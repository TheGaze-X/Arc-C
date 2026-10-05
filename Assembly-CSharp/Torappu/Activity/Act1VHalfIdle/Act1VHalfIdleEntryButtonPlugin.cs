using System;
using Il2CppDummyDll;
using Torappu.Audio;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076E3 RID: 30435
	[Token(Token = "0x20076E3")]
	public class Act1VHalfIdleEntryButtonPlugin : TemplateActivityCommonPlugin, IAudioAnimationPlayerConditionProvider, IHotfixable
	{
		// Token: 0x0602AC7A RID: 175226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC7A")]
		[Address(RVA = "0x26866F0", Offset = "0x26852F0", VA = "0x1826866F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AC7B RID: 175227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC7B")]
		[Address(RVA = "0x2686300", Offset = "0x2684F00", VA = "0x182686300", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel actViewModel)
		{
		}

		// Token: 0x0602AC7C RID: 175228 RVA: 0x000D9F68 File Offset: 0x000D8168
		[Token(Token = "0x602AC7C")]
		[Address(RVA = "0x2686230", Offset = "0x2684E30", VA = "0x182686230", Slot = "6")]
		public bool CanPlayAudio()
		{
			return default(bool);
		}

		// Token: 0x0602AC7D RID: 175229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC7D")]
		[Address(RVA = "0x26868F0", Offset = "0x26854F0", VA = "0x1826868F0")]
		public Act1VHalfIdleEntryButtonPlugin()
		{
		}

		// Token: 0x0403DA41 RID: 252481
		[Token(Token = "0x403DA41")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ThreeStateToggle[] _trainLockToggles;

		// Token: 0x0403DA42 RID: 252482
		[Token(Token = "0x403DA42")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TwoStateToggle _zoneMapToggle;

		// Token: 0x0403DA43 RID: 252483
		[Token(Token = "0x403DA43")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ThreeStateToggle _havestTimeToggle;

		// Token: 0x0403DA44 RID: 252484
		[Token(Token = "0x403DA44")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ThreeStateToggle _harvestEntryToggle;

		// Token: 0x0403DA45 RID: 252485
		[Token(Token = "0x403DA45")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _harvestTimeText;

		// Token: 0x0403DA46 RID: 252486
		[Token(Token = "0x403DA46")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UICommonTrackPoint _newStageTrack;

		// Token: 0x0403DA47 RID: 252487
		[Token(Token = "0x403DA47")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _stageSettleObj;

		// Token: 0x0403DA48 RID: 252488
		[Token(Token = "0x403DA48")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UICommonTrackPoint _depotTrack;

		// Token: 0x0403DA49 RID: 252489
		[Token(Token = "0x403DA49")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UICommonTrackPoint _techTreeTrack;

		// Token: 0x0403DA4A RID: 252490
		[Token(Token = "0x403DA4A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _gachaCntObj;

		// Token: 0x0403DA4B RID: 252491
		[Token(Token = "0x403DA4B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _gachaCntText;

		// Token: 0x0403DA4C RID: 252492
		[Token(Token = "0x403DA4C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UICommonTrackPoint _harvestTrack;

		// Token: 0x0403DA4D RID: 252493
		[Token(Token = "0x403DA4D")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isInited;

		// Token: 0x0403DA4E RID: 252494
		[Token(Token = "0x403DA4E")]
		[FieldOffset(Offset = "0x90")]
		private TrackPointViewProperty m_stageTrackProp;

		// Token: 0x0403DA4F RID: 252495
		[Token(Token = "0x403DA4F")]
		[FieldOffset(Offset = "0x98")]
		private TrackPointViewProperty m_depotTrackProp;

		// Token: 0x0403DA50 RID: 252496
		[Token(Token = "0x403DA50")]
		[FieldOffset(Offset = "0xA0")]
		private TrackPointViewProperty m_techTreeTrackProp;

		// Token: 0x0403DA51 RID: 252497
		[Token(Token = "0x403DA51")]
		[FieldOffset(Offset = "0xA8")]
		private TrackPointViewProperty m_harvestTrackProp;

		// Token: 0x0403DA52 RID: 252498
		[Token(Token = "0x403DA52")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403DA53 RID: 252499
		[Token(Token = "0x403DA53")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403DA54 RID: 252500
		[Token(Token = "0x403DA54")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CanPlayAudio;

		// Token: 0x0403DA55 RID: 252501
		[Token(Token = "0x403DA55")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020076E4 RID: 30436
		[Token(Token = "0x20076E4")]
		private class ZoneTrackPoint : ITrackPointModel, IHotfixable
		{
			// Token: 0x1700646A RID: 25706
			// (get) Token: 0x0602AC7E RID: 175230 RVA: 0x000D9F80 File Offset: 0x000D8180
			[Token(Token = "0x1700646A")]
			public bool isShow
			{
				[Token(Token = "0x602AC7E")]
				[Address(RVA = "0x26959E0", Offset = "0x26945E0", VA = "0x1826959E0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0602AC7F RID: 175231 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AC7F")]
			[Address(RVA = "0x2695800", Offset = "0x2694400", VA = "0x182695800", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x0602AC80 RID: 175232 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AC80")]
			[Address(RVA = "0x2695980", Offset = "0x2694580", VA = "0x182695980")]
			public ZoneTrackPoint()
			{
			}

			// Token: 0x0403DA56 RID: 252502
			[Token(Token = "0x403DA56")]
			[FieldOffset(Offset = "0x10")]
			private bool m_haveAvailFlag;

			// Token: 0x0403DA57 RID: 252503
			[Token(Token = "0x403DA57")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x0403DA58 RID: 252504
			[Token(Token = "0x403DA58")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x0403DA59 RID: 252505
			[Token(Token = "0x403DA59")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x020076E5 RID: 30437
			[Token(Token = "0x20076E5")]
			public class Param
			{
				// Token: 0x0602AC81 RID: 175233 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x602AC81")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Param()
				{
				}

				// Token: 0x0403DA5A RID: 252506
				[Token(Token = "0x403DA5A")]
				[FieldOffset(Offset = "0x10")]
				public TemplateActivityMilestoneGroupViewModel viewModel;

				// Token: 0x0403DA5B RID: 252507
				[Token(Token = "0x403DA5B")]
				[FieldOffset(Offset = "0x18")]
				public bool isMileStoneEnable;
			}
		}

		// Token: 0x020076E6 RID: 30438
		[Token(Token = "0x20076E6")]
		private class HarvestTrackPoint : ITrackPointModel, IHotfixable
		{
			// Token: 0x1700646B RID: 25707
			// (get) Token: 0x0602AC82 RID: 175234 RVA: 0x000D9F98 File Offset: 0x000D8198
			[Token(Token = "0x1700646B")]
			public bool isShow
			{
				[Token(Token = "0x602AC82")]
				[Address(RVA = "0x2694970", Offset = "0x2693570", VA = "0x182694970", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0602AC83 RID: 175235 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AC83")]
			[Address(RVA = "0x2694840", Offset = "0x2693440", VA = "0x182694840", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x0602AC84 RID: 175236 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AC84")]
			[Address(RVA = "0x2694910", Offset = "0x2693510", VA = "0x182694910")]
			public HarvestTrackPoint()
			{
			}

			// Token: 0x0403DA5C RID: 252508
			[Token(Token = "0x403DA5C")]
			[FieldOffset(Offset = "0x10")]
			private bool m_haveAvailFlag;

			// Token: 0x0403DA5D RID: 252509
			[Token(Token = "0x403DA5D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x0403DA5E RID: 252510
			[Token(Token = "0x403DA5E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x0403DA5F RID: 252511
			[Token(Token = "0x403DA5F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020076E7 RID: 30439
		[Token(Token = "0x20076E7")]
		public class TechTreeTrackpointModel : ITrackPointModel, IHotfixable
		{
			// Token: 0x1700646C RID: 25708
			// (get) Token: 0x0602AC85 RID: 175237 RVA: 0x000D9FB0 File Offset: 0x000D81B0
			[Token(Token = "0x1700646C")]
			public bool isShow
			{
				[Token(Token = "0x602AC85")]
				[Address(RVA = "0x2695590", Offset = "0x2694190", VA = "0x182695590", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0602AC86 RID: 175238 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AC86")]
			[Address(RVA = "0x2695430", Offset = "0x2694030", VA = "0x182695430", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x0602AC87 RID: 175239 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AC87")]
			[Address(RVA = "0x2695530", Offset = "0x2694130", VA = "0x182695530")]
			public TechTreeTrackpointModel()
			{
			}

			// Token: 0x0403DA60 RID: 252512
			[Token(Token = "0x403DA60")]
			[FieldOffset(Offset = "0x10")]
			private bool m_isShow;

			// Token: 0x0403DA61 RID: 252513
			[Token(Token = "0x403DA61")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x0403DA62 RID: 252514
			[Token(Token = "0x403DA62")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x0403DA63 RID: 252515
			[Token(Token = "0x403DA63")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x020076E8 RID: 30440
			[Token(Token = "0x20076E8")]
			public class Param
			{
				// Token: 0x0602AC88 RID: 175240 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x602AC88")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Param()
				{
				}

				// Token: 0x0403DA64 RID: 252516
				[Token(Token = "0x403DA64")]
				[FieldOffset(Offset = "0x10")]
				public string actId;

				// Token: 0x0403DA65 RID: 252517
				[Token(Token = "0x403DA65")]
				[FieldOffset(Offset = "0x18")]
				public bool isActEnd;
			}
		}
	}
}
