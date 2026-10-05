using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000197 RID: 407
	[Token(Token = "0x2000197")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
	public sealed class DesignTimeVisibleAttribute : Attribute
	{
		// Token: 0x06000A64 RID: 2660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x4EC7C0", Offset = "0x4EB3C0", VA = "0x1804EC7C0")]
		public DesignTimeVisibleAttribute(bool visible)
		{
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public DesignTimeVisibleAttribute()
		{
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x00006048 File Offset: 0x00004248
		[Token(Token = "0x1700020C")]
		public bool Visible
		{
			[Token(Token = "0x6000A66")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x00006060 File Offset: 0x00004260
		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x5143660", Offset = "0x5142260", VA = "0x185143660", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x00006078 File Offset: 0x00004278
		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x51436E0", Offset = "0x51422E0", VA = "0x1851436E0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x00006090 File Offset: 0x00004290
		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x5143790", Offset = "0x5142390", VA = "0x185143790", Slot = "6")]
		public override bool IsDefaultAttribute()
		{
			return default(bool);
		}

		// Token: 0x040006A0 RID: 1696
		[Token(Token = "0x40006A0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DesignTimeVisibleAttribute Yes;

		// Token: 0x040006A1 RID: 1697
		[Token(Token = "0x40006A1")]
		[FieldOffset(Offset = "0x8")]
		public static readonly DesignTimeVisibleAttribute No;

		// Token: 0x040006A2 RID: 1698
		[Token(Token = "0x40006A2")]
		[FieldOffset(Offset = "0x10")]
		public static readonly DesignTimeVisibleAttribute Default;
	}
}
