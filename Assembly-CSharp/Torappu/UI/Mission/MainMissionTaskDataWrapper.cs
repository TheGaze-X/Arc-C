using System;
using Il2CppDummyDll;

namespace Torappu.UI.Mission
{
	// Token: 0x02004896 RID: 18582
	[Token(Token = "0x2004896")]
	public struct MainMissionTaskDataWrapper
	{
		// Token: 0x040249E5 RID: 149989
		[Token(Token = "0x40249E5")]
		[FieldOffset(Offset = "0x0")]
		public MissionViewModel model;

		// Token: 0x040249E6 RID: 149990
		[Token(Token = "0x40249E6")]
		[FieldOffset(Offset = "0x8")]
		public int originIndex;

		// Token: 0x040249E7 RID: 149991
		[Token(Token = "0x40249E7")]
		[FieldOffset(Offset = "0xC")]
		public bool useCustomStyle;
	}
}
