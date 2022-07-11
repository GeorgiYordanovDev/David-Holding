int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());

for(int i = first; i <= second; i++){
    string n = i.ToString();
    int odds = 0;
    int evens = 0;

    for(int x = 0; x < n.Length; x++){
        int digit = int.Parse(n[x].ToString());
        if(x % 2 == 0){
            evens += digit;
        }
        else{
            odds += digit;
        }
    }
    if(odds == evens){
        Console.WriteLine(i);
    }
}