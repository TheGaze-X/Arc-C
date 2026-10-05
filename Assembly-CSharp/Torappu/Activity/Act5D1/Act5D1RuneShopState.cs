using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x02007250 RID: 29264
	[Token(Token = "0x2007250")]
	public class Act5D1RuneShopState : PopupFadeState
	{
		// Token: 0x06029799 RID: 169881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029799")]
		[Address(RVA = "0x24E6770", Offset = "0x24E5370", VA = "0x1824E6770", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602979A RID: 169882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602979A")]
		[Address(RVA = "0x24E6840", Offset = "0x24E5440", VA = "0x1824E6840", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602979B RID: 169883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602979B")]
		[Address(RVA = "0x24E6C30", Offset = "0x24E5830", VA = "0x1824E6C30")]
		private void _SendGetGoodList()
		{
		}

		// Token: 0x0602979C RID: 169884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602979C")]
		[Address(RVA = "0x24E6B40", Offset = "0x24E5740", VA = "0x1824E6B40")]
		public void TransDataToDetail(IStateBean stateBean)
		{
		}

		// Token: 0x0602979D RID: 169885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602979D")]
		[Address(RVA = "0x24E6920", Offset = "0x24E5520", VA = "0x1824E6920", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602979E RID: 169886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602979E")]
		[Address(RVA = "0x24E68A0", Offset = "0x24E54A0", VA = "0x1824E68A0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602979F RID: 169887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602979F")]
		[Address(RVA = "0x24E6E90", Offset = "0x24E5A90", VA = "0x1824E6E90")]
		private void _Syn(Act5D1GetGoodsListResponse response)
		{
		}

		// Token: 0x060297A0 RID: 169888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297A0")]
		[Address(RVA = "0x24E67D0", Offset = "0x24E53D0", VA = "0x1824E67D0")]
		public void NotifyBuyComplete()
		{
		}

		// Token: 0x060297A1 RID: 169889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297A1")]
		[Address(RVA = "0x24E74C0", Offset = "0x24E60C0", VA = "0x1824E74C0")]
		public Act5D1RuneShopState()
		{
		}

		// Token: 0x060297A3 RID: 169891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297A3")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060297A4 RID: 169892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60297A4")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x060297A5 RID: 169893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297A5")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0403B42A RID: 242730
		[Token(Token = "0x403B42A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act5D1RuneShopStateBean _stateBean;

		// Token: 0x0403B42B RID: 242731
		[Token(Token = "0x403B42B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act5D1RuneShopItem _itemPrefab;

		// Token: 0x0403B42C RID: 242732
		[Token(Token = "0x403B42C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _listRoot;

		// Token: 0x0403B42D RID: 242733
		[Token(Token = "0x403B42D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Act5D1ResourceBar _resourceBar;

		// Token: 0x0403B42E RID: 242734
		[Token(Token = "0x403B42E")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		public Act5D1ShopCommonViewModel forOpenViewModel;

		// Token: 0x0403B42F RID: 242735
		[Token(Token = "0x403B42F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403B430 RID: 242736
		[Token(Token = "0x403B430")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403B431 RID: 242737
		[Token(Token = "0x403B431")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SendGetGoodList;

		// Token: 0x0403B432 RID: 242738
		[Token(Token = "0x403B432")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TransDataToDetail;

		// Token: 0x0403B433 RID: 242739
		[Token(Token = "0x403B433")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403B434 RID: 242740
		[Token(Token = "0x403B434")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403B435 RID: 242741
		[Token(Token = "0x403B435")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__Syn;

		// Token: 0x0403B436 RID: 242742
		[Token(Token = "0x403B436")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_NotifyBuyComplete;

		// Token: 0x0403B437 RID: 242743
		[Token(Token = "0x403B437")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
