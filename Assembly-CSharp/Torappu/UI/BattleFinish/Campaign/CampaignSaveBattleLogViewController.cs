using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.BattleFinish.Campaign
{
	// Token: 0x0200622A RID: 25130
	[Token(Token = "0x200622A")]
	public class CampaignSaveBattleLogViewController : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602441E RID: 148510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602441E")]
		[Address(RVA = "0x1F1AC20", Offset = "0x1F19820", VA = "0x181F1AC20")]
		public void OnConfirmBtnClicked()
		{
		}

		// Token: 0x0602441F RID: 148511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602441F")]
		[Address(RVA = "0x1F1B650", Offset = "0x1F1A250", VA = "0x181F1B650")]
		private void _Show(AutoBattleConvertUtil.BattleLog newLog, AutoBattleConvertUtil.BattleLog oldLog, Action<bool> callback)
		{
		}

		// Token: 0x06024420 RID: 148512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024420")]
		[Address(RVA = "0x1F1B5A0", Offset = "0x1F1A1A0", VA = "0x181F1B5A0")]
		private IEnumerator _HideAndDestroy()
		{
			return null;
		}

		// Token: 0x06024421 RID: 148513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024421")]
		[Address(RVA = "0x1F1B460", Offset = "0x1F1A060", VA = "0x181F1B460")]
		private void _ChooseDefaultLogSmartly(AutoBattleConvertUtil.BattleLog newLog, AutoBattleConvertUtil.BattleLog oldLog)
		{
		}

		// Token: 0x06024422 RID: 148514 RVA: 0x000C3978 File Offset: 0x000C1B78
		[Token(Token = "0x6024422")]
		[Address(RVA = "0x1F1ADB0", Offset = "0x1F199B0", VA = "0x181F1ADB0")]
		public static bool OpenCampaignSaveBattleLogPanel(CampaignSaveBattleLogViewController prefab, Transform parent, Action<bool> onFinished)
		{
			return default(bool);
		}

		// Token: 0x06024423 RID: 148515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024423")]
		[Address(RVA = "0x1F1B940", Offset = "0x1F1A540", VA = "0x181F1B940")]
		public CampaignSaveBattleLogViewController()
		{
		}

		// Token: 0x0403269C RID: 206492
		[Token(Token = "0x403269C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIBlurFloatPanel _backImage;

		// Token: 0x0403269D RID: 206493
		[Token(Token = "0x403269D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CampaignSaveBattleLogPanel _newLogPanel;

		// Token: 0x0403269E RID: 206494
		[Token(Token = "0x403269E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CampaignSaveBattleLogPanel _oldLogPanel;

		// Token: 0x0403269F RID: 206495
		[Token(Token = "0x403269F")]
		[FieldOffset(Offset = "0x30")]
		private Action<bool> m_callback;

		// Token: 0x040326A0 RID: 206496
		[Token(Token = "0x40326A0")]
		[FieldOffset(Offset = "0x38")]
		private Coroutine m_coroutine;

		// Token: 0x040326A1 RID: 206497
		[Token(Token = "0x40326A1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnConfirmBtnClicked;

		// Token: 0x040326A2 RID: 206498
		[Token(Token = "0x40326A2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Show;

		// Token: 0x040326A3 RID: 206499
		[Token(Token = "0x40326A3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__HideAndDestroy;

		// Token: 0x040326A4 RID: 206500
		[Token(Token = "0x40326A4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ChooseDefaultLogSmartly;

		// Token: 0x040326A5 RID: 206501
		[Token(Token = "0x40326A5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OpenCampaignSaveBattleLogPanel;

		// Token: 0x040326A6 RID: 206502
		[Token(Token = "0x40326A6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
