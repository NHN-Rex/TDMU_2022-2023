#include<iostream>
using namespace std;

void delElement(int *arr, int start, int end){
    for(int i = start; i < end; i++){
        *(arr+i) = *(arr+i+1);
    }
}

void sort (int a[], int n){
    for (int i=0; i<n-1; i++)
        for (int j=i+1; j<n; j++)
            if (a[i] > a[j])
                swap(a[i], a[j]);
}

void mysort(int *arr, int n, int start, int end, int mid, int *result){
    if(n%2!=0) mid++;
    int x = 0, l = start+mid, r = end-mid;
    int a[l], b[r];
    for(int i = start; i < mid; i++){
        a[i] = *(arr+i);
    }
    for(int i = mid; i < end; i++){
        b[i-mid] = *(arr+i);
    }
    // for(int i = 0; i < mid; i++){
    //     cout << a[i] << " ";
    // }
    // cout << "\n";
    // for(int i = 0; i < mid-1; i++){
    //     cout << b[i] << " ";
    // }
    sort(a, mid);
    sort(b, end-mid);
    // for(int i = 0; i < mid; i++){
    //     cout << a[i] << " ";
    // }
    // cout << "\n";
    // for(int i = 0; i < mid-1; i++){
    //     cout << b[i] << " ";
    // }
    while(n!=0){
        if(a[0]<b[0]){
            *(result+x) = a[0];
            delElement(a, 0, mid);
            l--;
        }else{
            *(result+x) = b[0];
            delElement(b, 0, mid);
            r--;
        }
        x++;
        n--;
    }
}

void output(int b[], int n){
    for(int i = 0; i < n; i++){
        cout << b[i] << " ";
    }
}

int main(){
    int n = 5;
    int a[n] = {150, 170, 140, 160, 130};
    int b[n];
    mysort(a, n, 0, n, n/2, b);
    output(b, n);
    return 0;
}