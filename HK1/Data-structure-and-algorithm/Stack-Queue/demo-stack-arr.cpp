#include <iostream>
using namespace std;
#define max 5

typedef struct{
    int a[max];
    int t;
}Stack;

//Create Empty Stack.
void InitStack(Stack &s){
    s.t = -1;
}

//Check Empty Stack.
int IsEmpty(Stack &s){
    if(s.t == -1)
        return 1;
    return 0;
}

//Check Full Stack.
int IsFull(Stack &s){
    if(s.t == max-1)
        return 1;
    return 0;
}

//Push function
int Push(Stack &s, int x){
    if(IsFull(s)==0){
        s.t++;
        s.a[s.t]=x;
        return 1;
    }
    return 0;
}

//Pop function
int Pop(Stack &s){
    int x;
    if(IsEmpty(s)==0){
        x = s.a[s.t];
        s.t--;
        return x;
    }
    return 0;
}

int main(){
    Stack s;
    InitStack(s);
    int a, t = 0;
    for(int i = 0; i < max; i++){
        cin >> a;
        Push(s, a);
    }
    for(int i = s.t; i >-1; i--){
        t += Pop(s);
    }
    cout << t;
    return 0;
}