using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x02007A26 RID: 31270
	[Token(Token = "0x2007A26")]
	public class Act13sideDailyMissionTrackPoint : ITrackPointModel, IHotfixable
	{
		// Token: 0x170066C1 RID: 26305
		// (get) Token: 0x0602BD22 RID: 179490 RVA: 0x000DD550 File Offset: 0x000DB750
		[Token(Token = "0x170066C1")]
		public bool isShow
		{
			[Token(Token = "0x602BD22")]
			[Address(RVA = "0x27B4170", Offset = "0x27B2D70", VA = "0x1827B4170", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602BD23 RID: 179491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD23")]
		[Address(RVA = "0x27B4050", Offset = "0x27B2C50", VA = "0x1827B4050", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0602BD24 RID: 179492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD24")]
		[Address(RVA = "0x27B4110", Offset = "0x27B2D10", VA = "0x1827B4110")]
		public Act13sideDailyMissionTrackPoint()
		{
		}

		// Token: 0x0403F681 RID: 259713
		[Token(Token = "0x403F681")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x0403F682 RID: 259714
		[Token(Token = "0x403F682")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403F683 RID: 259715
		[Token(Token = "0x403F683")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403F684 RID: 259716
		[Token(Token = "0x403F684")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
