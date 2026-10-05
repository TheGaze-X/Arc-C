using System;
using Il2CppDummyDll;

namespace DG.Tweening.Plugins.Options
{
	// Token: 0x02000092 RID: 146
	[Token(Token = "0x2000092")]
	public struct VectorOptions : IPlugOptions
	{
		// Token: 0x06000374 RID: 884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x3759BB0", Offset = "0x37587B0", VA = "0x183759BB0", Slot = "4")]
		public void Reset()
		{
		}

		// Token: 0x04000192 RID: 402
		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x0")]
		public AxisConstraint axisConstraint;

		// Token: 0x04000193 RID: 403
		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x4")]
		public bool snapping;
	}
}
