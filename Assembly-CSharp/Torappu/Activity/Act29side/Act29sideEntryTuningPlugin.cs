using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act29side
{
	// Token: 0x020074A9 RID: 29865
	[Token(Token = "0x20074A9")]
	public class Act29sideEntryTuningPlugin : TemplateActivityCommonPlugin, IHotfixable
	{
		// Token: 0x0602A1FB RID: 172539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1FB")]
		[Address(RVA = "0x25AE400", Offset = "0x25AD000", VA = "0x1825AE400", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x0602A1FC RID: 172540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1FC")]
		[Address(RVA = "0x25AE220", Offset = "0x25ACE20", VA = "0x1825AE220")]
		public void OnClick()
		{
		}

		// Token: 0x0602A1FD RID: 172541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1FD")]
		[Address(RVA = "0x25AE760", Offset = "0x25AD360", VA = "0x1825AE760")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A1FE RID: 172542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1FE")]
		[Address(RVA = "0x25AE810", Offset = "0x25AD410", VA = "0x1825AE810")]
		public Act29sideEntryTuningPlugin()
		{
		}

		// Token: 0x0403C7D8 RID: 247768
		[Token(Token = "0x403C7D8")]
		[FieldOffset(Offset = "0x28")]
		private string m_actId;

		// Token: 0x0403C7D9 RID: 247769
		[Token(Token = "0x403C7D9")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x0403C7DA RID: 247770
		[Token(Token = "0x403C7DA")]
		[FieldOffset(Offset = "0x38")]
		private string m_toastDesc;

		// Token: 0x0403C7DB RID: 247771
		[Token(Token = "0x403C7DB")]
		[FieldOffset(Offset = "0x40")]
		private Act29sideEntryTuningViewModel.Status m_cachedCurrStatus;

		// Token: 0x0403C7DC RID: 247772
		[Token(Token = "0x403C7DC")]
		[FieldOffset(Offset = "0x48")]
		private string m_cachedCrossDayTrackId;

		// Token: 0x0403C7DD RID: 247773
		[Token(Token = "0x403C7DD")]
		[FieldOffset(Offset = "0x50")]
		private TrackPointViewProperty m_trackPointLockProp;

		// Token: 0x0403C7DE RID: 247774
		[Token(Token = "0x403C7DE")]
		[FieldOffset(Offset = "0x58")]
		private TrackPointViewProperty m_trackPointProp;

		// Token: 0x0403C7DF RID: 247775
		[Token(Token = "0x403C7DF")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UICommonTrackPoint _trackPointLock;

		// Token: 0x0403C7E0 RID: 247776
		[Token(Token = "0x403C7E0")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIActTrackPoint _trackPoint;

		// Token: 0x0403C7E1 RID: 247777
		[Token(Token = "0x403C7E1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _buttonClick;

		// Token: 0x0403C7E2 RID: 247778
		[Token(Token = "0x403C7E2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textUnlockDesc;

		// Token: 0x0403C7E3 RID: 247779
		[Token(Token = "0x403C7E3")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0403C7E4 RID: 247780
		[Token(Token = "0x403C7E4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403C7E5 RID: 247781
		[Token(Token = "0x403C7E5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403C7E6 RID: 247782
		[Token(Token = "0x403C7E6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403C7E7 RID: 247783
		[Token(Token = "0x403C7E7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020074AA RID: 29866
		[Token(Token = "0x20074AA")]
		public class TuningEntryTrackPointModel : ITrackPointModel, IHotfixable
		{
			// Token: 0x0602A1FF RID: 172543 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A1FF")]
			[Address(RVA = "0x25C38D0", Offset = "0x25C24D0", VA = "0x1825C38D0", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x17006353 RID: 25427
			// (get) Token: 0x0602A200 RID: 172544 RVA: 0x000D77D8 File Offset: 0x000D59D8
			[Token(Token = "0x17006353")]
			public bool isShow
			{
				[Token(Token = "0x602A200")]
				[Address(RVA = "0x25C3B40", Offset = "0x25C2740", VA = "0x1825C3B40", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0602A201 RID: 172545 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A201")]
			[Address(RVA = "0x25C3AE0", Offset = "0x25C26E0", VA = "0x1825C3AE0")]
			public TuningEntryTrackPointModel()
			{
			}

			// Token: 0x0403C7E8 RID: 247784
			[Token(Token = "0x403C7E8")]
			[FieldOffset(Offset = "0x10")]
			private bool m_isShow;

			// Token: 0x0403C7E9 RID: 247785
			[Token(Token = "0x403C7E9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x0403C7EA RID: 247786
			[Token(Token = "0x403C7EA")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x0403C7EB RID: 247787
			[Token(Token = "0x403C7EB")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x020074AB RID: 29867
			[Token(Token = "0x20074AB")]
			public class Param
			{
				// Token: 0x0602A202 RID: 172546 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x602A202")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Param()
				{
				}

				// Token: 0x0403C7EC RID: 247788
				[Token(Token = "0x403C7EC")]
				[FieldOffset(Offset = "0x10")]
				public string actId;

				// Token: 0x0403C7ED RID: 247789
				[Token(Token = "0x403C7ED")]
				[FieldOffset(Offset = "0x18")]
				public string crossDayTrackId;

				// Token: 0x0403C7EE RID: 247790
				[Token(Token = "0x403C7EE")]
				[FieldOffset(Offset = "0x20")]
				public bool isUnlock;
			}
		}

		// Token: 0x020074AC RID: 29868
		[Token(Token = "0x20074AC")]
		public class TuningEntryLockTrackPointModel : ITrackPointModel, IHotfixable
		{
			// Token: 0x0602A203 RID: 172547 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A203")]
			[Address(RVA = "0x25C36E0", Offset = "0x25C22E0", VA = "0x1825C36E0", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x17006354 RID: 25428
			// (get) Token: 0x0602A204 RID: 172548 RVA: 0x000D77F0 File Offset: 0x000D59F0
			[Token(Token = "0x17006354")]
			public bool isShow
			{
				[Token(Token = "0x602A204")]
				[Address(RVA = "0x25C3870", Offset = "0x25C2470", VA = "0x1825C3870", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0602A205 RID: 172549 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A205")]
			[Address(RVA = "0x25C3810", Offset = "0x25C2410", VA = "0x1825C3810")]
			public TuningEntryLockTrackPointModel()
			{
			}

			// Token: 0x0403C7EF RID: 247791
			[Token(Token = "0x403C7EF")]
			[FieldOffset(Offset = "0x10")]
			private bool m_isShow;

			// Token: 0x0403C7F0 RID: 247792
			[Token(Token = "0x403C7F0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x0403C7F1 RID: 247793
			[Token(Token = "0x403C7F1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x0403C7F2 RID: 247794
			[Token(Token = "0x403C7F2")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x020074AD RID: 29869
			[Token(Token = "0x20074AD")]
			public class Param
			{
				// Token: 0x0602A206 RID: 172550 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x602A206")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Param()
				{
				}

				// Token: 0x0403C7F3 RID: 247795
				[Token(Token = "0x403C7F3")]
				[FieldOffset(Offset = "0x10")]
				public string actId;

				// Token: 0x0403C7F4 RID: 247796
				[Token(Token = "0x403C7F4")]
				[FieldOffset(Offset = "0x18")]
				public bool isUnlock;
			}
		}
	}
}
