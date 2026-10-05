using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using Torappu.UI.ActivityStage.Extern;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020068E3 RID: 26851
	[Token(Token = "0x20068E3")]
	public class StageActivityLoader : PageSingleComponent
	{
		// Token: 0x0602677C RID: 157564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602677C")]
		[Address(RVA = "0x2181250", Offset = "0x217FE50", VA = "0x182181250")]
		private void Update()
		{
		}

		// Token: 0x0602677D RID: 157565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602677D")]
		[Address(RVA = "0x2180FA0", Offset = "0x217FBA0", VA = "0x182180FA0")]
		public static void RegisterActivityZones(UIPageFinder.Interface page, ListDict<ZoneViewType, ZoneGroupViewModel> zones)
		{
		}

		// Token: 0x17005AD8 RID: 23256
		// (get) Token: 0x0602677E RID: 157566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005AD8")]
		public ActivityStageController activityController
		{
			[Token(Token = "0x602677E")]
			[Address(RVA = "0x21844E0", Offset = "0x21830E0", VA = "0x1821844E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005AD9 RID: 23257
		// (get) Token: 0x0602677F RID: 157567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005AD9")]
		public string activityId
		{
			[Token(Token = "0x602677F")]
			[Address(RVA = "0x2184540", Offset = "0x2183140", VA = "0x182184540")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005ADA RID: 23258
		// (get) Token: 0x06026780 RID: 157568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005ADA")]
		public ListDict<string, ActivityBasicInfo> activities
		{
			[Token(Token = "0x6026780")]
			[Address(RVA = "0x2184350", Offset = "0x2182F50", VA = "0x182184350")]
			get
			{
				return null;
			}
		}

		// Token: 0x06026781 RID: 157569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026781")]
		[Address(RVA = "0x2180D40", Offset = "0x217F940", VA = "0x182180D40")]
		public void NotifyStagePageResumed(UIPageTransContext context)
		{
		}

		// Token: 0x06026782 RID: 157570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026782")]
		[Address(RVA = "0x2180C80", Offset = "0x217F880", VA = "0x182180C80")]
		public void NotifyPageHideEffect()
		{
		}

		// Token: 0x06026783 RID: 157571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026783")]
		[Address(RVA = "0x2180E50", Offset = "0x217FA50", VA = "0x182180E50")]
		public void NotifyStageZoneSelectStateSetEffectEnable(bool enable)
		{
		}

		// Token: 0x06026784 RID: 157572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026784")]
		[Address(RVA = "0x2180F30", Offset = "0x217FB30", VA = "0x182180F30", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06026785 RID: 157573 RVA: 0x000CB430 File Offset: 0x000C9630
		[Token(Token = "0x6026785")]
		[Address(RVA = "0x2180B50", Offset = "0x217F750", VA = "0x182180B50")]
		public bool IsStateStable()
		{
			return default(bool);
		}

		// Token: 0x06026786 RID: 157574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026786")]
		[Address(RVA = "0x2181310", Offset = "0x217FF10", VA = "0x182181310")]
		public IEnumerator WaitForStateStable()
		{
			return null;
		}

		// Token: 0x06026787 RID: 157575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026787")]
		[Address(RVA = "0x2180BC0", Offset = "0x217F7C0", VA = "0x182180BC0")]
		public void LoadActivity(string activityId)
		{
		}

		// Token: 0x06026788 RID: 157576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026788")]
		[Address(RVA = "0x2182C30", Offset = "0x2181830", VA = "0x182182C30")]
		private void _LoadActivityInternal(string activityId)
		{
		}

		// Token: 0x06026789 RID: 157577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026789")]
		[Address(RVA = "0x2182AC0", Offset = "0x21816C0", VA = "0x182182AC0")]
		private IEnumerator _LoadActivityCoroutine(string activityId, StageActivityLoader.LoadExtraParams extraParams)
		{
			return null;
		}

		// Token: 0x0602678A RID: 157578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602678A")]
		[Address(RVA = "0x2183300", Offset = "0x2181F00", VA = "0x182183300")]
		private void _ResetIfNecessary()
		{
		}

		// Token: 0x0602678B RID: 157579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602678B")]
		[Address(RVA = "0x2182410", Offset = "0x2181010", VA = "0x182182410")]
		private ActivityStageController _InstantiateController(ActivityBasicInfo basicInfo, ActivityStageController prefab, string dynEntryId, ActivityStageDynEntry dynEntryPrefab)
		{
			return null;
		}

		// Token: 0x0602678C RID: 157580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602678C")]
		[Address(RVA = "0x21815B0", Offset = "0x21801B0", VA = "0x1821815B0")]
		private static void _ClearActivity(ActivityStageController controller)
		{
		}

		// Token: 0x0602678D RID: 157581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602678D")]
		[Address(RVA = "0x2181A60", Offset = "0x2180660", VA = "0x182181A60")]
		private static void _DeleteExternalComponent(MonoBehaviour comp)
		{
		}

		// Token: 0x0602678E RID: 157582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602678E")]
		[Address(RVA = "0x21838A0", Offset = "0x21824A0", VA = "0x1821838A0")]
		private static void _SetupExternalComponentTransition(MonoBehaviour comp, SafeParentComponent parent)
		{
		}

		// Token: 0x0602678F RID: 157583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602678F")]
		[Address(RVA = "0x21813C0", Offset = "0x217FFC0", VA = "0x1821813C0")]
		private static StageActivityLoader _CheckInst(UIPageFinder.Interface pageInterface)
		{
			return null;
		}

		// Token: 0x06026790 RID: 157584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026790")]
		[Address(RVA = "0x2183A80", Offset = "0x2182680", VA = "0x182183A80")]
		private void _UnloadUnusedResources()
		{
		}

		// Token: 0x06026791 RID: 157585 RVA: 0x000CB448 File Offset: 0x000C9648
		[Token(Token = "0x6026791")]
		[Address(RVA = "0x2181480", Offset = "0x2180080", VA = "0x182181480")]
		private bool _CheckResourceUnused(string resourceId, StageActivityLoader.ResourceType resourceType)
		{
			return default(bool);
		}

		// Token: 0x06026792 RID: 157586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026792")]
		[Address(RVA = "0x21820D0", Offset = "0x2180CD0", VA = "0x1821820D0")]
		private StageActivityLoader.LoadActivityCommonFlowPlugin _GetFlowPlugin(string activityId, StageActivityLoader.LoadExtraParams extraParams)
		{
			return null;
		}

		// Token: 0x06026793 RID: 157587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026793")]
		[Address(RVA = "0x2183080", Offset = "0x2181C80", VA = "0x182183080")]
		private void _NotifyActivityLoadToStagePage(ActivityStageController controller)
		{
		}

		// Token: 0x06026794 RID: 157588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026794")]
		[Address(RVA = "0x21840E0", Offset = "0x2182CE0", VA = "0x1821840E0")]
		private IEnumerator _WaitForReadySignalFromController(string activityId, IEnumerator coroutine)
		{
			return null;
		}

		// Token: 0x06026795 RID: 157589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026795")]
		[Address(RVA = "0x21819D0", Offset = "0x21805D0", VA = "0x1821819D0")]
		private Coroutine _CoroutineWithPage(IEnumerator routine)
		{
			return null;
		}

		// Token: 0x06026796 RID: 157590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026796")]
		[Address(RVA = "0x2183FB0", Offset = "0x2182BB0", VA = "0x182183FB0")]
		private void _UpdateStageEntryParticalStatus(ActivityStageController controller)
		{
		}

		// Token: 0x06026797 RID: 157591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026797")]
		[Address(RVA = "0x21822A0", Offset = "0x2180EA0", VA = "0x1821822A0")]
		private void _GetZonesForActivity(string acitivtyId, List<ActivityZoneViewModel> outputList)
		{
		}

		// Token: 0x06026798 RID: 157592 RVA: 0x000CB460 File Offset: 0x000C9660
		[Token(Token = "0x6026798")]
		[Address(RVA = "0x2181E30", Offset = "0x2180A30", VA = "0x182181E30")]
		private bool _FocusToZone(string zoneId)
		{
			return default(bool);
		}

		// Token: 0x06026799 RID: 157593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026799")]
		[Address(RVA = "0x2181CC0", Offset = "0x21808C0", VA = "0x182181CC0")]
		private ZoneViewModel _FindZone(string zoneId)
		{
			return null;
		}

		// Token: 0x0602679A RID: 157594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602679A")]
		[Address(RVA = "0x2181F70", Offset = "0x2180B70", VA = "0x182181F70")]
		private string _GetCurrentSelectedZone()
		{
			return null;
		}

		// Token: 0x0602679B RID: 157595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602679B")]
		[Address(RVA = "0x2181B10", Offset = "0x2180710", VA = "0x182181B10")]
		private void _ExitCurrentActivity()
		{
		}

		// Token: 0x0602679C RID: 157596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602679C")]
		[Address(RVA = "0x21841E0", Offset = "0x2182DE0", VA = "0x1821841E0")]
		public StageActivityLoader()
		{
		}

		// Token: 0x0602679D RID: 157597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602679D")]
		[Address(RVA = "0xEDDC40", Offset = "0xEDC840", VA = "0x180EDDC40")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x04036321 RID: 221985
		[Token(Token = "0x4036321")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SafeParentComponent _embedEntryParent;

		// Token: 0x04036322 RID: 221986
		[Token(Token = "0x4036322")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SafeParentComponent _floatParent;

		// Token: 0x04036323 RID: 221987
		[Token(Token = "0x4036323")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SafeParentComponent _mapDecorParent;

		// Token: 0x04036324 RID: 221988
		[Token(Token = "0x4036324")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SafeParentComponent _stagePreviewParent;

		// Token: 0x04036325 RID: 221989
		[Token(Token = "0x4036325")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SafeParentComponent _floatEntryParent;

		// Token: 0x04036326 RID: 221990
		[Token(Token = "0x4036326")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ScreenEffectHolder _stageEntryPartical;

		// Token: 0x04036327 RID: 221991
		[Token(Token = "0x4036327")]
		[FieldOffset(Offset = "0x50")]
		private ListDict<string, ActivityBasicInfo> m_activities;

		// Token: 0x04036328 RID: 221992
		[Token(Token = "0x4036328")]
		[FieldOffset(Offset = "0x58")]
		private List<ActivityZoneViewModel> m_activityZones;

		// Token: 0x04036329 RID: 221993
		[Token(Token = "0x4036329")]
		[FieldOffset(Offset = "0x60")]
		private ActivityStageController m_actController;

		// Token: 0x0403632A RID: 221994
		[Token(Token = "0x403632A")]
		[FieldOffset(Offset = "0x68")]
		private string m_targetActivityId;

		// Token: 0x0403632B RID: 221995
		[Token(Token = "0x403632B")]
		[FieldOffset(Offset = "0x70")]
		private string m_targetActivityDynEntryId;

		// Token: 0x0403632C RID: 221996
		[Token(Token = "0x403632C")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<string, StageActivityLoader.ResourceConfig> m_activeResources;

		// Token: 0x0403632D RID: 221997
		[Token(Token = "0x403632D")]
		[FieldOffset(Offset = "0x80")]
		private StageActivityLoader.State m_state;

		// Token: 0x0403632E RID: 221998
		[Token(Token = "0x403632E")]
		[FieldOffset(Offset = "0x88")]
		private StageActivityLoader.LoadContext m_loadContext;

		// Token: 0x0403632F RID: 221999
		[Token(Token = "0x403632F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04036330 RID: 222000
		[Token(Token = "0x4036330")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RegisterActivityZones;

		// Token: 0x04036331 RID: 222001
		[Token(Token = "0x4036331")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_activityController;

		// Token: 0x04036332 RID: 222002
		[Token(Token = "0x4036332")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_activityId;

		// Token: 0x04036333 RID: 222003
		[Token(Token = "0x4036333")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_activities;

		// Token: 0x04036334 RID: 222004
		[Token(Token = "0x4036334")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_NotifyStagePageResumed;

		// Token: 0x04036335 RID: 222005
		[Token(Token = "0x4036335")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_NotifyPageHideEffect;

		// Token: 0x04036336 RID: 222006
		[Token(Token = "0x4036336")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_NotifyStageZoneSelectStateSetEffectEnable;

		// Token: 0x04036337 RID: 222007
		[Token(Token = "0x4036337")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04036338 RID: 222008
		[Token(Token = "0x4036338")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_IsStateStable;

		// Token: 0x04036339 RID: 222009
		[Token(Token = "0x4036339")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_WaitForStateStable;

		// Token: 0x0403633A RID: 222010
		[Token(Token = "0x403633A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_LoadActivity;

		// Token: 0x0403633B RID: 222011
		[Token(Token = "0x403633B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__LoadActivityInternal;

		// Token: 0x0403633C RID: 222012
		[Token(Token = "0x403633C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__LoadActivityCoroutine;

		// Token: 0x0403633D RID: 222013
		[Token(Token = "0x403633D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ResetIfNecessary;

		// Token: 0x0403633E RID: 222014
		[Token(Token = "0x403633E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__InstantiateController;

		// Token: 0x0403633F RID: 222015
		[Token(Token = "0x403633F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__ClearActivity;

		// Token: 0x04036340 RID: 222016
		[Token(Token = "0x4036340")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__DeleteExternalComponent;

		// Token: 0x04036341 RID: 222017
		[Token(Token = "0x4036341")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__SetupExternalComponentTransition;

		// Token: 0x04036342 RID: 222018
		[Token(Token = "0x4036342")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__CheckInst;

		// Token: 0x04036343 RID: 222019
		[Token(Token = "0x4036343")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__UnloadUnusedResources;

		// Token: 0x04036344 RID: 222020
		[Token(Token = "0x4036344")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__CheckResourceUnused;

		// Token: 0x04036345 RID: 222021
		[Token(Token = "0x4036345")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__GetFlowPlugin;

		// Token: 0x04036346 RID: 222022
		[Token(Token = "0x4036346")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__NotifyActivityLoadToStagePage;

		// Token: 0x04036347 RID: 222023
		[Token(Token = "0x4036347")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__WaitForReadySignalFromController;

		// Token: 0x04036348 RID: 222024
		[Token(Token = "0x4036348")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__CoroutineWithPage;

		// Token: 0x04036349 RID: 222025
		[Token(Token = "0x4036349")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__UpdateStageEntryParticalStatus;

		// Token: 0x0403634A RID: 222026
		[Token(Token = "0x403634A")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__GetZonesForActivity;

		// Token: 0x0403634B RID: 222027
		[Token(Token = "0x403634B")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__FocusToZone;

		// Token: 0x0403634C RID: 222028
		[Token(Token = "0x403634C")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__FindZone;

		// Token: 0x0403634D RID: 222029
		[Token(Token = "0x403634D")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__GetCurrentSelectedZone;

		// Token: 0x0403634E RID: 222030
		[Token(Token = "0x403634E")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__ExitCurrentActivity;

		// Token: 0x0403634F RID: 222031
		[Token(Token = "0x403634F")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020068E4 RID: 26852
		[Token(Token = "0x20068E4")]
		public enum State
		{
			// Token: 0x04036351 RID: 222033
			[Token(Token = "0x4036351")]
			NONE,
			// Token: 0x04036352 RID: 222034
			[Token(Token = "0x4036352")]
			LOADING,
			// Token: 0x04036353 RID: 222035
			[Token(Token = "0x4036353")]
			TRANSITING,
			// Token: 0x04036354 RID: 222036
			[Token(Token = "0x4036354")]
			LOADED
		}

		// Token: 0x020068E5 RID: 26853
		[Token(Token = "0x20068E5")]
		private struct LoadOpt
		{
			// Token: 0x17005ADB RID: 23259
			// (get) Token: 0x0602679E RID: 157598 RVA: 0x000CB478 File Offset: 0x000C9678
			// (set) Token: 0x0602679F RID: 157599 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005ADB")]
			public bool isEmpty
			{
				[Token(Token = "0x602679E")]
				[Address(RVA = "0xDF9A30", Offset = "0xDF8630", VA = "0x180DF9A30")]
				[CompilerGenerated]
				readonly get
				{
					return default(bool);
				}
				[Token(Token = "0x602679F")]
				[Address(RVA = "0xFEDED0", Offset = "0xFECAD0", VA = "0x180FEDED0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x04036355 RID: 222037
			[Token(Token = "0x4036355")]
			[FieldOffset(Offset = "0x0")]
			public static readonly StageActivityLoader.LoadOpt EMPTY;

			// Token: 0x04036357 RID: 222039
			[Token(Token = "0x4036357")]
			[FieldOffset(Offset = "0x8")]
			public string activityId;
		}

		// Token: 0x020068E6 RID: 26854
		[Token(Token = "0x20068E6")]
		private struct LoadContext
		{
			// Token: 0x17005ADC RID: 23260
			// (get) Token: 0x060267A1 RID: 157601 RVA: 0x000CB490 File Offset: 0x000C9690
			[Token(Token = "0x17005ADC")]
			public bool isEmpty
			{
				[Token(Token = "0x60267A1")]
				[Address(RVA = "0xDF9A30", Offset = "0xDF8630", VA = "0x180DF9A30")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x04036358 RID: 222040
			[Token(Token = "0x4036358")]
			[FieldOffset(Offset = "0x0")]
			public static readonly StageActivityLoader.LoadContext EMPTY;

			// Token: 0x04036359 RID: 222041
			[Token(Token = "0x4036359")]
			[FieldOffset(Offset = "0x0")]
			private bool m_isEmpty;

			// Token: 0x0403635A RID: 222042
			[Token(Token = "0x403635A")]
			[FieldOffset(Offset = "0x8")]
			public ActivityStageController newController;

			// Token: 0x0403635B RID: 222043
			[Token(Token = "0x403635B")]
			[FieldOffset(Offset = "0x10")]
			public ActivityStageController oldController;

			// Token: 0x0403635C RID: 222044
			[Token(Token = "0x403635C")]
			[FieldOffset(Offset = "0x18")]
			public StageActivityLoader.LoadOpt pendingOpt;
		}

		// Token: 0x020068E7 RID: 26855
		[Token(Token = "0x20068E7")]
		private struct LoadExtraParams
		{
			// Token: 0x0403635D RID: 222045
			[Token(Token = "0x403635D")]
			[FieldOffset(Offset = "0x0")]
			public string activityDynEntryId;

			// Token: 0x0403635E RID: 222046
			[Token(Token = "0x403635E")]
			[FieldOffset(Offset = "0x8")]
			public ActivityStageController.ActivityControllerTransitionReason transitionReason;
		}

		// Token: 0x020068E8 RID: 26856
		[Token(Token = "0x20068E8")]
		private enum ResourceType
		{
			// Token: 0x04036360 RID: 222048
			[Token(Token = "0x4036360")]
			NONE,
			// Token: 0x04036361 RID: 222049
			[Token(Token = "0x4036361")]
			TYPE_ACTIVITY_CONTROLLER,
			// Token: 0x04036362 RID: 222050
			[Token(Token = "0x4036362")]
			TYPE_ACTIVITY_DYN_ENTRY
		}

		// Token: 0x020068E9 RID: 26857
		[Token(Token = "0x20068E9")]
		private struct ResourceConfig
		{
			// Token: 0x04036363 RID: 222051
			[Token(Token = "0x4036363")]
			[FieldOffset(Offset = "0x0")]
			public UnityEngine.Object resource;

			// Token: 0x04036364 RID: 222052
			[Token(Token = "0x4036364")]
			[FieldOffset(Offset = "0x8")]
			public StageActivityLoader.ResourceType resourceType;
		}

		// Token: 0x020068EA RID: 26858
		[Token(Token = "0x20068EA")]
		private class LoadActivityCommonFlowPlugin : IHotfixable
		{
			// Token: 0x060267A3 RID: 157603 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60267A3")]
			[Address(RVA = "0x217A600", Offset = "0x2179200", VA = "0x18217A600")]
			public LoadActivityCommonFlowPlugin(StageActivityLoader closure)
			{
			}

			// Token: 0x060267A4 RID: 157604 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60267A4")]
			[Address(RVA = "0x217A480", Offset = "0x2179080", VA = "0x18217A480", Slot = "4")]
			public virtual IEnumerator OverrideBeforeTransition()
			{
				return null;
			}

			// Token: 0x060267A5 RID: 157605 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60267A5")]
			[Address(RVA = "0x217A420", Offset = "0x2179020", VA = "0x18217A420", Slot = "5")]
			public virtual void OverrideAfterTransition()
			{
			}

			// Token: 0x04036365 RID: 222053
			[Token(Token = "0x4036365")]
			[FieldOffset(Offset = "0x10")]
			protected StageActivityLoader closure;

			// Token: 0x04036366 RID: 222054
			[Token(Token = "0x4036366")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04036367 RID: 222055
			[Token(Token = "0x4036367")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OverrideBeforeTransition;

			// Token: 0x04036368 RID: 222056
			[Token(Token = "0x4036368")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OverrideAfterTransition;
		}

		// Token: 0x020068EB RID: 26859
		[Token(Token = "0x20068EB")]
		private class LoadActivityByDynEntryReplacementFlowPlugin : StageActivityLoader.LoadActivityCommonFlowPlugin
		{
			// Token: 0x060267A6 RID: 157606 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60267A6")]
			[Address(RVA = "0x217A590", Offset = "0x2179190", VA = "0x18217A590")]
			public LoadActivityByDynEntryReplacementFlowPlugin(StageActivityLoader closure)
			{
			}

			// Token: 0x060267A7 RID: 157607 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60267A7")]
			[Address(RVA = "0x217A4E0", Offset = "0x21790E0", VA = "0x18217A4E0")]
			private IEnumerator _OverrideBeforeTransition()
			{
				return null;
			}

			// Token: 0x060267A8 RID: 157608 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60267A8")]
			[Address(RVA = "0x217A320", Offset = "0x2178F20", VA = "0x18217A320", Slot = "4")]
			public override IEnumerator OverrideBeforeTransition()
			{
				return null;
			}

			// Token: 0x060267A9 RID: 157609 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60267A9")]
			[Address(RVA = "0x217A1D0", Offset = "0x2178DD0", VA = "0x18217A1D0", Slot = "5")]
			public override void OverrideAfterTransition()
			{
			}

			// Token: 0x060267AA RID: 157610 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60267AA")]
			[Address(RVA = "0x217A480", Offset = "0x2179080", VA = "0x18217A480")]
			private IEnumerator <>xLuaBaseProxy_OverrideBeforeTransition()
			{
				return null;
			}

			// Token: 0x060267AB RID: 157611 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60267AB")]
			[Address(RVA = "0x217A420", Offset = "0x2179020", VA = "0x18217A420")]
			private void <>xLuaBaseProxy_OverrideAfterTransition()
			{
			}

			// Token: 0x04036369 RID: 222057
			[Token(Token = "0x4036369")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403636A RID: 222058
			[Token(Token = "0x403636A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0__OverrideBeforeTransition;

			// Token: 0x0403636B RID: 222059
			[Token(Token = "0x403636B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OverrideBeforeTransition;

			// Token: 0x0403636C RID: 222060
			[Token(Token = "0x403636C")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OverrideAfterTransition;
		}
	}
}
