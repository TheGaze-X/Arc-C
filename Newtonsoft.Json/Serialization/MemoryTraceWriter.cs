using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200007D RID: 125
	[Token(Token = "0x200007D")]
	[Preserve]
	public class MemoryTraceWriter : ITraceWriter
	{
		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x00003CA8 File Offset: 0x00001EA8
		// (set) Token: 0x06000461 RID: 1121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000C1")]
		public TraceLevel LevelFilter
		{
			[Token(Token = "0x6000460")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return TraceLevel.Off;
			}
			[Token(Token = "0x6000461")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000462")]
		[Address(RVA = "0x4D8FEE0", Offset = "0x4D8EAE0", VA = "0x184D8FEE0")]
		public MemoryTraceWriter()
		{
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000463")]
		[Address(RVA = "0x4D8FCC0", Offset = "0x4D8E8C0", VA = "0x184D8FCC0", Slot = "5")]
		public void Trace(TraceLevel level, string message, Exception ex)
		{
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000464")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
		public IEnumerable<string> GetTraceMessages()
		{
			return null;
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000465")]
		[Address(RVA = "0x4D8FB20", Offset = "0x4D8E720", VA = "0x184D8FB20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000211 RID: 529
		[Token(Token = "0x4000211")]
		[FieldOffset(Offset = "0x10")]
		private readonly Queue<string> _traceMessages;
	}
}
