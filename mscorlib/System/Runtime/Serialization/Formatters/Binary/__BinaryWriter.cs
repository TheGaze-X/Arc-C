using System;
using System.Collections;
using System.IO;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200043D RID: 1085
	[Token(Token = "0x200043D")]
	internal sealed class __BinaryWriter
	{
		// Token: 0x060020FD RID: 8445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020FD")]
		[Address(RVA = "0x4BB41E0", Offset = "0x4BB2DE0", VA = "0x184BB41E0")]
		internal __BinaryWriter(System.IO.Stream sout, ObjectWriter objectWriter, FormatterTypeStyle formatterTypeStyle)
		{
		}

		// Token: 0x060020FE RID: 8446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020FE")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		internal void WriteBegin()
		{
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020FF")]
		[Address(RVA = "0x4BB19C0", Offset = "0x4BB05C0", VA = "0x184BB19C0")]
		internal void WriteEnd()
		{
		}

		// Token: 0x06002100 RID: 8448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002100")]
		[Address(RVA = "0x4BB15F0", Offset = "0x4BB01F0", VA = "0x184BB15F0")]
		internal void WriteBoolean(bool value)
		{
		}

		// Token: 0x06002101 RID: 8449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002101")]
		[Address(RVA = "0x4BB1640", Offset = "0x4BB0240", VA = "0x184BB1640")]
		internal void WriteByte(byte value)
		{
		}

		// Token: 0x06002102 RID: 8450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002102")]
		[Address(RVA = "0x4BB1690", Offset = "0x4BB0290", VA = "0x184BB1690")]
		private void WriteBytes(byte[] value)
		{
		}

		// Token: 0x06002103 RID: 8451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002103")]
		[Address(RVA = "0x4BB16E0", Offset = "0x4BB02E0", VA = "0x184BB16E0")]
		private void WriteBytes(byte[] byteA, int offset, int size)
		{
		}

		// Token: 0x06002104 RID: 8452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002104")]
		[Address(RVA = "0x4BB1760", Offset = "0x4BB0360", VA = "0x184BB1760")]
		internal void WriteChar(char value)
		{
		}

		// Token: 0x06002105 RID: 8453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002105")]
		[Address(RVA = "0x4BB17B0", Offset = "0x4BB03B0", VA = "0x184BB17B0")]
		internal void WriteChars(char[] value)
		{
		}

		// Token: 0x06002106 RID: 8454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002106")]
		[Address(RVA = "0x4BB1890", Offset = "0x4BB0490", VA = "0x184BB1890")]
		internal void WriteDecimal(decimal value)
		{
		}

		// Token: 0x06002107 RID: 8455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002107")]
		[Address(RVA = "0x4BB36C0", Offset = "0x4BB22C0", VA = "0x184BB36C0")]
		internal void WriteSingle(float value)
		{
		}

		// Token: 0x06002108 RID: 8456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002108")]
		[Address(RVA = "0x4BB1970", Offset = "0x4BB0570", VA = "0x184BB1970")]
		internal void WriteDouble(double value)
		{
		}

		// Token: 0x06002109 RID: 8457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002109")]
		[Address(RVA = "0x4BB1A00", Offset = "0x4BB0600", VA = "0x184BB1A00")]
		internal void WriteInt16(short value)
		{
		}

		// Token: 0x0600210A RID: 8458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600210A")]
		[Address(RVA = "0x4BB1A50", Offset = "0x4BB0650", VA = "0x184BB1A50")]
		internal void WriteInt32(int value)
		{
		}

		// Token: 0x0600210B RID: 8459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600210B")]
		[Address(RVA = "0x4BB1AA0", Offset = "0x4BB06A0", VA = "0x184BB1AA0")]
		internal void WriteInt64(long value)
		{
		}

		// Token: 0x0600210C RID: 8460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600210C")]
		[Address(RVA = "0x4BB1640", Offset = "0x4BB0240", VA = "0x184BB1640")]
		internal void WriteSByte(sbyte value)
		{
		}

		// Token: 0x0600210D RID: 8461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600210D")]
		[Address(RVA = "0x4BB3710", Offset = "0x4BB2310", VA = "0x184BB3710")]
		internal void WriteString(string value)
		{
		}

		// Token: 0x0600210E RID: 8462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600210E")]
		[Address(RVA = "0x4BB3760", Offset = "0x4BB2360", VA = "0x184BB3760")]
		internal void WriteTimeSpan(System.TimeSpan value)
		{
		}

		// Token: 0x0600210F RID: 8463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600210F")]
		[Address(RVA = "0x4BB1800", Offset = "0x4BB0400", VA = "0x184BB1800")]
		internal void WriteDateTime(System.DateTime value)
		{
		}

		// Token: 0x06002110 RID: 8464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002110")]
		[Address(RVA = "0x4BB37F0", Offset = "0x4BB23F0", VA = "0x184BB37F0")]
		internal void WriteUInt16(ushort value)
		{
		}

		// Token: 0x06002111 RID: 8465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002111")]
		[Address(RVA = "0x4BB3840", Offset = "0x4BB2440", VA = "0x184BB3840")]
		internal void WriteUInt32(uint value)
		{
		}

		// Token: 0x06002112 RID: 8466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002112")]
		[Address(RVA = "0x4BB3890", Offset = "0x4BB2490", VA = "0x184BB3890")]
		internal void WriteUInt64(ulong value)
		{
		}

		// Token: 0x06002113 RID: 8467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002113")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		internal void WriteObjectEnd(NameInfo memberNameInfo, NameInfo typeNameInfo)
		{
		}

		// Token: 0x06002114 RID: 8468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002114")]
		[Address(RVA = "0x4BB3050", Offset = "0x4BB1C50", VA = "0x184BB3050")]
		internal void WriteSerializationHeaderEnd()
		{
		}

		// Token: 0x06002115 RID: 8469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002115")]
		[Address(RVA = "0x4BB30D0", Offset = "0x4BB1CD0", VA = "0x184BB30D0")]
		internal void WriteSerializationHeader(int topId, int headerId, int minorVersion, int majorVersion)
		{
		}

		// Token: 0x06002116 RID: 8470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002116")]
		[Address(RVA = "0x4BB23C0", Offset = "0x4BB0FC0", VA = "0x184BB23C0")]
		internal void WriteMethodCall()
		{
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002117")]
		[Address(RVA = "0x4BB2450", Offset = "0x4BB1050", VA = "0x184BB2450")]
		internal void WriteMethodReturn()
		{
		}

		// Token: 0x06002118 RID: 8472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002118")]
		[Address(RVA = "0x4BB27A0", Offset = "0x4BB13A0", VA = "0x184BB27A0")]
		internal void WriteObject(NameInfo nameInfo, NameInfo typeNameInfo, int numMembers, string[] memberNames, System.Type[] memberTypes, WriteObjectInfo[] memberObjectInfos)
		{
		}

		// Token: 0x06002119 RID: 8473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002119")]
		[Address(RVA = "0x4BB2630", Offset = "0x4BB1230", VA = "0x184BB2630")]
		internal void WriteObjectString(int objectId, string value)
		{
		}

		// Token: 0x0600211A RID: 8474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600211A")]
		[Address(RVA = "0x4BB3280", Offset = "0x4BB1E80", VA = "0x184BB3280")]
		internal void WriteSingleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, System.Array array)
		{
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600211B")]
		[Address(RVA = "0x4BB1210", Offset = "0x4BAFE10", VA = "0x184BB1210")]
		private void WriteArrayAsBytes(System.Array array, int typeLength)
		{
		}

		// Token: 0x0600211C RID: 8476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600211C")]
		[Address(RVA = "0x4BB1CA0", Offset = "0x4BB08A0", VA = "0x184BB1CA0")]
		internal void WriteJaggedArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound)
		{
		}

		// Token: 0x0600211D RID: 8477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600211D")]
		[Address(RVA = "0x4BB2E90", Offset = "0x4BB1A90", VA = "0x184BB2E90")]
		internal void WriteRectangleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int rank, int[] lengthA, int[] lowerBoundA)
		{
		}

		// Token: 0x0600211E RID: 8478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600211E")]
		[Address(RVA = "0x4BB25D0", Offset = "0x4BB11D0", VA = "0x184BB25D0")]
		internal void WriteObjectByteArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, byte[] byteA)
		{
		}

		// Token: 0x0600211F RID: 8479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600211F")]
		[Address(RVA = "0x4BB21B0", Offset = "0x4BB0DB0", VA = "0x184BB21B0")]
		internal void WriteMember(NameInfo memberNameInfo, NameInfo typeNameInfo, object value)
		{
		}

		// Token: 0x06002120 RID: 8480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002120")]
		[Address(RVA = "0x4BB24F0", Offset = "0x4BB10F0", VA = "0x184BB24F0")]
		internal void WriteNullMember(NameInfo memberNameInfo, NameInfo typeNameInfo)
		{
		}

		// Token: 0x06002121 RID: 8481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002121")]
		[Address(RVA = "0x4BB1EE0", Offset = "0x4BB0AE0", VA = "0x184BB1EE0")]
		internal void WriteMemberObjectRef(NameInfo memberNameInfo, int idRef)
		{
		}

		// Token: 0x06002122 RID: 8482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002122")]
		[Address(RVA = "0x4BB1EB0", Offset = "0x4BB0AB0", VA = "0x184BB1EB0")]
		internal void WriteMemberNested(NameInfo memberNameInfo)
		{
		}

		// Token: 0x06002123 RID: 8483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002123")]
		[Address(RVA = "0x4BB2020", Offset = "0x4BB0C20", VA = "0x184BB2020")]
		internal void WriteMemberString(NameInfo memberNameInfo, NameInfo typeNameInfo, string value)
		{
		}

		// Token: 0x06002124 RID: 8484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002124")]
		[Address(RVA = "0x4BB1C40", Offset = "0x4BB0840", VA = "0x184BB1C40")]
		internal void WriteItem(NameInfo itemNameInfo, NameInfo typeNameInfo, object value)
		{
		}

		// Token: 0x06002125 RID: 8485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002125")]
		[Address(RVA = "0x4BB24E0", Offset = "0x4BB10E0", VA = "0x184BB24E0")]
		internal void WriteNullItem(NameInfo itemNameInfo, NameInfo typeNameInfo)
		{
		}

		// Token: 0x06002126 RID: 8486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002126")]
		[Address(RVA = "0x4BB1960", Offset = "0x4BB0560", VA = "0x184BB1960")]
		internal void WriteDelayedNullItem()
		{
		}

		// Token: 0x06002127 RID: 8487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002127")]
		[Address(RVA = "0x4BB1AF0", Offset = "0x4BB06F0", VA = "0x184BB1AF0")]
		internal void WriteItemEnd()
		{
		}

		// Token: 0x06002128 RID: 8488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002128")]
		[Address(RVA = "0x4BB1150", Offset = "0x4BAFD50", VA = "0x184BB1150")]
		private void InternalWriteItemNull()
		{
		}

		// Token: 0x06002129 RID: 8489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002129")]
		[Address(RVA = "0x4BB1B00", Offset = "0x4BB0700", VA = "0x184BB1B00")]
		internal void WriteItemObjectRef(NameInfo nameInfo, int idRef)
		{
		}

		// Token: 0x0600212A RID: 8490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600212A")]
		[Address(RVA = "0x4BB1440", Offset = "0x4BB0040", VA = "0x184BB1440")]
		internal void WriteAssembly(System.Type type, string assemblyString, int assemId, bool isNew)
		{
		}

		// Token: 0x0600212B RID: 8491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600212B")]
		[Address(RVA = "0x4BB38E0", Offset = "0x4BB24E0", VA = "0x184BB38E0")]
		internal void WriteValue(InternalPrimitiveTypeE code, object value)
		{
		}

		// Token: 0x0400121A RID: 4634
		[Token(Token = "0x400121A")]
		[FieldOffset(Offset = "0x10")]
		internal System.IO.Stream sout;

		// Token: 0x0400121B RID: 4635
		[Token(Token = "0x400121B")]
		[FieldOffset(Offset = "0x18")]
		internal FormatterTypeStyle formatterTypeStyle;

		// Token: 0x0400121C RID: 4636
		[Token(Token = "0x400121C")]
		[FieldOffset(Offset = "0x20")]
		internal System.Collections.Hashtable objectMapTable;

		// Token: 0x0400121D RID: 4637
		[Token(Token = "0x400121D")]
		[FieldOffset(Offset = "0x28")]
		internal ObjectWriter objectWriter;

		// Token: 0x0400121E RID: 4638
		[Token(Token = "0x400121E")]
		[FieldOffset(Offset = "0x30")]
		internal System.IO.BinaryWriter dataWriter;

		// Token: 0x0400121F RID: 4639
		[Token(Token = "0x400121F")]
		[FieldOffset(Offset = "0x38")]
		internal int m_nestedObjectCount;

		// Token: 0x04001220 RID: 4640
		[Token(Token = "0x4001220")]
		[FieldOffset(Offset = "0x3C")]
		private int nullCount;

		// Token: 0x04001221 RID: 4641
		[Token(Token = "0x4001221")]
		[FieldOffset(Offset = "0x40")]
		internal BinaryMethodCall binaryMethodCall;

		// Token: 0x04001222 RID: 4642
		[Token(Token = "0x4001222")]
		[FieldOffset(Offset = "0x48")]
		internal BinaryMethodReturn binaryMethodReturn;

		// Token: 0x04001223 RID: 4643
		[Token(Token = "0x4001223")]
		[FieldOffset(Offset = "0x50")]
		internal BinaryObject binaryObject;

		// Token: 0x04001224 RID: 4644
		[Token(Token = "0x4001224")]
		[FieldOffset(Offset = "0x58")]
		internal BinaryObjectWithMap binaryObjectWithMap;

		// Token: 0x04001225 RID: 4645
		[Token(Token = "0x4001225")]
		[FieldOffset(Offset = "0x60")]
		internal BinaryObjectWithMapTyped binaryObjectWithMapTyped;

		// Token: 0x04001226 RID: 4646
		[Token(Token = "0x4001226")]
		[FieldOffset(Offset = "0x68")]
		internal BinaryObjectString binaryObjectString;

		// Token: 0x04001227 RID: 4647
		[Token(Token = "0x4001227")]
		[FieldOffset(Offset = "0x70")]
		internal BinaryArray binaryArray;

		// Token: 0x04001228 RID: 4648
		[Token(Token = "0x4001228")]
		[FieldOffset(Offset = "0x78")]
		private byte[] byteBuffer;

		// Token: 0x04001229 RID: 4649
		[Token(Token = "0x4001229")]
		[FieldOffset(Offset = "0x80")]
		private int chunkSize;

		// Token: 0x0400122A RID: 4650
		[Token(Token = "0x400122A")]
		[FieldOffset(Offset = "0x88")]
		internal MemberPrimitiveUnTyped memberPrimitiveUnTyped;

		// Token: 0x0400122B RID: 4651
		[Token(Token = "0x400122B")]
		[FieldOffset(Offset = "0x90")]
		internal MemberPrimitiveTyped memberPrimitiveTyped;

		// Token: 0x0400122C RID: 4652
		[Token(Token = "0x400122C")]
		[FieldOffset(Offset = "0x98")]
		internal ObjectNull objectNull;

		// Token: 0x0400122D RID: 4653
		[Token(Token = "0x400122D")]
		[FieldOffset(Offset = "0xA0")]
		internal MemberReference memberReference;

		// Token: 0x0400122E RID: 4654
		[Token(Token = "0x400122E")]
		[FieldOffset(Offset = "0xA8")]
		internal BinaryAssembly binaryAssembly;
	}
}
