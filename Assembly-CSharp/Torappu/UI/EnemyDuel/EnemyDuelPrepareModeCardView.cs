using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02005046 RID: 20550
	[Token(Token = "0x2005046")]
	public class EnemyDuelPrepareModeCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E779 RID: 124793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E779")]
		[Address(RVA = "0x18275A0", Offset = "0x18261A0", VA = "0x1818275A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E77A RID: 124794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E77A")]
		[Address(RVA = "0x1826D30", Offset = "0x1825930", VA = "0x181826D30")]
		public void Render(int idx, EnemyDuelPrepareSelectModeCardViewModel viewModel, bool isSelected)
		{
		}

		// Token: 0x0601E77B RID: 124795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E77B")]
		[Address(RVA = "0x1826C20", Offset = "0x1825820", VA = "0x181826C20")]
		public void EventOnClick()
		{
		}

		// Token: 0x0601E77C RID: 124796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E77C")]
		[Address(RVA = "0x1827780", Offset = "0x1826380", VA = "0x181827780")]
		public EnemyDuelPrepareModeCardView()
		{
		}

		// Token: 0x04028CBF RID: 167103
		[Token(Token = "0x4028CBF")]
		private const float CARD_LOAD_ANIM_TIME_UNIT = 0.05f;

		// Token: 0x04028CC0 RID: 167104
		[Token(Token = "0x4028CC0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _entryPicImg;

		// Token: 0x04028CC1 RID: 167105
		[Token(Token = "0x4028CC1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _extraRewardObj;

		// Token: 0x04028CC2 RID: 167106
		[Token(Token = "0x4028CC2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _modeNameText;

		// Token: 0x04028CC3 RID: 167107
		[Token(Token = "0x4028CC3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _modeEnNameText;

		// Token: 0x04028CC4 RID: 167108
		[Token(Token = "0x4028CC4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text[] _modePlayerCntTexts;

		// Token: 0x04028CC5 RID: 167109
		[Token(Token = "0x4028CC5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text[] _avatarNameTexts;

		// Token: 0x04028CC6 RID: 167110
		[Token(Token = "0x4028CC6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text[] _avatarDescTexts;

		// Token: 0x04028CC7 RID: 167111
		[Token(Token = "0x4028CC7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _highScoreText;

		// Token: 0x04028CC8 RID: 167112
		[Token(Token = "0x4028CC8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TwoStateToggle _avatarNameToggle;

		// Token: 0x04028CC9 RID: 167113
		[Token(Token = "0x4028CC9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TwoStateToggle _highScoreToggle;

		// Token: 0x04028CCA RID: 167114
		[Token(Token = "0x4028CCA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _highScoreObj;

		// Token: 0x04028CCB RID: 167115
		[Token(Token = "0x4028CCB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _highScoreDescText;

		// Token: 0x04028CCC RID: 167116
		[Token(Token = "0x4028CCC")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TwoStateToggle[] _multiPlayerToggles;

		// Token: 0x04028CCD RID: 167117
		[Token(Token = "0x4028CCD")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _lockObj;

		// Token: 0x04028CCE RID: 167118
		[Token(Token = "0x4028CCE")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _cardContentObj;

		// Token: 0x04028CCF RID: 167119
		[Token(Token = "0x4028CCF")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _lockText;

		// Token: 0x04028CD0 RID: 167120
		[Token(Token = "0x4028CD0")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIAnimationLocation _selectAnim;

		// Token: 0x04028CD1 RID: 167121
		[Token(Token = "0x4028CD1")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UIAnimationLocation _loadAnim;

		// Token: 0x04028CD2 RID: 167122
		[Token(Token = "0x4028CD2")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_isInited;

		// Token: 0x04028CD3 RID: 167123
		[Token(Token = "0x4028CD3")]
		[FieldOffset(Offset = "0xB9")]
		private bool m_isLoadAnimPlayed;

		// Token: 0x04028CD4 RID: 167124
		[Token(Token = "0x4028CD4")]
		[FieldOffset(Offset = "0xC0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04028CD5 RID: 167125
		[Token(Token = "0x4028CD5")]
		[FieldOffset(Offset = "0xD0")]
		private int m_cacheSeqNum;

		// Token: 0x04028CD6 RID: 167126
		[Token(Token = "0x4028CD6")]
		[FieldOffset(Offset = "0xD8")]
		private EnemyDuelPrepareSelectModeCardViewModel m_viewModel;

		// Token: 0x04028CD7 RID: 167127
		[Token(Token = "0x4028CD7")]
		[FieldOffset(Offset = "0xE0")]
		private AnimationSwitchTween m_selectSwitchTween;

		// Token: 0x04028CD8 RID: 167128
		[Token(Token = "0x4028CD8")]
		[FieldOffset(Offset = "0xE8")]
		private AnimationSwitchTween m_loadAnimSwitchTween;

		// Token: 0x04028CD9 RID: 167129
		[Token(Token = "0x4028CD9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04028CDA RID: 167130
		[Token(Token = "0x4028CDA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04028CDB RID: 167131
		[Token(Token = "0x4028CDB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x04028CDC RID: 167132
		[Token(Token = "0x4028CDC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
