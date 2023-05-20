using Builder;
using Builder.Builders;
using System.Drawing;

HeroBuilder heroBuilder = new HeroBuilder();
Director director = new Director(heroBuilder);
director.Build("Barbie", Color.Blue, 78, 35, 100, "GirlPower");
Character hero = heroBuilder.Get();

EnemyBuilder enemyBuilder = new EnemyBuilder();
director = new Director(enemyBuilder);
director.Build("Raquelle", Color.Purple, 86, 100, 76, "Destruction");
Character enemy = enemyBuilder.Get();

Console.WriteLine($"{hero}\n{enemy}");