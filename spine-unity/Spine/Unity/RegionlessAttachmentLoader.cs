using System;
using Il2CppDummyDll;

namespace Spine.Unity
{
	// Token: 0x0200006B RID: 107
	[Token(Token = "0x200006B")]
	public class RegionlessAttachmentLoader : AttachmentLoader
	{
		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000176")]
		private static AtlasRegion EmptyRegion
		{
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x4E7DEE0", Offset = "0x4E7CAE0", VA = "0x184E7DEE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x4E7DE60", Offset = "0x4E7CA60", VA = "0x184E7DE60", Slot = "4")]
		public RegionAttachment NewRegionAttachment(Skin skin, string name, string path)
		{
			return null;
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x4E7DD20", Offset = "0x4E7C920", VA = "0x184E7DD20", Slot = "5")]
		public MeshAttachment NewMeshAttachment(Skin skin, string name, string path)
		{
			return null;
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x4E7DC60", Offset = "0x4E7C860", VA = "0x184E7DC60", Slot = "6")]
		public BoundingBoxAttachment NewBoundingBoxAttachment(Skin skin, string name)
		{
			return null;
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x4E7DDA0", Offset = "0x4E7C9A0", VA = "0x184E7DDA0", Slot = "7")]
		public PathAttachment NewPathAttachment(Skin skin, string name)
		{
			return null;
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x4E7DE00", Offset = "0x4E7CA00", VA = "0x184E7DE00", Slot = "8")]
		public PointAttachment NewPointAttachment(Skin skin, string name)
		{
			return null;
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x4E7DCC0", Offset = "0x4E7C8C0", VA = "0x184E7DCC0", Slot = "9")]
		public ClippingAttachment NewClippingAttachment(Skin skin, string name)
		{
			return null;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RegionlessAttachmentLoader()
		{
		}

		// Token: 0x040002B1 RID: 689
		[Token(Token = "0x40002B1")]
		[FieldOffset(Offset = "0x0")]
		private static AtlasRegion emptyRegion;
	}
}
