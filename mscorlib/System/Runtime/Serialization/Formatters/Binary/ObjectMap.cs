using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000439 RID: 1081
	[Token(Token = "0x2000439")]
	internal sealed class ObjectMap
	{
		// Token: 0x060020D6 RID: 8406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020D6")]
		[Address(RVA = "0x4BA8510", Offset = "0x4BA7110", VA = "0x184BA8510")]
		internal ObjectMap(string objectName, System.Type objectType, string[] memberNames, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo)
		{
		}

		// Token: 0x060020D7 RID: 8407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020D7")]
		[Address(RVA = "0x4BA8130", Offset = "0x4BA6D30", VA = "0x184BA8130")]
		internal ObjectMap(string objectName, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable)
		{
		}

		// Token: 0x060020D8 RID: 8408 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60020D8")]
		[Address(RVA = "0x4BA7F30", Offset = "0x4BA6B30", VA = "0x184BA7F30")]
		internal ReadObjectInfo CreateObjectInfo(ref SerializationInfo si, ref object[] memberData)
		{
			return null;
		}

		// Token: 0x060020D9 RID: 8409 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60020D9")]
		[Address(RVA = "0x4BA7FA0", Offset = "0x4BA6BA0", VA = "0x184BA7FA0")]
		internal static ObjectMap Create(string name, System.Type objectType, string[] memberNames, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo)
		{
			return null;
		}

		// Token: 0x060020DA RID: 8410 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60020DA")]
		[Address(RVA = "0x4BA8050", Offset = "0x4BA6C50", VA = "0x184BA8050")]
		internal static ObjectMap Create(string name, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable)
		{
			return null;
		}

		// Token: 0x040011C4 RID: 4548
		[Token(Token = "0x40011C4")]
		[FieldOffset(Offset = "0x10")]
		internal string objectName;

		// Token: 0x040011C5 RID: 4549
		[Token(Token = "0x40011C5")]
		[FieldOffset(Offset = "0x18")]
		internal System.Type objectType;

		// Token: 0x040011C6 RID: 4550
		[Token(Token = "0x40011C6")]
		[FieldOffset(Offset = "0x20")]
		internal BinaryTypeEnum[] binaryTypeEnumA;

		// Token: 0x040011C7 RID: 4551
		[Token(Token = "0x40011C7")]
		[FieldOffset(Offset = "0x28")]
		internal object[] typeInformationA;

		// Token: 0x040011C8 RID: 4552
		[Token(Token = "0x40011C8")]
		[FieldOffset(Offset = "0x30")]
		internal System.Type[] memberTypes;

		// Token: 0x040011C9 RID: 4553
		[Token(Token = "0x40011C9")]
		[FieldOffset(Offset = "0x38")]
		internal string[] memberNames;

		// Token: 0x040011CA RID: 4554
		[Token(Token = "0x40011CA")]
		[FieldOffset(Offset = "0x40")]
		internal ReadObjectInfo objectInfo;

		// Token: 0x040011CB RID: 4555
		[Token(Token = "0x40011CB")]
		[FieldOffset(Offset = "0x48")]
		internal bool isInitObjectInfo;

		// Token: 0x040011CC RID: 4556
		[Token(Token = "0x40011CC")]
		[FieldOffset(Offset = "0x50")]
		internal ObjectReader objectReader;

		// Token: 0x040011CD RID: 4557
		[Token(Token = "0x40011CD")]
		[FieldOffset(Offset = "0x58")]
		internal int objectId;

		// Token: 0x040011CE RID: 4558
		[Token(Token = "0x40011CE")]
		[FieldOffset(Offset = "0x60")]
		internal BinaryAssemblyInfo assemblyInfo;
	}
}
