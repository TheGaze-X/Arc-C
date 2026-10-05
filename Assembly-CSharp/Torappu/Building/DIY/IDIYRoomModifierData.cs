using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.DIY
{
	// Token: 0x02001883 RID: 6275
	[Token(Token = "0x2001883")]
	public interface IDIYRoomModifierData : IDIYItem, IHotfixable
	{
		// Token: 0x170011D2 RID: 4562
		// (get) Token: 0x06009ECA RID: 40650
		[Token(Token = "0x170011D2")]
		DIYRoomPart part { [Token(Token = "0x6009ECA")] get; }

		// Token: 0x170011D3 RID: 4563
		// (get) Token: 0x06009ECB RID: 40651
		[Token(Token = "0x170011D3")]
		Mesh mesh { [Token(Token = "0x6009ECB")] get; }

		// Token: 0x170011D4 RID: 4564
		// (get) Token: 0x06009ECC RID: 40652
		[Token(Token = "0x170011D4")]
		Material material { [Token(Token = "0x6009ECC")] get; }
	}
}
