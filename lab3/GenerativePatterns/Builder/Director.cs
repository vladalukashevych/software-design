using Builder.Builders;
using System.Drawing;

namespace Builder
{
    public class Director
    {
        private readonly ICharacterBuilder _builder;

        public Director(ICharacterBuilder builder)
        {
            _builder = builder;
        }

        public void Build(string name, Color eyeColor, int strength, int speed,
            int intelligence, string weapon)
        {
            _builder
                .SetName(name)
                .SetEyeColor(eyeColor)
                .SetStrength(strength)
                .SetSpeed(speed)
                .SetIntelligence(intelligence)
                .SetWeapon(weapon);
        }
    }
}
