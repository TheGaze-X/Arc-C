using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003AB8 RID: 15032
	[Token(Token = "0x2003AB8")]
	public struct HiddenStageMissionPushMsg
	{
		// Token: 0x0401CA49 RID: 117321
		[Token(Token = "0x401CA49")]
		[FieldOffset(Offset = "0x0")]
		public string stageId;

		// Token: 0x0401CA4A RID: 117322
		[Token(Token = "0x401CA4A")]
		[FieldOffset(Offset = "0x8")]
		public int missionIdx;

		// Token: 0x0401CA4B RID: 117323
		[Token(Token = "0x401CA4B")]
		[FieldOffset(Offset = "0xC")]
		public int state;
	}
}
