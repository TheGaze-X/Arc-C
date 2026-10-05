using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using Torappu.UI.ActivityStage.Extern;
using Torappu.UI.TemplateMission;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x0200714A RID: 29002
	[Token(Token = "0x200714A")]
	public class Act9D0StageController : ActivityStageController
	{
		// Token: 0x17006179 RID: 24953
		// (get) Token: 0x060292B9 RID: 168633 RVA: 0x000D4AC0 File Offset: 0x000D2CC0
		[Token(Token = "0x17006179")]
		public override bool disableStageEntryPartical
		{
			[Token(Token = "0x60292B9")]
			[Address(RVA = "0x247D150", Offset = "0x247BD50", VA = "0x18247D150", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700617A RID: 24954
		// (get) Token: 0x060292BA RID: 168634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700617A")]
		public TrackPointViewProperty favorUpTrackProperty
		{
			[Token(Token = "0x60292BA")]
			[Address(RVA = "0x247D210", Offset = "0x247BE10", VA = "0x18247D210")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700617B RID: 24955
		// (get) Token: 0x060292BB RID: 168635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700617B")]
		public TrackPointViewProperty missionTrackProperty
		{
			[Token(Token = "0x60292BB")]
			[Address(RVA = "0x247D2D0", Offset = "0x247BED0", VA = "0x18247D2D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700617C RID: 24956
		// (get) Token: 0x060292BC RID: 168636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700617C")]
		public TrackPointViewProperty templateTrapTrackProperty
		{
			[Token(Token = "0x60292BC")]
			[Address(RVA = "0x247D3F0", Offset = "0x247BFF0", VA = "0x18247D3F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700617D RID: 24957
		// (get) Token: 0x060292BD RID: 168637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700617D")]
		public Act9D0ZoneDescGroupViewProperty zoneDescGroupProperty
		{
			[Token(Token = "0x60292BD")]
			[Address(RVA = "0x247D450", Offset = "0x247C050", VA = "0x18247D450")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700617E RID: 24958
		// (get) Token: 0x060292BE RID: 168638 RVA: 0x000D4AD8 File Offset: 0x000D2CD8
		[Token(Token = "0x1700617E")]
		public bool isLoaded
		{
			[Token(Token = "0x60292BE")]
			[Address(RVA = "0x247D270", Offset = "0x247BE70", VA = "0x18247D270")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700617F RID: 24959
		// (get) Token: 0x060292BF RID: 168639 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060292C0 RID: 168640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700617F")]
		public Action onStageTimeout
		{
			[Token(Token = "0x60292BF")]
			[Address(RVA = "0x247D390", Offset = "0x247BF90", VA = "0x18247D390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60292C0")]
			[Address(RVA = "0x247D530", Offset = "0x247C130", VA = "0x18247D530")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17006180 RID: 24960
		// (get) Token: 0x060292C1 RID: 168641 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060292C2 RID: 168642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006180")]
		public Action onRewardTimeout
		{
			[Token(Token = "0x60292C1")]
			[Address(RVA = "0x247D330", Offset = "0x247BF30", VA = "0x18247D330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60292C2")]
			[Address(RVA = "0x247D4B0", Offset = "0x247C0B0", VA = "0x18247D4B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17006181 RID: 24961
		// (get) Token: 0x060292C3 RID: 168643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006181")]
		public EventPool<Act9D0StageController.Act9D0Event> eventPool
		{
			[Token(Token = "0x60292C3")]
			[Address(RVA = "0x247D1B0", Offset = "0x247BDB0", VA = "0x18247D1B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060292C4 RID: 168644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60292C4")]
		[Address(RVA = "0x247C270", Offset = "0x247AE70", VA = "0x18247C270", Slot = "5")]
		protected override ActivityStageBridge CreateBridge()
		{
			return null;
		}

		// Token: 0x060292C5 RID: 168645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60292C5")]
		[Address(RVA = "0x247C6F0", Offset = "0x247B2F0", VA = "0x18247C6F0", Slot = "10")]
		protected override void OnLoaded()
		{
		}

		// Token: 0x060292C6 RID: 168646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60292C6")]
		[Address(RVA = "0x247CF40", Offset = "0x247BB40", VA = "0x18247CF40", Slot = "11")]
		protected override void TriggerActivityLoadedAVG()
		{
		}

		// Token: 0x060292C7 RID: 168647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60292C7")]
		[Address(RVA = "0x247CB70", Offset = "0x247B770", VA = "0x18247CB70", Slot = "18")]
		protected override void OnStagePageHideEffect()
		{
		}

		// Token: 0x060292C8 RID: 168648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60292C8")]
		[Address(RVA = "0x247CC40", Offset = "0x247B840", VA = "0x18247CC40", Slot = "13")]
		protected override void OnStageTimeout()
		{
		}

		// Token: 0x060292C9 RID: 168649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60292C9")]
		[Address(RVA = "0x247CA50", Offset = "0x247B650", VA = "0x18247CA50", Slot = "14")]
		protected override void OnRewardTimeout()
		{
		}

		// Token: 0x060292CA RID: 168650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60292CA")]
		[Address(RVA = "0x247C640", Offset = "0x247B240", VA = "0x18247C640", Slot = "16")]
		protected override IEnumerator HideCoroutine()
		{
			return null;
		}

		// Token: 0x060292CB RID: 168651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60292CB")]
		[Address(RVA = "0x247C5B0", Offset = "0x247B1B0", VA = "0x18247C5B0")]
		public void FocusToZone(string zoneId)
		{
		}

		// Token: 0x060292CC RID: 168652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60292CC")]
		[Address(RVA = "0x247C4F0", Offset = "0x247B0F0", VA = "0x18247C4F0")]
		public void EventOnZoneClicked(string zoneId)
		{
		}

		// Token: 0x060292CD RID: 168653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60292CD")]
		[Address(RVA = "0x247C300", Offset = "0x247AF00", VA = "0x18247C300")]
		public TemplateMissionInputParam CreateTemplateMissionInputParam()
		{
			return null;
		}

		// Token: 0x060292CE RID: 168654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60292CE")]
		[Address(RVA = "0x247CFB0", Offset = "0x247BBB0", VA = "0x18247CFB0")]
		public Act9D0StageController()
		{
		}

		// Token: 0x060292D0 RID: 168656 RVA: 0x000D4AF0 File Offset: 0x000D2CF0
		[Token(Token = "0x60292D0")]
		[Address(RVA = "0x22DB6F0", Offset = "0x22DA2F0", VA = "0x1822DB6F0")]
		private bool <>xLuaBaseProxy_get_disableStageEntryPartical()
		{
			return default(bool);
		}

		// Token: 0x060292D1 RID: 168657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60292D1")]
		[Address(RVA = "0x22DB660", Offset = "0x22DA260", VA = "0x1822DB660")]
		private void <>xLuaBaseProxy_OnLoaded()
		{
		}

		// Token: 0x060292D2 RID: 168658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60292D2")]
		[Address(RVA = "0x22DB6E0", Offset = "0x22DA2E0", VA = "0x1822DB6E0")]
		private void <>xLuaBaseProxy_TriggerActivityLoadedAVG()
		{
		}

		// Token: 0x060292D3 RID: 168659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60292D3")]
		[Address(RVA = "0x22DB670", Offset = "0x22DA270", VA = "0x1822DB670")]
		private void <>xLuaBaseProxy_OnStagePageHideEffect()
		{
		}

		// Token: 0x060292D4 RID: 168660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60292D4")]
		[Address(RVA = "0x22DB6C0", Offset = "0x22DA2C0", VA = "0x1822DB6C0")]
		private void <>xLuaBaseProxy_OnStageTimeout()
		{
		}

		// Token: 0x060292D5 RID: 168661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60292D5")]
		[Address(RVA = "0x247CFA0", Offset = "0x247BBA0", VA = "0x18247CFA0")]
		private void <>xLuaBaseProxy_OnRewardTimeout()
		{
		}

		// Token: 0x060292D6 RID: 168662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60292D6")]
		[Address(RVA = "0x22DB630", Offset = "0x22DA230", VA = "0x1822DB630")]
		private IEnumerator <>xLuaBaseProxy_HideCoroutine()
		{
			return null;
		}

		// Token: 0x0403ACAE RID: 240814
		[Token(Token = "0x403ACAE")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Tooltip("Whether to disable partical on zone select state")]
		private bool _disableStageEntryPartical;

		// Token: 0x0403ACAF RID: 240815
		[Token(Token = "0x403ACAF")]
		[FieldOffset(Offset = "0x68")]
		private TrackPointViewProperty m_favorUpTrackProperty;

		// Token: 0x0403ACB0 RID: 240816
		[Token(Token = "0x403ACB0")]
		[FieldOffset(Offset = "0x70")]
		private TrackPointViewProperty m_missionTrackProperty;

		// Token: 0x0403ACB1 RID: 240817
		[Token(Token = "0x403ACB1")]
		[FieldOffset(Offset = "0x78")]
		private TrackPointViewProperty m_templateTrapTrackProperty;

		// Token: 0x0403ACB2 RID: 240818
		[Token(Token = "0x403ACB2")]
		[FieldOffset(Offset = "0x80")]
		private Act9D0ZoneDescGroupViewProperty m_zoneDescGroupProperty;

		// Token: 0x0403ACB3 RID: 240819
		[Token(Token = "0x403ACB3")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isLoaded;

		// Token: 0x0403ACB4 RID: 240820
		[Token(Token = "0x403ACB4")]
		[FieldOffset(Offset = "0x90")]
		private EventPool<Act9D0StageController.Act9D0Event> m_eventPool;

		// Token: 0x0403ACB7 RID: 240823
		[Token(Token = "0x403ACB7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_disableStageEntryPartical;

		// Token: 0x0403ACB8 RID: 240824
		[Token(Token = "0x403ACB8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_favorUpTrackProperty;

		// Token: 0x0403ACB9 RID: 240825
		[Token(Token = "0x403ACB9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_missionTrackProperty;

		// Token: 0x0403ACBA RID: 240826
		[Token(Token = "0x403ACBA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_templateTrapTrackProperty;

		// Token: 0x0403ACBB RID: 240827
		[Token(Token = "0x403ACBB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_zoneDescGroupProperty;

		// Token: 0x0403ACBC RID: 240828
		[Token(Token = "0x403ACBC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_isLoaded;

		// Token: 0x0403ACBD RID: 240829
		[Token(Token = "0x403ACBD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_onStageTimeout;

		// Token: 0x0403ACBE RID: 240830
		[Token(Token = "0x403ACBE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_onStageTimeout;

		// Token: 0x0403ACBF RID: 240831
		[Token(Token = "0x403ACBF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_onRewardTimeout;

		// Token: 0x0403ACC0 RID: 240832
		[Token(Token = "0x403ACC0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_onRewardTimeout;

		// Token: 0x0403ACC1 RID: 240833
		[Token(Token = "0x403ACC1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_eventPool;

		// Token: 0x0403ACC2 RID: 240834
		[Token(Token = "0x403ACC2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CreateBridge;

		// Token: 0x0403ACC3 RID: 240835
		[Token(Token = "0x403ACC3")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnLoaded;

		// Token: 0x0403ACC4 RID: 240836
		[Token(Token = "0x403ACC4")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_TriggerActivityLoadedAVG;

		// Token: 0x0403ACC5 RID: 240837
		[Token(Token = "0x403ACC5")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnStagePageHideEffect;

		// Token: 0x0403ACC6 RID: 240838
		[Token(Token = "0x403ACC6")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnStageTimeout;

		// Token: 0x0403ACC7 RID: 240839
		[Token(Token = "0x403ACC7")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnRewardTimeout;

		// Token: 0x0403ACC8 RID: 240840
		[Token(Token = "0x403ACC8")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0403ACC9 RID: 240841
		[Token(Token = "0x403ACC9")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_FocusToZone;

		// Token: 0x0403ACCA RID: 240842
		[Token(Token = "0x403ACCA")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_EventOnZoneClicked;

		// Token: 0x0403ACCB RID: 240843
		[Token(Token = "0x403ACCB")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_CreateTemplateMissionInputParam;

		// Token: 0x0403ACCC RID: 240844
		[Token(Token = "0x403ACCC")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200714B RID: 29003
		[Token(Token = "0x200714B")]
		public enum Act9D0Event
		{
			// Token: 0x0403ACCE RID: 240846
			[Token(Token = "0x403ACCE")]
			NONE,
			// Token: 0x0403ACCF RID: 240847
			[Token(Token = "0x403ACCF")]
			NEWS_UPDATED,
			// Token: 0x0403ACD0 RID: 240848
			[Token(Token = "0x403ACD0")]
			MISSION_UPDATED,
			// Token: 0x0403ACD1 RID: 240849
			[Token(Token = "0x403ACD1")]
			BEFORE_HIDE_EFFECT,
			// Token: 0x0403ACD2 RID: 240850
			[Token(Token = "0x403ACD2")]
			TIMEOUT_UPDATE
		}

		// Token: 0x0200714C RID: 29004
		[Token(Token = "0x200714C")]
		public class Bridge : ActivityStageBridge
		{
			// Token: 0x060292D7 RID: 168663 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60292D7")]
			[Address(RVA = "0x24A68C0", Offset = "0x24A54C0", VA = "0x1824A68C0", Slot = "5")]
			protected override void OnZoneSelected(string selectedZoneId)
			{
			}

			// Token: 0x060292D8 RID: 168664 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60292D8")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Bridge()
			{
			}
		}
	}
}
