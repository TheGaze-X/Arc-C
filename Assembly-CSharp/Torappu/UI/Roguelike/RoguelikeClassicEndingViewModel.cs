using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052C1 RID: 21185
	[Token(Token = "0x20052C1")]
	public class RoguelikeClassicEndingViewModel : RoguelikeEndingViewModel
	{
		// Token: 0x17004942 RID: 18754
		// (get) Token: 0x0601F3DF RID: 127967 RVA: 0x000B14C8 File Offset: 0x000AF6C8
		// (set) Token: 0x0601F3E0 RID: 127968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004942")]
		public bool hideEndingStory
		{
			[Token(Token = "0x601F3DF")]
			[Address(RVA = "0x18F7FA0", Offset = "0x18F6BA0", VA = "0x1818F7FA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601F3E0")]
			[Address(RVA = "0x18F8000", Offset = "0x18F6C00", VA = "0x1818F8000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601F3E1 RID: 127969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3E1")]
		[Address(RVA = "0x18F76E0", Offset = "0x18F62E0", VA = "0x1818F76E0", Slot = "4")]
		public override void LoadData(string topicId)
		{
		}

		// Token: 0x0601F3E2 RID: 127970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3E2")]
		[Address(RVA = "0x18F74B0", Offset = "0x18F60B0", VA = "0x1818F74B0")]
		public void LoadDataFromResponse(string topicId, RoguelikeTopicGameSettleResponse response)
		{
		}

		// Token: 0x0601F3E3 RID: 127971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3E3")]
		[Address(RVA = "0x18F7330", Offset = "0x18F5F30", VA = "0x1818F7330")]
		public void AddPageViewModel(ViewType viewType, RoguelikeClassicEndingPageViewModel viewModel)
		{
		}

		// Token: 0x0601F3E4 RID: 127972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F3E4")]
		[Address(RVA = "0x18F7410", Offset = "0x18F6010", VA = "0x1818F7410")]
		public RoguelikeClassicEndingPageViewModel GetPageViewModel(ViewType viewType)
		{
			return null;
		}

		// Token: 0x0601F3E5 RID: 127973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3E5")]
		[Address(RVA = "0x18F7C50", Offset = "0x18F6850", VA = "0x1818F7C50")]
		private void _LoadRogueActivitySeed(string topicId, PlayerRoguelikePendingEvent.EndingBrief brief)
		{
		}

		// Token: 0x0601F3E6 RID: 127974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3E6")]
		[Address(RVA = "0x18F7EA0", Offset = "0x18F6AA0", VA = "0x1818F7EA0")]
		public RoguelikeClassicEndingViewModel()
		{
		}

		// Token: 0x04029F60 RID: 171872
		[Token(Token = "0x4029F60")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<ViewType, RoguelikeClassicEndingPageViewModel> m_data;

		// Token: 0x04029F61 RID: 171873
		[Token(Token = "0x4029F61")]
		[FieldOffset(Offset = "0x18")]
		public string theme;

		// Token: 0x04029F62 RID: 171874
		[Token(Token = "0x4029F62")]
		[FieldOffset(Offset = "0x20")]
		public RoguelikeTopicMode mode;

		// Token: 0x04029F63 RID: 171875
		[Token(Token = "0x4029F63")]
		[FieldOffset(Offset = "0x24")]
		public int grade;

		// Token: 0x04029F64 RID: 171876
		[Token(Token = "0x4029F64")]
		[FieldOffset(Offset = "0x28")]
		public bool isSuccess;

		// Token: 0x04029F65 RID: 171877
		[Token(Token = "0x4029F65")]
		[FieldOffset(Offset = "0x30")]
		public string endingId;

		// Token: 0x04029F66 RID: 171878
		[Token(Token = "0x4029F66")]
		[FieldOffset(Offset = "0x38")]
		public string failEndingId;

		// Token: 0x04029F67 RID: 171879
		[Token(Token = "0x4029F67")]
		[FieldOffset(Offset = "0x40")]
		public bool needPopReport;

		// Token: 0x04029F68 RID: 171880
		[Token(Token = "0x4029F68")]
		[FieldOffset(Offset = "0x48")]
		public string endingFrameDetail;

		// Token: 0x04029F69 RID: 171881
		[Token(Token = "0x4029F69")]
		[FieldOffset(Offset = "0x50")]
		public RoguelikeTopicDetail topicDetail;

		// Token: 0x04029F6A RID: 171882
		[Token(Token = "0x4029F6A")]
		[FieldOffset(Offset = "0x58")]
		public RoguelikeTopicCustomizeData topicCustomize;

		// Token: 0x04029F6B RID: 171883
		[Token(Token = "0x4029F6B")]
		[FieldOffset(Offset = "0x60")]
		public GameSettleOuterInfo gameSettleOuterInfo;

		// Token: 0x04029F6C RID: 171884
		[Token(Token = "0x4029F6C")]
		[FieldOffset(Offset = "0x68")]
		public int score;

		// Token: 0x04029F6D RID: 171885
		[Token(Token = "0x4029F6D")]
		[FieldOffset(Offset = "0x70")]
		public string seed;

		// Token: 0x04029F6E RID: 171886
		[Token(Token = "0x4029F6E")]
		[FieldOffset(Offset = "0x78")]
		public string copySeedFormat;

		// Token: 0x04029F6F RID: 171887
		[Token(Token = "0x4029F6F")]
		[FieldOffset(Offset = "0x80")]
		public string copySucceededTextHint;

		// Token: 0x04029F70 RID: 171888
		[Token(Token = "0x4029F70")]
		[FieldOffset(Offset = "0x88")]
		public bool isShowSeed;

		// Token: 0x04029F72 RID: 171890
		[Token(Token = "0x4029F72")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hideEndingStory;

		// Token: 0x04029F73 RID: 171891
		[Token(Token = "0x4029F73")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_hideEndingStory;

		// Token: 0x04029F74 RID: 171892
		[Token(Token = "0x4029F74")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04029F75 RID: 171893
		[Token(Token = "0x4029F75")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadDataFromResponse;

		// Token: 0x04029F76 RID: 171894
		[Token(Token = "0x4029F76")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_AddPageViewModel;

		// Token: 0x04029F77 RID: 171895
		[Token(Token = "0x4029F77")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetPageViewModel;

		// Token: 0x04029F78 RID: 171896
		[Token(Token = "0x4029F78")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadRogueActivitySeed;

		// Token: 0x04029F79 RID: 171897
		[Token(Token = "0x4029F79")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
