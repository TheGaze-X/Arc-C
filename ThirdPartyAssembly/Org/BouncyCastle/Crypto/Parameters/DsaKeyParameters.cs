using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002CB RID: 715
	[Token(Token = "0x20002CB")]
	public abstract class DsaKeyParameters : AsymmetricKeyParameter
	{
		// Token: 0x0600187B RID: 6267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600187B")]
		[Address(RVA = "0x52859E0", Offset = "0x52845E0", VA = "0x1852859E0")]
		protected DsaKeyParameters(bool isPrivate, DsaParameters parameters)
		{
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x0600187C RID: 6268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000351")]
		public DsaParameters Parameters
		{
			[Token(Token = "0x600187C")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x0000BE98 File Offset: 0x0000A098
		[Token(Token = "0x600187D")]
		[Address(RVA = "0x5285900", Offset = "0x5284500", VA = "0x185285900", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600187E RID: 6270 RVA: 0x0000BEB0 File Offset: 0x0000A0B0
		[Token(Token = "0x600187E")]
		[Address(RVA = "0x5282E00", Offset = "0x5281A00", VA = "0x185282E00")]
		protected bool Equals(DsaKeyParameters other)
		{
			return default(bool);
		}

		// Token: 0x0600187F RID: 6271 RVA: 0x0000BEC8 File Offset: 0x0000A0C8
		[Token(Token = "0x600187F")]
		[Address(RVA = "0x5282E60", Offset = "0x5281A60", VA = "0x185282E60", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000D05 RID: 3333
		[Token(Token = "0x4000D05")]
		[FieldOffset(Offset = "0x18")]
		private readonly DsaParameters parameters;
	}
}
