using System;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200541D RID: 21533
	[Token(Token = "0x200541D")]
	public class RoguelikeOnDisastersChangedToastArgs
	{
		// Token: 0x0601FAA0 RID: 129696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FAA0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeOnDisastersChangedToastArgs()
		{
		}

		// Token: 0x0402AB4D RID: 174925
		[Token(Token = "0x402AB4D")]
		[FieldOffset(Offset = "0x10")]
		public bool gain;

		// Token: 0x0402AB4E RID: 174926
		[Token(Token = "0x402AB4E")]
		[FieldOffset(Offset = "0x18")]
		public string disasterId;
	}
}
