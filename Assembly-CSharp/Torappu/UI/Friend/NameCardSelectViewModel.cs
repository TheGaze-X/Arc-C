using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Medal;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D5A RID: 19802
	[Token(Token = "0x2004D5A")]
	public class NameCardSelectViewModel
	{
		// Token: 0x0601DA19 RID: 121369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA19")]
		[Address(RVA = "0x1735C80", Offset = "0x1734880", VA = "0x181735C80")]
		public NameCardSelectViewModel()
		{
		}

		// Token: 0x0402722D RID: 160301
		[Token(Token = "0x402722D")]
		[FieldOffset(Offset = "0x10")]
		public NameCardMedalType currentType;

		// Token: 0x0402722E RID: 160302
		[Token(Token = "0x402722E")]
		[FieldOffset(Offset = "0x18")]
		public string currentParam;

		// Token: 0x0402722F RID: 160303
		[Token(Token = "0x402722F")]
		[FieldOffset(Offset = "0x20")]
		public NameCardMedalType selectType;

		// Token: 0x04027230 RID: 160304
		[Token(Token = "0x4027230")]
		[FieldOffset(Offset = "0x28")]
		public string selectParam;

		// Token: 0x04027231 RID: 160305
		[Token(Token = "0x4027231")]
		[FieldOffset(Offset = "0x30")]
		public List<MedalGroupViewModel> groupViewModel;
	}
}
