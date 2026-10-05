using System;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x0200014D RID: 333
	[Token(Token = "0x200014D")]
	public abstract class XmlSchemaParticle : XmlSchemaAnnotated
	{
		// Token: 0x17000328 RID: 808
		// (set) Token: 0x06000AFD RID: 2813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000328")]
		[XmlIgnore]
		public decimal MinOccurs
		{
			[Token(Token = "0x6000AFD")]
			[Address(RVA = "0x5020F90", Offset = "0x501FB90", VA = "0x185020F90")]
			set
			{
			}
		}

		// Token: 0x17000329 RID: 809
		// (set) Token: 0x06000AFE RID: 2814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000329")]
		[XmlIgnore]
		public decimal MaxOccurs
		{
			[Token(Token = "0x6000AFE")]
			[Address(RVA = "0x5020DE0", Offset = "0x501F9E0", VA = "0x185020DE0")]
			set
			{
			}
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0x5020D60", Offset = "0x501F960", VA = "0x185020D60")]
		protected XmlSchemaParticle()
		{
		}

		// Token: 0x040005A1 RID: 1441
		[Token(Token = "0x40005A1")]
		[FieldOffset(Offset = "0x10")]
		private decimal minOccurs;

		// Token: 0x040005A2 RID: 1442
		[Token(Token = "0x40005A2")]
		[FieldOffset(Offset = "0x20")]
		private decimal maxOccurs;

		// Token: 0x040005A3 RID: 1443
		[Token(Token = "0x40005A3")]
		[FieldOffset(Offset = "0x30")]
		private XmlSchemaParticle.Occurs flags;

		// Token: 0x040005A4 RID: 1444
		[Token(Token = "0x40005A4")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly XmlSchemaParticle Empty;

		// Token: 0x0200014E RID: 334
		[Token(Token = "0x200014E")]
		[Flags]
		private enum Occurs
		{
			// Token: 0x040005A6 RID: 1446
			[Token(Token = "0x40005A6")]
			None = 0,
			// Token: 0x040005A7 RID: 1447
			[Token(Token = "0x40005A7")]
			Min = 1,
			// Token: 0x040005A8 RID: 1448
			[Token(Token = "0x40005A8")]
			Max = 2
		}

		// Token: 0x0200014F RID: 335
		[Token(Token = "0x200014F")]
		private class EmptyParticle : XmlSchemaParticle
		{
			// Token: 0x06000B01 RID: 2817 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000B01")]
			[Address(RVA = "0x5004B20", Offset = "0x5003720", VA = "0x185004B20")]
			public EmptyParticle()
			{
			}
		}
	}
}
