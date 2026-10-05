using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F62 RID: 28514
	[Token(Token = "0x2006F62")]
	public class ActMultiV3ActivityMissionItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060287CD RID: 165837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287CD")]
		[Address(RVA = "0x23BE710", Offset = "0x23BD310", VA = "0x1823BE710")]
		public void Render(ActMultiV3MissionViewModel model)
		{
		}

		// Token: 0x060287CE RID: 165838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287CE")]
		[Address(RVA = "0x23BE610", Offset = "0x23BD210", VA = "0x1823BE610")]
		public void OnClickConfirmMissionBtn()
		{
		}

		// Token: 0x060287CF RID: 165839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287CF")]
		[Address(RVA = "0x23BEC20", Offset = "0x23BD820", VA = "0x1823BEC20")]
		public ActMultiV3ActivityMissionItemView()
		{
		}

		// Token: 0x040399B7 RID: 235959
		[Token(Token = "0x40399B7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _inProgressGo;

		// Token: 0x040399B8 RID: 235960
		[Token(Token = "0x40399B8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _completedGo;

		// Token: 0x040399B9 RID: 235961
		[Token(Token = "0x40399B9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIButton _confirmButton;

		// Token: 0x040399BA RID: 235962
		[Token(Token = "0x40399BA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _confirmedGo;

		// Token: 0x040399BB RID: 235963
		[Token(Token = "0x40399BB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _missionDesc;

		// Token: 0x040399BC RID: 235964
		[Token(Token = "0x40399BC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _inProgressDescColor;

		// Token: 0x040399BD RID: 235965
		[Token(Token = "0x40399BD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _completedDescColor;

		// Token: 0x040399BE RID: 235966
		[Token(Token = "0x40399BE")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _fillProgressImage;

		// Token: 0x040399BF RID: 235967
		[Token(Token = "0x40399BF")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _inProgressFillColor;

		// Token: 0x040399C0 RID: 235968
		[Token(Token = "0x40399C0")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Color _completedFillColor;

		// Token: 0x040399C1 RID: 235969
		[Token(Token = "0x40399C1")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _progressText;

		// Token: 0x040399C2 RID: 235970
		[Token(Token = "0x40399C2")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Color _completedProgressColor;

		// Token: 0x040399C3 RID: 235971
		[Token(Token = "0x40399C3")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private TwoStateToggle _titleBgToggle;

		// Token: 0x040399C4 RID: 235972
		[Token(Token = "0x40399C4")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _titleText;

		// Token: 0x040399C5 RID: 235973
		[Token(Token = "0x40399C5")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Image _rewardIcon;

		// Token: 0x040399C6 RID: 235974
		[Token(Token = "0x40399C6")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Text _rewardCountText;

		// Token: 0x040399C7 RID: 235975
		[Token(Token = "0x40399C7")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Color _inProgressRewardCountColor;

		// Token: 0x040399C8 RID: 235976
		[Token(Token = "0x40399C8")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Color _completedRewardCountColor;

		// Token: 0x040399C9 RID: 235977
		[Token(Token = "0x40399C9")]
		[FieldOffset(Offset = "0xE0")]
		private string m_cachedMissionId;

		// Token: 0x040399CA RID: 235978
		[Token(Token = "0x40399CA")]
		[FieldOffset(Offset = "0xE8")]
		private UIStateFinder m_finder;

		// Token: 0x040399CB RID: 235979
		[Token(Token = "0x40399CB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040399CC RID: 235980
		[Token(Token = "0x40399CC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClickConfirmMissionBtn;

		// Token: 0x040399CD RID: 235981
		[Token(Token = "0x40399CD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
