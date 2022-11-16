namespace EriksBossfight
{
    public class GameCharacters
    {
        public string _Name;
        public int _health;
        public int _dmg;
        public int _stamina;

        public GameCharacters(string name, int hp, int dmg, int stamina)
        {
            _Name = name;
            _health = hp;
            _dmg = dmg;
            _stamina = stamina;
        }
    }
}