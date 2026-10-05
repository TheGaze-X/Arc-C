using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using Torappu.UI.ActivityStage.Extern;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007A6A RID: 31338
	[Token(Token = "0x2007A6A")]
	public class Act12sideStageController : ActivityStageController
	{
		// Token: 0x170066E7 RID: 26343
		// (get) Token: 0x0602BE3A RID: 179770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170066E7")]
		public StateEngine floatStateEngine
		{
			[Token(Token = "0x602BE3A")]
			[Address(RVA = "0x27C72B0", Offset = "0x27C5EB0", VA = "0x1827C72B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170066E8 RID: 26344
		// (get) Token: 0x0602BE3B RID: 179771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170066E8")]
		public Act12sideZoneDescGroupViewProperty zoneDescGroupProperty
		{
			[Token(Token = "0x602BE3B")]
			[Address(RVA = "0x27C7760", Offset = "0x27C6360", VA = "0x1827C7760")]
			get
			{
				return null;
			}
		}

		// Token: 0x170066E9 RID: 26345
		// (get) Token: 0x0602BE3C RID: 179772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170066E9")]
		public Act12sideMissionProperty missionProperty
		{
			[Token(Token = "0x602BE3C")]
			[Address(RVA = "0x27C7580", Offset = "0x27C6180", VA = "0x1827C7580")]
			get
			{
				return null;
			}
		}

		// Token: 0x170066EA RID: 26346
		// (get) Token: 0x0602BE3D RID: 179773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170066EA")]
		public Act12sideMilestoneProperty milestoneProperty
		{
			[Token(Token = "0x602BE3D")]
			[Address(RVA = "0x27C74C0", Offset = "0x27C60C0", VA = "0x1827C74C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170066EB RID: 26347
		// (get) Token: 0x0602BE3E RID: 179774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170066EB")]
		public TrackPointViewProperty favorUpTrackProperty
		{
			[Token(Token = "0x602BE3E")]
			[Address(RVA = "0x27C7250", Offset = "0x27C5E50", VA = "0x1827C7250")]
			get
			{
				return null;
			}
		}

		// Token: 0x170066EC RID: 26348
		// (get) Token: 0x0602BE3F RID: 179775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170066EC")]
		public TrackPointViewProperty milestoneTrackPointProp
		{
			[Token(Token = "0x602BE3F")]
			[Address(RVA = "0x27C7520", Offset = "0x27C6120", VA = "0x1827C7520")]
			get
			{
				return null;
			}
		}

		// Token: 0x170066ED RID: 26349
		// (get) Token: 0x0602BE40 RID: 179776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170066ED")]
		public TrackPointViewProperty missionTrackPointProp
		{
			[Token(Token = "0x602BE40")]
			[Address(RVA = "0x27C75E0", Offset = "0x27C61E0", VA = "0x1827C75E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170066EE RID: 26350
		// (get) Token: 0x0602BE41 RID: 179777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170066EE")]
		public TrackPointViewProperty honorShowcaseProperty
		{
			[Token(Token = "0x602BE41")]
			[Address(RVA = "0x27C7400", Offset = "0x27C6000", VA = "0x1827C7400")]
			get
			{
				return null;
			}
		}

		// Token: 0x170066EF RID: 26351
		// (get) Token: 0x0602BE42 RID: 179778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170066EF")]
		public TrackPointViewProperty newCharmTrackPointProp
		{
			[Token(Token = "0x602BE42")]
			[Address(RVA = "0x27C7640", Offset = "0x27C6240", VA = "0x1827C7640")]
			get
			{
				return null;
			}
		}

		// Token: 0x170066F0 RID: 26352
		// (get) Token: 0x0602BE43 RID: 179779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170066F0")]
		public TrackPointViewProperty recycleCharmTrackPointProp
		{
			[Token(Token = "0x602BE43")]
			[Address(RVA = "0x27C7700", Offset = "0x27C6300", VA = "0x1827C7700")]
			get
			{
				return null;
			}
		}

		// Token: 0x170066F1 RID: 26353
		// (get) Token: 0x0602BE44 RID: 179780 RVA: 0x000DD988 File Offset: 0x000DBB88
		[Token(Token = "0x170066F1")]
		public override bool disableStageEntryPartical
		{
			[Token(Token = "0x602BE44")]
			[Address(RVA = "0x27C71F0", Offset = "0x27C5DF0", VA = "0x1827C71F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170066F2 RID: 26354
		// (get) Token: 0x0602BE45 RID: 179781 RVA: 0x000DD9A0 File Offset: 0x000DBBA0
		[Token(Token = "0x170066F2")]
		public bool isLoaded
		{
			[Token(Token = "0x602BE45")]
			[Address(RVA = "0x27C7460", Offset = "0x27C6060", VA = "0x1827C7460")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170066F3 RID: 26355
		// (get) Token: 0x0602BE46 RID: 179782 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602BE47 RID: 179783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170066F3")]
		public Action onStageTimeout
		{
			[Token(Token = "0x602BE46")]
			[Address(RVA = "0x27C76A0", Offset = "0x27C62A0", VA = "0x1827C76A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602BE47")]
			[Address(RVA = "0x27C77C0", Offset = "0x27C63C0", VA = "0x1827C77C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602BE48 RID: 179784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BE48")]
		[Address(RVA = "0x27C48C0", Offset = "0x27C34C0", VA = "0x1827C48C0", Slot = "5")]
		protected override ActivityStageBridge CreateBridge()
		{
			return null;
		}

		// Token: 0x0602BE49 RID: 179785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE49")]
		[Address(RVA = "0x27C4BA0", Offset = "0x27C37A0", VA = "0x1827C4BA0", Slot = "10")]
		protected override void OnLoaded()
		{
		}

		// Token: 0x0602BE4A RID: 179786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE4A")]
		[Address(RVA = "0x27C5260", Offset = "0x27C3E60", VA = "0x1827C5260", Slot = "13")]
		protected override void OnStageTimeout()
		{
		}

		// Token: 0x0602BE4B RID: 179787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE4B")]
		[Address(RVA = "0x27C5030", Offset = "0x27C3C30", VA = "0x1827C5030", Slot = "17")]
		protected override void OnStagePageResumed(UIPageTransContext context)
		{
		}

		// Token: 0x0602BE4C RID: 179788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BE4C")]
		[Address(RVA = "0x27C4AF0", Offset = "0x27C36F0", VA = "0x1827C4AF0", Slot = "9")]
		public override IEnumerator LoadCoroutine()
		{
			return null;
		}

		// Token: 0x0602BE4D RID: 179789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE4D")]
		[Address(RVA = "0x27C4950", Offset = "0x27C3550", VA = "0x1827C4950")]
		public void EventOnZoneClicked(string zoneId)
		{
		}

		// Token: 0x0602BE4E RID: 179790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE4E")]
		[Address(RVA = "0x27C5700", Offset = "0x27C4300", VA = "0x1827C5700")]
		public void RefreshMilestoneStatus()
		{
		}

		// Token: 0x0602BE4F RID: 179791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE4F")]
		[Address(RVA = "0x27C54F0", Offset = "0x27C40F0", VA = "0x1827C54F0")]
		public void RefreshFavorUpTrackPoint()
		{
		}

		// Token: 0x0602BE50 RID: 179792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE50")]
		[Address(RVA = "0x27C58E0", Offset = "0x27C44E0", VA = "0x1827C58E0")]
		public void RefreshMilestoneTrackPoint()
		{
		}

		// Token: 0x0602BE51 RID: 179793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE51")]
		[Address(RVA = "0x27C5AD0", Offset = "0x27C46D0", VA = "0x1827C5AD0")]
		public void RefreshMissionTrackPoint()
		{
		}

		// Token: 0x0602BE52 RID: 179794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE52")]
		[Address(RVA = "0x27C5B80", Offset = "0x27C4780", VA = "0x1827C5B80")]
		public void RefreshNewCharmTrackPoint()
		{
		}

		// Token: 0x0602BE53 RID: 179795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE53")]
		[Address(RVA = "0x27C5C20", Offset = "0x27C4820", VA = "0x1827C5C20")]
		public void RefreshRecycleCharmTrackPoint()
		{
		}

		// Token: 0x0602BE54 RID: 179796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE54")]
		[Address(RVA = "0x27C5630", Offset = "0x27C4230", VA = "0x1827C5630")]
		public void RefreshHonorShowcaseTrackPoint()
		{
		}

		// Token: 0x0602BE55 RID: 179797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE55")]
		[Address(RVA = "0x27C45C0", Offset = "0x27C31C0", VA = "0x1827C45C0")]
		public void CheckMissionAndRefreshTrackPoint()
		{
		}

		// Token: 0x0602BE56 RID: 179798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BE56")]
		[Address(RVA = "0x27C49E0", Offset = "0x27C35E0", VA = "0x1827C49E0")]
		public List<string> FetchFavorUpList()
		{
			return null;
		}

		// Token: 0x0602BE57 RID: 179799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BE57")]
		[Address(RVA = "0x27C6E10", Offset = "0x27C5A10", VA = "0x1827C6E10")]
		private IEnumerator _TrySyncMissionStatus()
		{
			return null;
		}

		// Token: 0x0602BE58 RID: 179800 RVA: 0x000DD9B8 File Offset: 0x000DBBB8
		[Token(Token = "0x602BE58")]
		[Address(RVA = "0x27C5CC0", Offset = "0x27C48C0", VA = "0x1827C5CC0")]
		private bool _HasMissionNew()
		{
			return default(bool);
		}

		// Token: 0x0602BE59 RID: 179801 RVA: 0x000DD9D0 File Offset: 0x000DBBD0
		[Token(Token = "0x602BE59")]
		[Address(RVA = "0x27C5EA0", Offset = "0x27C4AA0", VA = "0x1827C5EA0")]
		private bool _HasPhotoNew()
		{
			return default(bool);
		}

		// Token: 0x0602BE5A RID: 179802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE5A")]
		[Address(RVA = "0x27C66F0", Offset = "0x27C52F0", VA = "0x1827C66F0")]
		private void _InitMissionProperty()
		{
		}

		// Token: 0x0602BE5B RID: 179803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE5B")]
		[Address(RVA = "0x27C6BE0", Offset = "0x27C57E0", VA = "0x1827C6BE0")]
		private void _RefreshMissionProperty()
		{
		}

		// Token: 0x0602BE5C RID: 179804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE5C")]
		[Address(RVA = "0x27C61E0", Offset = "0x27C4DE0", VA = "0x1827C61E0")]
		private void _InitMilestoneProperty()
		{
		}

		// Token: 0x0602BE5D RID: 179805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE5D")]
		[Address(RVA = "0x27C6EC0", Offset = "0x27C5AC0", VA = "0x1827C6EC0")]
		public Act12sideStageController()
		{
		}

		// Token: 0x0602BE5F RID: 179807 RVA: 0x000DD9E8 File Offset: 0x000DBBE8
		[Token(Token = "0x602BE5F")]
		[Address(RVA = "0x22DB6F0", Offset = "0x22DA2F0", VA = "0x1822DB6F0")]
		private bool <>xLuaBaseProxy_get_disableStageEntryPartical()
		{
			return default(bool);
		}

		// Token: 0x0602BE60 RID: 179808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE60")]
		[Address(RVA = "0x22DB660", Offset = "0x22DA260", VA = "0x1822DB660")]
		private void <>xLuaBaseProxy_OnLoaded()
		{
		}

		// Token: 0x0602BE61 RID: 179809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE61")]
		[Address(RVA = "0x22DB6C0", Offset = "0x22DA2C0", VA = "0x1822DB6C0")]
		private void <>xLuaBaseProxy_OnStageTimeout()
		{
		}

		// Token: 0x0602BE62 RID: 179810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE62")]
		[Address(RVA = "0x22DB680", Offset = "0x22DA280", VA = "0x1822DB680")]
		private void <>xLuaBaseProxy_OnStagePageResumed(UIPageTransContext P0)
		{
		}

		// Token: 0x0602BE63 RID: 179811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BE63")]
		[Address(RVA = "0x246D290", Offset = "0x246BE90", VA = "0x18246D290")]
		private IEnumerator <>xLuaBaseProxy_LoadCoroutine()
		{
			return null;
		}

		// Token: 0x0403F903 RID: 260355
		[Token(Token = "0x403F903")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Tooltip("Whether to disable partical on zone select state")]
		private bool _disableStageEntryPartical;

		// Token: 0x0403F904 RID: 260356
		[Token(Token = "0x403F904")]
		[FieldOffset(Offset = "0x68")]
		private Act12sideZoneDescGroupViewProperty m_zoneDescGroupProperty;

		// Token: 0x0403F905 RID: 260357
		[Token(Token = "0x403F905")]
		[FieldOffset(Offset = "0x70")]
		private Act12sideMissionProperty m_missionProperty;

		// Token: 0x0403F906 RID: 260358
		[Token(Token = "0x403F906")]
		[FieldOffset(Offset = "0x78")]
		private Act12sideMilestoneProperty m_milestoneProperty;

		// Token: 0x0403F907 RID: 260359
		[Token(Token = "0x403F907")]
		[FieldOffset(Offset = "0x80")]
		private TrackPointViewProperty m_favorUpTrackProperty;

		// Token: 0x0403F908 RID: 260360
		[Token(Token = "0x403F908")]
		[FieldOffset(Offset = "0x88")]
		private TrackPointViewProperty m_milestoneTrackPointProperty;

		// Token: 0x0403F909 RID: 260361
		[Token(Token = "0x403F909")]
		[FieldOffset(Offset = "0x90")]
		private TrackPointViewProperty m_missionTrackPointProperty;

		// Token: 0x0403F90A RID: 260362
		[Token(Token = "0x403F90A")]
		[FieldOffset(Offset = "0x98")]
		private TrackPointViewProperty m_newCharmTrackProperty;

		// Token: 0x0403F90B RID: 260363
		[Token(Token = "0x403F90B")]
		[FieldOffset(Offset = "0xA0")]
		private TrackPointViewProperty m_recycleCharmTrackProperty;

		// Token: 0x0403F90C RID: 260364
		[Token(Token = "0x403F90C")]
		[FieldOffset(Offset = "0xA8")]
		private TrackPointViewProperty m_honorsShowcaseTrackPointProperty;

		// Token: 0x0403F90D RID: 260365
		[Token(Token = "0x403F90D")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_isLoaded;

		// Token: 0x0403F90E RID: 260366
		[Token(Token = "0x403F90E")]
		[FieldOffset(Offset = "0xB8")]
		private ActFavorUpTrackPointParam m_favorUpTrackPointParam;

		// Token: 0x0403F910 RID: 260368
		[Token(Token = "0x403F910")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_floatStateEngine;

		// Token: 0x0403F911 RID: 260369
		[Token(Token = "0x403F911")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_zoneDescGroupProperty;

		// Token: 0x0403F912 RID: 260370
		[Token(Token = "0x403F912")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_missionProperty;

		// Token: 0x0403F913 RID: 260371
		[Token(Token = "0x403F913")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_milestoneProperty;

		// Token: 0x0403F914 RID: 260372
		[Token(Token = "0x403F914")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_favorUpTrackProperty;

		// Token: 0x0403F915 RID: 260373
		[Token(Token = "0x403F915")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_milestoneTrackPointProp;

		// Token: 0x0403F916 RID: 260374
		[Token(Token = "0x403F916")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_missionTrackPointProp;

		// Token: 0x0403F917 RID: 260375
		[Token(Token = "0x403F917")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_honorShowcaseProperty;

		// Token: 0x0403F918 RID: 260376
		[Token(Token = "0x403F918")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_newCharmTrackPointProp;

		// Token: 0x0403F919 RID: 260377
		[Token(Token = "0x403F919")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_recycleCharmTrackPointProp;

		// Token: 0x0403F91A RID: 260378
		[Token(Token = "0x403F91A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_disableStageEntryPartical;

		// Token: 0x0403F91B RID: 260379
		[Token(Token = "0x403F91B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_isLoaded;

		// Token: 0x0403F91C RID: 260380
		[Token(Token = "0x403F91C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_onStageTimeout;

		// Token: 0x0403F91D RID: 260381
		[Token(Token = "0x403F91D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_onStageTimeout;

		// Token: 0x0403F91E RID: 260382
		[Token(Token = "0x403F91E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_CreateBridge;

		// Token: 0x0403F91F RID: 260383
		[Token(Token = "0x403F91F")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnLoaded;

		// Token: 0x0403F920 RID: 260384
		[Token(Token = "0x403F920")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnStageTimeout;

		// Token: 0x0403F921 RID: 260385
		[Token(Token = "0x403F921")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnStagePageResumed;

		// Token: 0x0403F922 RID: 260386
		[Token(Token = "0x403F922")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_LoadCoroutine;

		// Token: 0x0403F923 RID: 260387
		[Token(Token = "0x403F923")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_EventOnZoneClicked;

		// Token: 0x0403F924 RID: 260388
		[Token(Token = "0x403F924")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_RefreshMilestoneStatus;

		// Token: 0x0403F925 RID: 260389
		[Token(Token = "0x403F925")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_RefreshFavorUpTrackPoint;

		// Token: 0x0403F926 RID: 260390
		[Token(Token = "0x403F926")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_RefreshMilestoneTrackPoint;

		// Token: 0x0403F927 RID: 260391
		[Token(Token = "0x403F927")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_RefreshMissionTrackPoint;

		// Token: 0x0403F928 RID: 260392
		[Token(Token = "0x403F928")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_RefreshNewCharmTrackPoint;

		// Token: 0x0403F929 RID: 260393
		[Token(Token = "0x403F929")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_RefreshRecycleCharmTrackPoint;

		// Token: 0x0403F92A RID: 260394
		[Token(Token = "0x403F92A")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_RefreshHonorShowcaseTrackPoint;

		// Token: 0x0403F92B RID: 260395
		[Token(Token = "0x403F92B")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_CheckMissionAndRefreshTrackPoint;

		// Token: 0x0403F92C RID: 260396
		[Token(Token = "0x403F92C")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_FetchFavorUpList;

		// Token: 0x0403F92D RID: 260397
		[Token(Token = "0x403F92D")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__TrySyncMissionStatus;

		// Token: 0x0403F92E RID: 260398
		[Token(Token = "0x403F92E")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__HasMissionNew;

		// Token: 0x0403F92F RID: 260399
		[Token(Token = "0x403F92F")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__HasPhotoNew;

		// Token: 0x0403F930 RID: 260400
		[Token(Token = "0x403F930")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__InitMissionProperty;

		// Token: 0x0403F931 RID: 260401
		[Token(Token = "0x403F931")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__RefreshMissionProperty;

		// Token: 0x0403F932 RID: 260402
		[Token(Token = "0x403F932")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__InitMilestoneProperty;

		// Token: 0x0403F933 RID: 260403
		[Token(Token = "0x403F933")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007A6B RID: 31339
		[Token(Token = "0x2007A6B")]
		public class Bridge : ActivityStageBridge
		{
			// Token: 0x0602BE64 RID: 179812 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BE64")]
			[Address(RVA = "0x27D1A40", Offset = "0x27D0640", VA = "0x1827D1A40", Slot = "5")]
			protected override void OnZoneSelected(string selectedZoneId)
			{
			}

			// Token: 0x0602BE65 RID: 179813 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BE65")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Bridge()
			{
			}
		}
	}
}
