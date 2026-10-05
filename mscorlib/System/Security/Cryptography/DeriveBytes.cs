using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x020002F8 RID: 760
	[Token(Token = "0x20002F8")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public abstract class DeriveBytes : System.IDisposable
	{
		// Token: 0x06001907 RID: 6407
		[Token(Token = "0x6001907")]
		public abstract byte[] GetBytes(int cb);

		// Token: 0x06001908 RID: 6408
		[Token(Token = "0x6001908")]
		public abstract void Reset();

		// Token: 0x06001909 RID: 6409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001909")]
		[Address(RVA = "0x4B2AA50", Offset = "0x4B29650", VA = "0x184B2AA50", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600190A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600190B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected DeriveBytes()
		{
		}
	}
}
