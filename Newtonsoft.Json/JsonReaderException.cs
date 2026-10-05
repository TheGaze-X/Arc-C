using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	[Preserve]
	[Serializable]
	public class JsonReaderException : JsonException
	{
		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00002748 File Offset: 0x00000948
		// (set) Token: 0x0600014C RID: 332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000050")]
		public int LineNumber
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x4D67380", Offset = "0x4D65F80", VA = "0x184D67380")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x4D67390", Offset = "0x4D65F90", VA = "0x184D67390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00002760 File Offset: 0x00000960
		// (set) Token: 0x0600014E RID: 334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000051")]
		public int LinePosition
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x42BAD30", Offset = "0x42B9930", VA = "0x1842BAD30")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x42BAE40", Offset = "0x42B9A40", VA = "0x1842BAE40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600014F RID: 335 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000150 RID: 336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000052")]
		public string Path
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0xF93800", Offset = "0xF92400", VA = "0x180F93800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000150")]
			[Address(RVA = "0xF93850", Offset = "0xF92450", VA = "0x180F93850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x4D65BF0", Offset = "0x4D647F0", VA = "0x184D65BF0")]
		public JsonReaderException()
		{
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x4D65C40", Offset = "0x4D64840", VA = "0x184D65C40")]
		public JsonReaderException(string message)
		{
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x4D65CA0", Offset = "0x4D648A0", VA = "0x184D65CA0")]
		public JsonReaderException(string message, Exception innerException)
		{
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x4D65D10", Offset = "0x4D64910", VA = "0x184D65D10")]
		public JsonReaderException(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x4D672E0", Offset = "0x4D65EE0", VA = "0x184D672E0")]
		internal JsonReaderException(string message, Exception innerException, string path, int lineNumber, int linePosition)
		{
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x4D672D0", Offset = "0x4D65ED0", VA = "0x184D672D0")]
		internal static JsonReaderException Create(JsonReader reader, string message)
		{
			return null;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x4D67110", Offset = "0x4D65D10", VA = "0x184D67110")]
		internal static JsonReaderException Create(JsonReader reader, string message, Exception ex)
		{
			return null;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x4D66FA0", Offset = "0x4D65BA0", VA = "0x184D66FA0")]
		internal static JsonReaderException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex)
		{
			return null;
		}
	}
}
