#include <iostream>
using namespace std;

void merge(int a[], int l, int m, int h){
    int  i, j, k = l;
    int n1 = m-l+1;
    int n2 = h - m;
    int *L = new int[n1];
    int *R = new int[n2];
    for(i = 0; i < n1; i++){
        L[i] = a[l+i];
    }
    for(j = 0; j < n2; j++){
        R[j] = a[m+j+1];
    }
    i = 0; j = 0;
    while(i < n1 && j < n2){
        if(L[i] <= R[j]){
            a[k] = L[i];
            i++;
        }else{
            a[k] = R[j];
            j++;
        }
        k++;
        /*Viết tắt 18-25*/
        /*a[k++] = (L[i] <= R[j]) ? L[i++] : R[j++];*/
    }
    while(i < n1){
        a[k] = L[i];
        k++;
        i++;
        /*Viết tắt 30-32*/
        /*a[k++] = L[i++];*/
    }
    while(j < n2){
        a[k] = R[j];
        k++;
        j++;
        /*Viết tắt 37-39*/
        /*a[k++] = R[j++];*/
    }
}

void Merge_Sort(int a[], int l, int h){
    if(l < h){
        int m = l + (h - l)/2;
        Merge_Sort(a, l, m);
        Merge_Sort(a, m+1, h);
        merge(a, l, m, h);
    }
}

int main(){
    int a[10]{9, 5, 7, 8, 2, 1, 3, 10, 6, 4};
    Merge_Sort(a, 0, 9);
    for(int i = 0; i < 10; i++){
        cout << a[i] << "; ";
    }
    return 0;
}