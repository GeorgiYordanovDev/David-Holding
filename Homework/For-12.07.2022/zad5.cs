int num;
do{
    Console.WriteLine("Put in a number between 1 and 600000");
    num = int.Parse(Console.ReadLine());
}while(num < 1 || num > 600000);
int check = 0;

for(int i = 1111; i < 9999; i++){

    string y = i.ToString();

    for(int x = 0; x < y.Length; x++){
        int digit = int.Parse(y[x].ToString());
        if(digit != 0){
            if(num % digit == 0){
                check += 1;
            }
        }
        else{
            check += 1;
        }
    }
    if(check == 4){
        Console.WriteLine(i);
    }
    check = 0;
    
}