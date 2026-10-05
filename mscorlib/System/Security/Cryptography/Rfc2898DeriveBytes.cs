using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x020002D7 RID: 727
	[Token(Token = "0x20002D7")]
	public class Rfc2898DeriveBytes : DeriveBytes
	{
		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06001811 RID: 6161 RVA: 0x000113E8 File Offset: 0x0000F5E8
		[Token(Token = "0x17000273")]
		public HashAlgorithmName HashAlgorithm
		{
			[Token(Token = "0x6001811")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return default(HashAlgorithmName);
			}
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001812")]
		[Address(RVA = "0x4B17B50", Offset = "0x4B16750", VA = "0x184B17B50")]
		public Rfc2898DeriveBytes(byte[] password, byte[] salt, int iterations)
		{
		}

		// Token: 0x06001813 RID: 6163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001813")]
		[Address(RVA = "0x4B17BB0", Offset = "0x4B167B0", VA = "0x184B17BB0")]
		public Rfc2898DeriveBytes(byte[] password, byte[] salt, int iterations, HashAlgorithmName hashAlgorithm)
		{
		}

		// Token: 0x06001814 RID: 6164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001814")]
		[Address(RVA = "0x4B17E00", Offset = "0x4B16A00", VA = "0x184B17E00")]
		public Rfc2898DeriveBytes(string password, byte[] salt)
		{
		}

		// Token: 0x06001815 RID: 6165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001815")]
		[Address(RVA = "0x4B17AA0", Offset = "0x4B166A0", VA = "0x184B17AA0")]
		public Rfc2898DeriveBytes(string password, byte[] salt, int iterations)
		{
		}

		// Token: 0x06001816 RID: 6166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001816")]
		[Address(RVA = "0x4B17A00", Offset = "0x4B16600", VA = "0x184B17A00")]
		public Rfc2898DeriveBytes(string password, byte[] salt, int iterations, HashAlgorithmName hashAlgorithm)
		{
		}

		// Token: 0x06001817 RID: 6167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001817")]
		[Address(RVA = "0x4B17770", Offset = "0x4B16370", VA = "0x184B17770")]
		public Rfc2898DeriveBytes(string password, int saltSize)
		{
		}

		// Token: 0x06001818 RID: 6168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001818")]
		[Address(RVA = "0x4B17EB0", Offset = "0x4B16AB0", VA = "0x184B17EB0")]
		public Rfc2898DeriveBytes(string password, int saltSize, int iterations)
		{
		}

		// Token: 0x06001819 RID: 6169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001819")]
		[Address(RVA = "0x4B177D0", Offset = "0x4B163D0", VA = "0x184B177D0")]
		public Rfc2898DeriveBytes(string password, int saltSize, int iterations, HashAlgorithmName hashAlgorithm)
		{
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x0600181A RID: 6170 RVA: 0x00011400 File Offset: 0x0000F600
		// (set) Token: 0x0600181B RID: 6171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000274")]
		public int IterationCount
		{
			[Token(Token = "0x600181A")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600181B")]
			[Address(RVA = "0x4B17F20", Offset = "0x4B16B20", VA = "0x184B17F20")]
			set
			{
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x0600181C RID: 6172 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x0600181D RID: 6173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000275")]
		public byte[] Salt
		{
			[Token(Token = "0x600181C")]
			[Address(RVA = "0x4B17F10", Offset = "0x4B16B10", VA = "0x184B17F10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600181D")]
			[Address(RVA = "0x4B17FB0", Offset = "0x4B16BB0", VA = "0x184B17FB0")]
			set
			{
			}
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600181E")]
		[Address(RVA = "0x4B16D50", Offset = "0x4B15950", VA = "0x184B16D50", Slot = "7")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x0600181F RID: 6175 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600181F")]
		[Address(RVA = "0x4B172C0", Offset = "0x4B15EC0", VA = "0x184B172C0", Slot = "5")]
		public override byte[] GetBytes(int cb)
		{
			return null;
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001820")]
		[Address(RVA = "0x4B16D00", Offset = "0x4B15900", VA = "0x184B16D00")]
		public byte[] CryptDeriveKey(string algname, string alghashname, int keySize, byte[] rgbIV)
		{
			return null;
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001821")]
		[Address(RVA = "0x4B17760", Offset = "0x4B16360", VA = "0x184B17760", Slot = "6")]
		public override void Reset()
		{
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001822")]
		[Address(RVA = "0x4B174E0", Offset = "0x4B160E0", VA = "0x184B174E0")]
		private HMAC OpenHmac()
		{
			return null;
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001823")]
		[Address(RVA = "0x4B17460", Offset = "0x4B16060", VA = "0x184B17460")]
		private void Initialize()
		{
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001824")]
		[Address(RVA = "0x4B16DF0", Offset = "0x4B159F0", VA = "0x184B16DF0")]
		private byte[] Func()
		{
			return null;
		}

		// Token: 0x04000D33 RID: 3379
		[Token(Token = "0x4000D33")]
		private const int MinimumSaltSize = 8;

		// Token: 0x04000D34 RID: 3380
		[Token(Token = "0x4000D34")]
		[FieldOffset(Offset = "0x10")]
		private readonly byte[] _password;

		// Token: 0x04000D35 RID: 3381
		[Token(Token = "0x4000D35")]
		[FieldOffset(Offset = "0x18")]
		private byte[] _salt;

		// Token: 0x04000D36 RID: 3382
		[Token(Token = "0x4000D36")]
		[FieldOffset(Offset = "0x20")]
		private uint _iterations;

		// Token: 0x04000D37 RID: 3383
		[Token(Token = "0x4000D37")]
		[FieldOffset(Offset = "0x28")]
		private HMAC _hmac;

		// Token: 0x04000D38 RID: 3384
		[Token(Token = "0x4000D38")]
		[FieldOffset(Offset = "0x30")]
		private int _blockSize;

		// Token: 0x04000D39 RID: 3385
		[Token(Token = "0x4000D39")]
		[FieldOffset(Offset = "0x38")]
		private byte[] _buffer;

		// Token: 0x04000D3A RID: 3386
		[Token(Token = "0x4000D3A")]
		[FieldOffset(Offset = "0x40")]
		private uint _block;

		// Token: 0x04000D3B RID: 3387
		[Token(Token = "0x4000D3B")]
		[FieldOffset(Offset = "0x44")]
		private int _startIndex;

		// Token: 0x04000D3C RID: 3388
		[Token(Token = "0x4000D3C")]
		[FieldOffset(Offset = "0x48")]
		private int _endIndex;
	}
}
