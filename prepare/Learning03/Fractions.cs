using System;

public class Fractions{

    private int _top;
    private int _bottom;

    public Fractions(){

        _top = 1;
        _bottom = 1;
    }
    
    public Fractions(int integer){

        _top = integer;
        _bottom = 1;
    }

    public Fractions(int topNumber, int bottomNumber){

        _top = topNumber;
        _bottom = bottomNumber;
    }

    public string GetFractionString(){

        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue(){

        return (double)_top / (double)_bottom;
    }

};