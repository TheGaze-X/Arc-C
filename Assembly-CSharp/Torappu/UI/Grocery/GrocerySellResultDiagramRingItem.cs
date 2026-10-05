using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004D09 RID: 19721
	[Token(Token = "0x2004D09")]
	public class GrocerySellResultDiagramRingItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D8E5 RID: 121061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8E5")]
		[Address(RVA = "0x1717440", Offset = "0x1716040", VA = "0x181717440")]
		public void SetRankText(int rank)
		{
		}

		// Token: 0x0601D8E6 RID: 121062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8E6")]
		[Address(RVA = "0x1717510", Offset = "0x1716110", VA = "0x181717510")]
		public void SetStyleAndPlayTween(float percent, float duration, bool isPlayer)
		{
		}

		// Token: 0x0601D8E7 RID: 121063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8E7")]
		[Address(RVA = "0x17172C0", Offset = "0x1715EC0", VA = "0x1817172C0")]
		public void ResetTweenAtBegin()
		{
		}

		// Token: 0x0601D8E8 RID: 121064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8E8")]
		[Address(RVA = "0x1717990", Offset = "0x1716590", VA = "0x181717990")]
		public GrocerySellResultDiagramRingItem()
		{
		}

		// Token: 0x04027042 RID: 159810
		[Token(Token = "0x4027042")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color PLAYER_RING_COLOR;

		// Token: 0x04027043 RID: 159811
		[Token(Token = "0x4027043")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Color NPC_RING_COLOR;

		// Token: 0x04027044 RID: 159812
		[Token(Token = "0x4027044")]
		private const float FILL_AMOUNT_TO_DEGREE = 360f;

		// Token: 0x04027045 RID: 159813
		[Token(Token = "0x4027045")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _ringImage;

		// Token: 0x04027046 RID: 159814
		[Token(Token = "0x4027046")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _ringRotateCenter;

		// Token: 0x04027047 RID: 159815
		[Token(Token = "0x4027047")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _ringTranverseRotateCenter;

		// Token: 0x04027048 RID: 159816
		[Token(Token = "0x4027048")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TwoStateToggle _ringStyle;

		// Token: 0x04027049 RID: 159817
		[Token(Token = "0x4027049")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _rankText;

		// Token: 0x0402704A RID: 159818
		[Token(Token = "0x402704A")]
		[FieldOffset(Offset = "0x40")]
		private Tween m_tween;

		// Token: 0x0402704B RID: 159819
		[Token(Token = "0x402704B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetRankText;

		// Token: 0x0402704C RID: 159820
		[Token(Token = "0x402704C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetStyleAndPlayTween;

		// Token: 0x0402704D RID: 159821
		[Token(Token = "0x402704D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ResetTweenAtBegin;

		// Token: 0x0402704E RID: 159822
		[Token(Token = "0x402704E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
