using System;
using System.Xml.XPath;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000165 RID: 357
	[Token(Token = "0x2000165")]
	internal class XmlAnyConverter : XmlBaseConverter
	{
		// Token: 0x06000C46 RID: 3142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C46")]
		[Address(RVA = "0x5028B90", Offset = "0x5027790", VA = "0x185028B90")]
		protected XmlAnyConverter(XmlTypeCode typeCode)
		{
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x00006438 File Offset: 0x00004638
		[Token(Token = "0x6000C47")]
		[Address(RVA = "0x5027850", Offset = "0x5026450", VA = "0x185027850", Slot = "9")]
		public override bool ToBoolean(object value)
		{
			return default(bool);
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x00006450 File Offset: 0x00004650
		[Token(Token = "0x6000C48")]
		[Address(RVA = "0x5027CD0", Offset = "0x50268D0", VA = "0x185027CD0", Slot = "39")]
		public override DateTime ToDateTime(object value)
		{
			return default(DateTime);
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x00006468 File Offset: 0x00004668
		[Token(Token = "0x6000C49")]
		[Address(RVA = "0x5027A60", Offset = "0x5026660", VA = "0x185027A60", Slot = "42")]
		public override DateTimeOffset ToDateTimeOffset(object value)
		{
			return default(DateTimeOffset);
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x00006480 File Offset: 0x00004680
		[Token(Token = "0x6000C4A")]
		[Address(RVA = "0x5027EE0", Offset = "0x5026AE0", VA = "0x185027EE0", Slot = "23")]
		public override decimal ToDecimal(object value)
		{
			return 0m;
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x00006498 File Offset: 0x00004698
		[Token(Token = "0x6000C4B")]
		[Address(RVA = "0x5028140", Offset = "0x5026D40", VA = "0x185028140", Slot = "29")]
		public override double ToDouble(object value)
		{
			return 0.0;
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x000064B0 File Offset: 0x000046B0
		[Token(Token = "0x6000C4C")]
		[Address(RVA = "0x5028350", Offset = "0x5026F50", VA = "0x185028350", Slot = "15")]
		public override int ToInt32(object value)
		{
			return 0;
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x000064C8 File Offset: 0x000046C8
		[Token(Token = "0x6000C4D")]
		[Address(RVA = "0x5028560", Offset = "0x5027160", VA = "0x185028560", Slot = "21")]
		public override long ToInt64(object value)
		{
			return 0L;
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x000064E0 File Offset: 0x000046E0
		[Token(Token = "0x6000C4E")]
		[Address(RVA = "0x5028810", Offset = "0x5027410", VA = "0x185028810", Slot = "32")]
		public override float ToSingle(object value)
		{
			return 0f;
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C4F")]
		[Address(RVA = "0x5025470", Offset = "0x5024070", VA = "0x185025470", Slot = "53")]
		public override object ChangeType(bool value, Type destinationType)
		{
			return null;
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C50")]
		[Address(RVA = "0x5025680", Offset = "0x5024280", VA = "0x185025680", Slot = "58")]
		public override object ChangeType(DateTime value, Type destinationType)
		{
			return null;
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C51")]
		[Address(RVA = "0x5024DE0", Offset = "0x50239E0", VA = "0x185024DE0", Slot = "56")]
		public override object ChangeType(decimal value, Type destinationType)
		{
			return null;
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C52")]
		[Address(RVA = "0x5027640", Offset = "0x5026240", VA = "0x185027640", Slot = "57")]
		public override object ChangeType(double value, Type destinationType)
		{
			return null;
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C53")]
		[Address(RVA = "0x5025890", Offset = "0x5024490", VA = "0x185025890", Slot = "54")]
		public override object ChangeType(int value, Type destinationType)
		{
			return null;
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C54")]
		[Address(RVA = "0x5025010", Offset = "0x5023C10", VA = "0x185025010", Slot = "55")]
		public override object ChangeType(long value, Type destinationType)
		{
			return null;
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C55")]
		[Address(RVA = "0x5025220", Offset = "0x5023E20", VA = "0x185025220", Slot = "59")]
		public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			return null;
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C56")]
		[Address(RVA = "0x5025AA0", Offset = "0x50246A0", VA = "0x185025AA0", Slot = "61")]
		public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			return null;
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C57")]
		[Address(RVA = "0x5024AF0", Offset = "0x50236F0", VA = "0x185024AF0")]
		private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			return null;
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C58")]
		[Address(RVA = "0x5024C40", Offset = "0x5023840", VA = "0x185024C40")]
		private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			return null;
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C59")]
		[Address(RVA = "0x5028770", Offset = "0x5027370", VA = "0x185028770")]
		private XPathNavigator ToNavigator(XPathNavigator nav)
		{
			return null;
		}

		// Token: 0x0400062B RID: 1579
		[Token(Token = "0x400062B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly XmlValueConverter Item;

		// Token: 0x0400062C RID: 1580
		[Token(Token = "0x400062C")]
		[FieldOffset(Offset = "0x8")]
		public static readonly XmlValueConverter AnyAtomic;
	}
}
