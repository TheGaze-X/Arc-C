using System;
using Il2CppDummyDll;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x02000384 RID: 900
	[Token(Token = "0x2000384")]
	public class TorappuFavorDBWrap
	{
		// Token: 0x06003FB9 RID: 16313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FB9")]
		[Address(RVA = "0xC04C90", Offset = "0xC03890", VA = "0x180C04C90")]
		public static void __Register(IntPtr L)
		{
		}

		// Token: 0x06003FBA RID: 16314 RVA: 0x0001FED8 File Offset: 0x0001E0D8
		[Token(Token = "0x6003FBA")]
		[Address(RVA = "0xC04B50", Offset = "0xC03750", VA = "0x180C04B50")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003FBB RID: 16315 RVA: 0x0001FEF0 File Offset: 0x0001E0F0
		[Token(Token = "0x6003FBB")]
		[Address(RVA = "0xC05350", Offset = "0xC03F50", VA = "0x180C05350")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetFavorData(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003FBC RID: 16316 RVA: 0x0001FF08 File Offset: 0x0001E108
		[Token(Token = "0x6003FBC")]
		[Address(RVA = "0xC05140", Offset = "0xC03D40", VA = "0x180C05140")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetFavorBattlePhase(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003FBD RID: 16317 RVA: 0x0001FF20 File Offset: 0x0001E120
		[Token(Token = "0x6003FBD")]
		[Address(RVA = "0xC04F30", Offset = "0xC03B30", VA = "0x180C04F30")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_CalculateFavorPointByBattlePhaseRoughly(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06003FBE RID: 16318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FBE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TorappuFavorDBWrap()
		{
		}
	}
}
