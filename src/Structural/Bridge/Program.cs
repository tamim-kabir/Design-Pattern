﻿using Bridge;

AbstractRemoteControl sonyRemoteControl = new SonyRemoteControl(new SonyLedTv());
sonyRemoteControl.SwitchOn();
sonyRemoteControl.SetChannel(101);
sonyRemoteControl.SwitchOff();

Console.WriteLine();

AbstractRemoteControl samsungRemoteControl = new SamsungRemoteControl(new SamsungLedTv());
samsungRemoteControl.SwitchOn();
samsungRemoteControl.SetChannel(202);
samsungRemoteControl.SwitchOff();
Console.ReadKey();
