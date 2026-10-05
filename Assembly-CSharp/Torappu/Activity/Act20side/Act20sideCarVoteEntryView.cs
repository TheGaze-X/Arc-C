using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x0200767A RID: 30330
	[Token(Token = "0x200767A")]
	public class Act20sideCarVoteEntryView : DataBinder<Act20sideCarVoteEntryProperty>
	{
		// Token: 0x0602AA95 RID: 174741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA95")]
		[Address(RVA = "0x2669970", Offset = "0x2668570", VA = "0x182669970", Slot = "7")]
		public override void OnValueChanged(Act20sideCarVoteEntryProperty property)
		{
		}

		// Token: 0x0602AA96 RID: 174742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA96")]
		[Address(RVA = "0x266A350", Offset = "0x2668F50", VA = "0x18266A350")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AA97 RID: 174743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA97")]
		[Address(RVA = "0x266A160", Offset = "0x2668D60", VA = "0x18266A160")]
		private void _ApplyAvatar(AvatarInfo avatarInfo)
		{
		}

		// Token: 0x0602AA98 RID: 174744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA98")]
		[Address(RVA = "0x266A4E0", Offset = "0x26690E0", VA = "0x18266A4E0")]
		private void _TweenDailyHotValIfNecessary(int dailyHotVal)
		{
		}

		// Token: 0x0602AA99 RID: 174745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA99")]
		[Address(RVA = "0x2669900", Offset = "0x2668500", VA = "0x182669900")]
		private void OnDestroy()
		{
		}

		// Token: 0x0602AA9A RID: 174746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA9A")]
		[Address(RVA = "0x266A780", Offset = "0x2669380", VA = "0x18266A780")]
		public Act20sideCarVoteEntryView()
		{
		}

		// Token: 0x0403D703 RID: 251651
		[Token(Token = "0x403D703")]
		private const float DAILY_HOT_VAL_TWEEN_DURATION = 0.5f;

		// Token: 0x0403D704 RID: 251652
		[Token(Token = "0x403D704")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _hotValue;

		// Token: 0x0403D705 RID: 251653
		[Token(Token = "0x403D705")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _dailyHotValue;

		// Token: 0x0403D706 RID: 251654
		[Token(Token = "0x403D706")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _leftJudgeTimes;

		// Token: 0x0403D707 RID: 251655
		[Token(Token = "0x403D707")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _playerName;

		// Token: 0x0403D708 RID: 251656
		[Token(Token = "0x403D708")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _playerNickNumber;

		// Token: 0x0403D709 RID: 251657
		[Token(Token = "0x403D709")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _playerLevel;

		// Token: 0x0403D70A RID: 251658
		[Token(Token = "0x403D70A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _hotValNoData;

		// Token: 0x0403D70B RID: 251659
		[Token(Token = "0x403D70B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _dailyValNoData;

		// Token: 0x0403D70C RID: 251660
		[Token(Token = "0x403D70C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _avatarContainer;

		// Token: 0x0403D70D RID: 251661
		[Token(Token = "0x403D70D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _avatarViewScale;

		// Token: 0x0403D70E RID: 251662
		[Token(Token = "0x403D70E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act20sideCarObject _carPrefab;

		// Token: 0x0403D70F RID: 251663
		[Token(Token = "0x403D70F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform _carContainer;

		// Token: 0x0403D710 RID: 251664
		[Token(Token = "0x403D710")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _carMask;

		// Token: 0x0403D711 RID: 251665
		[Token(Token = "0x403D711")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _carViewScale;

		// Token: 0x0403D712 RID: 251666
		[Token(Token = "0x403D712")]
		[FieldOffset(Offset = "0x8C")]
		private bool m_isInited;

		// Token: 0x0403D713 RID: 251667
		[Token(Token = "0x403D713")]
		[FieldOffset(Offset = "0x90")]
		private Act20sideCarObject m_carView;

		// Token: 0x0403D714 RID: 251668
		[Token(Token = "0x403D714")]
		[FieldOffset(Offset = "0x98")]
		private PlayerAvatarView m_avatarView;

		// Token: 0x0403D715 RID: 251669
		[Token(Token = "0x403D715")]
		[FieldOffset(Offset = "0xA0")]
		private int m_cachedDailyHotVal;

		// Token: 0x0403D716 RID: 251670
		[Token(Token = "0x403D716")]
		[FieldOffset(Offset = "0xA8")]
		private Tween m_cachedDailyHotValTween;

		// Token: 0x0403D717 RID: 251671
		[Token(Token = "0x403D717")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403D718 RID: 251672
		[Token(Token = "0x403D718")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403D719 RID: 251673
		[Token(Token = "0x403D719")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ApplyAvatar;

		// Token: 0x0403D71A RID: 251674
		[Token(Token = "0x403D71A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TweenDailyHotValIfNecessary;

		// Token: 0x0403D71B RID: 251675
		[Token(Token = "0x403D71B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403D71C RID: 251676
		[Token(Token = "0x403D71C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
