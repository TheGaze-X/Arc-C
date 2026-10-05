using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200431F RID: 17183
	[Token(Token = "0x200431F")]
	public class SandboxV2ChallengeModeViewModel : IHotfixable
	{
		// Token: 0x0601A659 RID: 108121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A659")]
		[Address(RVA = "0x1340600", Offset = "0x133F200", VA = "0x181340600")]
		public void LoadData(string topicId, SandboxV2Data dataBase, PlayerSandboxV2 playerData)
		{
		}

		// Token: 0x0601A65A RID: 108122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A65A")]
		[Address(RVA = "0x1341460", Offset = "0x1340060", VA = "0x181341460")]
		private void _RefreshChallengeViewSelection()
		{
		}

		// Token: 0x0601A65B RID: 108123 RVA: 0x000A1AA8 File Offset: 0x0009FCA8
		[Token(Token = "0x601A65B")]
		[Address(RVA = "0x13413B0", Offset = "0x133FFB0", VA = "0x1813413B0")]
		public bool SetChallengeViewSelected(bool selected)
		{
			return default(bool);
		}

		// Token: 0x0601A65C RID: 108124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A65C")]
		[Address(RVA = "0x13414E0", Offset = "0x13400E0", VA = "0x1813414E0")]
		public SandboxV2ChallengeModeViewModel()
		{
		}

		// Token: 0x0402184E RID: 137294
		[Token(Token = "0x402184E")]
		[FieldOffset(Offset = "0x10")]
		public bool challengeSysEnabled;

		// Token: 0x0402184F RID: 137295
		[Token(Token = "0x402184F")]
		[FieldOffset(Offset = "0x11")]
		public bool challengeModeActivated;

		// Token: 0x04021850 RID: 137296
		[Token(Token = "0x4021850")]
		[FieldOffset(Offset = "0x12")]
		public bool challengeModeUnlocked;

		// Token: 0x04021851 RID: 137297
		[Token(Token = "0x4021851")]
		[FieldOffset(Offset = "0x13")]
		public bool isInChallengeMode;

		// Token: 0x04021852 RID: 137298
		[Token(Token = "0x4021852")]
		[FieldOffset(Offset = "0x18")]
		public List<SandboxV2ChallengeModeUnlockCondViewModel> challengeModeUnlockCondList;

		// Token: 0x04021853 RID: 137299
		[Token(Token = "0x4021853")]
		[FieldOffset(Offset = "0x20")]
		public bool isChallengeViewSelected;

		// Token: 0x04021854 RID: 137300
		[Token(Token = "0x4021854")]
		[FieldOffset(Offset = "0x28")]
		public string challengeModeDesc;

		// Token: 0x04021855 RID: 137301
		[Token(Token = "0x4021855")]
		[FieldOffset(Offset = "0x30")]
		public int rewardCanReceiveCount;

		// Token: 0x04021856 RID: 137302
		[Token(Token = "0x4021856")]
		[FieldOffset(Offset = "0x34")]
		public bool isInRift;

		// Token: 0x04021857 RID: 137303
		[Token(Token = "0x4021857")]
		[FieldOffset(Offset = "0x35")]
		public bool currTopicActivated;

		// Token: 0x04021858 RID: 137304
		[Token(Token = "0x4021858")]
		[FieldOffset(Offset = "0x36")]
		public bool otherTopicInChallenge;

		// Token: 0x04021859 RID: 137305
		[Token(Token = "0x4021859")]
		[FieldOffset(Offset = "0x37")]
		public bool hasEnteredOnce;

		// Token: 0x0402185A RID: 137306
		[Token(Token = "0x402185A")]
		[FieldOffset(Offset = "0x38")]
		public PlayerSandboxV2.Challenge.ChallengeStatus challengeStatus;

		// Token: 0x0402185B RID: 137307
		[Token(Token = "0x402185B")]
		[FieldOffset(Offset = "0x40")]
		public SandboxV2ChallengeModeCurrentViewModel currentStatus;

		// Token: 0x0402185C RID: 137308
		[Token(Token = "0x402185C")]
		[FieldOffset(Offset = "0x48")]
		public SandboxV2ChallengeModeHistoryViewModel bestStatus;

		// Token: 0x0402185D RID: 137309
		[Token(Token = "0x402185D")]
		[FieldOffset(Offset = "0x50")]
		public SandboxV2ChallengeModeHistoryViewModel lastStatus;

		// Token: 0x0402185E RID: 137310
		[Token(Token = "0x402185E")]
		[FieldOffset(Offset = "0x58")]
		private PlayerSandboxV2.Challenge.ChallengeStatus m_cachedChallengeStatus;

		// Token: 0x0402185F RID: 137311
		[Token(Token = "0x402185F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04021860 RID: 137312
		[Token(Token = "0x4021860")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RefreshChallengeViewSelection;

		// Token: 0x04021861 RID: 137313
		[Token(Token = "0x4021861")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetChallengeViewSelected;

		// Token: 0x04021862 RID: 137314
		[Token(Token = "0x4021862")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
