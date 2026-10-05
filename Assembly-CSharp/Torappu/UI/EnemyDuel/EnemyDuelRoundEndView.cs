using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02005019 RID: 20505
	[Token(Token = "0x2005019")]
	public class EnemyDuelRoundEndView : DataBinder<EnemyDuelRoundEndProperty>
	{
		// Token: 0x0601E6C0 RID: 124608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6C0")]
		[Address(RVA = "0x18359D0", Offset = "0x18345D0", VA = "0x1818359D0", Slot = "7")]
		public override void OnValueChanged(EnemyDuelRoundEndProperty property)
		{
		}

		// Token: 0x0601E6C1 RID: 124609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6C1")]
		[Address(RVA = "0x1835FD0", Offset = "0x1834BD0", VA = "0x181835FD0")]
		private void _PlayAnim()
		{
		}

		// Token: 0x0601E6C2 RID: 124610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6C2")]
		[Address(RVA = "0x18363A0", Offset = "0x1834FA0", VA = "0x1818363A0")]
		private void _PlayMoneyTween(Text moneyText, int moneyChange)
		{
		}

		// Token: 0x0601E6C3 RID: 124611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6C3")]
		[Address(RVA = "0x1836170", Offset = "0x1834D70", VA = "0x181836170")]
		private void _PlayAudio(bool isMid, bool isWin, bool isAllin, bool isStand, bool useShield)
		{
		}

		// Token: 0x0601E6C4 RID: 124612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6C4")]
		[Address(RVA = "0x1836700", Offset = "0x1835300", VA = "0x181836700")]
		public EnemyDuelRoundEndView()
		{
		}

		// Token: 0x04028B53 RID: 166739
		[Token(Token = "0x4028B53")]
		private const float MONEY_TWEEN_START_TIME = 0.3f;

		// Token: 0x04028B54 RID: 166740
		[Token(Token = "0x4028B54")]
		private const float MONEY_TWEEN_DURATION = 1f;

		// Token: 0x04028B55 RID: 166741
		[Token(Token = "0x4028B55")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ThreeStateToggle _bkgToggle;

		// Token: 0x04028B56 RID: 166742
		[Token(Token = "0x4028B56")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ThreeStateToggle _toggle;

		// Token: 0x04028B57 RID: 166743
		[Token(Token = "0x4028B57")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Win Part")]
		private GameObject _panelOptWin;

		// Token: 0x04028B58 RID: 166744
		[Token(Token = "0x4028B58")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Win Part")]
		private Text _moneyTextWin;

		// Token: 0x04028B59 RID: 166745
		[Token(Token = "0x4028B59")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Win Part")]
		private TwoStateToggle _winTextToggle;

		// Token: 0x04028B5A RID: 166746
		[Token(Token = "0x4028B5A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Win Part")]
		private TwoStateToggle _winSpineToggle;

		// Token: 0x04028B5B RID: 166747
		[Token(Token = "0x4028B5B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Win Part")]
		private GameObject _allInDeco;

		// Token: 0x04028B5C RID: 166748
		[Token(Token = "0x4028B5C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Lose Part")]
		private TwoStateToggle _loseToggle;

		// Token: 0x04028B5D RID: 166749
		[Token(Token = "0x4028B5D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Lose Part")]
		private Text _moneyTextLose;

		// Token: 0x04028B5E RID: 166750
		[Token(Token = "0x4028B5E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Lose Part")]
		private TwoStateToggle _loseTextToggleAllIn;

		// Token: 0x04028B5F RID: 166751
		[Token(Token = "0x4028B5F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Lose Part")]
		private TwoStateToggle _loseTextToggleOut;

		// Token: 0x04028B60 RID: 166752
		[Token(Token = "0x4028B60")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Lose Part")]
		private GameObject _panelShield;

		// Token: 0x04028B61 RID: 166753
		[Token(Token = "0x4028B61")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Anim")]
		private UIAnimationLocation _anim;

		// Token: 0x04028B62 RID: 166754
		[Token(Token = "0x4028B62")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Anim")]
		private UISpineLocation _spineWin;

		// Token: 0x04028B63 RID: 166755
		[Token(Token = "0x4028B63")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Anim")]
		private UISpineLocation _spineWinAllIn;

		// Token: 0x04028B64 RID: 166756
		[Token(Token = "0x4028B64")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Anim")]
		private UISpineLocation _spineLose;

		// Token: 0x04028B65 RID: 166757
		[Token(Token = "0x4028B65")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Anim")]
		private UISpineLocation _spineShield;

		// Token: 0x04028B66 RID: 166758
		[Token(Token = "0x4028B66")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Anim")]
		private UISpineLocation _spineSkip;

		// Token: 0x04028B67 RID: 166759
		[Token(Token = "0x4028B67")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private EnemyDuelRoundEndPlayerInfoView _playerInfoLeft;

		// Token: 0x04028B68 RID: 166760
		[Token(Token = "0x4028B68")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private EnemyDuelRoundEndPlayerInfoView _playerInfoRight;

		// Token: 0x04028B69 RID: 166761
		[Token(Token = "0x4028B69")]
		[FieldOffset(Offset = "0xF0")]
		private Tween m_tween;

		// Token: 0x04028B6A RID: 166762
		[Token(Token = "0x4028B6A")]
		[FieldOffset(Offset = "0xF8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04028B6B RID: 166763
		[Token(Token = "0x4028B6B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04028B6C RID: 166764
		[Token(Token = "0x4028B6C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PlayAnim;

		// Token: 0x04028B6D RID: 166765
		[Token(Token = "0x4028B6D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PlayMoneyTween;

		// Token: 0x04028B6E RID: 166766
		[Token(Token = "0x4028B6E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayAudio;

		// Token: 0x04028B6F RID: 166767
		[Token(Token = "0x4028B6F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
