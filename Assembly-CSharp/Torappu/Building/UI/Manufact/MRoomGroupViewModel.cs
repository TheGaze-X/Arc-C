using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.UI.Manufact
{
	// Token: 0x02001D91 RID: 7569
	[Token(Token = "0x2001D91")]
	public class MRoomGroupViewModel : IBasicRoomGroupModel, IHotfixable
	{
		// Token: 0x0600BAAF RID: 47791 RVA: 0x00045D68 File Offset: 0x00043F68
		[Token(Token = "0x600BAAF")]
		[Address(RVA = "0x3376680", Offset = "0x3375280", VA = "0x183376680", Slot = "5")]
		public int GetRoomNum()
		{
			return 0;
		}

		// Token: 0x0600BAB0 RID: 47792 RVA: 0x00045D80 File Offset: 0x00043F80
		[Token(Token = "0x600BAB0")]
		[Address(RVA = "0x3376540", Offset = "0x3375140", VA = "0x183376540", Slot = "6")]
		public BasicRoomInfoModel GetRoomInfo(int index)
		{
			return default(BasicRoomInfoModel);
		}

		// Token: 0x0600BAB1 RID: 47793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BAB1")]
		[Address(RVA = "0x33766F0", Offset = "0x33752F0", VA = "0x1833766F0", Slot = "4")]
		public string GetSelectedSlotId()
		{
			return null;
		}

		// Token: 0x0600BAB2 RID: 47794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAB2")]
		[Address(RVA = "0x3376750", Offset = "0x3375350", VA = "0x183376750")]
		public MRoomGroupViewModel()
		{
		}

		// Token: 0x0400B9F9 RID: 47609
		[Token(Token = "0x400B9F9")]
		[FieldOffset(Offset = "0x10")]
		public int maxManufactNum;

		// Token: 0x0400B9FA RID: 47610
		[Token(Token = "0x400B9FA")]
		[FieldOffset(Offset = "0x18")]
		public ListDict<string, MRoomViewModel> rooms;

		// Token: 0x0400B9FB RID: 47611
		[Token(Token = "0x400B9FB")]
		[FieldOffset(Offset = "0x20")]
		public string selectedSlotId;

		// Token: 0x0400B9FC RID: 47612
		[Token(Token = "0x400B9FC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetRoomNum;

		// Token: 0x0400B9FD RID: 47613
		[Token(Token = "0x400B9FD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetRoomInfo;

		// Token: 0x0400B9FE RID: 47614
		[Token(Token = "0x400B9FE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetSelectedSlotId;

		// Token: 0x0400B9FF RID: 47615
		[Token(Token = "0x400B9FF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
