using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Building
{
	// Token: 0x020017EB RID: 6123
	[Token(Token = "0x20017EB")]
	[Serializable]
	public class FurnitureLodPreprocessSetting
	{
		// Token: 0x06009AB7 RID: 39607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AB7")]
		[Address(RVA = "0x315FE00", Offset = "0x315EA00", VA = "0x18315FE00")]
		public FurnitureLodPreprocessSetting()
		{
		}

		// Token: 0x04009109 RID: 37129
		[Token(Token = "0x4009109")]
		[FieldOffset(Offset = "0x10")]
		public int minVertexCount;

		// Token: 0x0400910A RID: 37130
		[Token(Token = "0x400910A")]
		[FieldOffset(Offset = "0x14")]
		public int minVertexCountUseAlphaBlend;

		// Token: 0x0400910B RID: 37131
		[Token(Token = "0x400910B")]
		[FieldOffset(Offset = "0x18")]
		public int sizeNeedInclude;

		// Token: 0x0400910C RID: 37132
		[Token(Token = "0x400910C")]
		[FieldOffset(Offset = "0x1C")]
		public int sizeNeedExclude;

		// Token: 0x0400910D RID: 37133
		[Token(Token = "0x400910D")]
		[FieldOffset(Offset = "0x20")]
		public bool enableEffect;

		// Token: 0x0400910E RID: 37134
		[Token(Token = "0x400910E")]
		[FieldOffset(Offset = "0x21")]
		public bool disableInteractable;

		// Token: 0x0400910F RID: 37135
		[Token(Token = "0x400910F")]
		[FieldOffset(Offset = "0x28")]
		public List<BuildingData.FurnitureType> typeNeedInclude;

		// Token: 0x04009110 RID: 37136
		[Token(Token = "0x4009110")]
		[FieldOffset(Offset = "0x30")]
		public List<BuildingData.FurnitureType> typeNeedExclude;
	}
}
