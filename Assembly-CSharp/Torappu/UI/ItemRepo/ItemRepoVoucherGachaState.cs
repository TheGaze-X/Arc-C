using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E67 RID: 24167
	[Token(Token = "0x2005E67")]
	public class ItemRepoVoucherGachaState : ItemRepoItemDetailState
	{
		// Token: 0x0602304A RID: 143434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602304A")]
		[Address(RVA = "0x1D88EE0", Offset = "0x1D87AE0", VA = "0x181D88EE0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602304B RID: 143435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602304B")]
		[Address(RVA = "0x1D89010", Offset = "0x1D87C10", VA = "0x181D89010", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602304C RID: 143436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602304C")]
		[Address(RVA = "0x1D89120", Offset = "0x1D87D20", VA = "0x181D89120")]
		public void OnUseClick()
		{
		}

		// Token: 0x0602304D RID: 143437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602304D")]
		[Address(RVA = "0x1D890B0", Offset = "0x1D87CB0", VA = "0x181D890B0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0602304E RID: 143438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602304E")]
		[Address(RVA = "0x1D88F40", Offset = "0x1D87B40", VA = "0x181D88F40")]
		public void OnDetailClick()
		{
		}

		// Token: 0x0602304F RID: 143439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602304F")]
		[Address(RVA = "0x1D89640", Offset = "0x1D88240", VA = "0x181D89640")]
		public void SendGetItem()
		{
		}

		// Token: 0x06023050 RID: 143440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023050")]
		[Address(RVA = "0x1D89410", Offset = "0x1D88010", VA = "0x181D89410")]
		public void SendGetChar()
		{
		}

		// Token: 0x06023051 RID: 143441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023051")]
		[Address(RVA = "0x1D8A5F0", Offset = "0x1D891F0", VA = "0x181D8A5F0")]
		private void _ResetTween()
		{
		}

		// Token: 0x06023052 RID: 143442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023052")]
		[Address(RVA = "0x1D89AD0", Offset = "0x1D886D0", VA = "0x181D89AD0")]
		public void ShowAlpha()
		{
		}

		// Token: 0x06023053 RID: 143443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023053")]
		[Address(RVA = "0x1D89BC0", Offset = "0x1D887C0", VA = "0x181D89BC0")]
		public void ShowChar(CharGachaVoucherData info)
		{
		}

		// Token: 0x06023054 RID: 143444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023054")]
		[Address(RVA = "0x1D89870", Offset = "0x1D88470", VA = "0x181D89870")]
		public void SendItemVoucherRequest()
		{
		}

		// Token: 0x06023055 RID: 143445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023055")]
		[Address(RVA = "0x1D891D0", Offset = "0x1D87DD0", VA = "0x181D891D0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06023056 RID: 143446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023056")]
		[Address(RVA = "0x1D89C90", Offset = "0x1D88890", VA = "0x181D89C90")]
		public void ShowGachaEffect(GachaResult[] gachaResultList, bool isAdvanced, bool isSkippable)
		{
		}

		// Token: 0x06023057 RID: 143447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023057")]
		[Address(RVA = "0x1D8A690", Offset = "0x1D89290", VA = "0x181D8A690")]
		public ItemRepoVoucherGachaState()
		{
		}

		// Token: 0x0602305E RID: 143454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602305E")]
		[Address(RVA = "0x1D8A5D0", Offset = "0x1D891D0", VA = "0x181D8A5D0")]
		private IStateBean <>xLuaBaseProxy_GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602305F RID: 143455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602305F")]
		[Address(RVA = "0x1D8A5E0", Offset = "0x1D891E0", VA = "0x181D8A5E0")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06023060 RID: 143456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023060")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x06023061 RID: 143457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023061")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x040303B7 RID: 197559
		[Token(Token = "0x40303B7")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _detailPart;

		// Token: 0x040303B8 RID: 197560
		[Token(Token = "0x40303B8")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private GameObject _rarityCharPart6;

		// Token: 0x040303B9 RID: 197561
		[Token(Token = "0x40303B9")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private GameObject _rarityCharPart5;

		// Token: 0x040303BA RID: 197562
		[Token(Token = "0x40303BA")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private CanvasGroup _alphaCanvas;

		// Token: 0x040303BB RID: 197563
		[Token(Token = "0x40303BB")]
		[FieldOffset(Offset = "0xE0")]
		private Tween m_showTween;

		// Token: 0x040303BC RID: 197564
		[Token(Token = "0x40303BC")]
		private const float FADE_DUR = 0.16f;

		// Token: 0x040303BD RID: 197565
		[Token(Token = "0x40303BD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040303BE RID: 197566
		[Token(Token = "0x40303BE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040303BF RID: 197567
		[Token(Token = "0x40303BF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnUseClick;

		// Token: 0x040303C0 RID: 197568
		[Token(Token = "0x40303C0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x040303C1 RID: 197569
		[Token(Token = "0x40303C1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDetailClick;

		// Token: 0x040303C2 RID: 197570
		[Token(Token = "0x40303C2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SendGetItem;

		// Token: 0x040303C3 RID: 197571
		[Token(Token = "0x40303C3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SendGetChar;

		// Token: 0x040303C4 RID: 197572
		[Token(Token = "0x40303C4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ResetTween;

		// Token: 0x040303C5 RID: 197573
		[Token(Token = "0x40303C5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ShowAlpha;

		// Token: 0x040303C6 RID: 197574
		[Token(Token = "0x40303C6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ShowChar;

		// Token: 0x040303C7 RID: 197575
		[Token(Token = "0x40303C7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SendItemVoucherRequest;

		// Token: 0x040303C8 RID: 197576
		[Token(Token = "0x40303C8")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x040303C9 RID: 197577
		[Token(Token = "0x40303C9")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ShowGachaEffect;

		// Token: 0x040303CA RID: 197578
		[Token(Token = "0x40303CA")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
