using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x0200014B RID: 331
	[Token(Token = "0x200014B")]
	public abstract class XmlSchemaObject
	{
		// Token: 0x06000AF3 RID: 2803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		internal virtual void OnAdd(XmlSchemaObjectCollection container, object item)
		{
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		internal virtual void OnRemove(XmlSchemaObjectCollection container, object item)
		{
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		internal virtual void OnClear(XmlSchemaObjectCollection container)
		{
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected XmlSchemaObject()
		{
		}
	}
}
