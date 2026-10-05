using System;
using Il2CppDummyDll;
using XLua.LuaDLL;

namespace XLua.CSObjectWrap
{
	// Token: 0x020003AE RID: 942
	[Token(Token = "0x20003AE")]
	public class TorappuSkillDBWrap
	{
		// Token: 0x06004155 RID: 16725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004155")]
		[Address(RVA = "0xD0A450", Offset = "0xD09050", VA = "0x180D0A450")]
		public static void __Register(IntPtr L)
		{
		}

		// Token: 0x06004156 RID: 16726 RVA: 0x00021AE0 File Offset: 0x0001FCE0
		[Token(Token = "0x6004156")]
		[Address(RVA = "0xD0A310", Offset = "0xD08F10", VA = "0x180D0A310")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int __CreateInstance(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06004157 RID: 16727 RVA: 0x00021AF8 File Offset: 0x0001FCF8
		[Token(Token = "0x6004157")]
		[Address(RVA = "0xD0A750", Offset = "0xD09350", VA = "0x180D0A750")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_GetSkillOrDefault(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06004158 RID: 16728 RVA: 0x00021B10 File Offset: 0x0001FD10
		[Token(Token = "0x6004158")]
		[Address(RVA = "0xD0ADF0", Offset = "0xD099F0", VA = "0x180D0ADF0")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_TryGetSkill(IntPtr L)
		{
			return 0;
		}

		// Token: 0x06004159 RID: 16729 RVA: 0x00021B28 File Offset: 0x0001FD28
		[Token(Token = "0x6004159")]
		[Address(RVA = "0xD0A980", Offset = "0xD09580", VA = "0x180D0A980")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_TryGetSkillBundle(IntPtr L)
		{
			return 0;
		}

		// Token: 0x0600415A RID: 16730 RVA: 0x00021B40 File Offset: 0x0001FD40
		[Token(Token = "0x600415A")]
		[Address(RVA = "0xD0ABB0", Offset = "0xD097B0", VA = "0x180D0ABB0")]
		[MonoPInvokeCallback(typeof(lua_CSFunction))]
		private static int _m_TryGetSkillOverrideRange(IntPtr L)
		{
			return 0;
		}

		// Token: 0x0600415B RID: 16731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600415B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TorappuSkillDBWrap()
		{
		}
	}
}
