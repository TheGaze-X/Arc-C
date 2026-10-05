using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	public class HotfixTestStub : IHotfixable
	{
		// Token: 0x06000113 RID: 275 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x54E3F60", Offset = "0x54E2B60", VA = "0x1854E3F60")]
		public static string GenerateDevInfo(string devVersion, string dataVer)
		{
			return null;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x54E3FE0", Offset = "0x54E2BE0", VA = "0x1854E3FE0")]
		public HotfixTestStub()
		{
		}

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate3 __Hotfix0_GenerateDevInfo;

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;
	}
}
