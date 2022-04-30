using System;

public class MarksInfo
{
    private double _fullMarks = 100;
    private double _passMarks = 32;
    private double _minMarks = 0;
    private double _scienceMarks;
    private double _mathMarks;
    public double ScienceMarks
    {
        get 
        {
            return _scienceMarks;
        }
        set
        {
            if (value >_fullMarks)
            {
                _scienceMarks = _fullMarks;
            }
            else if(value < _minMarks)
            {
                _scienceMarks = _minMarks;
            }
            else
            {
                _scienceMarks = value;
            }
        }
    }
    public double MathMarks
    {
        get => _mathMarks;
        set
        {
           _mathMarks = (value > _fullMarks) ? _fullMarks : (value < _minMarks) ? _minMarks : value;
        }
    }
    

    public double Total => ScienceMarks + MathMarks;
}