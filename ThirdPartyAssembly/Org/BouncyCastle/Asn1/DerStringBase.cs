using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003CB RID: 971
	[Token(Token = "0x20003CB")]
	public abstract class DerStringBase : Asn1Object, IAsn1String
	{
		// Token: 0x060020CF RID: 8399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020CF")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		protected DerStringBase()
		{
		}

		// Token: 0x060020D0 RID: 8400
		[Token(Token = "0x60020D0")]
		public abstract string GetString();

		// Token: 0x060020D1 RID: 8401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020D1")]
		[Address(RVA = "0x4F23820", Offset = "0x4F22420", VA = "0x184F23820", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060020D2 RID: 8402 RVA: 0x0000F540 File Offset: 0x0000D740
		[Token(Token = "0x60020D2")]
		[Address(RVA = "0x5337100", Offset = "0x5335D00", VA = "0x185337100", Slot = "8")]
		protected override int Asn1GetHashCode()
		{
			return 0;
		}
	}
}
