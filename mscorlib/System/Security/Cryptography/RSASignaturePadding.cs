using System;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x020002E6 RID: 742
	[Token(Token = "0x20002E6")]
	public sealed class RSASignaturePadding : System.IEquatable<RSASignaturePadding>
	{
		// Token: 0x0600188F RID: 6287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600188F")]
		[Address(RVA = "0x50EDE0", Offset = "0x50D9E0", VA = "0x18050EDE0")]
		private RSASignaturePadding(RSASignaturePaddingMode mode)
		{
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06001890 RID: 6288 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000291")]
		public static RSASignaturePadding Pkcs1
		{
			[Token(Token = "0x6001890")]
			[Address(RVA = "0x4B32A80", Offset = "0x4B31680", VA = "0x184B32A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06001891 RID: 6289 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000292")]
		public static RSASignaturePadding Pss
		{
			[Token(Token = "0x6001891")]
			[Address(RVA = "0x4B32AD0", Offset = "0x4B316D0", VA = "0x184B32AD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06001892 RID: 6290 RVA: 0x00011790 File Offset: 0x0000F990
		[Token(Token = "0x17000293")]
		public RSASignaturePaddingMode Mode
		{
			[Token(Token = "0x6001892")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return RSASignaturePaddingMode.Pkcs1;
			}
		}

		// Token: 0x06001893 RID: 6291 RVA: 0x000117A8 File Offset: 0x0000F9A8
		[Token(Token = "0x6001893")]
		[Address(RVA = "0x4B32910", Offset = "0x4B31510", VA = "0x184B32910", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x000117C0 File Offset: 0x0000F9C0
		[Token(Token = "0x6001894")]
		[Address(RVA = "0x4B32800", Offset = "0x4B31400", VA = "0x184B32800", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x000117D8 File Offset: 0x0000F9D8
		[Token(Token = "0x6001895")]
		[Address(RVA = "0x4B32860", Offset = "0x4B31460", VA = "0x184B32860", Slot = "4")]
		public bool Equals(RSASignaturePadding other)
		{
			return default(bool);
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x000117F0 File Offset: 0x0000F9F0
		[Token(Token = "0x6001896")]
		[Address(RVA = "0x4B32B20", Offset = "0x4B31720", VA = "0x184B32B20")]
		public static bool operator ==(RSASignaturePadding left, RSASignaturePadding right)
		{
			return default(bool);
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x00011808 File Offset: 0x0000FA08
		[Token(Token = "0x6001897")]
		[Address(RVA = "0x4B32B40", Offset = "0x4B31740", VA = "0x184B32B40")]
		public static bool operator !=(RSASignaturePadding left, RSASignaturePadding right)
		{
			return default(bool);
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001898")]
		[Address(RVA = "0x4B32920", Offset = "0x4B31520", VA = "0x184B32920", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600189A")]
		[Address(RVA = "0x4B32A50", Offset = "0x4B31650", VA = "0x184B32A50")]
		internal RSASignaturePadding()
		{
		}

		// Token: 0x04000D93 RID: 3475
		[Token(Token = "0x4000D93")]
		[FieldOffset(Offset = "0x0")]
		private static readonly RSASignaturePadding s_pkcs1;

		// Token: 0x04000D94 RID: 3476
		[Token(Token = "0x4000D94")]
		[FieldOffset(Offset = "0x8")]
		private static readonly RSASignaturePadding s_pss;

		// Token: 0x04000D95 RID: 3477
		[Token(Token = "0x4000D95")]
		[FieldOffset(Offset = "0x10")]
		private readonly RSASignaturePaddingMode _mode;
	}
}
