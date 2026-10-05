using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x020020A0 RID: 8352
	[Token(Token = "0x20020A0")]
	public struct BattleActivityMeta
	{
		// Token: 0x0600CD9B RID: 52635 RVA: 0x0004A268 File Offset: 0x00048468
		[Token(Token = "0x600CD9B")]
		[Address(RVA = "0x7F69A0", Offset = "0x7F55A0", VA = "0x1807F69A0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x0400D8FC RID: 55548
		[Token(Token = "0x400D8FC")]
		[FieldOffset(Offset = "0x0")]
		public string activityId;

		// Token: 0x0400D8FD RID: 55549
		[Token(Token = "0x400D8FD")]
		[FieldOffset(Offset = "0x8")]
		public bool overrideBattleFinish;

		// Token: 0x0400D8FE RID: 55550
		[Token(Token = "0x400D8FE")]
		[FieldOffset(Offset = "0x10")]
		public DataBundle meta;

		// Token: 0x0400D8FF RID: 55551
		[Token(Token = "0x400D8FF")]
		[FieldOffset(Offset = "0x18")]
		public bool backAsHomeAct;
	}
}
