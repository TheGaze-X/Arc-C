using System;
using Il2CppDummyDll;

namespace System.Xml.Serialization
{
	// Token: 0x020000BF RID: 191
	[Token(Token = "0x20000BF")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
	public sealed class XmlSchemaProviderAttribute : Attribute
	{
		// Token: 0x060007F9 RID: 2041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public XmlSchemaProviderAttribute(string methodName)
		{
		}

		// Token: 0x170001ED RID: 493
		// (set) Token: 0x060007FA RID: 2042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001ED")]
		public bool IsAny
		{
			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
			set
			{
			}
		}

		// Token: 0x0400040D RID: 1037
		[Token(Token = "0x400040D")]
		[FieldOffset(Offset = "0x10")]
		private string _methodName;

		// Token: 0x0400040E RID: 1038
		[Token(Token = "0x400040E")]
		[FieldOffset(Offset = "0x18")]
		private bool _isAny;
	}
}
