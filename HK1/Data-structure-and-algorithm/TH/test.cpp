#include<iostream>
using namespace std;

void abc(int *arr, int n, int a, int b, int *brr){
    for(int i = 1; i < n; i++){
        *(arr+i) = *(arr+i+1);
    }
    n--;
}

int main(){
    cout << 5/2;
    return 0;
}