using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200431E RID: 17182
	[Token(Token = "0x200431E")]
	public class SandboxV2ChallengeModeCurrentViewModel : IHotfixable
	{
		// Token: 0x0601A657 RID: 108119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A657")]
		[Address(RVA = "0x1340280", Offset = "0x133EE80", VA = "0x181340280")]
		public void LoadData(bool isInChallengeMode, PlayerSandboxV2 playerData)
		{
		}

		// Token: 0x0601A658 RID: 108120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A658")]
		[Address(RVA = "0x13403E0", Offset = "0x133EFE0", VA = "0x1813403E0")]
		public SandboxV2ChallengeModeCurrentViewModel()
		{
		}

		// Token: 0x04021847 RID: 137287
		[Token(Token = "0x4021847")]
		[FieldOffset(Offset = "0x10")]
		public bool isInChallengeMode;

		// Token: 0x04021848 RID: 137288
		[Token(Token = "0x4021848")]
		[FieldOffset(Offset = "0x14")]
		public int latestArchiveDay;

		// Token: 0x04021849 RID: 137289
		[Token(Token = "0x4021849")]
		[FieldOffset(Offset = "0x18")]
		public int startDay;

		// Token: 0x0402184A RID: 137290
		[Token(Token = "0x402184A")]
		[FieldOffset(Offset = "0x1C")]
		public int startLoadTimes;

		// Token: 0x0402184B RID: 137291
		[Token(Token = "0x402184B")]
		[FieldOffset(Offset = "0x20")]
		public int challengeDay;

		// Token: 0x0402184C RID: 137292
		[Token(Token = "0x402184C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402184D RID: 137293
		[Token(Token = "0x402184D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
