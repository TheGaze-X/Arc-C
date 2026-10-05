using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007968 RID: 31080
	[Token(Token = "0x2007968")]
	public class Arc1ArcadeSettlementBadgeHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602B99F RID: 178591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B99F")]
		[Address(RVA = "0x2791440", Offset = "0x2790040", VA = "0x182791440")]
		public void OnRender(Act1ArcadeSettlementModel settlementModel)
		{
		}

		// Token: 0x0602B9A0 RID: 178592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9A0")]
		[Address(RVA = "0x2791970", Offset = "0x2790570", VA = "0x182791970")]
		public Arc1ArcadeSettlementBadgeHolder()
		{
		}

		// Token: 0x0403F123 RID: 258339
		[Token(Token = "0x403F123")]
		private const float START_ANIM_DELAY = 0.3f;

		// Token: 0x0403F124 RID: 258340
		[Token(Token = "0x403F124")]
		private const float PER_LEVEL_ANIM_DELAY = 0.03f;

		// Token: 0x0403F125 RID: 258341
		[Token(Token = "0x403F125")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _holder;

		// Token: 0x0403F126 RID: 258342
		[Token(Token = "0x403F126")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _itemBasicWidth;

		// Token: 0x0403F127 RID: 258343
		[Token(Token = "0x403F127")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Act1ArcadeSettlementBadgeItemView _badgeItemViewPrefab;

		// Token: 0x0403F128 RID: 258344
		[Token(Token = "0x403F128")]
		[FieldOffset(Offset = "0x30")]
		private List<Act1ArcadeSettlementBadgeItemView> m_badgeViews;

		// Token: 0x0403F129 RID: 258345
		[Token(Token = "0x403F129")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403F12A RID: 258346
		[Token(Token = "0x403F12A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
