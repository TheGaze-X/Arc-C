using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	[Preserve]
	[Serializable]
	public class JsonException : Exception
	{
		// Token: 0x06000032 RID: 50 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x4D65BF0", Offset = "0x4D647F0", VA = "0x184D65BF0")]
		public JsonException()
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x4D65C40", Offset = "0x4D64840", VA = "0x184D65C40")]
		public JsonException(string message)
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x4D65CA0", Offset = "0x4D648A0", VA = "0x184D65CA0")]
		public JsonException(string message, Exception innerException)
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x4D65D10", Offset = "0x4D64910", VA = "0x184D65D10")]
		public JsonException(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x4D65B10", Offset = "0x4D64710", VA = "0x184D65B10")]
		internal static JsonException Create(IJsonLineInfo lineInfo, string path, string message)
		{
			return null;
		}
	}
}
