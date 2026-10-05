using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E6C RID: 24172
	[Token(Token = "0x2005E6C")]
	public class ItemRepoHomeState : State
	{
		// Token: 0x06023078 RID: 143480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023078")]
		[Address(RVA = "0x1D93A60", Offset = "0x1D92660", VA = "0x181D93A60", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06023079 RID: 143481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023079")]
		[Address(RVA = "0x1D94630", Offset = "0x1D93230", VA = "0x181D94630")]
		public void ToDetailState(IStateBean stateBean)
		{
		}

		// Token: 0x0602307A RID: 143482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602307A")]
		[Address(RVA = "0x1D94410", Offset = "0x1D93010", VA = "0x181D94410", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602307B RID: 143483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602307B")]
		[Address(RVA = "0x1D93F30", Offset = "0x1D92B30", VA = "0x181D93F30")]
		public void RefreshData(IStateBean stateBean)
		{
		}

		// Token: 0x0602307C RID: 143484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602307C")]
		[Address(RVA = "0x1D93FB0", Offset = "0x1D92BB0", VA = "0x181D93FB0", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0602307D RID: 143485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602307D")]
		[Address(RVA = "0x1D93E10", Offset = "0x1D92A10", VA = "0x181D93E10", Slot = "19")]
		protected override IEnumerator OnPreload()
		{
			return null;
		}

		// Token: 0x0602307E RID: 143486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602307E")]
		[Address(RVA = "0x1D93EC0", Offset = "0x1D92AC0", VA = "0x181D93EC0")]
		public void RefreshData()
		{
		}

		// Token: 0x0602307F RID: 143487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602307F")]
		[Address(RVA = "0x1D93D40", Offset = "0x1D92940", VA = "0x181D93D40", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06023080 RID: 143488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023080")]
		[Address(RVA = "0x1D93930", Offset = "0x1D92530", VA = "0x181D93930")]
		public void EventOnItemCardClick(int position)
		{
		}

		// Token: 0x06023081 RID: 143489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023081")]
		[Address(RVA = "0x1D93850", Offset = "0x1D92450", VA = "0x181D93850")]
		public void EventOnHideItemDescClick()
		{
		}

		// Token: 0x06023082 RID: 143490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023082")]
		[Address(RVA = "0x1D94830", Offset = "0x1D93430", VA = "0x181D94830")]
		private void _OnInitTopMenu(GameObject inst)
		{
		}

		// Token: 0x06023083 RID: 143491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023083")]
		[Address(RVA = "0x1D94960", Offset = "0x1D93560", VA = "0x181D94960")]
		private void _OnPageBack()
		{
		}

		// Token: 0x06023084 RID: 143492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023084")]
		[Address(RVA = "0x1D93BE0", Offset = "0x1D927E0", VA = "0x181D93BE0")]
		public void OnClickToDetail(int position)
		{
		}

		// Token: 0x06023085 RID: 143493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023085")]
		[Address(RVA = "0x1D93AC0", Offset = "0x1D926C0", VA = "0x181D93AC0")]
		public void OnClickToChangeFilter(int filter)
		{
		}

		// Token: 0x06023086 RID: 143494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023086")]
		[Address(RVA = "0x1D949D0", Offset = "0x1D935D0", VA = "0x181D949D0")]
		public ItemRepoHomeState()
		{
		}

		// Token: 0x06023088 RID: 143496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023088")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06023089 RID: 143497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023089")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0602308A RID: 143498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602308A")]
		[Address(RVA = "0x15A0840", Offset = "0x159F440", VA = "0x1815A0840")]
		private IEnumerator <>xLuaBaseProxy_OnPreload()
		{
			return null;
		}

		// Token: 0x0602308B RID: 143499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602308B")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x040303E1 RID: 197601
		[Token(Token = "0x40303E1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ItemRepoStateBean _stateBean;

		// Token: 0x040303E2 RID: 197602
		[Token(Token = "0x40303E2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x040303E3 RID: 197603
		[Token(Token = "0x40303E3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040303E4 RID: 197604
		[Token(Token = "0x40303E4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ToDetailState;

		// Token: 0x040303E5 RID: 197605
		[Token(Token = "0x40303E5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x040303E6 RID: 197606
		[Token(Token = "0x40303E6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x040303E7 RID: 197607
		[Token(Token = "0x40303E7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x040303E8 RID: 197608
		[Token(Token = "0x40303E8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnPreload;

		// Token: 0x040303E9 RID: 197609
		[Token(Token = "0x40303E9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix1_RefreshData;

		// Token: 0x040303EA RID: 197610
		[Token(Token = "0x40303EA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040303EB RID: 197611
		[Token(Token = "0x40303EB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnItemCardClick;

		// Token: 0x040303EC RID: 197612
		[Token(Token = "0x40303EC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnHideItemDescClick;

		// Token: 0x040303ED RID: 197613
		[Token(Token = "0x40303ED")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnInitTopMenu;

		// Token: 0x040303EE RID: 197614
		[Token(Token = "0x40303EE")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnPageBack;

		// Token: 0x040303EF RID: 197615
		[Token(Token = "0x40303EF")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnClickToDetail;

		// Token: 0x040303F0 RID: 197616
		[Token(Token = "0x40303F0")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnClickToChangeFilter;

		// Token: 0x040303F1 RID: 197617
		[Token(Token = "0x40303F1")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
