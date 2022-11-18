#include <stdio.h>

int main()
{
    int heigth=0,length1=0,length2=0;
    printf("\nВъведете долна основа ");
    scanf("%d",&length1);
     printf("\nВъведете горна основа ");
    scanf("%d",&length2);
    printf("\nВъведете височината ");
    scanf("%d",&heigth);
    printf("\nРезултат: лице %d",heigth*(length1+length2)/2);
    return 0;
}