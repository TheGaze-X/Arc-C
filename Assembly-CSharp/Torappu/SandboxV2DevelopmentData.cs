using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012BD RID: 4797
	[Token(Token = "0x20012BD")]
	public class SandboxV2DevelopmentData
	{
		// Token: 0x06007238 RID: 29240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007238")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2DevelopmentData()
		{
		}

		// Token: 0x040069FB RID: 27131
		[Token(Token = "0x40069FB")]
		[FieldOffset(Offset = "0x10")]
		public string techId;

		// Token: 0x040069FC RID: 27132
		[Token(Token = "0x40069FC")]
		[FieldOffset(Offset = "0x18")]
		public SandboxV2DevelopmentType techType;

		// Token: 0x040069FD RID: 27133
		[Token(Token = "0x40069FD")]
		[FieldOffset(Offset = "0x1C")]
		public int positionX;

		// Token: 0x040069FE RID: 27134
		[Token(Token = "0x40069FE")]
		[FieldOffset(Offset = "0x20")]
		public int positionY;

		// Token: 0x040069FF RID: 27135
		[Token(Token = "0x40069FF")]
		[FieldOffset(Offset = "0x28")]
		public string frontNodeId;

		// Token: 0x04006A00 RID: 27136
		[Token(Token = "0x4006A00")]
		[FieldOffset(Offset = "0x30")]
		public List<string> nextNodeIds;

		// Token: 0x04006A01 RID: 27137
		[Token(Token = "0x4006A01")]
		[FieldOffset(Offset = "0x38")]
		public int limitBaseLevel;

		// Token: 0x04006A02 RID: 27138
		[Token(Token = "0x4006A02")]
		[FieldOffset(Offset = "0x3C")]
		public int tokenCost;

		// Token: 0x04006A03 RID: 27139
		[Token(Token = "0x4006A03")]
		[FieldOffset(Offset = "0x40")]
		public string techName;

		// Token: 0x04006A04 RID: 27140
		[Token(Token = "0x4006A04")]
		[FieldOffset(Offset = "0x48")]
		public string techIconId;

		// Token: 0x04006A05 RID: 27141
		[Token(Token = "0x4006A05")]
		[FieldOffset(Offset = "0x50")]
		public string nodeTitle;

		// Token: 0x04006A06 RID: 27142
		[Token(Token = "0x4006A06")]
		[FieldOffset(Offset = "0x58")]
		public string rawDesc;

		// Token: 0x04006A07 RID: 27143
		[Token(Token = "0x4006A07")]
		[FieldOffset(Offset = "0x60")]
		public bool canBuffReserch;

		// Token: 0x020012BE RID: 4798
		[Token(Token = "0x20012BE")]
		public class SandboxV2DevelopmentUnlockCondition
		{
			// Token: 0x06007239 RID: 29241 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007239")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SandboxV2DevelopmentUnlockCondition()
			{
			}

			// Token: 0x04006A08 RID: 27144
			[Token(Token = "0x4006A08")]
			[FieldOffset(Offset = "0x10")]
			public string condType;

			// Token: 0x04006A09 RID: 27145
			[Token(Token = "0x4006A09")]
			[FieldOffset(Offset = "0x18")]
			public int condValue;
		}
	}
}
