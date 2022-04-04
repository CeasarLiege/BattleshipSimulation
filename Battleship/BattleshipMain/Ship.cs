namespace BattleshipMain
{
    public class Ship
    {
        public bool IsDestroyed { get; set; }
        public int Width { get; set; }
        public string Name { get; set; }
        
        public Ship(int shipWidth, string shipName)
        {
            IsDestroyed = false;
            Width = shipWidth;
            Name = shipName;
        }        
    }
}
