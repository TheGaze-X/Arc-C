using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075F6 RID: 30198
	[Token(Token = "0x20075F6")]
	public class Act24sideMissionObjViewModel : IHotfixable
	{
		// Token: 0x0602A84C RID: 174156 RVA: 0x000D8CC0 File Offset: 0x000D6EC0
		[Token(Token = "0x602A84C")]
		[Address(RVA = "0x2626ED0", Offset = "0x2625AD0", VA = "0x182626ED0")]
		public int GetRewardItemCount()
		{
			return 0;
		}

		// Token: 0x0602A84D RID: 174157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A84D")]
		[Address(RVA = "0x2626FA0", Offset = "0x2625BA0", VA = "0x182626FA0")]
		public void LoadData(MissionData missionData, string actId)
		{
		}

		// Token: 0x0602A84E RID: 174158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A84E")]
		[Address(RVA = "0x2627820", Offset = "0x2626420", VA = "0x182627820")]
		public void UpdateState()
		{
		}

		// Token: 0x0602A84F RID: 174159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A84F")]
		[Address(RVA = "0x26279A0", Offset = "0x26265A0", VA = "0x1826279A0")]
		public Act24sideMissionObjViewModel()
		{
		}

		// Token: 0x0403D338 RID: 250680
		[Token(Token = "0x403D338")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0403D339 RID: 250681
		[Token(Token = "0x403D339")]
		[FieldOffset(Offset = "0x18")]
		public string missionId;

		// Token: 0x0403D33A RID: 250682
		[Token(Token = "0x403D33A")]
		[FieldOffset(Offset = "0x20")]
		public string missionTitle;

		// Token: 0x0403D33B RID: 250683
		[Token(Token = "0x403D33B")]
		[FieldOffset(Offset = "0x28")]
		public string missionDesc;

		// Token: 0x0403D33C RID: 250684
		[Token(Token = "0x403D33C")]
		[FieldOffset(Offset = "0x30")]
		public string missionClient;

		// Token: 0x0403D33D RID: 250685
		[Token(Token = "0x403D33D")]
		[FieldOffset(Offset = "0x38")]
		public string missionClientDesc;

		// Token: 0x0403D33E RID: 250686
		[Token(Token = "0x403D33E")]
		[FieldOffset(Offset = "0x40")]
		public int nowSchedule;

		// Token: 0x0403D33F RID: 250687
		[Token(Token = "0x403D33F")]
		[FieldOffset(Offset = "0x44")]
		public int totalSchedule;

		// Token: 0x0403D340 RID: 250688
		[Token(Token = "0x403D340")]
		[FieldOffset(Offset = "0x48")]
		public int sortId;

		// Token: 0x0403D341 RID: 250689
		[Token(Token = "0x403D341")]
		[FieldOffset(Offset = "0x50")]
		public string missionProgressFormat;

		// Token: 0x0403D342 RID: 250690
		[Token(Token = "0x403D342")]
		[FieldOffset(Offset = "0x58")]
		public Act24sideMissionObjViewModel.MissionState missionState;

		// Token: 0x0403D343 RID: 250691
		[Token(Token = "0x403D343")]
		[FieldOffset(Offset = "0x5C")]
		public Act24SideData.MissionType missionType;

		// Token: 0x0403D344 RID: 250692
		[Token(Token = "0x403D344")]
		[FieldOffset(Offset = "0x60")]
		public List<UIItemViewModel> normalRewardList;

		// Token: 0x0403D345 RID: 250693
		[Token(Token = "0x403D345")]
		[FieldOffset(Offset = "0x68")]
		public List<Act24sideMeldingItemViewModel> actRewardList;

		// Token: 0x0403D346 RID: 250694
		[Token(Token = "0x403D346")]
		[FieldOffset(Offset = "0x70")]
		public List<Act24sideMissionActItemViewModel> actItemList;

		// Token: 0x0403D347 RID: 250695
		[Token(Token = "0x403D347")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetRewardItemCount;

		// Token: 0x0403D348 RID: 250696
		[Token(Token = "0x403D348")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403D349 RID: 250697
		[Token(Token = "0x403D349")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403D34A RID: 250698
		[Token(Token = "0x403D34A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020075F7 RID: 30199
		[Token(Token = "0x20075F7")]
		public enum MissionState
		{
			// Token: 0x0403D34C RID: 250700
			[Token(Token = "0x403D34C")]
			CAN_RECEIVE,
			// Token: 0x0403D34D RID: 250701
			[Token(Token = "0x403D34D")]
			DOING,
			// Token: 0x0403D34E RID: 250702
			[Token(Token = "0x403D34E")]
			COMPLETE
		}
	}
}
