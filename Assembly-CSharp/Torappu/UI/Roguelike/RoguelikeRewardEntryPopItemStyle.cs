using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053D8 RID: 21464
	[Token(Token = "0x20053D8")]
	[Serializable]
	public struct RoguelikeRewardEntryPopItemStyle
	{
		// Token: 0x0402A876 RID: 174198
		[Token(Token = "0x402A876")]
		[FieldOffset(Offset = "0x0")]
		public ROGUELIKE_REWARDS_LEVEL_UP_POP_TYPE type;

		// Token: 0x0402A877 RID: 174199
		[Token(Token = "0x402A877")]
		[FieldOffset(Offset = "0x4")]
		public Color popTxtCol;

		// Token: 0x0402A878 RID: 174200
		[Token(Token = "0x402A878")]
		[FieldOffset(Offset = "0x14")]
		public Color popBgCol;

		// Token: 0x0402A879 RID: 174201
		[Token(Token = "0x402A879")]
		[FieldOffset(Offset = "0x28")]
		public Sprite popIcon;

		// Token: 0x0402A87A RID: 174202
		[Token(Token = "0x402A87A")]
		[FieldOffset(Offset = "0x0")]
		[HideInInspector]
		public static readonly RoguelikeRewardEntryPopItemStyle DEFAULT;
	}
}
