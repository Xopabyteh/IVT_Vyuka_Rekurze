# Zadání 14.03.
## #1 - Rekurze
Vyberte si pár z těchto zadání a zkuste naprogramovat (*mnohdy dají se vyřešit i bez rekurze*):

Factorial
---
V mathematice, faktoriál je nezáporné číslo `n` označené jako `n!` a je to výsledek součinu všech kladných čísel, které jsou menší nebo rovny `n`.

Například: `5! = 5 × 4 × 3 × 2 × 1 = 120.`

Hodnota `0!` je `1`
### Úkol
Vyrobte funkci, která dostane parametr `n` a vrátí faktoriál tohoto čísla

### Rada:
>Vždy platí, že `n! = n × (n - 1)!`

Fibonacciho posloupnost
---
Fibonacciho posloupnost je nekonečná řada čísel, kdy pro každé číslo platí, že je součtem dvou předchozích.

Řada vypadá takto: ` 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, …,`
### Úkol
Vyrobte funkci, která dostane parametr `n` a vrátí číslo, které se v řadě nachází na pozici `n`;
Např: `Fib(7) => 8`

Zrnka rýže na šachovnici
---
[Dostupné na codewars](https://www.codewars.com/kata/5b0d67c1cb35dfa10b0022c7)

Existuje legenda o rýži. Mladý chlapec říká svému otrokáři, že má hlad a řekne mu, aby vzal šachovnici, dal na první políčko 1 zrnko rýže, na druhé 2, na třetí 4 a vždy násobil dvěmi pro další políčko. Hostitel nebyl chytrý a tak mu to slíbil, jenom aby zjistil, že ho kluk zbankrotoval.

### Úkol
Vyrobte funkci, která dostane parametr `grains` a vrátí minimální počet políček, který potřeba proto, aby jsme se dostali k `grains` zrnkům rýže

Např: 
```
SquaresNeeded(0) => 0
SquaresNeeded(1) => 1
SquaresNeeded(2) => 2
SquaresNeeded(3) => 2
SquaresNeeded(4) => 3
``` 
### Rada:
>V rekurzi se dá využít více parametrů

## #2 - Sorting
Zkuste si naprogramovat pár z některých základních řadících algoritmů:
- Bubble sort
- Selection sort
- Insertion sort

Pokud to cítíte na výzvu, můžete zkusit:
- Merge sort
- Quick sort

>Na stránce: https://visualgo.net/en/sorting je znázorněná pár možných řadících algoritmů. Není to jediná stránka. **Na internetu jsou toho kvanta**.
