using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D09 RID: 7433
	[Token(Token = "0x2001D09")]
	public struct ClueProducerInfo
	{
		// Token: 0x0600B776 RID: 46966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B776")]
		[Address(RVA = "0x32B0C50", Offset = "0x32AF850", VA = "0x1832B0C50")]
		public ClueProducerInfo(Sprite icon, int level, int evolve)
		{
		}

		// Token: 0x0400B598 RID: 46488
		[Token(Token = "0x400B598")]
		[FieldOffset(Offset = "0x0")]
		public Sprite icon;

		// Token: 0x0400B599 RID: 46489
		[Token(Token = "0x400B599")]
		[FieldOffset(Offset = "0x8")]
		public int level;

		// Token: 0x0400B59A RID: 46490
		[Token(Token = "0x400B59A")]
		[FieldOffset(Offset = "0xC")]
		public int evolve;
	}
}
