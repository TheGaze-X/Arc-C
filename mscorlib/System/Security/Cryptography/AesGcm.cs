using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x02000341 RID: 833
	[Token(Token = "0x2000341")]
	public sealed class AesGcm : System.IDisposable
	{
		// Token: 0x06001BA1 RID: 7073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA1")]
		[Address(RVA = "0x4B531D0", Offset = "0x4B51DD0", VA = "0x184B531D0")]
		public AesGcm(byte[] key)
		{
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA2")]
		[Address(RVA = "0x4B53220", Offset = "0x4B51E20", VA = "0x184B53220")]
		public AesGcm(System.ReadOnlySpan<byte> key)
		{
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06001BA3 RID: 7075 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700030A")]
		public static KeySizes NonceByteSizes
		{
			[Token(Token = "0x6001BA3")]
			[Address(RVA = "0x4B53270", Offset = "0x4B51E70", VA = "0x184B53270")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06001BA4 RID: 7076 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700030B")]
		public static KeySizes TagByteSizes
		{
			[Token(Token = "0x6001BA4")]
			[Address(RVA = "0x4B532C0", Offset = "0x4B51EC0", VA = "0x184B532C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA5")]
		[Address(RVA = "0x4B53090", Offset = "0x4B51C90", VA = "0x184B53090")]
		public void Decrypt(byte[] nonce, byte[] ciphertext, byte[] tag, byte[] plaintext, [System.Runtime.InteropServices.Optional] byte[] associatedData)
		{
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA6")]
		[Address(RVA = "0x4B530E0", Offset = "0x4B51CE0", VA = "0x184B530E0")]
		public void Decrypt(System.ReadOnlySpan<byte> nonce, System.ReadOnlySpan<byte> ciphertext, System.ReadOnlySpan<byte> tag, System.Span<byte> plaintext, [System.Runtime.InteropServices.Optional] System.ReadOnlySpan<byte> associatedData)
		{
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA7")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA8")]
		[Address(RVA = "0x4B53130", Offset = "0x4B51D30", VA = "0x184B53130")]
		public void Encrypt(byte[] nonce, byte[] plaintext, byte[] ciphertext, byte[] tag, [System.Runtime.InteropServices.Optional] byte[] associatedData)
		{
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA9")]
		[Address(RVA = "0x4B53180", Offset = "0x4B51D80", VA = "0x184B53180")]
		public void Encrypt(System.ReadOnlySpan<byte> nonce, System.ReadOnlySpan<byte> plaintext, System.Span<byte> ciphertext, System.Span<byte> tag, [System.Runtime.InteropServices.Optional] System.ReadOnlySpan<byte> associatedData)
		{
		}
	}
}
