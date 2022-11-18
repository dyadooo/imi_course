#include <stdio.h>

int main()
{
    int num1 = -20;
    int num2=30;
    printf("Number 1 = %d, Number 2 = %d\n",num1,num2);

    int temp=num1;
    num1=num2;
    num2=temp;

    printf("Number 1 = %d, Number 2 = %d\n",num1,num2);

    return 0;
}