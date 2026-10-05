using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using Torappu.UI.ActivityStage.Extern;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act10D5
{
	// Token: 0x02007B17 RID: 31511
	[Token(Token = "0x2007B17")]
	public class Act10D5StageController : ActivityStageController
	{
		// Token: 0x17006758 RID: 26456
		// (get) Token: 0x0602C1CD RID: 180685 RVA: 0x000DE270 File Offset: 0x000DC470
		[Token(Token = "0x17006758")]
		public override bool disableStageEntryPartical
		{
			[Token(Token = "0x602C1CD")]
			[Address(RVA = "0x2808900", Offset = "0x2807500", VA = "0x182808900", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006759 RID: 26457
		// (get) Token: 0x0602C1CE RID: 180686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006759")]
		public TrackPointViewProperty favorUpTrackProperty
		{
			[Token(Token = "0x602C1CE")]
			[Address(RVA = "0x2808960", Offset = "0x2807560", VA = "0x182808960")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700675A RID: 26458
		// (get) Token: 0x0602C1CF RID: 180687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700675A")]
		public Act10D5ZoneDescGroupViewProperty zoneDescGroupProperty
		{
			[Token(Token = "0x602C1CF")]
			[Address(RVA = "0x2808B90", Offset = "0x2807790", VA = "0x182808B90")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700675B RID: 26459
		// (get) Token: 0x0602C1D0 RID: 180688 RVA: 0x000DE288 File Offset: 0x000DC488
		[Token(Token = "0x1700675B")]
		public bool isLoaded
		{
			[Token(Token = "0x602C1D0")]
			[Address(RVA = "0x2808A70", Offset = "0x2807670", VA = "0x182808A70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700675C RID: 26460
		// (get) Token: 0x0602C1D1 RID: 180689 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C1D2 RID: 180690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700675C")]
		public Action onStageTimeout
		{
			[Token(Token = "0x602C1D1")]
			[Address(RVA = "0x2808B30", Offset = "0x2807730", VA = "0x182808B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602C1D2")]
			[Address(RVA = "0x2808C70", Offset = "0x2807870", VA = "0x182808C70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700675D RID: 26461
		// (get) Token: 0x0602C1D3 RID: 180691 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C1D4 RID: 180692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700675D")]
		public Action onRewardTimeout
		{
			[Token(Token = "0x602C1D3")]
			[Address(RVA = "0x2808AD0", Offset = "0x28076D0", VA = "0x182808AD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602C1D4")]
			[Address(RVA = "0x2808BF0", Offset = "0x28077F0", VA = "0x182808BF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700675E RID: 26462
		// (get) Token: 0x0602C1D5 RID: 180693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700675E")]
		public Act10D5StageController.Act10D5InitMeta initMetaObj
		{
			[Token(Token = "0x602C1D5")]
			[Address(RVA = "0x28089C0", Offset = "0x28075C0", VA = "0x1828089C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602C1D6 RID: 180694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1D6")]
		[Address(RVA = "0x2808080", Offset = "0x2806C80", VA = "0x182808080")]
		public void TryRefreshPlugins()
		{
		}

		// Token: 0x0602C1D7 RID: 180695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1D7")]
		[Address(RVA = "0x2808510", Offset = "0x2807110", VA = "0x182808510")]
		private void _TryRefreshMedalPlugin()
		{
		}

		// Token: 0x0602C1D8 RID: 180696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C1D8")]
		[Address(RVA = "0x28081C0", Offset = "0x2806DC0", VA = "0x1828081C0")]
		private TemplateActivityMedalViewModel _GenMedalViewModel()
		{
			return null;
		}

		// Token: 0x0602C1D9 RID: 180697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1D9")]
		[Address(RVA = "0x28082D0", Offset = "0x2806ED0", VA = "0x1828082D0")]
		private void _TryRefreshCGGalleryPlugin()
		{
		}

		// Token: 0x0602C1DA RID: 180698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C1DA")]
		[Address(RVA = "0x28080F0", Offset = "0x2806CF0", VA = "0x1828080F0")]
		private TemplateActivityCGGalleryViewModel _GenCGGalleryViewModel()
		{
			return null;
		}

		// Token: 0x0602C1DB RID: 180699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C1DB")]
		[Address(RVA = "0x2807590", Offset = "0x2806190", VA = "0x182807590", Slot = "5")]
		protected override ActivityStageBridge CreateBridge()
		{
			return null;
		}

		// Token: 0x0602C1DC RID: 180700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C1DC")]
		[Address(RVA = "0x2807750", Offset = "0x2806350", VA = "0x182807750", Slot = "7")]
		protected override string GetBGMSignal()
		{
			return null;
		}

		// Token: 0x0602C1DD RID: 180701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1DD")]
		[Address(RVA = "0x28079B0", Offset = "0x28065B0", VA = "0x1828079B0", Slot = "10")]
		protected override void OnLoaded()
		{
		}

		// Token: 0x0602C1DE RID: 180702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1DE")]
		[Address(RVA = "0x2807DF0", Offset = "0x28069F0", VA = "0x182807DF0", Slot = "13")]
		protected override void OnStageTimeout()
		{
		}

		// Token: 0x0602C1DF RID: 180703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1DF")]
		[Address(RVA = "0x2807BD0", Offset = "0x28067D0", VA = "0x182807BD0", Slot = "14")]
		protected override void OnRewardTimeout()
		{
		}

		// Token: 0x0602C1E0 RID: 180704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1E0")]
		[Address(RVA = "0x2807CF0", Offset = "0x28068F0", VA = "0x182807CF0", Slot = "17")]
		protected override void OnStagePageResumed(UIPageTransContext context)
		{
		}

		// Token: 0x0602C1E1 RID: 180705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1E1")]
		[Address(RVA = "0x28076C0", Offset = "0x28062C0", VA = "0x1828076C0")]
		public void EventOnZoneClicked(string zoneId)
		{
		}

		// Token: 0x0602C1E2 RID: 180706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C1E2")]
		[Address(RVA = "0x2807620", Offset = "0x2806220", VA = "0x182807620")]
		public static string CreateInitMeta4StoryState()
		{
			return null;
		}

		// Token: 0x0602C1E3 RID: 180707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1E3")]
		[Address(RVA = "0x28087D0", Offset = "0x28073D0", VA = "0x1828087D0")]
		public Act10D5StageController()
		{
		}

		// Token: 0x0602C1E4 RID: 180708 RVA: 0x000DE2A0 File Offset: 0x000DC4A0
		[Token(Token = "0x602C1E4")]
		[Address(RVA = "0x22DB6F0", Offset = "0x22DA2F0", VA = "0x1822DB6F0")]
		private bool <>xLuaBaseProxy_get_disableStageEntryPartical()
		{
			return default(bool);
		}

		// Token: 0x0602C1E5 RID: 180709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C1E5")]
		[Address(RVA = "0x256A040", Offset = "0x2568C40", VA = "0x18256A040")]
		private string <>xLuaBaseProxy_GetBGMSignal()
		{
			return null;
		}

		// Token: 0x0602C1E6 RID: 180710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1E6")]
		[Address(RVA = "0x22DB660", Offset = "0x22DA260", VA = "0x1822DB660")]
		private void <>xLuaBaseProxy_OnLoaded()
		{
		}

		// Token: 0x0602C1E7 RID: 180711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1E7")]
		[Address(RVA = "0x22DB6C0", Offset = "0x22DA2C0", VA = "0x1822DB6C0")]
		private void <>xLuaBaseProxy_OnStageTimeout()
		{
		}

		// Token: 0x0602C1E8 RID: 180712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1E8")]
		[Address(RVA = "0x247CFA0", Offset = "0x247BBA0", VA = "0x18247CFA0")]
		private void <>xLuaBaseProxy_OnRewardTimeout()
		{
		}

		// Token: 0x0602C1E9 RID: 180713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1E9")]
		[Address(RVA = "0x22DB680", Offset = "0x22DA280", VA = "0x1822DB680")]
		private void <>xLuaBaseProxy_OnStagePageResumed(UIPageTransContext P0)
		{
		}

		// Token: 0x0403FF44 RID: 261956
		[Token(Token = "0x403FF44")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Tooltip("Whether to disable partical on zone select state")]
		private bool _disableStageEntryPartical;

		// Token: 0x0403FF45 RID: 261957
		[Token(Token = "0x403FF45")]
		[FieldOffset(Offset = "0x68")]
		private TrackPointViewProperty m_favorUpTrackProperty;

		// Token: 0x0403FF46 RID: 261958
		[Token(Token = "0x403FF46")]
		[FieldOffset(Offset = "0x70")]
		private Act10D5ZoneDescGroupViewProperty m_zoneDescGroupProperty;

		// Token: 0x0403FF47 RID: 261959
		[Token(Token = "0x403FF47")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isLoaded;

		// Token: 0x0403FF48 RID: 261960
		[Token(Token = "0x403FF48")]
		[FieldOffset(Offset = "0x80")]
		private Act10D5StageController.Act10D5InitMeta m_initMetaObj;

		// Token: 0x0403FF49 RID: 261961
		[Token(Token = "0x403FF49")]
		[FieldOffset(Offset = "0x88")]
		private TemplateActivityMedalViewModel m_medalViewModel;

		// Token: 0x0403FF4A RID: 261962
		[Token(Token = "0x403FF4A")]
		[FieldOffset(Offset = "0x90")]
		private TemplateActivityCGGalleryViewModel m_cgGalleryViewModel;

		// Token: 0x0403FF4D RID: 261965
		[Token(Token = "0x403FF4D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_disableStageEntryPartical;

		// Token: 0x0403FF4E RID: 261966
		[Token(Token = "0x403FF4E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_favorUpTrackProperty;

		// Token: 0x0403FF4F RID: 261967
		[Token(Token = "0x403FF4F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_zoneDescGroupProperty;

		// Token: 0x0403FF50 RID: 261968
		[Token(Token = "0x403FF50")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isLoaded;

		// Token: 0x0403FF51 RID: 261969
		[Token(Token = "0x403FF51")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onStageTimeout;

		// Token: 0x0403FF52 RID: 261970
		[Token(Token = "0x403FF52")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onStageTimeout;

		// Token: 0x0403FF53 RID: 261971
		[Token(Token = "0x403FF53")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_onRewardTimeout;

		// Token: 0x0403FF54 RID: 261972
		[Token(Token = "0x403FF54")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_onRewardTimeout;

		// Token: 0x0403FF55 RID: 261973
		[Token(Token = "0x403FF55")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_initMetaObj;

		// Token: 0x0403FF56 RID: 261974
		[Token(Token = "0x403FF56")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_TryRefreshPlugins;

		// Token: 0x0403FF57 RID: 261975
		[Token(Token = "0x403FF57")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TryRefreshMedalPlugin;

		// Token: 0x0403FF58 RID: 261976
		[Token(Token = "0x403FF58")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GenMedalViewModel;

		// Token: 0x0403FF59 RID: 261977
		[Token(Token = "0x403FF59")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__TryRefreshCGGalleryPlugin;

		// Token: 0x0403FF5A RID: 261978
		[Token(Token = "0x403FF5A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__GenCGGalleryViewModel;

		// Token: 0x0403FF5B RID: 261979
		[Token(Token = "0x403FF5B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_CreateBridge;

		// Token: 0x0403FF5C RID: 261980
		[Token(Token = "0x403FF5C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetBGMSignal;

		// Token: 0x0403FF5D RID: 261981
		[Token(Token = "0x403FF5D")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnLoaded;

		// Token: 0x0403FF5E RID: 261982
		[Token(Token = "0x403FF5E")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnStageTimeout;

		// Token: 0x0403FF5F RID: 261983
		[Token(Token = "0x403FF5F")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnRewardTimeout;

		// Token: 0x0403FF60 RID: 261984
		[Token(Token = "0x403FF60")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnStagePageResumed;

		// Token: 0x0403FF61 RID: 261985
		[Token(Token = "0x403FF61")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_EventOnZoneClicked;

		// Token: 0x0403FF62 RID: 261986
		[Token(Token = "0x403FF62")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_CreateInitMeta4StoryState;

		// Token: 0x0403FF63 RID: 261987
		[Token(Token = "0x403FF63")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007B18 RID: 31512
		[Token(Token = "0x2007B18")]
		public class Bridge : ActivityStageBridge
		{
			// Token: 0x0602C1EA RID: 180714 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C1EA")]
			[Address(RVA = "0x2818B00", Offset = "0x2817700", VA = "0x182818B00", Slot = "5")]
			protected override void OnZoneSelected(string selectedZoneId)
			{
			}

			// Token: 0x0602C1EB RID: 180715 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C1EB")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Bridge()
			{
			}
		}

		// Token: 0x02007B19 RID: 31513
		[Token(Token = "0x2007B19")]
		public class Act10D5InitMeta
		{
			// Token: 0x0602C1EC RID: 180716 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C1EC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act10D5InitMeta()
			{
			}

			// Token: 0x0403FF64 RID: 261988
			[Token(Token = "0x403FF64")]
			[FieldOffset(Offset = "0x10")]
			public bool jumpToStoryState;
		}
	}
}
