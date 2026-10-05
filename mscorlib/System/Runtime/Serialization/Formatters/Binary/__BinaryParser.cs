using System;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000448 RID: 1096
	[Token(Token = "0x2000448")]
	internal sealed class __BinaryParser
	{
		// Token: 0x0600219F RID: 8607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600219F")]
		[Address(RVA = "0x4BCE160", Offset = "0x4BCCD60", VA = "0x184BCE160")]
		internal __BinaryParser(System.IO.Stream stream, ObjectReader objectReader)
		{
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x060021A0 RID: 8608 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700045F")]
		internal BinaryAssemblyInfo SystemAssemblyInfo
		{
			[Token(Token = "0x60021A0")]
			[Address(RVA = "0x4BCE470", Offset = "0x4BCD070", VA = "0x184BCE470")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x060021A1 RID: 8609 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000460")]
		internal SizedArray ObjectMapIdTable
		{
			[Token(Token = "0x60021A1")]
			[Address(RVA = "0x4BCE390", Offset = "0x4BCCF90", VA = "0x184BCE390")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x060021A2 RID: 8610 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000461")]
		internal SizedArray AssemIdToAssemblyTable
		{
			[Token(Token = "0x60021A2")]
			[Address(RVA = "0x4BCE2B0", Offset = "0x4BCCEB0", VA = "0x184BCE2B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x060021A3 RID: 8611 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000462")]
		internal ParseRecord prs
		{
			[Token(Token = "0x60021A3")]
			[Address(RVA = "0x4BCE540", Offset = "0x4BCD140", VA = "0x184BCE540")]
			get
			{
				return null;
			}
		}

		// Token: 0x060021A4 RID: 8612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021A4")]
		[Address(RVA = "0x4BCDAD0", Offset = "0x4BCC6D0", VA = "0x184BCDAD0")]
		internal void Run()
		{
		}

		// Token: 0x060021A5 RID: 8613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021A5")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		internal void ReadBegin()
		{
		}

		// Token: 0x060021A6 RID: 8614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021A6")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		internal void ReadEnd()
		{
		}

		// Token: 0x060021A7 RID: 8615 RVA: 0x000138A8 File Offset: 0x00011AA8
		[Token(Token = "0x60021A7")]
		[Address(RVA = "0x4BC9750", Offset = "0x4BC8350", VA = "0x184BC9750")]
		internal bool ReadBoolean()
		{
			return default(bool);
		}

		// Token: 0x060021A8 RID: 8616 RVA: 0x000138C0 File Offset: 0x00011AC0
		[Token(Token = "0x60021A8")]
		[Address(RVA = "0x4BC97A0", Offset = "0x4BC83A0", VA = "0x184BC97A0")]
		internal byte ReadByte()
		{
			return 0;
		}

		// Token: 0x060021A9 RID: 8617 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60021A9")]
		[Address(RVA = "0x4BC97F0", Offset = "0x4BC83F0", VA = "0x184BC97F0")]
		internal byte[] ReadBytes(int length)
		{
			return null;
		}

		// Token: 0x060021AA RID: 8618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021AA")]
		[Address(RVA = "0x4BC9840", Offset = "0x4BC8440", VA = "0x184BC9840")]
		internal void ReadBytes(byte[] byteA, int offset, int size)
		{
		}

		// Token: 0x060021AB RID: 8619 RVA: 0x000138D8 File Offset: 0x00011AD8
		[Token(Token = "0x60021AB")]
		[Address(RVA = "0x4BC98F0", Offset = "0x4BC84F0", VA = "0x184BC98F0")]
		internal char ReadChar()
		{
			return '\0';
		}

		// Token: 0x060021AC RID: 8620 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60021AC")]
		[Address(RVA = "0x4BC9940", Offset = "0x4BC8540", VA = "0x184BC9940")]
		internal char[] ReadChars(int length)
		{
			return null;
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x000138F0 File Offset: 0x00011AF0
		[Token(Token = "0x60021AD")]
		[Address(RVA = "0x4BCA7B0", Offset = "0x4BC93B0", VA = "0x184BCA7B0")]
		internal decimal ReadDecimal()
		{
			return 0m;
		}

		// Token: 0x060021AE RID: 8622 RVA: 0x00013908 File Offset: 0x00011B08
		[Token(Token = "0x60021AE")]
		[Address(RVA = "0x4BCD260", Offset = "0x4BCBE60", VA = "0x184BCD260")]
		internal float ReadSingle()
		{
			return 0f;
		}

		// Token: 0x060021AF RID: 8623 RVA: 0x00013920 File Offset: 0x00011B20
		[Token(Token = "0x60021AF")]
		[Address(RVA = "0x4BCA890", Offset = "0x4BC9490", VA = "0x184BCA890")]
		internal double ReadDouble()
		{
			return 0.0;
		}

		// Token: 0x060021B0 RID: 8624 RVA: 0x00013938 File Offset: 0x00011B38
		[Token(Token = "0x60021B0")]
		[Address(RVA = "0x4BCA8E0", Offset = "0x4BC94E0", VA = "0x184BCA8E0")]
		internal short ReadInt16()
		{
			return 0;
		}

		// Token: 0x060021B1 RID: 8625 RVA: 0x00013950 File Offset: 0x00011B50
		[Token(Token = "0x60021B1")]
		[Address(RVA = "0x4BCA930", Offset = "0x4BC9530", VA = "0x184BCA930")]
		internal int ReadInt32()
		{
			return 0;
		}

		// Token: 0x060021B2 RID: 8626 RVA: 0x00013968 File Offset: 0x00011B68
		[Token(Token = "0x60021B2")]
		[Address(RVA = "0x4BCA980", Offset = "0x4BC9580", VA = "0x184BCA980")]
		internal long ReadInt64()
		{
			return 0L;
		}

		// Token: 0x060021B3 RID: 8627 RVA: 0x00013980 File Offset: 0x00011B80
		[Token(Token = "0x60021B3")]
		[Address(RVA = "0x4BC97A0", Offset = "0x4BC83A0", VA = "0x184BC97A0")]
		internal sbyte ReadSByte()
		{
			return 0;
		}

		// Token: 0x060021B4 RID: 8628 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60021B4")]
		[Address(RVA = "0x4BCD2B0", Offset = "0x4BCBEB0", VA = "0x184BCD2B0")]
		internal string ReadString()
		{
			return null;
		}

		// Token: 0x060021B5 RID: 8629 RVA: 0x00013998 File Offset: 0x00011B98
		[Token(Token = "0x60021B5")]
		[Address(RVA = "0x4BCA980", Offset = "0x4BC9580", VA = "0x184BCA980")]
		internal System.TimeSpan ReadTimeSpan()
		{
			return default(System.TimeSpan);
		}

		// Token: 0x060021B6 RID: 8630 RVA: 0x000139B0 File Offset: 0x00011BB0
		[Token(Token = "0x60021B6")]
		[Address(RVA = "0x4BCA720", Offset = "0x4BC9320", VA = "0x184BCA720")]
		internal System.DateTime ReadDateTime()
		{
			return default(System.DateTime);
		}

		// Token: 0x060021B7 RID: 8631 RVA: 0x000139C8 File Offset: 0x00011BC8
		[Token(Token = "0x60021B7")]
		[Address(RVA = "0x4BCD300", Offset = "0x4BCBF00", VA = "0x184BCD300")]
		internal ushort ReadUInt16()
		{
			return 0;
		}

		// Token: 0x060021B8 RID: 8632 RVA: 0x000139E0 File Offset: 0x00011BE0
		[Token(Token = "0x60021B8")]
		[Address(RVA = "0x4BCD350", Offset = "0x4BCBF50", VA = "0x184BCD350")]
		internal uint ReadUInt32()
		{
			return 0U;
		}

		// Token: 0x060021B9 RID: 8633 RVA: 0x000139F8 File Offset: 0x00011BF8
		[Token(Token = "0x60021B9")]
		[Address(RVA = "0x4BCD3A0", Offset = "0x4BCBFA0", VA = "0x184BCD3A0")]
		internal ulong ReadUInt64()
		{
			return 0UL;
		}

		// Token: 0x060021BA RID: 8634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021BA")]
		[Address(RVA = "0x4BCD1A0", Offset = "0x4BCBDA0", VA = "0x184BCD1A0")]
		internal void ReadSerializationHeaderRecord()
		{
		}

		// Token: 0x060021BB RID: 8635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021BB")]
		[Address(RVA = "0x4BC9490", Offset = "0x4BC8090", VA = "0x184BC9490")]
		internal void ReadAssembly(BinaryHeaderEnum binaryHeaderEnum)
		{
		}

		// Token: 0x060021BC RID: 8636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021BC")]
		[Address(RVA = "0x4BCCC50", Offset = "0x4BCB850", VA = "0x184BCCC50")]
		private void ReadObject()
		{
		}

		// Token: 0x060021BD RID: 8637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021BD")]
		[Address(RVA = "0x4BC9990", Offset = "0x4BC8590", VA = "0x184BC9990")]
		internal void ReadCrossAppDomainMap()
		{
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021BE")]
		[Address(RVA = "0x4BCC5B0", Offset = "0x4BCB1B0", VA = "0x184BCC5B0")]
		internal void ReadObjectWithMap(BinaryHeaderEnum binaryHeaderEnum)
		{
		}

		// Token: 0x060021BF RID: 8639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021BF")]
		[Address(RVA = "0x4BCC680", Offset = "0x4BCB280", VA = "0x184BCC680")]
		private void ReadObjectWithMap(BinaryObjectWithMap record)
		{
		}

		// Token: 0x060021C0 RID: 8640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021C0")]
		[Address(RVA = "0x4BCBE90", Offset = "0x4BCAA90", VA = "0x184BCBE90")]
		internal void ReadObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum)
		{
		}

		// Token: 0x060021C1 RID: 8641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021C1")]
		[Address(RVA = "0x4BCBF50", Offset = "0x4BCAB50", VA = "0x184BCBF50")]
		private void ReadObjectWithMapTyped(BinaryObjectWithMapTyped record)
		{
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021C2")]
		[Address(RVA = "0x4BCB790", Offset = "0x4BCA390", VA = "0x184BCB790")]
		private void ReadObjectString(BinaryHeaderEnum binaryHeaderEnum)
		{
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021C3")]
		[Address(RVA = "0x4BCA9D0", Offset = "0x4BC95D0", VA = "0x184BCA9D0")]
		private void ReadMemberPrimitiveTyped()
		{
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021C4")]
		[Address(RVA = "0x4BC8D60", Offset = "0x4BC7960", VA = "0x184BC8D60")]
		private void ReadArray(BinaryHeaderEnum binaryHeaderEnum)
		{
		}

		// Token: 0x060021C5 RID: 8645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021C5")]
		[Address(RVA = "0x4BC8900", Offset = "0x4BC7500", VA = "0x184BC8900")]
		private void ReadArrayAsBytes(ParseRecord pr)
		{
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021C6")]
		[Address(RVA = "0x4BCAE00", Offset = "0x4BC9A00", VA = "0x184BCAE00")]
		private void ReadMemberPrimitiveUnTyped()
		{
		}

		// Token: 0x060021C7 RID: 8647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021C7")]
		[Address(RVA = "0x4BCB120", Offset = "0x4BC9D20", VA = "0x184BCB120")]
		private void ReadMemberReference()
		{
		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021C8")]
		[Address(RVA = "0x4BCB530", Offset = "0x4BCA130", VA = "0x184BCB530")]
		private void ReadObjectNull(BinaryHeaderEnum binaryHeaderEnum)
		{
		}

		// Token: 0x060021C9 RID: 8649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021C9")]
		[Address(RVA = "0x4BCB370", Offset = "0x4BC9F70", VA = "0x184BCB370")]
		private void ReadMessageEnd()
		{
		}

		// Token: 0x060021CA RID: 8650 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60021CA")]
		[Address(RVA = "0x4BCD3F0", Offset = "0x4BCBFF0", VA = "0x184BCD3F0")]
		internal object ReadValue(InternalPrimitiveTypeE code)
		{
			return null;
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60021CB")]
		[Address(RVA = "0x4BC87B0", Offset = "0x4BC73B0", VA = "0x184BC87B0")]
		private ObjectProgress GetOp()
		{
			return null;
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021CC")]
		[Address(RVA = "0x4BC8850", Offset = "0x4BC7450", VA = "0x184BC8850")]
		private void PutOp(ObjectProgress op)
		{
		}

		// Token: 0x04001292 RID: 4754
		[Token(Token = "0x4001292")]
		[FieldOffset(Offset = "0x10")]
		internal ObjectReader objectReader;

		// Token: 0x04001293 RID: 4755
		[Token(Token = "0x4001293")]
		[FieldOffset(Offset = "0x18")]
		internal System.IO.Stream input;

		// Token: 0x04001294 RID: 4756
		[Token(Token = "0x4001294")]
		[FieldOffset(Offset = "0x20")]
		internal long topId;

		// Token: 0x04001295 RID: 4757
		[Token(Token = "0x4001295")]
		[FieldOffset(Offset = "0x28")]
		internal long headerId;

		// Token: 0x04001296 RID: 4758
		[Token(Token = "0x4001296")]
		[FieldOffset(Offset = "0x30")]
		internal SizedArray objectMapIdTable;

		// Token: 0x04001297 RID: 4759
		[Token(Token = "0x4001297")]
		[FieldOffset(Offset = "0x38")]
		internal SizedArray assemIdToAssemblyTable;

		// Token: 0x04001298 RID: 4760
		[Token(Token = "0x4001298")]
		[FieldOffset(Offset = "0x40")]
		internal SerStack stack;

		// Token: 0x04001299 RID: 4761
		[Token(Token = "0x4001299")]
		[FieldOffset(Offset = "0x48")]
		internal BinaryTypeEnum expectedType;

		// Token: 0x0400129A RID: 4762
		[Token(Token = "0x400129A")]
		[FieldOffset(Offset = "0x50")]
		internal object expectedTypeInformation;

		// Token: 0x0400129B RID: 4763
		[Token(Token = "0x400129B")]
		[FieldOffset(Offset = "0x58")]
		internal ParseRecord PRS;

		// Token: 0x0400129C RID: 4764
		[Token(Token = "0x400129C")]
		[FieldOffset(Offset = "0x60")]
		private BinaryAssemblyInfo systemAssemblyInfo;

		// Token: 0x0400129D RID: 4765
		[Token(Token = "0x400129D")]
		[FieldOffset(Offset = "0x68")]
		private System.IO.BinaryReader dataReader;

		// Token: 0x0400129E RID: 4766
		[Token(Token = "0x400129E")]
		[FieldOffset(Offset = "0x0")]
		private static System.Text.Encoding encoding;

		// Token: 0x0400129F RID: 4767
		[Token(Token = "0x400129F")]
		[FieldOffset(Offset = "0x70")]
		private SerStack opPool;

		// Token: 0x040012A0 RID: 4768
		[Token(Token = "0x40012A0")]
		[FieldOffset(Offset = "0x78")]
		private BinaryObject binaryObject;

		// Token: 0x040012A1 RID: 4769
		[Token(Token = "0x40012A1")]
		[FieldOffset(Offset = "0x80")]
		private BinaryObjectWithMap bowm;

		// Token: 0x040012A2 RID: 4770
		[Token(Token = "0x40012A2")]
		[FieldOffset(Offset = "0x88")]
		private BinaryObjectWithMapTyped bowmt;

		// Token: 0x040012A3 RID: 4771
		[Token(Token = "0x40012A3")]
		[FieldOffset(Offset = "0x90")]
		internal BinaryObjectString objectString;

		// Token: 0x040012A4 RID: 4772
		[Token(Token = "0x40012A4")]
		[FieldOffset(Offset = "0x98")]
		internal BinaryCrossAppDomainString crossAppDomainString;

		// Token: 0x040012A5 RID: 4773
		[Token(Token = "0x40012A5")]
		[FieldOffset(Offset = "0xA0")]
		internal MemberPrimitiveTyped memberPrimitiveTyped;

		// Token: 0x040012A6 RID: 4774
		[Token(Token = "0x40012A6")]
		[FieldOffset(Offset = "0xA8")]
		private byte[] byteBuffer;

		// Token: 0x040012A7 RID: 4775
		[Token(Token = "0x40012A7")]
		[FieldOffset(Offset = "0xB0")]
		internal MemberPrimitiveUnTyped memberPrimitiveUnTyped;

		// Token: 0x040012A8 RID: 4776
		[Token(Token = "0x40012A8")]
		[FieldOffset(Offset = "0xB8")]
		internal MemberReference memberReference;

		// Token: 0x040012A9 RID: 4777
		[Token(Token = "0x40012A9")]
		[FieldOffset(Offset = "0xC0")]
		internal ObjectNull objectNull;

		// Token: 0x040012AA RID: 4778
		[Token(Token = "0x40012AA")]
		[FieldOffset(Offset = "0x8")]
		internal static MessageEnd messageEnd;
	}
}
