namespace CDAC1collection;
using System.Collections;
public class Player1 : IComparable
{
        public string? name;
    public int run;
    public int matches;
    public int age;

    public Player1(string name,int run,int matches,int age){
        this.name=name;
        this.matches=matches;
        this.run=run;
        this.age=age;
        
        
    }
    public int CompareTo(object? obj)
    {
        Player1 anotherPlayer=(Player1)obj;

        if(this.matches > anotherPlayer.matches){
            return 1;
        }
        else if (this.matches < anotherPlayer.matches){
            return -1;
        }
        else
          return 0;
    }
}