using System;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002EB RID: 747
	[Token(Token = "0x20002EB")]
	internal struct HeaderVariantInfo
	{
		// Token: 0x060014A2 RID: 5282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014A2")]
		[Address(RVA = "0x21178B0", Offset = "0x21164B0", VA = "0x1821178B0")]
		internal HeaderVariantInfo(string name, CookieVariant variant)
		{
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x060014A3 RID: 5283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000460")]
		internal string Name
		{
			[Token(Token = "0x60014A3")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x060014A4 RID: 5284 RVA: 0x00009BE8 File Offset: 0x00007DE8
		[Token(Token = "0x17000461")]
		internal CookieVariant Variant
		{
			[Token(Token = "0x60014A4")]
			[Address(RVA = "0x116A510", Offset = "0x1169110", VA = "0x18116A510")]
			get
			{
				return CookieVariant.Unknown;
			}
		}

		// Token: 0x04000B52 RID: 2898
		[Token(Token = "0x4000B52")]
		[FieldOffset(Offset = "0x0")]
		private string m_name;

		// Token: 0x04000B53 RID: 2899
		[Token(Token = "0x4000B53")]
		[FieldOffset(Offset = "0x8")]
		private CookieVariant m_variant;
	}
}
