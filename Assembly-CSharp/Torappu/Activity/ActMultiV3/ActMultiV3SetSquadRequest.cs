using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006EC9 RID: 28361
	[Token(Token = "0x2006EC9")]
	public class ActMultiV3SetSquadRequest
	{
		// Token: 0x06028540 RID: 165184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028540")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActMultiV3SetSquadRequest()
		{
		}

		// Token: 0x0403951A RID: 234778
		[Token(Token = "0x403951A")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403951B RID: 234779
		[Token(Token = "0x403951B")]
		[FieldOffset(Offset = "0x18")]
		public ActMultiV3MapModeType modeType;

		// Token: 0x0403951C RID: 234780
		[Token(Token = "0x403951C")]
		[FieldOffset(Offset = "0x20")]
		public List<RequestSquadSlot> prefer;

		// Token: 0x0403951D RID: 234781
		[Token(Token = "0x403951D")]
		[FieldOffset(Offset = "0x28")]
		public List<RequestSquadSlot> backup;
	}
}
