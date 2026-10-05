using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F84 RID: 8068
	[Token(Token = "0x2001F84")]
	public class ChatScript : IHotfixable
	{
		// Token: 0x0600C881 RID: 51329 RVA: 0x00048EA0 File Offset: 0x000470A0
		[Token(Token = "0x600C881")]
		[Address(RVA = "0x3498500", Offset = "0x3497100", VA = "0x183498500")]
		public bool LoadScript(string content, AVGParser parser)
		{
			return default(bool);
		}

		// Token: 0x0600C882 RID: 51330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C882")]
		[Address(RVA = "0x34985D0", Offset = "0x34971D0", VA = "0x1834985D0")]
		public ChatScript()
		{
		}

		// Token: 0x0400CF1E RID: 53022
		[Token(Token = "0x400CF1E")]
		[FieldOffset(Offset = "0x10")]
		public List<Command> commands;

		// Token: 0x0400CF1F RID: 53023
		[Token(Token = "0x400CF1F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadScript;

		// Token: 0x0400CF20 RID: 53024
		[Token(Token = "0x400CF20")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
