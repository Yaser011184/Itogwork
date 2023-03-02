// Код для решения задачи на скалярное произведение на языке C#

int [] firstVector = {1 , 8};
int [] secondVector = {6 , 3};
int size = 2;
int scalarProdact = 0;

for (int index = 0; index < size; index++)
{
    scalarProdact = scalarProdact + firstVector[index] * secondVector[index];
}

Console.WriteLine(scalarProdact);