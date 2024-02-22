using System;

public class CarSpeedEventArgs : EventArgs
{
    private int _speed;
    public CarSpeedEventArgs(int Speed)
    {
        _speed = Speed;
    }

    public int Speed
    {
        get => _speed;
    }
}