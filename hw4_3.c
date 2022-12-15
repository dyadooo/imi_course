#include <stdio.h>

int main(){

    double numbers[10];
    double sum=0;
    int count=0;
    for(int i=0;i<10;i++)
    {
        printf("Enter number %d: ",i+1);
        scanf("%lf",numbers + i);       
    }
    printf("\nThe numbers are ");
    for(int i=0;i<10;i++)
    {
        printf("%.2lf ",numbers[i]);
        if(numbers[i]>5&&numbers[i]<10)
        {
            sum+=numbers[i]; count++;
        }
    }
    printf("\ncount=%d, sum=%.2lf",count,sum);

    return 0;
}

