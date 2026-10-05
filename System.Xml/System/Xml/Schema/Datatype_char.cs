using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x0200011A RID: 282
	[Token(Token = "0x200011A")]
	internal class Datatype_char : Datatype_anySimpleType
	{
		// Token: 0x170002AA RID: 682
		// (get) Token: 0x060009B6 RID: 2486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AA")]
		public override Type ValueType
		{
			[Token(Token = "0x60009B6")]
			[Address(RVA = "0x4FFCC10", Offset = "0x4FFB810", VA = "0x184FFCC10", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AB")]
		internal override Type ListValueType
		{
			[Token(Token = "0x60009B7")]
			[Address(RVA = "0x4FFCBC0", Offset = "0x4FFB7C0", VA = "0x184FFCBC0", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x00005370 File Offset: 0x00003570
		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x4FFC7A0", Offset = "0x4FFB3A0", VA = "0x184FFC7A0", Slot = "11")]
		internal override int Compare(object value1, object value2)
		{
			return 0;
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x4FFC840", Offset = "0x4FFB440", VA = "0x184FFC840", Slot = "6")]
		public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr)
		{
			return null;
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x4FFC9B0", Offset = "0x4FFB5B0", VA = "0x184FFC9B0", Slot = "12")]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			return null;
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x4FFCB40", Offset = "0x4FFB740", VA = "0x184FFCB40")]
		public Datatype_char()
		{
		}

		// Token: 0x04000509 RID: 1289
		[Token(Token = "0x4000509")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type atomicValueType;

		// Token: 0x0400050A RID: 1290
		[Token(Token = "0x400050A")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Type listValueType;
	}
}
