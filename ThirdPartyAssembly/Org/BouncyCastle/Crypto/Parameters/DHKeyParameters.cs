using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002C5 RID: 709
	[Token(Token = "0x20002C5")]
	public class DHKeyParameters : AsymmetricKeyParameter
	{
		// Token: 0x0600184F RID: 6223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600184F")]
		[Address(RVA = "0x5282F10", Offset = "0x5281B10", VA = "0x185282F10")]
		protected DHKeyParameters(bool isPrivate, DHParameters parameters)
		{
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001850")]
		[Address(RVA = "0x5282EC0", Offset = "0x5281AC0", VA = "0x185282EC0")]
		protected DHKeyParameters(bool isPrivate, DHParameters parameters, DerObjectIdentifier algorithmOid)
		{
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06001851 RID: 6225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000344")]
		public DHParameters Parameters
		{
			[Token(Token = "0x6001851")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06001852 RID: 6226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000345")]
		public DerObjectIdentifier AlgorithmOid
		{
			[Token(Token = "0x6001852")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x0000BCD0 File Offset: 0x00009ED0
		[Token(Token = "0x6001853")]
		[Address(RVA = "0x5282D20", Offset = "0x5281920", VA = "0x185282D20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x0000BCE8 File Offset: 0x00009EE8
		[Token(Token = "0x6001854")]
		[Address(RVA = "0x5282E00", Offset = "0x5281A00", VA = "0x185282E00")]
		protected bool Equals(DHKeyParameters other)
		{
			return default(bool);
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x0000BD00 File Offset: 0x00009F00
		[Token(Token = "0x6001855")]
		[Address(RVA = "0x5282E60", Offset = "0x5281A60", VA = "0x185282E60", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000CF6 RID: 3318
		[Token(Token = "0x4000CF6")]
		[FieldOffset(Offset = "0x18")]
		private readonly DHParameters parameters;

		// Token: 0x04000CF7 RID: 3319
		[Token(Token = "0x4000CF7")]
		[FieldOffset(Offset = "0x20")]
		private readonly DerObjectIdentifier algorithmOid;
	}
}
