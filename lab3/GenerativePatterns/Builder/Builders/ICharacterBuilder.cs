using System.Drawing;

namespace Builder.Builders
{
    public interface ICharacterBuilder
    {
        ICharacterBuilder SetName(string name);
        ICharacterBuilder SetEyeColor(Color eyeColor);
        ICharacterBuilder SetStrength(int strength);
        ICharacterBuilder SetSpeed(int speed);
        ICharacterBuilder SetIntelligence(int intelligence);
        ICharacterBuilder SetWeapon(string weapon);
        Character Get();
    }
}
