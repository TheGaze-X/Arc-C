using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x02007184 RID: 29060
	[Token(Token = "0x2007184")]
	public class Act9D0MissionTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x170061A2 RID: 24994
		// (get) Token: 0x060293FF RID: 168959 RVA: 0x000D4DC0 File Offset: 0x000D2FC0
		[Token(Token = "0x170061A2")]
		public bool isShow
		{
			[Token(Token = "0x60293FF")]
			[Address(RVA = "0x249D270", Offset = "0x249BE70", VA = "0x18249D270", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06029400 RID: 168960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029400")]
		[Address(RVA = "0x249D040", Offset = "0x249BC40", VA = "0x18249D040", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x06029401 RID: 168961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029401")]
		[Address(RVA = "0x249D210", Offset = "0x249BE10", VA = "0x18249D210")]
		public Act9D0MissionTrackPointModel()
		{
		}

		// Token: 0x0403AEA6 RID: 241318
		[Token(Token = "0x403AEA6")]
		[FieldOffset(Offset = "0x10")]
		private bool m_hasCanGetRewardMission;

		// Token: 0x0403AEA7 RID: 241319
		[Token(Token = "0x403AEA7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403AEA8 RID: 241320
		[Token(Token = "0x403AEA8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403AEA9 RID: 241321
		[Token(Token = "0x403AEA9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
