using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.StationSelect
{
	// Token: 0x02001C7F RID: 7295
	[Token(Token = "0x2001C7F")]
	public abstract class StationSelectConfirmRoomSlotCardMaskPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600B53B RID: 46395
		[Token(Token = "0x600B53B")]
		public abstract void Init(BuildingStationSelectCharItemView cardView, StationSelectConfirmStateBean stateBean, object context);

		// Token: 0x0600B53C RID: 46396
		[Token(Token = "0x600B53C")]
		public abstract void Render(StationCharViewModel cardModel);

		// Token: 0x0600B53D RID: 46397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B53D")]
		[Address(RVA = "0x32FC5D0", Offset = "0x32FB1D0", VA = "0x1832FC5D0")]
		protected StationSelectConfirmRoomSlotCardMaskPlugin()
		{
		}

		// Token: 0x0400B148 RID: 45384
		[Token(Token = "0x400B148")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
