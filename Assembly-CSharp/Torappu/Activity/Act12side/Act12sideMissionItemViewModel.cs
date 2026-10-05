using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act12side
{
	// Token: 0x02007A64 RID: 31332
	[Token(Token = "0x2007A64")]
	public class Act12sideMissionItemViewModel : IHotfixable
	{
		// Token: 0x170066DB RID: 26331
		// (get) Token: 0x0602BE1D RID: 179741 RVA: 0x000DD880 File Offset: 0x000DBA80
		[Token(Token = "0x170066DB")]
		public int target
		{
			[Token(Token = "0x602BE1D")]
			[Address(RVA = "0x27C2860", Offset = "0x27C1460", VA = "0x1827C2860")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170066DC RID: 26332
		// (get) Token: 0x0602BE1E RID: 179742 RVA: 0x000DD898 File Offset: 0x000DBA98
		[Token(Token = "0x170066DC")]
		public int progress
		{
			[Token(Token = "0x602BE1E")]
			[Address(RVA = "0x27C2800", Offset = "0x27C1400", VA = "0x1827C2800")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170066DD RID: 26333
		// (get) Token: 0x0602BE1F RID: 179743 RVA: 0x000DD8B0 File Offset: 0x000DBAB0
		[Token(Token = "0x170066DD")]
		public float normalizeProgress
		{
			[Token(Token = "0x602BE1F")]
			[Address(RVA = "0x27C2790", Offset = "0x27C1390", VA = "0x1827C2790")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170066DE RID: 26334
		// (get) Token: 0x0602BE20 RID: 179744 RVA: 0x000DD8C8 File Offset: 0x000DBAC8
		[Token(Token = "0x170066DE")]
		public Act12SideData.ActZoneClass zoneClass
		{
			[Token(Token = "0x602BE20")]
			[Address(RVA = "0x27C28C0", Offset = "0x27C14C0", VA = "0x1827C28C0")]
			get
			{
				return Act12SideData.ActZoneClass.NONE;
			}
		}

		// Token: 0x170066DF RID: 26335
		// (get) Token: 0x0602BE21 RID: 179745 RVA: 0x000DD8E0 File Offset: 0x000DBAE0
		[Token(Token = "0x170066DF")]
		public bool isCompleted
		{
			[Token(Token = "0x602BE21")]
			[Address(RVA = "0x27C2730", Offset = "0x27C1330", VA = "0x1827C2730")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602BE22 RID: 179746 RVA: 0x000DD8F8 File Offset: 0x000DBAF8
		[Token(Token = "0x602BE22")]
		[Address(RVA = "0x27C2540", Offset = "0x27C1140", VA = "0x1827C2540")]
		public bool NeedLock()
		{
			return default(bool);
		}

		// Token: 0x0602BE23 RID: 179747 RVA: 0x000DD910 File Offset: 0x000DBB10
		[Token(Token = "0x602BE23")]
		[Address(RVA = "0x27C24B0", Offset = "0x27C10B0", VA = "0x1827C24B0")]
		public bool IsUnlock()
		{
			return default(bool);
		}

		// Token: 0x0602BE24 RID: 179748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE24")]
		[Address(RVA = "0x27C2660", Offset = "0x27C1260", VA = "0x1827C2660")]
		public void ResetStatus()
		{
		}

		// Token: 0x0602BE25 RID: 179749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE25")]
		[Address(RVA = "0x27C25D0", Offset = "0x27C11D0", VA = "0x1827C25D0")]
		public void RefreshStatus(MissionHoldingState state, int target, int progress)
		{
		}

		// Token: 0x0602BE26 RID: 179750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE26")]
		[Address(RVA = "0x27C26D0", Offset = "0x27C12D0", VA = "0x1827C26D0")]
		public Act12sideMissionItemViewModel()
		{
		}

		// Token: 0x0403F8DA RID: 260314
		[Token(Token = "0x403F8DA")]
		[FieldOffset(Offset = "0x10")]
		public Act12SideData.MissionDescInfo missionDescInfo;

		// Token: 0x0403F8DB RID: 260315
		[Token(Token = "0x403F8DB")]
		[FieldOffset(Offset = "0x18")]
		public MissionData missionData;

		// Token: 0x0403F8DC RID: 260316
		[Token(Token = "0x403F8DC")]
		[FieldOffset(Offset = "0x20")]
		public string activityId;

		// Token: 0x0403F8DD RID: 260317
		[Token(Token = "0x403F8DD")]
		[FieldOffset(Offset = "0x28")]
		private MissionHoldingState m_missionState;

		// Token: 0x0403F8DE RID: 260318
		[Token(Token = "0x403F8DE")]
		[FieldOffset(Offset = "0x2C")]
		private int m_target;

		// Token: 0x0403F8DF RID: 260319
		[Token(Token = "0x403F8DF")]
		[FieldOffset(Offset = "0x30")]
		private int m_progress;

		// Token: 0x0403F8E0 RID: 260320
		[Token(Token = "0x403F8E0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_target;

		// Token: 0x0403F8E1 RID: 260321
		[Token(Token = "0x403F8E1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_progress;

		// Token: 0x0403F8E2 RID: 260322
		[Token(Token = "0x403F8E2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_normalizeProgress;

		// Token: 0x0403F8E3 RID: 260323
		[Token(Token = "0x403F8E3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_zoneClass;

		// Token: 0x0403F8E4 RID: 260324
		[Token(Token = "0x403F8E4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isCompleted;

		// Token: 0x0403F8E5 RID: 260325
		[Token(Token = "0x403F8E5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_NeedLock;

		// Token: 0x0403F8E6 RID: 260326
		[Token(Token = "0x403F8E6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_IsUnlock;

		// Token: 0x0403F8E7 RID: 260327
		[Token(Token = "0x403F8E7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ResetStatus;

		// Token: 0x0403F8E8 RID: 260328
		[Token(Token = "0x403F8E8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RefreshStatus;

		// Token: 0x0403F8E9 RID: 260329
		[Token(Token = "0x403F8E9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
