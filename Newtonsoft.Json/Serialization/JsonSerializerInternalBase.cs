using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000A6 RID: 166
	[Token(Token = "0x20000A6")]
	[Preserve]
	internal abstract class JsonSerializerInternalBase
	{
		// Token: 0x060005FF RID: 1535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x4DA9ED0", Offset = "0x4DA8AD0", VA = "0x184DA9ED0")]
		protected JsonSerializerInternalBase(JsonSerializer serializer)
		{
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012B")]
		internal BidirectionalDictionary<string, object> DefaultReferenceMappings
		{
			[Token(Token = "0x6000600")]
			[Address(RVA = "0x4DA9F80", Offset = "0x4DA8B80", VA = "0x184DA9F80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000601")]
		[Address(RVA = "0x4DA9980", Offset = "0x4DA8580", VA = "0x184DA9980")]
		private ErrorContext GetErrorContext(object currentObject, object member, string path, Exception error)
		{
			return null;
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000602")]
		[Address(RVA = "0x4DA9900", Offset = "0x4DA8500", VA = "0x184DA9900")]
		protected void ClearErrorContext()
		{
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00004500 File Offset: 0x00002700
		[Token(Token = "0x6000603")]
		[Address(RVA = "0x4DA9AC0", Offset = "0x4DA86C0", VA = "0x184DA9AC0")]
		protected bool IsErrorHandled(object currentObject, JsonContract contract, object keyValue, IJsonLineInfo lineInfo, string path, Exception ex)
		{
			return default(bool);
		}

		// Token: 0x040002BC RID: 700
		[Token(Token = "0x40002BC")]
		[FieldOffset(Offset = "0x10")]
		private ErrorContext _currentErrorContext;

		// Token: 0x040002BD RID: 701
		[Token(Token = "0x40002BD")]
		[FieldOffset(Offset = "0x18")]
		private BidirectionalDictionary<string, object> _mappings;

		// Token: 0x040002BE RID: 702
		[Token(Token = "0x40002BE")]
		[FieldOffset(Offset = "0x20")]
		internal readonly JsonSerializer Serializer;

		// Token: 0x040002BF RID: 703
		[Token(Token = "0x40002BF")]
		[FieldOffset(Offset = "0x28")]
		internal readonly ITraceWriter TraceWriter;

		// Token: 0x040002C0 RID: 704
		[Token(Token = "0x40002C0")]
		[FieldOffset(Offset = "0x30")]
		protected JsonSerializerProxy InternalSerializer;

		// Token: 0x020000A7 RID: 167
		[Token(Token = "0x20000A7")]
		private class ReferenceEqualsEqualityComparer : IEqualityComparer<object>
		{
			// Token: 0x06000604 RID: 1540 RVA: 0x00004518 File Offset: 0x00002718
			[Token(Token = "0x6000604")]
			[Address(RVA = "0x281EE50", Offset = "0x281DA50", VA = "0x18281EE50", Slot = "4")]
			private bool Equals(object x, object y)
			{
				return default(bool);
			}

			// Token: 0x06000605 RID: 1541 RVA: 0x00004530 File Offset: 0x00002730
			[Token(Token = "0x6000605")]
			[Address(RVA = "0x281EE60", Offset = "0x281DA60", VA = "0x18281EE60", Slot = "5")]
			private int GetHashCode(object obj)
			{
				return 0;
			}

			// Token: 0x06000606 RID: 1542 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000606")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ReferenceEqualsEqualityComparer()
			{
			}
		}
	}
}
