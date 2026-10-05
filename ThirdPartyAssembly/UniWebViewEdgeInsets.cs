using System;
using Il2CppDummyDll;

// Token: 0x02000025 RID: 37
[Token(Token = "0x2000025")]
[Serializable]
public class UniWebViewEdgeInsets
{
	// Token: 0x0600011F RID: 287 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600011F")]
	[Address(RVA = "0x319E910", Offset = "0x319D510", VA = "0x18319E910")]
	public UniWebViewEdgeInsets(int aTop, int aLeft, int aBottom, int aRight)
	{
	}

	// Token: 0x06000120 RID: 288 RVA: 0x00002328 File Offset: 0x00000528
	[Token(Token = "0x6000120")]
	[Address(RVA = "0x3B25E50", Offset = "0x3B24A50", VA = "0x183B25E50")]
	public static bool operator ==(UniWebViewEdgeInsets inset1, UniWebViewEdgeInsets inset2)
	{
		return default(bool);
	}

	// Token: 0x06000121 RID: 289 RVA: 0x00002340 File Offset: 0x00000540
	[Token(Token = "0x6000121")]
	[Address(RVA = "0x51C6C00", Offset = "0x51C5800", VA = "0x1851C6C00")]
	public static bool operator !=(UniWebViewEdgeInsets inset1, UniWebViewEdgeInsets inset2)
	{
		return default(bool);
	}

	// Token: 0x06000122 RID: 290 RVA: 0x00002358 File Offset: 0x00000558
	[Token(Token = "0x6000122")]
	[Address(RVA = "0x51C6BD0", Offset = "0x51C57D0", VA = "0x1851C6BD0", Slot = "2")]
	public override int GetHashCode()
	{
		return 0;
	}

	// Token: 0x06000123 RID: 291 RVA: 0x00002370 File Offset: 0x00000570
	[Token(Token = "0x6000123")]
	[Address(RVA = "0x51C6A90", Offset = "0x51C5690", VA = "0x1851C6A90", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	// Token: 0x0400009E RID: 158
	[Token(Token = "0x400009E")]
	[FieldOffset(Offset = "0x10")]
	public int top;

	// Token: 0x0400009F RID: 159
	[Token(Token = "0x400009F")]
	[FieldOffset(Offset = "0x14")]
	public int left;

	// Token: 0x040000A0 RID: 160
	[Token(Token = "0x40000A0")]
	[FieldOffset(Offset = "0x18")]
	public int bottom;

	// Token: 0x040000A1 RID: 161
	[Token(Token = "0x40000A1")]
	[FieldOffset(Offset = "0x1C")]
	public int right;
}
