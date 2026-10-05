using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x0200033A RID: 826
	[Token(Token = "0x200033A")]
	public sealed class RNGCryptoServiceProvider : RandomNumberGenerator
	{
		// Token: 0x06001B6E RID: 7022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B6E")]
		[Address(RVA = "0x4B638A0", Offset = "0x4B624A0", VA = "0x184B638A0")]
		public RNGCryptoServiceProvider()
		{
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B6F")]
		[Address(RVA = "0x4B63A50", Offset = "0x4B62650", VA = "0x184B63A50")]
		public RNGCryptoServiceProvider(byte[] rgb)
		{
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B70")]
		[Address(RVA = "0x4B63810", Offset = "0x4B62410", VA = "0x184B63810")]
		public RNGCryptoServiceProvider(CspParameters cspParams)
		{
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B71")]
		[Address(RVA = "0x4B63930", Offset = "0x4B62530", VA = "0x184B63930")]
		public RNGCryptoServiceProvider(string str)
		{
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B72")]
		[Address(RVA = "0x4B63030", Offset = "0x4B61C30", VA = "0x184B63030")]
		private void Check()
		{
		}

		// Token: 0x06001B73 RID: 7027
		[Token(Token = "0x6001B73")]
		[Address(RVA = "0x4B63760", Offset = "0x4B62360", VA = "0x184B63760")]
		[MethodImpl(4096)]
		private static extern bool RngOpen();

		// Token: 0x06001B74 RID: 7028
		[Token(Token = "0x6001B74")]
		[Address(RVA = "0x4B63750", Offset = "0x4B62350", VA = "0x184B63750")]
		[MethodImpl(4096)]
		private unsafe static extern System.IntPtr RngInitialize(byte* seed, System.IntPtr seed_length);

		// Token: 0x06001B75 RID: 7029
		[Token(Token = "0x6001B75")]
		[Address(RVA = "0x4B63740", Offset = "0x4B62340", VA = "0x184B63740")]
		[MethodImpl(4096)]
		private unsafe static extern System.IntPtr RngGetBytes(System.IntPtr handle, byte* data, System.IntPtr data_length);

		// Token: 0x06001B76 RID: 7030
		[Token(Token = "0x6001B76")]
		[Address(RVA = "0x4B63730", Offset = "0x4B62330", VA = "0x184B63730")]
		[MethodImpl(4096)]
		private static extern void RngClose(System.IntPtr handle);

		// Token: 0x06001B77 RID: 7031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B77")]
		[Address(RVA = "0x4B631D0", Offset = "0x4B61DD0", VA = "0x184B631D0", Slot = "6")]
		public override void GetBytes(byte[] data)
		{
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B78")]
		[Address(RVA = "0x4B633D0", Offset = "0x4B61FD0", VA = "0x184B633D0")]
		internal unsafe void GetBytes(byte* data, System.IntPtr data_length)
		{
		}

		// Token: 0x06001B79 RID: 7033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B79")]
		[Address(RVA = "0x4B63550", Offset = "0x4B62150", VA = "0x184B63550", Slot = "8")]
		public override void GetNonZeroBytes(byte[] data)
		{
		}

		// Token: 0x06001B7A RID: 7034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B7A")]
		[Address(RVA = "0x4B630F0", Offset = "0x4B61CF0", VA = "0x184B630F0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06001B7B RID: 7035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B7B")]
		[Address(RVA = "0x50CDF0", Offset = "0x50B9F0", VA = "0x18050CDF0", Slot = "5")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x04000ECC RID: 3788
		[Token(Token = "0x4000ECC")]
		[FieldOffset(Offset = "0x0")]
		private static object _lock;

		// Token: 0x04000ECD RID: 3789
		[Token(Token = "0x4000ECD")]
		[FieldOffset(Offset = "0x10")]
		private System.IntPtr _handle;
	}
}
