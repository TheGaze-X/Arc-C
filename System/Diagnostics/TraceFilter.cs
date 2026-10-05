using System;
using Il2CppDummyDll;

namespace System.Diagnostics
{
	// Token: 0x02000105 RID: 261
	[Token(Token = "0x2000105")]
	public abstract class TraceFilter
	{
		// Token: 0x0600066A RID: 1642
		[Token(Token = "0x600066A")]
		public abstract bool ShouldTrace(TraceEventCache cache, string source, TraceEventType eventType, int id, string formatOrMessage, object[] args, object data1, object[] data);

		// Token: 0x0600066B RID: 1643 RVA: 0x00004908 File Offset: 0x00002B08
		[Token(Token = "0x600066B")]
		[Address(RVA = "0x5119C50", Offset = "0x5118850", VA = "0x185119C50")]
		internal bool ShouldTrace(TraceEventCache cache, string source, TraceEventType eventType, int id, string formatOrMessage)
		{
			return default(bool);
		}
	}
}
