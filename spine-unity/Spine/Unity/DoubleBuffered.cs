using System;
using Il2CppDummyDll;

namespace Spine.Unity
{
	// Token: 0x020000AA RID: 170
	[Token(Token = "0x20000AA")]
	public class DoubleBuffered<T> where T : new()
	{
		// Token: 0x06000698 RID: 1688 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000698")]
		public T GetCurrent()
		{
			return null;
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000699")]
		public T GetNext()
		{
			return null;
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600069A")]
		public DoubleBuffered()
		{
		}

		// Token: 0x04000412 RID: 1042
		[Token(Token = "0x4000412")]
		[FieldOffset(Offset = "0x0")]
		private readonly T a;

		// Token: 0x04000413 RID: 1043
		[Token(Token = "0x4000413")]
		[FieldOffset(Offset = "0x0")]
		private readonly T b;

		// Token: 0x04000414 RID: 1044
		[Token(Token = "0x4000414")]
		[FieldOffset(Offset = "0x0")]
		private bool usingA;
	}
}
