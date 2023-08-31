#include<iostream>
using namespace std;

typedef struct tagNode{
    int info;
    struct tagNode *pNext;
}Node;

typedef struct tagList{
    Node *pHead;
    Node *pTail;
}List;

//Create Node Function
Node *CreateNode(int x){
    Node *temp = new Node;
    temp->info = x;
    temp->pNext = NULL;
    return temp;
}

//Check Empty Linked list
bool IsEmpty(List s){
    if(s.pHead==NULL)
        return true;
    return false;
}

// Add Head Function
void AddHead(List &s, Node *x){
    if(IsEmpty){
        s.pHead = x;
        s.pTail = x;
    }else{
        x->pNext = s.pHead;
        s.pHead = x;
    }
}

//Push Function
void Push(List &s, int x){
    Node *new_element = CreateNode(x);
    AddHead(s, new_element);

}

//Pop Function
int Pop(List &s, int &x){
    Node *p;
    if(!IsEmpty(s)){
        p = s.pHead;
        x = p->info;
        s.pHead = s.pHead->pNext;
    }
    if(s.pHead==NULL){
        s.pTail = NULL;
        delete p;
        return 1;
    }
    return 0;
}

//Top Function
int Top(List &s){
    if(!IsEmpty(s))
        return s.pHead->info;
    return NULL;
}

int main(){
    List s;
    return 0;
}