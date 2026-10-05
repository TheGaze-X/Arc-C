using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000110 RID: 272
	[Token(Token = "0x2000110")]
	internal class Datatype_nonNegativeInteger : Datatype_integer
	{
		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000982 RID: 2434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000292")]
		internal override FacetsChecker FacetsChecker
		{
			[Token(Token = "0x6000982")]
			[Address(RVA = "0x5000BF0", Offset = "0x4FFF7F0", VA = "0x185000BF0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x00005250 File Offset: 0x00003450
		[Token(Token = "0x17000293")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x6000983")]
			[Address(RVA = "0x4F24220", Offset = "0x4F22E20", VA = "0x184F24220", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000984")]
		[Address(RVA = "0x5000320", Offset = "0x4FFEF20", VA = "0x185000320")]
		public Datatype_nonNegativeInteger()
		{
		}

		// Token: 0x040004F9 RID: 1273
		[Token(Token = "0x40004F9")]
		[FieldOffset(Offset = "0x0")]
		private static readonly FacetsChecker numeric10FacetsChecker;
	}
}
