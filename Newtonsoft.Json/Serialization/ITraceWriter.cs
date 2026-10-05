using System;
using System.Diagnostics;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200007B RID: 123
	[Token(Token = "0x200007B")]
	[Preserve]
	public interface ITraceWriter
	{
		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000452 RID: 1106
		[Token(Token = "0x170000BA")]
		TraceLevel LevelFilter { [Token(Token = "0x6000452")] get; }

		// Token: 0x06000453 RID: 1107
		[Token(Token = "0x6000453")]
		void Trace(TraceLevel level, string message, Exception ex);
	}
}
