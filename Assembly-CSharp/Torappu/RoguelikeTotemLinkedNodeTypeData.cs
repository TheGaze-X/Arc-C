using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200119B RID: 4507
	[Token(Token = "0x200119B")]
	public class RoguelikeTotemLinkedNodeTypeData
	{
		// Token: 0x06006F89 RID: 28553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F89")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeTotemLinkedNodeTypeData()
		{
		}

		// Token: 0x0400608D RID: 24717
		[Token(Token = "0x400608D")]
		[FieldOffset(Offset = "0x10")]
		public List<RoguelikeEventType> effectiveNodeTypes;

		// Token: 0x0400608E RID: 24718
		[Token(Token = "0x400608E")]
		[FieldOffset(Offset = "0x18")]
		public List<RoguelikeTotemBlurNodeType> blurNodeTypes;
	}
}
