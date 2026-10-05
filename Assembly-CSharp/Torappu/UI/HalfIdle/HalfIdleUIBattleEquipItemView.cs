using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HalfIdle
{
	// Token: 0x02006746 RID: 26438
	[Token(Token = "0x2006746")]
	public class HalfIdleUIBattleEquipItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025F13 RID: 155411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F13")]
		[Address(RVA = "0x20F21F0", Offset = "0x20F0DF0", VA = "0x1820F21F0")]
		public void Reset()
		{
		}

		// Token: 0x06025F14 RID: 155412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F14")]
		[Address(RVA = "0x20F1970", Offset = "0x20F0570", VA = "0x1820F1970")]
		public void BeforeTransNewlyAdded(bool blasted, bool isInitList)
		{
		}

		// Token: 0x06025F15 RID: 155413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F15")]
		[Address(RVA = "0x20F2300", Offset = "0x20F0F00", VA = "0x1820F2300")]
		public void TransNewlyAdded(float lerp, float duration, bool blasted, bool isInitList)
		{
		}

		// Token: 0x06025F16 RID: 155414 RVA: 0x000C9828 File Offset: 0x000C7A28
		[Token(Token = "0x6025F16")]
		[Address(RVA = "0x20F1DC0", Offset = "0x20F09C0", VA = "0x1820F1DC0")]
		public float GetTransNewlyAddedDuration(bool blasted, bool isInitList)
		{
			return 0f;
		}

		// Token: 0x06025F17 RID: 155415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F17")]
		[Address(RVA = "0x20F1BB0", Offset = "0x20F07B0", VA = "0x1820F1BB0")]
		public void BeforeTransitionRemoved(bool blasted, bool isInitList)
		{
		}

		// Token: 0x06025F18 RID: 155416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F18")]
		[Address(RVA = "0x20F24E0", Offset = "0x20F10E0", VA = "0x1820F24E0")]
		public void TransitionRemoved(float lerp, float duration, bool blasted, bool isInitList)
		{
		}

		// Token: 0x06025F19 RID: 155417 RVA: 0x000C9840 File Offset: 0x000C7A40
		[Token(Token = "0x6025F19")]
		[Address(RVA = "0x20F1EA0", Offset = "0x20F0AA0", VA = "0x1820F1EA0")]
		public float GetTransitionRemovedDuration(bool blasted, bool isInitList)
		{
			return 0f;
		}

		// Token: 0x06025F1A RID: 155418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F1A")]
		[Address(RVA = "0x20F2040", Offset = "0x20F0C40", VA = "0x1820F2040")]
		public void Render(HalfIdleUIBattleEquipItemViewModel vm, string actId)
		{
		}

		// Token: 0x06025F1B RID: 155419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F1B")]
		[Address(RVA = "0x20F1F80", Offset = "0x20F0B80", VA = "0x1820F1F80")]
		public void RegisterTutorialGO()
		{
		}

		// Token: 0x06025F1C RID: 155420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F1C")]
		[Address(RVA = "0x20F1D00", Offset = "0x20F0900", VA = "0x1820F1D00")]
		public void EventOnClick()
		{
		}

		// Token: 0x06025F1D RID: 155421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F1D")]
		[Address(RVA = "0x20F25D0", Offset = "0x20F11D0", VA = "0x1820F25D0")]
		public HalfIdleUIBattleEquipItemView()
		{
		}

		// Token: 0x040355AF RID: 218543
		[Token(Token = "0x40355AF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _root;

		// Token: 0x040355B0 RID: 218544
		[Token(Token = "0x40355B0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIButton _wearEquipButton;

		// Token: 0x040355B1 RID: 218545
		[Token(Token = "0x40355B1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private HalfIdleUIBattleEquipIconView _equipIcon;

		// Token: 0x040355B2 RID: 218546
		[Token(Token = "0x40355B2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _descText;

		// Token: 0x040355B3 RID: 218547
		[Token(Token = "0x40355B3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _normalInOutAnim;

		// Token: 0x040355B4 RID: 218548
		[Token(Token = "0x40355B4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _blastInAnim;

		// Token: 0x040355B5 RID: 218549
		[Token(Token = "0x40355B5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _blastOutAnim;

		// Token: 0x040355B6 RID: 218550
		[Token(Token = "0x40355B6")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAnimationLocation _newEquipRemindAnim;

		// Token: 0x040355B7 RID: 218551
		[Token(Token = "0x40355B7")]
		[FieldOffset(Offset = "0x78")]
		private uint m_cachedUid;

		// Token: 0x040355B8 RID: 218552
		[Token(Token = "0x40355B8")]
		[FieldOffset(Offset = "0x80")]
		private Act1VHalfIdleEquipData m_cachedEquipData;

		// Token: 0x040355B9 RID: 218553
		[Token(Token = "0x40355B9")]
		[FieldOffset(Offset = "0x88")]
		private Tween m_newEquipRemindTween;

		// Token: 0x040355BA RID: 218554
		[Token(Token = "0x40355BA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x040355BB RID: 218555
		[Token(Token = "0x40355BB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_BeforeTransNewlyAdded;

		// Token: 0x040355BC RID: 218556
		[Token(Token = "0x40355BC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TransNewlyAdded;

		// Token: 0x040355BD RID: 218557
		[Token(Token = "0x40355BD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetTransNewlyAddedDuration;

		// Token: 0x040355BE RID: 218558
		[Token(Token = "0x40355BE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_BeforeTransitionRemoved;

		// Token: 0x040355BF RID: 218559
		[Token(Token = "0x40355BF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TransitionRemoved;

		// Token: 0x040355C0 RID: 218560
		[Token(Token = "0x40355C0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetTransitionRemovedDuration;

		// Token: 0x040355C1 RID: 218561
		[Token(Token = "0x40355C1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040355C2 RID: 218562
		[Token(Token = "0x40355C2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGO;

		// Token: 0x040355C3 RID: 218563
		[Token(Token = "0x40355C3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x040355C4 RID: 218564
		[Token(Token = "0x40355C4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
