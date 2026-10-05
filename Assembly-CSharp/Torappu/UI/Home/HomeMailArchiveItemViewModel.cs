using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BB4 RID: 19380
	[Token(Token = "0x2004BB4")]
	public class HomeMailArchiveItemViewModel : IHotfixable, IComparable
	{
		// Token: 0x0601D21A RID: 119322 RVA: 0x000AAA00 File Offset: 0x000A8C00
		[Token(Token = "0x601D21A")]
		[Address(RVA = "0x169C860", Offset = "0x169B460", VA = "0x18169C860", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x0601D21B RID: 119323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D21B")]
		[Address(RVA = "0x169C9F0", Offset = "0x169B5F0", VA = "0x18169C9F0")]
		public HomeMailArchiveItemViewModel()
		{
		}

		// Token: 0x040263AC RID: 156588
		[Token(Token = "0x40263AC")]
		[FieldOffset(Offset = "0x10")]
		public HomeMailArchiveItemViewModel.ViewType type;

		// Token: 0x040263AD RID: 156589
		[Token(Token = "0x40263AD")]
		[FieldOffset(Offset = "0x14")]
		public int year;

		// Token: 0x040263AE RID: 156590
		[Token(Token = "0x40263AE")]
		[FieldOffset(Offset = "0x18")]
		public string yearText;

		// Token: 0x040263AF RID: 156591
		[Token(Token = "0x40263AF")]
		[FieldOffset(Offset = "0x20")]
		public int index;

		// Token: 0x040263B0 RID: 156592
		[Token(Token = "0x40263B0")]
		[FieldOffset(Offset = "0x28")]
		public string itemId;

		// Token: 0x040263B1 RID: 156593
		[Token(Token = "0x40263B1")]
		[FieldOffset(Offset = "0x30")]
		public int sortId;

		// Token: 0x040263B2 RID: 156594
		[Token(Token = "0x40263B2")]
		[FieldOffset(Offset = "0x38")]
		public string title;

		// Token: 0x040263B3 RID: 156595
		[Token(Token = "0x40263B3")]
		[FieldOffset(Offset = "0x40")]
		public string content;

		// Token: 0x040263B4 RID: 156596
		[Token(Token = "0x40263B4")]
		[FieldOffset(Offset = "0x48")]
		public string senderId;

		// Token: 0x040263B5 RID: 156597
		[Token(Token = "0x40263B5")]
		[FieldOffset(Offset = "0x50")]
		public long receiveTime;

		// Token: 0x040263B6 RID: 156598
		[Token(Token = "0x40263B6")]
		[FieldOffset(Offset = "0x58")]
		public string receiveTimeText;

		// Token: 0x040263B7 RID: 156599
		[Token(Token = "0x40263B7")]
		[FieldOffset(Offset = "0x60")]
		public List<ItemBundle> rewardItem;

		// Token: 0x040263B8 RID: 156600
		[Token(Token = "0x40263B8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x040263B9 RID: 156601
		[Token(Token = "0x40263B9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004BB5 RID: 19381
		[Token(Token = "0x2004BB5")]
		public enum ViewType
		{
			// Token: 0x040263BB RID: 156603
			[Token(Token = "0x40263BB")]
			TITLE,
			// Token: 0x040263BC RID: 156604
			[Token(Token = "0x40263BC")]
			ITEM
		}
	}
}
