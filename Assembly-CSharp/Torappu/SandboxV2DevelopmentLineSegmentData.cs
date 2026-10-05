using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012E6 RID: 4838
	[Token(Token = "0x20012E6")]
	public class SandboxV2DevelopmentLineSegmentData
	{
		// Token: 0x06007261 RID: 29281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007261")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2DevelopmentLineSegmentData()
		{
		}

		// Token: 0x04006ADA RID: 27354
		[Token(Token = "0x4006ADA")]
		[FieldOffset(Offset = "0x10")]
		public string fromNodeId;

		// Token: 0x04006ADB RID: 27355
		[Token(Token = "0x4006ADB")]
		[FieldOffset(Offset = "0x18")]
		public List<string> passingNodeIds;

		// Token: 0x04006ADC RID: 27356
		[Token(Token = "0x4006ADC")]
		[FieldOffset(Offset = "0x20")]
		public int fromAxisPosX;

		// Token: 0x04006ADD RID: 27357
		[Token(Token = "0x4006ADD")]
		[FieldOffset(Offset = "0x24")]
		public int fromAxisPosY;

		// Token: 0x04006ADE RID: 27358
		[Token(Token = "0x4006ADE")]
		[FieldOffset(Offset = "0x28")]
		public int toAxisPosX;

		// Token: 0x04006ADF RID: 27359
		[Token(Token = "0x4006ADF")]
		[FieldOffset(Offset = "0x2C")]
		public int toAxisPosY;

		// Token: 0x04006AE0 RID: 27360
		[Token(Token = "0x4006AE0")]
		[FieldOffset(Offset = "0x30")]
		public SandboxV2DevelopmentLineStyle lineStyle;

		// Token: 0x04006AE1 RID: 27361
		[Token(Token = "0x4006AE1")]
		[FieldOffset(Offset = "0x34")]
		public int unlockBasementLevel;
	}
}
