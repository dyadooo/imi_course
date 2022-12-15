
#include <stdio.h>


int main(){

    int numbers[]={10,20,5,6,78,101};
    int sum=0,product=1;
    double average=0;
    for(int i=0;i<6;i++)
    {
        sum+=numbers[i];
        product*=numbers[i];
    }
    printf("Sum=%d, Product=%d, Average=%lf",sum,product,(double)sum/6);

    return 0;
}
