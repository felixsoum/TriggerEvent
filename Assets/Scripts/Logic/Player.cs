using System;

public class Player
{
    public event Action<int> RaiseHpUpdate;
    private int hp = 100;

    public int Hp
    {
        get
        {
            return hp;
        }
        set
        {
            hp = value;
            RaiseHpUpdate(hp);
        }
    }
}
