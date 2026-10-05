using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	[Preserve]
	[Serializable]
	public class JsonSerializationException : JsonException
	{
		// Token: 0x060001E7 RID: 487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x4D65BF0", Offset = "0x4D647F0", VA = "0x184D65BF0")]
		public JsonSerializationException()
		{
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x4D65C40", Offset = "0x4D64840", VA = "0x184D65C40")]
		public JsonSerializationException(string message)
		{
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x4D65CA0", Offset = "0x4D648A0", VA = "0x184D65CA0")]
		public JsonSerializationException(string message, Exception innerException)
		{
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x4D65D10", Offset = "0x4D64910", VA = "0x184D65D10")]
		public JsonSerializationException(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x4D6BB80", Offset = "0x4D6A780", VA = "0x184D6BB80")]
		internal static JsonSerializationException Create(JsonReader reader, string message)
		{
			return null;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x4D6BCC0", Offset = "0x4D6A8C0", VA = "0x184D6BCC0")]
		internal static JsonSerializationException Create(JsonReader reader, string message, Exception ex)
		{
			return null;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x4D6BE10", Offset = "0x4D6AA10", VA = "0x184D6BE10")]
		internal static JsonSerializationException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex)
		{
			return null;
		}
	}
}
