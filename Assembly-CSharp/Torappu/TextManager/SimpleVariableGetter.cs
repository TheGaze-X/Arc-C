using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.AVG;
using XLua;

namespace Torappu.TextManager
{
	// Token: 0x02001E1A RID: 7706
	[Token(Token = "0x2001E1A")]
	public class SimpleVariableGetter : IHotfixable
	{
		// Token: 0x0600BE79 RID: 48761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE79")]
		[Address(RVA = "0x33CF940", Offset = "0x33CE540", VA = "0x1833CF940")]
		public SimpleVariableGetter([Optional] AVGVariableConfig config)
		{
		}

		// Token: 0x0600BE7A RID: 48762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BE7A")]
		[Address(RVA = "0x33CF7F0", Offset = "0x33CE3F0", VA = "0x1833CF7F0")]
		public string GetVariableValue(string varName)
		{
			return null;
		}

		// Token: 0x0400BF52 RID: 48978
		[Token(Token = "0x400BF52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AVGVariableConfig m_variableConfig;

		// Token: 0x0400BF53 RID: 48979
		[Token(Token = "0x400BF53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400BF54 RID: 48980
		[Token(Token = "0x400BF54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetVariableValue;
	}
}
