using System;
using Il2CppDummyDll;

namespace System.Xml.Serialization
{
	// Token: 0x020000BB RID: 187
	[Token(Token = "0x20000BB")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
	public class XmlAttributeAttribute : Attribute
	{
		// Token: 0x060007F5 RID: 2037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public XmlAttributeAttribute(string attributeName)
		{
		}

		// Token: 0x04000408 RID: 1032
		[Token(Token = "0x4000408")]
		[FieldOffset(Offset = "0x10")]
		private string attributeName;
	}
}
