using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.BP
{
	// Token: 0x02001AAF RID: 6831
	[Token(Token = "0x2001AAF")]
	public class BDormRoom : BCustomRoom
	{
		// Token: 0x0600AC57 RID: 44119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC57")]
		[Address(RVA = "0x326C5B0", Offset = "0x326B1B0", VA = "0x18326C5B0", Slot = "5")]
		protected override void OnInit(BRoomSlot roomSlot, RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600AC58 RID: 44120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AC58")]
		[Address(RVA = "0x326C440", Offset = "0x326B040", VA = "0x18326C440", Slot = "4")]
		public override Action<object> ListenerToPlayerData()
		{
			return null;
		}

		// Token: 0x0600AC59 RID: 44121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC59")]
		[Address(RVA = "0x326C4F0", Offset = "0x326B0F0", VA = "0x18326C4F0", Slot = "6")]
		protected override void OnContentChanged(RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600AC5A RID: 44122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC5A")]
		[Address(RVA = "0x326C770", Offset = "0x326B370", VA = "0x18326C770")]
		private void _OnPlayerDataChanged(object _)
		{
		}

		// Token: 0x0600AC5B RID: 44123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC5B")]
		[Address(RVA = "0x326C830", Offset = "0x326B430", VA = "0x18326C830")]
		private void _UpdateContent(RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600AC5C RID: 44124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC5C")]
		[Address(RVA = "0x326CB30", Offset = "0x326B730", VA = "0x18326CB30")]
		public BDormRoom()
		{
		}

		// Token: 0x0600AC5D RID: 44125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC5D")]
		[Address(RVA = "0x326C760", Offset = "0x326B360", VA = "0x18326C760")]
		private void <>xLuaBaseProxy_OnInit(BRoomSlot P0, RoomSlotModel P1)
		{
		}

		// Token: 0x0600AC5E RID: 44126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AC5E")]
		[Address(RVA = "0x326C700", Offset = "0x326B300", VA = "0x18326C700")]
		private Action<object> <>xLuaBaseProxy_ListenerToPlayerData()
		{
			return null;
		}

		// Token: 0x0600AC5F RID: 44127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC5F")]
		[Address(RVA = "0x326BE20", Offset = "0x326AA20", VA = "0x18326BE20")]
		private void <>xLuaBaseProxy_OnContentChanged(RoomSlotModel P0)
		{
		}

		// Token: 0x0400A477 RID: 42103
		[Token(Token = "0x400A477")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SimpleLayoutContent _panelLevel;

		// Token: 0x0400A478 RID: 42104
		[Token(Token = "0x400A478")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textCharNum;

		// Token: 0x0400A479 RID: 42105
		[Token(Token = "0x400A479")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textCharLimit;

		// Token: 0x0400A47A RID: 42106
		[Token(Token = "0x400A47A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textState;

		// Token: 0x0400A47B RID: 42107
		[Token(Token = "0x400A47B")]
		[FieldOffset(Offset = "0x78")]
		private BRoomLevelAdapter m_levelAdapter;

		// Token: 0x0400A47C RID: 42108
		[Token(Token = "0x400A47C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400A47D RID: 42109
		[Token(Token = "0x400A47D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ListenerToPlayerData;

		// Token: 0x0400A47E RID: 42110
		[Token(Token = "0x400A47E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnContentChanged;

		// Token: 0x0400A47F RID: 42111
		[Token(Token = "0x400A47F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnPlayerDataChanged;

		// Token: 0x0400A480 RID: 42112
		[Token(Token = "0x400A480")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateContent;

		// Token: 0x0400A481 RID: 42113
		[Token(Token = "0x400A481")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
