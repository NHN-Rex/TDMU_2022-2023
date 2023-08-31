#include<iostream>
using namespace std;

struct node{
    int data;
    node *next;
};

node *createnode(int x){
    node *temp = new node;
    temp->data = x;
    temp->next = NULL;
    return temp;
}

struct list{
    node *head;
    node *tail;
};

void createlist(list &l){
    l.head = NULL;
    l.tail = NULL;
}

void addhead(list &l, node *x){
    if(l.head == NULL){
        l.head = x;
        l.tail = x;
    }else{
        x->next = l.head;
        l.head = x;
    }
}

void addtail(list &l, node *x){
    if(l.tail == NULL){
        l.head = x;
        l.tail = x;
    }else{
        l.tail->next = x;
        l.tail = x;
    }
}

void addafternode(list &l, node *x, node *k){
    if(k != NULL){
        x->next = k->next;
        k->next = x;
        if(k == l.tail) l.tail = x;
    }else{
        addhead(l, x);
    }
}

void deletehead(list &l){
    if(l.head != NULL){
        node *temp = l.head;
        l.head = l.head->next;
        free(temp);
    }
}

void deleteafternode(list &l, node *k){
    if(k != NULL){
        node *temp = k->next;
        if(temp != NULL) k->next = temp->next;
        free(temp);
    }
}

void deletenodex(list &l, int x){
    node *temp1, *temp2;
    for(temp1 = l.head; temp1!=NULL; temp1 = temp1->next){
        if(temp1->data == x) break;
        temp2 = temp1;
    }
    if(temp1 != NULL){
        deleteafternode(l, temp1);
    }
}

void input(list &l){
    int x, n;
    cout << "nhap so luong node: "; cin >> n;
    for(int i = 0; i < n; i++){
        cout << "nhap data node " << i+1 <<": "; cin >> x;
        node *p = createnode(x);
        addhead(l, p);
    }
}

void output(list &l){
    node *temp = l.head;
    for(temp; temp != NULL; temp = temp->next){
        cout << temp->data << "; ";
    }
}

int main(){
    list l;
    createlist(l);
    input(l);
    output(l);
    return 0;
}