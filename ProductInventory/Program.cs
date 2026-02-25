using System;

Product p1 = new Product("노트북", 1500000, 5);
Product p2 = new Product("마우스", 35000, 20);
Product p3 = new Product("키보드", 89000, 15);

Console.WriteLine("=== 상품 목록 ===");
Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine(p3);

Console.WriteLine("\n=== 거래 ===");
p1.Sell(2);
p2.Sell(5);
p3.Sell(20);
p3.AddStock(10);

Console.WriteLine("\n=== 최종 상품 목록 ===");
Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine(p3);

Console.WriteLine("\n=== 총 재고 가치 ===");
Console.WriteLine($"{p1.Name}: {p1.GetTotalValue()}원");
Console.WriteLine($"{p2.Name}: {p2.GetTotalValue()}원");
Console.WriteLine($"{p3.Name}: {p3.GetTotalValue()}원");
Console.WriteLine("---");
Console.WriteLine($"전체 재고 총 가치: {p1.GetTotalValue() + p2.GetTotalValue() + p3.GetTotalValue()}");

class Product
{
    public string Name { get; private set; }
    public int Price { get; private set; }
    public int Stock { get; private set; }

    public Product(string name, int price, int stock)
    {
        Name = name;
        Price = price;
        Stock = stock;
    }
    public void AddStock(int quantity)
    {
        Stock += quantity;
        Console.WriteLine($"{Name} {quantity}개 재고 추가. 현재 재고: {Stock}");
    }

    public void Sell(int quantity)
    {
        if (Stock < quantity)
        {
            Console.WriteLine($"{Name} {quantity}개 판매 실패. 재고가 부족합니다. (현재 재고: {Stock}개");
            return;
        }
        Stock -= quantity;
        Console.WriteLine($"{Name} {quantity}개 판매 완료. 남은 재고: {Stock}개");
    }

    public int GetTotalValue()
    {
        return Price * Stock;
    }

    public override string ToString()
    {
        return $"[{Name}] {Price}원 (재고: {Stock}개)";
    }
}