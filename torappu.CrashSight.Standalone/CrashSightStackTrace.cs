using System;
using Il2CppDummyDll;

// Token: 0x02000009 RID: 9
[Token(Token = "0x2000009")]
public class CrashSightStackTrace
{
	// Token: 0x0600006A RID: 106 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600006A")]
	[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
	public static void setEnable(bool enable)
	{
	}

	// Token: 0x0600006B RID: 107 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600006B")]
	[Address(RVA = "0x559E6C0", Offset = "0x559D2C0", VA = "0x18559E6C0")]
	public static string ExtractStackTrace()
	{
		return null;
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600006C")]
	[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
	public CrashSightStackTrace()
	{
	}

	// Token: 0x04000017 RID: 23
	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x0")]
	public static bool enable;

	// Token: 0x04000018 RID: 24
	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x8")]
	private static string stackTrace;
}
