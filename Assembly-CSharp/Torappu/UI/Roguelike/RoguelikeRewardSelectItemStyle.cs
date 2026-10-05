using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053FA RID: 21498
	[Token(Token = "0x20053FA")]
	[Serializable]
	public struct RoguelikeRewardSelectItemStyle
	{
		// Token: 0x0402A9E1 RID: 174561
		[Token(Token = "0x402A9E1")]
		[FieldOffset(Offset = "0x0")]
		public RoguelikeGameItemType itemType;

		// Token: 0x0402A9E2 RID: 174562
		[Token(Token = "0x402A9E2")]
		[FieldOffset(Offset = "0x4")]
		public RoguelikeRewardShowType showType;

		// Token: 0x0402A9E3 RID: 174563
		[Token(Token = "0x402A9E3")]
		[FieldOffset(Offset = "0x8")]
		public Color bgColor;

		// Token: 0x0402A9E4 RID: 174564
		[Token(Token = "0x402A9E4")]
		[FieldOffset(Offset = "0x18")]
		public Color btnColor;

		// Token: 0x0402A9E5 RID: 174565
		[Token(Token = "0x402A9E5")]
		[FieldOffset(Offset = "0x0")]
		[HideInInspector]
		public static readonly RoguelikeRewardSelectItemStyle DEFAULT;
	}
}
