using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B0A RID: 6922
	[Token(Token = "0x2001B0A")]
	public class CommonBasicRoomViewModel : IBasicRoomModel, IHotfixable
	{
		// Token: 0x0600AE87 RID: 44679 RVA: 0x000432A8 File Offset: 0x000414A8
		[Token(Token = "0x600AE87")]
		[Address(RVA = "0x329B600", Offset = "0x329A200", VA = "0x18329B600", Slot = "4")]
		public BasicRoomInfoModel GetRoomInfo()
		{
			return default(BasicRoomInfoModel);
		}

		// Token: 0x0600AE88 RID: 44680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE88")]
		[Address(RVA = "0x329B690", Offset = "0x329A290", VA = "0x18329B690")]
		public void LoadData(RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600AE89 RID: 44681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE89")]
		[Address(RVA = "0x329B7A0", Offset = "0x329A3A0", VA = "0x18329B7A0")]
		public CommonBasicRoomViewModel()
		{
		}

		// Token: 0x0400A74C RID: 42828
		[Token(Token = "0x400A74C")]
		[FieldOffset(Offset = "0x10")]
		private BasicRoomInfoModel m_basicModel;

		// Token: 0x0400A74D RID: 42829
		[Token(Token = "0x400A74D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetRoomInfo;

		// Token: 0x0400A74E RID: 42830
		[Token(Token = "0x400A74E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0400A74F RID: 42831
		[Token(Token = "0x400A74F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
