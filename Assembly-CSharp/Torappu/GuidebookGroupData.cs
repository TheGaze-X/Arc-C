using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200100F RID: 4111
	[Token(Token = "0x200100F")]
	public class GuidebookGroupData
	{
		// Token: 0x06006D64 RID: 28004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D64")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GuidebookGroupData()
		{
		}

		// Token: 0x04005757 RID: 22359
		[Token(Token = "0x4005757")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x04005758 RID: 22360
		[Token(Token = "0x4005758")]
		[FieldOffset(Offset = "0x18")]
		public UIGuideTarget guideTarget;

		// Token: 0x04005759 RID: 22361
		[Token(Token = "0x4005759")]
		[FieldOffset(Offset = "0x20")]
		public string subSignal;

		// Token: 0x0400575A RID: 22362
		[Token(Token = "0x400575A")]
		[FieldOffset(Offset = "0x28")]
		public List<GuidebookConfigData> configList;
	}
}
