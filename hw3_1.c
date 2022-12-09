#include <stdio.h>

int main()
{
	int i;
	for (i = 0; i <= 20; i++)
	{
		printf("%d ", i);
	}
	printf("\n");

	i = 20;
	while(i<=30)
	{
		printf("%d ", i++);
	}
	printf("\n");

	for (i =10; i <= 100; i+=5)
	{
		printf("%d ", i);
	}
	printf("\n");

	i = 20;
	do
	{
		printf("%d ", i--);
	} while (i >= 10);
	printf("\n");

	i = 1000;
	do
	{
		printf("%d ", i);
		i -= 100;
	} while (i >= 0);
	printf("\n");


	return 0;
}