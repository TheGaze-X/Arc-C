using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000449 RID: 1097
	[Token(Token = "0x2000449")]
	internal sealed class ParseRecord
	{
		// Token: 0x060021CE RID: 8654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021CE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal ParseRecord()
		{
		}

		// Token: 0x060021CF RID: 8655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021CF")]
		[Address(RVA = "0x4BC1A40", Offset = "0x4BC0640", VA = "0x184BC1A40")]
		internal void Init()
		{
		}

		// Token: 0x040012AB RID: 4779
		[Token(Token = "0x40012AB")]
		[FieldOffset(Offset = "0x0")]
		internal static int parseRecordIdCount;

		// Token: 0x040012AC RID: 4780
		[Token(Token = "0x40012AC")]
		[FieldOffset(Offset = "0x10")]
		internal InternalParseTypeE PRparseTypeEnum;

		// Token: 0x040012AD RID: 4781
		[Token(Token = "0x40012AD")]
		[FieldOffset(Offset = "0x14")]
		internal InternalObjectTypeE PRobjectTypeEnum;

		// Token: 0x040012AE RID: 4782
		[Token(Token = "0x40012AE")]
		[FieldOffset(Offset = "0x18")]
		internal InternalArrayTypeE PRarrayTypeEnum;

		// Token: 0x040012AF RID: 4783
		[Token(Token = "0x40012AF")]
		[FieldOffset(Offset = "0x1C")]
		internal InternalMemberTypeE PRmemberTypeEnum;

		// Token: 0x040012B0 RID: 4784
		[Token(Token = "0x40012B0")]
		[FieldOffset(Offset = "0x20")]
		internal InternalMemberValueE PRmemberValueEnum;

		// Token: 0x040012B1 RID: 4785
		[Token(Token = "0x40012B1")]
		[FieldOffset(Offset = "0x24")]
		internal InternalObjectPositionE PRobjectPositionEnum;

		// Token: 0x040012B2 RID: 4786
		[Token(Token = "0x40012B2")]
		[FieldOffset(Offset = "0x28")]
		internal string PRname;

		// Token: 0x040012B3 RID: 4787
		[Token(Token = "0x40012B3")]
		[FieldOffset(Offset = "0x30")]
		internal string PRvalue;

		// Token: 0x040012B4 RID: 4788
		[Token(Token = "0x40012B4")]
		[FieldOffset(Offset = "0x38")]
		internal object PRvarValue;

		// Token: 0x040012B5 RID: 4789
		[Token(Token = "0x40012B5")]
		[FieldOffset(Offset = "0x40")]
		internal string PRkeyDt;

		// Token: 0x040012B6 RID: 4790
		[Token(Token = "0x40012B6")]
		[FieldOffset(Offset = "0x48")]
		internal System.Type PRdtType;

		// Token: 0x040012B7 RID: 4791
		[Token(Token = "0x40012B7")]
		[FieldOffset(Offset = "0x50")]
		internal InternalPrimitiveTypeE PRdtTypeCode;

		// Token: 0x040012B8 RID: 4792
		[Token(Token = "0x40012B8")]
		[FieldOffset(Offset = "0x54")]
		internal bool PRisEnum;

		// Token: 0x040012B9 RID: 4793
		[Token(Token = "0x40012B9")]
		[FieldOffset(Offset = "0x58")]
		internal long PRobjectId;

		// Token: 0x040012BA RID: 4794
		[Token(Token = "0x40012BA")]
		[FieldOffset(Offset = "0x60")]
		internal long PRidRef;

		// Token: 0x040012BB RID: 4795
		[Token(Token = "0x40012BB")]
		[FieldOffset(Offset = "0x68")]
		internal string PRarrayElementTypeString;

		// Token: 0x040012BC RID: 4796
		[Token(Token = "0x40012BC")]
		[FieldOffset(Offset = "0x70")]
		internal System.Type PRarrayElementType;

		// Token: 0x040012BD RID: 4797
		[Token(Token = "0x40012BD")]
		[FieldOffset(Offset = "0x78")]
		internal bool PRisArrayVariant;

		// Token: 0x040012BE RID: 4798
		[Token(Token = "0x40012BE")]
		[FieldOffset(Offset = "0x7C")]
		internal InternalPrimitiveTypeE PRarrayElementTypeCode;

		// Token: 0x040012BF RID: 4799
		[Token(Token = "0x40012BF")]
		[FieldOffset(Offset = "0x80")]
		internal int PRrank;

		// Token: 0x040012C0 RID: 4800
		[Token(Token = "0x40012C0")]
		[FieldOffset(Offset = "0x88")]
		internal int[] PRlengthA;

		// Token: 0x040012C1 RID: 4801
		[Token(Token = "0x40012C1")]
		[FieldOffset(Offset = "0x90")]
		internal int[] PRpositionA;

		// Token: 0x040012C2 RID: 4802
		[Token(Token = "0x40012C2")]
		[FieldOffset(Offset = "0x98")]
		internal int[] PRlowerBoundA;

		// Token: 0x040012C3 RID: 4803
		[Token(Token = "0x40012C3")]
		[FieldOffset(Offset = "0xA0")]
		internal int[] PRupperBoundA;

		// Token: 0x040012C4 RID: 4804
		[Token(Token = "0x40012C4")]
		[FieldOffset(Offset = "0xA8")]
		internal int[] PRindexMap;

		// Token: 0x040012C5 RID: 4805
		[Token(Token = "0x40012C5")]
		[FieldOffset(Offset = "0xB0")]
		internal int PRmemberIndex;

		// Token: 0x040012C6 RID: 4806
		[Token(Token = "0x40012C6")]
		[FieldOffset(Offset = "0xB4")]
		internal int PRlinearlength;

		// Token: 0x040012C7 RID: 4807
		[Token(Token = "0x40012C7")]
		[FieldOffset(Offset = "0xB8")]
		internal int[] PRrectangularMap;

		// Token: 0x040012C8 RID: 4808
		[Token(Token = "0x40012C8")]
		[FieldOffset(Offset = "0xC0")]
		internal bool PRisLowerBound;

		// Token: 0x040012C9 RID: 4809
		[Token(Token = "0x40012C9")]
		[FieldOffset(Offset = "0xC8")]
		internal long PRtopId;

		// Token: 0x040012CA RID: 4810
		[Token(Token = "0x40012CA")]
		[FieldOffset(Offset = "0xD0")]
		internal long PRheaderId;

		// Token: 0x040012CB RID: 4811
		[Token(Token = "0x40012CB")]
		[FieldOffset(Offset = "0xD8")]
		internal ReadObjectInfo PRobjectInfo;

		// Token: 0x040012CC RID: 4812
		[Token(Token = "0x40012CC")]
		[FieldOffset(Offset = "0xE0")]
		internal bool PRisValueTypeFixup;

		// Token: 0x040012CD RID: 4813
		[Token(Token = "0x40012CD")]
		[FieldOffset(Offset = "0xE8")]
		internal object PRnewObj;

		// Token: 0x040012CE RID: 4814
		[Token(Token = "0x40012CE")]
		[FieldOffset(Offset = "0xF0")]
		internal object[] PRobjectA;

		// Token: 0x040012CF RID: 4815
		[Token(Token = "0x40012CF")]
		[FieldOffset(Offset = "0xF8")]
		internal PrimitiveArray PRprimitiveArray;

		// Token: 0x040012D0 RID: 4816
		[Token(Token = "0x40012D0")]
		[FieldOffset(Offset = "0x100")]
		internal bool PRisRegistered;

		// Token: 0x040012D1 RID: 4817
		[Token(Token = "0x40012D1")]
		[FieldOffset(Offset = "0x108")]
		internal object[] PRmemberData;

		// Token: 0x040012D2 RID: 4818
		[Token(Token = "0x40012D2")]
		[FieldOffset(Offset = "0x110")]
		internal SerializationInfo PRsi;

		// Token: 0x040012D3 RID: 4819
		[Token(Token = "0x40012D3")]
		[FieldOffset(Offset = "0x118")]
		internal int PRnullCount;
	}
}
