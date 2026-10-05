using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x0200755A RID: 30042
	[Token(Token = "0x200755A")]
	public class Act24sideBattleFinishDropItemIconView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A4E3 RID: 173283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A4E3")]
		[Address(RVA = "0x25F34A0", Offset = "0x25F20A0", VA = "0x1825F34A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A4E4 RID: 173284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A4E4")]
		[Address(RVA = "0x25F3660", Offset = "0x25F2260", VA = "0x1825F3660")]
		private IEnumerator _RenderAfterTime(float passTime)
		{
			return null;
		}

		// Token: 0x0602A4E5 RID: 173285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A4E5")]
		[Address(RVA = "0x25F3210", Offset = "0x25F1E10", VA = "0x1825F3210")]
		public void Render(Act24sideBattleFinishMeldingDropViewModel.Act24sideBattleFinishMeldingDropItemViewModel itemModel, string actId, float passTime)
		{
		}

		// Token: 0x0602A4E6 RID: 173286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A4E6")]
		[Address(RVA = "0x25F35D0", Offset = "0x25F21D0", VA = "0x1825F35D0")]
		private void _PlayItemDropSE()
		{
		}

		// Token: 0x0602A4E7 RID: 173287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A4E7")]
		[Address(RVA = "0x25F3720", Offset = "0x25F2320", VA = "0x1825F3720")]
		public Act24sideBattleFinishDropItemIconView()
		{
		}

		// Token: 0x0403CD3F RID: 249151
		[Token(Token = "0x403CD3F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x0403CD40 RID: 249152
		[Token(Token = "0x403CD40")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act24sideMeldingItemView _itemViewPrefab;

		// Token: 0x0403CD41 RID: 249153
		[Token(Token = "0x403CD41")]
		[FieldOffset(Offset = "0x28")]
		private Animator m_animator;

		// Token: 0x0403CD42 RID: 249154
		[Token(Token = "0x403CD42")]
		[FieldOffset(Offset = "0x30")]
		private Act24sideMeldingItemView m_itemCard;

		// Token: 0x0403CD43 RID: 249155
		[Token(Token = "0x403CD43")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x0403CD44 RID: 249156
		[Token(Token = "0x403CD44")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403CD45 RID: 249157
		[Token(Token = "0x403CD45")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderAfterTime;

		// Token: 0x0403CD46 RID: 249158
		[Token(Token = "0x403CD46")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403CD47 RID: 249159
		[Token(Token = "0x403CD47")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayItemDropSE;

		// Token: 0x0403CD48 RID: 249160
		[Token(Token = "0x403CD48")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
