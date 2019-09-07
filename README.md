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
