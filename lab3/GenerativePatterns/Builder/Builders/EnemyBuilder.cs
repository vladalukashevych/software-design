using System.Drawing;

namespace Builder.Builders
{
    public class EnemyBuilder : ICharacterBuilder
    {
        private Character _character;
        public EnemyBuilder()
        {
            _character = new();
        }
        public ICharacterBuilder SetName(string name)
        {
            _character.Name = $"{name} (Enemy)";
            return this;
        }
        public ICharacterBuilder SetEyeColor(Color eyeColor)
        {
            _character.EyeColor = eyeColor;
            return this;
        }
        public ICharacterBuilder SetStrength(int strength)
        {
            _character.Strength = strength;
            return this;
        }
        public ICharacterBuilder SetSpeed(int speed)
        {
            _character.Speed = speed;
            return this;
        }

        public ICharacterBuilder SetIntelligence(int intelligence)
        {
            _character.Intelligence = intelligence;
            return this;
        }
        public ICharacterBuilder SetWeapon(string weapon)
        {
            _character.Weapon = weapon;
            return this;
        }
        public Character Get()
        {
            Character character = _character;

            _character = new();

            return character;
        }
    }
}
