using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x0200653D RID: 25917
	[Token(Token = "0x200653D")]
	public class ArtMagazineCoverOverviewView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060253F2 RID: 152562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253F2")]
		[Address(RVA = "0x20345D0", Offset = "0x20331D0", VA = "0x1820345D0")]
		public void Render(ArtMagazineCoverOverviewHomeViewModel viewModel)
		{
		}

		// Token: 0x060253F3 RID: 152563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253F3")]
		[Address(RVA = "0x20344B0", Offset = "0x20330B0", VA = "0x1820344B0")]
		public void EventOnArrowLeftClick()
		{
		}

		// Token: 0x060253F4 RID: 152564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253F4")]
		[Address(RVA = "0x2034540", Offset = "0x2033140", VA = "0x182034540")]
		public void EventOnArrowRightClick()
		{
		}

		// Token: 0x060253F5 RID: 152565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253F5")]
		[Address(RVA = "0x2034B40", Offset = "0x2033740", VA = "0x182034B40")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060253F6 RID: 152566 RVA: 0x000C7290 File Offset: 0x000C5490
		[Token(Token = "0x60253F6")]
		[Address(RVA = "0x2034900", Offset = "0x2033500", VA = "0x182034900")]
		private bool _CheckIfShowGroupFaseMode(ArtMagazineCoverOverviewHomeViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x060253F7 RID: 152567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253F7")]
		[Address(RVA = "0x2034FB0", Offset = "0x2033BB0", VA = "0x182034FB0")]
		private void _SwitchContentGroup(bool fastMode)
		{
		}

		// Token: 0x060253F8 RID: 152568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253F8")]
		[Address(RVA = "0x2034DA0", Offset = "0x20339A0", VA = "0x182034DA0")]
		private void _RenderGroupView()
		{
		}

		// Token: 0x060253F9 RID: 152569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253F9")]
		[Address(RVA = "0x2035160", Offset = "0x2033D60", VA = "0x182035160")]
		public ArtMagazineCoverOverviewView()
		{
		}

		// Token: 0x04034420 RID: 214048
		[Token(Token = "0x4034420")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasView;

		// Token: 0x04034421 RID: 214049
		[Token(Token = "0x4034421")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasViewInfo;

		// Token: 0x04034422 RID: 214050
		[Token(Token = "0x4034422")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasViewGroup;

		// Token: 0x04034423 RID: 214051
		[Token(Token = "0x4034423")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _fadeOutContentTime;

		// Token: 0x04034424 RID: 214052
		[Token(Token = "0x4034424")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _fadeInContentTime;

		// Token: 0x04034425 RID: 214053
		[Token(Token = "0x4034425")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleLayoutContent _dotList;

		// Token: 0x04034426 RID: 214054
		[Token(Token = "0x4034426")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ArtMagazineCoverOverviewGroupView _groupView;

		// Token: 0x04034427 RID: 214055
		[Token(Token = "0x4034427")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _canvasNoInfo;

		// Token: 0x04034428 RID: 214056
		[Token(Token = "0x4034428")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x04034429 RID: 214057
		[Token(Token = "0x4034429")]
		[FieldOffset(Offset = "0x58")]
		private FadeSwitchTween m_tweenViewInfo;

		// Token: 0x0403442A RID: 214058
		[Token(Token = "0x403442A")]
		[FieldOffset(Offset = "0x60")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403442B RID: 214059
		[Token(Token = "0x403442B")]
		[FieldOffset(Offset = "0x70")]
		private int m_groupCount;

		// Token: 0x0403442C RID: 214060
		[Token(Token = "0x403442C")]
		[FieldOffset(Offset = "0x74")]
		private int m_curGroupIndex;

		// Token: 0x0403442D RID: 214061
		[Token(Token = "0x403442D")]
		[FieldOffset(Offset = "0x78")]
		private ArtMagazineCoverOverviewView.DotListAdapter m_dotAdapter;

		// Token: 0x0403442E RID: 214062
		[Token(Token = "0x403442E")]
		[FieldOffset(Offset = "0x80")]
		private FadeSwitchTween m_noInfoTween;

		// Token: 0x0403442F RID: 214063
		[Token(Token = "0x403442F")]
		[FieldOffset(Offset = "0x88")]
		private FadeSwitchTween m_viewTween;

		// Token: 0x04034430 RID: 214064
		[Token(Token = "0x4034430")]
		[FieldOffset(Offset = "0x90")]
		private Sequence m_groupViewSwitchSequence;

		// Token: 0x04034431 RID: 214065
		[Token(Token = "0x4034431")]
		[FieldOffset(Offset = "0x98")]
		private ArtMagazineCoverOverviewGroupViewModel m_cacheGroupViewModel;

		// Token: 0x04034432 RID: 214066
		[Token(Token = "0x4034432")]
		[FieldOffset(Offset = "0xA0")]
		private int m_cachedEnterSeq;

		// Token: 0x04034433 RID: 214067
		[Token(Token = "0x4034433")]
		[FieldOffset(Offset = "0xA4")]
		private bool m_cachedShowInfo;

		// Token: 0x04034434 RID: 214068
		[Token(Token = "0x4034434")]
		[FieldOffset(Offset = "0xA5")]
		private bool m_cachedDisplayShow;

		// Token: 0x04034435 RID: 214069
		[Token(Token = "0x4034435")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04034436 RID: 214070
		[Token(Token = "0x4034436")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnArrowLeftClick;

		// Token: 0x04034437 RID: 214071
		[Token(Token = "0x4034437")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnArrowRightClick;

		// Token: 0x04034438 RID: 214072
		[Token(Token = "0x4034438")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04034439 RID: 214073
		[Token(Token = "0x4034439")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckIfShowGroupFaseMode;

		// Token: 0x0403443A RID: 214074
		[Token(Token = "0x403443A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SwitchContentGroup;

		// Token: 0x0403443B RID: 214075
		[Token(Token = "0x403443B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderGroupView;

		// Token: 0x0403443C RID: 214076
		[Token(Token = "0x403443C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200653E RID: 25918
		[Token(Token = "0x200653E")]
		private class DotListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x060253FA RID: 152570 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60253FA")]
			[Address(RVA = "0x2040080", Offset = "0x203EC80", VA = "0x182040080")]
			public DotListAdapter(ArtMagazineCoverOverviewView closure)
			{
			}

			// Token: 0x170057ED RID: 22509
			// (get) Token: 0x060253FB RID: 152571 RVA: 0x000C72A8 File Offset: 0x000C54A8
			[Token(Token = "0x170057ED")]
			public override int count
			{
				[Token(Token = "0x60253FB")]
				[Address(RVA = "0x2040100", Offset = "0x203ED00", VA = "0x182040100", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060253FC RID: 152572 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60253FC")]
			[Address(RVA = "0x203FDB0", Offset = "0x203E9B0", VA = "0x18203FDB0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403443D RID: 214077
			[Token(Token = "0x403443D")]
			[FieldOffset(Offset = "0x20")]
			private ArtMagazineCoverOverviewView m_closure;

			// Token: 0x0403443E RID: 214078
			[Token(Token = "0x403443E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403443F RID: 214079
			[Token(Token = "0x403443F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04034440 RID: 214080
			[Token(Token = "0x4034440")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
