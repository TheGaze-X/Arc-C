using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001C99 RID: 7321
	[Token(Token = "0x2001C99")]
	public class StationManageEditQueueStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0600B5A5 RID: 46501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5A5")]
		[Address(RVA = "0x3313ED0", Offset = "0x3312AD0", VA = "0x183313ED0")]
		public void InitData(BuildingModel model, RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600B5A6 RID: 46502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5A6")]
		[Address(RVA = "0x3314160", Offset = "0x3312D60", VA = "0x183314160")]
		public void UpdateData(BuildingModel model, RoomSlotModel slotModel, bool updateByMsg = false)
		{
		}

		// Token: 0x0600B5A7 RID: 46503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5A7")]
		[Address(RVA = "0x3314250", Offset = "0x3312E50", VA = "0x183314250")]
		public StationManageEditQueueStateBean()
		{
		}

		// Token: 0x0400B236 RID: 45622
		[Token(Token = "0x400B236")]
		[FieldOffset(Offset = "0x10")]
		public readonly StationManageEditQueueViewProp stationManageProp;

		// Token: 0x0400B237 RID: 45623
		[Token(Token = "0x400B237")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0400B238 RID: 45624
		[Token(Token = "0x400B238")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0400B239 RID: 45625
		[Token(Token = "0x400B239")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
