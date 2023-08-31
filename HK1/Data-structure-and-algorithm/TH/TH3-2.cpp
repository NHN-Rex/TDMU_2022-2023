#include<iostream>
using namespace std;

void delElement(int *arr, int size){
    for(int i = 0; i < size; i++){
        *(arr+i) = *(arr+i+1);
    }
}
void output(int b[], int n){
    for(int i = 0; i < n; i++){
        cout << b[i] << " ";
    }
}

void mysort(int *arr, int n, int start, int end, int mid, int *result){
    cout << mid << "\n";
    int x = 0;
    int sa = mid-start;
    int sb = end-mid;
    int arr_left[sa];
    int arr_right[sb];
    for(int i = start; i <= mid; i++){
        arr_left[i] = *(arr+i);
    }  
    for(int i = start; i < end-mid; i++){
        arr_right[i] = *(arr+i+mid);
    }
    cout  << "left: ";
    for(int i = 0; i < sa; i++){
        cout << arr_left[i] << ";" << "\n"  ;
    }
    cout << "right: ";
    for(int i = 0; i < sb; i++){
        cout  << arr_right[i] << "; " << "\n";
    }

    while(sa != 0 && sb != 0){
        if(arr_left[0] < arr_right[0]){
            *(result+x) = arr_left[0];
            delElement(arr_left, sa);
            sa--;
        }else{
            *(result+x) = arr_right[0];
            delElement(arr_right, sb);
            sb--;
        }
        x++;
    }
    if(sa != 0){
        while(sa != 0){
            *(result+x) = arr_left[0];
            delElement(arr_left, sa);
            sa--;
        }
    }else{
        while(sb != 0){
            *(result+x) = arr_right[0];
            delElement(arr_right, sb);
            sb--;
        }
    }
    // for(int i = 0; i < n; i++){
    //     cout << *(result + i) << "; ";
    // }
}



int main(){
    int n = 5;
    int a[n] = {150, 170, 140, 160, 130};
    int b[n];
    mysort(a, n, 0, n, n/2, b);
    // output(b, n);
    return 0;
}