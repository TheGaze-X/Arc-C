using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	[Preserve]
	[Serializable]
	public class JsonWriterException : JsonException
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000143 RID: 323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700004F")]
		public string Path
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x789270", Offset = "0x787E70", VA = "0x180789270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x1FC11F0", Offset = "0x1FBFDF0", VA = "0x181FC11F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x4D65BF0", Offset = "0x4D647F0", VA = "0x184D65BF0")]
		public JsonWriterException()
		{
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x4D65C40", Offset = "0x4D64840", VA = "0x184D65C40")]
		public JsonWriterException(string message)
		{
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x4D65CA0", Offset = "0x4D648A0", VA = "0x184D65CA0")]
		public JsonWriterException(string message, Exception innerException)
		{
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x4D65D10", Offset = "0x4D64910", VA = "0x184D65D10")]
		public JsonWriterException(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x4D7C9C0", Offset = "0x4D7B5C0", VA = "0x184D7C9C0")]
		internal JsonWriterException(string message, Exception innerException, string path)
		{
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x4D7C8B0", Offset = "0x4D7B4B0", VA = "0x184D7C8B0")]
		internal static JsonWriterException Create(JsonWriter writer, string message, Exception ex)
		{
			return null;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x4D7C7B0", Offset = "0x4D7B3B0", VA = "0x184D7C7B0")]
		internal static JsonWriterException Create(string path, string message, Exception ex)
		{
			return null;
		}
	}
}
