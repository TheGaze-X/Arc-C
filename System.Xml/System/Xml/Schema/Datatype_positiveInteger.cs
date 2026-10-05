using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000115 RID: 277
	[Token(Token = "0x2000115")]
	internal class Datatype_positiveInteger : Datatype_nonNegativeInteger
	{
		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A4")]
		internal override FacetsChecker FacetsChecker
		{
			[Token(Token = "0x60009A6")]
			[Address(RVA = "0x5000F50", Offset = "0x4FFFB50", VA = "0x185000F50", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x00005328 File Offset: 0x00003528
		[Token(Token = "0x170002A5")]
		public override XmlTypeCode TypeCode
		{
			[Token(Token = "0x60009A7")]
			[Address(RVA = "0x3D28700", Offset = "0x3D27300", VA = "0x183D28700", Slot = "8")]
			get
			{
				return XmlTypeCode.None;
			}
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x5000ED0", Offset = "0x4FFFAD0", VA = "0x185000ED0")]
		public Datatype_positiveInteger()
		{
		}

		// Token: 0x04000506 RID: 1286
		[Token(Token = "0x4000506")]
		[FieldOffset(Offset = "0x0")]
		private static readonly FacetsChecker numeric10FacetsChecker;
	}
}
