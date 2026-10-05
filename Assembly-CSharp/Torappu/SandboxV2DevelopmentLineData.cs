using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012E4 RID: 4836
	[Token(Token = "0x20012E4")]
	public class SandboxV2DevelopmentLineData
	{
		// Token: 0x0600725F RID: 29279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600725F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2DevelopmentLineData()
		{
		}

		// Token: 0x04006ACE RID: 27342
		[Token(Token = "0x4006ACE")]
		[FieldOffset(Offset = "0x10")]
		public string fromNodeId;

		// Token: 0x04006ACF RID: 27343
		[Token(Token = "0x4006ACF")]
		[FieldOffset(Offset = "0x18")]
		public List<string> toNodeIds;

		// Token: 0x04006AD0 RID: 27344
		[Token(Token = "0x4006AD0")]
		[FieldOffset(Offset = "0x20")]
		public int fromNodePosX;

		// Token: 0x04006AD1 RID: 27345
		[Token(Token = "0x4006AD1")]
		[FieldOffset(Offset = "0x24")]
		public int fromNodePosY;

		// Token: 0x04006AD2 RID: 27346
		[Token(Token = "0x4006AD2")]
		[FieldOffset(Offset = "0x28")]
		public List<int> toNodePosXList;

		// Token: 0x04006AD3 RID: 27347
		[Token(Token = "0x4006AD3")]
		[FieldOffset(Offset = "0x30")]
		public List<int> toNodePosYList;

		// Token: 0x04006AD4 RID: 27348
		[Token(Token = "0x4006AD4")]
		[FieldOffset(Offset = "0x38")]
		public SandboxV2DevelopmentLineStyle lineStyle;

		// Token: 0x04006AD5 RID: 27349
		[Token(Token = "0x4006AD5")]
		[FieldOffset(Offset = "0x3C")]
		public int unlockBasementLevel;
	}
}
