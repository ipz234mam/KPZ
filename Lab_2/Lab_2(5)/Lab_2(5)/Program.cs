using System;
using System.Reflection.Emit;

class Program
{
    static void Main()
    {
        var director = new CharacterDirector();

        var heroBuilder = new HeroBuilder();
        var hero = director.CreateHero(heroBuilder);
        heroBuilder.AddGoodDeed("Врятував село").AddGoodDeed("Допоміг старенькому");

        var enemyBuilder = new EnemyBuilder();
        var enemy = director.CreateEnemy(enemyBuilder);
        enemyBuilder.AddEvilDeed("Спалив ліс").AddEvilDeed("Вкрав артефакт");

        Console.WriteLine("🦸‍♀️ Герой мрії:");
        hero.Print();

        Console.WriteLine("\n🦹‍♂️ Запеклий ворог:");
        enemy.Print();
    }
}
