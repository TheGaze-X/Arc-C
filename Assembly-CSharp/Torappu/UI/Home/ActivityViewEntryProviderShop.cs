using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BCC RID: 19404
	[Token(Token = "0x2004BCC")]
	public class ActivityViewEntryProviderShop : ActivityViewEntryProvider
	{
		// Token: 0x0601D29C RID: 119452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D29C")]
		[Address(RVA = "0x16B52E0", Offset = "0x16B3EE0", VA = "0x1816B52E0", Slot = "4")]
		public override IEnumerable<ActivityViewEntry> EnumAllActivityViewEntry()
		{
			return null;
		}

		// Token: 0x0601D29D RID: 119453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D29D")]
		[Address(RVA = "0x16B5390", Offset = "0x16B3F90", VA = "0x1816B5390")]
		private void _UpdateAvailItems()
		{
		}

		// Token: 0x0601D29E RID: 119454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D29E")]
		[Address(RVA = "0x16B5700", Offset = "0x16B4300", VA = "0x1816B5700")]
		public ActivityViewEntryProviderShop()
		{
		}

		// Token: 0x0601D29F RID: 119455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D29F")]
		[Address(RVA = "0x16B4CB0", Offset = "0x16B38B0", VA = "0x1816B4CB0")]
		private IEnumerable<ActivityViewEntry> <>xLuaBaseProxy_EnumAllActivityViewEntry()
		{
			return null;
		}

		// Token: 0x04026468 RID: 156776
		[Token(Token = "0x4026468")]
		[FieldOffset(Offset = "0x18")]
		private List<ActivityViewEntryProviderShop.ActivityViewEntryShop> m_entries;

		// Token: 0x04026469 RID: 156777
		[Token(Token = "0x4026469")]
		[FieldOffset(Offset = "0x20")]
		private List<ShopCarouselData.Item> m_availItems;

		// Token: 0x0402646A RID: 156778
		[Token(Token = "0x402646A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EnumAllActivityViewEntry;

		// Token: 0x0402646B RID: 156779
		[Token(Token = "0x402646B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateAvailItems;

		// Token: 0x0402646C RID: 156780
		[Token(Token = "0x402646C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004BCD RID: 19405
		[Token(Token = "0x2004BCD")]
		private class ActivityViewEntryShop : ActivityViewEntry
		{
			// Token: 0x0601D2A0 RID: 119456 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D2A0")]
			[Address(RVA = "0x16B5AD0", Offset = "0x16B46D0", VA = "0x1816B5AD0", Slot = "6")]
			public override Sprite GetImage()
			{
				return null;
			}

			// Token: 0x0601D2A1 RID: 119457 RVA: 0x000AAC70 File Offset: 0x000A8E70
			[Token(Token = "0x601D2A1")]
			[Address(RVA = "0x54B470", Offset = "0x54A070", VA = "0x18054B470", Slot = "4")]
			public override ActivityEntryType EntryType()
			{
				return ActivityEntryType.NONE;
			}

			// Token: 0x0601D2A2 RID: 119458 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D2A2")]
			[Address(RVA = "0x16B5B90", Offset = "0x16B4790", VA = "0x1816B5B90", Slot = "7")]
			public override void OnClick()
			{
			}

			// Token: 0x0601D2A3 RID: 119459 RVA: 0x000AAC88 File Offset: 0x000A8E88
			[Token(Token = "0x601D2A3")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610", Slot = "5")]
			public override int SubOrder()
			{
				return 0;
			}

			// Token: 0x0601D2A4 RID: 119460 RVA: 0x000AACA0 File Offset: 0x000A8EA0
			[Token(Token = "0x601D2A4")]
			[Address(RVA = "0x16B5A50", Offset = "0x16B4650", VA = "0x1816B5A50", Slot = "8")]
			public override bool CheckAvail()
			{
				return default(bool);
			}

			// Token: 0x0601D2A5 RID: 119461 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D2A5")]
			[Address(RVA = "0x16B5CB0", Offset = "0x16B48B0", VA = "0x1816B5CB0")]
			public ActivityViewEntryShop()
			{
			}

			// Token: 0x0402646D RID: 156781
			[Token(Token = "0x402646D")]
			[FieldOffset(Offset = "0x10")]
			public string spriteId;

			// Token: 0x0402646E RID: 156782
			[Token(Token = "0x402646E")]
			[FieldOffset(Offset = "0x18")]
			public ShopRouteTarget shopTarget;

			// Token: 0x0402646F RID: 156783
			[Token(Token = "0x402646F")]
			[FieldOffset(Offset = "0x20")]
			public string goodId;

			// Token: 0x04026470 RID: 156784
			[Token(Token = "0x4026470")]
			[FieldOffset(Offset = "0x28")]
			public int index;
		}
	}
}
