using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000574 RID: 1396
	[Token(Token = "0x2000574")]
	public class RefCountReference
	{
		// Token: 0x06005BA1 RID: 23457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BA1")]
		[Address(RVA = "0x1AF9100", Offset = "0x1AF7D00", VA = "0x181AF9100")]
		public void Attach(IRefCountInstance inst)
		{
		}

		// Token: 0x06005BA2 RID: 23458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BA2")]
		[Address(RVA = "0x1AF91F0", Offset = "0x1AF7DF0", VA = "0x181AF91F0")]
		public void Detach(IRefCountInstance inst)
		{
		}

		// Token: 0x06005BA3 RID: 23459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BA3")]
		[Address(RVA = "0x1AF9280", Offset = "0x1AF7E80", VA = "0x181AF9280")]
		public void Unreference(IRefCountInstance inst)
		{
		}

		// Token: 0x06005BA4 RID: 23460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BA4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RefCountReference()
		{
		}

		// Token: 0x0400212C RID: 8492
		[Token(Token = "0x400212C")]
		[FieldOffset(Offset = "0x10")]
		private long m_signature;

		// Token: 0x0400212D RID: 8493
		[Token(Token = "0x400212D")]
		[FieldOffset(Offset = "0x18")]
		private int m_selfRefCount;
	}
}
