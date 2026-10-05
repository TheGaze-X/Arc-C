using System;
using Il2CppDummyDll;

namespace YoStar.SDK.UIWidgets
{
	// Token: 0x020000E6 RID: 230
	[Token(Token = "0x20000E6")]
	public interface ITweenValue
	{
		// Token: 0x06000631 RID: 1585
		[Token(Token = "0x6000631")]
		void TweenValue(float floatPercentage);

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000632 RID: 1586
		[Token(Token = "0x17000067")]
		bool ignoreTimeScale { [Token(Token = "0x6000632")] get; }

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000633 RID: 1587
		[Token(Token = "0x17000068")]
		float duration { [Token(Token = "0x6000633")] get; }

		// Token: 0x06000634 RID: 1588
		[Token(Token = "0x6000634")]
		bool ValidTarget();

		// Token: 0x06000635 RID: 1589
		[Token(Token = "0x6000635")]
		void OnFinish();
	}
}
