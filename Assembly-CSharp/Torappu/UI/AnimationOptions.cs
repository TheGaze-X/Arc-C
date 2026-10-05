using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x020036C8 RID: 14024
	[Token(Token = "0x20036C8")]
	public struct AnimationOptions
	{
		// Token: 0x0401ACD1 RID: 109777
		[Token(Token = "0x401ACD1")]
		[FieldOffset(Offset = "0x0")]
		public static AnimationOptions DEFAULT;

		// Token: 0x0401ACD2 RID: 109778
		[Token(Token = "0x401ACD2")]
		[FieldOffset(Offset = "0x0")]
		public bool isFillAfter;

		// Token: 0x0401ACD3 RID: 109779
		[Token(Token = "0x401ACD3")]
		[FieldOffset(Offset = "0x8")]
		public Action<string> onAnimEnd;

		// Token: 0x0401ACD4 RID: 109780
		[Token(Token = "0x401ACD4")]
		[FieldOffset(Offset = "0x10")]
		public bool isInverse;
	}
}
