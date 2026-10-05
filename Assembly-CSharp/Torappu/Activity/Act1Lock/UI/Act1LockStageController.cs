using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using Torappu.UI.ActivityStage.Extern;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x0200787C RID: 30844
	[Token(Token = "0x200787C")]
	public class Act1LockStageController : ActivityStageController
	{
		// Token: 0x17006526 RID: 25894
		// (get) Token: 0x0602B3A9 RID: 177065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006526")]
		public Act1LockMainProperty mainProperty
		{
			[Token(Token = "0x602B3A9")]
			[Address(RVA = "0x2717EB0", Offset = "0x2716AB0", VA = "0x182717EB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006527 RID: 25895
		// (get) Token: 0x0602B3AA RID: 177066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006527")]
		public TrackPointViewProperty milestoneTrackProperty
		{
			[Token(Token = "0x602B3AA")]
			[Address(RVA = "0x2717F10", Offset = "0x2716B10", VA = "0x182717F10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006528 RID: 25896
		// (get) Token: 0x0602B3AB RID: 177067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006528")]
		public TrackPointViewProperty missionTrackProperty
		{
			[Token(Token = "0x602B3AB")]
			[Address(RVA = "0x2717F70", Offset = "0x2716B70", VA = "0x182717F70")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602B3AC RID: 177068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B3AC")]
		[Address(RVA = "0x2717BF0", Offset = "0x27167F0", VA = "0x182717BF0")]
		public void RefreshMainInfo()
		{
		}

		// Token: 0x0602B3AD RID: 177069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B3AD")]
		[Address(RVA = "0x2717B50", Offset = "0x2716750", VA = "0x182717B50", Slot = "17")]
		protected override void OnStagePageResumed(UIPageTransContext context)
		{
		}

		// Token: 0x0602B3AE RID: 177070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B3AE")]
		[Address(RVA = "0x2717AA0", Offset = "0x27166A0", VA = "0x182717AA0", Slot = "9")]
		public override IEnumerator LoadCoroutine()
		{
			return null;
		}

		// Token: 0x0602B3AF RID: 177071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B3AF")]
		[Address(RVA = "0x2717CD0", Offset = "0x27168D0", VA = "0x182717CD0")]
		private IEnumerator _TryOpenMapPage(string stageId)
		{
			return null;
		}

		// Token: 0x0602B3B0 RID: 177072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B3B0")]
		[Address(RVA = "0x27179F0", Offset = "0x27165F0", VA = "0x1827179F0", Slot = "20")]
		public override IEnumerator GetReadySignalForStagePage()
		{
			return null;
		}

		// Token: 0x0602B3B1 RID: 177073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B3B1")]
		[Address(RVA = "0x2717960", Offset = "0x2716560", VA = "0x182717960", Slot = "5")]
		protected override ActivityStageBridge CreateBridge()
		{
			return null;
		}

		// Token: 0x0602B3B2 RID: 177074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B3B2")]
		[Address(RVA = "0x2717DA0", Offset = "0x27169A0", VA = "0x182717DA0")]
		public Act1LockStageController()
		{
		}

		// Token: 0x0602B3B4 RID: 177076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B3B4")]
		[Address(RVA = "0x22DB680", Offset = "0x22DA280", VA = "0x1822DB680")]
		private void <>xLuaBaseProxy_OnStagePageResumed(UIPageTransContext P0)
		{
		}

		// Token: 0x0602B3B5 RID: 177077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B3B5")]
		[Address(RVA = "0x246D290", Offset = "0x246BE90", VA = "0x18246D290")]
		private IEnumerator <>xLuaBaseProxy_LoadCoroutine()
		{
			return null;
		}

		// Token: 0x0602B3B6 RID: 177078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B3B6")]
		[Address(RVA = "0x2717CC0", Offset = "0x27168C0", VA = "0x182717CC0")]
		private IEnumerator <>xLuaBaseProxy_GetReadySignalForStagePage()
		{
			return null;
		}

		// Token: 0x0403E7E1 RID: 255969
		[Token(Token = "0x403E7E1")]
		[FieldOffset(Offset = "0x60")]
		private Act1LockMainProperty m_mainProperty;

		// Token: 0x0403E7E2 RID: 255970
		[Token(Token = "0x403E7E2")]
		[FieldOffset(Offset = "0x68")]
		private TrackPointViewProperty m_milestoneTrackProperty;

		// Token: 0x0403E7E3 RID: 255971
		[Token(Token = "0x403E7E3")]
		[FieldOffset(Offset = "0x70")]
		private TrackPointViewProperty m_missionTrackProperty;

		// Token: 0x0403E7E4 RID: 255972
		[Token(Token = "0x403E7E4")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isCustomInitFinish;

		// Token: 0x0403E7E5 RID: 255973
		[Token(Token = "0x403E7E5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_mainProperty;

		// Token: 0x0403E7E6 RID: 255974
		[Token(Token = "0x403E7E6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_milestoneTrackProperty;

		// Token: 0x0403E7E7 RID: 255975
		[Token(Token = "0x403E7E7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_missionTrackProperty;

		// Token: 0x0403E7E8 RID: 255976
		[Token(Token = "0x403E7E8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RefreshMainInfo;

		// Token: 0x0403E7E9 RID: 255977
		[Token(Token = "0x403E7E9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnStagePageResumed;

		// Token: 0x0403E7EA RID: 255978
		[Token(Token = "0x403E7EA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadCoroutine;

		// Token: 0x0403E7EB RID: 255979
		[Token(Token = "0x403E7EB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TryOpenMapPage;

		// Token: 0x0403E7EC RID: 255980
		[Token(Token = "0x403E7EC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetReadySignalForStagePage;

		// Token: 0x0403E7ED RID: 255981
		[Token(Token = "0x403E7ED")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CreateBridge;

		// Token: 0x0403E7EE RID: 255982
		[Token(Token = "0x403E7EE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200787D RID: 30845
		[Token(Token = "0x200787D")]
		public class Bridge : ActivityStageBridge
		{
			// Token: 0x0602B3B7 RID: 177079 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B3B7")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Bridge()
			{
			}
		}
	}
}
