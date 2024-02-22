using System;

public class CarNameChangingEventArgs : EventArgs
{
    private string _oldName;
    private string _newName;

    public CarNameChangingEventArgs(string OldName, string NewName)
    {
        _oldName = OldName;
        _newName = NewName;
    }

    public string OldName => _oldName;
    public string NewName => _newName;
    
}