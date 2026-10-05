using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045F0 RID: 17904
	[Token(Token = "0x20045F0")]
	public abstract class Rl03OuterBuffNodeBaseViewModel : IHotfixable
	{
		// Token: 0x170040CB RID: 16587
		// (get) Token: 0x0601B36A RID: 111466
		[Token(Token = "0x170040CB")]
		public abstract string topicId { [Token(Token = "0x601B36A")] get; }

		// Token: 0x170040CC RID: 16588
		// (get) Token: 0x0601B36B RID: 111467
		[Token(Token = "0x170040CC")]
		public abstract string buffId { [Token(Token = "0x601B36B")] get; }

		// Token: 0x170040CD RID: 16589
		// (get) Token: 0x0601B36C RID: 111468
		[Token(Token = "0x170040CD")]
		public abstract string buffName { [Token(Token = "0x601B36C")] get; }

		// Token: 0x170040CE RID: 16590
		// (get) Token: 0x0601B36D RID: 111469
		[Token(Token = "0x170040CE")]
		public abstract string iconId { [Token(Token = "0x601B36D")] get; }

		// Token: 0x170040CF RID: 16591
		// (get) Token: 0x0601B36E RID: 111470
		[Token(Token = "0x170040CF")]
		public abstract string groupId { [Token(Token = "0x601B36E")] get; }

		// Token: 0x170040D0 RID: 16592
		// (get) Token: 0x0601B36F RID: 111471
		[Token(Token = "0x170040D0")]
		public abstract bool isActive { [Token(Token = "0x601B36F")] get; }

		// Token: 0x170040D1 RID: 16593
		// (get) Token: 0x0601B370 RID: 111472
		[Token(Token = "0x170040D1")]
		public abstract Rl03OuterBuffViewType viewType { [Token(Token = "0x601B370")] get; }

		// Token: 0x170040D2 RID: 16594
		// (get) Token: 0x0601B371 RID: 111473
		[Token(Token = "0x170040D2")]
		public abstract RL03DevelopmentNodeType nodeType { [Token(Token = "0x601B371")] get; }

		// Token: 0x0601B372 RID: 111474
		[Token(Token = "0x601B372")]
		public abstract void LoadData(string topicId, RL03Development buffData, Dictionary<string, RL03DevDifficultyNodeInfo> diffData);

		// Token: 0x0601B373 RID: 111475
		[Token(Token = "0x601B373")]
		public abstract void RefreshStatus(Dictionary<string, int> playerNodeStatus);

		// Token: 0x0601B374 RID: 111476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B374")]
		[Address(RVA = "0x1467550", Offset = "0x1466150", VA = "0x181467550")]
		protected Rl03OuterBuffNodeBaseViewModel()
		{
		}

		// Token: 0x04023177 RID: 143735
		[Token(Token = "0x4023177")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
