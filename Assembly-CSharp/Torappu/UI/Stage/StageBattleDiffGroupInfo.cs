using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020068CF RID: 26831
	[Token(Token = "0x20068CF")]
	public class StageBattleDiffGroupInfo : IHotfixable
	{
		// Token: 0x17005AD1 RID: 23249
		// (get) Token: 0x06026737 RID: 157495 RVA: 0x000CB328 File Offset: 0x000C9528
		[Token(Token = "0x17005AD1")]
		public int apCost
		{
			[Token(Token = "0x6026737")]
			[Address(RVA = "0x2184600", Offset = "0x2183200", VA = "0x182184600")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06026738 RID: 157496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026738")]
		[Address(RVA = "0x21845A0", Offset = "0x21831A0", VA = "0x1821845A0")]
		public StageBattleDiffGroupInfo()
		{
		}

		// Token: 0x040362BF RID: 221887
		[Token(Token = "0x40362BF")]
		[FieldOffset(Offset = "0x10")]
		public int diffGroupMaskInfo;

		// Token: 0x040362C0 RID: 221888
		[Token(Token = "0x40362C0")]
		[FieldOffset(Offset = "0x14")]
		public int count;

		// Token: 0x040362C1 RID: 221889
		[Token(Token = "0x40362C1")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<StageDiffGroup, StageBattleDiffGroupInfo.StageInfo> diffGroupStageModel;

		// Token: 0x040362C2 RID: 221890
		[Token(Token = "0x40362C2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_apCost;

		// Token: 0x040362C3 RID: 221891
		[Token(Token = "0x40362C3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020068D0 RID: 26832
		[Token(Token = "0x20068D0")]
		public class StageInfo
		{
			// Token: 0x06026739 RID: 157497 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026739")]
			[Address(RVA = "0x2184A50", Offset = "0x2183650", VA = "0x182184A50")]
			public StageInfo(StageViewModel viewModel, bool isOnBattle)
			{
			}

			// Token: 0x040362C4 RID: 221892
			[Token(Token = "0x40362C4")]
			[FieldOffset(Offset = "0x10")]
			public string stageId;

			// Token: 0x040362C5 RID: 221893
			[Token(Token = "0x40362C5")]
			[FieldOffset(Offset = "0x18")]
			public int apCost;

			// Token: 0x040362C6 RID: 221894
			[Token(Token = "0x40362C6")]
			[FieldOffset(Offset = "0x1C")]
			public StageDiffGroup diffGroup;

			// Token: 0x040362C7 RID: 221895
			[Token(Token = "0x40362C7")]
			[FieldOffset(Offset = "0x20")]
			public PlayerStageState state;

			// Token: 0x040362C8 RID: 221896
			[Token(Token = "0x40362C8")]
			[FieldOffset(Offset = "0x28")]
			public List<StageRewardViewModel> displayRewards;

			// Token: 0x040362C9 RID: 221897
			[Token(Token = "0x40362C9")]
			[FieldOffset(Offset = "0x30")]
			public bool isOnBattle;
		}
	}
}
