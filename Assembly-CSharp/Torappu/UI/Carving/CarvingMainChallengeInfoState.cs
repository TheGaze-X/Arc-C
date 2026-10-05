using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x02006070 RID: 24688
	[Token(Token = "0x2006070")]
	public class CarvingMainChallengeInfoState : PopupFadeState
	{
		// Token: 0x06023B25 RID: 146213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023B25")]
		[Address(RVA = "0x1E58540", Offset = "0x1E57140", VA = "0x181E58540", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06023B26 RID: 146214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B26")]
		[Address(RVA = "0x1E588E0", Offset = "0x1E574E0", VA = "0x181E588E0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06023B27 RID: 146215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023B27")]
		[Address(RVA = "0x1E58E80", Offset = "0x1E57A80", VA = "0x181E58E80", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x06023B28 RID: 146216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B28")]
		[Address(RVA = "0x1E58FD0", Offset = "0x1E57BD0", VA = "0x181E58FD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023B29 RID: 146217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B29")]
		[Address(RVA = "0x1E593C0", Offset = "0x1E57FC0", VA = "0x181E593C0")]
		private void _PlayShowAnim()
		{
		}

		// Token: 0x06023B2A RID: 146218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B2A")]
		[Address(RVA = "0x1E585A0", Offset = "0x1E571A0", VA = "0x181E585A0")]
		public void OnClickBackBtn()
		{
		}

		// Token: 0x06023B2B RID: 146219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B2B")]
		[Address(RVA = "0x1E59210", Offset = "0x1E57E10", VA = "0x181E59210")]
		private void _OnClickState(CarvingShopToBuyResponse response)
		{
		}

		// Token: 0x06023B2C RID: 146220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B2C")]
		[Address(RVA = "0x1E59160", Offset = "0x1E57D60", VA = "0x181E59160")]
		private void _OnBackBtnClicked()
		{
		}

		// Token: 0x06023B2D RID: 146221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B2D")]
		[Address(RVA = "0x1E59530", Offset = "0x1E58130", VA = "0x181E59530")]
		public CarvingMainChallengeInfoState()
		{
		}

		// Token: 0x06023B2F RID: 146223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B2F")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06023B30 RID: 146224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023B30")]
		[Address(RVA = "0x1089D20", Offset = "0x1088920", VA = "0x181089D20")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x04031789 RID: 202633
		[Token(Token = "0x4031789")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIFullScreenImage _background;

		// Token: 0x0403178A RID: 202634
		[Token(Token = "0x403178A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CarvingMainChallengeInfoView _infoView;

		// Token: 0x0403178B RID: 202635
		[Token(Token = "0x403178B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _backBtn;

		// Token: 0x0403178C RID: 202636
		[Token(Token = "0x403178C")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _autoPopBkgObj;

		// Token: 0x0403178D RID: 202637
		[Token(Token = "0x403178D")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _showAnimLocation;

		// Token: 0x0403178E RID: 202638
		[Token(Token = "0x403178E")]
		[FieldOffset(Offset = "0xA0")]
		private CarvingMainChallengeInfoStateBean m_stateBean;

		// Token: 0x0403178F RID: 202639
		[Token(Token = "0x403178F")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_isInited;

		// Token: 0x04031790 RID: 202640
		[Token(Token = "0x4031790")]
		[FieldOffset(Offset = "0xB0")]
		private Tween m_showTween;

		// Token: 0x04031791 RID: 202641
		[Token(Token = "0x4031791")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04031792 RID: 202642
		[Token(Token = "0x4031792")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04031793 RID: 202643
		[Token(Token = "0x4031793")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x04031794 RID: 202644
		[Token(Token = "0x4031794")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04031795 RID: 202645
		[Token(Token = "0x4031795")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayShowAnim;

		// Token: 0x04031796 RID: 202646
		[Token(Token = "0x4031796")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnClickBackBtn;

		// Token: 0x04031797 RID: 202647
		[Token(Token = "0x4031797")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnClickState;

		// Token: 0x04031798 RID: 202648
		[Token(Token = "0x4031798")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnBackBtnClicked;

		// Token: 0x04031799 RID: 202649
		[Token(Token = "0x4031799")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
