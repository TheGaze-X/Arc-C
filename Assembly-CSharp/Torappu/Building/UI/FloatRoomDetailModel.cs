using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.UI
{
	// Token: 0x02001B03 RID: 6915
	[Token(Token = "0x2001B03")]
	public class FloatRoomDetailModel
	{
		// Token: 0x0600AE7C RID: 44668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE7C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FloatRoomDetailModel()
		{
		}

		// Token: 0x0400A73D RID: 42813
		[Token(Token = "0x400A73D")]
		[FieldOffset(Offset = "0x10")]
		public RoomSlotModel slotModel;

		// Token: 0x0400A73E RID: 42814
		[Token(Token = "0x400A73E")]
		[FieldOffset(Offset = "0x18")]
		public bool isShow;

		// Token: 0x0400A73F RID: 42815
		[Token(Token = "0x400A73F")]
		[FieldOffset(Offset = "0x1C")]
		public Color levelColor;

		// Token: 0x0400A740 RID: 42816
		[Token(Token = "0x400A740")]
		[FieldOffset(Offset = "0x2C")]
		public Color emptyColor;
	}
}
