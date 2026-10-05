using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.X9
{
	// Token: 0x020003FC RID: 1020
	[Token(Token = "0x20003FC")]
	public abstract class X9ECParametersHolder
	{
		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x060021B6 RID: 8630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000453")]
		public X9ECParameters Parameters
		{
			[Token(Token = "0x60021B6")]
			[Address(RVA = "0x5352FD0", Offset = "0x5351BD0", VA = "0x185352FD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060021B7 RID: 8631
		[Token(Token = "0x60021B7")]
		protected abstract X9ECParameters CreateParameters();

		// Token: 0x060021B8 RID: 8632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021B8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected X9ECParametersHolder()
		{
		}

		// Token: 0x04001186 RID: 4486
		[Token(Token = "0x4001186")]
		[FieldOffset(Offset = "0x10")]
		private X9ECParameters parameters;
	}
}
