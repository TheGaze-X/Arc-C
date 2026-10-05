using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Cooperate
{
	// Token: 0x020026E8 RID: 9960
	[Token(Token = "0x20026E8")]
	[Serializable]
	public class CooperateAheadGoalData : IHotfixable
	{
		// Token: 0x06010316 RID: 66326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010316")]
		[Address(RVA = "0x7E4230", Offset = "0x7E2E30", VA = "0x1807E4230")]
		public CooperateAheadGoalData()
		{
		}

		// Token: 0x04012190 RID: 74128
		[Token(Token = "0x4012190")]
		[FieldOffset(Offset = "0x10")]
		public int aheadCnt;

		// Token: 0x04012191 RID: 74129
		[Token(Token = "0x4012191")]
		[FieldOffset(Offset = "0x14")]
		public int level;

		// Token: 0x04012192 RID: 74130
		[Token(Token = "0x4012192")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
