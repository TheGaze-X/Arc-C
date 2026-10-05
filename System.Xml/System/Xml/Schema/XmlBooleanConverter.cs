using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000161 RID: 353
	[Token(Token = "0x2000161")]
	internal class XmlBooleanConverter : XmlBaseConverter
	{
		// Token: 0x06000C09 RID: 3081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C09")]
		[Address(RVA = "0x5014460", Offset = "0x5013060", VA = "0x185014460")]
		protected XmlBooleanConverter(XmlSchemaType schemaType)
		{
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C0A")]
		[Address(RVA = "0x5013CA0", Offset = "0x50128A0", VA = "0x185013CA0")]
		public static XmlValueConverter Create(XmlSchemaType schemaType)
		{
			return null;
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x00006270 File Offset: 0x00004470
		[Token(Token = "0x6000C0B")]
		[Address(RVA = "0x5014060", Offset = "0x5012C60", VA = "0x185014060", Slot = "8")]
		public override bool ToBoolean(string value)
		{
			return default(bool);
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x00006288 File Offset: 0x00004488
		[Token(Token = "0x6000C0C")]
		[Address(RVA = "0x5013D30", Offset = "0x5012930", VA = "0x185013D30", Slot = "9")]
		public override bool ToBoolean(object value)
		{
			return default(bool);
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C0D")]
		[Address(RVA = "0x5014410", Offset = "0x5013010", VA = "0x185014410", Slot = "43")]
		public override string ToString(bool value)
		{
			return null;
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C0E")]
		[Address(RVA = "0x5014100", Offset = "0x5012D00", VA = "0x185014100", Slot = "52")]
		public override string ToString(object value, IXmlNamespaceResolver nsResolver)
		{
			return null;
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C0F")]
		[Address(RVA = "0x5012B20", Offset = "0x5011720", VA = "0x185012B20", Slot = "53")]
		public override object ChangeType(bool value, Type destinationType)
		{
			return null;
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C10")]
		[Address(RVA = "0x5013810", Offset = "0x5012410", VA = "0x185013810", Slot = "59")]
		public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			return null;
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C11")]
		[Address(RVA = "0x5012F60", Offset = "0x5011B60", VA = "0x185012F60", Slot = "61")]
		public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			return null;
		}
	}
}
