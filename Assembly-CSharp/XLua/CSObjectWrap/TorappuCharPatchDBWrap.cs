using System;
using Il2CppDummyDll;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x02000370 RID: 880
	[Token(Token = "0x2000370")]
	public class TorappuCharPatchDBWrap
	{
		// Token: 0x06003E6A RID: 15978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E6A")]
		[Address(RVA = "0xAEF950", Offset = "0xAEE550", VA = "0x180AEF950")]
		public static void __Register(IntPtr L)
		{
		}

		// Token: 0x06003E6B RID: 15979 RVA: 0x0001E348 File Offset: 0x0001C548
		[Token(Token = "0x6003E6B")]
		[Address(RVA = "0xAEF810", Offset = "0xAEE410", VA = "0x180AEF810")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003E6C RID: 15980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E6C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TorappuCharPatchDBWrap()
		{
		}
	}
}
