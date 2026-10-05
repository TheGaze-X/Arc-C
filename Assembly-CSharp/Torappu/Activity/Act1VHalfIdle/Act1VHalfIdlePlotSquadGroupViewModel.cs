using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007776 RID: 30582
	[Token(Token = "0x2007776")]
	public class Act1VHalfIdlePlotSquadGroupViewModel : IHotfixable
	{
		// Token: 0x0602AF56 RID: 175958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF56")]
		[Address(RVA = "0x26D3060", Offset = "0x26D1C60", VA = "0x1826D3060")]
		public Act1VHalfIdlePlotSquadGroupViewModel()
		{
		}

		// Token: 0x0403DFBE RID: 253886
		[Token(Token = "0x403DFBE")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0403DFBF RID: 253887
		[Token(Token = "0x403DFBF")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;

		// Token: 0x0403DFC0 RID: 253888
		[Token(Token = "0x403DFC0")]
		[FieldOffset(Offset = "0x20")]
		public Act1VHalfIdlePlotType plotType;

		// Token: 0x0403DFC1 RID: 253889
		[Token(Token = "0x403DFC1")]
		[FieldOffset(Offset = "0x28")]
		public List<Act1VHalfidlePlotViewModel> plotList;

		// Token: 0x0403DFC2 RID: 253890
		[Token(Token = "0x403DFC2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
