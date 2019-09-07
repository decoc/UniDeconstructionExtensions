# Overview

This repository contains [`Deconstructing`](https://docs.microsoft.com/en-us/dotnet/csharp/deconstruct) Unity classes/structs with extension methods.

Supported classes/structs are as bellow:

- Vector
  - Vector2
  - Vector2Int
  - Vector3
  - Vector3Int
  - Vector4
- Quoaternion
- Color
  - Color
  - Color32
- Rect

## Hot to use

```cs
//Deconstruct Vector3
var (x, y, z) = new Vector3(1,1,1);

//Deconstruct Color
var (r, g, b, a) = new Color(1, 1, 1);
```

Also, you can convert to tuple explicitly if you concern order of return values.

```cs
// Visual Studio dialog an explanation of return values.
var (x, y, z) = Vector3.One.ToTuple();

var(r, g, b, a) = Color.red.ToTuple();
```
