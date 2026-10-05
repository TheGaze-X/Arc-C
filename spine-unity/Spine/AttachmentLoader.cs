using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	public interface AttachmentLoader
	{
		// Token: 0x0600016C RID: 364
		[Token(Token = "0x600016C")]
		RegionAttachment NewRegionAttachment(Skin skin, string name, string path);

		// Token: 0x0600016D RID: 365
		[Token(Token = "0x600016D")]
		MeshAttachment NewMeshAttachment(Skin skin, string name, string path);

		// Token: 0x0600016E RID: 366
		[Token(Token = "0x600016E")]
		BoundingBoxAttachment NewBoundingBoxAttachment(Skin skin, string name);

		// Token: 0x0600016F RID: 367
		[Token(Token = "0x600016F")]
		PathAttachment NewPathAttachment(Skin skin, string name);

		// Token: 0x06000170 RID: 368
		[Token(Token = "0x6000170")]
		PointAttachment NewPointAttachment(Skin skin, string name);

		// Token: 0x06000171 RID: 369
		[Token(Token = "0x6000171")]
		ClippingAttachment NewClippingAttachment(Skin skin, string name);
	}
}
