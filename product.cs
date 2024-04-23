#include <stdio.h>

#include <stdio.h>

void main ()

{
int number1, number2, product;

number1 = number2 = product= 0;

//printf ("Enter the First Number: " );

scanf("%d", &number1);

//printf ("Enter the Second Number: " );

scanf("%d", &number2);

product = number1 * number2;

if (product == 1000)

{
printf("\n Product of %d and %d is equal to 1000" , number1, number2);
}

else if (product >1000)

{

printf("\n Product of %d and %d is greater than 1000" , number1, number2);

}

else
	{
printf("\n Product of %d and %d is less than 1000" , number1, number2);

}

}
