using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;

namespace Torappu.Activity.Act1BossRush
{
	// Token: 0x020070CD RID: 28877
	[Token(Token = "0x20070CD")]
	public class Act1BossRushMissionViewModelPlugin : TemplateActivityMissionViewModelPlugin
	{
		// Token: 0x06029094 RID: 168084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029094")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		public void SetContext(TemplateActivityMissionGroupViewModel viewModel)
		{
		}

		// Token: 0x06029095 RID: 168085 RVA: 0x000D4220 File Offset: 0x000D2420
		[Token(Token = "0x6029095")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "5")]
		public bool CheckMissionShowAbleFlag(int missionIndex)
		{
			return default(bool);
		}

		// Token: 0x06029096 RID: 168086 RVA: 0x000D4238 File Offset: 0x000D2438
		[Token(Token = "0x6029096")]
		[Address(RVA = "0x246BCB0", Offset = "0x246A8B0", VA = "0x18246BCB0", Slot = "6")]
		public bool Compare(TemplateMissionViewModel a, TemplateMissionViewModel b, out int result)
		{
			return default(bool);
		}

		// Token: 0x06029097 RID: 168087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029097")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act1BossRushMissionViewModelPlugin()
		{
		}
	}
}
