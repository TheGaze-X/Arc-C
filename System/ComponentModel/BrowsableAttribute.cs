using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000158 RID: 344
	[Token(Token = "0x2000158")]
	[AttributeUsage(AttributeTargets.All)]
	public sealed class BrowsableAttribute : Attribute
	{
		// Token: 0x060008CE RID: 2254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x4EC7C0", Offset = "0x4EB3C0", VA = "0x1804EC7C0")]
		public BrowsableAttribute(bool browsable)
		{
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060008CF RID: 2255 RVA: 0x00005478 File Offset: 0x00003678
		[Token(Token = "0x170001B6")]
		public bool Browsable
		{
			[Token(Token = "0x60008CF")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00005490 File Offset: 0x00003690
		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x5121330", Offset = "0x511FF30", VA = "0x185121330", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x000054A8 File Offset: 0x000036A8
		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x51213F0", Offset = "0x511FFF0", VA = "0x1851213F0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x000054C0 File Offset: 0x000036C0
		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x5121450", Offset = "0x5120050", VA = "0x185121450", Slot = "6")]
		public override bool IsDefaultAttribute()
		{
			return default(bool);
		}

		// Token: 0x0400060B RID: 1547
		[Token(Token = "0x400060B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BrowsableAttribute Yes;

		// Token: 0x0400060C RID: 1548
		[Token(Token = "0x400060C")]
		[FieldOffset(Offset = "0x8")]
		public static readonly BrowsableAttribute No;

		// Token: 0x0400060D RID: 1549
		[Token(Token = "0x400060D")]
		[FieldOffset(Offset = "0x10")]
		public static readonly BrowsableAttribute Default;
	}
}
