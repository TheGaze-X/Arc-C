using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	public class CriStructMemory<Type> : IDisposable
	{
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600018A RID: 394 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x0600018B RID: 395 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700003A")]
		public byte[] bytes
		{
			[Token(Token = "0x600018A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600018B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600018C RID: 396 RVA: 0x000026E4 File Offset: 0x000008E4
		[Token(Token = "0x1700003B")]
		public IntPtr ptr
		{
			[Token(Token = "0x600018C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600018D")]
		public CriStructMemory()
		{
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600018E")]
		public CriStructMemory(int num)
		{
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600018F")]
		public void Dispose()
		{
		}

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private GCHandle gch;
	}
}
