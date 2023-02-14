
int userChoice = 0;
Console.WriteLine("Enter the first input:");
userChoice = Convert.ToInt32(Console.ReadLine());
while(userChoice != 3){

    if(userChoice == 1) fullTriangle();
    if(userChoice == 2) partialTriangle();
    if(userChoice != 1 && userChoice != 2) Console.WriteLine("Invalid input please try again.");


    Console.WriteLine("Enter the next input:");
    userChoice = Convert.ToInt32(Console.ReadLine());
}

static void fullTriangle(){
    int rowNumbers = randomGenerator();

    for(int i = 0; i < rowNumbers; i++){
        for(int x = 0; x <= i; x++){
            Console.Write("O");
        }
        Console.WriteLine("");
    }
}

static void partialTriangle(){
    int rowNumbers = randomGenerator();
    Random rand = new Random();

    for(int i = 0; i < rowNumbers; i++){
        for(int x = 0; x <= i; x++){
            int check = rand.Next(2);
            if(check == 1) Console.Write("O");
        }
        Console.WriteLine("");
    }

}

static int randomGenerator(){
    Random rnd = new Random();
    int rows = rnd.Next(3,9);
    return rows;
}