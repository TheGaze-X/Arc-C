using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x0200015B RID: 347
	[Token(Token = "0x200015B")]
	[AttributeUsage(AttributeTargets.All)]
	public sealed class DesignOnlyAttribute : Attribute
	{
		// Token: 0x060008E1 RID: 2273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x4EC7C0", Offset = "0x4EB3C0", VA = "0x1804EC7C0")]
		public DesignOnlyAttribute(bool isDesignOnly)
		{
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060008E2 RID: 2274 RVA: 0x00005520 File Offset: 0x00003720
		[Token(Token = "0x170001BB")]
		public bool IsDesignOnly
		{
			[Token(Token = "0x60008E2")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00005538 File Offset: 0x00003738
		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x51227E0", Offset = "0x51213E0", VA = "0x1851227E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00005550 File Offset: 0x00003750
		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x51228A0", Offset = "0x51214A0", VA = "0x1851228A0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x00005568 File Offset: 0x00003768
		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x5122900", Offset = "0x5121500", VA = "0x185122900", Slot = "6")]
		public override bool IsDefaultAttribute()
		{
			return default(bool);
		}

		// Token: 0x04000612 RID: 1554
		[Token(Token = "0x4000612")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DesignOnlyAttribute Yes;

		// Token: 0x04000613 RID: 1555
		[Token(Token = "0x4000613")]
		[FieldOffset(Offset = "0x8")]
		public static readonly DesignOnlyAttribute No;

		// Token: 0x04000614 RID: 1556
		[Token(Token = "0x4000614")]
		[FieldOffset(Offset = "0x10")]
		public static readonly DesignOnlyAttribute Default;
	}
}
