using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001AE7 RID: 6887
	[Token(Token = "0x2001AE7")]
	public class BuyLaborState : State
	{
		// Token: 0x0600AE0D RID: 44557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE0D")]
		[Address(RVA = "0x329AA80", Offset = "0x3299680", VA = "0x18329AA80", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600AE0E RID: 44558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AE0E")]
		[Address(RVA = "0x329A8B0", Offset = "0x32994B0", VA = "0x18329A8B0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0600AE0F RID: 44559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE0F")]
		[Address(RVA = "0x329B020", Offset = "0x3299C20", VA = "0x18329B020")]
		public void SendCurrentBuy()
		{
		}

		// Token: 0x0600AE10 RID: 44560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE10")]
		[Address(RVA = "0x329ACC0", Offset = "0x32998C0", VA = "0x18329ACC0")]
		public void Render()
		{
		}

		// Token: 0x0600AE11 RID: 44561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE11")]
		[Address(RVA = "0x329A820", Offset = "0x3299420", VA = "0x18329A820")]
		public void Add()
		{
		}

		// Token: 0x0600AE12 RID: 44562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE12")]
		[Address(RVA = "0x329A9F0", Offset = "0x32995F0", VA = "0x18329A9F0")]
		public void Minus()
		{
		}

		// Token: 0x0600AE13 RID: 44563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE13")]
		[Address(RVA = "0x329A910", Offset = "0x3299510", VA = "0x18329A910")]
		public void MinusToMin()
		{
		}

		// Token: 0x0600AE14 RID: 44564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE14")]
		[Address(RVA = "0x329A790", Offset = "0x3299390", VA = "0x18329A790")]
		public void AddToMax()
		{
		}

		// Token: 0x0600AE15 RID: 44565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE15")]
		[Address(RVA = "0x329B3A0", Offset = "0x3299FA0", VA = "0x18329B3A0")]
		private void Update()
		{
		}

		// Token: 0x0600AE16 RID: 44566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE16")]
		[Address(RVA = "0x329B4E0", Offset = "0x329A0E0", VA = "0x18329B4E0")]
		public BuyLaborState()
		{
		}

		// Token: 0x0600AE18 RID: 44568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE18")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0400A664 RID: 42596
		[Token(Token = "0x400A664")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BuyLaborStateBean _stateBean;

		// Token: 0x0400A665 RID: 42597
		[Token(Token = "0x400A665")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _currentCount;

		// Token: 0x0400A666 RID: 42598
		[Token(Token = "0x400A666")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _downAP;

		// Token: 0x0400A667 RID: 42599
		[Token(Token = "0x400A667")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _detailText;

		// Token: 0x0400A668 RID: 42600
		[Token(Token = "0x400A668")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private BuildingUIResItem _laborPriceItem;

		// Token: 0x0400A669 RID: 42601
		[Token(Token = "0x400A669")]
		[FieldOffset(Offset = "0x78")]
		private bool m_initFlag;

		// Token: 0x0400A66A RID: 42602
		[Token(Token = "0x400A66A")]
		[FieldOffset(Offset = "0x80")]
		private DateTime m_currentTime;

		// Token: 0x0400A66B RID: 42603
		[Token(Token = "0x400A66B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400A66C RID: 42604
		[Token(Token = "0x400A66C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0400A66D RID: 42605
		[Token(Token = "0x400A66D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SendCurrentBuy;

		// Token: 0x0400A66E RID: 42606
		[Token(Token = "0x400A66E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400A66F RID: 42607
		[Token(Token = "0x400A66F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Add;

		// Token: 0x0400A670 RID: 42608
		[Token(Token = "0x400A670")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Minus;

		// Token: 0x0400A671 RID: 42609
		[Token(Token = "0x400A671")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_MinusToMin;

		// Token: 0x0400A672 RID: 42610
		[Token(Token = "0x400A672")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_AddToMax;

		// Token: 0x0400A673 RID: 42611
		[Token(Token = "0x400A673")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400A674 RID: 42612
		[Token(Token = "0x400A674")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
