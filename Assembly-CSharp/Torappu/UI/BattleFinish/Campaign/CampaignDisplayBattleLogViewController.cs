using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.BattleFinish.Campaign
{
	// Token: 0x02006225 RID: 25125
	[Token(Token = "0x2006225")]
	public class CampaignDisplayBattleLogViewController : MonoBehaviour
	{
		// Token: 0x06024403 RID: 148483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024403")]
		[Address(RVA = "0x1F19050", Offset = "0x1F17C50", VA = "0x181F19050")]
		public void OnConfirmBtnClicked()
		{
		}

		// Token: 0x06024404 RID: 148484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024404")]
		[Address(RVA = "0x1F19480", Offset = "0x1F18080", VA = "0x181F19480")]
		private void _Show(AutoBattleConvertUtil.BattleLog newLog, Action callback)
		{
		}

		// Token: 0x06024405 RID: 148485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024405")]
		[Address(RVA = "0x1F19400", Offset = "0x1F18000", VA = "0x181F19400")]
		private IEnumerator _HideAndDestroy()
		{
			return null;
		}

		// Token: 0x06024406 RID: 148486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024406")]
		[Address(RVA = "0x1F19130", Offset = "0x1F17D30", VA = "0x181F19130")]
		public static void OpenCampaignDisplayBattleLogPanel(CampaignDisplayBattleLogViewController prefab, Transform parent, Action onFinished)
		{
		}

		// Token: 0x06024407 RID: 148487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024407")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public CampaignDisplayBattleLogViewController()
		{
		}

		// Token: 0x04032681 RID: 206465
		[Token(Token = "0x4032681")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIBlurFloatPanel _backImage;

		// Token: 0x04032682 RID: 206466
		[Token(Token = "0x4032682")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CampaignSaveBattleLogPanel _logPanel;

		// Token: 0x04032683 RID: 206467
		[Token(Token = "0x4032683")]
		[FieldOffset(Offset = "0x28")]
		private Action m_callback;
	}
}
