using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007962 RID: 31074
	[Token(Token = "0x2007962")]
	public class Act1ArcadeSettlementBadgeItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602B97F RID: 178559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B97F")]
		[Address(RVA = "0x277E9A0", Offset = "0x277D5A0", VA = "0x18277E9A0")]
		public void OnRender(string actId, Act1ArcadeSettlementModel.UnlockBadgeModel badgeModel, float animStartDelay)
		{
		}

		// Token: 0x0602B980 RID: 178560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B980")]
		[Address(RVA = "0x277EC90", Offset = "0x277D890", VA = "0x18277EC90")]
		private Sprite _LoadBadgeBookBadgeIcon(string actId, string iconId)
		{
			return null;
		}

		// Token: 0x0602B981 RID: 178561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B981")]
		[Address(RVA = "0x277EE30", Offset = "0x277DA30", VA = "0x18277EE30")]
		public Act1ArcadeSettlementBadgeItemView()
		{
		}

		// Token: 0x0403F0EE RID: 258286
		[Token(Token = "0x403F0EE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgBadge;

		// Token: 0x0403F0EF RID: 258287
		[Token(Token = "0x403F0EF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _startAnim;

		// Token: 0x0403F0F0 RID: 258288
		[Token(Token = "0x403F0F0")]
		[FieldOffset(Offset = "0x30")]
		private AutoPackSpriteHub m_catchedHub;

		// Token: 0x0403F0F1 RID: 258289
		[Token(Token = "0x403F0F1")]
		[FieldOffset(Offset = "0x38")]
		private Tween m_animTween;

		// Token: 0x0403F0F2 RID: 258290
		[Token(Token = "0x403F0F2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403F0F3 RID: 258291
		[Token(Token = "0x403F0F3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadBadgeBookBadgeIcon;

		// Token: 0x0403F0F4 RID: 258292
		[Token(Token = "0x403F0F4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
