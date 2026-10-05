using System;
using System.Reflection;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200044E RID: 1102
	[Token(Token = "0x200044E")]
	internal sealed class ValueFixup
	{
		// Token: 0x060021E9 RID: 8681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021E9")]
		[Address(RVA = "0x4BC63A0", Offset = "0x4BC4FA0", VA = "0x184BC63A0")]
		internal ValueFixup(System.Array arrayObj, int[] indexMap)
		{
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021EA")]
		[Address(RVA = "0x4BC6400", Offset = "0x4BC5000", VA = "0x184BC6400")]
		internal ValueFixup(object memberObject, string memberName, ReadObjectInfo objectInfo)
		{
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021EB")]
		[Address(RVA = "0x4BC6070", Offset = "0x4BC4C70", VA = "0x184BC6070")]
		internal void Fixup(ParseRecord record, ParseRecord parent)
		{
		}

		// Token: 0x040012DD RID: 4829
		[Token(Token = "0x40012DD")]
		[FieldOffset(Offset = "0x10")]
		internal ValueFixupEnum valueFixupEnum;

		// Token: 0x040012DE RID: 4830
		[Token(Token = "0x40012DE")]
		[FieldOffset(Offset = "0x18")]
		internal System.Array arrayObj;

		// Token: 0x040012DF RID: 4831
		[Token(Token = "0x40012DF")]
		[FieldOffset(Offset = "0x20")]
		internal int[] indexMap;

		// Token: 0x040012E0 RID: 4832
		[Token(Token = "0x40012E0")]
		[FieldOffset(Offset = "0x28")]
		internal object header;

		// Token: 0x040012E1 RID: 4833
		[Token(Token = "0x40012E1")]
		[FieldOffset(Offset = "0x30")]
		internal object memberObject;

		// Token: 0x040012E2 RID: 4834
		[Token(Token = "0x40012E2")]
		[FieldOffset(Offset = "0x0")]
		internal static System.Reflection.MemberInfo valueInfo;

		// Token: 0x040012E3 RID: 4835
		[Token(Token = "0x40012E3")]
		[FieldOffset(Offset = "0x38")]
		internal ReadObjectInfo objectInfo;

		// Token: 0x040012E4 RID: 4836
		[Token(Token = "0x40012E4")]
		[FieldOffset(Offset = "0x40")]
		internal string memberName;
	}
}
