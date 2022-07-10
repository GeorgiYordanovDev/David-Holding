string steps;
int totalSteps = 0;
int toHome;

do{
    steps = Console.ReadLine();
    if(steps == "Going home"){
        Console.WriteLine("How many steps to the home? ");
        toHome = int.Parse(Console.ReadLine());
        totalSteps += toHome;
        break;
    }
    totalSteps += int.Parse(steps);
}
while(totalSteps <= 10000);

int afterSteps = totalSteps - 10000;
if(afterSteps >= 0){
    Console.WriteLine("Goal reached! Good job!");
    Console.WriteLine("{0} steps over the goal!", afterSteps);
}
else{
    Console.WriteLine("Goal reached!");
    Console.WriteLine("{0} steps more to reach the goal!", (afterSteps * -1));
}