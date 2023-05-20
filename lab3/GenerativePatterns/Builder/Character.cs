using System.Drawing;

namespace Builder
{
    public class Character
    {
        public string? Name { get; set; }
        public Color EyeColor { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
        public int Intelligence { get; set; }
        public string? Weapon { get; set; }

        public override string ToString()
        {
            return $"{Name}:\n" +
                $"\tEye Color: {EyeColor.Name}\n" +
                $"\tStrength: {Strength}\n" +
                $"\tSpeed: {Speed}\n" +
                $"\tIntelligence: {Intelligence}\n" +
                $"\tWeapon: " + (Weapon == null ? "Words" : Weapon) + "\n";
        }

    }
}
