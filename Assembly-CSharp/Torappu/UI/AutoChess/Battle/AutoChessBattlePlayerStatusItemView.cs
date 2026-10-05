using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064EC RID: 25836
	[Token(Token = "0x20064EC")]
	public class AutoChessBattlePlayerStatusItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170057A0 RID: 22432
		// (get) Token: 0x06025205 RID: 152069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170057A0")]
		public RectTransform emojiRect
		{
			[Token(Token = "0x6025205")]
			[Address(RVA = "0x2013720", Offset = "0x2012320", VA = "0x182013720")]
			get
			{
				return null;
			}
		}

		// Token: 0x06025206 RID: 152070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025206")]
		[Address(RVA = "0x2012100", Offset = "0x2010D00", VA = "0x182012100")]
		public void Render(AutoChessBattlePlayerStatusModel itemModel, AutoChessBattlePlayerStatusGroupModel groupModel)
		{
		}

		// Token: 0x06025207 RID: 152071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025207")]
		[Address(RVA = "0x2012FC0", Offset = "0x2011BC0", VA = "0x182012FC0")]
		private void _RegisterTutorialGOIfNeed(AutoChessBattlePlayerStatusGroupModel groupModel, AutoChessBattlePlayerStatusModel itemModel)
		{
		}

		// Token: 0x06025208 RID: 152072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025208")]
		[Address(RVA = "0x2012950", Offset = "0x2011550", VA = "0x182012950")]
		public void SetExclusiveGroup(ExclusiveSelectionGroup grp)
		{
		}

		// Token: 0x06025209 RID: 152073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025209")]
		[Address(RVA = "0x20129E0", Offset = "0x20115E0", VA = "0x1820129E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602520A RID: 152074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602520A")]
		[Address(RVA = "0x2012B50", Offset = "0x2011750", VA = "0x182012B50")]
		private void _PlayHpTweenIfNeed()
		{
		}

		// Token: 0x0602520B RID: 152075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602520B")]
		[Address(RVA = "0x20133A0", Offset = "0x2011FA0", VA = "0x1820133A0")]
		private void _UpdateHpAndDeadStatus()
		{
		}

		// Token: 0x0602520C RID: 152076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602520C")]
		[Address(RVA = "0x2013550", Offset = "0x2012150", VA = "0x182013550")]
		private void _UpdateHpVisible()
		{
		}

		// Token: 0x0602520D RID: 152077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602520D")]
		[Address(RVA = "0x2013130", Offset = "0x2011D30", VA = "0x182013130")]
		private void _RenderAvatar(AutoChessBattlePlayerStatusModel itemModel)
		{
		}

		// Token: 0x0602520E RID: 152078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602520E")]
		[Address(RVA = "0x2011FD0", Offset = "0x2010BD0", VA = "0x182011FD0")]
		public void EventOnObPreClick()
		{
		}

		// Token: 0x0602520F RID: 152079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602520F")]
		[Address(RVA = "0x2011E40", Offset = "0x2010A40", VA = "0x182011E40")]
		public void EventOnObClick()
		{
		}

		// Token: 0x06025210 RID: 152080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025210")]
		[Address(RVA = "0x2012090", Offset = "0x2010C90", VA = "0x182012090")]
		public void EventOnObResetToPreClick()
		{
		}

		// Token: 0x06025211 RID: 152081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025211")]
		[Address(RVA = "0x2011C80", Offset = "0x2010880", VA = "0x182011C80")]
		public void EventOnBtnObClick()
		{
		}

		// Token: 0x06025212 RID: 152082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025212")]
		[Address(RVA = "0x2011CF0", Offset = "0x20108F0", VA = "0x182011CF0")]
		public void EventOnBtnObNotAvail()
		{
		}

		// Token: 0x06025213 RID: 152083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025213")]
		[Address(RVA = "0x2011BE0", Offset = "0x20107E0", VA = "0x182011BE0")]
		public void EventOnBtnCancelOb()
		{
		}

		// Token: 0x06025214 RID: 152084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025214")]
		[Address(RVA = "0x20136B0", Offset = "0x20122B0", VA = "0x1820136B0")]
		public AutoChessBattlePlayerStatusItemView()
		{
		}

		// Token: 0x040340A4 RID: 213156
		[Token(Token = "0x40340A4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _avatarContainer;

		// Token: 0x040340A5 RID: 213157
		[Token(Token = "0x40340A5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _emojiRefRect;

		// Token: 0x040340A6 RID: 213158
		[Token(Token = "0x40340A6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _avatarScale;

		// Token: 0x040340A7 RID: 213159
		[Token(Token = "0x40340A7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _viewPlayerGrpGO;

		// Token: 0x040340A8 RID: 213160
		[Token(Token = "0x40340A8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _otherPlayerGrpGO;

		// Token: 0x040340A9 RID: 213161
		[Token(Token = "0x40340A9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _iconSelfGO;

		// Token: 0x040340AA RID: 213162
		[Token(Token = "0x40340AA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _deadPartGO;

		// Token: 0x040340AB RID: 213163
		[Token(Token = "0x40340AB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _reconnectPartGO;

		// Token: 0x040340AC RID: 213164
		[Token(Token = "0x40340AC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _quitPartGO;

		// Token: 0x040340AD RID: 213165
		[Token(Token = "0x40340AD")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _actionMovingPartGO;

		// Token: 0x040340AE RID: 213166
		[Token(Token = "0x40340AE")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _actionCompletePartGO;

		// Token: 0x040340AF RID: 213167
		[Token(Token = "0x40340AF")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Button _btnOb;

		// Token: 0x040340B0 RID: 213168
		[Token(Token = "0x40340B0")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Observe")]
		private GameObject _inObGO;

		// Token: 0x040340B1 RID: 213169
		[Token(Token = "0x40340B1")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Observe")]
		private TwoPhaseButtonWidget _twoPhaseObWidget;

		// Token: 0x040340B2 RID: 213170
		[Token(Token = "0x40340B2")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Observe")]
		private CanvasGroup _obWidgetAlphaHandler;

		// Token: 0x040340B3 RID: 213171
		[Token(Token = "0x40340B3")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Observe")]
		private GameObject _normalObservePartGO;

		// Token: 0x040340B4 RID: 213172
		[Token(Token = "0x40340B4")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Observe")]
		private GameObject _disableObservePartGO;

		// Token: 0x040340B5 RID: 213173
		[Token(Token = "0x40340B5")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Observe")]
		private CanvasGroup _cancelObserveAlphaHandler;

		// Token: 0x040340B6 RID: 213174
		[Token(Token = "0x40340B6")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("HP")]
		private GameObject _hpPartGO;

		// Token: 0x040340B7 RID: 213175
		[Token(Token = "0x40340B7")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("HP")]
		private Image _imgHpIcon;

		// Token: 0x040340B8 RID: 213176
		[Token(Token = "0x40340B8")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("HP")]
		private Text _textHp;

		// Token: 0x040340B9 RID: 213177
		[Token(Token = "0x40340B9")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("HP")]
		private float _hpTweenDuration;

		// Token: 0x040340BA RID: 213178
		[Token(Token = "0x40340BA")]
		[FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[Group("HP")]
		private Color _colorHpIconNormal;

		// Token: 0x040340BB RID: 213179
		[Token(Token = "0x40340BB")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		[Group("HP")]
		private Color _colorHpIconTweening;

		// Token: 0x040340BC RID: 213180
		[Token(Token = "0x40340BC")]
		[FieldOffset(Offset = "0xE4")]
		[SerializeField]
		[Group("HP")]
		private Color _colorHpTextNormal;

		// Token: 0x040340BD RID: 213181
		[Token(Token = "0x40340BD")]
		[FieldOffset(Offset = "0xF4")]
		[SerializeField]
		[Group("HP")]
		private Color _colorHpTextTweening;

		// Token: 0x040340BE RID: 213182
		[Token(Token = "0x40340BE")]
		[FieldOffset(Offset = "0x108")]
		private PlayerAvatarView m_avatarView;

		// Token: 0x040340BF RID: 213183
		[Token(Token = "0x40340BF")]
		[FieldOffset(Offset = "0x110")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040340C0 RID: 213184
		[Token(Token = "0x40340C0")]
		[FieldOffset(Offset = "0x120")]
		private SeqNumSource.Checker m_hpChecker;

		// Token: 0x040340C1 RID: 213185
		[Token(Token = "0x40340C1")]
		[FieldOffset(Offset = "0x128")]
		private AutoChessBattlePlayerStatusModel m_itemModel;

		// Token: 0x040340C2 RID: 213186
		[Token(Token = "0x40340C2")]
		[FieldOffset(Offset = "0x130")]
		private int m_cacheHp;

		// Token: 0x040340C3 RID: 213187
		[Token(Token = "0x40340C3")]
		[FieldOffset(Offset = "0x138")]
		private Tween m_hpTween;

		// Token: 0x040340C4 RID: 213188
		[Token(Token = "0x40340C4")]
		[FieldOffset(Offset = "0x140")]
		private bool m_hasInited;

		// Token: 0x040340C5 RID: 213189
		[Token(Token = "0x40340C5")]
		[FieldOffset(Offset = "0x148")]
		private FadeSwitchTween m_obWidgetTween;

		// Token: 0x040340C6 RID: 213190
		[Token(Token = "0x40340C6")]
		[FieldOffset(Offset = "0x150")]
		private FadeSwitchTween m_cancelObTween;

		// Token: 0x040340C7 RID: 213191
		[Token(Token = "0x40340C7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_emojiRect;

		// Token: 0x040340C8 RID: 213192
		[Token(Token = "0x40340C8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040340C9 RID: 213193
		[Token(Token = "0x40340C9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGOIfNeed;

		// Token: 0x040340CA RID: 213194
		[Token(Token = "0x40340CA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetExclusiveGroup;

		// Token: 0x040340CB RID: 213195
		[Token(Token = "0x40340CB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040340CC RID: 213196
		[Token(Token = "0x40340CC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PlayHpTweenIfNeed;

		// Token: 0x040340CD RID: 213197
		[Token(Token = "0x40340CD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateHpAndDeadStatus;

		// Token: 0x040340CE RID: 213198
		[Token(Token = "0x40340CE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateHpVisible;

		// Token: 0x040340CF RID: 213199
		[Token(Token = "0x40340CF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderAvatar;

		// Token: 0x040340D0 RID: 213200
		[Token(Token = "0x40340D0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnObPreClick;

		// Token: 0x040340D1 RID: 213201
		[Token(Token = "0x40340D1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnObClick;

		// Token: 0x040340D2 RID: 213202
		[Token(Token = "0x40340D2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EventOnObResetToPreClick;

		// Token: 0x040340D3 RID: 213203
		[Token(Token = "0x40340D3")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnBtnObClick;

		// Token: 0x040340D4 RID: 213204
		[Token(Token = "0x40340D4")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EventOnBtnObNotAvail;

		// Token: 0x040340D5 RID: 213205
		[Token(Token = "0x40340D5")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_EventOnBtnCancelOb;

		// Token: 0x040340D6 RID: 213206
		[Token(Token = "0x40340D6")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
