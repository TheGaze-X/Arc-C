using System;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	// Token: 0x02000088 RID: 136
	[Token(Token = "0x2000088")]
	public abstract class ImageAspects
	{
		// Token: 0x06000587 RID: 1415
		[Token(Token = "0x6000587")]
		public abstract void OnSpriteChanged(Image image);

		// Token: 0x06000588 RID: 1416
		[Token(Token = "0x6000588")]
		public abstract void Awake(Image image);

		// Token: 0x06000589 RID: 1417
		[Token(Token = "0x6000589")]
		public abstract void OnEnable(Image image);

		// Token: 0x0600058A RID: 1418
		[Token(Token = "0x600058A")]
		public abstract void OnDestroy(Image image);

		// Token: 0x0600058B RID: 1419
		[Token(Token = "0x600058B")]
		public abstract void SetNativeSize(Image image);

		// Token: 0x0600058C RID: 1420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600058C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected ImageAspects()
		{
		}
	}
}
