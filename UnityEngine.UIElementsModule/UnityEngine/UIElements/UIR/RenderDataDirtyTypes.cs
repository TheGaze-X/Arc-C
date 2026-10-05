using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020002A6 RID: 678
	[Token(Token = "0x20002A6")]
	[Flags]
	internal enum RenderDataDirtyTypes
	{
		// Token: 0x04000A0A RID: 2570
		[Token(Token = "0x4000A0A")]
		None = 0,
		// Token: 0x04000A0B RID: 2571
		[Token(Token = "0x4000A0B")]
		Transform = 1,
		// Token: 0x04000A0C RID: 2572
		[Token(Token = "0x4000A0C")]
		ClipRectSize = 2,
		// Token: 0x04000A0D RID: 2573
		[Token(Token = "0x4000A0D")]
		Clipping = 4,
		// Token: 0x04000A0E RID: 2574
		[Token(Token = "0x4000A0E")]
		ClippingHierarchy = 8,
		// Token: 0x04000A0F RID: 2575
		[Token(Token = "0x4000A0F")]
		Visuals = 16,
		// Token: 0x04000A10 RID: 2576
		[Token(Token = "0x4000A10")]
		VisualsHierarchy = 32,
		// Token: 0x04000A11 RID: 2577
		[Token(Token = "0x4000A11")]
		Opacity = 64,
		// Token: 0x04000A12 RID: 2578
		[Token(Token = "0x4000A12")]
		OpacityHierarchy = 128,
		// Token: 0x04000A13 RID: 2579
		[Token(Token = "0x4000A13")]
		Color = 256
	}
}
