using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003D0 RID: 976
	[Token(Token = "0x20003D0")]
	public class DerUtf8String : DerStringBase
	{
		// Token: 0x060020F7 RID: 8439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F7")]
		[Address(RVA = "0x5339350", Offset = "0x5337F50", VA = "0x185339350")]
		public static DerUtf8String GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x060020F8 RID: 8440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F8")]
		[Address(RVA = "0x5339140", Offset = "0x5337D40", VA = "0x185339140")]
		public static DerUtf8String GetInstance(Asn1TaggedObject obj, bool isExplicit)
		{
			return null;
		}

		// Token: 0x060020F9 RID: 8441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020F9")]
		[Address(RVA = "0x5339560", Offset = "0x5338160", VA = "0x185339560")]
		public DerUtf8String(byte[] str)
		{
		}

		// Token: 0x060020FA RID: 8442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020FA")]
		[Address(RVA = "0x53394D0", Offset = "0x53380D0", VA = "0x1853394D0")]
		public DerUtf8String(string str)
		{
		}

		// Token: 0x060020FB RID: 8443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020FB")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "10")]
		public override string GetString()
		{
			return null;
		}

		// Token: 0x060020FC RID: 8444 RVA: 0x0000F600 File Offset: 0x0000D800
		[Token(Token = "0x60020FC")]
		[Address(RVA = "0x5338FA0", Offset = "0x5337BA0", VA = "0x185338FA0", Slot = "7")]
		protected override bool Asn1Equals(Asn1Object asn1Object)
		{
			return default(bool);
		}

		// Token: 0x060020FD RID: 8445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020FD")]
		[Address(RVA = "0x5339050", Offset = "0x5337C50", VA = "0x185339050", Slot = "6")]
		internal override void Encode(DerOutputStream derOut)
		{
		}

		// Token: 0x0400114F RID: 4431
		[Token(Token = "0x400114F")]
		[FieldOffset(Offset = "0x10")]
		private readonly string str;
	}
}
