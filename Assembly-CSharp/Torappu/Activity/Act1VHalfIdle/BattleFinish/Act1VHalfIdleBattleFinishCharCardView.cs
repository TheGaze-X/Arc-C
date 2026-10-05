using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle.BattleFinish
{
	// Token: 0x02007822 RID: 30754
	[Token(Token = "0x2007822")]
	public class Act1VHalfIdleBattleFinishCharCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602B23A RID: 176698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B23A")]
		[Address(RVA = "0x26F2710", Offset = "0x26F1310", VA = "0x1826F2710")]
		public void RenderCard(Act1VHalfIdleBattleFinishCharCardViewModel model)
		{
		}

		// Token: 0x0602B23B RID: 176699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B23B")]
		[Address(RVA = "0x26F2620", Offset = "0x26F1220", VA = "0x1826F2620")]
		public void PlayLvlUpAnim()
		{
		}

		// Token: 0x0602B23C RID: 176700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B23C")]
		[Address(RVA = "0x26F28A0", Offset = "0x26F14A0", VA = "0x1826F28A0")]
		public Act1VHalfIdleBattleFinishCharCardView()
		{
		}

		// Token: 0x0403E5B1 RID: 255409
		[Token(Token = "0x403E5B1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _emptyToggle;

		// Token: 0x0403E5B2 RID: 255410
		[Token(Token = "0x403E5B2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _levelUpEffectNode;

		// Token: 0x0403E5B3 RID: 255411
		[Token(Token = "0x403E5B3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _levelUpAnim;

		// Token: 0x0403E5B4 RID: 255412
		[Token(Token = "0x403E5B4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CommonCharCardView _charCardViewPrefab;

		// Token: 0x0403E5B5 RID: 255413
		[Token(Token = "0x403E5B5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _charCardContainer;

		// Token: 0x0403E5B6 RID: 255414
		[Token(Token = "0x403E5B6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _charCardScaler;

		// Token: 0x0403E5B7 RID: 255415
		[Token(Token = "0x403E5B7")]
		[FieldOffset(Offset = "0x4C")]
		private bool m_levelUp;

		// Token: 0x0403E5B8 RID: 255416
		[Token(Token = "0x403E5B8")]
		[FieldOffset(Offset = "0x50")]
		private CommonCharCardView m_charCardView;

		// Token: 0x0403E5B9 RID: 255417
		[Token(Token = "0x403E5B9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderCard;

		// Token: 0x0403E5BA RID: 255418
		[Token(Token = "0x403E5BA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PlayLvlUpAnim;

		// Token: 0x0403E5BB RID: 255419
		[Token(Token = "0x403E5BB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
