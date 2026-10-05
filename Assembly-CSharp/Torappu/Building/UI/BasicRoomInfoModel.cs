using System;
using Il2CppDummyDll;

namespace Torappu.Building.UI
{
	// Token: 0x02001B07 RID: 6919
	[Token(Token = "0x2001B07")]
	public struct BasicRoomInfoModel
	{
		// Token: 0x170014A3 RID: 5283
		// (get) Token: 0x0600AE80 RID: 44672 RVA: 0x00043290 File Offset: 0x00041490
		[Token(Token = "0x170014A3")]
		public bool isEmpty
		{
			[Token(Token = "0x600AE80")]
			[Address(RVA = "0x7F69A0", Offset = "0x7F55A0", VA = "0x1807F69A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600AE81 RID: 44673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE81")]
		[Address(RVA = "0x3288880", Offset = "0x3287480", VA = "0x183288880")]
		public void LoadData(RoomSlotModel slotModel)
		{
		}

		// Token: 0x0400A743 RID: 42819
		[Token(Token = "0x400A743")]
		[FieldOffset(Offset = "0x0")]
		public static BasicRoomInfoModel EMPTY;

		// Token: 0x0400A744 RID: 42820
		[Token(Token = "0x400A744")]
		[FieldOffset(Offset = "0x0")]
		public string slotId;

		// Token: 0x0400A745 RID: 42821
		[Token(Token = "0x400A745")]
		[FieldOffset(Offset = "0x8")]
		public int level;

		// Token: 0x0400A746 RID: 42822
		[Token(Token = "0x400A746")]
		[FieldOffset(Offset = "0xC")]
		public int maxLevel;

		// Token: 0x0400A747 RID: 42823
		[Token(Token = "0x400A747")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x0400A748 RID: 42824
		[Token(Token = "0x400A748")]
		[FieldOffset(Offset = "0x18")]
		public GridPosition offset;

		// Token: 0x0400A749 RID: 42825
		[Token(Token = "0x400A749")]
		[FieldOffset(Offset = "0x20")]
		public bool isUpgrading;

		// Token: 0x0400A74A RID: 42826
		[Token(Token = "0x400A74A")]
		[FieldOffset(Offset = "0x24")]
		public int index;

		// Token: 0x0400A74B RID: 42827
		[Token(Token = "0x400A74B")]
		[FieldOffset(Offset = "0x28")]
		public bool hasTrackPoint;
	}
}
