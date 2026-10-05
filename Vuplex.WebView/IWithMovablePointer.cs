using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Vuplex.WebView
{
	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	public interface IWithMovablePointer
	{
		// Token: 0x0600015C RID: 348
		[Token(Token = "0x600015C")]
		void MovePointer(Vector2 normalizedPoint, bool pointerLeave = false);
	}
}
