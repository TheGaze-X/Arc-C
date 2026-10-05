using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200415C RID: 16732
	[Token(Token = "0x200415C")]
	public interface ISandboxV2DungeonCullElement
	{
		// Token: 0x06019D55 RID: 105813
		[Token(Token = "0x6019D55")]
		Vector3[] GetWorldCullBounds();

		// Token: 0x06019D56 RID: 105814
		[Token(Token = "0x6019D56")]
		CanvasGroup GetAlphaHandler();
	}
}
