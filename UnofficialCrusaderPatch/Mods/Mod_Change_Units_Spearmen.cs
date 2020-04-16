namespace UCP.Patching
{
    /**
     * CHANGE SPEARMEN STATS
     */
    public class Mod_Change_Units_Spearmen : Mod
    {
        override public Change getChange()
        {
            // Lanzenträger hp: 10000
            return new Change("u_spearmen", ChangeType.Troops)
            {
                new DefaultHeader("u_spearmen")
                {
                    BinInt32.CreateEdit("u_spearbow", 2000), // B4EAA0 + 4 * 18   (vanilla = 3500)
                    BinInt32.CreateEdit("u_spearxbow", 9999), // B4EBE0 + 4 * 18   (vanilla = 15000)
                }
            };
        }
    }
}