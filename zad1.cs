double Spring = 3000;
double Summer = 4200;
double Autumn = 4200;
double Winter = 2600;

int fishermen;
int budget;
string season;
double total;


do{
    Console.WriteLine("What's their budget?");
    budget = int.Parse(Console.ReadLine());
}
while((budget < 1) || (budget > 8000));

do{
    Console.WriteLine("What's the season?");
    season = Console.ReadLine();
}
while((season != "Spring") && (season != "Summer") && (season != "Autumn") && (season != "Winter"));

do{
    Console.WriteLine("How many fishermen are in the group?");
    fishermen = int.Parse(Console.ReadLine());
}
while((fishermen < 4) || (fishermen > 18));



// Discounts
if((fishermen >= 4) && (fishermen <= 6)){
    Spring *= 0.9;
    Summer *= 0.9;
    Autumn *= 0.9;
    Winter *= 0.9;
}
else if((fishermen >= 7) && (fishermen <= 11)){
    Spring *= 0.85;
    Summer *= 0.85;
    Autumn *= 0.85;
    Winter *= 0.85;
}
else if((fishermen >= 12) && (fishermen <= 18)){
    Spring *= 0.75;
    Summer *= 0.75;
    Autumn *= 0.75;
    Winter *= 0.75;
}
else{
    Console.WriteLine("Fishermen should be between 4 and 18.");
}

if(fishermen % 2 == 0){
    Spring *= 0.95;
    Summer *= 0.95;
    Winter *= 0.95;
}
else{
    Console.WriteLine("No 5% discount!");
}

if(season == "Spring"){
    total = budget - Spring;
    if(total >= 0){
        Console.WriteLine("Yes! You have {0} leva left!", total);
    }
    else{
        Console.WriteLine("Not enough money! You need {0} leva.", (total * -1));
    }
}
if(season == "Summer"){
    total = budget - Summer;
    if(total >= 0){
        Console.WriteLine("Yes! You have {0} leva left!", total);
    }
    else{
        Console.WriteLine("Not enough money! You need {0} leva.", (total * -1));
    }
}
if(season == "Autumn"){
    total = budget - Autumn;
    if(total >= 0){
        Console.WriteLine("Yes! You have {0} leva left!", total);
    }
    else{
        Console.WriteLine("Not enough money! You need {0} leva.", (total * -1));
    }
}
if(season == "Winter"){
    total = budget - Winter;
    if(total >= 0){
        Console.WriteLine("Yes! You have {0} leva left!", total);
    }
    else{
        Console.WriteLine("Not enough money! You need {0} leva.", (total * -1));
    }
}