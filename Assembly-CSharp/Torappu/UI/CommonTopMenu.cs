using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200391C RID: 14620
	[Token(Token = "0x200391C")]
	public class CommonTopMenu : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700372D RID: 14125
		// (get) Token: 0x060171B1 RID: 94641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700372D")]
		protected Canvas rootCanvas
		{
			[Token(Token = "0x60171B1")]
			[Address(RVA = "0xF72470", Offset = "0xF71070", VA = "0x180F72470")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700372E RID: 14126
		// (get) Token: 0x060171B2 RID: 94642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700372E")]
		public GameObject backBtnGo
		{
			[Token(Token = "0x60171B2")]
			[Address(RVA = "0xF72410", Offset = "0xF71010", VA = "0x180F72410")]
			get
			{
				return null;
			}
		}

		// Token: 0x060171B3 RID: 94643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171B3")]
		[Address(RVA = "0xF71130", Offset = "0xF6FD30", VA = "0x180F71130")]
		private void Start()
		{
		}

		// Token: 0x060171B4 RID: 94644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171B4")]
		[Address(RVA = "0xF71000", Offset = "0xF6FC00", VA = "0x180F71000")]
		public void EventOnBtnBack()
		{
		}

		// Token: 0x060171B5 RID: 94645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171B5")]
		[Address(RVA = "0xF71080", Offset = "0xF6FC80", VA = "0x180F71080")]
		public void EventOnBtnHome()
		{
		}

		// Token: 0x060171B6 RID: 94646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171B6")]
		[Address(RVA = "0xF70FA0", Offset = "0xF6FBA0", VA = "0x180F70FA0")]
		public void EventOnBlankClicked()
		{
		}

		// Token: 0x060171B7 RID: 94647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171B7")]
		[Address(RVA = "0xF719E0", Offset = "0xF705E0", VA = "0x180F719E0")]
		private void _OnRouteButtonClicked(UIRouteTarget target)
		{
		}

		// Token: 0x060171B8 RID: 94648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171B8")]
		[Address(RVA = "0xF71680", Offset = "0xF70280", VA = "0x180F71680")]
		private void _HandleRouteEvent(UIRouteTarget target, object param)
		{
		}

		// Token: 0x060171B9 RID: 94649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171B9")]
		[Address(RVA = "0xF71580", Offset = "0xF70180", VA = "0x180F71580")]
		private void _EventOnBackPress()
		{
		}

		// Token: 0x1700372F RID: 14127
		// (set) Token: 0x060171BA RID: 94650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700372F")]
		public Action onBackClick
		{
			[Token(Token = "0x60171BA")]
			[Address(RVA = "0xF72590", Offset = "0xF71190", VA = "0x180F72590")]
			set
			{
			}
		}

		// Token: 0x060171BB RID: 94651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171BB")]
		[Address(RVA = "0xF722D0", Offset = "0xF70ED0", VA = "0x180F722D0")]
		private void _ToggleDetail()
		{
		}

		// Token: 0x060171BC RID: 94652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171BC")]
		[Address(RVA = "0xF71970", Offset = "0xF70570", VA = "0x180F71970")]
		private void _HideDetail()
		{
		}

		// Token: 0x060171BD RID: 94653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171BD")]
		[Address(RVA = "0xF71F80", Offset = "0xF70B80", VA = "0x180F71F80")]
		private void _ShowDetailTween()
		{
		}

		// Token: 0x060171BE RID: 94654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171BE")]
		[Address(RVA = "0xF71760", Offset = "0xF70360", VA = "0x180F71760")]
		private void _HideDetailTween()
		{
		}

		// Token: 0x060171BF RID: 94655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171BF")]
		[Address(RVA = "0xF71480", Offset = "0xF70080", VA = "0x180F71480")]
		private void _ClearPendingTweens()
		{
		}

		// Token: 0x060171C0 RID: 94656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171C0")]
		[Address(RVA = "0xF71B90", Offset = "0xF70790", VA = "0x180F71B90")]
		private void _ResetDetailContentRect()
		{
		}

		// Token: 0x060171C1 RID: 94657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171C1")]
		[Address(RVA = "0xF72350", Offset = "0xF70F50", VA = "0x180F72350")]
		public CommonTopMenu()
		{
		}

		// Token: 0x0401BE42 RID: 114242
		[Token(Token = "0x401BE42")]
		[FieldOffset(Offset = "0x18")]
		private float TWEEN_DUR;

		// Token: 0x0401BE43 RID: 114243
		[Token(Token = "0x401BE43")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _homeHilight;

		// Token: 0x0401BE44 RID: 114244
		[Token(Token = "0x401BE44")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _detailContainer;

		// Token: 0x0401BE45 RID: 114245
		[Token(Token = "0x401BE45")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _detailContent;

		// Token: 0x0401BE46 RID: 114246
		[Token(Token = "0x401BE46")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _detailAlphaHandler;

		// Token: 0x0401BE47 RID: 114247
		[Token(Token = "0x401BE47")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UICommonTopMenuButton[] _routeButtons;

		// Token: 0x0401BE48 RID: 114248
		[Token(Token = "0x401BE48")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelBackBtn;

		// Token: 0x0401BE49 RID: 114249
		[Token(Token = "0x401BE49")]
		[FieldOffset(Offset = "0x50")]
		private Action m_btnBackListener;

		// Token: 0x0401BE4A RID: 114250
		[Token(Token = "0x401BE4A")]
		[FieldOffset(Offset = "0x58")]
		private bool m_showDetail;

		// Token: 0x0401BE4B RID: 114251
		[Token(Token = "0x401BE4B")]
		[FieldOffset(Offset = "0x60")]
		private Canvas m_rootCanvas;

		// Token: 0x0401BE4C RID: 114252
		[Token(Token = "0x401BE4C")]
		[FieldOffset(Offset = "0x68")]
		private List<Tween> m_playingTweens;

		// Token: 0x0401BE4D RID: 114253
		[Token(Token = "0x401BE4D")]
		[FieldOffset(Offset = "0x70")]
		public Action<UIRouteTarget, object, Action<UIRouteTarget, object>> overrideRouteEvent;

		// Token: 0x0401BE4E RID: 114254
		[Token(Token = "0x401BE4E")]
		[FieldOffset(Offset = "0x78")]
		public Action<UIRouteTarget, bool> onRouteEventHandled;

		// Token: 0x0401BE4F RID: 114255
		[Token(Token = "0x401BE4F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_rootCanvas;

		// Token: 0x0401BE50 RID: 114256
		[Token(Token = "0x401BE50")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_backBtnGo;

		// Token: 0x0401BE51 RID: 114257
		[Token(Token = "0x401BE51")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0401BE52 RID: 114258
		[Token(Token = "0x401BE52")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnBtnBack;

		// Token: 0x0401BE53 RID: 114259
		[Token(Token = "0x401BE53")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnBtnHome;

		// Token: 0x0401BE54 RID: 114260
		[Token(Token = "0x401BE54")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnBlankClicked;

		// Token: 0x0401BE55 RID: 114261
		[Token(Token = "0x401BE55")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnRouteButtonClicked;

		// Token: 0x0401BE56 RID: 114262
		[Token(Token = "0x401BE56")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__HandleRouteEvent;

		// Token: 0x0401BE57 RID: 114263
		[Token(Token = "0x401BE57")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__EventOnBackPress;

		// Token: 0x0401BE58 RID: 114264
		[Token(Token = "0x401BE58")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_onBackClick;

		// Token: 0x0401BE59 RID: 114265
		[Token(Token = "0x401BE59")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ToggleDetail;

		// Token: 0x0401BE5A RID: 114266
		[Token(Token = "0x401BE5A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__HideDetail;

		// Token: 0x0401BE5B RID: 114267
		[Token(Token = "0x401BE5B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ShowDetailTween;

		// Token: 0x0401BE5C RID: 114268
		[Token(Token = "0x401BE5C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__HideDetailTween;

		// Token: 0x0401BE5D RID: 114269
		[Token(Token = "0x401BE5D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ClearPendingTweens;

		// Token: 0x0401BE5E RID: 114270
		[Token(Token = "0x401BE5E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ResetDetailContentRect;

		// Token: 0x0401BE5F RID: 114271
		[Token(Token = "0x401BE5F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
