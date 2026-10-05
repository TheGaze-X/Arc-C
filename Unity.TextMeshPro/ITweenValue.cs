using System;
using Il2CppDummyDll;

namespace TMPro
{
	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	internal interface ITweenValue
	{
		// Token: 0x06000146 RID: 326
		[Token(Token = "0x6000146")]
		void TweenValue(float floatPercentage);

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000147 RID: 327
		[Token(Token = "0x1700002C")]
		bool ignoreTimeScale { [Token(Token = "0x6000147")] get; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000148 RID: 328
		[Token(Token = "0x1700002D")]
		float duration { [Token(Token = "0x6000148")] get; }

		// Token: 0x06000149 RID: 329
		[Token(Token = "0x6000149")]
		bool ValidTarget();
	}
}
