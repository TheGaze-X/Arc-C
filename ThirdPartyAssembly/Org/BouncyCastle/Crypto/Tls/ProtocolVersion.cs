using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000270 RID: 624
	[Token(Token = "0x2000270")]
	public sealed class ProtocolVersion
	{
		// Token: 0x060014F5 RID: 5365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014F5")]
		[Address(RVA = "0x524D820", Offset = "0x524C420", VA = "0x18524D820")]
		private ProtocolVersion(int v, string name)
		{
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x060014F6 RID: 5366 RVA: 0x0000ADB8 File Offset: 0x00008FB8
		[Token(Token = "0x170002E3")]
		public int FullVersion
		{
			[Token(Token = "0x60014F6")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x060014F7 RID: 5367 RVA: 0x0000ADD0 File Offset: 0x00008FD0
		[Token(Token = "0x170002E4")]
		public int MajorVersion
		{
			[Token(Token = "0x60014F7")]
			[Address(RVA = "0x524D910", Offset = "0x524C510", VA = "0x18524D910")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x060014F8 RID: 5368 RVA: 0x0000ADE8 File Offset: 0x00008FE8
		[Token(Token = "0x170002E5")]
		public int MinorVersion
		{
			[Token(Token = "0x60014F8")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x060014F9 RID: 5369 RVA: 0x0000AE00 File Offset: 0x00009000
		[Token(Token = "0x170002E6")]
		public bool IsDtls
		{
			[Token(Token = "0x60014F9")]
			[Address(RVA = "0x524D870", Offset = "0x524C470", VA = "0x18524D870")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x060014FA RID: 5370 RVA: 0x0000AE18 File Offset: 0x00009018
		[Token(Token = "0x170002E7")]
		public bool IsSsl
		{
			[Token(Token = "0x60014FA")]
			[Address(RVA = "0x524D890", Offset = "0x524C490", VA = "0x18524D890")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x060014FB RID: 5371 RVA: 0x0000AE30 File Offset: 0x00009030
		[Token(Token = "0x170002E8")]
		public bool IsTls
		{
			[Token(Token = "0x60014FB")]
			[Address(RVA = "0x524D8F0", Offset = "0x524C4F0", VA = "0x18524D8F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014FC")]
		[Address(RVA = "0x524CF80", Offset = "0x524BB80", VA = "0x18524CF80")]
		public ProtocolVersion GetEquivalentTLSVersion()
		{
			return null;
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x0000AE48 File Offset: 0x00009048
		[Token(Token = "0x60014FD")]
		[Address(RVA = "0x524D460", Offset = "0x524C060", VA = "0x18524D460")]
		public bool IsEqualOrEarlierVersionOf(ProtocolVersion version)
		{
			return default(bool);
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x0000AE60 File Offset: 0x00009060
		[Token(Token = "0x60014FE")]
		[Address(RVA = "0x524D4C0", Offset = "0x524C0C0", VA = "0x18524D4C0")]
		public bool IsLaterVersionOf(ProtocolVersion version)
		{
			return default(bool);
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x0000AE78 File Offset: 0x00009078
		[Token(Token = "0x60014FF")]
		[Address(RVA = "0x524CEE0", Offset = "0x524BAE0", VA = "0x18524CEE0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x0000AE90 File Offset: 0x00009090
		[Token(Token = "0x6001500")]
		[Address(RVA = "0x524CEC0", Offset = "0x524BAC0", VA = "0x18524CEC0")]
		public bool Equals(ProtocolVersion other)
		{
			return default(bool);
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x0000AEA8 File Offset: 0x000090A8
		[Token(Token = "0x6001501")]
		[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001502")]
		[Address(RVA = "0x524D1A0", Offset = "0x524BDA0", VA = "0x18524D1A0")]
		public static ProtocolVersion Get(int major, int minor)
		{
			return null;
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001503")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001504")]
		[Address(RVA = "0x524D040", Offset = "0x524BC40", VA = "0x18524D040")]
		private static ProtocolVersion GetUnknownVersion(int major, int minor, string prefix)
		{
			return null;
		}

		// Token: 0x04000BAB RID: 2987
		[Token(Token = "0x4000BAB")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ProtocolVersion SSLv3;

		// Token: 0x04000BAC RID: 2988
		[Token(Token = "0x4000BAC")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ProtocolVersion TLSv10;

		// Token: 0x04000BAD RID: 2989
		[Token(Token = "0x4000BAD")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ProtocolVersion TLSv11;

		// Token: 0x04000BAE RID: 2990
		[Token(Token = "0x4000BAE")]
		[FieldOffset(Offset = "0x18")]
		public static readonly ProtocolVersion TLSv12;

		// Token: 0x04000BAF RID: 2991
		[Token(Token = "0x4000BAF")]
		[FieldOffset(Offset = "0x20")]
		public static readonly ProtocolVersion DTLSv10;

		// Token: 0x04000BB0 RID: 2992
		[Token(Token = "0x4000BB0")]
		[FieldOffset(Offset = "0x28")]
		public static readonly ProtocolVersion DTLSv12;

		// Token: 0x04000BB1 RID: 2993
		[Token(Token = "0x4000BB1")]
		[FieldOffset(Offset = "0x10")]
		private readonly int version;

		// Token: 0x04000BB2 RID: 2994
		[Token(Token = "0x4000BB2")]
		[FieldOffset(Offset = "0x18")]
		private readonly string name;
	}
}
