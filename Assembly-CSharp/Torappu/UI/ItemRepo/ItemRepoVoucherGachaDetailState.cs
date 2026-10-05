using System;
using Il2CppDummyDll;
using Torappu.UI.Recruit;
using UnityEngine;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E64 RID: 24164
	[Token(Token = "0x2005E64")]
	public class ItemRepoVoucherGachaDetailState : PopupFloatState
	{
		// Token: 0x0602303D RID: 143421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602303D")]
		[Address(RVA = "0x1D881B0", Offset = "0x1D86DB0", VA = "0x181D881B0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602303E RID: 143422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602303E")]
		[Address(RVA = "0x1D884B0", Offset = "0x1D870B0", VA = "0x181D884B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602303F RID: 143423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602303F")]
		[Address(RVA = "0x1D88210", Offset = "0x1D86E10", VA = "0x181D88210", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06023040 RID: 143424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023040")]
		[Address(RVA = "0x1D886A0", Offset = "0x1D872A0", VA = "0x181D886A0")]
		public ItemRepoVoucherGachaDetailState()
		{
		}

		// Token: 0x06023041 RID: 143425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023041")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x040303A2 RID: 197538
		[Token(Token = "0x40303A2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ItemRepoItemDetailStateBean _stateBean;

		// Token: 0x040303A3 RID: 197539
		[Token(Token = "0x40303A3")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform _container;

		// Token: 0x040303A4 RID: 197540
		[Token(Token = "0x40303A4")]
		[FieldOffset(Offset = "0x80")]
		private RecruitGachaPoolDetailHolder m_holder;

		// Token: 0x040303A5 RID: 197541
		[Token(Token = "0x40303A5")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isInited;

		// Token: 0x040303A6 RID: 197542
		[Token(Token = "0x40303A6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040303A7 RID: 197543
		[Token(Token = "0x40303A7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040303A8 RID: 197544
		[Token(Token = "0x40303A8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040303A9 RID: 197545
		[Token(Token = "0x40303A9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
