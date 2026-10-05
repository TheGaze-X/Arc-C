using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	public abstract class IInterpolation
	{
		// Token: 0x060002FB RID: 763
		[Token(Token = "0x60002FB")]
		protected abstract float Apply(float a);

		// Token: 0x060002FC RID: 764 RVA: 0x00003554 File Offset: 0x00001754
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x4E4E140", Offset = "0x4E4CD40", VA = "0x184E4E140")]
		public float Apply(float start, float end, float a)
		{
			return 0f;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected IInterpolation()
		{
		}

		// Token: 0x040001D9 RID: 473
		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x0")]
		public static IInterpolation Pow2;

		// Token: 0x040001DA RID: 474
		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x8")]
		public static IInterpolation Pow2Out;
	}
}
