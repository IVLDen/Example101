//Задача  25

/*Console.WriteLine("Введите числа ");

int a;
int.TryParse (Console.ReadLine()!, out a);
int b;
int.TryParse (Console.ReadLine()!, out b);

int res = Kvadrat(a, b);

int Kvadrat (int _a, int _b) {

int t; t = _a;
for (int i = 1; i <_b; i++) {

 t = t * _a;

}

   return t;
}

Console.WriteLine(res); */

//Задача 27

/*Console.WriteLine("Введите число ");
int a;
int.TryParse (Console.ReadLine()!, out a);
int b = Summa (a);
Console.WriteLine(b);


int Summa (int _a) {
int t;
int sum = 0;

for ( t = _a; _a !=0; _a= _a/10) {
 
    t = _a%10;
    sum = sum + t;

}
return sum;
} */ 


//Задача 29

 /*int[] arr = new int[5];

void PutInMassive (int [] _arr) {
 
    int lenght = _arr.Length;
     
     Console.WriteLine("Заполните массив ");
     for ( int i = 0; i < lenght; i++ ) {
      
       int.TryParse (Console.ReadLine()!, out _arr[i]);
        }
}

void ShowMassive (int [] _arr) {

int lenght = _arr.Length;
for ( int i = 0; i < lenght; i++ ) {
      
       Console.WriteLine(_arr[i]);
        }
}


PutInMassive (arr);
Console.WriteLine();
Console.WriteLine();
ShowMassive (arr); */ 


