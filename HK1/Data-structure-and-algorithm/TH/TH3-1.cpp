#include<iostream>
using namespace std;

void minisort(int *Arr, int n , int start, int end) {
    int min;
    for(int i = start; i <= end; i++){
        min = i;
        for(int j = i+1; j <= end; j++){
            if(*(Arr+min) > *(Arr+j))
                min = j;
        }
        if(min != i){
            int t = *(Arr+i);
            *(Arr+i) = *(Arr+min);
            *(Arr+min) = t;
        };
    }
}

void output(int a[], int n){
    for(int i = 0; i < n; i++){
        cout << a[i] << " ";
    }
}

int main(){
    int n = 10;
    int a[n] = {150, 170, 160, 140, 130, 110, 180, 190, 200, 120};
    minisort(a, n, 2, 4);
    output(a, n);
    return 0;
}