using System;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x020002E3 RID: 739
	[Token(Token = "0x20002E3")]
	public readonly struct HashAlgorithmName : System.IEquatable<HashAlgorithmName>
	{
		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06001870 RID: 6256 RVA: 0x000115E0 File Offset: 0x0000F7E0
		[Token(Token = "0x17000284")]
		public static HashAlgorithmName MD5
		{
			[Token(Token = "0x6001870")]
			[Address(RVA = "0x4B2D320", Offset = "0x4B2BF20", VA = "0x184B2D320")]
			get
			{
				return default(HashAlgorithmName);
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06001871 RID: 6257 RVA: 0x000115F8 File Offset: 0x0000F7F8
		[Token(Token = "0x17000285")]
		public static HashAlgorithmName SHA1
		{
			[Token(Token = "0x6001871")]
			[Address(RVA = "0x4B2D360", Offset = "0x4B2BF60", VA = "0x184B2D360")]
			get
			{
				return default(HashAlgorithmName);
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06001872 RID: 6258 RVA: 0x00011610 File Offset: 0x0000F810
		[Token(Token = "0x17000286")]
		public static HashAlgorithmName SHA256
		{
			[Token(Token = "0x6001872")]
			[Address(RVA = "0x4B2D3A0", Offset = "0x4B2BFA0", VA = "0x184B2D3A0")]
			get
			{
				return default(HashAlgorithmName);
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06001873 RID: 6259 RVA: 0x00011628 File Offset: 0x0000F828
		[Token(Token = "0x17000287")]
		public static HashAlgorithmName SHA384
		{
			[Token(Token = "0x6001873")]
			[Address(RVA = "0x4B2D3E0", Offset = "0x4B2BFE0", VA = "0x184B2D3E0")]
			get
			{
				return default(HashAlgorithmName);
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06001874 RID: 6260 RVA: 0x00011640 File Offset: 0x0000F840
		[Token(Token = "0x17000288")]
		public static HashAlgorithmName SHA512
		{
			[Token(Token = "0x6001874")]
			[Address(RVA = "0x4B2D420", Offset = "0x4B2C020", VA = "0x184B2D420")]
			get
			{
				return default(HashAlgorithmName);
			}
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001875")]
		[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
		public HashAlgorithmName(string name)
		{
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06001876 RID: 6262 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000289")]
		public string Name
		{
			[Token(Token = "0x6001876")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001877")]
		[Address(RVA = "0x4B2D2D0", Offset = "0x4B2BED0", VA = "0x184B2D2D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x00011658 File Offset: 0x0000F858
		[Token(Token = "0x6001878")]
		[Address(RVA = "0x4B2D1E0", Offset = "0x4B2BDE0", VA = "0x184B2D1E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x00011670 File Offset: 0x0000F870
		[Token(Token = "0x6001879")]
		[Address(RVA = "0x4B2D270", Offset = "0x4B2BE70", VA = "0x184B2D270", Slot = "4")]
		public bool Equals(HashAlgorithmName other)
		{
			return default(bool);
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x00011688 File Offset: 0x0000F888
		[Token(Token = "0x600187A")]
		[Address(RVA = "0x4B2D280", Offset = "0x4B2BE80", VA = "0x184B2D280", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x000116A0 File Offset: 0x0000F8A0
		[Token(Token = "0x600187B")]
		[Address(RVA = "0x4B2D460", Offset = "0x4B2C060", VA = "0x184B2D460")]
		public static bool operator ==(HashAlgorithmName left, HashAlgorithmName right)
		{
			return default(bool);
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x000116B8 File Offset: 0x0000F8B8
		[Token(Token = "0x600187C")]
		[Address(RVA = "0x4B2D470", Offset = "0x4B2C070", VA = "0x184B2D470")]
		public static bool operator !=(HashAlgorithmName left, HashAlgorithmName right)
		{
			return default(bool);
		}

		// Token: 0x04000D88 RID: 3464
		[Token(Token = "0x4000D88")]
		[FieldOffset(Offset = "0x0")]
		private readonly string _name;
	}
}
