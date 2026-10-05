using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Vuplex.WebView
{
	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000028")]
	public interface IWithIme
	{
		// Token: 0x1400002D RID: 45
		// (add) Token: 0x06000155 RID: 341
		// (remove) Token: 0x06000156 RID: 342
		[Token(Token = "0x1400002D")]
		event EventHandler<EventArgs<Vector2Int>> ImeInputFieldPositionChanged;

		// Token: 0x06000157 RID: 343
		[Token(Token = "0x6000157")]
		void CancelImeComposition();

		// Token: 0x06000158 RID: 344
		[Token(Token = "0x6000158")]
		void FinishImeComposition(string text);

		// Token: 0x06000159 RID: 345
		[Token(Token = "0x6000159")]
		void SetImeComposition(string text);
	}
}
