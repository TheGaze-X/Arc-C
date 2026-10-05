using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Cooperate
{
	// Token: 0x020026E5 RID: 9957
	[Token(Token = "0x20026E5")]
	[Serializable]
	public class CooperateTeamPlayer : IHotfixable
	{
		// Token: 0x06010311 RID: 66321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010311")]
		[Address(RVA = "0x7E6150", Offset = "0x7E4D50", VA = "0x1807E6150")]
		public CooperateTeamPlayer()
		{
		}

		// Token: 0x04012184 RID: 74116
		[Token(Token = "0x4012184")]
		[FieldOffset(Offset = "0x10")]
		public string forward;

		// Token: 0x04012185 RID: 74117
		[Token(Token = "0x4012185")]
		[FieldOffset(Offset = "0x18")]
		public string goalkeeper;

		// Token: 0x04012186 RID: 74118
		[Token(Token = "0x4012186")]
		[FieldOffset(Offset = "0x20")]
		public string muscleman;

		// Token: 0x04012187 RID: 74119
		[Token(Token = "0x4012187")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
