﻿namespace APBD_2;

public class OverfillException:Exception
{
    public OverfillException(string? message) : base(message)
    {
    }
}