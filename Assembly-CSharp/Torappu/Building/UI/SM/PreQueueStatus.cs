using System;
using Il2CppDummyDll;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001C9F RID: 7327
	[Token(Token = "0x2001C9F")]
	[Flags]
	public enum PreQueueStatus
	{
		// Token: 0x0400B251 RID: 45649
		[Token(Token = "0x400B251")]
		Avail = 0,
		// Token: 0x0400B252 RID: 45650
		[Token(Token = "0x400B252")]
		EmptyQueue = 1,
		// Token: 0x0400B253 RID: 45651
		[Token(Token = "0x400B253")]
		HasTired = 2,
		// Token: 0x0400B254 RID: 45652
		[Token(Token = "0x400B254")]
		HasWorkInOtherRoom = 4,
		// Token: 0x0400B255 RID: 45653
		[Token(Token = "0x400B255")]
		IsTraining = 8,
		// Token: 0x0400B256 RID: 45654
		[Token(Token = "0x400B256")]
		SameAsCurRoom = 16
	}
}
