using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x0200010B RID: 267
	[Token(Token = "0x200010B")]
	internal class Datatype_negativeInteger : Datatype_nonPositiveInteger
	{
		// Token: 0x17000280 RID: 640
		// (get) Token: 0x0600095E RID: 2398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000280")]
		internal override FacetsChecker FacetsChecker
		{
			[Token(Token = "0x600095E")]
			[Address(RVA = "0x5000A80", Offset = "0x4FFF680", VA = "0x185000A80", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x0600095F RID: 2399 RVA: 0x00005178 File Offset: 0x00003378
		[Token(Token = "0x17000281")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x600095F")]
			[Address(RVA = "0x5000AD0", Offset = "0x4FFF6D0", VA = "0x185000AD0", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000960")]
		[Address(RVA = "0x5000A00", Offset = "0x4FFF600", VA = "0x185000A00")]
		public Datatype_negativeInteger()
		{
		}

		// Token: 0x040004EC RID: 1260
		[Token(Token = "0x40004EC")]
		[FieldOffset(Offset = "0x0")]
		private static readonly FacetsChecker numeric10FacetsChecker;
	}
}
