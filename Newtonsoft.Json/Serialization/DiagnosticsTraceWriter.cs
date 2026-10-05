using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000079 RID: 121
	[Token(Token = "0x2000079")]
	[Preserve]
	public class DiagnosticsTraceWriter : ITraceWriter
	{
		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x00003C30 File Offset: 0x00001E30
		// (set) Token: 0x0600044C RID: 1100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000B9")]
		public TraceLevel LevelFilter
		{
			[Token(Token = "0x600044B")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return TraceLevel.Off;
			}
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00003C48 File Offset: 0x00001E48
		[Token(Token = "0x600044D")]
		[Address(RVA = "0x4D86750", Offset = "0x4D85350", VA = "0x184D86750")]
		private TraceEventType GetTraceEventType(TraceLevel level)
		{
			return (TraceEventType)0;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600044E")]
		[Address(RVA = "0x4D867F0", Offset = "0x4D853F0", VA = "0x184D867F0", Slot = "5")]
		public void Trace(TraceLevel level, string message, Exception ex)
		{
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600044F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DiagnosticsTraceWriter()
		{
		}
	}
}
