using System;
using Il2CppDummyDll;

namespace U8.SDK
{
	// Token: 0x02000080 RID: 128
	[Token(Token = "0x2000080")]
	public class SDKPromiseWrapper
	{
		// Token: 0x0600027A RID: 634 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600027A")]
		public T EnsurePromise<T>() where T : ISDKPromise, new()
		{
			return null;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x4A18300", Offset = "0x4A16F00", VA = "0x184A18300")]
		public void Fulfill(object param)
		{
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x4A18370", Offset = "0x4A16F70", VA = "0x184A18370")]
		public void Reject(object reason)
		{
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1DEED20", Offset = "0x1DED920", VA = "0x181DEED20")]
		private void _Clear()
		{
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SDKPromiseWrapper()
		{
		}

		// Token: 0x04000234 RID: 564
		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x10")]
		private ISDKPromise m_promise;
	}
}
