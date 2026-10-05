using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.BP
{
	// Token: 0x02001AAE RID: 6830
	[Token(Token = "0x2001AAE")]
	public abstract class BCustomRoom : BRoom
	{
		// Token: 0x0600AC54 RID: 44116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC54")]
		[Address(RVA = "0x326C2A0", Offset = "0x326AEA0", VA = "0x18326C2A0", Slot = "5")]
		protected override void OnInit(BRoomSlot roomSlot, RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600AC55 RID: 44117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC55")]
		[Address(RVA = "0x326C3A0", Offset = "0x326AFA0", VA = "0x18326C3A0")]
		protected BCustomRoom()
		{
		}

		// Token: 0x0600AC56 RID: 44118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC56")]
		[Address(RVA = "0x326BE80", Offset = "0x326AA80", VA = "0x18326BE80")]
		private void <>xLuaBaseProxy_OnInit(BRoomSlot P0, RoomSlotModel P1)
		{
		}

		// Token: 0x0400A474 RID: 42100
		[Token(Token = "0x400A474")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textRoomCategory;

		// Token: 0x0400A475 RID: 42101
		[Token(Token = "0x400A475")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400A476 RID: 42102
		[Token(Token = "0x400A476")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
