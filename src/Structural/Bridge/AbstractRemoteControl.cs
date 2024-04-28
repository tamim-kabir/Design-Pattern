﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge;

internal abstract class AbstractRemoteControl
{
    protected ILEDTV ledTv;
    public abstract void SwitchOn();
    public abstract void SwitchOff();
    public abstract void SetChannel(int channelNumber);
}
