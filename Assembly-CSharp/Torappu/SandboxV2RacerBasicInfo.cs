using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x020012ED RID: 4845
	[Token(Token = "0x20012ED")]
	public class SandboxV2RacerBasicInfo
	{
		// Token: 0x06007266 RID: 29286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007266")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2RacerBasicInfo()
		{
		}

		// Token: 0x04006B02 RID: 27394
		[Token(Token = "0x4006B02")]
		[FieldOffset(Offset = "0x10")]
		public string racerId;

		// Token: 0x04006B03 RID: 27395
		[Token(Token = "0x4006B03")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04006B04 RID: 27396
		[Token(Token = "0x4006B04")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty(PropertyName = "racerName")]
		public string racerTypeName;

		// Token: 0x04006B05 RID: 27397
		[Token(Token = "0x4006B05")]
		[FieldOffset(Offset = "0x28")]
		public string itemId;

		// Token: 0x04006B06 RID: 27398
		[Token(Token = "0x4006B06")]
		[FieldOffset(Offset = "0x30")]
		public List<int> attributeMaxValue;
	}
}
