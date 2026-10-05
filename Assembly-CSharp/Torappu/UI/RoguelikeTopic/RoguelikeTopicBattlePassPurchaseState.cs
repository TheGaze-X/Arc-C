using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004494 RID: 17556
	[Token(Token = "0x2004494")]
	public class RoguelikeTopicBattlePassPurchaseState : PopupFadeState
	{
		// Token: 0x0601ACFF RID: 109823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ACFF")]
		[Address(RVA = "0x13F7040", Offset = "0x13F5C40", VA = "0x1813F7040", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601AD00 RID: 109824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD00")]
		[Address(RVA = "0x13F72A0", Offset = "0x13F5EA0", VA = "0x1813F72A0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601AD01 RID: 109825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AD01")]
		[Address(RVA = "0x13F7340", Offset = "0x13F5F40", VA = "0x1813F7340", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601AD02 RID: 109826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD02")]
		[Address(RVA = "0x13F7B30", Offset = "0x13F6730", VA = "0x1813F7B30")]
		private void _OnJumpToOverviewState(IStateBean stateBean)
		{
		}

		// Token: 0x0601AD03 RID: 109827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD03")]
		[Address(RVA = "0x13F79F0", Offset = "0x13F65F0", VA = "0x1813F79F0")]
		private void _OnJumpToConfirmState(IStateBean stateBean)
		{
		}

		// Token: 0x0601AD04 RID: 109828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD04")]
		[Address(RVA = "0x13F7510", Offset = "0x13F6110", VA = "0x1813F7510")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601AD05 RID: 109829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD05")]
		[Address(RVA = "0x13F7E60", Offset = "0x13F6A60", VA = "0x1813F7E60")]
		private void _OnWheelBeginScroll()
		{
		}

		// Token: 0x0601AD06 RID: 109830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD06")]
		[Address(RVA = "0x13F7D50", Offset = "0x13F6950", VA = "0x1813F7D50")]
		private void _OnWheelBeginDrag()
		{
		}

		// Token: 0x0601AD07 RID: 109831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD07")]
		[Address(RVA = "0x13F8050", Offset = "0x13F6C50", VA = "0x1813F8050")]
		private void _OnWheelUpdateIndex(int index)
		{
		}

		// Token: 0x0601AD08 RID: 109832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD08")]
		[Address(RVA = "0x13F7F20", Offset = "0x13F6B20", VA = "0x1813F7F20")]
		private void _OnWheelScrollEnd(int index)
		{
		}

		// Token: 0x0601AD09 RID: 109833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD09")]
		[Address(RVA = "0x13F7940", Offset = "0x13F6540", VA = "0x1813F7940")]
		private void _OnGrandPrizeBtnClicked(string grandPrizeId)
		{
		}

		// Token: 0x0601AD0A RID: 109834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD0A")]
		[Address(RVA = "0x13F70A0", Offset = "0x13F5CA0", VA = "0x1813F70A0")]
		public void OnBtnOverviewClicked()
		{
		}

		// Token: 0x0601AD0B RID: 109835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD0B")]
		[Address(RVA = "0x13F7170", Offset = "0x13F5D70", VA = "0x1813F7170")]
		public void OnBtnPurchaseClicked()
		{
		}

		// Token: 0x0601AD0C RID: 109836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD0C")]
		[Address(RVA = "0x13F8190", Offset = "0x13F6D90", VA = "0x1813F8190")]
		public RoguelikeTopicBattlePassPurchaseState()
		{
		}

		// Token: 0x0601AD0D RID: 109837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD0D")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601AD0E RID: 109838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AD0E")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x04022512 RID: 140562
		[Token(Token = "0x4022512")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RoguelikeTopicBattlePassPurchaseView _battlePassPurchaseView;

		// Token: 0x04022513 RID: 140563
		[Token(Token = "0x4022513")]
		[FieldOffset(Offset = "0x78")]
		private RoguelikeTopicBattlePassPurchaseState.StateBean m_stateBean;

		// Token: 0x04022514 RID: 140564
		[Token(Token = "0x4022514")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x04022515 RID: 140565
		[Token(Token = "0x4022515")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04022516 RID: 140566
		[Token(Token = "0x4022516")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04022517 RID: 140567
		[Token(Token = "0x4022517")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04022518 RID: 140568
		[Token(Token = "0x4022518")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnJumpToOverviewState;

		// Token: 0x04022519 RID: 140569
		[Token(Token = "0x4022519")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnJumpToConfirmState;

		// Token: 0x0402251A RID: 140570
		[Token(Token = "0x402251A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402251B RID: 140571
		[Token(Token = "0x402251B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnWheelBeginScroll;

		// Token: 0x0402251C RID: 140572
		[Token(Token = "0x402251C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnWheelBeginDrag;

		// Token: 0x0402251D RID: 140573
		[Token(Token = "0x402251D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnWheelUpdateIndex;

		// Token: 0x0402251E RID: 140574
		[Token(Token = "0x402251E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnWheelScrollEnd;

		// Token: 0x0402251F RID: 140575
		[Token(Token = "0x402251F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnGrandPrizeBtnClicked;

		// Token: 0x04022520 RID: 140576
		[Token(Token = "0x4022520")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnBtnOverviewClicked;

		// Token: 0x04022521 RID: 140577
		[Token(Token = "0x4022521")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnBtnPurchaseClicked;

		// Token: 0x04022522 RID: 140578
		[Token(Token = "0x4022522")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004495 RID: 17557
		[Token(Token = "0x2004495")]
		public class StateBean : IStateBean, IHotfixable, IDataBindWrapper
		{
			// Token: 0x0601AD0F RID: 109839 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AD0F")]
			[Address(RVA = "0x13FEB00", Offset = "0x13FD700", VA = "0x1813FEB00")]
			public void LoadData(RoguelikeTopicBattlePassDetailState.StateBean sourceBean)
			{
			}

			// Token: 0x0601AD10 RID: 109840 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AD10")]
			[Address(RVA = "0x13FEE70", Offset = "0x13FDA70", VA = "0x1813FEE70")]
			public void LoadData(RoguelikeTopicBattlePassStateBean sourceBean)
			{
			}

			// Token: 0x0601AD11 RID: 109841 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AD11")]
			[Address(RVA = "0x13FF550", Offset = "0x13FE150", VA = "0x1813FF550")]
			private void _LoadData(RoguelikeTopicBattlePassViewModel sourceBpModel, RoguelikeTopicBPGrandPrizeViewModel grandPrizeModel, string topicId)
			{
			}

			// Token: 0x0601AD12 RID: 109842 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AD12")]
			[Address(RVA = "0x13FF030", Offset = "0x13FDC30", VA = "0x1813FF030")]
			public void OnWheelBeginScroll()
			{
			}

			// Token: 0x0601AD13 RID: 109843 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AD13")]
			[Address(RVA = "0x13FEFA0", Offset = "0x13FDBA0", VA = "0x1813FEFA0")]
			public void OnWheelBeginDrag()
			{
			}

			// Token: 0x0601AD14 RID: 109844 RVA: 0x000A3668 File Offset: 0x000A1868
			[Token(Token = "0x601AD14")]
			[Address(RVA = "0x13FF490", Offset = "0x13FE090", VA = "0x1813FF490")]
			public bool UpdateWheelSelectedIndex(int index)
			{
				return default(bool);
			}

			// Token: 0x0601AD15 RID: 109845 RVA: 0x000A3680 File Offset: 0x000A1880
			[Token(Token = "0x601AD15")]
			[Address(RVA = "0x13FF3D0", Offset = "0x13FDFD0", VA = "0x1813FF3D0")]
			public bool UpdateWheelSelectedIndexOnScrollEnd(int index)
			{
				return default(bool);
			}

			// Token: 0x0601AD16 RID: 109846 RVA: 0x000A3698 File Offset: 0x000A1898
			[Token(Token = "0x601AD16")]
			[Address(RVA = "0x13FF0C0", Offset = "0x13FDCC0", VA = "0x1813FF0C0")]
			public bool ToggleGrandPrizeItem(string grandPrizeId)
			{
				return default(bool);
			}

			// Token: 0x0601AD17 RID: 109847 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AD17")]
			[Address(RVA = "0x13FFCF0", Offset = "0x13FE8F0", VA = "0x1813FFCF0")]
			public StateBean()
			{
			}

			// Token: 0x04022523 RID: 140579
			[Token(Token = "0x4022523")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeTopicBattlePassPurchaseProperty purchaseProperty;

			// Token: 0x04022524 RID: 140580
			[Token(Token = "0x4022524")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x04022525 RID: 140581
			[Token(Token = "0x4022525")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix1_LoadData;

			// Token: 0x04022526 RID: 140582
			[Token(Token = "0x4022526")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__LoadData;

			// Token: 0x04022527 RID: 140583
			[Token(Token = "0x4022527")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnWheelBeginScroll;

			// Token: 0x04022528 RID: 140584
			[Token(Token = "0x4022528")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnWheelBeginDrag;

			// Token: 0x04022529 RID: 140585
			[Token(Token = "0x4022529")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_UpdateWheelSelectedIndex;

			// Token: 0x0402252A RID: 140586
			[Token(Token = "0x402252A")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_UpdateWheelSelectedIndexOnScrollEnd;

			// Token: 0x0402252B RID: 140587
			[Token(Token = "0x402252B")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_ToggleGrandPrizeItem;

			// Token: 0x0402252C RID: 140588
			[Token(Token = "0x402252C")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
