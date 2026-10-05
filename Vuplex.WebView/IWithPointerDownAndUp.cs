using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Vuplex.WebView
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	public interface IWithPointerDownAndUp
	{
		// Token: 0x0600016B RID: 363
		[Token(Token = "0x600016B")]
		void PointerDown(Vector2 normalizedPoint);

		// Token: 0x0600016C RID: 364
		[Token(Token = "0x600016C")]
		void PointerDown(Vector2 normalizedPoint, PointerOptions options);

		// Token: 0x0600016D RID: 365
		[Token(Token = "0x600016D")]
		void PointerUp(Vector2 normalizedPoint);

		// Token: 0x0600016E RID: 366
		[Token(Token = "0x600016E")]
		void PointerUp(Vector2 normalizedPoint, PointerOptions options);
	}
}
