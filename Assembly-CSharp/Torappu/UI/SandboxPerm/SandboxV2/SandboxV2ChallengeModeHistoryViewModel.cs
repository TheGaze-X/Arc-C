using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200431D RID: 17181
	[Token(Token = "0x200431D")]
	public class SandboxV2ChallengeModeHistoryViewModel : IHotfixable
	{
		// Token: 0x0601A655 RID: 108117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A655")]
		[Address(RVA = "0x1340440", Offset = "0x133F040", VA = "0x181340440")]
		public void LoadData(PlayerSandboxV2.Challenge.History playerHistory)
		{
		}

		// Token: 0x0601A656 RID: 108118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A656")]
		[Address(RVA = "0x13404D0", Offset = "0x133F0D0", VA = "0x1813404D0")]
		public SandboxV2ChallengeModeHistoryViewModel()
		{
		}

		// Token: 0x04021841 RID: 137281
		[Token(Token = "0x4021841")]
		[FieldOffset(Offset = "0x10")]
		public int startDay;

		// Token: 0x04021842 RID: 137282
		[Token(Token = "0x4021842")]
		[FieldOffset(Offset = "0x14")]
		public int startLoadTimes;

		// Token: 0x04021843 RID: 137283
		[Token(Token = "0x4021843")]
		[FieldOffset(Offset = "0x18")]
		public long ts;

		// Token: 0x04021844 RID: 137284
		[Token(Token = "0x4021844")]
		[FieldOffset(Offset = "0x20")]
		public int challengeDay;

		// Token: 0x04021845 RID: 137285
		[Token(Token = "0x4021845")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04021846 RID: 137286
		[Token(Token = "0x4021846")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
