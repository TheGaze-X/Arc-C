using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054DE RID: 21726
	[Token(Token = "0x20054DE")]
	public abstract class RoguelikeGameShopBaseView : MonoBehaviour, IHotfixable, IRoguelikeGameShopVisibility
	{
		// Token: 0x0601FF49 RID: 130889 RVA: 0x000B3E80 File Offset: 0x000B2080
		[Token(Token = "0x601FF49")]
		[Address(RVA = "0x1A0EF30", Offset = "0x1A0DB30", VA = "0x181A0EF30", Slot = "4")]
		public float SetShow(bool isShow, bool fastMode, RoguelikeGameShopStatusEnum current)
		{
			return 0f;
		}

		// Token: 0x0601FF4A RID: 130890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF4A")]
		[Address(RVA = "0x1A0F150", Offset = "0x1A0DD50", VA = "0x181A0F150")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601FF4B RID: 130891
		[Token(Token = "0x601FF4B")]
		public abstract RoguelikeGameShopStatusEnum GetShopStatus();

		// Token: 0x0601FF4C RID: 130892 RVA: 0x000B3E98 File Offset: 0x000B2098
		[Token(Token = "0x601FF4C")]
		[Address(RVA = "0x1A0EED0", Offset = "0x1A0DAD0", VA = "0x181A0EED0", Slot = "8")]
		public virtual RoguelikeGameShopStatusEnum GetRivalStatus()
		{
			return RoguelikeGameShopStatusEnum.NONE;
		}

		// Token: 0x0601FF4D RID: 130893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF4D")]
		[Address(RVA = "0x1A0BD50", Offset = "0x1A0A950", VA = "0x181A0BD50", Slot = "9")]
		public virtual void Render(RoguelikeGameBankViewModel bankModel)
		{
		}

		// Token: 0x0601FF4E RID: 130894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF4E")]
		[Address(RVA = "0x1A0F2B0", Offset = "0x1A0DEB0", VA = "0x181A0F2B0")]
		protected RoguelikeGameShopBaseView()
		{
		}

		// Token: 0x0402B1B8 RID: 176568
		[Token(Token = "0x402B1B8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _panelWidgets;

		// Token: 0x0402B1B9 RID: 176569
		[Token(Token = "0x402B1B9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x0402B1BA RID: 176570
		[Token(Token = "0x402B1BA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector2 _hidePos;

		// Token: 0x0402B1BB RID: 176571
		[Token(Token = "0x402B1BB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector2 _showPos;

		// Token: 0x0402B1BC RID: 176572
		[Token(Token = "0x402B1BC")]
		[FieldOffset(Offset = "0x38")]
		private bool m_inited;

		// Token: 0x0402B1BD RID: 176573
		[Token(Token = "0x402B1BD")]
		[FieldOffset(Offset = "0x40")]
		private RoguelikeGameShopSwitchTween m_switchTween;

		// Token: 0x0402B1BE RID: 176574
		[Token(Token = "0x402B1BE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetShow;

		// Token: 0x0402B1BF RID: 176575
		[Token(Token = "0x402B1BF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402B1C0 RID: 176576
		[Token(Token = "0x402B1C0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetRivalStatus;

		// Token: 0x0402B1C1 RID: 176577
		[Token(Token = "0x402B1C1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B1C2 RID: 176578
		[Token(Token = "0x402B1C2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
