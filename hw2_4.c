#include <stdio.h>

int main()
{
    int a=1;
    int b=0;
    int c=0;
    int d=1;
    if(((a&&b)||(c&&d))&&d)
    {
        printf("Lamp is on!\n");
    }
    else
    {
        printf("Lamp is off!");
    }
    return 0;
}