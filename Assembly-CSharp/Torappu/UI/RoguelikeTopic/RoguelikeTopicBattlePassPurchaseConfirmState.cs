using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004483 RID: 17539
	[Token(Token = "0x2004483")]
	public class RoguelikeTopicBattlePassPurchaseConfirmState : PopupFloatState
	{
		// Token: 0x0601ACC1 RID: 109761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ACC1")]
		[Address(RVA = "0x13F4070", Offset = "0x13F2C70", VA = "0x1813F4070", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601ACC2 RID: 109762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACC2")]
		[Address(RVA = "0x13F4430", Offset = "0x13F3030", VA = "0x1813F4430", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601ACC3 RID: 109763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACC3")]
		[Address(RVA = "0x13F4A00", Offset = "0x13F3600", VA = "0x1813F4A00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601ACC4 RID: 109764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ACC4")]
		[Address(RVA = "0x13F4C40", Offset = "0x13F3840", VA = "0x1813F4C40")]
		private IEnumerator _ReceiveItems(List<ItemGet> rewardList, [Optional] Action onConfirm)
		{
			return null;
		}

		// Token: 0x0601ACC5 RID: 109765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACC5")]
		[Address(RVA = "0x13F4690", Offset = "0x13F3290", VA = "0x1813F4690")]
		private void _DoPurchase()
		{
		}

		// Token: 0x0601ACC6 RID: 109766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACC6")]
		[Address(RVA = "0x13F40D0", Offset = "0x13F2CD0", VA = "0x1813F40D0")]
		public void OnBtnPurchaseClicked()
		{
		}

		// Token: 0x0601ACC7 RID: 109767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACC7")]
		[Address(RVA = "0x13F4D20", Offset = "0x13F3920", VA = "0x1813F4D20")]
		public RoguelikeTopicBattlePassPurchaseConfirmState()
		{
		}

		// Token: 0x0601ACCB RID: 109771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACCB")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04022486 RID: 140422
		[Token(Token = "0x4022486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RoguelikeTopicBattlePassPurchaseConfirmView _confirmView;

		// Token: 0x04022487 RID: 140423
		[Token(Token = "0x4022487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RoguelikeTopicBattlePassPurchaseConfirmState.StateBean m_stateBean;

		// Token: 0x04022488 RID: 140424
		[Token(Token = "0x4022488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x04022489 RID: 140425
		[Token(Token = "0x4022489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402248A RID: 140426
		[Token(Token = "0x402248A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402248B RID: 140427
		[Token(Token = "0x402248B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402248C RID: 140428
		[Token(Token = "0x402248C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ReceiveItems;

		// Token: 0x0402248D RID: 140429
		[Token(Token = "0x402248D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__DoPurchase;

		// Token: 0x0402248E RID: 140430
		[Token(Token = "0x402248E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnBtnPurchaseClicked;

		// Token: 0x0402248F RID: 140431
		[Token(Token = "0x402248F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004484 RID: 17540
		[Token(Token = "0x2004484")]
		public class StateBean : IStateBean, IHotfixable, IDataBindWrapper
		{
			// Token: 0x0601ACCC RID: 109772 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601ACCC")]
			[Address(RVA = "0x13FEBC0", Offset = "0x13FD7C0", VA = "0x1813FEBC0")]
			public void LoadData(RoguelikeTopicBattlePassPurchaseState.StateBean sourceBean)
			{
			}

			// Token: 0x0601ACCD RID: 109773 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601ACCD")]
			[Address(RVA = "0x13FFBF0", Offset = "0x13FE7F0", VA = "0x1813FFBF0")]
			public StateBean()
			{
			}

			// Token: 0x04022490 RID: 140432
			[Token(Token = "0x4022490")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RoguelikeTopicBattlePassPurchaseOverviewProperty overviewProperty;

			// Token: 0x04022491 RID: 140433
			[Token(Token = "0x4022491")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x04022492 RID: 140434
			[Token(Token = "0x4022492")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
