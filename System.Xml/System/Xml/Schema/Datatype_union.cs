using System;
using Il2CppDummyDll;

namespace System.Xml.Schema
{
	// Token: 0x020000E0 RID: 224
	[Token(Token = "0x20000E0")]
	internal class Datatype_union : Datatype_anySimpleType
	{
		// Token: 0x06000897 RID: 2199 RVA: 0x00004AA0 File Offset: 0x00002CA0
		[Token(Token = "0x6000897")]
		[Address(RVA = "0x5001820", Offset = "0x5000420", VA = "0x185001820")]
		internal bool HasAtomicMembers()
		{
			return default(bool);
		}

		// Token: 0x040004CE RID: 1230
		[Token(Token = "0x40004CE")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type atomicValueType;

		// Token: 0x040004CF RID: 1231
		[Token(Token = "0x40004CF")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Type listValueType;

		// Token: 0x040004D0 RID: 1232
		[Token(Token = "0x40004D0")]
		[FieldOffset(Offset = "0x38")]
		private XmlSchemaSimpleType[] types;
	}
}
