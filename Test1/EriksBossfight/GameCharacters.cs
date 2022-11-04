namespace EriksBossfight
{
    public class GameCharacters
    {
        public string _Name;
        private int _health;
        private int _dmg;
        private int _stamina;

        public GameCharacters(string name, int hp, int dmg, int stamina)
        {
            _Name = name;
            _health = hp;
            _dmg = dmg;
            _stamina = stamina;
        }
    }
}