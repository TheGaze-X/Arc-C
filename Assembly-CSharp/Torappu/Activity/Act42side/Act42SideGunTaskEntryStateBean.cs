using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act42side
{
	// Token: 0x02007321 RID: 29473
	[Token(Token = "0x2007321")]
	public class Act42SideGunTaskEntryStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06029ADA RID: 170714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029ADA")]
		[Address(RVA = "0x250D4C0", Offset = "0x250C0C0", VA = "0x18250D4C0")]
		public Act42SideGunTaskEntryStateBean()
		{
		}

		// Token: 0x0403BA1E RID: 244254
		[Token(Token = "0x403BA1E")]
		[FieldOffset(Offset = "0x10")]
		public Act42sideGunTaskEntryProperty prop;

		// Token: 0x0403BA1F RID: 244255
		[Token(Token = "0x403BA1F")]
		[FieldOffset(Offset = "0x18")]
		public TrackPointViewProperty rewardTrack;

		// Token: 0x0403BA20 RID: 244256
		[Token(Token = "0x403BA20")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
