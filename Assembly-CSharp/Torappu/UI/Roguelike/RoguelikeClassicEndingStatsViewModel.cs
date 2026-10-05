using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using Torappu.UI.RoguelikeTopic.Ending;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052BB RID: 21179
	[Token(Token = "0x20052BB")]
	public class RoguelikeClassicEndingStatsViewModel : RoguelikeClassicEndingPageViewModel
	{
		// Token: 0x0601F3C7 RID: 127943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3C7")]
		[Address(RVA = "0x18F6CF0", Offset = "0x18F58F0", VA = "0x1818F6CF0", Slot = "4")]
		public override void LoadData(string topicId, PlayerRoguelikePendingEvent.EndingResult result)
		{
		}

		// Token: 0x0601F3C8 RID: 127944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3C8")]
		[Address(RVA = "0x18F6E70", Offset = "0x18F5A70", VA = "0x1818F6E70", Slot = "5")]
		public override void LoadFromResponse(string topicId, RoguelikeTopicGameSettleResponse response)
		{
		}

		// Token: 0x0601F3C9 RID: 127945 RVA: 0x000B1480 File Offset: 0x000AF680
		[Token(Token = "0x601F3C9")]
		[Address(RVA = "0x18F6AC0", Offset = "0x18F56C0", VA = "0x1818F6AC0", Slot = "6")]
		public override bool CheckNeedBpView()
		{
			return default(bool);
		}

		// Token: 0x0601F3CA RID: 127946 RVA: 0x000B1498 File Offset: 0x000AF698
		[Token(Token = "0x601F3CA")]
		[Address(RVA = "0x18F6B20", Offset = "0x18F5720", VA = "0x1818F6B20", Slot = "7")]
		public override RoguelikeTopicEndingBpAndGpView.Model GeneEndingBpAndGpViewModel()
		{
			return default(RoguelikeTopicEndingBpAndGpView.Model);
		}

		// Token: 0x0601F3CB RID: 127947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F3CB")]
		[Address(RVA = "0x18F6C90", Offset = "0x18F5890", VA = "0x1818F6C90", Slot = "8")]
		public override List<ItemBundle> GetRewardItemList()
		{
			return null;
		}

		// Token: 0x0601F3CC RID: 127948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3CC")]
		[Address(RVA = "0x18F69A0", Offset = "0x18F55A0", VA = "0x1818F69A0")]
		public void AddCompViewModel(Type type)
		{
		}

		// Token: 0x0601F3CD RID: 127949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F3CD")]
		[Address(RVA = "0x18F6BC0", Offset = "0x18F57C0", VA = "0x1818F6BC0")]
		public RoguelikeClassicEndingStatsViewComponentModel GetCompViewModel(Type type)
		{
			return null;
		}

		// Token: 0x0601F3CE RID: 127950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3CE")]
		[Address(RVA = "0x18F6EF0", Offset = "0x18F5AF0", VA = "0x1818F6EF0")]
		public RoguelikeClassicEndingStatsViewModel()
		{
		}

		// Token: 0x04029F36 RID: 171830
		[Token(Token = "0x4029F36")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<Type, RoguelikeClassicEndingStatsViewComponentModel> m_data;

		// Token: 0x04029F37 RID: 171831
		[Token(Token = "0x4029F37")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04029F38 RID: 171832
		[Token(Token = "0x4029F38")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadFromResponse;

		// Token: 0x04029F39 RID: 171833
		[Token(Token = "0x4029F39")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckNeedBpView;

		// Token: 0x04029F3A RID: 171834
		[Token(Token = "0x4029F3A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GeneEndingBpAndGpViewModel;

		// Token: 0x04029F3B RID: 171835
		[Token(Token = "0x4029F3B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetRewardItemList;

		// Token: 0x04029F3C RID: 171836
		[Token(Token = "0x4029F3C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_AddCompViewModel;

		// Token: 0x04029F3D RID: 171837
		[Token(Token = "0x4029F3D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetCompViewModel;

		// Token: 0x04029F3E RID: 171838
		[Token(Token = "0x4029F3E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
