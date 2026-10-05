using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x02000340 RID: 832
	[Token(Token = "0x2000340")]
	public sealed class AesCcm : System.IDisposable
	{
		// Token: 0x06001B98 RID: 7064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B98")]
		[Address(RVA = "0x4B52FA0", Offset = "0x4B51BA0", VA = "0x184B52FA0")]
		public AesCcm(byte[] key)
		{
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B99")]
		[Address(RVA = "0x4B52F50", Offset = "0x4B51B50", VA = "0x184B52F50")]
		public AesCcm(System.ReadOnlySpan<byte> key)
		{
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06001B9A RID: 7066 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000308")]
		public static KeySizes NonceByteSizes
		{
			[Token(Token = "0x6001B9A")]
			[Address(RVA = "0x4B52FF0", Offset = "0x4B51BF0", VA = "0x184B52FF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06001B9B RID: 7067 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000309")]
		public static KeySizes TagByteSizes
		{
			[Token(Token = "0x6001B9B")]
			[Address(RVA = "0x4B53040", Offset = "0x4B51C40", VA = "0x184B53040")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B9C RID: 7068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B9C")]
		[Address(RVA = "0x4B52E10", Offset = "0x4B51A10", VA = "0x184B52E10")]
		public void Decrypt(byte[] nonce, byte[] ciphertext, byte[] tag, byte[] plaintext, [System.Runtime.InteropServices.Optional] byte[] associatedData)
		{
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B9D")]
		[Address(RVA = "0x4B52E60", Offset = "0x4B51A60", VA = "0x184B52E60")]
		public void Decrypt(System.ReadOnlySpan<byte> nonce, System.ReadOnlySpan<byte> ciphertext, System.ReadOnlySpan<byte> tag, System.Span<byte> plaintext, [System.Runtime.InteropServices.Optional] System.ReadOnlySpan<byte> associatedData)
		{
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B9E")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B9F")]
		[Address(RVA = "0x4B52EB0", Offset = "0x4B51AB0", VA = "0x184B52EB0")]
		public void Encrypt(byte[] nonce, byte[] plaintext, byte[] ciphertext, byte[] tag, [System.Runtime.InteropServices.Optional] byte[] associatedData)
		{
		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA0")]
		[Address(RVA = "0x4B52F00", Offset = "0x4B51B00", VA = "0x184B52F00")]
		public void Encrypt(System.ReadOnlySpan<byte> nonce, System.ReadOnlySpan<byte> plaintext, System.Span<byte> ciphertext, System.Span<byte> tag, [System.Runtime.InteropServices.Optional] System.ReadOnlySpan<byte> associatedData)
		{
		}
	}
}
