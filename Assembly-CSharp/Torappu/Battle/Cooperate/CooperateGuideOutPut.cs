using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Cooperate
{
	// Token: 0x020026E4 RID: 9956
	[Token(Token = "0x20026E4")]
	public class CooperateGuideOutPut : IHotfixable
	{
		// Token: 0x06010310 RID: 66320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010310")]
		[Address(RVA = "0x7E53A0", Offset = "0x7E3FA0", VA = "0x1807E53A0")]
		public CooperateGuideOutPut()
		{
		}

		// Token: 0x0401217F RID: 74111
		[Token(Token = "0x401217F")]
		[FieldOffset(Offset = "0x10")]
		public NormalGuideStatus normal;

		// Token: 0x04012180 RID: 74112
		[Token(Token = "0x4012180")]
		[FieldOffset(Offset = "0x18")]
		public FootballGuideStatus football;

		// Token: 0x04012181 RID: 74113
		[Token(Token = "0x4012181")]
		[FieldOffset(Offset = "0x20")]
		public DefenceGuideStatus defence;

		// Token: 0x04012182 RID: 74114
		[Token(Token = "0x4012182")]
		[FieldOffset(Offset = "0x28")]
		public RaftGuideStatus raft;

		// Token: 0x04012183 RID: 74115
		[Token(Token = "0x4012183")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
