using System;
using Il2CppDummyDll;

namespace Spine.Unity
{
	// Token: 0x02000073 RID: 115
	[Token(Token = "0x2000073")]
	public class MaterialsTextureLoader : TextureLoader
	{
		// Token: 0x060004C7 RID: 1223 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public MaterialsTextureLoader(SpineAtlasAsset atlasAsset)
		{
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x4E7A4F0", Offset = "0x4E790F0", VA = "0x184E7A4F0", Slot = "4")]
		public void Load(AtlasPage page, string path)
		{
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		public void Unload(object texture)
		{
		}

		// Token: 0x040002CB RID: 715
		[Token(Token = "0x40002CB")]
		[FieldOffset(Offset = "0x10")]
		private SpineAtlasAsset atlasAsset;
	}
}
