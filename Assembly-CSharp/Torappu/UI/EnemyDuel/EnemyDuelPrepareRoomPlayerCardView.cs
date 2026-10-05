using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x0200503B RID: 20539
	[Token(Token = "0x200503B")]
	public class EnemyDuelPrepareRoomPlayerCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E756 RID: 124758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E756")]
		[Address(RVA = "0x18292B0", Offset = "0x1827EB0", VA = "0x1818292B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E757 RID: 124759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E757")]
		[Address(RVA = "0x1828BA0", Offset = "0x18277A0", VA = "0x181828BA0")]
		public void Render(EnemyDuelPrepareRoomPlayerCardViewModel viewModel, bool isCheckingAvatar, bool isHostVision)
		{
		}

		// Token: 0x0601E758 RID: 124760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E758")]
		[Address(RVA = "0x1829470", Offset = "0x1828070", VA = "0x181829470")]
		private void _SetEnterAnim(bool prevIsEmpty, bool isEmpty, bool isReset)
		{
		}

		// Token: 0x0601E759 RID: 124761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E759")]
		[Address(RVA = "0x1829560", Offset = "0x1828160", VA = "0x181829560")]
		private void _SetIsChecking(bool isChecking, bool isReset)
		{
		}

		// Token: 0x0601E75A RID: 124762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E75A")]
		[Address(RVA = "0x18288A0", Offset = "0x18274A0", VA = "0x1818288A0")]
		public void EventOnClick()
		{
		}

		// Token: 0x0601E75B RID: 124763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E75B")]
		[Address(RVA = "0x1828AA0", Offset = "0x18276A0", VA = "0x181828AA0")]
		public void EventOnSendFriendRequestClick()
		{
		}

		// Token: 0x0601E75C RID: 124764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E75C")]
		[Address(RVA = "0x18287A0", Offset = "0x18273A0", VA = "0x1818287A0")]
		public void EventOnCheckNameCardClick()
		{
		}

		// Token: 0x0601E75D RID: 124765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E75D")]
		[Address(RVA = "0x1828990", Offset = "0x1827590", VA = "0x181828990")]
		public void EventOnKickClick()
		{
		}

		// Token: 0x0601E75E RID: 124766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E75E")]
		[Address(RVA = "0x18296E0", Offset = "0x18282E0", VA = "0x1818296E0")]
		public EnemyDuelPrepareRoomPlayerCardView()
		{
		}

		// Token: 0x04028C3D RID: 166973
		[Token(Token = "0x4028C3D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _avatarImg;

		// Token: 0x04028C3E RID: 166974
		[Token(Token = "0x4028C3E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _nameText;

		// Token: 0x04028C3F RID: 166975
		[Token(Token = "0x4028C3F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject[] _playerObjs;

		// Token: 0x04028C40 RID: 166976
		[Token(Token = "0x4028C40")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject[] _firstEmptyObjs;

		// Token: 0x04028C41 RID: 166977
		[Token(Token = "0x4028C41")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _hostObj;

		// Token: 0x04028C42 RID: 166978
		[Token(Token = "0x4028C42")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _selfObj;

		// Token: 0x04028C43 RID: 166979
		[Token(Token = "0x4028C43")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _offlineObj;

		// Token: 0x04028C44 RID: 166980
		[Token(Token = "0x4028C44")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _battleFinishingObj;

		// Token: 0x04028C45 RID: 166981
		[Token(Token = "0x4028C45")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _optionRootObj;

		// Token: 0x04028C46 RID: 166982
		[Token(Token = "0x4028C46")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _optionCanvasGroup;

		// Token: 0x04028C47 RID: 166983
		[Token(Token = "0x4028C47")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private TwoStateToggle _hostOptionsToggle;

		// Token: 0x04028C48 RID: 166984
		[Token(Token = "0x4028C48")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text[] _friendOptionTexts;

		// Token: 0x04028C49 RID: 166985
		[Token(Token = "0x4028C49")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TwoStateToggle[] _friendOptionToggles;

		// Token: 0x04028C4A RID: 166986
		[Token(Token = "0x4028C4A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04028C4B RID: 166987
		[Token(Token = "0x4028C4B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _optionInAnim;

		// Token: 0x04028C4C RID: 166988
		[Token(Token = "0x4028C4C")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIAnimationLocation _optionOutAnim;

		// Token: 0x04028C4D RID: 166989
		[Token(Token = "0x4028C4D")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_isInited;

		// Token: 0x04028C4E RID: 166990
		[Token(Token = "0x4028C4E")]
		[FieldOffset(Offset = "0xB1")]
		private bool m_isChecking;

		// Token: 0x04028C4F RID: 166991
		[Token(Token = "0x4028C4F")]
		[FieldOffset(Offset = "0xB2")]
		private bool m_isEmpty;

		// Token: 0x04028C50 RID: 166992
		[Token(Token = "0x4028C50")]
		[FieldOffset(Offset = "0xB3")]
		private bool m_isSelf;

		// Token: 0x04028C51 RID: 166993
		[Token(Token = "0x4028C51")]
		[FieldOffset(Offset = "0xB4")]
		private bool m_isHostVision;

		// Token: 0x04028C52 RID: 166994
		[Token(Token = "0x4028C52")]
		[FieldOffset(Offset = "0xB8")]
		private int m_cacheIdx;

		// Token: 0x04028C53 RID: 166995
		[Token(Token = "0x4028C53")]
		[FieldOffset(Offset = "0xC0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04028C54 RID: 166996
		[Token(Token = "0x4028C54")]
		[FieldOffset(Offset = "0xD0")]
		private AnimationSwitchTween m_enterAnimSwitchTween;

		// Token: 0x04028C55 RID: 166997
		[Token(Token = "0x4028C55")]
		[FieldOffset(Offset = "0xD8")]
		private AnimationSwitchTween m_optionInSwitchTween;

		// Token: 0x04028C56 RID: 166998
		[Token(Token = "0x4028C56")]
		[FieldOffset(Offset = "0xE0")]
		private AnimationSwitchTween m_optionOutSwitchTween;

		// Token: 0x04028C57 RID: 166999
		[Token(Token = "0x4028C57")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04028C58 RID: 167000
		[Token(Token = "0x4028C58")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04028C59 RID: 167001
		[Token(Token = "0x4028C59")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetEnterAnim;

		// Token: 0x04028C5A RID: 167002
		[Token(Token = "0x4028C5A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetIsChecking;

		// Token: 0x04028C5B RID: 167003
		[Token(Token = "0x4028C5B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x04028C5C RID: 167004
		[Token(Token = "0x4028C5C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnSendFriendRequestClick;

		// Token: 0x04028C5D RID: 167005
		[Token(Token = "0x4028C5D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnCheckNameCardClick;

		// Token: 0x04028C5E RID: 167006
		[Token(Token = "0x4028C5E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnKickClick;

		// Token: 0x04028C5F RID: 167007
		[Token(Token = "0x4028C5F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
