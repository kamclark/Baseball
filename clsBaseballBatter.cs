using System;
using System.Collections.Generic;
using System.Text;

public class clsBaseballBatter
{
    // =============== symbolic constants ===================
    public const int TRIPLE_PROBABILITY_BOUND =     4607745;  // 
    public const int HITBYPITCH_PROBABILITY_BOUND = 8466822; //
    public const int HR_PROBABILITY_BOUND =         24921245; //
    public const int DOUBLE_PROBABILITY_BOUND =     44522245; // 
    public const int WALK_PROBABILITY_BOUND =       78427508; // 
    public const int SINGLE_PROBABILITY_BOUND =     153353997; //
    public const int STRIKEOUT_PROBABILITY_BOUND =  199964917; //
    public const int OUT_PROBABILITY_BOUND =        494202343; // 

    public const int RATING_INCREASE_MULTIPLIER = 4000; // 
    // =============== static members =======================
    static Random random = new Random();

    // =============== instance members =====================
    private int atBatResult;

    // =============== constructor(s) =======================

    // =============== property methods =====================
    public int AtBatResult
    {
        get
        {
            return atBatResult;
        }
    }
    // =============== general methods ======================
    public int Swing()
    {
        // Generate and display random number for at bat chance.
        Random randomNumber = new Random();
        double hitRandomResult = random.Next(0, (STRIKEOUT_PROBABILITY_BOUND + OUT_PROBABILITY_BOUND) - RATING_INCREASE_MULTIPLIER * 1);

        // -------------------------probability of triple----------------------
        if (hitRandomResult < TRIPLE_PROBABILITY_BOUND && hitRandomResult >= 0)
        {
            atBatResult = 3;
            return 3;
        }

        // -------------------------probability of hit by pitch---------------------
        else if (hitRandomResult < (TRIPLE_PROBABILITY_BOUND + HITBYPITCH_PROBABILITY_BOUND)
              && hitRandomResult >= TRIPLE_PROBABILITY_BOUND)
        {
            atBatResult = 8;
            return 8;
        }

        // -------------------------probability of homerun---------------------
        else if (hitRandomResult < (HITBYPITCH_PROBABILITY_BOUND + HR_PROBABILITY_BOUND)
              && hitRandomResult >= HITBYPITCH_PROBABILITY_BOUND)
        {
            atBatResult = 4;
            return 4;
        }

        // -------------------------probability of double---------------------
        else if (hitRandomResult < (HR_PROBABILITY_BOUND + DOUBLE_PROBABILITY_BOUND)
              && hitRandomResult >= HR_PROBABILITY_BOUND)
        {
            atBatResult = 2;
            return 2;
        }

        // -------------------------probability of walk---------------------
        else if (hitRandomResult < (DOUBLE_PROBABILITY_BOUND + WALK_PROBABILITY_BOUND)
              && hitRandomResult >= DOUBLE_PROBABILITY_BOUND)
        {
            atBatResult = 5;
            return 5;
        }

        // -------------------------probability of single---------------------
        else if (hitRandomResult < (WALK_PROBABILITY_BOUND + SINGLE_PROBABILITY_BOUND)
              && hitRandomResult >= WALK_PROBABILITY_BOUND)
        {
            atBatResult = 1;
            return 1;
        }

        // -------------------------probability of strikeout---------------------
        else if (hitRandomResult < (SINGLE_PROBABILITY_BOUND + STRIKEOUT_PROBABILITY_BOUND)
              && hitRandomResult >= SINGLE_PROBABILITY_BOUND)
        {
            atBatResult = 6;
            return 6;
        }

        // -------------------------probability of putout---------------------
        else if (hitRandomResult < (STRIKEOUT_PROBABILITY_BOUND + OUT_PROBABILITY_BOUND)
              && hitRandomResult >= STRIKEOUT_PROBABILITY_BOUND)
        {
            atBatResult = 7;
            return 7;
        }

        else
        {
            return 9; // error?
        }
    }
}