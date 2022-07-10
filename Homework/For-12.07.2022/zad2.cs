int grade;
int badGrades = 0;
int allowedBadGrades;

double allGrades = 0;
double totalOfGrades = 0;

string mathEx = "";
string theExName;

Console.WriteLine("How many bad grades are allowed before the program stops?");
allowedBadGrades = int.Parse(Console.ReadLine());

do{
    theExName = mathEx;
    Console.WriteLine("What's the name of the math problem");
    mathEx = Console.ReadLine();

    if(mathEx == "Enough"){
        double averageScore = totalOfGrades/allGrades;
        Console.WriteLine("Average score: {0}", averageScore);
        Console.WriteLine("Number of problems: {0}", allGrades);
        Console.WriteLine("Last problem: {0}", theExName);
        Environment.Exit(0);
    }
    

    Console.WriteLine("What will the student's grade be");
    grade = int.Parse(Console.ReadLine());
    allGrades += 1;
    totalOfGrades += grade;

    if(grade <= 4){
        badGrades += 1;
    }
}
while(badGrades < allowedBadGrades);

Console.WriteLine("You need a break, {0} poor grades.", badGrades);