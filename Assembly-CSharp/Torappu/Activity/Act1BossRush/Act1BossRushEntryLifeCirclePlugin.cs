using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1BossRush
{
	// Token: 0x020070AF RID: 28847
	[Token(Token = "0x20070AF")]
	public class Act1BossRushEntryLifeCirclePlugin : TemplateActivityCommonPlugin
	{
		// Token: 0x0602902B RID: 167979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602902B")]
		[Address(RVA = "0x2465CA0", Offset = "0x24648A0", VA = "0x182465CA0", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x0602902C RID: 167980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602902C")]
		[Address(RVA = "0x2465E90", Offset = "0x2464A90", VA = "0x182465E90")]
		public void OpenStageChoose()
		{
		}

		// Token: 0x0602902D RID: 167981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602902D")]
		[Address(RVA = "0x2465FD0", Offset = "0x2464BD0", VA = "0x182465FD0")]
		public Act1BossRushEntryLifeCirclePlugin()
		{
		}

		// Token: 0x0403A88E RID: 239758
		[Token(Token = "0x403A88E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objActLockTips1;

		// Token: 0x0403A88F RID: 239759
		[Token(Token = "0x403A88F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _objActLockTips2;

		// Token: 0x0403A890 RID: 239760
		[Token(Token = "0x403A890")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textActLockTips1;

		// Token: 0x0403A891 RID: 239761
		[Token(Token = "0x403A891")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textActLockTips2;

		// Token: 0x0403A892 RID: 239762
		[Token(Token = "0x403A892")]
		[FieldOffset(Offset = "0x48")]
		private string m_actId;

		// Token: 0x0403A893 RID: 239763
		[Token(Token = "0x403A893")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403A894 RID: 239764
		[Token(Token = "0x403A894")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OpenStageChoose;

		// Token: 0x0403A895 RID: 239765
		[Token(Token = "0x403A895")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
