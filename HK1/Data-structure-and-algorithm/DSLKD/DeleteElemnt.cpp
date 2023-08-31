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

node *DeleteElement(node *l, int k){
    node *p = l;
    for(int i = 0; i < k-1; i++){
        p = p->next;
    }
    node *temp = p->next;
    p->next = temp->next;
    delete(temp);
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
    cout << "nhap vi tri muon xoa: "; int k; cin >> k;
    // if(k == 0)
    //     l = addHead(l, a);
    // else if(k<n)
    //     l = addAny(l, k, a);
    // else
    //     l = addTail(l, a);
    l = DeleteElement(l, k);
    printList(l);
    return 0;
}