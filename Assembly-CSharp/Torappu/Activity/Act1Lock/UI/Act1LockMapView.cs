using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x020078B4 RID: 30900
	[Token(Token = "0x20078B4")]
	public class Act1LockMapView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602B54F RID: 177487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B54F")]
		[Address(RVA = "0x27287A0", Offset = "0x27273A0", VA = "0x1827287A0")]
		public void RenderMap(Act1LockZoneMapViewModel mapViewModel)
		{
		}

		// Token: 0x0602B550 RID: 177488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B550")]
		[Address(RVA = "0x2729560", Offset = "0x2728160", VA = "0x182729560")]
		private void _RenderStagesFirstTime(Act1LockZoneMapViewModel mapViewModel)
		{
		}

		// Token: 0x0602B551 RID: 177489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B551")]
		[Address(RVA = "0x27290E0", Offset = "0x2727CE0", VA = "0x1827290E0")]
		private void _RefreshStages(Act1LockZoneMapViewModel mapViewModel)
		{
		}

		// Token: 0x0602B552 RID: 177490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B552")]
		[Address(RVA = "0x2729E20", Offset = "0x2728A20", VA = "0x182729E20")]
		private void _TryFocusStage(Act1LockStageBtnHolder btnHolder, ActivityInterlockData.InterlockStageType stageType)
		{
		}

		// Token: 0x0602B553 RID: 177491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B553")]
		[Address(RVA = "0x27294B0", Offset = "0x27280B0", VA = "0x1827294B0")]
		private void _RenderBkg()
		{
		}

		// Token: 0x0602B554 RID: 177492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B554")]
		[Address(RVA = "0x2729040", Offset = "0x2727C40", VA = "0x182729040")]
		private void _InitPos()
		{
		}

		// Token: 0x0602B555 RID: 177493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B555")]
		[Address(RVA = "0x2728AC0", Offset = "0x27276C0", VA = "0x182728AC0")]
		private void _ApplyToPos(RectTransform buttonTrans, RectTransform _focusBound)
		{
		}

		// Token: 0x0602B556 RID: 177494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B556")]
		[Address(RVA = "0x2728CF0", Offset = "0x27278F0", VA = "0x182728CF0")]
		private void _FocusToValue(float targetPos)
		{
		}

		// Token: 0x0602B557 RID: 177495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B557")]
		[Address(RVA = "0x2729FA0", Offset = "0x2728BA0", VA = "0x182729FA0")]
		private void _TryResetFocus()
		{
		}

		// Token: 0x0602B558 RID: 177496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B558")]
		[Address(RVA = "0x272A030", Offset = "0x2728C30", VA = "0x18272A030")]
		private void _TryTriggerUnlockToast(bool isFinalFirst, bool isInterlockFirst)
		{
		}

		// Token: 0x0602B559 RID: 177497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B559")]
		[Address(RVA = "0x2729C80", Offset = "0x2728880", VA = "0x182729C80")]
		private void _TraceMapAVG()
		{
		}

		// Token: 0x0602B55A RID: 177498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B55A")]
		[Address(RVA = "0x2728F40", Offset = "0x2727B40", VA = "0x182728F40")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B55B RID: 177499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B55B")]
		[Address(RVA = "0x272A160", Offset = "0x2728D60", VA = "0x18272A160")]
		public Act1LockMapView()
		{
		}

		// Token: 0x0403EA3D RID: 256573
		[Token(Token = "0x403EA3D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _normalFocusBound;

		// Token: 0x0403EA3E RID: 256574
		[Token(Token = "0x403EA3E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _interlockFocusBound;

		// Token: 0x0403EA3F RID: 256575
		[Token(Token = "0x403EA3F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgBkg;

		// Token: 0x0403EA40 RID: 256576
		[Token(Token = "0x403EA40")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _btnContainer;

		// Token: 0x0403EA41 RID: 256577
		[Token(Token = "0x403EA41")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Act1LockPointView _milestonePointView;

		// Token: 0x0403EA42 RID: 256578
		[Token(Token = "0x403EA42")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _bkgDayMask;

		// Token: 0x0403EA43 RID: 256579
		[Token(Token = "0x403EA43")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _bkgSunsetMask;

		// Token: 0x0403EA44 RID: 256580
		[Token(Token = "0x403EA44")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Act1LockStageBtn _normalStageObj;

		// Token: 0x0403EA45 RID: 256581
		[Token(Token = "0x403EA45")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Act1LockStageBtn _lockStageObj;

		// Token: 0x0403EA46 RID: 256582
		[Token(Token = "0x403EA46")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Act1LockStageBtn _ultimateStageObj;

		// Token: 0x0403EA47 RID: 256583
		[Token(Token = "0x403EA47")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Act1LockStageBtnHolder[] _stageBtnHolders;

		// Token: 0x0403EA48 RID: 256584
		[Token(Token = "0x403EA48")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act1LockStageLine[] _stageLines;

		// Token: 0x0403EA49 RID: 256585
		[Token(Token = "0x403EA49")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Color _interLockedColor;

		// Token: 0x0403EA4A RID: 256586
		[Token(Token = "0x403EA4A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Color _interNormalColor;

		// Token: 0x0403EA4B RID: 256587
		[Token(Token = "0x403EA4B")]
		[FieldOffset(Offset = "0x98")]
		[NonSerialized]
		public Action<string> onStageClickEvent;

		// Token: 0x0403EA4C RID: 256588
		[Token(Token = "0x403EA4C")]
		private const int FIRST_INTERLOCK_STAGE_SORTID = 1;

		// Token: 0x0403EA4D RID: 256589
		[Token(Token = "0x403EA4D")]
		[FieldOffset(Offset = "0xA0")]
		private Act1LockZoneMapViewModel m_cachedZoneViewModel;

		// Token: 0x0403EA4E RID: 256590
		[Token(Token = "0x403EA4E")]
		[FieldOffset(Offset = "0xA8")]
		private Act1LockStageBtn m_cachedSelectedBtn;

		// Token: 0x0403EA4F RID: 256591
		[Token(Token = "0x403EA4F")]
		[FieldOffset(Offset = "0xB0")]
		private Tween m_tweenBkg;

		// Token: 0x0403EA50 RID: 256592
		[Token(Token = "0x403EA50")]
		[FieldOffset(Offset = "0xB8")]
		private Tween m_tweenBtn;

		// Token: 0x0403EA51 RID: 256593
		[Token(Token = "0x403EA51")]
		[FieldOffset(Offset = "0xC0")]
		private float m_positionValue;

		// Token: 0x0403EA52 RID: 256594
		[Token(Token = "0x403EA52")]
		[FieldOffset(Offset = "0xC4")]
		private float m_initValue;

		// Token: 0x0403EA53 RID: 256595
		[Token(Token = "0x403EA53")]
		[FieldOffset(Offset = "0xC8")]
		private Act1LockStageBtn m_cachedGuideInterlockBtn;

		// Token: 0x0403EA54 RID: 256596
		[Token(Token = "0x403EA54")]
		[FieldOffset(Offset = "0xD0")]
		private Act1LockStageBtn m_cachedGuideFinalBtn;

		// Token: 0x0403EA55 RID: 256597
		[Token(Token = "0x403EA55")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_inited;

		// Token: 0x0403EA56 RID: 256598
		[Token(Token = "0x403EA56")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderMap;

		// Token: 0x0403EA57 RID: 256599
		[Token(Token = "0x403EA57")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderStagesFirstTime;

		// Token: 0x0403EA58 RID: 256600
		[Token(Token = "0x403EA58")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RefreshStages;

		// Token: 0x0403EA59 RID: 256601
		[Token(Token = "0x403EA59")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TryFocusStage;

		// Token: 0x0403EA5A RID: 256602
		[Token(Token = "0x403EA5A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderBkg;

		// Token: 0x0403EA5B RID: 256603
		[Token(Token = "0x403EA5B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitPos;

		// Token: 0x0403EA5C RID: 256604
		[Token(Token = "0x403EA5C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ApplyToPos;

		// Token: 0x0403EA5D RID: 256605
		[Token(Token = "0x403EA5D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__FocusToValue;

		// Token: 0x0403EA5E RID: 256606
		[Token(Token = "0x403EA5E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__TryResetFocus;

		// Token: 0x0403EA5F RID: 256607
		[Token(Token = "0x403EA5F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TryTriggerUnlockToast;

		// Token: 0x0403EA60 RID: 256608
		[Token(Token = "0x403EA60")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TraceMapAVG;

		// Token: 0x0403EA61 RID: 256609
		[Token(Token = "0x403EA61")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403EA62 RID: 256610
		[Token(Token = "0x403EA62")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
