#include<iostream>
using namespace std;

typedef struct tagNode{
    int data;
    struct tagNode *pNext;
}Node;

typedef struct tagList{
    Node *pHead;
    Node *pTail;
}List;

Node *CreateNode(int x){
    Node *temp = new Node;
    temp->data = x;
    temp->pNext = NULL;
    return temp;
}

bool IsEmpty(List s){
    if(s.pHead==NULL)
        return true;
    return false;
}

void AddHead(List &s, Node *x){
    if(s.pHead == NULL){
        s.pHead = x;
        s.pTail = x;
    }else{
        x->pNext = s.pHead;
        s.pHead = x;
    }
}

void Push(List &s, int x){
    Node *new_element = CreateNode(x);
    AddHead(s, new_element);
}

int Pop(List &s, int &x){
    Node *p;
    if(!IsEmpty(s)){
        p = s.pHead;
        x = p->data;
        s.pHead = s.pHead->pNext;
    }
    if(s.pHead==NULL){
        s.pTail = NULL;
        delete p;
        return 1;
    }
    return 0;
}

void Input(List &s, int &n){
    int x;
    cout << "nhap so luong phan tu: ";
    cin >> n;
    cout << "---------\n";
    for(int i = 0; i < n; i++){
        cout << "phan tu thu " << i+1 << ": ";
        cin >> x;
        Push(s, x);
    }
}

void Output(List &s, int &n, int &t){
    int x;
    for(int i = 0; i < n; i++){
        Pop(s, x);
        t += x;
    }
    cout << "\n";
    cout << "tong la: " << t;

}

int main(){
    List s;
    int n;
    int t = 0;
    Input(s, n);
    Output(s, n, t);
    return 0;
}