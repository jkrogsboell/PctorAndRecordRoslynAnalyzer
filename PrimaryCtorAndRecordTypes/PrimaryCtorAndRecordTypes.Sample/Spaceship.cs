using System;

namespace PrimaryCtorAndRecordTypes.Sample;

public class Spaceship(int tester)
{
    public void SetSpeed(long speed)
    {
        if (speed > 299_792_458)
            throw new ArgumentOutOfRangeException(nameof(speed));
    }
}

public class PCTEst(int tester)
{
    
}