using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004F21 RID: 20257
	[Token(Token = "0x2004F21")]
	public class FifthAnnivExploreTopMenuView : DataBinder<FifthAnnivExploreProperty>, IHotfixable
	{
		// Token: 0x170046C2 RID: 18114
		// (get) Token: 0x0601E2F1 RID: 123633 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601E2F0 RID: 123632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170046C2")]
		public Action onHeritageBtnClick
		{
			[Token(Token = "0x601E2F1")]
			[Address(RVA = "0x17F4500", Offset = "0x17F3100", VA = "0x1817F4500")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601E2F0")]
			[Address(RVA = "0x17F45C0", Offset = "0x17F31C0", VA = "0x1817F45C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170046C3 RID: 18115
		// (get) Token: 0x0601E2F3 RID: 123635 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601E2F2 RID: 123634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170046C3")]
		public Action onProgressBtnClick
		{
			[Token(Token = "0x601E2F3")]
			[Address(RVA = "0x17F4560", Offset = "0x17F3160", VA = "0x1817F4560")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601E2F2")]
			[Address(RVA = "0x17F4640", Offset = "0x17F3240", VA = "0x1817F4640")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601E2F4 RID: 123636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2F4")]
		[Address(RVA = "0x17F4230", Offset = "0x17F2E30", VA = "0x1817F4230")]
		private void _OnHeritageBtnClick()
		{
		}

		// Token: 0x0601E2F5 RID: 123637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2F5")]
		[Address(RVA = "0x17F4340", Offset = "0x17F2F40", VA = "0x1817F4340")]
		private void _OnProgressBtnClick()
		{
		}

		// Token: 0x0601E2F6 RID: 123638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2F6")]
		[Address(RVA = "0x17F3F70", Offset = "0x17F2B70", VA = "0x1817F3F70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E2F7 RID: 123639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2F7")]
		[Address(RVA = "0x17F3D70", Offset = "0x17F2970", VA = "0x1817F3D70", Slot = "7")]
		public override void OnValueChanged(FifthAnnivExploreProperty property)
		{
		}

		// Token: 0x0601E2F8 RID: 123640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2F8")]
		[Address(RVA = "0x17F4450", Offset = "0x17F3050", VA = "0x1817F4450")]
		public FifthAnnivExploreTopMenuView()
		{
		}

		// Token: 0x0402833E RID: 164670
		[Token(Token = "0x402833E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _dynViewContainer;

		// Token: 0x0402833F RID: 164671
		[Token(Token = "0x402833F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private FifthAnnivExploreTopMenuHeritageView _heritageViewPrefab;

		// Token: 0x04028340 RID: 164672
		[Token(Token = "0x4028340")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private FifthAnnivExploreTopMenuProgressView _progressViewPrefab;

		// Token: 0x04028341 RID: 164673
		[Token(Token = "0x4028341")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UICommonTrackPoint _missionTrackpoint;

		// Token: 0x04028344 RID: 164676
		[Token(Token = "0x4028344")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x04028345 RID: 164677
		[Token(Token = "0x4028345")]
		[FieldOffset(Offset = "0x58")]
		private FifthAnnivExploreTopMenuHeritageView m_heritageView;

		// Token: 0x04028346 RID: 164678
		[Token(Token = "0x4028346")]
		[FieldOffset(Offset = "0x60")]
		private FifthAnnivExploreTopMenuProgressView m_progressView;

		// Token: 0x04028347 RID: 164679
		[Token(Token = "0x4028347")]
		[FieldOffset(Offset = "0x68")]
		private TrackPointViewProperty m_missionTrackPointViewProperty;

		// Token: 0x04028348 RID: 164680
		[Token(Token = "0x4028348")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_onHeritageBtnClick;

		// Token: 0x04028349 RID: 164681
		[Token(Token = "0x4028349")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onHeritageBtnClick;

		// Token: 0x0402834A RID: 164682
		[Token(Token = "0x402834A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_onProgressBtnClick;

		// Token: 0x0402834B RID: 164683
		[Token(Token = "0x402834B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_onProgressBtnClick;

		// Token: 0x0402834C RID: 164684
		[Token(Token = "0x402834C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnHeritageBtnClick;

		// Token: 0x0402834D RID: 164685
		[Token(Token = "0x402834D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnProgressBtnClick;

		// Token: 0x0402834E RID: 164686
		[Token(Token = "0x402834E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402834F RID: 164687
		[Token(Token = "0x402834F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04028350 RID: 164688
		[Token(Token = "0x4028350")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
