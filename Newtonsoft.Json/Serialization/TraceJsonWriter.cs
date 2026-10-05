using System;
using System.IO;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000080 RID: 128
	[Token(Token = "0x2000080")]
	[Preserve]
	internal class TraceJsonWriter : JsonWriter
	{
		// Token: 0x0600047F RID: 1151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600047F")]
		[Address(RVA = "0x4D9AB90", Offset = "0x4D99790", VA = "0x184D9AB90")]
		public TraceJsonWriter(JsonWriter innerWriter)
		{
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000480")]
		[Address(RVA = "0x4D990D0", Offset = "0x4D97CD0", VA = "0x184D990D0")]
		public string GetSerializedJsonMessage()
		{
			return null;
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000481")]
		[Address(RVA = "0x4D99B10", Offset = "0x4D98710", VA = "0x184D99B10", Slot = "39")]
		public override void WriteValue(decimal value)
		{
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000482")]
		[Address(RVA = "0x4D99D40", Offset = "0x4D98940", VA = "0x184D99D40", Slot = "33")]
		public override void WriteValue(bool value)
		{
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000483")]
		[Address(RVA = "0x4D999C0", Offset = "0x4D985C0", VA = "0x184D999C0", Slot = "37")]
		public override void WriteValue(byte value)
		{
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000484")]
		[Address(RVA = "0x4D9A0B0", Offset = "0x4D98CB0", VA = "0x184D9A0B0", Slot = "54")]
		public override void WriteValue(byte? value)
		{
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000485")]
		[Address(RVA = "0x4D99DF0", Offset = "0x4D989F0", VA = "0x184D99DF0", Slot = "36")]
		public override void WriteValue(char value)
		{
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000486")]
		[Address(RVA = "0x4D9A8B0", Offset = "0x4D994B0", VA = "0x184D9A8B0", Slot = "61")]
		public override void WriteValue(byte[] value)
		{
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000487")]
		[Address(RVA = "0x4D9A750", Offset = "0x4D99350", VA = "0x184D9A750", Slot = "40")]
		public override void WriteValue(DateTime value)
		{
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000488")]
		[Address(RVA = "0x4D99BD0", Offset = "0x4D987D0", VA = "0x184D99BD0", Slot = "41")]
		public override void WriteValue(DateTimeOffset value)
		{
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000489")]
		[Address(RVA = "0x4D99C90", Offset = "0x4D98890", VA = "0x184D99C90", Slot = "32")]
		public override void WriteValue(double value)
		{
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600048A")]
		[Address(RVA = "0x4D99880", Offset = "0x4D98480", VA = "0x184D99880", Slot = "23")]
		public override void WriteUndefined()
		{
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600048B")]
		[Address(RVA = "0x4D99370", Offset = "0x4D97F70", VA = "0x184D99370", Slot = "22")]
		public override void WriteNull()
		{
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600048C")]
		[Address(RVA = "0x4D9A3C0", Offset = "0x4D98FC0", VA = "0x184D9A3C0", Slot = "31")]
		public override void WriteValue(float value)
		{
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600048D")]
		[Address(RVA = "0x4D9A1E0", Offset = "0x4D98DE0", VA = "0x184D9A1E0", Slot = "42")]
		public override void WriteValue(Guid value)
		{
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600048E")]
		[Address(RVA = "0x4D99A70", Offset = "0x4D98670", VA = "0x184D99A70", Slot = "27")]
		public override void WriteValue(int value)
		{
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600048F")]
		[Address(RVA = "0x4D9A510", Offset = "0x4D99110", VA = "0x184D9A510", Slot = "29")]
		public override void WriteValue(long value)
		{
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000490")]
		[Address(RVA = "0x4D9A5C0", Offset = "0x4D991C0", VA = "0x184D9A5C0", Slot = "63")]
		public override void WriteValue(object value)
		{
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000491")]
		[Address(RVA = "0x4D99910", Offset = "0x4D98510", VA = "0x184D99910", Slot = "38")]
		public override void WriteValue(sbyte value)
		{
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x4D9A9A0", Offset = "0x4D995A0", VA = "0x184D9A9A0", Slot = "34")]
		public override void WriteValue(short value)
		{
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000493")]
		[Address(RVA = "0x4D99EA0", Offset = "0x4D98AA0", VA = "0x184D99EA0", Slot = "26")]
		public override void WriteValue(string value)
		{
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000494")]
		[Address(RVA = "0x4D99F50", Offset = "0x4D98B50", VA = "0x184D99F50", Slot = "43")]
		public override void WriteValue(TimeSpan value)
		{
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000495")]
		[Address(RVA = "0x4D9A470", Offset = "0x4D99070", VA = "0x184D9A470", Slot = "28")]
		public override void WriteValue(uint value)
		{
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000496")]
		[Address(RVA = "0x4D9A800", Offset = "0x4D99400", VA = "0x184D9A800", Slot = "30")]
		public override void WriteValue(ulong value)
		{
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000497")]
		[Address(RVA = "0x4D9A2A0", Offset = "0x4D98EA0", VA = "0x184D9A2A0", Slot = "62")]
		public override void WriteValue(Uri value)
		{
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x4D9A000", Offset = "0x4D98C00", VA = "0x184D9A000", Slot = "35")]
		public override void WriteValue(ushort value)
		{
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x4D9AA50", Offset = "0x4D99650", VA = "0x184D9AA50", Slot = "65")]
		public override void WriteWhitespace(string ws)
		{
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600049A")]
		[Address(RVA = "0x4D99120", Offset = "0x4D97D20", VA = "0x184D99120", Slot = "64")]
		public override void WriteComment(string text)
		{
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600049B")]
		[Address(RVA = "0x4D996C0", Offset = "0x4D982C0", VA = "0x184D996C0", Slot = "10")]
		public override void WriteStartArray()
		{
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600049C")]
		[Address(RVA = "0x4D991C0", Offset = "0x4D97DC0", VA = "0x184D991C0", Slot = "11")]
		public override void WriteEndArray()
		{
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600049D")]
		[Address(RVA = "0x4D99750", Offset = "0x4D98350", VA = "0x184D99750", Slot = "12")]
		public override void WriteStartConstructor(string name)
		{
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600049E")]
		[Address(RVA = "0x4D99250", Offset = "0x4D97E50", VA = "0x184D99250", Slot = "13")]
		public override void WriteEndConstructor()
		{
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600049F")]
		[Address(RVA = "0x4D99400", Offset = "0x4D98000", VA = "0x184D99400", Slot = "14")]
		public override void WritePropertyName(string name)
		{
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x4D994B0", Offset = "0x4D980B0", VA = "0x184D994B0", Slot = "15")]
		public override void WritePropertyName(string name, bool escape)
		{
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x4D997F0", Offset = "0x4D983F0", VA = "0x184D997F0", Slot = "8")]
		public override void WriteStartObject()
		{
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x4D992E0", Offset = "0x4D97EE0", VA = "0x184D992E0", Slot = "9")]
		public override void WriteEndObject()
		{
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x4D99580", Offset = "0x4D98180", VA = "0x184D99580", Slot = "25")]
		public override void WriteRawValue(string json)
		{
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x4D99630", Offset = "0x4D98230", VA = "0x184D99630", Slot = "24")]
		public override void WriteRaw(string json)
		{
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x4D98F60", Offset = "0x4D97B60", VA = "0x184D98F60", Slot = "7")]
		public override void Close()
		{
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x4D99050", Offset = "0x4D97C50", VA = "0x184D99050", Slot = "6")]
		public override void Flush()
		{
		}

		// Token: 0x04000217 RID: 535
		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x60")]
		private readonly JsonWriter _innerWriter;

		// Token: 0x04000218 RID: 536
		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x68")]
		private readonly JsonTextWriter _textWriter;

		// Token: 0x04000219 RID: 537
		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x70")]
		private readonly StringWriter _sw;
	}
}
