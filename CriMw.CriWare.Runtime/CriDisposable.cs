using System;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x02000113 RID: 275
	[Token(Token = "0x2000113")]
	public abstract class CriDisposable : IDisposable
	{
		// Token: 0x06000816 RID: 2070 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000816")]
		[Address(RVA = "0x36F3310", Offset = "0x36F1F10", VA = "0x1836F3310")]
		public CriDisposable()
		{
		}

		// Token: 0x06000817 RID: 2071
		[Token(Token = "0x6000817")]
		public abstract void Dispose();

		// Token: 0x040004F4 RID: 1268
		[Token(Token = "0x40004F4")]
		[FieldOffset(Offset = "0x10")]
		public Guid guid;
	}
}
