using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.BossRush;
using XLua;

namespace Torappu.Activity.Act1BossRush
{
	// Token: 0x020070C5 RID: 28869
	[Token(Token = "0x20070C5")]
	public class Act1BossRushMileStoneViewModel : IHotfixable
	{
		// Token: 0x06029077 RID: 168055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029077")]
		[Address(RVA = "0x2469680", Offset = "0x2468280", VA = "0x182469680")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x06029078 RID: 168056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029078")]
		[Address(RVA = "0x2469C40", Offset = "0x2468840", VA = "0x182469C40")]
		public Act1BossRushMileStoneViewModel()
		{
		}

		// Token: 0x0403A906 RID: 239878
		[Token(Token = "0x403A906")]
		[FieldOffset(Offset = "0x10")]
		public List<Act1BossRushMileStoneItemViewModel> dataSet;

		// Token: 0x0403A907 RID: 239879
		[Token(Token = "0x403A907")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, Act1BossRushMileStoneItemViewModel.State> itemStateMap;

		// Token: 0x0403A908 RID: 239880
		[Token(Token = "0x403A908")]
		[FieldOffset(Offset = "0x20")]
		public int focusIndex;

		// Token: 0x0403A909 RID: 239881
		[Token(Token = "0x403A909")]
		[FieldOffset(Offset = "0x28")]
		public string mainItemDesc;

		// Token: 0x0403A90A RID: 239882
		[Token(Token = "0x403A90A")]
		[FieldOffset(Offset = "0x30")]
		public string rewardSkinId;

		// Token: 0x0403A90B RID: 239883
		[Token(Token = "0x403A90B")]
		[FieldOffset(Offset = "0x38")]
		public MilestoneStruct milestoneStruct;

		// Token: 0x0403A90C RID: 239884
		[Token(Token = "0x403A90C")]
		[FieldOffset(Offset = "0x48")]
		public bool hasItemCanReceive;

		// Token: 0x0403A90D RID: 239885
		[Token(Token = "0x403A90D")]
		[FieldOffset(Offset = "0x4C")]
		private int m_point;

		// Token: 0x0403A90E RID: 239886
		[Token(Token = "0x403A90E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403A90F RID: 239887
		[Token(Token = "0x403A90F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
