using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x02007420 RID: 29728
	[Token(Token = "0x2007420")]
	public class Act3D0GachaBoxInfo
	{
		// Token: 0x06029F83 RID: 171907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F83")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act3D0GachaBoxInfo()
		{
		}

		// Token: 0x0403C2AC RID: 246444
		[Token(Token = "0x403C2AC")]
		[FieldOffset(Offset = "0x10")]
		public string gachaBoxId;

		// Token: 0x0403C2AD RID: 246445
		[Token(Token = "0x403C2AD")]
		[FieldOffset(Offset = "0x18")]
		public int tokenNumOnce;

		// Token: 0x0403C2AE RID: 246446
		[Token(Token = "0x403C2AE")]
		[FieldOffset(Offset = "0x1C")]
		public Act3D0GachaBoxInfo.UnlockState unlockState;

		// Token: 0x0403C2AF RID: 246447
		[Token(Token = "0x403C2AF")]
		[FieldOffset(Offset = "0x20")]
		public Act3D0Data.GachaBoxType gachaBoxType;

		// Token: 0x0403C2B0 RID: 246448
		[Token(Token = "0x403C2B0")]
		[FieldOffset(Offset = "0x28")]
		public List<Act3D0GachaBoxInfo.Act3D0GachaBoxItemInfo> itemList;

		// Token: 0x0403C2B1 RID: 246449
		[Token(Token = "0x403C2B1")]
		[FieldOffset(Offset = "0x30")]
		public ItemBundle requireItem;

		// Token: 0x0403C2B2 RID: 246450
		[Token(Token = "0x403C2B2")]
		[FieldOffset(Offset = "0x38")]
		public string unlockImg;

		// Token: 0x0403C2B3 RID: 246451
		[Token(Token = "0x403C2B3")]
		[FieldOffset(Offset = "0x40")]
		public int totalCount;

		// Token: 0x0403C2B4 RID: 246452
		[Token(Token = "0x403C2B4")]
		[FieldOffset(Offset = "0x44")]
		public int remainCount;

		// Token: 0x02007421 RID: 29729
		[Token(Token = "0x2007421")]
		public enum UnlockState
		{
			// Token: 0x0403C2B6 RID: 246454
			[Token(Token = "0x403C2B6")]
			OUT_OF_STACK,
			// Token: 0x0403C2B7 RID: 246455
			[Token(Token = "0x403C2B7")]
			UNLOCKED,
			// Token: 0x0403C2B8 RID: 246456
			[Token(Token = "0x403C2B8")]
			LOCKED
		}

		// Token: 0x02007422 RID: 29730
		[Token(Token = "0x2007422")]
		public class Act3D0GachaBoxItemInfo : IComparable<Act3D0GachaBoxInfo.Act3D0GachaBoxItemInfo>
		{
			// Token: 0x06029F84 RID: 171908 RVA: 0x000D7130 File Offset: 0x000D5330
			[Token(Token = "0x6029F84")]
			[Address(RVA = "0x1A00EF0", Offset = "0x19FFAF0", VA = "0x181A00EF0", Slot = "4")]
			public int CompareTo(Act3D0GachaBoxInfo.Act3D0GachaBoxItemInfo other)
			{
				return 0;
			}

			// Token: 0x06029F85 RID: 171909 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029F85")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act3D0GachaBoxItemInfo()
			{
			}

			// Token: 0x0403C2B9 RID: 246457
			[Token(Token = "0x403C2B9")]
			[FieldOffset(Offset = "0x10")]
			public string goodId;

			// Token: 0x0403C2BA RID: 246458
			[Token(Token = "0x403C2BA")]
			[FieldOffset(Offset = "0x18")]
			public string boxId;

			// Token: 0x0403C2BB RID: 246459
			[Token(Token = "0x403C2BB")]
			[FieldOffset(Offset = "0x20")]
			public int remainCount;

			// Token: 0x0403C2BC RID: 246460
			[Token(Token = "0x403C2BC")]
			[FieldOffset(Offset = "0x28")]
			public ItemBundle itemInfo;

			// Token: 0x0403C2BD RID: 246461
			[Token(Token = "0x403C2BD")]
			[FieldOffset(Offset = "0x30")]
			public int perCount;

			// Token: 0x0403C2BE RID: 246462
			[Token(Token = "0x403C2BE")]
			[FieldOffset(Offset = "0x34")]
			public int totalCount;

			// Token: 0x0403C2BF RID: 246463
			[Token(Token = "0x403C2BF")]
			[FieldOffset(Offset = "0x38")]
			public string type;

			// Token: 0x0403C2C0 RID: 246464
			[Token(Token = "0x403C2C0")]
			[FieldOffset(Offset = "0x40")]
			public int orderId;
		}
	}
}
