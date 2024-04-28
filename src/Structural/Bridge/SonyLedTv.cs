﻿namespace Bridge;

internal class SonyLedTv : ILEDTV
{
    public void SwitchOn()
    {
        Console.WriteLine("Turning ON : Sony TV");
    }
    public void SwitchOff()
    {
        Console.WriteLine("Turning OFF : Sony TV");
    }
    public void SetChannel(int channelNumber)
    {
        Console.WriteLine("Setting channel Number " + channelNumber + " on Sony TV");
    }
}