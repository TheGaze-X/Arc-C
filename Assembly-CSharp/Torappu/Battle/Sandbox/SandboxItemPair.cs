using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Sandbox
{
	// Token: 0x02002A79 RID: 10873
	[Token(Token = "0x2002A79")]
	[Serializable]
	public class SandboxItemPair : IHotfixable
	{
		// Token: 0x06012121 RID: 74017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012121")]
		[Address(RVA = "0xA2D130", Offset = "0xA2BD30", VA = "0x180A2D130")]
		public SandboxItemPair()
		{
		}

		// Token: 0x040146D1 RID: 83665
		[Token(Token = "0x40146D1")]
		[FieldOffset(Offset = "0x10")]
		public string itemId;

		// Token: 0x040146D2 RID: 83666
		[Token(Token = "0x40146D2")]
		[FieldOffset(Offset = "0x18")]
		public int cnt;

		// Token: 0x040146D3 RID: 83667
		[Token(Token = "0x40146D3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
