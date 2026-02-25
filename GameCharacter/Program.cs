using System;

GameCharacter warrior = new GameCharacter();
warrior.Name = "홍길동";
warrior.Job = "전사";
warrior.ShowStatus();

warrior.GainExp(50);
warrior.GainExp(30);
warrior.GainExp(40);
warrior.ShowStatus();

Console.WriteLine();

GameCharacter mage = new GameCharacter();
mage.Name = "김철수";
mage.Job = "마법사";
mage.ShowStatus();

mage.GainExp(100);
mage.ShowStatus();

class GameCharacter
{
    public string Name { get; set; }
    public string Job { get; set; }
    public int Level { get; private set; } = 1;
    public int Exp { get; private set; } = 0;

    public void ShowStatus()
    {
        Console.WriteLine($"[{Job}] {Name} - Lv.{Level} (EXP: {Exp}/100)");
    }
    public void GainExp(int amount)
    {
        Exp += amount;
        if (Exp >= 100)
        {
            Level++;
            Exp -= 100;
            Console.WriteLine($"레벨 업! 이름 Lv.{Level} 달성!");
        }
        else
        {
            Console.WriteLine($"경험치 획득! 현재 EXP: {Exp}/100");
        }
    }
}