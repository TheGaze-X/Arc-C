using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042AA RID: 17066
	[Token(Token = "0x20042AA")]
	public class SandboxV2DungeonMiscChallengeViewModel : IHotfixable
	{
		// Token: 0x0601A465 RID: 107621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A465")]
		[Address(RVA = "0x132F7C0", Offset = "0x132E3C0", VA = "0x18132F7C0")]
		public void LoadData(SandboxV2Data topicDetailData, PlayerSandboxV2 playerTopicData)
		{
		}

		// Token: 0x0601A466 RID: 107622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A466")]
		[Address(RVA = "0x132FAF0", Offset = "0x132E6F0", VA = "0x18132FAF0")]
		public SandboxV2DungeonMiscChallengeViewModel()
		{
		}

		// Token: 0x04021493 RID: 136339
		[Token(Token = "0x4021493")]
		[FieldOffset(Offset = "0x10")]
		public int challengeDay;

		// Token: 0x04021494 RID: 136340
		[Token(Token = "0x4021494")]
		[FieldOffset(Offset = "0x14")]
		public int bestDay;

		// Token: 0x04021495 RID: 136341
		[Token(Token = "0x4021495")]
		[FieldOffset(Offset = "0x18")]
		public int nextDebuffDay;

		// Token: 0x04021496 RID: 136342
		[Token(Token = "0x4021496")]
		[FieldOffset(Offset = "0x20")]
		public string titleDesc;

		// Token: 0x04021497 RID: 136343
		[Token(Token = "0x4021497")]
		[FieldOffset(Offset = "0x28")]
		public string debuffCountdownDesc;

		// Token: 0x04021498 RID: 136344
		[Token(Token = "0x4021498")]
		[FieldOffset(Offset = "0x30")]
		public string debuffGainAllDesc;

		// Token: 0x04021499 RID: 136345
		[Token(Token = "0x4021499")]
		[FieldOffset(Offset = "0x38")]
		public string debuffTitleDesc;

		// Token: 0x0402149A RID: 136346
		[Token(Token = "0x402149A")]
		[FieldOffset(Offset = "0x40")]
		public int debuffNum;

		// Token: 0x0402149B RID: 136347
		[Token(Token = "0x402149B")]
		[FieldOffset(Offset = "0x48")]
		public List<string> debuffDesc;

		// Token: 0x0402149C RID: 136348
		[Token(Token = "0x402149C")]
		[FieldOffset(Offset = "0x50")]
		public PlayerSandboxV2.Challenge.ChallengeStatus challengeStatus;

		// Token: 0x0402149D RID: 136349
		[Token(Token = "0x402149D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402149E RID: 136350
		[Token(Token = "0x402149E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
