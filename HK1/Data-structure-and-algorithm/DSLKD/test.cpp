#include<iostream>
using namespace std;

struct node{
    int data;
    node *next;
};

node *CreateNode(int x){
    node *temp = new node;
    temp->data = x;
    temp->next = NULL;
}

node *addell(int x, node *l){
    node *temp = CreateNode(x);
    l->next = temp;
    return temp;
}

void printlist(node *l){
    node *p = l;
    while(p != NULL){
        cout << p->data << " ";
        p = p->next;
    }
}

int tongmu(int c, node *l){
    node *p = l;
    int s = 0, a = 1;
    while(p != NULL){
        int x = p->data;
        a = 1;
        for(int i = 1; i <= x; i++){
            a *= c;
        }
        s += a;
        p = p->next;
    }
    return s;
}

int main(){
    int n, x, c;
    cin >> n;
    cin >> x;
    node *l = CreateNode(x);
    node *p = l;
    for(int i = 1; i < n; i++){
        cin >> x;
        p = addell(x, p);
    }
    cout << "nhap co so: ";
    cin >> c;
    cout << tongmu(c, l);
    // printlist(l);
    return 0;
}