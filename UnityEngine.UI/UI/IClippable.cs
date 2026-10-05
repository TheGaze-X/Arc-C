using System;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	public interface IClippable
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000051 RID: 81
		[Token(Token = "0x17000013")]
		GameObject gameObject { [Token(Token = "0x6000051")] get; }

		// Token: 0x06000052 RID: 82
		[Token(Token = "0x6000052")]
		void RecalculateClipping();

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000053 RID: 83
		[Token(Token = "0x17000014")]
		RectTransform rectTransform { [Token(Token = "0x6000053")] get; }

		// Token: 0x06000054 RID: 84
		[Token(Token = "0x6000054")]
		void Cull(Rect clipRect, bool validRect);

		// Token: 0x06000055 RID: 85
		[Token(Token = "0x6000055")]
		void SetClipRect(Rect value, bool validRect);

		// Token: 0x06000056 RID: 86
		[Token(Token = "0x6000056")]
		void SetClipSoftness(Vector2 clipSoftness);
	}
}
