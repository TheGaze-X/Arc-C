using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CE4 RID: 27876
	[Token(Token = "0x2006CE4")]
	public class TemplateActivityFavorViewModel : TemplateActivityViewModel
	{
		// Token: 0x06027C0B RID: 162827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027C0B")]
		[Address(RVA = "0x22FA090", Offset = "0x22F8C90", VA = "0x1822FA090")]
		public TemplateActivityFavorViewModel(object param)
		{
		}

		// Token: 0x17005DDE RID: 24030
		// (get) Token: 0x06027C0C RID: 162828 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027C0D RID: 162829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005DDE")]
		public TemplateActivityFavorViewModel.FavorEntryTrackPointModel.Param trackPointParam
		{
			[Token(Token = "0x6027C0C")]
			[Address(RVA = "0x22FA2E0", Offset = "0x22F8EE0", VA = "0x1822FA2E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6027C0D")]
			[Address(RVA = "0x22FA340", Offset = "0x22F8F40", VA = "0x1822FA340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x040385FC RID: 230908
		[Token(Token = "0x40385FC")]
		[FieldOffset(Offset = "0x20")]
		public List<string> favorCharList;

		// Token: 0x040385FD RID: 230909
		[Token(Token = "0x40385FD")]
		[FieldOffset(Offset = "0x28")]
		public TrackPointViewProperty homeViewTrackPoint;

		// Token: 0x040385FF RID: 230911
		[Token(Token = "0x40385FF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04038600 RID: 230912
		[Token(Token = "0x4038600")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_trackPointParam;

		// Token: 0x04038601 RID: 230913
		[Token(Token = "0x4038601")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_trackPointParam;

		// Token: 0x02006CE5 RID: 27877
		[Token(Token = "0x2006CE5")]
		public class Input
		{
			// Token: 0x06027C0E RID: 162830 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027C0E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x04038602 RID: 230914
			[Token(Token = "0x4038602")]
			[FieldOffset(Offset = "0x10")]
			public List<string> favorCharList;

			// Token: 0x04038603 RID: 230915
			[Token(Token = "0x4038603")]
			[FieldOffset(Offset = "0x18")]
			public string actId;
		}

		// Token: 0x02006CE6 RID: 27878
		[Token(Token = "0x2006CE6")]
		public class FavorEntryTrackPointModel : ITrackPointModel, IHotfixable
		{
			// Token: 0x17005DDF RID: 24031
			// (get) Token: 0x06027C0F RID: 162831 RVA: 0x000CF3D8 File Offset: 0x000CD5D8
			[Token(Token = "0x17005DDF")]
			public bool isShow
			{
				[Token(Token = "0x6027C0F")]
				[Address(RVA = "0x22F8DB0", Offset = "0x22F79B0", VA = "0x1822F8DB0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06027C10 RID: 162832 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027C10")]
			[Address(RVA = "0x22F8B60", Offset = "0x22F7760", VA = "0x1822F8B60", Slot = "4")]
			public void UpdateState(object param_)
			{
			}

			// Token: 0x06027C11 RID: 162833 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027C11")]
			[Address(RVA = "0x22F8D50", Offset = "0x22F7950", VA = "0x1822F8D50")]
			public FavorEntryTrackPointModel()
			{
			}

			// Token: 0x04038604 RID: 230916
			[Token(Token = "0x4038604")]
			[FieldOffset(Offset = "0x10")]
			private TemplateActivityFavorViewModel.FavorEntryTrackPointModel.Param param;

			// Token: 0x04038605 RID: 230917
			[Token(Token = "0x4038605")]
			[FieldOffset(Offset = "0x18")]
			private bool m_hasNewUp;

			// Token: 0x04038606 RID: 230918
			[Token(Token = "0x4038606")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x04038607 RID: 230919
			[Token(Token = "0x4038607")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x04038608 RID: 230920
			[Token(Token = "0x4038608")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x02006CE7 RID: 27879
			[Token(Token = "0x2006CE7")]
			public class Param
			{
				// Token: 0x06027C12 RID: 162834 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6027C12")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Param()
				{
				}

				// Token: 0x04038609 RID: 230921
				[Token(Token = "0x4038609")]
				[FieldOffset(Offset = "0x10")]
				public List<string> favorCharList;

				// Token: 0x0403860A RID: 230922
				[Token(Token = "0x403860A")]
				[FieldOffset(Offset = "0x18")]
				public string actId;
			}
		}
	}
}
