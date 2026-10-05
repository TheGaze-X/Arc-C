using System;
using Il2CppDummyDll;

namespace System.Xml.Serialization
{
	// Token: 0x020000BC RID: 188
	[Token(Token = "0x20000BC")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = true)]
	public class XmlElementAttribute : Attribute
	{
		// Token: 0x060007F6 RID: 2038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x4FF5A30", Offset = "0x4FF4630", VA = "0x184FF5A30")]
		public XmlElementAttribute(string elementName, Type type)
		{
		}

		// Token: 0x04000409 RID: 1033
		[Token(Token = "0x4000409")]
		[FieldOffset(Offset = "0x10")]
		private string elementName;

		// Token: 0x0400040A RID: 1034
		[Token(Token = "0x400040A")]
		[FieldOffset(Offset = "0x18")]
		private Type type;

		// Token: 0x0400040B RID: 1035
		[Token(Token = "0x400040B")]
		[FieldOffset(Offset = "0x20")]
		private int order;
	}
}
