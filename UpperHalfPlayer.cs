namespace ShootingDice
{
    // TODO: Complete this class

    // A Player whose role will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player
    {

        public override int Roll()
        {
            int fixedResult = 0;
            int initResult = base.Roll();
            if (initResult < 4)
            {
                fixedResult = initResult + 3;
                return fixedResult;
            }
            else
            {
                return initResult;
            }
        }

    }
}