using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000425 RID: 1061
	[Token(Token = "0x2000425")]
	internal static class BinaryConverter
	{
		// Token: 0x0600207C RID: 8316 RVA: 0x00013668 File Offset: 0x00011868
		[Token(Token = "0x600207C")]
		[Address(RVA = "0x4B93E60", Offset = "0x4B92A60", VA = "0x184B93E60")]
		internal static BinaryTypeEnum GetBinaryTypeInfo(System.Type type, WriteObjectInfo objectInfo, string typeName, ObjectWriter objectWriter, out object typeInformation, out int assemId)
		{
			return BinaryTypeEnum.Primitive;
		}

		// Token: 0x0600207D RID: 8317 RVA: 0x00013680 File Offset: 0x00011880
		[Token(Token = "0x600207D")]
		[Address(RVA = "0x4B941B0", Offset = "0x4B92DB0", VA = "0x184B941B0")]
		internal static BinaryTypeEnum GetParserBinaryTypeInfo(System.Type type, out object typeInformation)
		{
			return BinaryTypeEnum.Primitive;
		}

		// Token: 0x0600207E RID: 8318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600207E")]
		[Address(RVA = "0x4B94BD0", Offset = "0x4B937D0", VA = "0x184B94BD0")]
		internal static void WriteTypeInfo(BinaryTypeEnum binaryTypeEnum, object typeInformation, int assemId, __BinaryWriter sout)
		{
		}

		// Token: 0x0600207F RID: 8319 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600207F")]
		[Address(RVA = "0x4B94420", Offset = "0x4B93020", VA = "0x184B94420")]
		internal static object ReadTypeInfo(BinaryTypeEnum binaryTypeEnum, __BinaryParser input, out int assemId)
		{
			return null;
		}

		// Token: 0x06002080 RID: 8320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002080")]
		[Address(RVA = "0x4B945F0", Offset = "0x4B931F0", VA = "0x184B945F0")]
		internal static void TypeFromInfo(BinaryTypeEnum binaryTypeEnum, object typeInformation, ObjectReader objectReader, BinaryAssemblyInfo assemblyInfo, out InternalPrimitiveTypeE primitiveTypeEnum, out string typeString, out System.Type type, out bool isVariant)
		{
		}
	}
}
