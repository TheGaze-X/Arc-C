using System;
using Il2CppDummyDll;

namespace UnityEngine.UI.CoroutineTween
{
	// Token: 0x0200009B RID: 155
	[Token(Token = "0x200009B")]
	internal interface ITweenValue
	{
		// Token: 0x060005D5 RID: 1493
		[Token(Token = "0x60005D5")]
		void TweenValue(float floatPercentage);

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060005D6 RID: 1494
		[Token(Token = "0x1700017B")]
		bool ignoreTimeScale { [Token(Token = "0x60005D6")] get; }

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060005D7 RID: 1495
		[Token(Token = "0x1700017C")]
		float duration { [Token(Token = "0x60005D7")] get; }

		// Token: 0x060005D8 RID: 1496
		[Token(Token = "0x60005D8")]
		bool ValidTarget();
	}
}
