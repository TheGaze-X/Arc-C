using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000081 RID: 129
	[Token(Token = "0x2000081")]
	[Preserve]
	internal class JsonFormatterConverter : IFormatterConverter
	{
		// Token: 0x060004A7 RID: 1191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x4DA80D0", Offset = "0x4DA6CD0", VA = "0x184DA80D0")]
		public JsonFormatterConverter(JsonSerializerInternalReader reader, JsonISerializableContract contract, JsonProperty member)
		{
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A8")]
		private T GetTokenValue<T>(object value)
		{
			return null;
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x4DA7940", Offset = "0x4DA6540", VA = "0x184DA7940", Slot = "4")]
		public object Convert(object value, Type type)
		{
			return null;
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x4DA7740", Offset = "0x4DA6340", VA = "0x184DA7740", Slot = "10")]
		public object Convert(object value, TypeCode typeCode)
		{
			return null;
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00003DF8 File Offset: 0x00001FF8
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x4DA7C00", Offset = "0x4DA6800", VA = "0x184DA7C00", Slot = "5")]
		public bool ToBoolean(object value)
		{
			return default(bool);
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00003E10 File Offset: 0x00002010
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x4DA7C50", Offset = "0x4DA6850", VA = "0x184DA7C50", Slot = "11")]
		public byte ToByte(object value)
		{
			return 0;
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00003E28 File Offset: 0x00002028
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x4DA7CA0", Offset = "0x4DA68A0", VA = "0x184DA7CA0", Slot = "12")]
		public char ToChar(object value)
		{
			return '\0';
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00003E40 File Offset: 0x00002040
		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x4DA7CF0", Offset = "0x4DA68F0", VA = "0x184DA7CF0", Slot = "13")]
		public DateTime ToDateTime(object value)
		{
			return default(DateTime);
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00003E58 File Offset: 0x00002058
		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x4DA7D40", Offset = "0x4DA6940", VA = "0x184DA7D40", Slot = "14")]
		public decimal ToDecimal(object value)
		{
			return 0m;
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00003E70 File Offset: 0x00002070
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x4DA7DB0", Offset = "0x4DA69B0", VA = "0x184DA7DB0", Slot = "15")]
		public double ToDouble(object value)
		{
			return 0.0;
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00003E88 File Offset: 0x00002088
		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x4DA7E00", Offset = "0x4DA6A00", VA = "0x184DA7E00", Slot = "16")]
		public short ToInt16(object value)
		{
			return 0;
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00003EA0 File Offset: 0x000020A0
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x4DA7E50", Offset = "0x4DA6A50", VA = "0x184DA7E50", Slot = "6")]
		public int ToInt32(object value)
		{
			return 0;
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00003EB8 File Offset: 0x000020B8
		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x4DA7EA0", Offset = "0x4DA6AA0", VA = "0x184DA7EA0", Slot = "7")]
		public long ToInt64(object value)
		{
			return 0L;
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00003ED0 File Offset: 0x000020D0
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x4DA7EF0", Offset = "0x4DA6AF0", VA = "0x184DA7EF0", Slot = "17")]
		public sbyte ToSByte(object value)
		{
			return 0;
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00003EE8 File Offset: 0x000020E8
		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x4DA7F40", Offset = "0x4DA6B40", VA = "0x184DA7F40", Slot = "8")]
		public float ToSingle(object value)
		{
			return 0f;
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x4DA7F90", Offset = "0x4DA6B90", VA = "0x184DA7F90", Slot = "9")]
		public string ToString(object value)
		{
			return null;
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00003F00 File Offset: 0x00002100
		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x4DA7FE0", Offset = "0x4DA6BE0", VA = "0x184DA7FE0", Slot = "18")]
		public ushort ToUInt16(object value)
		{
			return 0;
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00003F18 File Offset: 0x00002118
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x4DA8030", Offset = "0x4DA6C30", VA = "0x184DA8030", Slot = "19")]
		public uint ToUInt32(object value)
		{
			return 0U;
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00003F30 File Offset: 0x00002130
		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x4DA8080", Offset = "0x4DA6C80", VA = "0x184DA8080", Slot = "20")]
		public ulong ToUInt64(object value)
		{
			return 0UL;
		}

		// Token: 0x0400021A RID: 538
		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x10")]
		private readonly JsonSerializerInternalReader _reader;

		// Token: 0x0400021B RID: 539
		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x18")]
		private readonly JsonISerializableContract _contract;

		// Token: 0x0400021C RID: 540
		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x20")]
		private readonly JsonProperty _member;
	}
}
