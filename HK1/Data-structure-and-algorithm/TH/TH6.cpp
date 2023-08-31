#include<iostream>
using namespace std;

int linear_search(int a[], int n, int x){  
    for (int i = 0; i < n; i++) 
        if (a[i] == x) 
            return i; 
    return -1; 
}

int binary_search(int a[], int n, int x){
    int m, l = 0, r = n-1;
    while(l < r){
        m = (l+r)/2;
        if(a[m]==x) return m;
        if(a[m] < x) l = m+1;
        else r = m-1;
    }
    return -1;
}

void swap(int &a, int &b){
    int t = a; a = b; b = t;
}

void insertion_sort(int a[], int n){
    int x, j;
    for(int i = 1; i < n; i++){
        x = a[i];
        for(j = 0; a[j] > x && j > 0; j--){
            if(a[j] < a[j-1]) a[j] = a[j-1];
        }
        a[j] = x;
    }
}

void selection_search(int a[], int n){
    for(int i = 0; i < n; i++){
        int min = i;
        for(int j = i+1; j < n; j++){
            if(a[min] > a[j]) min = j;
        }
        swap(a[i], a[min]);
    }
}

void Interchange_Sort(int a[], int n){
    for(int i = 0; i < n-1; i++){
        for(int j = i+1; j<n; j++){
            if(a[i]>a[j])
                swap(a[i], a[j]);
        }
    }
}

void Bubble_Sort(int a[], int n){
    for(int i = 0; i < n-1; i++){
        for(int j = n-1; j > i; j--){
            if(a[j] < a[j-1])
                swap(a[j], a[j-1]);
        }
    }
}

struct Stack{
    int a[5];
    int t;
};

int initStack(Stack s){
    s.t = -1;
    return 1;
}

bool Isempty(Stack s){
    if(s.t == -1) return true;
    return false;
}

bool Isfull(Stack s){
    if(s.t = 4) return true;
    return false;
}

bool Push(Stack s, int x){
    if(!Isfull(s)){
        s.a[s.t] = x;
        s.t++;
        return true;
    }
    return false;
}

bool Pop(Stack s, int x){
    if(!Isempty(s)){
        x = s.a[s.t];
        s.t--;
        return true;
    }
    return false;
}

struct Queue{
    int First;
    int Last;
    int Element[10];
};

void Create(Queue &Q){
    Q.First=0;
    Q.Last=-1;
}

int Empty(Queue Q){
    return Q.First>Q.Last?1:0;
}

void Add(int x, Queue &Q){
    if(Q.Last==4) return;
    else{
    Q.Last++;
    Q.Element[Q.Last]=x;
    }
}

void Remove(int &x,Queue &Q){
    if(Empty(Q)) return;
    x=Q.Element[Q.First];
    Q.First++;
}

struct Node{
    int data;
    Node *pnext;
};

Node *createNode(int x){
    Node *temp = new Node;
    temp->data = x;
    temp->next = NULL;
    return temp;
}

struct Linked_list{
    Node *phead;
    Node *ptail;
};

void create_list(Linked_list &l){
    l.phead = NULL;
    l.ptail = NULL;
}

void Add_head(Linked_list &l, Node *x){
    if(l.phead = NULL){
        l.phead = x;
        l.ptail = x;
    }else{
        x->next = l.phead;
        l.phead = x;
    }
}

void Add_tail(Linked_list &l, Node *x){
    if(l.ptail == NULL){
        l.phead = x;
        l.ptail = x;
    }else{
        l.ptail->next = x;
        l.ptail = x;
    }
}

void Add_any(Linked_list &l, Node *q, Node *x){
    if(q != NULL){
        x->next = q->next;
        q->next = x;
        if(l.ptail == q) l.ptail = x;
    }else{
        Add_head(l, x);
    }
}

void Input(Linked_list &l){
    Node *p = new Node;
    for(int i = 0; i < 5; i++){
        int x;
        cout << "nhap x{" << i + 1<< "}: "; cin >> x;
        p = createNode(x);
        Add_tail(l, p);
    }
}

void Output(Linked_list &l){
    Node *p = new Node;
    for(p = l.phead; p != NULL; p = p->next){
        cout << p->data << "; ";
    }
}

//BNT

struct Node{
	int data;
	Node *pleft, *pright;
};

void Create_Tree(Node *&t){
	t = NULL;
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
		cout << t->data << " ";
		NLR(t->pleft);
		NLR(t->pright);
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


void FindNode(Node *&x, Node *&y){
	if(y->pleft != NULL)
		FindNode(x, y->pleft); 
	else{
		x->data = y->data;
		x = y;
		y = y->pright; 
	}
}

void DelNode(Node *&t, int x){
	if(t == NULL) return;
	if(x < t->data)
		DelNode(t->pleft, x); 
	else if(x > t->data)
		DelNode(t->pright, x); 
	else{ 
		Node *p = t;
		if(t->pleft == NULL) 
			t = t->pright; 
		else if(t->pright == NULL)
			t = t->pleft;
		else 
			FindNode(p, t->pright); 
		delete p;
	}
}