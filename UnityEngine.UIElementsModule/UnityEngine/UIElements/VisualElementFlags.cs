using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020000BE RID: 190
	[Token(Token = "0x20000BE")]
	[Flags]
	internal enum VisualElementFlags
	{
		// Token: 0x0400029C RID: 668
		[Token(Token = "0x400029C")]
		WorldTransformDirty = 1,
		// Token: 0x0400029D RID: 669
		[Token(Token = "0x400029D")]
		WorldTransformInverseDirty = 2,
		// Token: 0x0400029E RID: 670
		[Token(Token = "0x400029E")]
		WorldClipDirty = 4,
		// Token: 0x0400029F RID: 671
		[Token(Token = "0x400029F")]
		BoundingBoxDirty = 8,
		// Token: 0x040002A0 RID: 672
		[Token(Token = "0x40002A0")]
		WorldBoundingBoxDirty = 16,
		// Token: 0x040002A1 RID: 673
		[Token(Token = "0x40002A1")]
		LayoutManual = 32,
		// Token: 0x040002A2 RID: 674
		[Token(Token = "0x40002A2")]
		CompositeRoot = 64,
		// Token: 0x040002A3 RID: 675
		[Token(Token = "0x40002A3")]
		RequireMeasureFunction = 128,
		// Token: 0x040002A4 RID: 676
		[Token(Token = "0x40002A4")]
		EnableViewDataPersistence = 256,
		// Token: 0x040002A5 RID: 677
		[Token(Token = "0x40002A5")]
		DisableClipping = 512,
		// Token: 0x040002A6 RID: 678
		[Token(Token = "0x40002A6")]
		NeedsAttachToPanelEvent = 1024,
		// Token: 0x040002A7 RID: 679
		[Token(Token = "0x40002A7")]
		HierarchyDisplayed = 2048,
		// Token: 0x040002A8 RID: 680
		[Token(Token = "0x40002A8")]
		StyleInitialized = 4096,
		// Token: 0x040002A9 RID: 681
		[Token(Token = "0x40002A9")]
		Init = 2079
	}
}
