using System;
using Il2CppDummyDll;

namespace Torappu.Resource
{
	// Token: 0x02001700 RID: 5888
	[Token(Token = "0x2001700")]
	public class AssetBundleEliminate
	{
		// Token: 0x060094F5 RID: 38133 RVA: 0x0003A1B8 File Offset: 0x000383B8
		[Token(Token = "0x60094F5")]
		[Address(RVA = "0x30FFD50", Offset = "0x30FE950", VA = "0x1830FFD50")]
		public static AssetBundleEliminate.ThinModeLevel RuntimeThinMode()
		{
			return AssetBundleEliminate.ThinModeLevel.NONE;
		}

		// Token: 0x060094F6 RID: 38134 RVA: 0x0003A1D0 File Offset: 0x000383D0
		[Token(Token = "0x60094F6")]
		[Address(RVA = "0x30FFCC0", Offset = "0x30FE8C0", VA = "0x1830FFCC0")]
		public static AssetBundleEliminate.ThinModeLevel ResThinMode()
		{
			return AssetBundleEliminate.ThinModeLevel.NONE;
		}

		// Token: 0x060094F7 RID: 38135 RVA: 0x0003A1E8 File Offset: 0x000383E8
		[Token(Token = "0x60094F7")]
		[Address(RVA = "0x30FFCA0", Offset = "0x30FE8A0", VA = "0x1830FFCA0")]
		public static bool IsThinModeLV4()
		{
			return default(bool);
		}

		// Token: 0x060094F8 RID: 38136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094F8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AssetBundleEliminate()
		{
		}

		// Token: 0x02001701 RID: 5889
		[Token(Token = "0x2001701")]
		public enum ThinModeLevel
		{
			// Token: 0x04008B10 RID: 35600
			[Token(Token = "0x4008B10")]
			NONE,
			// Token: 0x04008B11 RID: 35601
			[Token(Token = "0x4008B11")]
			LV1,
			// Token: 0x04008B12 RID: 35602
			[Token(Token = "0x4008B12")]
			LV2,
			// Token: 0x04008B13 RID: 35603
			[Token(Token = "0x4008B13")]
			LV3,
			// Token: 0x04008B14 RID: 35604
			[Token(Token = "0x4008B14")]
			LV4,
			// Token: 0x04008B15 RID: 35605
			[Token(Token = "0x4008B15")]
			FULL = 999
		}
	}
}
