# GameCharacter

게임 캐릭터를 육성하는 `GameCharacter` 클래스를 작성하시오.

**요구사항**

- 필드
  - `Name`: 캐릭터 이름 (string)
  - `Job`: 직업 (string)
  - `Level`: 레벨 (int, 기본값 1)
  - `Exp`: 경험치 (int, 기본값 0)
- 메서드
  - `ShowStatus()`: 상태 출력 → `[직업] 이름 - Lv.레벨 (EXP: 경험치/100)`
  - `GainExp(int amount)`: 경험치 획득
    - `Exp += amount`
    - 경험치가 100 이상이면: 레벨 1 증가, 경험치에서 100 차감, `레벨 업! 이름 Lv.레벨 달성!` 출력
    - 경험치가 100 미만이면: `경험치 획득! 현재 EXP: 경험치/100` 출력

**테스트 코드**

```csharp
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
```

## 예상 실행 결과

```
[전사] 홍길동 - Lv.1 (EXP: 0/100)
경험치 획득! 현재 EXP: 50/100
경험치 획득! 현재 EXP: 80/100
레벨 업! 홍길동 Lv.2 달성!
[전사] 홍길동 - Lv.2 (EXP: 20/100)

[마법사] 김철수 - Lv.1 (EXP: 0/100)
레벨 업! 김철수 Lv.2 달성!
[마법사] 김철수 - Lv.2 (EXP: 0/100)
```
