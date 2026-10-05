using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x0200011C RID: 284
	[Token(Token = "0x200011C")]
	internal class Datatype_uuid : Datatype_anySimpleType
	{
		// Token: 0x170002AC RID: 684
		// (get) Token: 0x060009C0 RID: 2496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AC")]
		public override Type ValueType
		{
			[Token(Token = "0x60009C0")]
			[Address(RVA = "0x50034D0", Offset = "0x50020D0", VA = "0x1850034D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x060009C1 RID: 2497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AD")]
		internal override Type ListValueType
		{
			[Token(Token = "0x60009C1")]
			[Address(RVA = "0x5003480", Offset = "0x5002080", VA = "0x185003480", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x00005388 File Offset: 0x00003588
		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x5003060", Offset = "0x5001C60", VA = "0x185003060", Slot = "11")]
		internal override int Compare(object value1, object value2)
		{
			return 0;
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x50030F0", Offset = "0x5001CF0", VA = "0x1850030F0", Slot = "6")]
		public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr)
		{
			return null;
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x5003260", Offset = "0x5001E60", VA = "0x185003260", Slot = "12")]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			return null;
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x5003400", Offset = "0x5002000", VA = "0x185003400")]
		public Datatype_uuid()
		{
		}

		// Token: 0x0400050B RID: 1291
		[Token(Token = "0x400050B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type atomicValueType;

		// Token: 0x0400050C RID: 1292
		[Token(Token = "0x400050C")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Type listValueType;
	}
}
