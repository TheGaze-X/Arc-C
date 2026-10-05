using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200125C RID: 4700
	[Token(Token = "0x200125C")]
	public class RoguelikeCommonDevelopment
	{
		// Token: 0x060071D1 RID: 29137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071D1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeCommonDevelopment()
		{
		}

		// Token: 0x040067A6 RID: 26534
		[Token(Token = "0x40067A6")]
		[FieldOffset(Offset = "0x10")]
		public string buffId;

		// Token: 0x040067A7 RID: 26535
		[Token(Token = "0x40067A7")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeCommonDevelopmentNodeType nodeType;

		// Token: 0x040067A8 RID: 26536
		[Token(Token = "0x40067A8")]
		[FieldOffset(Offset = "0x20")]
		public List<string> frontNodeId;

		// Token: 0x040067A9 RID: 26537
		[Token(Token = "0x40067A9")]
		[FieldOffset(Offset = "0x28")]
		public List<string> nextNodeId;

		// Token: 0x040067AA RID: 26538
		[Token(Token = "0x40067AA")]
		[FieldOffset(Offset = "0x30")]
		public int positionRow;

		// Token: 0x040067AB RID: 26539
		[Token(Token = "0x40067AB")]
		[FieldOffset(Offset = "0x34")]
		public int positionOrder;

		// Token: 0x040067AC RID: 26540
		[Token(Token = "0x40067AC")]
		[FieldOffset(Offset = "0x38")]
		public int tokenCost;

		// Token: 0x040067AD RID: 26541
		[Token(Token = "0x40067AD")]
		[FieldOffset(Offset = "0x40")]
		public string buffName;

		// Token: 0x040067AE RID: 26542
		[Token(Token = "0x40067AE")]
		[FieldOffset(Offset = "0x48")]
		public string activeIconId;

		// Token: 0x040067AF RID: 26543
		[Token(Token = "0x40067AF")]
		[FieldOffset(Offset = "0x50")]
		public string inactiveIconId;

		// Token: 0x040067B0 RID: 26544
		[Token(Token = "0x40067B0")]
		[FieldOffset(Offset = "0x58")]
		public string bottomIconId;

		// Token: 0x040067B1 RID: 26545
		[Token(Token = "0x40067B1")]
		[FieldOffset(Offset = "0x60")]
		public RoguelikeCommonDevelopmentEffectType effectType;

		// Token: 0x040067B2 RID: 26546
		[Token(Token = "0x40067B2")]
		[FieldOffset(Offset = "0x68")]
		public List<string> rawDesc;

		// Token: 0x040067B3 RID: 26547
		[Token(Token = "0x40067B3")]
		[FieldOffset(Offset = "0x70")]
		public List<RoguelikeTopicDisplayItem> buffDisplayInfo;

		// Token: 0x040067B4 RID: 26548
		[Token(Token = "0x40067B4")]
		[FieldOffset(Offset = "0x78")]
		public string groupId;

		// Token: 0x040067B5 RID: 26549
		[Token(Token = "0x40067B5")]
		[FieldOffset(Offset = "0x80")]
		public string enrollId;
	}
}
