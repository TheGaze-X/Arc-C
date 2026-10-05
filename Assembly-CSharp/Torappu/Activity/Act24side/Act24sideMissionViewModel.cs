using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075F5 RID: 30197
	[Token(Token = "0x20075F5")]
	public class Act24sideMissionViewModel : IHotfixable
	{
		// Token: 0x0602A845 RID: 174149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A845")]
		[Address(RVA = "0x262DFD0", Offset = "0x262CBD0", VA = "0x18262DFD0")]
		public void InitData(string actId, [Optional] string clickMissionId)
		{
		}

		// Token: 0x0602A846 RID: 174150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A846")]
		[Address(RVA = "0x262E3E0", Offset = "0x262CFE0", VA = "0x18262E3E0")]
		public void UpdateData(bool ifSort = true)
		{
		}

		// Token: 0x0602A847 RID: 174151 RVA: 0x000D8C78 File Offset: 0x000D6E78
		[Token(Token = "0x602A847")]
		[Address(RVA = "0x262E780", Offset = "0x262D380", VA = "0x18262E780")]
		private int _MissionComparer(Act24sideMissionObjViewModel x, Act24sideMissionObjViewModel y)
		{
			return 0;
		}

		// Token: 0x0602A848 RID: 174152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A848")]
		[Address(RVA = "0x262E5D0", Offset = "0x262D1D0", VA = "0x18262E5D0")]
		private void _CalculateCompleteAndReceiveMissionNum()
		{
		}

		// Token: 0x0602A849 RID: 174153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A849")]
		[Address(RVA = "0x262E8A0", Offset = "0x262D4A0", VA = "0x18262E8A0")]
		public Act24sideMissionViewModel()
		{
		}

		// Token: 0x0403D32B RID: 250667
		[Token(Token = "0x403D32B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string m_actId;

		// Token: 0x0403D32C RID: 250668
		[Token(Token = "0x403D32C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<MissionData> missionData;

		// Token: 0x0403D32D RID: 250669
		[Token(Token = "0x403D32D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int completeMission;

		// Token: 0x0403D32E RID: 250670
		[Token(Token = "0x403D32E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int totalMission;

		// Token: 0x0403D32F RID: 250671
		[Token(Token = "0x403D32F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int pos;

		// Token: 0x0403D330 RID: 250672
		[Token(Token = "0x403D330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int sequenceNum;

		// Token: 0x0403D331 RID: 250673
		[Token(Token = "0x403D331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool haveMissionCanReceive;

		// Token: 0x0403D332 RID: 250674
		[Token(Token = "0x403D332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<Act24sideMissionObjViewModel> act24SideMissionObjViewModelList;

		// Token: 0x0403D333 RID: 250675
		[Token(Token = "0x403D333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0403D334 RID: 250676
		[Token(Token = "0x403D334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0403D335 RID: 250677
		[Token(Token = "0x403D335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__MissionComparer;

		// Token: 0x0403D336 RID: 250678
		[Token(Token = "0x403D336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CalculateCompleteAndReceiveMissionNum;

		// Token: 0x0403D337 RID: 250679
		[Token(Token = "0x403D337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
