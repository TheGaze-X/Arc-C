using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act10D5
{
	// Token: 0x02007B23 RID: 31523
	[Token(Token = "0x2007B23")]
	public class Activity10D5ResHolder : ActivityResHolder, IHotfixable
	{
		// Token: 0x17006766 RID: 26470
		// (get) Token: 0x0602C21B RID: 180763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006766")]
		public override Sprite topbarSprite
		{
			[Token(Token = "0x602C21B")]
			[Address(RVA = "0x28129C0", Offset = "0x28115C0", VA = "0x1828129C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006767 RID: 26471
		// (get) Token: 0x0602C21C RID: 180764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006767")]
		public override Sprite homeSprite
		{
			[Token(Token = "0x602C21C")]
			[Address(RVA = "0x2812960", Offset = "0x2811560", VA = "0x182812960", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006768 RID: 26472
		// (get) Token: 0x0602C21D RID: 180765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006768")]
		public override Sprite homeSpriteMultiMode
		{
			[Token(Token = "0x602C21D")]
			[Address(RVA = "0x28128C0", Offset = "0x28114C0", VA = "0x1828128C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006769 RID: 26473
		// (get) Token: 0x0602C21E RID: 180766 RVA: 0x000DE330 File Offset: 0x000DC530
		[Token(Token = "0x17006769")]
		public override ActivityResHolder.ZoneHomeRes zoneHomeRes
		{
			[Token(Token = "0x602C21E")]
			[Address(RVA = "0x2812A20", Offset = "0x2811620", VA = "0x182812A20", Slot = "7")]
			get
			{
				return default(ActivityResHolder.ZoneHomeRes);
			}
		}

		// Token: 0x0602C21F RID: 180767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C21F")]
		[Address(RVA = "0x2812810", Offset = "0x2811410", VA = "0x182812810")]
		public Activity10D5ResHolder()
		{
		}

		// Token: 0x0602C220 RID: 180768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C220")]
		[Address(RVA = "0x24A65F0", Offset = "0x24A51F0", VA = "0x1824A65F0")]
		private Sprite <>xLuaBaseProxy_get_homeSpriteMultiMode()
		{
			return null;
		}

		// Token: 0x0602C221 RID: 180769 RVA: 0x000DE348 File Offset: 0x000DC548
		[Token(Token = "0x602C221")]
		[Address(RVA = "0x24A6600", Offset = "0x24A5200", VA = "0x1824A6600")]
		private ActivityResHolder.ZoneHomeRes <>xLuaBaseProxy_get_zoneHomeRes()
		{
			return default(ActivityResHolder.ZoneHomeRes);
		}

		// Token: 0x0403FF9C RID: 262044
		[Token(Token = "0x403FF9C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite _homeSprite;

		// Token: 0x0403FF9D RID: 262045
		[Token(Token = "0x403FF9D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _homeMultiSprite;

		// Token: 0x0403FF9E RID: 262046
		[Token(Token = "0x403FF9E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ActivityResHolder.ZoneHomeRes _zoneHomeRes;

		// Token: 0x0403FF9F RID: 262047
		[Token(Token = "0x403FF9F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topbarSprite;

		// Token: 0x0403FFA0 RID: 262048
		[Token(Token = "0x403FFA0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_homeSprite;

		// Token: 0x0403FFA1 RID: 262049
		[Token(Token = "0x403FFA1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_homeSpriteMultiMode;

		// Token: 0x0403FFA2 RID: 262050
		[Token(Token = "0x403FFA2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_zoneHomeRes;

		// Token: 0x0403FFA3 RID: 262051
		[Token(Token = "0x403FFA3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
