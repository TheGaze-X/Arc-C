using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000C5 RID: 197
	[Token(Token = "0x20000C5")]
	[System.Serializable]
	public sealed class DBNull : System.Runtime.Serialization.ISerializable, System.IConvertible
	{
		// Token: 0x06000620 RID: 1568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000620")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private DBNull()
		{
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000621")]
		[Address(RVA = "0x4CB5900", Offset = "0x4CB4500", VA = "0x184CB5900")]
		private DBNull(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000622")]
		[Address(RVA = "0x4CB5240", Offset = "0x4CB3E40", VA = "0x184CB5240", Slot = "4")]
		public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000623")]
		[Address(RVA = "0x4CB5800", Offset = "0x4CB4400", VA = "0x184CB5800", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000624")]
		[Address(RVA = "0x4CB5840", Offset = "0x4CB4440", VA = "0x184CB5840", Slot = "20")]
		public string ToString(System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00006468 File Offset: 0x00004668
		[Token(Token = "0x6000625")]
		[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "5")]
		public System.TypeCode GetTypeCode()
		{
			return System.TypeCode.Empty;
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00006480 File Offset: 0x00004680
		[Token(Token = "0x6000626")]
		[Address(RVA = "0x4CB5250", Offset = "0x4CB3E50", VA = "0x184CB5250", Slot = "6")]
		private bool ToBoolean(System.IFormatProvider provider)
		{
			return default(bool);
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00006498 File Offset: 0x00004698
		[Token(Token = "0x6000627")]
		[Address(RVA = "0x4CB5310", Offset = "0x4CB3F10", VA = "0x184CB5310", Slot = "7")]
		private char ToChar(System.IFormatProvider provider)
		{
			return '\0';
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x000064B0 File Offset: 0x000046B0
		[Token(Token = "0x6000628")]
		[Address(RVA = "0x4CB55B0", Offset = "0x4CB41B0", VA = "0x184CB55B0", Slot = "8")]
		private sbyte ToSByte(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x000064C8 File Offset: 0x000046C8
		[Token(Token = "0x6000629")]
		[Address(RVA = "0x4CB52B0", Offset = "0x4CB3EB0", VA = "0x184CB52B0", Slot = "9")]
		private byte ToByte(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x000064E0 File Offset: 0x000046E0
		[Token(Token = "0x600062A")]
		[Address(RVA = "0x4CB5490", Offset = "0x4CB4090", VA = "0x184CB5490", Slot = "10")]
		private short ToInt16(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x000064F8 File Offset: 0x000046F8
		[Token(Token = "0x600062B")]
		[Address(RVA = "0x4CB56E0", Offset = "0x4CB42E0", VA = "0x184CB56E0", Slot = "11")]
		private ushort ToUInt16(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00006510 File Offset: 0x00004710
		[Token(Token = "0x600062C")]
		[Address(RVA = "0x4CB54F0", Offset = "0x4CB40F0", VA = "0x184CB54F0", Slot = "12")]
		private int ToInt32(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00006528 File Offset: 0x00004728
		[Token(Token = "0x600062D")]
		[Address(RVA = "0x4CB5740", Offset = "0x4CB4340", VA = "0x184CB5740", Slot = "13")]
		private uint ToUInt32(System.IFormatProvider provider)
		{
			return 0U;
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00006540 File Offset: 0x00004740
		[Token(Token = "0x600062E")]
		[Address(RVA = "0x4CB5550", Offset = "0x4CB4150", VA = "0x184CB5550", Slot = "14")]
		private long ToInt64(System.IFormatProvider provider)
		{
			return 0L;
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00006558 File Offset: 0x00004758
		[Token(Token = "0x600062F")]
		[Address(RVA = "0x4CB57A0", Offset = "0x4CB43A0", VA = "0x184CB57A0", Slot = "15")]
		private ulong ToUInt64(System.IFormatProvider provider)
		{
			return 0UL;
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00006570 File Offset: 0x00004770
		[Token(Token = "0x6000630")]
		[Address(RVA = "0x4CB5610", Offset = "0x4CB4210", VA = "0x184CB5610", Slot = "16")]
		private float ToSingle(System.IFormatProvider provider)
		{
			return 0f;
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00006588 File Offset: 0x00004788
		[Token(Token = "0x6000631")]
		[Address(RVA = "0x4CB5430", Offset = "0x4CB4030", VA = "0x184CB5430", Slot = "17")]
		private double ToDouble(System.IFormatProvider provider)
		{
			return 0.0;
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x000065A0 File Offset: 0x000047A0
		[Token(Token = "0x6000632")]
		[Address(RVA = "0x4CB53D0", Offset = "0x4CB3FD0", VA = "0x184CB53D0", Slot = "18")]
		private decimal ToDecimal(System.IFormatProvider provider)
		{
			return 0m;
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x000065B8 File Offset: 0x000047B8
		[Token(Token = "0x6000633")]
		[Address(RVA = "0x4CB5370", Offset = "0x4CB3F70", VA = "0x184CB5370", Slot = "19")]
		private System.DateTime ToDateTime(System.IFormatProvider provider)
		{
			return default(System.DateTime);
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000634")]
		[Address(RVA = "0x4CB5670", Offset = "0x4CB4270", VA = "0x184CB5670", Slot = "21")]
		private object ToType(System.Type type, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x040002F3 RID: 755
		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x0")]
		public static readonly System.DBNull Value;
	}
}
