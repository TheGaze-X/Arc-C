using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building
{
	// Token: 0x02001808 RID: 6152
	[Token(Token = "0x2001808")]
	public class StoreyViewModel : IHotfixable
	{
		// Token: 0x06009BC2 RID: 39874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BC2")]
		[Address(RVA = "0x3168940", Offset = "0x3167540", VA = "0x183168940")]
		public void UpdateData(RoomSlotModel controlSlot)
		{
		}

		// Token: 0x06009BC3 RID: 39875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009BC3")]
		[Address(RVA = "0x3168600", Offset = "0x3167200", VA = "0x183168600")]
		public static ListDict<string, StoreyViewModel> LoadViewModels(RoomSlotModel controlSlotModel, BuildingData.LayoutData layoutData)
		{
			return null;
		}

		// Token: 0x06009BC4 RID: 39876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BC4")]
		[Address(RVA = "0x3168A20", Offset = "0x3167620", VA = "0x183168A20")]
		public StoreyViewModel()
		{
		}

		// Token: 0x0400926C RID: 37484
		[Token(Token = "0x400926C")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x0400926D RID: 37485
		[Token(Token = "0x400926D")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x0400926E RID: 37486
		[Token(Token = "0x400926E")]
		[FieldOffset(Offset = "0x20")]
		public bool isUnlocked;

		// Token: 0x0400926F RID: 37487
		[Token(Token = "0x400926F")]
		[FieldOffset(Offset = "0x24")]
		public int requireLevel;

		// Token: 0x04009270 RID: 37488
		[Token(Token = "0x4009270")]
		[FieldOffset(Offset = "0x28")]
		public int yOffset;

		// Token: 0x04009271 RID: 37489
		[Token(Token = "0x4009271")]
		[FieldOffset(Offset = "0x2C")]
		public bool isUnderground;

		// Token: 0x04009272 RID: 37490
		[Token(Token = "0x4009272")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04009273 RID: 37491
		[Token(Token = "0x4009273")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadViewModels;

		// Token: 0x04009274 RID: 37492
		[Token(Token = "0x4009274")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
