using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Cooperate
{
	// Token: 0x020026EA RID: 9962
	[Token(Token = "0x20026EA")]
	[Serializable]
	public class CooperateBonusData : IHotfixable
	{
		// Token: 0x06010318 RID: 66328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010318")]
		[Address(RVA = "0x7E4290", Offset = "0x7E2E90", VA = "0x1807E4290")]
		public CooperateBonusData()
		{
		}

		// Token: 0x0401219A RID: 74138
		[Token(Token = "0x401219A")]
		[FieldOffset(Offset = "0x10")]
		public string key;

		// Token: 0x0401219B RID: 74139
		[Token(Token = "0x401219B")]
		[FieldOffset(Offset = "0x18")]
		public bool fail;

		// Token: 0x0401219C RID: 74140
		[Token(Token = "0x401219C")]
		[FieldOffset(Offset = "0x1C")]
		public int weight;

		// Token: 0x0401219D RID: 74141
		[Token(Token = "0x401219D")]
		[FieldOffset(Offset = "0x20")]
		public string description;

		// Token: 0x0401219E RID: 74142
		[Token(Token = "0x401219E")]
		[FieldOffset(Offset = "0x28")]
		public Blackboard blackboard;

		// Token: 0x0401219F RID: 74143
		[Token(Token = "0x401219F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
