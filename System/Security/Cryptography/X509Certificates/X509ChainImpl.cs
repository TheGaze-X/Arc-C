using System;
using Il2CppDummyDll;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000146 RID: 326
	[Token(Token = "0x2000146")]
	internal abstract class X509ChainImpl : IDisposable
	{
		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600080D RID: 2061
		[Token(Token = "0x1700018D")]
		public abstract bool IsValid { [Token(Token = "0x600080D")] get; }

		// Token: 0x0600080E RID: 2062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600080E")]
		[Address(RVA = "0x5133D90", Offset = "0x5132990", VA = "0x185133D90")]
		protected void ThrowIfContextInvalid()
		{
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600080F RID: 2063
		[Token(Token = "0x1700018E")]
		public abstract X509ChainElementCollection ChainElements { [Token(Token = "0x600080F")] get; }

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000810 RID: 2064
		[Token(Token = "0x1700018F")]
		public abstract X509ChainPolicy ChainPolicy { [Token(Token = "0x6000810")] get; }

		// Token: 0x06000811 RID: 2065
		[Token(Token = "0x6000811")]
		public abstract bool Build(X509Certificate2 certificate);

		// Token: 0x06000812 RID: 2066
		[Token(Token = "0x6000812")]
		public abstract void AddStatus(X509ChainStatusFlags errorCode);

		// Token: 0x06000813 RID: 2067
		[Token(Token = "0x6000813")]
		public abstract void Reset();

		// Token: 0x06000814 RID: 2068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000814")]
		[Address(RVA = "0x5133D20", Offset = "0x5132920", VA = "0x185133D20", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000815")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "11")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000816")]
		[Address(RVA = "0x4AD6880", Offset = "0x4AD5480", VA = "0x184AD6880", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000817")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected X509ChainImpl()
		{
		}
	}
}
