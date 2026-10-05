using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BC6 RID: 19398
	[Token(Token = "0x2004BC6")]
	public class ActivityViewEntryProviderGacha : ActivityViewEntryProvider
	{
		// Token: 0x0601D27A RID: 119418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D27A")]
		[Address(RVA = "0x16B4C00", Offset = "0x16B3800", VA = "0x1816B4C00", Slot = "4")]
		public override IEnumerable<ActivityViewEntry> EnumAllActivityViewEntry()
		{
			return null;
		}

		// Token: 0x0601D27B RID: 119419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D27B")]
		[Address(RVA = "0x16B4E30", Offset = "0x16B3A30", VA = "0x1816B4E30")]
		private void _LoadAvailCarousels()
		{
		}

		// Token: 0x0601D27C RID: 119420 RVA: 0x000AABC8 File Offset: 0x000A8DC8
		[Token(Token = "0x601D27C")]
		[Address(RVA = "0x16B4CC0", Offset = "0x16B38C0", VA = "0x1816B4CC0")]
		private bool _CheckTimelyCarouselAvailable(GachaData.CarouselData gacha)
		{
			return default(bool);
		}

		// Token: 0x0601D27D RID: 119421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D27D")]
		[Address(RVA = "0x16B5000", Offset = "0x16B3C00", VA = "0x1816B5000")]
		public ActivityViewEntryProviderGacha()
		{
		}

		// Token: 0x0601D27E RID: 119422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D27E")]
		[Address(RVA = "0x16B4CB0", Offset = "0x16B38B0", VA = "0x1816B4CB0")]
		private IEnumerable<ActivityViewEntry> <>xLuaBaseProxy_EnumAllActivityViewEntry()
		{
			return null;
		}

		// Token: 0x0402644F RID: 156751
		[Token(Token = "0x402644F")]
		[FieldOffset(Offset = "0x18")]
		private List<ActivityViewEntryProviderGacha.ActivityViewEntryGacha> m_gachaEntries;

		// Token: 0x04026450 RID: 156752
		[Token(Token = "0x4026450")]
		[FieldOffset(Offset = "0x20")]
		private List<GachaData.CarouselData> m_availableCarousel;

		// Token: 0x04026451 RID: 156753
		[Token(Token = "0x4026451")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EnumAllActivityViewEntry;

		// Token: 0x04026452 RID: 156754
		[Token(Token = "0x4026452")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadAvailCarousels;

		// Token: 0x04026453 RID: 156755
		[Token(Token = "0x4026453")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckTimelyCarouselAvailable;

		// Token: 0x04026454 RID: 156756
		[Token(Token = "0x4026454")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004BC7 RID: 19399
		[Token(Token = "0x2004BC7")]
		private class ActivityViewEntryGacha : ActivityViewEntry
		{
			// Token: 0x0601D27F RID: 119423 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D27F")]
			[Address(RVA = "0x16B48F0", Offset = "0x16B34F0", VA = "0x1816B48F0", Slot = "6")]
			public override Sprite GetImage()
			{
				return null;
			}

			// Token: 0x0601D280 RID: 119424 RVA: 0x000AABE0 File Offset: 0x000A8DE0
			[Token(Token = "0x601D280")]
			[Address(RVA = "0x54B800", Offset = "0x54A400", VA = "0x18054B800", Slot = "4")]
			public override ActivityEntryType EntryType()
			{
				return ActivityEntryType.NONE;
			}

			// Token: 0x0601D281 RID: 119425 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D281")]
			[Address(RVA = "0x16B49B0", Offset = "0x16B35B0", VA = "0x1816B49B0", Slot = "7")]
			public override void OnClick()
			{
			}

			// Token: 0x0601D282 RID: 119426 RVA: 0x000AABF8 File Offset: 0x000A8DF8
			[Token(Token = "0x601D282")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890", Slot = "5")]
			public override int SubOrder()
			{
				return 0;
			}

			// Token: 0x0601D283 RID: 119427 RVA: 0x000AAC10 File Offset: 0x000A8E10
			[Token(Token = "0x601D283")]
			[Address(RVA = "0x16B4870", Offset = "0x16B3470", VA = "0x1816B4870", Slot = "8")]
			public override bool CheckAvail()
			{
				return default(bool);
			}

			// Token: 0x0601D284 RID: 119428 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D284")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public ActivityViewEntryGacha()
			{
			}

			// Token: 0x04026455 RID: 156757
			[Token(Token = "0x4026455")]
			[FieldOffset(Offset = "0x10")]
			public string spriteId;

			// Token: 0x04026456 RID: 156758
			[Token(Token = "0x4026456")]
			[FieldOffset(Offset = "0x18")]
			public string gachaPoolId;

			// Token: 0x04026457 RID: 156759
			[Token(Token = "0x4026457")]
			[FieldOffset(Offset = "0x20")]
			public int index;
		}
	}
}
