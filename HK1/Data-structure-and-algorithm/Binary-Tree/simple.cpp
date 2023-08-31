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
