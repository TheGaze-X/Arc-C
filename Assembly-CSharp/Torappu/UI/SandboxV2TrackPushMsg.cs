using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003B57 RID: 15191
	[Token(Token = "0x2003B57")]
	public struct SandboxV2TrackPushMsg
	{
		// Token: 0x0401CCCF RID: 117967
		[Token(Token = "0x401CCCF")]
		[FieldOffset(Offset = "0x0")]
		public string topicId;

		// Token: 0x0401CCD0 RID: 117968
		[Token(Token = "0x401CCD0")]
		[FieldOffset(Offset = "0x8")]
		public SandboxV2TrackType trackType;

		// Token: 0x0401CCD1 RID: 117969
		[Token(Token = "0x401CCD1")]
		[FieldOffset(Offset = "0x10")]
		public List<string> extraInfos;
	}
}
