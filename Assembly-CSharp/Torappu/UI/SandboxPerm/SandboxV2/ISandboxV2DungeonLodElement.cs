using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004162 RID: 16738
	[Token(Token = "0x2004162")]
	public interface ISandboxV2DungeonLodElement
	{
		// Token: 0x06019D69 RID: 105833
		[Token(Token = "0x6019D69")]
		void UpdateLod(float normalizedLod, SandboxV2DungeonLodRank lodRank, bool fastMode = false);
	}
}
