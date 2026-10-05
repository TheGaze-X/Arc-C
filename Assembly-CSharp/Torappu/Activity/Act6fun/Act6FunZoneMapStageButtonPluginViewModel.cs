using System;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.Activity.Act6fun
{
	// Token: 0x020071B9 RID: 29113
	[Token(Token = "0x20071B9")]
	public class Act6FunZoneMapStageButtonPluginViewModel : IHotfixable
	{
		// Token: 0x06029503 RID: 169219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029503")]
		[Address(RVA = "0x24B5350", Offset = "0x24B3F50", VA = "0x1824B5350")]
		public void LoadData(StageViewModel stageViewModel, Act6FunData act6FunData)
		{
		}

		// Token: 0x06029504 RID: 169220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029504")]
		[Address(RVA = "0x24B54D0", Offset = "0x24B40D0", VA = "0x1824B54D0")]
		public void RefreshData(StageViewModel stageViewModel, PlayerActFun6Stage playerActFun6Stage)
		{
		}

		// Token: 0x06029505 RID: 169221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029505")]
		[Address(RVA = "0x24B55D0", Offset = "0x24B41D0", VA = "0x1824B55D0")]
		public Act6FunZoneMapStageButtonPluginViewModel()
		{
		}

		// Token: 0x0403AFEA RID: 241642
		[Token(Token = "0x403AFEA")]
		[FieldOffset(Offset = "0x10")]
		public string stageCode;

		// Token: 0x0403AFEB RID: 241643
		[Token(Token = "0x403AFEB")]
		[FieldOffset(Offset = "0x18")]
		public int curAchievementCount;

		// Token: 0x0403AFEC RID: 241644
		[Token(Token = "0x403AFEC")]
		[FieldOffset(Offset = "0x1C")]
		public int maxAchievementCount;

		// Token: 0x0403AFED RID: 241645
		[Token(Token = "0x403AFED")]
		[FieldOffset(Offset = "0x20")]
		public bool showItem;

		// Token: 0x0403AFEE RID: 241646
		[Token(Token = "0x403AFEE")]
		[FieldOffset(Offset = "0x21")]
		public bool showAchievementInfo;

		// Token: 0x0403AFEF RID: 241647
		[Token(Token = "0x403AFEF")]
		[FieldOffset(Offset = "0x22")]
		public bool isUnlocked;

		// Token: 0x0403AFF0 RID: 241648
		[Token(Token = "0x403AFF0")]
		[FieldOffset(Offset = "0x23")]
		public bool isComplete;

		// Token: 0x0403AFF1 RID: 241649
		[Token(Token = "0x403AFF1")]
		[FieldOffset(Offset = "0x28")]
		private Act6FunStageAdditionData m_additionData;

		// Token: 0x0403AFF2 RID: 241650
		[Token(Token = "0x403AFF2")]
		[FieldOffset(Offset = "0x30")]
		private PlayerStageState m_stageState;

		// Token: 0x0403AFF3 RID: 241651
		[Token(Token = "0x403AFF3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403AFF4 RID: 241652
		[Token(Token = "0x403AFF4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0403AFF5 RID: 241653
		[Token(Token = "0x403AFF5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
