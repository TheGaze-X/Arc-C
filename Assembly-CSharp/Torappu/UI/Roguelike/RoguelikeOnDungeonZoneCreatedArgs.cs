using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005419 RID: 21529
	[Token(Token = "0x2005419")]
	public class RoguelikeOnDungeonZoneCreatedArgs
	{
		// Token: 0x0601FA9C RID: 129692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA9C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeOnDungeonZoneCreatedArgs()
		{
		}

		// Token: 0x0402AB45 RID: 174917
		[Token(Token = "0x402AB45")]
		[FieldOffset(Offset = "0x10")]
		public Bounds containerWorldBounds;

		// Token: 0x0402AB46 RID: 174918
		[Token(Token = "0x402AB46")]
		[FieldOffset(Offset = "0x28")]
		public Bounds focusNodeWorldBounds;
	}
}
