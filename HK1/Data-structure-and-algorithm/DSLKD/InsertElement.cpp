#include<iostream>
using namespace std;

struct node{
    int data;
    node *next;
};

node *createNode(int x){
    node *temp = new node;
    temp->data = x;
    temp->next = NULL;
    return temp;
}

node *addElement(node *l, int x){
    node *temp = createNode(x);
    l->next = temp;
    return temp;
}

void printList(node *l){
    node *p = l;
    while(p != NULL){
        cout << p->data << " ";
        p = p->next;
    }
}

node *addHead(node *l, int x){
    node *temp = new node;
    temp ->data = x;
    temp -> next = l;
    l = temp;
    return l;
}

node *addAny(node *l, int k, int x){
    node *p = l;
    for(int i = 1; i < k-1; i++){
        p = p->next;
    }
    node *temp = new node;
    temp->data = x;
    temp->next = p->next;
    p->next = temp;
    return l;
}

node *addTail(node *l, int x){
    node *p = l;
    while(p->next != NULL){
        p = p->next;
    }
    node *temp = new node;
    temp->data = x;
    temp->next = p->next;
    p->next = temp;
    return l;
}

int main(){
    int n, x;
    cin >> n;
    cin >> x;
    node *l = createNode(x);
    node *p = l;
    for(int i = 1; i < n; i++){
        cin >> x;
        p = addElement(p, x);
    }
    cout << "nhap vi tri: "; int k; cin >> k;
    cout << "nhap so muon them: "; int a; cin >> a;
    if(k == 0)
        l = addHead(l, a);
    else if(k<n)
        l = addAny(l, k, a);
    else
        l = addTail(l, a);
    printList(l);
    return 0;
}