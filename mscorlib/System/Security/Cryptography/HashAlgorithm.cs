using System;
using System.IO;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x020002E2 RID: 738
	[Token(Token = "0x20002E2")]
	public abstract class HashAlgorithm : System.IDisposable, ICryptoTransform
	{
		// Token: 0x06001857 RID: 6231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001857")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected HashAlgorithm()
		{
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001858")]
		[Address(RVA = "0x4B2DAC0", Offset = "0x4B2C6C0", VA = "0x184B2DAC0")]
		public static HashAlgorithm Create()
		{
			return null;
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001859")]
		[Address(RVA = "0x4B2DAD0", Offset = "0x4B2C6D0", VA = "0x184B2DAD0")]
		public static HashAlgorithm Create(string hashName)
		{
			return null;
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x0600185A RID: 6234 RVA: 0x00011520 File Offset: 0x0000F720
		[Token(Token = "0x1700027E")]
		public virtual int HashSize
		{
			[Token(Token = "0x600185A")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x0600185B RID: 6235 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700027F")]
		public virtual byte[] Hash
		{
			[Token(Token = "0x600185B")]
			[Address(RVA = "0x4B2E4E0", Offset = "0x4B2D0E0", VA = "0x184B2E4E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600185C")]
		[Address(RVA = "0x4B2D7D0", Offset = "0x4B2C3D0", VA = "0x184B2D7D0")]
		public byte[] ComputeHash(byte[] buffer)
		{
			return null;
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x00011538 File Offset: 0x0000F738
		[Token(Token = "0x600185D")]
		[Address(RVA = "0x4B2DFD0", Offset = "0x4B2CBD0", VA = "0x184B2DFD0")]
		public bool TryComputeHash(System.ReadOnlySpan<byte> source, System.Span<byte> destination, out int bytesWritten)
		{
			return default(bool);
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600185E")]
		[Address(RVA = "0x4B2D8B0", Offset = "0x4B2C4B0", VA = "0x184B2D8B0")]
		public byte[] ComputeHash(byte[] buffer, int offset, int count)
		{
			return null;
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600185F")]
		[Address(RVA = "0x4B2D5B0", Offset = "0x4B2C1B0", VA = "0x184B2D5B0")]
		public byte[] ComputeHash(System.IO.Stream inputStream)
		{
			return null;
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001860")]
		[Address(RVA = "0x4B2D490", Offset = "0x4B2C090", VA = "0x184B2D490")]
		private byte[] CaptureHashCodeAndReinitialize()
		{
			return null;
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001861")]
		[Address(RVA = "0x4B2DBA0", Offset = "0x4B2C7A0", VA = "0x184B2DBA0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001862")]
		[Address(RVA = "0x4B2D570", Offset = "0x4B2C170", VA = "0x184B2D570")]
		public void Clear()
		{
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001863")]
		[Address(RVA = "0x4B2DB90", Offset = "0x4B2C790", VA = "0x184B2DB90", Slot = "13")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06001864 RID: 6244 RVA: 0x00011550 File Offset: 0x0000F750
		[Token(Token = "0x17000280")]
		public virtual int InputBlockSize
		{
			[Token(Token = "0x6001864")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "14")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06001865 RID: 6245 RVA: 0x00011568 File Offset: 0x0000F768
		[Token(Token = "0x17000281")]
		public virtual int OutputBlockSize
		{
			[Token(Token = "0x6001865")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "15")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06001866 RID: 6246 RVA: 0x00011580 File Offset: 0x0000F780
		[Token(Token = "0x17000282")]
		public virtual bool CanTransformMultipleBlocks
		{
			[Token(Token = "0x6001866")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06001867 RID: 6247 RVA: 0x00011598 File Offset: 0x0000F798
		[Token(Token = "0x17000283")]
		public virtual bool CanReuseTransform
		{
			[Token(Token = "0x6001867")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x000115B0 File Offset: 0x0000F7B0
		[Token(Token = "0x6001868")]
		[Address(RVA = "0x4B2DDC0", Offset = "0x4B2C9C0", VA = "0x184B2DDC0", Slot = "9")]
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			return 0;
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001869")]
		[Address(RVA = "0x4B2DE70", Offset = "0x4B2CA70", VA = "0x184B2DE70", Slot = "10")]
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			return null;
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600186A")]
		[Address(RVA = "0x4B2E2F0", Offset = "0x4B2CEF0", VA = "0x184B2E2F0")]
		private void ValidateTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
		}

		// Token: 0x0600186B RID: 6251
		[Token(Token = "0x600186B")]
		protected abstract void HashCore(byte[] array, int ibStart, int cbSize);

		// Token: 0x0600186C RID: 6252
		[Token(Token = "0x600186C")]
		protected abstract byte[] HashFinal();

		// Token: 0x0600186D RID: 6253
		[Token(Token = "0x600186D")]
		public abstract void Initialize();

		// Token: 0x0600186E RID: 6254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600186E")]
		[Address(RVA = "0x4B2DC10", Offset = "0x4B2C810", VA = "0x184B2DC10", Slot = "21")]
		protected virtual void HashCore(System.ReadOnlySpan<byte> source)
		{
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x000115C8 File Offset: 0x0000F7C8
		[Token(Token = "0x600186F")]
		[Address(RVA = "0x4B2E190", Offset = "0x4B2CD90", VA = "0x184B2E190", Slot = "22")]
		protected virtual bool TryHashFinal(System.Span<byte> destination, out int bytesWritten)
		{
			return default(bool);
		}

		// Token: 0x04000D84 RID: 3460
		[Token(Token = "0x4000D84")]
		[FieldOffset(Offset = "0x10")]
		private bool _disposed;

		// Token: 0x04000D85 RID: 3461
		[Token(Token = "0x4000D85")]
		[FieldOffset(Offset = "0x14")]
		protected int HashSizeValue;

		// Token: 0x04000D86 RID: 3462
		[Token(Token = "0x4000D86")]
		[FieldOffset(Offset = "0x18")]
		protected internal byte[] HashValue;

		// Token: 0x04000D87 RID: 3463
		[Token(Token = "0x4000D87")]
		[FieldOffset(Offset = "0x20")]
		protected int State;
	}
}
