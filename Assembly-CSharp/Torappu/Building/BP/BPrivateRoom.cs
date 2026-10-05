using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.BP
{
	// Token: 0x02001ABA RID: 6842
	[Token(Token = "0x2001ABA")]
	public class BPrivateRoom : BCustomRoom
	{
		// Token: 0x0600ACC2 RID: 44226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACC2")]
		[Address(RVA = "0x3273F20", Offset = "0x3272B20", VA = "0x183273F20", Slot = "5")]
		protected override void OnInit(BRoomSlot roomSlot, RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600ACC3 RID: 44227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACC3")]
		[Address(RVA = "0x3273E60", Offset = "0x3272A60", VA = "0x183273E60", Slot = "6")]
		protected override void OnContentChanged(RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600ACC4 RID: 44228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACC4")]
		[Address(RVA = "0x3274080", Offset = "0x3272C80", VA = "0x183274080")]
		private void _UpdateContent(RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600ACC5 RID: 44229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACC5")]
		[Address(RVA = "0x3274380", Offset = "0x3272F80", VA = "0x183274380")]
		public BPrivateRoom()
		{
		}

		// Token: 0x0600ACC6 RID: 44230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACC6")]
		[Address(RVA = "0x326C760", Offset = "0x326B360", VA = "0x18326C760")]
		private void <>xLuaBaseProxy_OnInit(BRoomSlot P0, RoomSlotModel P1)
		{
		}

		// Token: 0x0600ACC7 RID: 44231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACC7")]
		[Address(RVA = "0x326BE20", Offset = "0x326AA20", VA = "0x18326BE20")]
		private void <>xLuaBaseProxy_OnContentChanged(RoomSlotModel P0)
		{
		}

		// Token: 0x0400A4F5 RID: 42229
		[Token(Token = "0x400A4F5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SimpleLayoutContent _panelLevel;

		// Token: 0x0400A4F6 RID: 42230
		[Token(Token = "0x400A4F6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textCharNum;

		// Token: 0x0400A4F7 RID: 42231
		[Token(Token = "0x400A4F7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _imgChar;

		// Token: 0x0400A4F8 RID: 42232
		[Token(Token = "0x400A4F8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _panelChar;

		// Token: 0x0400A4F9 RID: 42233
		[Token(Token = "0x400A4F9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textState;

		// Token: 0x0400A4FA RID: 42234
		[Token(Token = "0x400A4FA")]
		[FieldOffset(Offset = "0x80")]
		private BRoomLevelAdapter m_levelAdapter;

		// Token: 0x0400A4FB RID: 42235
		[Token(Token = "0x400A4FB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400A4FC RID: 42236
		[Token(Token = "0x400A4FC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnContentChanged;

		// Token: 0x0400A4FD RID: 42237
		[Token(Token = "0x400A4FD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateContent;

		// Token: 0x0400A4FE RID: 42238
		[Token(Token = "0x400A4FE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
