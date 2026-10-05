using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Workshop
{
	// Token: 0x02001BDC RID: 7132
	[Token(Token = "0x2001BDC")]
	public class BuildingWorkshopHomeState : State
	{
		// Token: 0x0600B1E7 RID: 45543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B1E7")]
		[Address(RVA = "0x32BF990", Offset = "0x32BE590", VA = "0x1832BF990", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0600B1E8 RID: 45544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1E8")]
		[Address(RVA = "0x32C1530", Offset = "0x32C0130", VA = "0x1832C1530")]
		private void _InitTopMenu()
		{
		}

		// Token: 0x17001549 RID: 5449
		// (get) Token: 0x0600B1E9 RID: 45545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001549")]
		public override IStateCacheHandler cacheHandler
		{
			[Token(Token = "0x600B1E9")]
			[Address(RVA = "0x32C1A60", Offset = "0x32C0660", VA = "0x1832C1A60", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B1EA RID: 45546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1EA")]
		[Address(RVA = "0x32C1600", Offset = "0x32C0200", VA = "0x1832C1600")]
		private void _LoadFromRuntime(BuildingWorkshopModel model)
		{
		}

		// Token: 0x0600B1EB RID: 45547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1EB")]
		[Address(RVA = "0x32C0010", Offset = "0x32BEC10", VA = "0x1832C0010", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600B1EC RID: 45548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B1EC")]
		[Address(RVA = "0x32C0E50", Offset = "0x32BFA50", VA = "0x1832C0E50", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0600B1ED RID: 45549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1ED")]
		[Address(RVA = "0x32C0DC0", Offset = "0x32BF9C0", VA = "0x1832C0DC0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0600B1EE RID: 45550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1EE")]
		[Address(RVA = "0x32BFFA0", Offset = "0x32BEBA0", VA = "0x1832BFFA0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600B1EF RID: 45551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1EF")]
		[Address(RVA = "0x32C16B0", Offset = "0x32C02B0", VA = "0x1832C16B0")]
		private void _OnPlayerDataChanged()
		{
		}

		// Token: 0x0600B1F0 RID: 45552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1F0")]
		[Address(RVA = "0x32C1720", Offset = "0x32C0320", VA = "0x1832C1720")]
		private void _SetWorkCount(int count)
		{
		}

		// Token: 0x0600B1F1 RID: 45553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1F1")]
		[Address(RVA = "0x32BFA70", Offset = "0x32BE670", VA = "0x1832BFA70")]
		public void OnCharacterButtonPressed()
		{
		}

		// Token: 0x0600B1F2 RID: 45554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1F2")]
		[Address(RVA = "0x32C0560", Offset = "0x32BF160", VA = "0x1832C0560")]
		public void OnFormulaButtonPressed()
		{
		}

		// Token: 0x0600B1F3 RID: 45555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1F3")]
		[Address(RVA = "0x32BF9F0", Offset = "0x32BE5F0", VA = "0x1832BF9F0")]
		public void OnAddButtonPressed()
		{
		}

		// Token: 0x0600B1F4 RID: 45556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1F4")]
		[Address(RVA = "0x32C0930", Offset = "0x32BF530", VA = "0x1832C0930")]
		public void OnMinusButtonPressed()
		{
		}

		// Token: 0x0600B1F5 RID: 45557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1F5")]
		[Address(RVA = "0x32C0800", Offset = "0x32BF400", VA = "0x1832C0800")]
		public void OnMaxButtonPressed()
		{
		}

		// Token: 0x0600B1F6 RID: 45558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1F6")]
		[Address(RVA = "0x32C08D0", Offset = "0x32BF4D0", VA = "0x1832C08D0")]
		public void OnMinButtonPressed()
		{
		}

		// Token: 0x0600B1F7 RID: 45559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1F7")]
		[Address(RVA = "0x32C0BB0", Offset = "0x32BF7B0", VA = "0x1832C0BB0")]
		public void OnProtectSwitchButtonPressed()
		{
		}

		// Token: 0x0600B1F8 RID: 45560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1F8")]
		[Address(RVA = "0x32C1180", Offset = "0x32BFD80", VA = "0x1832C1180")]
		private void _HandleWorkshopResult(WorkResult workResult)
		{
		}

		// Token: 0x0600B1F9 RID: 45561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1F9")]
		[Address(RVA = "0x32C18B0", Offset = "0x32C04B0", VA = "0x1832C18B0")]
		private void _ShowOKDialog(string content, [Optional] Action okAction)
		{
		}

		// Token: 0x0600B1FA RID: 45562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1FA")]
		[Address(RVA = "0x32BFC90", Offset = "0x32BE890", VA = "0x1832BFC90")]
		public void OnConfirmButtonPressed()
		{
		}

		// Token: 0x0600B1FB RID: 45563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1FB")]
		[Address(RVA = "0x32C09B0", Offset = "0x32BF5B0", VA = "0x1832C09B0")]
		public void OnPrevFormulaButtonPressed()
		{
		}

		// Token: 0x0600B1FC RID: 45564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1FC")]
		[Address(RVA = "0x32C05F0", Offset = "0x32BF1F0", VA = "0x1832C05F0")]
		public void OnIngredientJumpBtnPressed(int index)
		{
		}

		// Token: 0x0600B1FD RID: 45565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B1FD")]
		[Address(RVA = "0x32C1A00", Offset = "0x32C0600", VA = "0x1832C1A00")]
		public BuildingWorkshopHomeState()
		{
		}

		// Token: 0x0600B202 RID: 45570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B202")]
		[Address(RVA = "0x12DC030", Offset = "0x12DAC30", VA = "0x1812DC030")]
		private IStateCacheHandler <>xLuaBaseProxy_get_cacheHandler()
		{
			return null;
		}

		// Token: 0x0600B203 RID: 45571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B203")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0600B204 RID: 45572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B204")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0600B205 RID: 45573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B205")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0400AC7D RID: 44157
		[Token(Token = "0x400AC7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BuildingWorkshopStateBean _stateBean;

		// Token: 0x0400AC7E RID: 44158
		[Token(Token = "0x400AC7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x0400AC7F RID: 44159
		[Token(Token = "0x400AC7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private BuildingWorkshopWholeView _wholeView;

		// Token: 0x0400AC80 RID: 44160
		[Token(Token = "0x400AC80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private StateCacheHandler<BuildingWorkshopModel> m_runtimeHandler;

		// Token: 0x0400AC81 RID: 44161
		[Token(Token = "0x400AC81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0400AC82 RID: 44162
		[Token(Token = "0x400AC82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitTopMenu;

		// Token: 0x0400AC83 RID: 44163
		[Token(Token = "0x400AC83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_cacheHandler;

		// Token: 0x0400AC84 RID: 44164
		[Token(Token = "0x400AC84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadFromRuntime;

		// Token: 0x0400AC85 RID: 44165
		[Token(Token = "0x400AC85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400AC86 RID: 44166
		[Token(Token = "0x400AC86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0400AC87 RID: 44167
		[Token(Token = "0x400AC87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0400AC88 RID: 44168
		[Token(Token = "0x400AC88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400AC89 RID: 44169
		[Token(Token = "0x400AC89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnPlayerDataChanged;

		// Token: 0x0400AC8A RID: 44170
		[Token(Token = "0x400AC8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SetWorkCount;

		// Token: 0x0400AC8B RID: 44171
		[Token(Token = "0x400AC8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnCharacterButtonPressed;

		// Token: 0x0400AC8C RID: 44172
		[Token(Token = "0x400AC8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnFormulaButtonPressed;

		// Token: 0x0400AC8D RID: 44173
		[Token(Token = "0x400AC8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnAddButtonPressed;

		// Token: 0x0400AC8E RID: 44174
		[Token(Token = "0x400AC8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnMinusButtonPressed;

		// Token: 0x0400AC8F RID: 44175
		[Token(Token = "0x400AC8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnMaxButtonPressed;

		// Token: 0x0400AC90 RID: 44176
		[Token(Token = "0x400AC90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnMinButtonPressed;

		// Token: 0x0400AC91 RID: 44177
		[Token(Token = "0x400AC91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnProtectSwitchButtonPressed;

		// Token: 0x0400AC92 RID: 44178
		[Token(Token = "0x400AC92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__HandleWorkshopResult;

		// Token: 0x0400AC93 RID: 44179
		[Token(Token = "0x400AC93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__ShowOKDialog;

		// Token: 0x0400AC94 RID: 44180
		[Token(Token = "0x400AC94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnConfirmButtonPressed;

		// Token: 0x0400AC95 RID: 44181
		[Token(Token = "0x400AC95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnPrevFormulaButtonPressed;

		// Token: 0x0400AC96 RID: 44182
		[Token(Token = "0x400AC96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnIngredientJumpBtnPressed;

		// Token: 0x0400AC97 RID: 44183
		[Token(Token = "0x400AC97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
