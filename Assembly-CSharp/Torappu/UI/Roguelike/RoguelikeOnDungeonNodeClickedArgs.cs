using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200541A RID: 21530
	[Token(Token = "0x200541A")]
	public class RoguelikeOnDungeonNodeClickedArgs
	{
		// Token: 0x0601FA9D RID: 129693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA9D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeOnDungeonNodeClickedArgs()
		{
		}

		// Token: 0x0402AB47 RID: 174919
		[Token(Token = "0x402AB47")]
		[FieldOffset(Offset = "0x10")]
		public Bounds focusNodeWorldBounds;
	}
}
