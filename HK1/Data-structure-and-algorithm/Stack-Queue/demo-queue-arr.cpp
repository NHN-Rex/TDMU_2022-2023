#include<iostream>
using namespace std;
#define max 100

typedef struct tagQueue{
    int a[max];
    int f; //index head element
    int r; //index tail element
}Queue;

void InitQueue(Queue &q){
    q.f = q.r = -1;
}

char IsEmpty(Queue &q){
    return (q.a[q.f]==NULLDATA);
}

char IsFull(Queue &q){
    return (q.a[q.r] != NULLDATA);
}

char EnQueue(Queue &q, Data x){
    if(IsFull(q)) return -1;
    q.a[q.r++] = x;
    if(q.r==max)
        q.r = 0;
}

Data DeQueue(Queue &q){
    if(IsEmpty(q)) return NULLDATA;
    x = q.a[q.f];
    q.a[q.f++] = NULLDATA;
    if(q.f == max)
        q.f = 0;
    return 0;
}

int main(){
    Queue q;
    return 0;
}