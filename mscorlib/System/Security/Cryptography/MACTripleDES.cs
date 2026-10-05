using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x02000308 RID: 776
	[Token(Token = "0x2000308")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class MACTripleDES : KeyedHashAlgorithm
	{
		// Token: 0x0600196E RID: 6510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600196E")]
		[Address(RVA = "0x4B2EFB0", Offset = "0x4B2DBB0", VA = "0x184B2EFB0")]
		public MACTripleDES()
		{
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600196F")]
		[Address(RVA = "0x4B2F1D0", Offset = "0x4B2DDD0", VA = "0x184B2F1D0")]
		public MACTripleDES(byte[] rgbKey)
		{
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001970")]
		[Address(RVA = "0x4B2F220", Offset = "0x4B2DE20", VA = "0x184B2F220")]
		public MACTripleDES(string strTripleDES, byte[] rgbKey)
		{
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001971")]
		[Address(RVA = "0xFB1430", Offset = "0xFB0030", VA = "0x180FB1430", Slot = "20")]
		public override void Initialize()
		{
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06001972 RID: 6514 RVA: 0x00011BF8 File Offset: 0x0000FDF8
		// (set) Token: 0x06001973 RID: 6515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B6")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public PaddingMode Padding
		{
			[Token(Token = "0x6001972")]
			[Address(RVA = "0x4B2F4C0", Offset = "0x4B2E0C0", VA = "0x184B2F4C0")]
			get
			{
				return (PaddingMode)0;
			}
			[Token(Token = "0x6001973")]
			[Address(RVA = "0x4B2F510", Offset = "0x4B2E110", VA = "0x184B2F510")]
			set
			{
			}
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001974")]
		[Address(RVA = "0x4B2EB30", Offset = "0x4B2D730", VA = "0x184B2EB30", Slot = "18")]
		protected override void HashCore(byte[] rgbData, int ibStart, int cbSize)
		{
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001975")]
		[Address(RVA = "0x4B2ED60", Offset = "0x4B2D960", VA = "0x184B2ED60", Slot = "19")]
		protected override byte[] HashFinal()
		{
			return null;
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001976")]
		[Address(RVA = "0x4B2EA40", Offset = "0x4B2D640", VA = "0x184B2EA40", Slot = "13")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x04000DDF RID: 3551
		[Token(Token = "0x4000DDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ICryptoTransform m_encryptor;

		// Token: 0x04000DE0 RID: 3552
		[Token(Token = "0x4000DE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CryptoStream _cs;

		// Token: 0x04000DE1 RID: 3553
		[Token(Token = "0x4000DE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TailStream _ts;

		// Token: 0x04000DE2 RID: 3554
		[Token(Token = "0x4000DE2")]
		private const int m_bitsPerByte = 8;

		// Token: 0x04000DE3 RID: 3555
		[Token(Token = "0x4000DE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int m_bytesPerBlock;

		// Token: 0x04000DE4 RID: 3556
		[Token(Token = "0x4000DE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TripleDES des;
	}
}
