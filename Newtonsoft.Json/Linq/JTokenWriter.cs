using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000D4 RID: 212
	[Token(Token = "0x20000D4")]
	[Preserve]
	public class JTokenWriter : JsonWriter
	{
		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000189")]
		public JToken CurrentToken
		{
			[Token(Token = "0x6000826")]
			[Address(RVA = "0xEB4B80", Offset = "0xEB3780", VA = "0x180EB4B80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700018A")]
		public JToken Token
		{
			[Token(Token = "0x6000827")]
			[Address(RVA = "0x4DC7B10", Offset = "0x4DC6710", VA = "0x184DC7B10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000828")]
		[Address(RVA = "0x4DC7A70", Offset = "0x4DC6670", VA = "0x184DC7A70")]
		public JTokenWriter(JContainer container)
		{
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000829")]
		[Address(RVA = "0x4DC7A20", Offset = "0x4DC6620", VA = "0x184DC7A20")]
		public JTokenWriter()
		{
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600082A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public override void Flush()
		{
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600082B")]
		[Address(RVA = "0x4DC6950", Offset = "0x4DC5550", VA = "0x184DC6950", Slot = "7")]
		public override void Close()
		{
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600082C")]
		[Address(RVA = "0x4DC6D90", Offset = "0x4DC5990", VA = "0x184DC6D90", Slot = "8")]
		public override void WriteStartObject()
		{
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600082D")]
		[Address(RVA = "0x4DC66B0", Offset = "0x4DC52B0", VA = "0x184DC66B0")]
		private void AddParent(JContainer container)
		{
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600082E")]
		[Address(RVA = "0x4DC6960", Offset = "0x4DC5560", VA = "0x184DC6960")]
		private void RemoveParent()
		{
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600082F")]
		[Address(RVA = "0x4DC6C90", Offset = "0x4DC5890", VA = "0x184DC6C90", Slot = "10")]
		public override void WriteStartArray()
		{
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000830")]
		[Address(RVA = "0x4DC6D00", Offset = "0x4DC5900", VA = "0x184DC6D00", Slot = "12")]
		public override void WriteStartConstructor(string name)
		{
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000831")]
		[Address(RVA = "0x4DC6960", Offset = "0x4DC5560", VA = "0x184DC6960", Slot = "18")]
		protected override void WriteEnd(JsonToken token)
		{
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000832")]
		[Address(RVA = "0x4DC6A70", Offset = "0x4DC5670", VA = "0x184DC6A70", Slot = "14")]
		public override void WritePropertyName(string name)
		{
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000833")]
		[Address(RVA = "0x4DC68C0", Offset = "0x4DC54C0", VA = "0x184DC68C0")]
		private void AddValue(object value, JsonToken token)
		{
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000834")]
		[Address(RVA = "0x4DC6790", Offset = "0x4DC5390", VA = "0x184DC6790")]
		internal void AddValue(JValue value, JsonToken token)
		{
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000835")]
		[Address(RVA = "0x4D7B220", Offset = "0x4D79E20", VA = "0x184D7B220", Slot = "63")]
		public override void WriteValue(object value)
		{
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000836")]
		[Address(RVA = "0x4DC6A40", Offset = "0x4DC5640", VA = "0x184DC6A40", Slot = "22")]
		public override void WriteNull()
		{
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000837")]
		[Address(RVA = "0x4DC7110", Offset = "0x4DC5D10", VA = "0x184DC7110", Slot = "23")]
		public override void WriteUndefined()
		{
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000838")]
		[Address(RVA = "0x4DC6C00", Offset = "0x4DC5800", VA = "0x184DC6C00", Slot = "24")]
		public override void WriteRaw(string json)
		{
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000839")]
		[Address(RVA = "0x4DC6A00", Offset = "0x4DC5600", VA = "0x184DC6A00", Slot = "64")]
		public override void WriteComment(string text)
		{
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600083A")]
		[Address(RVA = "0x4DC7220", Offset = "0x4DC5E20", VA = "0x184DC7220", Slot = "26")]
		public override void WriteValue(string value)
		{
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600083B")]
		[Address(RVA = "0x4DC7470", Offset = "0x4DC6070", VA = "0x184DC7470", Slot = "27")]
		public override void WriteValue(int value)
		{
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600083C")]
		[Address(RVA = "0x4DC7260", Offset = "0x4DC5E60", VA = "0x184DC7260", Slot = "28")]
		[CLSCompliant(false)]
		public override void WriteValue(uint value)
		{
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600083D")]
		[Address(RVA = "0x4DC74E0", Offset = "0x4DC60E0", VA = "0x184DC74E0", Slot = "29")]
		public override void WriteValue(long value)
		{
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600083E")]
		[Address(RVA = "0x4DC73C0", Offset = "0x4DC5FC0", VA = "0x184DC73C0", Slot = "30")]
		[CLSCompliant(false)]
		public override void WriteValue(ulong value)
		{
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600083F")]
		[Address(RVA = "0x4DC7350", Offset = "0x4DC5F50", VA = "0x184DC7350", Slot = "31")]
		public override void WriteValue(float value)
		{
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000840")]
		[Address(RVA = "0x4DC7900", Offset = "0x4DC6500", VA = "0x184DC7900", Slot = "32")]
		public override void WriteValue(double value)
		{
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000841")]
		[Address(RVA = "0x4DC7770", Offset = "0x4DC6370", VA = "0x184DC7770", Slot = "33")]
		public override void WriteValue(bool value)
		{
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000842")]
		[Address(RVA = "0x4DC77E0", Offset = "0x4DC63E0", VA = "0x184DC77E0", Slot = "34")]
		public override void WriteValue(short value)
		{
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000843")]
		[Address(RVA = "0x4DC7690", Offset = "0x4DC6290", VA = "0x184DC7690", Slot = "35")]
		[CLSCompliant(false)]
		public override void WriteValue(ushort value)
		{
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000844")]
		[Address(RVA = "0x4DC7850", Offset = "0x4DC6450", VA = "0x184DC7850", Slot = "36")]
		public override void WriteValue(char value)
		{
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000845")]
		[Address(RVA = "0x4DC71B0", Offset = "0x4DC5DB0", VA = "0x184DC71B0", Slot = "37")]
		public override void WriteValue(byte value)
		{
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000846")]
		[Address(RVA = "0x4DC7140", Offset = "0x4DC5D40", VA = "0x184DC7140", Slot = "38")]
		[CLSCompliant(false)]
		public override void WriteValue(sbyte value)
		{
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000847")]
		[Address(RVA = "0x4DC72D0", Offset = "0x4DC5ED0", VA = "0x184DC72D0", Slot = "39")]
		public override void WriteValue(decimal value)
		{
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000848")]
		[Address(RVA = "0x4DC7970", Offset = "0x4DC6570", VA = "0x184DC7970", Slot = "40")]
		public override void WriteValue(DateTime value)
		{
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000849")]
		[Address(RVA = "0x4DC7610", Offset = "0x4DC6210", VA = "0x184DC7610", Slot = "41")]
		public override void WriteValue(DateTimeOffset value)
		{
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600084A")]
		[Address(RVA = "0x4DC7550", Offset = "0x4DC6150", VA = "0x184DC7550", Slot = "61")]
		public override void WriteValue(byte[] value)
		{
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600084B")]
		[Address(RVA = "0x4DC7700", Offset = "0x4DC6300", VA = "0x184DC7700", Slot = "43")]
		public override void WriteValue(TimeSpan value)
		{
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600084C")]
		[Address(RVA = "0x4DC7590", Offset = "0x4DC6190", VA = "0x184DC7590", Slot = "42")]
		public override void WriteValue(Guid value)
		{
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600084D")]
		[Address(RVA = "0x4DC7430", Offset = "0x4DC6030", VA = "0x184DC7430", Slot = "62")]
		public override void WriteValue(Uri value)
		{
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600084E")]
		[Address(RVA = "0x4DC6E00", Offset = "0x4DC5A00", VA = "0x184DC6E00", Slot = "17")]
		internal override void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments)
		{
		}

		// Token: 0x04000338 RID: 824
		[Token(Token = "0x4000338")]
		[FieldOffset(Offset = "0x60")]
		private JContainer _token;

		// Token: 0x04000339 RID: 825
		[Token(Token = "0x4000339")]
		[FieldOffset(Offset = "0x68")]
		private JContainer _parent;

		// Token: 0x0400033A RID: 826
		[Token(Token = "0x400033A")]
		[FieldOffset(Offset = "0x70")]
		private JValue _value;

		// Token: 0x0400033B RID: 827
		[Token(Token = "0x400033B")]
		[FieldOffset(Offset = "0x78")]
		private JToken _current;
	}
}
