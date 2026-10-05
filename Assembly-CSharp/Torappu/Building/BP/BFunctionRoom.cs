using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.BP
{
	// Token: 0x02001AB2 RID: 6834
	[Token(Token = "0x2001AB2")]
	public abstract class BFunctionRoom : BRoom
	{
		// Token: 0x0600AC6D RID: 44141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC6D")]
		[Address(RVA = "0x326D4D0", Offset = "0x326C0D0", VA = "0x18326D4D0", Slot = "5")]
		protected override void OnInit(BRoomSlot roomSlot, RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600AC6E RID: 44142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC6E")]
		[Address(RVA = "0x326D410", Offset = "0x326C010", VA = "0x18326D410", Slot = "6")]
		protected override void OnContentChanged(RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600AC6F RID: 44143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC6F")]
		[Address(RVA = "0x326D6A0", Offset = "0x326C2A0", VA = "0x18326D6A0")]
		private void _UpdateContent(RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600AC70 RID: 44144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC70")]
		[Address(RVA = "0x326D830", Offset = "0x326C430", VA = "0x18326D830")]
		protected BFunctionRoom()
		{
		}

		// Token: 0x0600AC71 RID: 44145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC71")]
		[Address(RVA = "0x326BE80", Offset = "0x326AA80", VA = "0x18326BE80")]
		private void <>xLuaBaseProxy_OnInit(BRoomSlot P0, RoomSlotModel P1)
		{
		}

		// Token: 0x0600AC72 RID: 44146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC72")]
		[Address(RVA = "0x326BE20", Offset = "0x326AA20", VA = "0x18326BE20")]
		private void <>xLuaBaseProxy_OnContentChanged(RoomSlotModel P0)
		{
		}

		// Token: 0x0400A492 RID: 42130
		[Token(Token = "0x400A492")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textStationNum;

		// Token: 0x0400A493 RID: 42131
		[Token(Token = "0x400A493")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textStationLimit;

		// Token: 0x0400A494 RID: 42132
		[Token(Token = "0x400A494")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SimpleLayoutContent _levelContent;

		// Token: 0x0400A495 RID: 42133
		[Token(Token = "0x400A495")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _colorMain;

		// Token: 0x0400A496 RID: 42134
		[Token(Token = "0x400A496")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textRoomCategory;

		// Token: 0x0400A497 RID: 42135
		[Token(Token = "0x400A497")]
		[FieldOffset(Offset = "0x80")]
		private BRoomLevelAdapter m_levelAdapter;

		// Token: 0x0400A498 RID: 42136
		[Token(Token = "0x400A498")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400A499 RID: 42137
		[Token(Token = "0x400A499")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnContentChanged;

		// Token: 0x0400A49A RID: 42138
		[Token(Token = "0x400A49A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateContent;

		// Token: 0x0400A49B RID: 42139
		[Token(Token = "0x400A49B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
