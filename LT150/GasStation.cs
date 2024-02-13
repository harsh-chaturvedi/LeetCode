namespace LT150;
//https://leetcode.com/problems/gas-station/description/?envType=study-plan-v2&envId=top-interview-150
public static class GasStation
{
    public static int CanCompleteCircuit(int[] gas, int[] cost)
    {
        int len = gas.Length;
        int init = -1;
        int currentTank = 0;
        int looper = 0;

        //first loop to start through all elements
        // if init is -1 by end of this loop, i.e. no path exists
        for (int i = 0; i < len && looper < len; i++, looper++)
        {
            //first point where we can start travelling
            if (gas[i] + currentTank > cost[i])
            {
                // looper = 0;
                init = i;
                while (true)
                {
                    // looper++;
                    //journey has started, break in journey
                    if (gas[i] + currentTank < cost[i])
                    {
                        //false path if beginning, reset init and continue search
                        if (i < len)
                        {
                            init = -1;
                            currentTank = 0;
                            break;
                        }
                        else
                            return -1;
                    }
                    currentTank += gas[i] - cost[i];
                    i = ++i % len;

                    if (i == init)
                        return init;

                    
                }
            }
        }

        return init;
    }
}