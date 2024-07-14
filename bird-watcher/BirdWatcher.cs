using System;

class BirdCount
{
    private int[] _birdsPerDay;

    public BirdCount(int[] birdsPerDay) => this._birdsPerDay = birdsPerDay;

    public static int[] LastWeek() => new[] {0,2,5,3,7,8,4};

    public int Today() => this._birdsPerDay[this._birdsPerDay.Length - 1];

    public void IncrementTodaysCount() {
        this._birdsPerDay[this._birdsPerDay.Length - 1] += 1;
    }

    public bool HasDayWithoutBirds()
    {
        for(int i = 0; i<this._birdsPerDay.Length;i++)
            if(this._birdsPerDay[i] == 0) return true;
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int contadorPassaros = 0;
        for(int i = 0; i<numberOfDays; i++) contadorPassaros += this._birdsPerDay[i];
        
        return contadorPassaros;
    }

    public int BusyDays()
    {
        int contadorDiasDificeis = 0;
        for(int i = 0; i<this._birdsPerDay.Length;i++)
            if(this._birdsPerDay[i] >= 5) contadorDiasDificeis++;

        return contadorDiasDificeis;
    }
}
