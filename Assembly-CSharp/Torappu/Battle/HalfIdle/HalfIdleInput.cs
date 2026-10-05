using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.HalfIdle
{
	// Token: 0x020026B7 RID: 9911
	[Token(Token = "0x20026B7")]
	public class HalfIdleInput : IHotfixable
	{
		// Token: 0x060102BC RID: 66236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102BC")]
		[Address(RVA = "0x7EC220", Offset = "0x7EAE20", VA = "0x1807EC220")]
		public HalfIdleInput()
		{
		}

		// Token: 0x04012069 RID: 73833
		[Token(Token = "0x4012069")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, List<string>> trapPoolDict;

		// Token: 0x0401206A RID: 73834
		[Token(Token = "0x401206A")]
		[FieldOffset(Offset = "0x18")]
		public List<string> plotIdList;

		// Token: 0x0401206B RID: 73835
		[Token(Token = "0x401206B")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public List<BattleCharacterData> exBattleTraps;

		// Token: 0x0401206C RID: 73836
		[Token(Token = "0x401206C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
