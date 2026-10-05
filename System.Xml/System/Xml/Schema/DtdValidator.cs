using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x0200011D RID: 285
	[Token(Token = "0x200011D")]
	internal sealed class DtdValidator : BaseValidator
	{
		// Token: 0x060009C7 RID: 2503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x5004060", Offset = "0x5002C60", VA = "0x185004060")]
		public static void SetDefaultTypedValue(SchemaAttDef attdef, IDtdParserAdapter readerAdapter)
		{
		}

		// Token: 0x0400050D RID: 1293
		[Token(Token = "0x400050D")]
		[FieldOffset(Offset = "0x0")]
		private static DtdValidator.NamespaceManager namespaceManager;

		// Token: 0x0200011E RID: 286
		[Token(Token = "0x200011E")]
		private class NamespaceManager : XmlNamespaceManager
		{
			// Token: 0x060009C9 RID: 2505 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009C9")]
			[Address(RVA = "0x5B5210", Offset = "0x5B3E10", VA = "0x1805B5210", Slot = "14")]
			public override string LookupNamespace(string prefix)
			{
				return null;
			}

			// Token: 0x060009CA RID: 2506 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60009CA")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public NamespaceManager()
			{
			}
		}
	}
}
