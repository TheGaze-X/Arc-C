using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02007018 RID: 28696
	[Token(Token = "0x2007018")]
	public class ActMultiV3TrainingRoomState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x06028BA9 RID: 166825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028BA9")]
		[Address(RVA = "0x24167A0", Offset = "0x24153A0", VA = "0x1824167A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028BAA RID: 166826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028BAA")]
		[Address(RVA = "0x2416240", Offset = "0x2414E40", VA = "0x182416240", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06028BAB RID: 166827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028BAB")]
		[Address(RVA = "0x24162A0", Offset = "0x2414EA0", VA = "0x1824162A0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06028BAC RID: 166828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028BAC")]
		[Address(RVA = "0x24165A0", Offset = "0x24151A0", VA = "0x1824165A0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06028BAD RID: 166829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028BAD")]
		[Address(RVA = "0x2416960", Offset = "0x2415560", VA = "0x182416960")]
		private void _OnModeBtnClicked(long msg)
		{
		}

		// Token: 0x06028BAE RID: 166830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028BAE")]
		[Address(RVA = "0x2416670", Offset = "0x2415270", VA = "0x182416670")]
		private void _EventOnBtnBack()
		{
		}

		// Token: 0x06028BAF RID: 166831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028BAF")]
		[Address(RVA = "0x2416B40", Offset = "0x2415740", VA = "0x182416B40")]
		public ActMultiV3TrainingRoomState()
		{
		}

		// Token: 0x06028BB0 RID: 166832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028BB0")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403A11E RID: 237854
		[Token(Token = "0x403A11E")]
		[NonSerialized]
		public const int MSG_BTN_CLICKED = 0;

		// Token: 0x0403A11F RID: 237855
		[Token(Token = "0x403A11F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403A120 RID: 237856
		[Token(Token = "0x403A120")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ActMultiV3TrainingRoomView _view;

		// Token: 0x0403A121 RID: 237857
		[Token(Token = "0x403A121")]
		[FieldOffset(Offset = "0x80")]
		private bool m_inited;

		// Token: 0x0403A122 RID: 237858
		[Token(Token = "0x403A122")]
		[FieldOffset(Offset = "0x88")]
		private string m_actId;

		// Token: 0x0403A123 RID: 237859
		[Token(Token = "0x403A123")]
		[FieldOffset(Offset = "0x90")]
		private ActMultiV3TrainingRoomProperty m_property;

		// Token: 0x0403A124 RID: 237860
		[Token(Token = "0x403A124")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A125 RID: 237861
		[Token(Token = "0x403A125")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403A126 RID: 237862
		[Token(Token = "0x403A126")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403A127 RID: 237863
		[Token(Token = "0x403A127")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403A128 RID: 237864
		[Token(Token = "0x403A128")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnModeBtnClicked;

		// Token: 0x0403A129 RID: 237865
		[Token(Token = "0x403A129")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EventOnBtnBack;

		// Token: 0x0403A12A RID: 237866
		[Token(Token = "0x403A12A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
