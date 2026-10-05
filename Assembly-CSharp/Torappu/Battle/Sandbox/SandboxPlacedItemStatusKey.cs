using System;
using Il2CppDummyDll;

namespace Torappu.Battle.Sandbox
{
	// Token: 0x02002A6C RID: 10860
	[Token(Token = "0x2002A6C")]
	public struct SandboxPlacedItemStatusKey : IHotfixable
	{
		// Token: 0x04014682 RID: 83586
		[Token(Token = "0x4014682")]
		[FieldOffset(Offset = "0x0")]
		public string itemId;

		// Token: 0x04014683 RID: 83587
		[Token(Token = "0x4014683")]
		[FieldOffset(Offset = "0x8")]
		public GridPosition position;
	}
}
