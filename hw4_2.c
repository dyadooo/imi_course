
#include <stdio.h>
#include <stdlib.h>
#include <time.h>


int main(){

    int numbers[100];
    int min=10,max=-10;
    double average=0;
    srand(time(NULL));
    printf("The numbers are\n");
    for(int i=0;i<100;i++)
    {
        numbers[i]=-10+rand()%21;
        if(numbers[i]>max) max=numbers[i];
        if(numbers[i]<min) min=numbers[i];
        printf("%d\t",numbers[i]);
        if(!((i+1)%10))
        {
            printf("\n");
        }
    }
    printf("\nmin=%d, max=%d",min,max);

    return 0;
}
