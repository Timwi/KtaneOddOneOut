using System;

sealed class StageInfo
{
    public int CorrectIndex;
    public Action<OddOneOutModule, int> Setup;
    public string Logging;
}