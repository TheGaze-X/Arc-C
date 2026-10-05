using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F2A RID: 28458
	[Token(Token = "0x2006F2A")]
	public class ActMultiV3DailyMissionViewModel : IHotfixable
	{
		// Token: 0x060286D5 RID: 165589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286D5")]
		[Address(RVA = "0x23AA730", Offset = "0x23A9330", VA = "0x1823AA730")]
		public void LoadData(string actId, PlayerActivity.PlayerMultiV3Activity playerActivity, ActMultiV3Data actData)
		{
		}

		// Token: 0x060286D6 RID: 165590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286D6")]
		[Address(RVA = "0x23AA820", Offset = "0x23A9420", VA = "0x1823AA820")]
		public ActMultiV3DailyMissionViewModel()
		{
		}

		// Token: 0x040397F2 RID: 235506
		[Token(Token = "0x40397F2")]
		[FieldOffset(Offset = "0x10")]
		public int maxDailyMissionPoint;

		// Token: 0x040397F3 RID: 235507
		[Token(Token = "0x40397F3")]
		[FieldOffset(Offset = "0x14")]
		public int currDailyMissionPoint;

		// Token: 0x040397F4 RID: 235508
		[Token(Token = "0x40397F4")]
		[FieldOffset(Offset = "0x18")]
		public bool completed;

		// Token: 0x040397F5 RID: 235509
		[Token(Token = "0x40397F5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040397F6 RID: 235510
		[Token(Token = "0x40397F6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
