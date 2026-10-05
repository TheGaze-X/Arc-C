using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B07 RID: 19207
	[Token(Token = "0x2004B07")]
	public class HomeBackgroundPreviewState : HomeReplaceableState, HomeIllustEditFrame.IClickEvent
	{
		// Token: 0x0601CDCE RID: 118222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDCE")]
		[Address(RVA = "0x163F2C0", Offset = "0x163DEC0", VA = "0x18163F2C0")]
		public void BtnPanelBlockClick()
		{
		}

		// Token: 0x0601CDCF RID: 118223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDCF")]
		[Address(RVA = "0x163F3A0", Offset = "0x163DFA0", VA = "0x18163F3A0")]
		public void BtnPreviewClick()
		{
		}

		// Token: 0x0601CDD0 RID: 118224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDD0")]
		[Address(RVA = "0x163F820", Offset = "0x163E420", VA = "0x18163F820")]
		public void CloseButtonFadeIn()
		{
		}

		// Token: 0x0601CDD1 RID: 118225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDD1")]
		[Address(RVA = "0x163FA90", Offset = "0x163E690", VA = "0x18163FA90")]
		public void ClosePreview()
		{
		}

		// Token: 0x0601CDD2 RID: 118226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDD2")]
		[Address(RVA = "0x163F680", Offset = "0x163E280", VA = "0x18163F680", Slot = "33")]
		public void ClickFromFrame(PointerEventData eventData)
		{
		}

		// Token: 0x0601CDD3 RID: 118227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDD3")]
		[Address(RVA = "0x16405D0", Offset = "0x163F1D0", VA = "0x1816405D0")]
		private void _ResetTweener()
		{
		}

		// Token: 0x0601CDD4 RID: 118228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDD4")]
		[Address(RVA = "0x1640680", Offset = "0x163F280", VA = "0x181640680")]
		private void _StartPreviewMode()
		{
		}

		// Token: 0x0601CDD5 RID: 118229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDD5")]
		[Address(RVA = "0x1640150", Offset = "0x163ED50", VA = "0x181640150")]
		private void _ExitPreviewMode()
		{
		}

		// Token: 0x0601CDD6 RID: 118230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDD6")]
		[Address(RVA = "0x16403A0", Offset = "0x163EFA0", VA = "0x1816403A0")]
		private void _InitIllustEditFrame()
		{
		}

		// Token: 0x0601CDD7 RID: 118231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDD7")]
		[Address(RVA = "0x1640270", Offset = "0x163EE70", VA = "0x181640270")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601CDD8 RID: 118232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDD8")]
		[Address(RVA = "0x163FCF0", Offset = "0x163E8F0", VA = "0x18163FCF0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601CDD9 RID: 118233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDD9")]
		[Address(RVA = "0x163FF50", Offset = "0x163EB50", VA = "0x18163FF50", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0601CDDA RID: 118234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDDA")]
		[Address(RVA = "0x163FC90", Offset = "0x163E890", VA = "0x18163FC90")]
		protected void OnDestroy()
		{
		}

		// Token: 0x0601CDDB RID: 118235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CDDB")]
		[Address(RVA = "0x163FB10", Offset = "0x163E710", VA = "0x18163FB10", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601CDDC RID: 118236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CDDC")]
		[Address(RVA = "0x163FFC0", Offset = "0x163EBC0", VA = "0x18163FFC0", Slot = "29")]
		protected override IEnumerator ShowEffect(HomeReplaceableState extractState)
		{
			return null;
		}

		// Token: 0x0601CDDD RID: 118237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CDDD")]
		[Address(RVA = "0x163FB70", Offset = "0x163E770", VA = "0x18163FB70", Slot = "30")]
		protected override IEnumerator HideEffect()
		{
			return null;
		}

		// Token: 0x0601CDDE RID: 118238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDDE")]
		[Address(RVA = "0x1640070", Offset = "0x163EC70", VA = "0x181640070", Slot = "31")]
		protected override void ShowFastMode()
		{
		}

		// Token: 0x0601CDDF RID: 118239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDDF")]
		[Address(RVA = "0x163FC20", Offset = "0x163E820", VA = "0x18163FC20", Slot = "32")]
		protected override void HideFastMode()
		{
		}

		// Token: 0x0601CDE0 RID: 118240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDE0")]
		[Address(RVA = "0x1640770", Offset = "0x163F370", VA = "0x181640770")]
		public HomeBackgroundPreviewState()
		{
		}

		// Token: 0x0601CDE2 RID: 118242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDE2")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601CDE3 RID: 118243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDE3")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x04025DD4 RID: 155092
		[Token(Token = "0x4025DD4")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x04025DD5 RID: 155093
		[Token(Token = "0x4025DD5")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _panelButtons;

		// Token: 0x04025DD6 RID: 155094
		[Token(Token = "0x4025DD6")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _btnDynPreview;

		// Token: 0x04025DD7 RID: 155095
		[Token(Token = "0x4025DD7")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private HomeIllustEditFrame _editFrame;

		// Token: 0x04025DD8 RID: 155096
		[Token(Token = "0x4025DD8")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _rectBack;

		// Token: 0x04025DD9 RID: 155097
		[Token(Token = "0x4025DD9")]
		[FieldOffset(Offset = "0x88")]
		private HomeIllustView.IllustHandler m_illustHandler;

		// Token: 0x04025DDA RID: 155098
		[Token(Token = "0x4025DDA")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isInited;

		// Token: 0x04025DDB RID: 155099
		[Token(Token = "0x4025DDB")]
		[FieldOffset(Offset = "0x91")]
		private bool m_illustFlagInited;

		// Token: 0x04025DDC RID: 155100
		[Token(Token = "0x4025DDC")]
		[FieldOffset(Offset = "0x92")]
		private bool m_useIllustSetting;

		// Token: 0x04025DDD RID: 155101
		[Token(Token = "0x4025DDD")]
		[FieldOffset(Offset = "0x93")]
		private bool m_isDynamicIllust;

		// Token: 0x04025DDE RID: 155102
		[Token(Token = "0x4025DDE")]
		[FieldOffset(Offset = "0x98")]
		private CharUISkinStruct m_curSkin;

		// Token: 0x04025DDF RID: 155103
		[Token(Token = "0x4025DDF")]
		[FieldOffset(Offset = "0xB0")]
		private Tweener m_fadeIn;

		// Token: 0x04025DE0 RID: 155104
		[Token(Token = "0x4025DE0")]
		[FieldOffset(Offset = "0xB8")]
		private Tweener m_fadeOut;

		// Token: 0x04025DE1 RID: 155105
		[Token(Token = "0x4025DE1")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_cancelBtnShowing;

		// Token: 0x04025DE2 RID: 155106
		[Token(Token = "0x4025DE2")]
		[FieldOffset(Offset = "0xC4")]
		private int m_instId;

		// Token: 0x04025DE3 RID: 155107
		[Token(Token = "0x4025DE3")]
		private const float FADE_IN_DELAY = 0.01f;

		// Token: 0x04025DE4 RID: 155108
		[Token(Token = "0x4025DE4")]
		private const float FADE_IN_TIME = 0.6f;

		// Token: 0x04025DE5 RID: 155109
		[Token(Token = "0x4025DE5")]
		private const float FADE_OUT_DELAY = 2.5f;

		// Token: 0x04025DE6 RID: 155110
		[Token(Token = "0x4025DE6")]
		private const float FADE_OUT_TIME = 0.6f;

		// Token: 0x04025DE7 RID: 155111
		[Token(Token = "0x4025DE7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_BtnPanelBlockClick;

		// Token: 0x04025DE8 RID: 155112
		[Token(Token = "0x4025DE8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_BtnPreviewClick;

		// Token: 0x04025DE9 RID: 155113
		[Token(Token = "0x4025DE9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CloseButtonFadeIn;

		// Token: 0x04025DEA RID: 155114
		[Token(Token = "0x4025DEA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ClosePreview;

		// Token: 0x04025DEB RID: 155115
		[Token(Token = "0x4025DEB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ClickFromFrame;

		// Token: 0x04025DEC RID: 155116
		[Token(Token = "0x4025DEC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ResetTweener;

		// Token: 0x04025DED RID: 155117
		[Token(Token = "0x4025DED")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__StartPreviewMode;

		// Token: 0x04025DEE RID: 155118
		[Token(Token = "0x4025DEE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ExitPreviewMode;

		// Token: 0x04025DEF RID: 155119
		[Token(Token = "0x4025DEF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIllustEditFrame;

		// Token: 0x04025DF0 RID: 155120
		[Token(Token = "0x4025DF0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04025DF1 RID: 155121
		[Token(Token = "0x4025DF1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04025DF2 RID: 155122
		[Token(Token = "0x4025DF2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04025DF3 RID: 155123
		[Token(Token = "0x4025DF3")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04025DF4 RID: 155124
		[Token(Token = "0x4025DF4")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04025DF5 RID: 155125
		[Token(Token = "0x4025DF5")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_ShowEffect;

		// Token: 0x04025DF6 RID: 155126
		[Token(Token = "0x4025DF6")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_HideEffect;

		// Token: 0x04025DF7 RID: 155127
		[Token(Token = "0x4025DF7")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_ShowFastMode;

		// Token: 0x04025DF8 RID: 155128
		[Token(Token = "0x4025DF8")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_HideFastMode;

		// Token: 0x04025DF9 RID: 155129
		[Token(Token = "0x4025DF9")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
