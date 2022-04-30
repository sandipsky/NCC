using System;

public class ClassAndObject
{
    //constructors
    //1. Special function
    //2. can be called only once in its lifetime i.e during the instantiation of class
    //3. Name should be name as that of classname
    //4. does not have return type
    //5. can be overloaded
    
    public ClassAndObject()
    {
        
    }

    public ClassAndObject(int i)
    {
        this.i = i;
    }

    public ClassAndObject(string s, int x)
    {
        
    }

    public ClassAndObject(int x, string s)
    {
        
    }

    //variables //first priority

    public int i;
    //properties

    public string Sprop {get; set;}

    private string fname="";
    public string Fname{
        get{
            return fname;
        }
        set 
        {
            fname = value;
        }
    }
    //methods or functions
    //destructors
    //delegates and events

}