using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
public class GradingPPSettings
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000001")]
	public static bool PostProcessEnabled
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x5821480", Offset = "0x5820080", VA = "0x185821480")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x58213C0", Offset = "0x581FFC0", VA = "0x1858213C0")]
	public static Vector4 GetMobileBlurParam(bool forceLow = false)
	{
		return default(Vector4);
	}

	// Token: 0x06000003 RID: 3 RVA: 0x0000207E File Offset: 0x0000027E
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
	public GradingPPSettings()
	{
	}

	// Token: 0x04000001 RID: 1
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x0")]
	public static bool s_colorGrading;

	// Token: 0x04000002 RID: 2
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x1")]
	public static bool s_bloom;

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x2")]
	public static bool s_vignette;

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x3")]
	public static bool s_antialiasing;

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x4")]
	public static GradingPPSettings.GradingLevel s_gradingLevel;

	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	public enum GradingLevel
	{
		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		NODEFINE,
		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		LOW,
		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		MEDIUM,
		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		HIGH
	}
}
