namespace BattleshipMain
{
    public class Ship
    {
        public int Width { get; set; }

        //for the future improvements
        public bool IsDestroyed { get; set; }        
        public string Name { get; set; }
        
        public Ship(int shipWidth, string shipName)
        {
            Width = shipWidth;
            IsDestroyed = false;            
            Name = shipName;
        }        
    }
}
