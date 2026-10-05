using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x02000147 RID: 327
	[Token(Token = "0x2000147")]
	[Serializable]
	public class XmlSchemaException : SystemException
	{
		// Token: 0x06000ADC RID: 2780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x501FEA0", Offset = "0x501EAA0", VA = "0x18501FEA0")]
		protected XmlSchemaException(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0x501FD50", Offset = "0x501E950", VA = "0x18501FD50", Slot = "12")]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x5020410", Offset = "0x501F010", VA = "0x185020410")]
		public XmlSchemaException()
		{
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x5020700", Offset = "0x501F300", VA = "0x185020700")]
		public XmlSchemaException(string message)
		{
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0x50204E0", Offset = "0x501F0E0", VA = "0x1850204E0")]
		public XmlSchemaException(string message, Exception innerException)
		{
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0x5020720", Offset = "0x501F320", VA = "0x185020720")]
		public XmlSchemaException(string message, Exception innerException, int lineNumber, int linePosition)
		{
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0x5020500", Offset = "0x501F100", VA = "0x185020500")]
		internal XmlSchemaException(string res, string arg)
		{
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0x5020310", Offset = "0x501EF10", VA = "0x185020310")]
		internal XmlSchemaException(string res, string arg, string sourceUri, int lineNumber, int linePosition)
		{
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x5020640", Offset = "0x501F240", VA = "0x185020640")]
		internal XmlSchemaException(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition, XmlSchemaObject source)
		{
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x501FD00", Offset = "0x501E900", VA = "0x18501FD00")]
		internal static string CreateMessage(string res, string[] args)
		{
			return null;
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700031F")]
		public override string Message
		{
			[Token(Token = "0x6000AE6")]
			[Address(RVA = "0x5020840", Offset = "0x501F440", VA = "0x185020840", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000591 RID: 1425
		[Token(Token = "0x4000591")]
		[FieldOffset(Offset = "0x90")]
		private string res;

		// Token: 0x04000592 RID: 1426
		[Token(Token = "0x4000592")]
		[FieldOffset(Offset = "0x98")]
		private string[] args;

		// Token: 0x04000593 RID: 1427
		[Token(Token = "0x4000593")]
		[FieldOffset(Offset = "0xA0")]
		private string sourceUri;

		// Token: 0x04000594 RID: 1428
		[Token(Token = "0x4000594")]
		[FieldOffset(Offset = "0xA8")]
		private int lineNumber;

		// Token: 0x04000595 RID: 1429
		[Token(Token = "0x4000595")]
		[FieldOffset(Offset = "0xAC")]
		private int linePosition;

		// Token: 0x04000596 RID: 1430
		[Token(Token = "0x4000596")]
		[FieldOffset(Offset = "0xB0")]
		[NonSerialized]
		private XmlSchemaObject sourceSchemaObject;

		// Token: 0x04000597 RID: 1431
		[Token(Token = "0x4000597")]
		[FieldOffset(Offset = "0xB8")]
		private string message;
	}
}
