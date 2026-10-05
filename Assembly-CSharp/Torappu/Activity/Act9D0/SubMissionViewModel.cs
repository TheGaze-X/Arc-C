using System;
using Il2CppDummyDll;
using Torappu.UI.Mission;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x02007183 RID: 29059
	[Token(Token = "0x2007183")]
	public class SubMissionViewModel
	{
		// Token: 0x060293FE RID: 168958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293FE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SubMissionViewModel()
		{
		}

		// Token: 0x0403AEA4 RID: 241316
		[Token(Token = "0x403AEA4")]
		[FieldOffset(Offset = "0x10")]
		public MissionViewModel viewModel;

		// Token: 0x0403AEA5 RID: 241317
		[Token(Token = "0x403AEA5")]
		[FieldOffset(Offset = "0x18")]
		public Act9D0Data.SubMissionInfo subMissionInfo;
	}
}
