using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020004A1 RID: 1185
	[Token(Token = "0x20004A1")]
	[Serializable]
	public class SandboxV2DialogChoiceOperation
	{
		// Token: 0x06004CE8 RID: 19688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CE8")]
		[Address(RVA = "0x1793110", Offset = "0x1791D10", VA = "0x181793110")]
		public SandboxV2DialogChoiceOperation(SandboxV2BattleAvgChoiceType _type, string _key, object _value)
		{
		}

		// Token: 0x06004CE9 RID: 19689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CE9")]
		[Address(RVA = "0x17931F0", Offset = "0x1791DF0", VA = "0x1817931F0")]
		public SandboxV2DialogChoiceOperation()
		{
		}

		// Token: 0x040010DE RID: 4318
		[Token(Token = "0x40010DE")]
		[FieldOffset(Offset = "0x10")]
		public SandboxV2BattleAvgChoiceType type;

		// Token: 0x040010DF RID: 4319
		[Token(Token = "0x40010DF")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, object> valueDict;
	}
}
