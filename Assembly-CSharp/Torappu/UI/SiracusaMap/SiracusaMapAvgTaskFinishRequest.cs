using System;
using Il2CppDummyDll;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F61 RID: 16225
	[Token(Token = "0x2003F61")]
	public class SiracusaMapAvgTaskFinishRequest
	{
		// Token: 0x06019306 RID: 103174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019306")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SiracusaMapAvgTaskFinishRequest()
		{
		}

		// Token: 0x0401F3BA RID: 127930
		[Token(Token = "0x401F3BA")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x0401F3BB RID: 127931
		[Token(Token = "0x401F3BB")]
		[FieldOffset(Offset = "0x18")]
		public string taskId;
	}
}
