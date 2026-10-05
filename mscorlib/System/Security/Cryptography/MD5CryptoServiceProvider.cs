using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x02000338 RID: 824
	[Token(Token = "0x2000338")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public sealed class MD5CryptoServiceProvider : MD5
	{
		// Token: 0x06001B60 RID: 7008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B60")]
		[Address(RVA = "0x4B60F50", Offset = "0x4B5FB50", VA = "0x184B60F50")]
		public MD5CryptoServiceProvider()
		{
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B61")]
		[Address(RVA = "0x4B5F9B0", Offset = "0x4B5E5B0", VA = "0x184B5F9B0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B62")]
		[Address(RVA = "0x4B5F940", Offset = "0x4B5E540", VA = "0x184B5F940", Slot = "13")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B63")]
		[Address(RVA = "0x4B5FA30", Offset = "0x4B5E630", VA = "0x184B5FA30", Slot = "18")]
		protected override void HashCore(byte[] rgb, int ibStart, int cbSize)
		{
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001B64")]
		[Address(RVA = "0x4B5FB50", Offset = "0x4B5E750", VA = "0x184B5FB50", Slot = "19")]
		protected override byte[] HashFinal()
		{
			return null;
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B65")]
		[Address(RVA = "0x4B5FC40", Offset = "0x4B5E840", VA = "0x184B5FC40", Slot = "20")]
		public override void Initialize()
		{
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B66")]
		[Address(RVA = "0x4B5FCC0", Offset = "0x4B5E8C0", VA = "0x184B5FCC0")]
		private void ProcessBlock(byte[] inputBuffer, int inputOffset)
		{
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B67")]
		[Address(RVA = "0x4B60CB0", Offset = "0x4B5F8B0", VA = "0x184B60CB0")]
		private void ProcessFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B68")]
		[Address(RVA = "0x4B5F860", Offset = "0x4B5E460", VA = "0x184B5F860")]
		internal void AddLength(ulong length, byte[] buffer, int position)
		{
		}

		// Token: 0x04000EBE RID: 3774
		[Token(Token = "0x4000EBE")]
		private const int BLOCK_SIZE_BYTES = 64;

		// Token: 0x04000EBF RID: 3775
		[Token(Token = "0x4000EBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private uint[] _H;

		// Token: 0x04000EC0 RID: 3776
		[Token(Token = "0x4000EC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private uint[] buff;

		// Token: 0x04000EC1 RID: 3777
		[Token(Token = "0x4000EC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ulong count;

		// Token: 0x04000EC2 RID: 3778
		[Token(Token = "0x4000EC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private byte[] _ProcessingBuffer;

		// Token: 0x04000EC3 RID: 3779
		[Token(Token = "0x4000EC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _ProcessingBufferCount;

		// Token: 0x04000EC4 RID: 3780
		[Token(Token = "0x4000EC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly uint[] K;
	}
}
