using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CE2 RID: 27874
	[Token(Token = "0x2006CE2")]
	public class TemplateActivityEntryMissionTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x17005DDD RID: 24029
		// (get) Token: 0x06027C07 RID: 162823 RVA: 0x000CF3C0 File Offset: 0x000CD5C0
		[Token(Token = "0x17005DDD")]
		public bool isShow
		{
			[Token(Token = "0x6027C07")]
			[Address(RVA = "0x22FA030", Offset = "0x22F8C30", VA = "0x1822FA030", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06027C08 RID: 162824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027C08")]
		[Address(RVA = "0x22F9E70", Offset = "0x22F8A70", VA = "0x1822F9E70", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x06027C09 RID: 162825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027C09")]
		[Address(RVA = "0x22F9FD0", Offset = "0x22F8BD0", VA = "0x1822F9FD0")]
		public TemplateActivityEntryMissionTrackPointModel()
		{
		}

		// Token: 0x040385F7 RID: 230903
		[Token(Token = "0x40385F7")]
		[FieldOffset(Offset = "0x10")]
		private bool m_hasCanGetRewardMission;

		// Token: 0x040385F8 RID: 230904
		[Token(Token = "0x40385F8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x040385F9 RID: 230905
		[Token(Token = "0x40385F9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x040385FA RID: 230906
		[Token(Token = "0x40385FA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006CE3 RID: 27875
		[Token(Token = "0x2006CE3")]
		public class Param
		{
			// Token: 0x06027C0A RID: 162826 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027C0A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x040385FB RID: 230907
			[Token(Token = "0x40385FB")]
			[FieldOffset(Offset = "0x10")]
			public List<TemplateMissionViewModel> missionViewModels;
		}
	}
}
