using System;
using Il2CppDummyDll;

namespace DG.Tweening.Plugins.Options
{
	// Token: 0x0200008C RID: 140
	[Token(Token = "0x200008C")]
	public struct Vector3ArrayOptions : IPlugOptions
	{
		// Token: 0x0600036E RID: 878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x3757520", Offset = "0x3756120", VA = "0x183757520", Slot = "4")]
		public void Reset()
		{
		}

		// Token: 0x04000187 RID: 391
		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x0")]
		public AxisConstraint axisConstraint;

		// Token: 0x04000188 RID: 392
		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x4")]
		public bool snapping;

		// Token: 0x04000189 RID: 393
		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x8")]
		internal float[] durations;
	}
}
