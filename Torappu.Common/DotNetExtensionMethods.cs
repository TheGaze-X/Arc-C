using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
public static class DotNetExtensionMethods
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x54DF410", Offset = "0x54DE010", VA = "0x1854DF410")]
	public static float GetFloat(this Dictionary<string, object> param, string key, float defaultValue = 0f)
	{
		return 0f;
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x54DF8E0", Offset = "0x54DE4E0", VA = "0x1854DF8E0")]
	public static string GetString(this Dictionary<string, object> param, string key, string defaultValue = "")
	{
		return null;
	}

	// Token: 0x06000003 RID: 3 RVA: 0x0000206C File Offset: 0x0000026C
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x54DF4E0", Offset = "0x54DE0E0", VA = "0x1854DF4E0")]
	public static int GetInt(this Dictionary<string, object> param, string key, int defaultValue = 0)
	{
		return 0;
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002084 File Offset: 0x00000284
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x54DF120", Offset = "0x54DDD20", VA = "0x1854DF120")]
	public static bool GetBool(this Dictionary<string, object> param, string key, bool defaultValue = false)
	{
		return default(bool);
	}

	// Token: 0x06000005 RID: 5 RVA: 0x0000209C File Offset: 0x0000029C
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x54DF9B0", Offset = "0x54DE5B0", VA = "0x1854DF9B0")]
	public static Vector2 GetVector2(this Dictionary<string, object> param, string key)
	{
		return default(Vector2);
	}

	// Token: 0x06000006 RID: 6 RVA: 0x000020B4 File Offset: 0x000002B4
	[Token(Token = "0x6000006")]
	[Address(RVA = "0x54DFAA0", Offset = "0x54DE6A0", VA = "0x1854DFAA0")]
	public static Vector3 GetVector3(this Dictionary<string, object> param, string key)
	{
		return default(Vector3);
	}

	// Token: 0x06000007 RID: 7 RVA: 0x000020CC File Offset: 0x000002CC
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x54DFBB0", Offset = "0x54DE7B0", VA = "0x1854DFBB0")]
	public static Vector4 GetVector4(this Dictionary<string, object> param, string key)
	{
		return default(Vector4);
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x54DF1F0", Offset = "0x54DDDF0", VA = "0x1854DF1F0")]
	public static List<float> GetFloatList(this Dictionary<string, object> param, string key)
	{
		return null;
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x54DF6D0", Offset = "0x54DE2D0", VA = "0x1854DF6D0")]
	public static List<string> GetStringList(this Dictionary<string, object> param, string key)
	{
		return null;
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x54DF5B0", Offset = "0x54DE1B0", VA = "0x1854DF5B0")]
	public static List<object> GetObjectList(this Dictionary<string, object> param, string key)
	{
		return null;
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600000B")]
	public static T GetEnum<T>(this Dictionary<string, object> param, string key, T defaultEnum, bool ignoreCase = false)
	{
		return null;
	}

	// Token: 0x0600000C RID: 12 RVA: 0x000020E4 File Offset: 0x000002E4
	[Token(Token = "0x600000C")]
	public static bool TryGetEnum<T>(this Dictionary<string, object> param, string key, out T value, bool ignoreCase = false)
	{
		return default(bool);
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x600000D")]
	public static List<T> GetEnumList<T>(this Dictionary<string, object> param, string key, T defaultEnum)
	{
		return null;
	}

	// Token: 0x0600000E RID: 14 RVA: 0x000020FA File Offset: 0x000002FA
	[Token(Token = "0x600000E")]
	public static void ChangeKey<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey oldKey, TKey newKey)
	{
	}

	// Token: 0x0600000F RID: 15 RVA: 0x000020FA File Offset: 0x000002FA
	[Token(Token = "0x600000F")]
	public static void Insert<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey keyIndex, bool above, TKey newKey, TValue newValue)
	{
	}

	// Token: 0x06000010 RID: 16 RVA: 0x000020FC File Offset: 0x000002FC
	[Token(Token = "0x6000010")]
	public static bool ValueEquals<T>(this List<T> list, List<T> other)
	{
		return default(bool);
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000011")]
	public static T Pop<T>(this List<T> list)
	{
		return null;
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00002114 File Offset: 0x00000314
	[Token(Token = "0x6000012")]
	public static bool IsIndexValid<T>(this T[,] array, int dimension1, int dimension2)
	{
		return default(bool);
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000013")]
	[Address(RVA = "0x54DFD10", Offset = "0x54DE910", VA = "0x1854DFD10")]
	public static string Replace(this string str, string filterStr, string replaceStr, bool ignoreCase)
	{
		return null;
	}

	// Token: 0x06000014 RID: 20 RVA: 0x0000212C File Offset: 0x0000032C
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x54DFDB0", Offset = "0x54DE9B0", VA = "0x1854DFDB0")]
	public static int ToInt32(this string str)
	{
		return 0;
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002144 File Offset: 0x00000344
	[Token(Token = "0x6000015")]
	[Address(RVA = "0x54DFCF0", Offset = "0x54DE8F0", VA = "0x1854DFCF0")]
	public static int LoopMod(this int num, int count)
	{
		return 0;
	}

	// Token: 0x06000016 RID: 22 RVA: 0x0000215C File Offset: 0x0000035C
	[Token(Token = "0x6000016")]
	public static bool IsFlagSet<T>(this int flags, T flag)
	{
		return default(bool);
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002174 File Offset: 0x00000374
	[Token(Token = "0x6000017")]
	public static int FlagSet<T>(this int flags, T flag)
	{
		return 0;
	}

	// Token: 0x06000018 RID: 24 RVA: 0x0000218C File Offset: 0x0000038C
	[Token(Token = "0x6000018")]
	public static int FlagUnset<T>(this int flags, T flag)
	{
		return 0;
	}

	// Token: 0x06000019 RID: 25 RVA: 0x000021A4 File Offset: 0x000003A4
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x54DFCE0", Offset = "0x54DE8E0", VA = "0x1854DFCE0")]
	public static bool IsPOT(this int x)
	{
		return default(bool);
	}
}
