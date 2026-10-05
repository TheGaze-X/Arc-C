using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020002BA RID: 698
	[Token(Token = "0x20002BA")]
	internal class VectorImageRenderInfo : LinkedPoolItem<VectorImageRenderInfo>
	{
		// Token: 0x06001307 RID: 4871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001307")]
		[Address(RVA = "0x5A67440", Offset = "0x5A66040", VA = "0x185A67440")]
		public void Reset()
		{
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001308")]
		[Address(RVA = "0x5A67470", Offset = "0x5A66070", VA = "0x185A67470")]
		public VectorImageRenderInfo()
		{
		}

		// Token: 0x04000A90 RID: 2704
		[Token(Token = "0x4000A90")]
		[FieldOffset(Offset = "0x18")]
		public int useCount;

		// Token: 0x04000A91 RID: 2705
		[Token(Token = "0x4000A91")]
		[FieldOffset(Offset = "0x20")]
		public GradientRemap firstGradientRemap;

		// Token: 0x04000A92 RID: 2706
		[Token(Token = "0x4000A92")]
		[FieldOffset(Offset = "0x28")]
		public Alloc gradientSettingsAlloc;
	}
}
