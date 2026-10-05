using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x0200010A RID: 266
	[Token(Token = "0x200010A")]
	internal class Datatype_nonPositiveInteger : Datatype_integer
	{
		// Token: 0x1700027E RID: 638
		// (get) Token: 0x0600095A RID: 2394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700027E")]
		internal override FacetsChecker FacetsChecker
		{
			[Token(Token = "0x600095A")]
			[Address(RVA = "0x5000D50", Offset = "0x4FFF950", VA = "0x185000D50", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x00005160 File Offset: 0x00003360
		[Token(Token = "0x1700027F")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x600095B")]
			[Address(RVA = "0x5000DA0", Offset = "0x4FFF9A0", VA = "0x185000DA0", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600095C")]
		[Address(RVA = "0x5000320", Offset = "0x4FFEF20", VA = "0x185000320")]
		public Datatype_nonPositiveInteger()
		{
		}

		// Token: 0x040004EB RID: 1259
		[Token(Token = "0x40004EB")]
		[FieldOffset(Offset = "0x0")]
		private static readonly FacetsChecker numeric10FacetsChecker;
	}
}
