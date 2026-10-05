using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Carving
{
	// Token: 0x020060B5 RID: 24757
	[Token(Token = "0x20060B5")]
	public class CarvingProcessRequest
	{
		// Token: 0x06023CC5 RID: 146629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023CC5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CarvingProcessRequest()
		{
		}

		// Token: 0x04031A25 RID: 203301
		[Token(Token = "0x4031A25")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x04031A26 RID: 203302
		[Token(Token = "0x4031A26")]
		[FieldOffset(Offset = "0x18")]
		public List<string> cards;
	}
}
