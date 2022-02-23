class Team{
    string name;

    public Team(string teamName){
        name = teamName;
    }
    static void Main(string[] args){
        Team Bats = new Team();
        Console.WriteLine(Bats.name);
    }
}