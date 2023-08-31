#include <iostream>
using namespace std;

struct Node{
    int data;
    Node *next;
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

int main(){
    Linked_list list;
    create_list(list);
    Input(list);
    int k, x;
    cout << "nhap vi tri can chen: "; cin >>  k;
    cout << "nhap so can chen: "; cin >> x;
    Output(list);
    return 0;
}