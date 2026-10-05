using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.BP
{
	// Token: 0x02001AB0 RID: 6832
	[Token(Token = "0x2001AB0")]
	public class BElevatorRoom : BRoom
	{
		// Token: 0x0600AC60 RID: 44128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC60")]
		[Address(RVA = "0x326CB90", Offset = "0x326B790", VA = "0x18326CB90", Slot = "5")]
		protected override void OnInit(BRoomSlot roomSlot, RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600AC61 RID: 44129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC61")]
		[Address(RVA = "0x326CD90", Offset = "0x326B990", VA = "0x18326CD90")]
		public BElevatorRoom()
		{
		}

		// Token: 0x0600AC62 RID: 44130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC62")]
		[Address(RVA = "0x326BE80", Offset = "0x326AA80", VA = "0x18326BE80")]
		private void <>xLuaBaseProxy_OnInit(BRoomSlot P0, RoomSlotModel P1)
		{
		}

		// Token: 0x0400A482 RID: 42114
		[Token(Token = "0x400A482")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _armLeft;

		// Token: 0x0400A483 RID: 42115
		[Token(Token = "0x400A483")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _armUp;

		// Token: 0x0400A484 RID: 42116
		[Token(Token = "0x400A484")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _armRight;

		// Token: 0x0400A485 RID: 42117
		[Token(Token = "0x400A485")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _armDown;

		// Token: 0x0400A486 RID: 42118
		[Token(Token = "0x400A486")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400A487 RID: 42119
		[Token(Token = "0x400A487")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
