using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200696F RID: 26991
	[Token(Token = "0x200696F")]
	public class StagePreviewConfigController : DataBinder<PreviewConfigViewProperty>
	{
		// Token: 0x17005B2D RID: 23341
		// (get) Token: 0x060269FE RID: 158206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B2D")]
		protected UIPageListener pageListener
		{
			[Token(Token = "0x60269FE")]
			[Address(RVA = "0x21B04F0", Offset = "0x21AF0F0", VA = "0x1821B04F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060269FF RID: 158207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269FF")]
		[Address(RVA = "0x21AF2E0", Offset = "0x21ADEE0", VA = "0x1821AF2E0")]
		public void OnAutoBattleLocked()
		{
		}

		// Token: 0x06026A00 RID: 158208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A00")]
		[Address(RVA = "0x21AF3A0", Offset = "0x21ADFA0", VA = "0x1821AF3A0", Slot = "7")]
		public override void OnValueChanged(PreviewConfigViewProperty property)
		{
		}

		// Token: 0x06026A01 RID: 158209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A01")]
		[Address(RVA = "0x21AFDF0", Offset = "0x21AE9F0", VA = "0x1821AFDF0")]
		private void _ShowPanelAsNormal(PreviewConfigViewModel viewModel)
		{
		}

		// Token: 0x06026A02 RID: 158210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A02")]
		[Address(RVA = "0x21AFD10", Offset = "0x21AE910", VA = "0x1821AFD10")]
		private void _ShowPanelAsHard(PreviewConfigViewModel viewModel)
		{
		}

		// Token: 0x06026A03 RID: 158211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A03")]
		[Address(RVA = "0x21AFF80", Offset = "0x21AEB80", VA = "0x1821AFF80")]
		private void _ShowPanelAsSixStar(PreviewConfigViewModel viewModel)
		{
		}

		// Token: 0x06026A04 RID: 158212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A04")]
		[Address(RVA = "0x21B0040", Offset = "0x21AEC40", VA = "0x1821B0040")]
		private void _UpdateStartBattleButton(PreviewConfigViewModel viewModel)
		{
		}

		// Token: 0x06026A05 RID: 158213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A05")]
		[Address(RVA = "0x21AF9E0", Offset = "0x21AE5E0", VA = "0x1821AF9E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026A06 RID: 158214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A06")]
		[Address(RVA = "0x21B0480", Offset = "0x21AF080", VA = "0x1821B0480")]
		public StagePreviewConfigController()
		{
		}

		// Token: 0x04036830 RID: 223280
		[Token(Token = "0x4036830")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _btnPractise;

		// Token: 0x04036831 RID: 223281
		[Token(Token = "0x4036831")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle _btnHard;

		// Token: 0x04036832 RID: 223282
		[Token(Token = "0x4036832")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _btnHardLocked;

		// Token: 0x04036833 RID: 223283
		[Token(Token = "0x4036833")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _btnSixStar;

		// Token: 0x04036834 RID: 223284
		[Token(Token = "0x4036834")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TwoStateToggle _tglAutoBattle;

		// Token: 0x04036835 RID: 223285
		[Token(Token = "0x4036835")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _autoBattleLocked;

		// Token: 0x04036836 RID: 223286
		[Token(Token = "0x4036836")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _tglReplayStory;

		// Token: 0x04036837 RID: 223287
		[Token(Token = "0x4036837")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _aniMultipleBtn;

		// Token: 0x04036838 RID: 223288
		[Token(Token = "0x4036838")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button _multipleBtn;

		// Token: 0x04036839 RID: 223289
		[Token(Token = "0x4036839")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textMultipleBattleTimes;

		// Token: 0x0403683A RID: 223290
		[Token(Token = "0x403683A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CanvasGroup _canvasMultiTwiceAndMoreDesc;

		// Token: 0x0403683B RID: 223291
		[Token(Token = "0x403683B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CanvasGroup _canvasMultiSingleDesc;

		// Token: 0x0403683C RID: 223292
		[Token(Token = "0x403683C")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private CanvasGroup _canvasMultiTwiceAndMoreCircle;

		// Token: 0x0403683D RID: 223293
		[Token(Token = "0x403683D")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private CanvasGroup _canvasMultiSingleCircle;

		// Token: 0x0403683E RID: 223294
		[Token(Token = "0x403683E")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		protected Text _apCostText;

		// Token: 0x0403683F RID: 223295
		[Token(Token = "0x403683F")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Color _commonApCostColor;

		// Token: 0x04036840 RID: 223296
		[Token(Token = "0x4036840")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Color _groupApCostColor;

		// Token: 0x04036841 RID: 223297
		[Token(Token = "0x4036841")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Button _btnStartBattleAp;

		// Token: 0x04036842 RID: 223298
		[Token(Token = "0x4036842")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private RectTransform _containerStartBattleOverride;

		// Token: 0x04036843 RID: 223299
		[Token(Token = "0x4036843")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private StageStartBattleETButton _prefabStartBattleEt;

		// Token: 0x04036844 RID: 223300
		[Token(Token = "0x4036844")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private StageStartBattleCustomButton _prefabStartBattleEditablePredefined;

		// Token: 0x04036845 RID: 223301
		[Token(Token = "0x4036845")]
		[FieldOffset(Offset = "0xE0")]
		private StageStartBattleETButton m_btnStartBattleEt;

		// Token: 0x04036846 RID: 223302
		[Token(Token = "0x4036846")]
		[FieldOffset(Offset = "0xE8")]
		private StageStartBattleCustomButton m_btnStartBattleCustom;

		// Token: 0x04036847 RID: 223303
		[Token(Token = "0x4036847")]
		[FieldOffset(Offset = "0xF0")]
		private AnimationSwitchTween m_aniMultipleBtnSwitchTween;

		// Token: 0x04036848 RID: 223304
		[Token(Token = "0x4036848")]
		[FieldOffset(Offset = "0xF8")]
		private FadeSwitchTween m_mulitpleTwiceAndMoreDescSwitchTween;

		// Token: 0x04036849 RID: 223305
		[Token(Token = "0x4036849")]
		[FieldOffset(Offset = "0x100")]
		private FadeSwitchTween m_mulitpleSingleDescSwitchTween;

		// Token: 0x0403684A RID: 223306
		[Token(Token = "0x403684A")]
		[FieldOffset(Offset = "0x108")]
		private FadeSwitchTween m_mulitpleTwiceAndMoreCircleSwitchTween;

		// Token: 0x0403684B RID: 223307
		[Token(Token = "0x403684B")]
		[FieldOffset(Offset = "0x110")]
		private FadeSwitchTween m_mulitpleSingleCircleSwitchTween;

		// Token: 0x0403684C RID: 223308
		[Token(Token = "0x403684C")]
		[FieldOffset(Offset = "0x118")]
		private bool m_isInited;

		// Token: 0x0403684D RID: 223309
		[Token(Token = "0x403684D")]
		[FieldOffset(Offset = "0x119")]
		private bool m_isAutoBattleUnlocked;

		// Token: 0x0403684E RID: 223310
		[Token(Token = "0x403684E")]
		[FieldOffset(Offset = "0x11A")]
		private bool m_isCampaign;

		// Token: 0x0403684F RID: 223311
		[Token(Token = "0x403684F")]
		[FieldOffset(Offset = "0x120")]
		private UIPageListener m_pageListener;

		// Token: 0x04036850 RID: 223312
		[Token(Token = "0x4036850")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_pageListener;

		// Token: 0x04036851 RID: 223313
		[Token(Token = "0x4036851")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnAutoBattleLocked;

		// Token: 0x04036852 RID: 223314
		[Token(Token = "0x4036852")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04036853 RID: 223315
		[Token(Token = "0x4036853")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ShowPanelAsNormal;

		// Token: 0x04036854 RID: 223316
		[Token(Token = "0x4036854")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ShowPanelAsHard;

		// Token: 0x04036855 RID: 223317
		[Token(Token = "0x4036855")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ShowPanelAsSixStar;

		// Token: 0x04036856 RID: 223318
		[Token(Token = "0x4036856")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateStartBattleButton;

		// Token: 0x04036857 RID: 223319
		[Token(Token = "0x4036857")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04036858 RID: 223320
		[Token(Token = "0x4036858")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
