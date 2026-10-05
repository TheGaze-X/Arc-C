using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.BP
{
	// Token: 0x02001AAC RID: 6828
	[Token(Token = "0x2001AAC")]
	public class BControlRoom : BRoom
	{
		// Token: 0x0600AC4A RID: 44106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC4A")]
		[Address(RVA = "0x326BF60", Offset = "0x326AB60", VA = "0x18326BF60")]
		private void _DoUpdateControlRoomContent(RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600AC4B RID: 44107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC4B")]
		[Address(RVA = "0x326C0A0", Offset = "0x326ACA0", VA = "0x18326C0A0")]
		private void _UpdateFavorMaxPanel(object arg)
		{
		}

		// Token: 0x0600AC4C RID: 44108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC4C")]
		[Address(RVA = "0x326BA80", Offset = "0x326A680", VA = "0x18326BA80", Slot = "5")]
		protected override void OnInit(BRoomSlot roomSlot, RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600AC4D RID: 44109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC4D")]
		[Address(RVA = "0x326B9C0", Offset = "0x326A5C0", VA = "0x18326B9C0", Slot = "6")]
		protected override void OnContentChanged(RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600AC4E RID: 44110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC4E")]
		[Address(RVA = "0x326BCA0", Offset = "0x326A8A0", VA = "0x18326BCA0", Slot = "8")]
		protected override void OnRoomDestroy()
		{
		}

		// Token: 0x0600AC4F RID: 44111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC4F")]
		[Address(RVA = "0x326C160", Offset = "0x326AD60", VA = "0x18326C160")]
		public BControlRoom()
		{
		}

		// Token: 0x0600AC50 RID: 44112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC50")]
		[Address(RVA = "0x326BE80", Offset = "0x326AA80", VA = "0x18326BE80")]
		private void <>xLuaBaseProxy_OnInit(BRoomSlot P0, RoomSlotModel P1)
		{
		}

		// Token: 0x0600AC51 RID: 44113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC51")]
		[Address(RVA = "0x326BE20", Offset = "0x326AA20", VA = "0x18326BE20")]
		private void <>xLuaBaseProxy_OnContentChanged(RoomSlotModel P0)
		{
		}

		// Token: 0x0600AC52 RID: 44114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC52")]
		[Address(RVA = "0x326BF00", Offset = "0x326AB00", VA = "0x18326BF00")]
		private void <>xLuaBaseProxy_OnRoomDestroy()
		{
		}

		// Token: 0x0400A46A RID: 42090
		[Token(Token = "0x400A46A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textLevel;

		// Token: 0x0400A46B RID: 42091
		[Token(Token = "0x400A46B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textLevelShadow;

		// Token: 0x0400A46C RID: 42092
		[Token(Token = "0x400A46C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelFavorMax;

		// Token: 0x0400A46D RID: 42093
		[Token(Token = "0x400A46D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__DoUpdateControlRoomContent;

		// Token: 0x0400A46E RID: 42094
		[Token(Token = "0x400A46E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateFavorMaxPanel;

		// Token: 0x0400A46F RID: 42095
		[Token(Token = "0x400A46F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400A470 RID: 42096
		[Token(Token = "0x400A470")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnContentChanged;

		// Token: 0x0400A471 RID: 42097
		[Token(Token = "0x400A471")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnRoomDestroy;

		// Token: 0x0400A472 RID: 42098
		[Token(Token = "0x400A472")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
