using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x020070F9 RID: 28921
	[Token(Token = "0x20070F9")]
	public class ActAutoChessHandbookTopBarView : DataBinder<ActAutoChessHandbookProperty>, IHotfixable
	{
		// Token: 0x060291C3 RID: 168387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291C3")]
		[Address(RVA = "0x2487980", Offset = "0x2486580", VA = "0x182487980", Slot = "7")]
		public override void OnValueChanged(ActAutoChessHandbookProperty property)
		{
		}

		// Token: 0x060291C4 RID: 168388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291C4")]
		[Address(RVA = "0x2487EF0", Offset = "0x2486AF0", VA = "0x182487EF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060291C5 RID: 168389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291C5")]
		[Address(RVA = "0x2487DE0", Offset = "0x24869E0", VA = "0x182487DE0")]
		private void _EventOnTabItemClicked(ActAutoChessHandbookTabType tabType)
		{
		}

		// Token: 0x060291C6 RID: 168390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291C6")]
		[Address(RVA = "0x24878C0", Offset = "0x24864C0", VA = "0x1824878C0")]
		public void EventOnBondTabClicked()
		{
		}

		// Token: 0x060291C7 RID: 168391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291C7")]
		[Address(RVA = "0x2487860", Offset = "0x2486460", VA = "0x182487860")]
		public void EventOnBandTabClicked()
		{
		}

		// Token: 0x060291C8 RID: 168392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291C8")]
		[Address(RVA = "0x2487920", Offset = "0x2486520", VA = "0x182487920")]
		public void EventOnEnemyTabClicked()
		{
		}

		// Token: 0x060291C9 RID: 168393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291C9")]
		[Address(RVA = "0x2488100", Offset = "0x2486D00", VA = "0x182488100")]
		public ActAutoChessHandbookTopBarView()
		{
		}

		// Token: 0x0403AAF5 RID: 240373
		[Token(Token = "0x403AAF5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ActAutoChessHandbookTopBarView.TopBarItem[] _topBarItemList;

		// Token: 0x0403AAF6 RID: 240374
		[Token(Token = "0x403AAF6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIActTrackPoint _trackPoint;

		// Token: 0x0403AAF7 RID: 240375
		[Token(Token = "0x403AAF7")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, UISwitchTween> m_topBatItemDict;

		// Token: 0x0403AAF8 RID: 240376
		[Token(Token = "0x403AAF8")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x0403AAF9 RID: 240377
		[Token(Token = "0x403AAF9")]
		[FieldOffset(Offset = "0x3C")]
		private int m_cachedSequence;

		// Token: 0x0403AAFA RID: 240378
		[Token(Token = "0x403AAFA")]
		[FieldOffset(Offset = "0x40")]
		private TrackPointViewProperty m_trackPointProperty;

		// Token: 0x0403AAFB RID: 240379
		[Token(Token = "0x403AAFB")]
		[FieldOffset(Offset = "0x48")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403AAFC RID: 240380
		[Token(Token = "0x403AAFC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403AAFD RID: 240381
		[Token(Token = "0x403AAFD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403AAFE RID: 240382
		[Token(Token = "0x403AAFE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EventOnTabItemClicked;

		// Token: 0x0403AAFF RID: 240383
		[Token(Token = "0x403AAFF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnBondTabClicked;

		// Token: 0x0403AB00 RID: 240384
		[Token(Token = "0x403AB00")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnBandTabClicked;

		// Token: 0x0403AB01 RID: 240385
		[Token(Token = "0x403AB01")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnEnemyTabClicked;

		// Token: 0x0403AB02 RID: 240386
		[Token(Token = "0x403AB02")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020070FA RID: 28922
		[Token(Token = "0x20070FA")]
		[Serializable]
		private struct TopBarItem
		{
			// Token: 0x0403AB03 RID: 240387
			[Token(Token = "0x403AB03")]
			[FieldOffset(Offset = "0x0")]
			public ActAutoChessHandbookTabType tabType;

			// Token: 0x0403AB04 RID: 240388
			[Token(Token = "0x403AB04")]
			[FieldOffset(Offset = "0x8")]
			public CanvasGroup canvasGroup;
		}

		// Token: 0x020070FB RID: 28923
		[Token(Token = "0x20070FB")]
		private class BandTrackPointModel : ITrackPointModel, IHotfixable
		{
			// Token: 0x17006165 RID: 24933
			// (get) Token: 0x060291CA RID: 168394 RVA: 0x000D4838 File Offset: 0x000D2A38
			// (set) Token: 0x060291CB RID: 168395 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17006165")]
			public bool isShow
			{
				[Token(Token = "0x60291CA")]
				[Address(RVA = "0x248F980", Offset = "0x248E580", VA = "0x18248F980", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60291CB")]
				[Address(RVA = "0x248F9E0", Offset = "0x248E5E0", VA = "0x18248F9E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060291CC RID: 168396 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60291CC")]
			[Address(RVA = "0x248F860", Offset = "0x248E460", VA = "0x18248F860", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x060291CD RID: 168397 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60291CD")]
			[Address(RVA = "0x248F920", Offset = "0x248E520", VA = "0x18248F920")]
			public BandTrackPointModel()
			{
			}

			// Token: 0x0403AB06 RID: 240390
			[Token(Token = "0x403AB06")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x0403AB07 RID: 240391
			[Token(Token = "0x403AB07")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_isShow;

			// Token: 0x0403AB08 RID: 240392
			[Token(Token = "0x403AB08")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x0403AB09 RID: 240393
			[Token(Token = "0x403AB09")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
