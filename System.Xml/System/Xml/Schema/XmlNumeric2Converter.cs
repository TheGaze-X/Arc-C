using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x0200015F RID: 351
	[Token(Token = "0x200015F")]
	internal class XmlNumeric2Converter : XmlBaseConverter
	{
		// Token: 0x06000BEE RID: 3054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BEE")]
		[Address(RVA = "0x501E610", Offset = "0x501D210", VA = "0x18501E610")]
		protected XmlNumeric2Converter(XmlSchemaType schemaType)
		{
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BEF")]
		[Address(RVA = "0x501D6F0", Offset = "0x501C2F0", VA = "0x18501D6F0")]
		public static XmlValueConverter Create(XmlSchemaType schemaType)
		{
			return null;
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x00006168 File Offset: 0x00004368
		[Token(Token = "0x6000BF0")]
		[Address(RVA = "0x501DB30", Offset = "0x501C730", VA = "0x18501DB30", Slot = "28")]
		public override double ToDouble(string value)
		{
			return 0.0;
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x00006180 File Offset: 0x00004380
		[Token(Token = "0x6000BF1")]
		[Address(RVA = "0x501D780", Offset = "0x501C380", VA = "0x18501D780", Slot = "29")]
		public override double ToDouble(object value)
		{
			return 0.0;
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x00006198 File Offset: 0x00004398
		[Token(Token = "0x6000BF2")]
		[Address(RVA = "0x501DCF0", Offset = "0x501C8F0", VA = "0x18501DCF0", Slot = "30")]
		public override float ToSingle(double value)
		{
			return 0f;
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x000061B0 File Offset: 0x000043B0
		[Token(Token = "0x6000BF3")]
		[Address(RVA = "0x501DC10", Offset = "0x501C810", VA = "0x18501DC10", Slot = "31")]
		public override float ToSingle(string value)
		{
			return 0f;
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x000061C8 File Offset: 0x000043C8
		[Token(Token = "0x6000BF4")]
		[Address(RVA = "0x501DD00", Offset = "0x501C900", VA = "0x18501DD00", Slot = "32")]
		public override float ToSingle(object value)
		{
			return 0f;
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BF5")]
		[Address(RVA = "0x501E0E0", Offset = "0x501CCE0", VA = "0x18501E0E0", Slot = "48")]
		public override string ToString(double value)
		{
			return null;
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BF6")]
		[Address(RVA = "0x501E580", Offset = "0x501D180", VA = "0x18501E580", Slot = "47")]
		public override string ToString(float value)
		{
			return null;
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BF7")]
		[Address(RVA = "0x501E1A0", Offset = "0x501CDA0", VA = "0x18501E1A0", Slot = "52")]
		public override string ToString(object value, IXmlNamespaceResolver nsResolver)
		{
			return null;
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BF8")]
		[Address(RVA = "0x501D250", Offset = "0x501BE50", VA = "0x18501D250", Slot = "57")]
		public override object ChangeType(double value, Type destinationType)
		{
			return null;
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BF9")]
		[Address(RVA = "0x501C220", Offset = "0x501AE20", VA = "0x18501C220", Slot = "59")]
		public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			return null;
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BFA")]
		[Address(RVA = "0x501C710", Offset = "0x501B310", VA = "0x18501C710", Slot = "61")]
		public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			return null;
		}
	}
}
