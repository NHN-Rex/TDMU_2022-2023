#include <iostream>
using namespace std;

struct Node{
	int data;
	Node *pleft, *pright;
};

void Create_Tree(Node *&t){
	t = NULL; // Cay rong.
}

void AddNode(Node *&t, int x){
	if(t==NULL){
		Node *p = new Node;
		p->data = x;
		p->pleft = NULL;
		p->pright = NULL;
		t = p;
	}else{
		if(t->data > x)	AddNode(t->pleft, x);
		else if(t->data < x)	AddNode(t->pright, x);
	}
}

void NLR(Node *&t){
	if(t != NULL){
		cout << t->data << " "; //xuat du lieu trong note
		NLR(t->pleft); //duyet qua trai
		NLR(t->pright); //duyet qua phai
	}
}

void LRN(Node *&t){
	if(t != NULL){
		LRN(t->pleft);
		LRN(t->pright);
		cout << t->data << " "; 
	}
}

void LNR(Node*&t){
	if(t != NULL){
		LNR(t->pleft);
		cout << t->data << " ";
		LNR(t->pright);
	}
}

Node *SearchNode(Node *t, int x){
	if(t != NULL){
		if(t->data == x) return t;
		if(t->data > x) return SearchNode(t->pleft, x);
		return SearchNode(t->pright, x);
	}
	return NULL;
}

void FindNode(Node *&x, Node *&y){
	if(y->pleft != NULL)/*con nhanh trai*/
		FindNode(x, y->pleft); /*tim nut trai nhat*/
	else{/*Tìm thấy nút trái nhất*/
		x->data = y->data;
		x = y;
		y = y->pright; /*cập nhật lại nút cha của nút cần xoá*/
	}
}

/*Xoá nút bất kỳ trong cây nhị phân tìm kiếm*/
void DelNode(Node *&t, int x){
	if(t == NULL) return;
	if(x < t->data)
		DelNode(t->pleft, x); /*Duyệt sang nhánh trái của cây*/
	else if(x > t->data)
		DelNode(t->pright, x); /*Duyệt sang nhánh phải của cây*/
	else{ /*Tìm Thấy nút cần xoá*/
		Node *p = t; /*Nút thế mạng p*/
		if(t->pleft == NULL) /*Nút có một con bên phải hoặc là nút lá*/
			t = t->pright; /*Duyệt sang phải của nút*/
		else if(t->pright == NULL)
			t = t->pleft; /*Duyệt sang trái của nút*/
		else /*Nút có 2 con*/
			FindNode(p, t->pright); /*Tìm nút trái nhất của cây con bên phải*/
			/*Tìm nút phải nhất của cây con bên trái
			FindNode(p, t->pleft)*/
		delete p;
	}
}

void input(Node *&t){
	int n;
	int x;
	cout << "nhap so nut: ";
	cin >> n;
	for(int i = 0; i < n; i++){
		cout << "nhap nut " << i+1 << ": ";
		cin >> x;
		AddNode(t, x);
	}
}

int main(){
	Node *Tree;
	Create_Tree(Tree);
	input(Tree);
	LNR(Tree);
	return 0;
}
