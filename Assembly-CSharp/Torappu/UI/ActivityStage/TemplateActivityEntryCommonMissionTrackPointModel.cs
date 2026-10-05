using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006C81 RID: 27777
	[Token(Token = "0x2006C81")]
	public class TemplateActivityEntryCommonMissionTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x17005DAD RID: 23981
		// (get) Token: 0x06027A36 RID: 162358 RVA: 0x000CEF40 File Offset: 0x000CD140
		[Token(Token = "0x17005DAD")]
		public bool isShow
		{
			[Token(Token = "0x6027A36")]
			[Address(RVA = "0x22CC3D0", Offset = "0x22CAFD0", VA = "0x1822CC3D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06027A37 RID: 162359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A37")]
		[Address(RVA = "0x22CC2A0", Offset = "0x22CAEA0", VA = "0x1822CC2A0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x06027A38 RID: 162360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A38")]
		[Address(RVA = "0x22CC370", Offset = "0x22CAF70", VA = "0x1822CC370")]
		public TemplateActivityEntryCommonMissionTrackPointModel()
		{
		}

		// Token: 0x0403837B RID: 230267
		[Token(Token = "0x403837B")]
		[FieldOffset(Offset = "0x10")]
		private bool m_hasCanGetRewardMission;

		// Token: 0x0403837C RID: 230268
		[Token(Token = "0x403837C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403837D RID: 230269
		[Token(Token = "0x403837D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403837E RID: 230270
		[Token(Token = "0x403837E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006C82 RID: 27778
		[Token(Token = "0x2006C82")]
		public class Param
		{
			// Token: 0x06027A39 RID: 162361 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027A39")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x0403837F RID: 230271
			[Token(Token = "0x403837F")]
			[FieldOffset(Offset = "0x10")]
			public bool hasCanGetRewardMission;
		}
	}
}
