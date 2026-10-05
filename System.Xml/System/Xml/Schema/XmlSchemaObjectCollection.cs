using System;
using System.Collections;
using System.Reflection;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x0200014C RID: 332
	[Token(Token = "0x200014C")]
	[DefaultMember("Item")]
	public class XmlSchemaObjectCollection : CollectionBase
	{
		// Token: 0x06000AF7 RID: 2807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0x4A887E0", Offset = "0x4A873E0", VA = "0x184A887E0")]
		public XmlSchemaObjectCollection()
		{
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x000059B8 File Offset: 0x00003BB8
		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0x5020A10", Offset = "0x501F610", VA = "0x185020A10")]
		public int Add(XmlSchemaObject item)
		{
			return 0;
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0x5020B50", Offset = "0x501F750", VA = "0x185020B50", Slot = "21")]
		protected override void OnInsert(int index, object item)
		{
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0x5020C10", Offset = "0x501F810", VA = "0x185020C10", Slot = "20")]
		protected override void OnSet(int index, object oldValue, object newValue)
		{
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x5020B00", Offset = "0x501F700", VA = "0x185020B00", Slot = "22")]
		protected override void OnClear()
		{
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0x5020BB0", Offset = "0x501F7B0", VA = "0x185020BB0", Slot = "23")]
		protected override void OnRemove(int index, object item)
		{
		}

		// Token: 0x040005A0 RID: 1440
		[Token(Token = "0x40005A0")]
		[FieldOffset(Offset = "0x18")]
		private XmlSchemaObject parent;
	}
}
