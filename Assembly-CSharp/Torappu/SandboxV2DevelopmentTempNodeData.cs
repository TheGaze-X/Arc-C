using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012E5 RID: 4837
	[Token(Token = "0x20012E5")]
	public class SandboxV2DevelopmentTempNodeData
	{
		// Token: 0x06007260 RID: 29280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007260")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2DevelopmentTempNodeData()
		{
		}

		// Token: 0x04006AD6 RID: 27350
		[Token(Token = "0x4006AD6")]
		[FieldOffset(Offset = "0x10")]
		public string tempId;

		// Token: 0x04006AD7 RID: 27351
		[Token(Token = "0x4006AD7")]
		[FieldOffset(Offset = "0x18")]
		public int posX;

		// Token: 0x04006AD8 RID: 27352
		[Token(Token = "0x4006AD8")]
		[FieldOffset(Offset = "0x1C")]
		public int posY;

		// Token: 0x04006AD9 RID: 27353
		[Token(Token = "0x4006AD9")]
		[FieldOffset(Offset = "0x20")]
		public List<string> passingNodeIds;
	}
}
