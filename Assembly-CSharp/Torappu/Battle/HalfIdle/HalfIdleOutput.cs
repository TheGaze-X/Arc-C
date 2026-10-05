using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.HalfIdle
{
	// Token: 0x020026B8 RID: 9912
	[Token(Token = "0x20026B8")]
	public class HalfIdleOutput : IHotfixable
	{
		// Token: 0x060102BD RID: 66237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102BD")]
		[Address(RVA = "0x7EC320", Offset = "0x7EAF20", VA = "0x1807EC320")]
		public HalfIdleOutput()
		{
		}

		// Token: 0x0401206D RID: 73837
		[Token(Token = "0x401206D")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<uint, int> characterLevelDict;

		// Token: 0x0401206E RID: 73838
		[Token(Token = "0x401206E")]
		[FieldOffset(Offset = "0x18")]
		public ListDict<string, int> resourceNumDict;

		// Token: 0x0401206F RID: 73839
		[Token(Token = "0x401206F")]
		[FieldOffset(Offset = "0x20")]
		public int bossState;

		// Token: 0x04012070 RID: 73840
		[Token(Token = "0x4012070")]
		[FieldOffset(Offset = "0x24")]
		public int battleProcess;

		// Token: 0x04012071 RID: 73841
		[Token(Token = "0x4012071")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
