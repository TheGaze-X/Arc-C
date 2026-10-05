using System;
using System.Runtime.InteropServices;
using System.Xml.XPath;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000138 RID: 312
	[Token(Token = "0x2000138")]
	public sealed class XmlAtomicValue : XPathItem, ICloneable
	{
		// Token: 0x06000AA0 RID: 2720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x500A510", Offset = "0x5009110", VA = "0x18500A510")]
		internal XmlAtomicValue(XmlSchemaType xmlType, bool value)
		{
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x500AD70", Offset = "0x5009970", VA = "0x18500AD70")]
		internal XmlAtomicValue(XmlSchemaType xmlType, DateTime value)
		{
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x500AE10", Offset = "0x5009A10", VA = "0x18500AE10")]
		internal XmlAtomicValue(XmlSchemaType xmlType, double value)
		{
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x500A9B0", Offset = "0x50095B0", VA = "0x18500A9B0")]
		internal XmlAtomicValue(XmlSchemaType xmlType, int value)
		{
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x500A910", Offset = "0x5009510", VA = "0x18500A910")]
		internal XmlAtomicValue(XmlSchemaType xmlType, long value)
		{
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x500AC70", Offset = "0x5009870", VA = "0x18500AC70")]
		internal XmlAtomicValue(XmlSchemaType xmlType, string value)
		{
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x500A6B0", Offset = "0x50092B0", VA = "0x18500A6B0")]
		internal XmlAtomicValue(XmlSchemaType xmlType, string value, IXmlNamespaceResolver nsResolver)
		{
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x500A5B0", Offset = "0x50091B0", VA = "0x18500A5B0")]
		internal XmlAtomicValue(XmlSchemaType xmlType, object value)
		{
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x500AA50", Offset = "0x5009650", VA = "0x18500AA50")]
		internal XmlAtomicValue(XmlSchemaType xmlType, object value, IXmlNamespaceResolver nsResolver)
		{
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120", Slot = "15")]
		private object Clone()
		{
			return null;
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000AAA RID: 2730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000305")]
		public override XmlSchemaType XmlType
		{
			[Token(Token = "0x6000AAA")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000306")]
		public override Type ValueType
		{
			[Token(Token = "0x6000AAB")]
			[Address(RVA = "0x500B870", Offset = "0x500A470", VA = "0x18500B870", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000AAC RID: 2732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000307")]
		public override object TypedValue
		{
			[Token(Token = "0x6000AAC")]
			[Address(RVA = "0x500AEB0", Offset = "0x5009AB0", VA = "0x18500AEB0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x000058C8 File Offset: 0x00003AC8
		[Token(Token = "0x17000308")]
		public override bool ValueAsBoolean
		{
			[Token(Token = "0x6000AAD")]
			[Address(RVA = "0x500B060", Offset = "0x5009C60", VA = "0x18500B060", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000AAE RID: 2734 RVA: 0x000058E0 File Offset: 0x00003AE0
		[Token(Token = "0x17000309")]
		public override DateTime ValueAsDateTime
		{
			[Token(Token = "0x6000AAE")]
			[Address(RVA = "0x500B1F0", Offset = "0x5009DF0", VA = "0x18500B1F0", Slot = "9")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x000058F8 File Offset: 0x00003AF8
		[Token(Token = "0x1700030A")]
		public override double ValueAsDouble
		{
			[Token(Token = "0x6000AAF")]
			[Address(RVA = "0x500B390", Offset = "0x5009F90", VA = "0x18500B390", Slot = "10")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x00005910 File Offset: 0x00003B10
		[Token(Token = "0x1700030B")]
		public override int ValueAsInt
		{
			[Token(Token = "0x6000AB0")]
			[Address(RVA = "0x500B540", Offset = "0x500A140", VA = "0x18500B540", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x00005928 File Offset: 0x00003B28
		[Token(Token = "0x1700030C")]
		public override long ValueAsLong
		{
			[Token(Token = "0x6000AB1")]
			[Address(RVA = "0x500B6D0", Offset = "0x500A2D0", VA = "0x18500B6D0", Slot = "12")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0x500A320", Offset = "0x5008F20", VA = "0x18500A320", Slot = "14")]
		public override object ValueAs(Type type, IXmlNamespaceResolver nsResolver)
		{
			return null;
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700030D")]
		public override string Value
		{
			[Token(Token = "0x6000AB3")]
			[Address(RVA = "0x500B8C0", Offset = "0x500A4C0", VA = "0x18500B8C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0x4FEC330", Offset = "0x4FEAF30", VA = "0x184FEC330", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0x500A270", Offset = "0x5008E70", VA = "0x18500A270")]
		private string GetPrefixFromQName(string value)
		{
			return null;
		}

		// Token: 0x04000563 RID: 1379
		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private XmlSchemaType xmlType;

		// Token: 0x04000564 RID: 1380
		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object objVal;

		// Token: 0x04000565 RID: 1381
		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TypeCode clrType;

		// Token: 0x04000566 RID: 1382
		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private XmlAtomicValue.Union unionVal;

		// Token: 0x04000567 RID: 1383
		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private XmlAtomicValue.NamespacePrefixForQName nsPrefix;

		// Token: 0x02000139 RID: 313
		[Token(Token = "0x2000139")]
		[StructLayout(2)]
		private struct Union
		{
			// Token: 0x04000568 RID: 1384
			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool boolVal;

			// Token: 0x04000569 RID: 1385
			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public double dblVal;

			// Token: 0x0400056A RID: 1386
			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public long i64Val;

			// Token: 0x0400056B RID: 1387
			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int i32Val;

			// Token: 0x0400056C RID: 1388
			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public DateTime dtVal;
		}

		// Token: 0x0200013A RID: 314
		[Token(Token = "0x200013A")]
		private class NamespacePrefixForQName : IXmlNamespaceResolver
		{
			// Token: 0x06000AB6 RID: 2742 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000AB6")]
			[Address(RVA = "0x5005CF0", Offset = "0x50048F0", VA = "0x185005CF0")]
			public NamespacePrefixForQName(string prefix, string ns)
			{
			}

			// Token: 0x06000AB7 RID: 2743 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000AB7")]
			[Address(RVA = "0x5005C80", Offset = "0x5004880", VA = "0x185005C80", Slot = "4")]
			public string LookupNamespace(string prefix)
			{
				return null;
			}

			// Token: 0x06000AB8 RID: 2744 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000AB8")]
			[Address(RVA = "0x5005CC0", Offset = "0x50048C0", VA = "0x185005CC0", Slot = "5")]
			public string LookupPrefix(string namespaceName)
			{
				return null;
			}

			// Token: 0x0400056D RID: 1389
			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string prefix;

			// Token: 0x0400056E RID: 1390
			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string ns;
		}
	}
}
