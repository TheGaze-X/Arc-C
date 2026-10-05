using System;
using Il2CppDummyDll;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
public class EnumInt32ToInt
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x703137A8019397E", Offset = "0x0", VA = "0x703137C0019397E")]
	public static int Convert<TEnum>(TEnum value) where TEnum : struct
	{
		return 0;
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002066 File Offset: 0x00000266
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1939CD8019397E", Offset = "0x0", VA = "0x1939CF0019397E")]
	public static TEnum RevertToEnum<TEnum>(int value) where TEnum : struct
	{
		return null;
	}
}
