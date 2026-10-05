using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076EA RID: 30442
	[Token(Token = "0x20076EA")]
	public class Act1VHalfIdleEntryMilestonePlugin : AbstractTemplateActivityEntryMilestonePlugin
	{
		// Token: 0x0602AC8C RID: 175244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC8C")]
		[Address(RVA = "0x2687400", Offset = "0x2686000", VA = "0x182687400")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AC8D RID: 175245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC8D")]
		[Address(RVA = "0x2686E20", Offset = "0x2685A20", VA = "0x182686E20", Slot = "6")]
		protected override void OnViewModelRefresh(TemplateActivityMilestoneGroupViewModel viewModel)
		{
		}

		// Token: 0x0602AC8E RID: 175246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC8E")]
		[Address(RVA = "0x2687550", Offset = "0x2686150", VA = "0x182687550")]
		public Act1VHalfIdleEntryMilestonePlugin()
		{
		}

		// Token: 0x0403DA76 RID: 252534
		[Token(Token = "0x403DA76")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _newObj;

		// Token: 0x0403DA77 RID: 252535
		[Token(Token = "0x403DA77")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Slider _progSlider;

		// Token: 0x0403DA78 RID: 252536
		[Token(Token = "0x403DA78")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _lvlText;

		// Token: 0x0403DA79 RID: 252537
		[Token(Token = "0x403DA79")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private TwoStateToggle _maxLvlToggle;

		// Token: 0x0403DA7A RID: 252538
		[Token(Token = "0x403DA7A")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UICommonTrackPoint _newProgressTrack;

		// Token: 0x0403DA7B RID: 252539
		[Token(Token = "0x403DA7B")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Image _milestoneIconImg;

		// Token: 0x0403DA7C RID: 252540
		[Token(Token = "0x403DA7C")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_isMileStoneEnable;

		// Token: 0x0403DA7D RID: 252541
		[Token(Token = "0x403DA7D")]
		[FieldOffset(Offset = "0xA9")]
		private bool m_isEntryPluginInited;

		// Token: 0x0403DA7E RID: 252542
		[Token(Token = "0x403DA7E")]
		[FieldOffset(Offset = "0xB0")]
		private TrackPointViewProperty m_trackUpdatedProp;

		// Token: 0x0403DA7F RID: 252543
		[Token(Token = "0x403DA7F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403DA80 RID: 252544
		[Token(Token = "0x403DA80")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403DA81 RID: 252545
		[Token(Token = "0x403DA81")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020076EB RID: 30443
		[Token(Token = "0x20076EB")]
		public class RewardTrackPoint : ITrackPointModel, IHotfixable
		{
			// Token: 0x1700646D RID: 25709
			// (get) Token: 0x0602AC8F RID: 175247 RVA: 0x000D9FC8 File Offset: 0x000D81C8
			[Token(Token = "0x1700646D")]
			public bool isShow
			{
				[Token(Token = "0x602AC8F")]
				[Address(RVA = "0x26953D0", Offset = "0x2693FD0", VA = "0x1826953D0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0602AC90 RID: 175248 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AC90")]
			[Address(RVA = "0x2695250", Offset = "0x2693E50", VA = "0x182695250", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x0602AC91 RID: 175249 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AC91")]
			[Address(RVA = "0x2695370", Offset = "0x2693F70", VA = "0x182695370")]
			public RewardTrackPoint()
			{
			}

			// Token: 0x0403DA82 RID: 252546
			[Token(Token = "0x403DA82")]
			[FieldOffset(Offset = "0x10")]
			private bool m_haveAvailFlag;

			// Token: 0x0403DA83 RID: 252547
			[Token(Token = "0x403DA83")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x0403DA84 RID: 252548
			[Token(Token = "0x403DA84")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x0403DA85 RID: 252549
			[Token(Token = "0x403DA85")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x020076EC RID: 30444
			[Token(Token = "0x20076EC")]
			public class Param
			{
				// Token: 0x0602AC92 RID: 175250 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x602AC92")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Param()
				{
				}

				// Token: 0x0403DA86 RID: 252550
				[Token(Token = "0x403DA86")]
				[FieldOffset(Offset = "0x10")]
				public TemplateActivityMilestoneGroupViewModel viewModel;

				// Token: 0x0403DA87 RID: 252551
				[Token(Token = "0x403DA87")]
				[FieldOffset(Offset = "0x18")]
				public bool isMileStoneEnable;
			}
		}

		// Token: 0x020076ED RID: 30445
		[Token(Token = "0x20076ED")]
		public class ProgressTrackPoint : ITrackPointModel, IHotfixable
		{
			// Token: 0x1700646E RID: 25710
			// (get) Token: 0x0602AC93 RID: 175251 RVA: 0x000D9FE0 File Offset: 0x000D81E0
			[Token(Token = "0x1700646E")]
			public bool isShow
			{
				[Token(Token = "0x602AC93")]
				[Address(RVA = "0x26951F0", Offset = "0x2693DF0", VA = "0x1826951F0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0602AC94 RID: 175252 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AC94")]
			[Address(RVA = "0x2695080", Offset = "0x2693C80", VA = "0x182695080", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x0602AC95 RID: 175253 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AC95")]
			[Address(RVA = "0x2695190", Offset = "0x2693D90", VA = "0x182695190")]
			public ProgressTrackPoint()
			{
			}

			// Token: 0x0403DA88 RID: 252552
			[Token(Token = "0x403DA88")]
			[FieldOffset(Offset = "0x10")]
			private bool m_haveAvailFlag;

			// Token: 0x0403DA89 RID: 252553
			[Token(Token = "0x403DA89")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x0403DA8A RID: 252554
			[Token(Token = "0x403DA8A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x0403DA8B RID: 252555
			[Token(Token = "0x403DA8B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x020076EE RID: 30446
			[Token(Token = "0x20076EE")]
			public class Param
			{
				// Token: 0x0602AC96 RID: 175254 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x602AC96")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Param()
				{
				}

				// Token: 0x0403DA8C RID: 252556
				[Token(Token = "0x403DA8C")]
				[FieldOffset(Offset = "0x10")]
				public string actId;

				// Token: 0x0403DA8D RID: 252557
				[Token(Token = "0x403DA8D")]
				[FieldOffset(Offset = "0x18")]
				public bool hasReward;

				// Token: 0x0403DA8E RID: 252558
				[Token(Token = "0x403DA8E")]
				[FieldOffset(Offset = "0x19")]
				public bool isMileStoneEnable;

				// Token: 0x0403DA8F RID: 252559
				[Token(Token = "0x403DA8F")]
				[FieldOffset(Offset = "0x1A")]
				public bool isMax;
			}
		}
	}
}
