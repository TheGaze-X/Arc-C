using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x020079F4 RID: 31220
	[Token(Token = "0x20079F4")]
	public class Act13sideMissionFinishViewModel
	{
		// Token: 0x0602BC3F RID: 179263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC3F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act13sideMissionFinishViewModel()
		{
		}

		// Token: 0x0403F50E RID: 259342
		[Token(Token = "0x403F50E")]
		[FieldOffset(Offset = "0x10")]
		public int startP;

		// Token: 0x0403F50F RID: 259343
		[Token(Token = "0x403F50F")]
		[FieldOffset(Offset = "0x14")]
		public int endP;

		// Token: 0x0403F510 RID: 259344
		[Token(Token = "0x403F510")]
		[FieldOffset(Offset = "0x18")]
		public string orgId;

		// Token: 0x0403F511 RID: 259345
		[Token(Token = "0x403F511")]
		[FieldOffset(Offset = "0x20")]
		public List<Act13SideEachMissionInfo> missionInfoList;
	}
}
