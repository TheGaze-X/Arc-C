using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterShow
{
	// Token: 0x02005DDF RID: 24031
	[Token(Token = "0x2005DDF")]
	public class CharacterShowV2State : State, IValueMsgReceiver
	{
		// Token: 0x06022CF2 RID: 142578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022CF2")]
		[Address(RVA = "0x1D4EE40", Offset = "0x1D4DA40", VA = "0x181D4EE40", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06022CF3 RID: 142579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CF3")]
		[Address(RVA = "0x1D4EEA0", Offset = "0x1D4DAA0", VA = "0x181D4EEA0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06022CF4 RID: 142580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CF4")]
		[Address(RVA = "0x1D4F3B0", Offset = "0x1D4DFB0", VA = "0x181D4F3B0", Slot = "23")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06022CF5 RID: 142581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CF5")]
		[Address(RVA = "0x1D4F480", Offset = "0x1D4E080", VA = "0x181D4F480")]
		private void _OnSkillClick(string skillId)
		{
		}

		// Token: 0x06022CF6 RID: 142582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CF6")]
		[Address(RVA = "0x1D4F6D0", Offset = "0x1D4E2D0", VA = "0x181D4F6D0")]
		private void _OnUniEquipClick(string strVal)
		{
		}

		// Token: 0x06022CF7 RID: 142583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CF7")]
		[Address(RVA = "0x1D4F8B0", Offset = "0x1D4E4B0", VA = "0x181D4F8B0")]
		private void _SetEquipScrollRectDragDelegate(CharacterShowBranchView branchView)
		{
		}

		// Token: 0x06022CF8 RID: 142584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CF8")]
		[Address(RVA = "0x1D4ED90", Offset = "0x1D4D990", VA = "0x181D4ED90")]
		public void EventOnBtnBack()
		{
		}

		// Token: 0x06022CF9 RID: 142585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CF9")]
		[Address(RVA = "0x1D4F950", Offset = "0x1D4E550", VA = "0x181D4F950")]
		public CharacterShowV2State()
		{
		}

		// Token: 0x06022CFA RID: 142586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CFA")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402FE7A RID: 196218
		[Token(Token = "0x402FE7A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CharacterShowV2LeftInfoView _leftInfoView;

		// Token: 0x0402FE7B RID: 196219
		[Token(Token = "0x402FE7B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CharacterShowRightInfoViewBase[] _rightInfoList;

		// Token: 0x0402FE7C RID: 196220
		[Token(Token = "0x402FE7C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _rightInfoContainer;

		// Token: 0x0402FE7D RID: 196221
		[Token(Token = "0x402FE7D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _btnBackRt;

		// Token: 0x0402FE7E RID: 196222
		[Token(Token = "0x402FE7E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _infoHintGo;

		// Token: 0x0402FE7F RID: 196223
		[Token(Token = "0x402FE7F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textInfoHint;

		// Token: 0x0402FE80 RID: 196224
		[Token(Token = "0x402FE80")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x0402FE81 RID: 196225
		[Token(Token = "0x402FE81")]
		[NonSerialized]
		public const int MSG_EQUIP_CLICK = 1;

		// Token: 0x0402FE82 RID: 196226
		[Token(Token = "0x402FE82")]
		[NonSerialized]
		public const int MSG_SKILL_CLICK = 2;

		// Token: 0x0402FE83 RID: 196227
		[Token(Token = "0x402FE83")]
		[FieldOffset(Offset = "0x88")]
		private CharacterShowV2StateBean m_stateBean;

		// Token: 0x0402FE84 RID: 196228
		[Token(Token = "0x402FE84")]
		[FieldOffset(Offset = "0x90")]
		private List<CharacterShowRightInfoViewBase> m_rightInfoViewList;

		// Token: 0x0402FE85 RID: 196229
		[Token(Token = "0x402FE85")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402FE86 RID: 196230
		[Token(Token = "0x402FE86")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402FE87 RID: 196231
		[Token(Token = "0x402FE87")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0402FE88 RID: 196232
		[Token(Token = "0x402FE88")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnSkillClick;

		// Token: 0x0402FE89 RID: 196233
		[Token(Token = "0x402FE89")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnUniEquipClick;

		// Token: 0x0402FE8A RID: 196234
		[Token(Token = "0x402FE8A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetEquipScrollRectDragDelegate;

		// Token: 0x0402FE8B RID: 196235
		[Token(Token = "0x402FE8B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnBtnBack;

		// Token: 0x0402FE8C RID: 196236
		[Token(Token = "0x402FE8C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
