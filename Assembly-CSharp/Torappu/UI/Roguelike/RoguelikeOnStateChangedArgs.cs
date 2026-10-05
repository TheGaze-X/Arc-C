using System;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200541B RID: 21531
	[Token(Token = "0x200541B")]
	public class RoguelikeOnStateChangedArgs
	{
		// Token: 0x0601FA9E RID: 129694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA9E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeOnStateChangedArgs()
		{
		}

		// Token: 0x0402AB48 RID: 174920
		[Token(Token = "0x402AB48")]
		[FieldOffset(Offset = "0x10")]
		public Type stateType;

		// Token: 0x0402AB49 RID: 174921
		[Token(Token = "0x402AB49")]
		[FieldOffset(Offset = "0x18")]
		public bool isBack;

		// Token: 0x0402AB4A RID: 174922
		[Token(Token = "0x402AB4A")]
		[FieldOffset(Offset = "0x20")]
		public StateEngine.OnStateChangeListener.Additions additions;
	}
}
