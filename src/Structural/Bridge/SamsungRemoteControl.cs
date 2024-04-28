﻿namespace Bridge;

internal class SamsungRemoteControl : AbstractRemoteControl
{
    public SamsungRemoteControl(ILEDTV ledTv)
    {
        this.ledTv = ledTv;
    }
    public override void SwitchOn()
    {
        ledTv.SwitchOn();
    }
    public override void SwitchOff()
    {
        ledTv.SwitchOff();
    }
    public override void SetChannel(int channelNumber)
    {
        ledTv.SetChannel(channelNumber);
    }
}
