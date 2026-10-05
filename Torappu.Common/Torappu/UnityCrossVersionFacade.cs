using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200011D RID: 285
	[Token(Token = "0x200011D")]
	public class UnityCrossVersionFacade
	{
		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x00006614 File Offset: 0x00004814
		// (set) Token: 0x060006EF RID: 1775 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x1700008B")]
		public static bool Physics2DAutoSimulation
		{
			[Token(Token = "0x60006EE")]
			[Address(RVA = "0x552BAA0", Offset = "0x552A6A0", VA = "0x18552BAA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006EF")]
			[Address(RVA = "0x552BAF0", Offset = "0x552A6F0", VA = "0x18552BAF0")]
			set
			{
			}
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x0000662C File Offset: 0x0000482C
		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70")]
		public static bool EnableOpenHarmony()
		{
			return default(bool);
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00006644 File Offset: 0x00004844
		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70")]
		public static bool EnableReleaseStandalone()
		{
			return default(bool);
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UnityCrossVersionFacade()
		{
		}

		// Token: 0x040005EE RID: 1518
		[Token(Token = "0x40005EE")]
		public const bool IS_NEW_VERSION = true;

		// Token: 0x040005EF RID: 1519
		[Token(Token = "0x40005EF")]
		public const bool USE_OPTIMIZED_TEXT_VERTS = true;
	}
}
