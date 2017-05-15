using System;
using System.Collections.Generic;
using System.Text;

public class clsBatterRatings
{

    public int contactRating = 0;
    public int powerRating = 0;
    public int eyeRating = 0;
    public int speedRating = 0;

    public float contactRatingCost = 10;
    public float powerRatingCost = 10;
    public float eyeRatingCost = 10;
    public float speedRatingCost = 10;

    public float skillPoints = 10;
    public float upgradeCost = 10;


    // =============== symbolic constants ===================
    private const int RATING_INCREASE_MULTIPLIER = 4000000; // 

    private const int TRIPLE_PROBABILITY_BOUND = 4607745;  // 
    private const int HITBYPITCH_PROBABILITY_BOUND = 8466822; //
    private const int HR_PROBABILITY_BOUND = 24921245; //
    private const int DOUBLE_PROBABILITY_BOUND = 44522245; // 
    private const int WALK_PROBABILITY_BOUND = 78427508; // 
    private const int SINGLE_PROBABILITY_BOUND = 153353997; //
    private const int STRIKEOUT_PROBABILITY_BOUND = 199964917; //
    private const int OUT_PROBABILITY_BOUND = 494202343;
    //private const int OUT_PROBABILITY_BOUND = 494202343 - (RATING_INCREASE_MULTIPLIER * 2);

    // =============== static members =======================
    static Random random = new Random();

    // =============== instance members =====================
    // =============== constructor(s) =======================

    // =============== property methods =====================
        public int ContactRating
        {
            get
            {
                return contactRating;
            }
        }

        public int PowerRating
        {
            get
            {
                return powerRating;
            }
        }

        public int EyeRating
        {
            get
            {
                return eyeRating;
            }
        }

        public int SpeedRating
        {
            get
            {
                return speedRating;
            }
        }

        public float SkillPoints
        {
            get
            {
                return skillPoints;
            }
        }

        public float ContactRatingCost
        {
            get
            {
                return contactRatingCost;
            }
        }

        public float PowerRatingCost
        {
            get
            {
                return powerRatingCost;
            }
        }

        public float EyeRatingCost
        {
            get
            {
                return eyeRatingCost;
            }
        }

        public float SpeedRatingCost
        {
            get
            {
                return speedRatingCost;
            }
        }


        public float UpgradeCost
        {
            get
            {
                return upgradeCost;
            }
        }
    // =============== general methods ======================
    public int Swing()
    {
        // Generate and display random number for at bat chance.
        Random randomNumber = new Random();
        double hitRandomResult = random.Next(0, (STRIKEOUT_PROBABILITY_BOUND + OUT_PROBABILITY_BOUND) - RATING_INCREASE_MULTIPLIER * contactRating);
        // double hitRandomResult = random.Next(0, (STRIKEOUT_PROBABILITY_BOUND + OUT_PROBABILITY_BOUND));

    // -------------------------probability of triple----------------------
        if (hitRandomResult < TRIPLE_PROBABILITY_BOUND && hitRandomResult >= 0)
        {
            skillPoints = skillPoints + 3.0F;
            return 3;
        }

        // -------------------------probability of hit by pitch---------------------
        else if (hitRandomResult < (TRIPLE_PROBABILITY_BOUND + HITBYPITCH_PROBABILITY_BOUND)
              && hitRandomResult >= TRIPLE_PROBABILITY_BOUND)
        {
            skillPoints = skillPoints + .5F;
            return 8;
        }

        // -------------------------probability of homerun---------------------
        else if (hitRandomResult < (HITBYPITCH_PROBABILITY_BOUND + HR_PROBABILITY_BOUND)
              && hitRandomResult >= HITBYPITCH_PROBABILITY_BOUND)
        {
            skillPoints = skillPoints + 4.0F;
            return 4;
        }

        // -------------------------probability of double---------------------
        else if (hitRandomResult < (HR_PROBABILITY_BOUND + DOUBLE_PROBABILITY_BOUND)
              && hitRandomResult >= HR_PROBABILITY_BOUND)
        {
            skillPoints = skillPoints + 2.0F;
            return 2;
        }

        // -------------------------probability of walk---------------------
        else if (hitRandomResult < (DOUBLE_PROBABILITY_BOUND + WALK_PROBABILITY_BOUND)
              && hitRandomResult >= DOUBLE_PROBABILITY_BOUND)
        {
            skillPoints = skillPoints + 1.0F;
            return 5;
        }

        // -------------------------probability of single---------------------
        else if (hitRandomResult < (WALK_PROBABILITY_BOUND + SINGLE_PROBABILITY_BOUND)
              && hitRandomResult >= WALK_PROBABILITY_BOUND)
        {
            skillPoints = skillPoints + 1.0F;
            return 1;
        }

        // -------------------------probability of strikeout---------------------
        else if (hitRandomResult < (SINGLE_PROBABILITY_BOUND + STRIKEOUT_PROBABILITY_BOUND)
              && hitRandomResult >= SINGLE_PROBABILITY_BOUND)
        {
            return 6;
        }

        // -------------------------probability of putout---------------------
        else if (hitRandomResult < (STRIKEOUT_PROBABILITY_BOUND + OUT_PROBABILITY_BOUND)
              && hitRandomResult >= STRIKEOUT_PROBABILITY_BOUND)
        {
            return 7;
        }

        else
        {
            return 9; // error?
        }
    }
}