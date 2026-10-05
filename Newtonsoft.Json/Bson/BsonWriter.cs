using System;
using System.IO;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x0200012C RID: 300
	[Token(Token = "0x200012C")]
	[Preserve]
	public class BsonWriter : JsonWriter
	{
		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000B89 RID: 2953 RVA: 0x00006300 File Offset: 0x00004500
		// (set) Token: 0x06000B8A RID: 2954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700023F")]
		public DateTimeKind DateTimeKindHandling
		{
			[Token(Token = "0x6000B89")]
			[Address(RVA = "0x4E02A00", Offset = "0x4E01600", VA = "0x184E02A00")]
			get
			{
				return DateTimeKind.Unspecified;
			}
			[Token(Token = "0x6000B8A")]
			[Address(RVA = "0x4E02A20", Offset = "0x4E01620", VA = "0x184E02A20")]
			set
			{
			}
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B8B")]
		[Address(RVA = "0x4E02900", Offset = "0x4E01500", VA = "0x184E02900")]
		public BsonWriter(Stream stream)
		{
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B8C")]
		[Address(RVA = "0x4E02820", Offset = "0x4E01420", VA = "0x184E02820")]
		public BsonWriter(BinaryWriter writer)
		{
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B8D")]
		[Address(RVA = "0x4E01570", Offset = "0x4E00170", VA = "0x184E01570", Slot = "6")]
		public override void Flush()
		{
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B8E")]
		[Address(RVA = "0x4E01640", Offset = "0x4E00240", VA = "0x184E01640", Slot = "18")]
		protected override void WriteEnd(JsonToken token)
		{
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x4E015F0", Offset = "0x4E001F0", VA = "0x184E015F0", Slot = "64")]
		public override void WriteComment(string text)
		{
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x4E01AF0", Offset = "0x4E006F0", VA = "0x184E01AF0", Slot = "12")]
		public override void WriteStartConstructor(string name)
		{
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x4E01840", Offset = "0x4E00440", VA = "0x184E01840", Slot = "24")]
		public override void WriteRaw(string json)
		{
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B92")]
		[Address(RVA = "0x4E017F0", Offset = "0x4E003F0", VA = "0x184E017F0", Slot = "25")]
		public override void WriteRawValue(string json)
		{
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B93")]
		[Address(RVA = "0x4E01A00", Offset = "0x4E00600", VA = "0x184E01A00", Slot = "10")]
		public override void WriteStartArray()
		{
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B94")]
		[Address(RVA = "0x4E01B40", Offset = "0x4E00740", VA = "0x184E01B40", Slot = "8")]
		public override void WriteStartObject()
		{
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B95")]
		[Address(RVA = "0x4E017B0", Offset = "0x4E003B0", VA = "0x184E017B0", Slot = "14")]
		public override void WritePropertyName(string name)
		{
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B96")]
		[Address(RVA = "0x4E01510", Offset = "0x4E00110", VA = "0x184E01510", Slot = "7")]
		public override void Close()
		{
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B97")]
		[Address(RVA = "0x4E00F60", Offset = "0x4DFFB60", VA = "0x184E00F60")]
		private void AddParent(BsonToken container)
		{
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B98")]
		[Address(RVA = "0x4E015C0", Offset = "0x4E001C0", VA = "0x184E015C0")]
		private void RemoveParent()
		{
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B99")]
		[Address(RVA = "0x4E01470", Offset = "0x4E00070", VA = "0x184E01470")]
		private void AddValue(object value, BsonType type)
		{
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0x4E00FA0", Offset = "0x4DFFBA0", VA = "0x184E00FA0")]
		internal void AddToken(BsonToken token)
		{
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B9B")]
		[Address(RVA = "0x4D7B220", Offset = "0x4D79E20", VA = "0x184D7B220", Slot = "63")]
		public override void WriteValue(object value)
		{
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0x4E016C0", Offset = "0x4E002C0", VA = "0x184E016C0", Slot = "22")]
		public override void WriteNull()
		{
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0x4E01C30", Offset = "0x4E00830", VA = "0x184E01C30", Slot = "23")]
		public override void WriteUndefined()
		{
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0x4E02690", Offset = "0x4E01290", VA = "0x184E02690", Slot = "26")]
		public override void WriteValue(string value)
		{
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0x4E01E40", Offset = "0x4E00A40", VA = "0x184E01E40", Slot = "27")]
		public override void WriteValue(int value)
		{
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0x4E01CD0", Offset = "0x4E008D0", VA = "0x184E01CD0", Slot = "28")]
		[CLSCompliant(false)]
		public override void WriteValue(uint value)
		{
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0x4E01EB0", Offset = "0x4E00AB0", VA = "0x184E01EB0", Slot = "29")]
		public override void WriteValue(long value)
		{
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0x4E01D80", Offset = "0x4E00980", VA = "0x184E01D80", Slot = "30")]
		[CLSCompliant(false)]
		public override void WriteValue(ulong value)
		{
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0x4E025B0", Offset = "0x4E011B0", VA = "0x184E025B0", Slot = "31")]
		public override void WriteValue(float value)
		{
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0x4E02370", Offset = "0x4E00F70", VA = "0x184E02370", Slot = "32")]
		public override void WriteValue(double value)
		{
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0x4E02540", Offset = "0x4E01140", VA = "0x184E02540", Slot = "33")]
		public override void WriteValue(bool value)
		{
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BA6")]
		[Address(RVA = "0x4E020A0", Offset = "0x4E00CA0", VA = "0x184E020A0", Slot = "34")]
		public override void WriteValue(short value)
		{
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BA7")]
		[Address(RVA = "0x4E01C60", Offset = "0x4E00860", VA = "0x184E01C60", Slot = "35")]
		[CLSCompliant(false)]
		public override void WriteValue(ushort value)
		{
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BA8")]
		[Address(RVA = "0x4E01F20", Offset = "0x4E00B20", VA = "0x184E01F20", Slot = "36")]
		public override void WriteValue(char value)
		{
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BA9")]
		[Address(RVA = "0x4E02230", Offset = "0x4E00E30", VA = "0x184E02230", Slot = "37")]
		public override void WriteValue(byte value)
		{
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BAA")]
		[Address(RVA = "0x4E02620", Offset = "0x4E01220", VA = "0x184E02620", Slot = "38")]
		[CLSCompliant(false)]
		public override void WriteValue(sbyte value)
		{
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BAB")]
		[Address(RVA = "0x4E02110", Offset = "0x4E00D10", VA = "0x184E02110", Slot = "39")]
		public override void WriteValue(decimal value)
		{
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BAC")]
		[Address(RVA = "0x4E023E0", Offset = "0x4E00FE0", VA = "0x184E023E0", Slot = "40")]
		public override void WriteValue(DateTime value)
		{
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BAD")]
		[Address(RVA = "0x4E02020", Offset = "0x4E00C20", VA = "0x184E02020", Slot = "41")]
		public override void WriteValue(DateTimeOffset value)
		{
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BAE")]
		[Address(RVA = "0x4E02190", Offset = "0x4E00D90", VA = "0x184E02190", Slot = "61")]
		public override void WriteValue(byte[] value)
		{
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BAF")]
		[Address(RVA = "0x4E02490", Offset = "0x4E01090", VA = "0x184E02490", Slot = "42")]
		public override void WriteValue(Guid value)
		{
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BB0")]
		[Address(RVA = "0x4E022A0", Offset = "0x4E00EA0", VA = "0x184E022A0", Slot = "43")]
		public override void WriteValue(TimeSpan value)
		{
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BB1")]
		[Address(RVA = "0x4E02750", Offset = "0x4E01350", VA = "0x184E02750", Slot = "62")]
		public override void WriteValue(Uri value)
		{
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BB2")]
		[Address(RVA = "0x4E016F0", Offset = "0x4E002F0", VA = "0x184E016F0")]
		public void WriteObjectId(byte[] value)
		{
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BB3")]
		[Address(RVA = "0x4E01890", Offset = "0x4E00490", VA = "0x184E01890")]
		public void WriteRegex(string pattern, string options)
		{
		}

		// Token: 0x0400046E RID: 1134
		[Token(Token = "0x400046E")]
		[FieldOffset(Offset = "0x60")]
		private readonly BsonBinaryWriter _writer;

		// Token: 0x0400046F RID: 1135
		[Token(Token = "0x400046F")]
		[FieldOffset(Offset = "0x68")]
		private BsonToken _root;

		// Token: 0x04000470 RID: 1136
		[Token(Token = "0x4000470")]
		[FieldOffset(Offset = "0x70")]
		private BsonToken _parent;

		// Token: 0x04000471 RID: 1137
		[Token(Token = "0x4000471")]
		[FieldOffset(Offset = "0x78")]
		private string _propertyName;
	}
}
