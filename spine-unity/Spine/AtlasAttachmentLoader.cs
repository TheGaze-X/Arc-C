using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x0200002F RID: 47
	[Token(Token = "0x200002F")]
	public class AtlasAttachmentLoader : AttachmentLoader
	{
		// Token: 0x0600015D RID: 349 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x4E419A0", Offset = "0x4E405A0", VA = "0x184E419A0")]
		public AtlasAttachmentLoader(params Atlas[] atlasArray)
		{
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x4E41820", Offset = "0x4E40420", VA = "0x184E41820", Slot = "4")]
		public RegionAttachment NewRegionAttachment(Skin skin, string name, string path)
		{
			return null;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x4E415E0", Offset = "0x4E401E0", VA = "0x184E415E0", Slot = "5")]
		public MeshAttachment NewMeshAttachment(Skin skin, string name, string path)
		{
			return null;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x4E414C0", Offset = "0x4E400C0", VA = "0x184E414C0", Slot = "6")]
		public BoundingBoxAttachment NewBoundingBoxAttachment(Skin skin, string name)
		{
			return null;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x4E41760", Offset = "0x4E40360", VA = "0x184E41760", Slot = "7")]
		public PathAttachment NewPathAttachment(Skin skin, string name)
		{
			return null;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x4E417C0", Offset = "0x4E403C0", VA = "0x184E417C0", Slot = "8")]
		public PointAttachment NewPointAttachment(Skin skin, string name)
		{
			return null;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x4E41550", Offset = "0x4E40150", VA = "0x184E41550", Slot = "9")]
		public ClippingAttachment NewClippingAttachment(Skin skin, string name)
		{
			return null;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x4E41390", Offset = "0x4E3FF90", VA = "0x184E41390")]
		public AtlasRegion FindRegion(string name)
		{
			return null;
		}

		// Token: 0x04000120 RID: 288
		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x10")]
		private Atlas[] atlasArray;
	}
}
