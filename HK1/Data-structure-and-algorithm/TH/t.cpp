#include<iostream>
using namespace std;

void delElement(int *arr, int start, int end){
    for(int i = start; i < end; i++){
        *(arr+i) = *(arr+i+1);
    }
}

void mysort(int *arr, int n, int start, int end, int mid, int *result){
    if(n%2!=0) mid++;
    int x = 0, l = start+mid, r = end-mid;
    int a[l], b[r];
    int s_a = sizeof(a)/sizeof(int);
    int s_b = sizeof(b)/sizeof(int);
    for(int i = start; i < mid; i++){
        a[i] = *(arr+i);
    }
    for(int i = mid; i < end; i++){
        b[i-mid] = *(arr+i);
    }
    while(s_a != 0 or s_b != 0){
        if(a[0]<b[0]){
            *(result+x) = a[0];
            delElement(a, 0, mid);
            s_a--;
            l--;
        }else{
            *(result+x) = b[0];
            delElement(b, 0, mid);
            s_b--;
            r--;
        }
        x++;
        n--;
    }
    if(s_a != 0){
        while(s_a != 0){
            *(result+x) = a[0];
            s_a--;
        }
    }else{
        while(s_b!=0){
            *(result+x) = b[0];
            s_b--;
        }
    }
}

void output(int b[], int n){
    for(int i = 0; i < n; i++){
        cout << b[i] << " ";
    }
}

int main(){
    int n = 5;
    int a[n] = {150, 170, 160, 140, 130};
    int b[n];
    int s_a = sizeof a / sizeof(int);
    for(int x = 0; x < n; x++){
        for(int i = 0; i < 5; i++){
            a[i] = a[i+1];
        }
        s_a--;
        cout << s_a << "\n";
        output(a, s_a);
        cout << "\n";
    }
    // mysort(a, n, 0, n, n/2, b);
    return 0;
}