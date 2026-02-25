using System;
using System.Diagnostics.Metrics;

{
    Dog myDog = new Dog();
    myDog.Name = "초코";
    myDog.Age = 3;
    myDog.Bark();

    Console.WriteLine($"이름: {myDog.Name}, 나이: {myDog.Age}살");
}

{
    Monster monster1 = new Monster();
    Console.WriteLine(monster1);

    var monster2 = new Monster();
    Console.WriteLine(monster2);
}

{
    Calculator calc = new Calculator();
    calc.Add(3, 5);
    calc.Multiply(4, 6);
}
{
    Counter counter = new Counter();
    counter.Increment();
    counter.Increment();
    counter.Increment();
    counter.Reset();
}

{
    GameManager.TotalPlayers = 10;
    GameManager.ShowStatus();

    GameManager manager = new GameManager();
    manager.PlayerName = "홍길동";
    manager.Greet();
}

{
    Greeting.SayHello();
    Farewell.Wave();

    Greeting greeting = new Greeting();
    greeting.SayGoodbye();

    Farewell farewell = new Farewell();
    farewell.Bow();
}

{
    Item item = new Item();
    item.Name = "포션";
    item.Price = 100;

    Console.WriteLine(item);
}

{
    Player player1 = new Player();
    player1.Name = "전사";
    player1.Level = 10;
    player1.Health = 200;

    Player player2 = new Player();
    player2.Name = "마법사";
    player2.Level = 8;
    player2.Health = 120;

    Console.WriteLine(player1);
    Console.WriteLine(player2);
}

{
    Enemy[] enemies = new Enemy[3];

    enemies[0] = new Enemy();
    enemies[0].Name = "고블린";
    enemies[0].Health = 50;

    enemies[1] = new Enemy();
    enemies[1].Name = "오크";
    enemies[1].Health = 100;

    enemies[2] = new Enemy();
    enemies[2].Name = "드래곤";
    enemies[2].Health = 500;

    for (int i = 0; i < enemies.Length; i++ )
    {
        enemies[i].ShowInfo();
    }
}

{
    Item2[] inventory = new Item2[3];
    inventory[0] = new Item2 { Name = "검", Price = 500 };
    inventory[1] = new Item2 { Name = "방패", Price = 300 };
    inventory[2] = new Item2 { Name = "포션", Price = 50 };

    Console.WriteLine("=== 인벤토리 ===");
    foreach (Item2 item in inventory)
    {
        Console.WriteLine(item);
    }
}

{
    Character char1 = new Character();
    char1.Name = "홍길동";
    char1.Level = 1;
    char1.Job = "전사";

    Character char2 = new Character
    {
        Name = "이순신",
        Level = 5,
        Job = "궁수"
    };

    Console.WriteLine($"{char1.Name} - {char1.Job} Lv.{char1.Level}");
    Console.WriteLine($"{char2.Name} - {char2.Job} Lv.{char2.Level}");
}

{
    Student[] students = new Student[3]
    {
        new Student {Name = "김철수", Score = 85},
        new Student {Name = "이영희", Score = 92},
        new Student {Name = "박민수", Score = 78}
    };

    foreach (Student student in students)
    {
        Console.WriteLine(student);
    }
}
public class Dog
{
    public string Name;
    public int Age;

    public void Bark()
    {
        Console.WriteLine($"{Name}: 멍멍!");
    }
}

public class Monster
{
    public string Name;
}

public class Calculator
{
    public void Add(int x, int y)
    {
        int sum = x + y;
        Console.WriteLine($"합계: {sum}");
    }

    public void Multiply(int x, int y)
    {
        int product = x * y;
        Console.WriteLine($"곱: {product}");
    }
}

public class Counter
{
    public int Count;

    public void Increment()
    {
        Count++;
        Console.WriteLine($"현재 카운트: {Count}");
    }
    
    public void Reset()
    {
        Count = 0;
        Console.WriteLine("카운트가 초기기화되었습니다.");
    }
}

public class GameManager
{
    public static int TotalPlayers = 0;
    public static void ShowStatus()
    {
        Console.WriteLine($"[정적] 총 플레이어 수: {TotalPlayers}");
    }
    public string PlayerName;
    public void Greet()
    {
        Console.WriteLine($"[인스턴스] 안녕하세요, {PlayerName}님!");
    }
}

public class Greeting
{
    public static void SayHello()
    {
        Console.WriteLine("안녕하세요!");
    }

    public void SayGoodbye()
    {
        Console.WriteLine("안녕히 가세요!");
    }
}

public class Farewell
{
    public static void Wave()
    {
        Console.WriteLine("(손을 흔든다)");
    }

    public void Bow()
    {
        Console.WriteLine("(인사한다)");
    }
}

public class Item
{
    public string Name;
    public int Price;

    public override string ToString()
    {
        return $"[아이템] {Name} - {Price}골드";
    }
}

public class Player
{
    public string Name;
    public int Level;
    public int Health;

    public override string ToString()
    {
        return $"[{Level}레벨] {Name} (HP: {Health})";
    }
}

public class Enemy
{
    public string Name;
    public int Health;

    public void ShowInfo()
    {
        Console.WriteLine($"{Name}: HP {Health}");
    }
}

public class Item2
{
    public string Name;
    public int Price;

    public override string ToString()
    {
        return $"{Name}: {Price}골드";
    }
}

public class Character
{
    public string Name;
    public int Level;
    public string Job;
}

public class Student
{
    public string Name;
    public int Score;

    public override string ToString()
    {
        return $"{Name}: {Score}점";
    }
}