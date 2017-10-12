Implement `Fisher–Yates shuffle` to shuffle array and run 6 millions times.

```csharp
int[] ary = new int[] {0, 1, 2};
```

### Using Random extension resoult ###
```json
[0-2-1]:999487
[0-1-2]:1000078
[2-0-1]:1000064
[1-2-0]:1001226
[2-1-0]:999657
[1-0-2]:999488
```

### Using array extensions result ###
```json
[0-2-1]:1001185
[0-1-2]:999077
[2-0-1]:1000702
[1-2-0]:999402
[2-1-0]:1000977
[1-0-2]:998657
```

|Combination |Random Extension| Array Extension|
|:-----------|:---------------|:---------------|
|[0-2-1]     |999487          |1001185
|[0-1-2]     |1000078         |999077
|[2-0-1]     |1000064         |1000702
|[1-2-0]     |1001226         |999402
|[2-1-0]     |999657          |1000977
|[1-0-2]     |999488          |998657