using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Crisis;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005948 RID: 22856
	[Token(Token = "0x2005948")]
	public class CrisisV2ShopState : State
	{
		// Token: 0x17004E16 RID: 19990
		// (get) Token: 0x060214FB RID: 136443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E16")]
		public CrisisShopViewHolder viewHolder
		{
			[Token(Token = "0x60214FB")]
			[Address(RVA = "0x1BBA450", Offset = "0x1BB9050", VA = "0x181BBA450")]
			get
			{
				return null;
			}
		}

		// Token: 0x060214FC RID: 136444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214FC")]
		[Address(RVA = "0x1BB9130", Offset = "0x1BB7D30", VA = "0x181BB9130")]
		public void OnEnterDetail(CrisisShopWrapped shopWrapped)
		{
		}

		// Token: 0x060214FD RID: 136445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60214FD")]
		[Address(RVA = "0x1BB9810", Offset = "0x1BB8410", VA = "0x181BB9810", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x060214FE RID: 136446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60214FE")]
		[Address(RVA = "0x1BB90D0", Offset = "0x1BB7CD0", VA = "0x181BB90D0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060214FF RID: 136447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214FF")]
		[Address(RVA = "0x1BB91E0", Offset = "0x1BB7DE0", VA = "0x181BB91E0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06021500 RID: 136448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021500")]
		[Address(RVA = "0x1BB9660", Offset = "0x1BB8260", VA = "0x181BB9660", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06021501 RID: 136449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021501")]
		[Address(RVA = "0x1BB95D0", Offset = "0x1BB81D0", VA = "0x181BB95D0")]
		public void OnOpenV1ShopState()
		{
		}

		// Token: 0x06021502 RID: 136450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021502")]
		[Address(RVA = "0x1BBA340", Offset = "0x1BB8F40", VA = "0x181BBA340")]
		private void _TryConsumeGuidebook()
		{
		}

		// Token: 0x06021503 RID: 136451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021503")]
		[Address(RVA = "0x1BBA120", Offset = "0x1BB8D20", VA = "0x181BBA120")]
		private void _SendGetInfo()
		{
		}

		// Token: 0x06021504 RID: 136452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021504")]
		[Address(RVA = "0x1BB9970", Offset = "0x1BB8570", VA = "0x181BB9970")]
		private IEnumerator ShowDetailCoroutine()
		{
			return null;
		}

		// Token: 0x06021505 RID: 136453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021505")]
		[Address(RVA = "0x1BBA3F0", Offset = "0x1BB8FF0", VA = "0x181BBA3F0")]
		public CrisisV2ShopState()
		{
		}

		// Token: 0x0602150A RID: 136458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602150A")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602150B RID: 136459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602150B")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602150C RID: 136460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602150C")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0402D6BE RID: 186046
		[Token(Token = "0x402D6BE")]
		private const string GUIDE_BOOK_SUB_SIGNAL = "shop";

		// Token: 0x0402D6BF RID: 186047
		[Token(Token = "0x402D6BF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CrisisShopStateBean _stateBean;

		// Token: 0x0402D6C0 RID: 186048
		[Token(Token = "0x402D6C0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CrisisShopViewHolder _viewHolder;

		// Token: 0x0402D6C1 RID: 186049
		[Token(Token = "0x402D6C1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _viewHolderContainer;

		// Token: 0x0402D6C2 RID: 186050
		[Token(Token = "0x402D6C2")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topmenuHolder;

		// Token: 0x0402D6C3 RID: 186051
		[Token(Token = "0x402D6C3")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _coinV2;

		// Token: 0x0402D6C4 RID: 186052
		[Token(Token = "0x402D6C4")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CanvasGroup _alphaGroup;

		// Token: 0x0402D6C5 RID: 186053
		[Token(Token = "0x402D6C5")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CrisisShopEvent _clickEvent;

		// Token: 0x0402D6C6 RID: 186054
		[Token(Token = "0x402D6C6")]
		[FieldOffset(Offset = "0x88")]
		private CrisisShopWrapped m_cacheData;

		// Token: 0x0402D6C7 RID: 186055
		[Token(Token = "0x402D6C7")]
		[FieldOffset(Offset = "0x90")]
		private CrisisShopViewHolder m_viewHolder;

		// Token: 0x0402D6C8 RID: 186056
		[Token(Token = "0x402D6C8")]
		private const float ITEM_FADE_DURATION = 0.23f;

		// Token: 0x0402D6C9 RID: 186057
		[Token(Token = "0x402D6C9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_viewHolder;

		// Token: 0x0402D6CA RID: 186058
		[Token(Token = "0x402D6CA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnterDetail;

		// Token: 0x0402D6CB RID: 186059
		[Token(Token = "0x402D6CB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0402D6CC RID: 186060
		[Token(Token = "0x402D6CC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402D6CD RID: 186061
		[Token(Token = "0x402D6CD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402D6CE RID: 186062
		[Token(Token = "0x402D6CE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402D6CF RID: 186063
		[Token(Token = "0x402D6CF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnOpenV1ShopState;

		// Token: 0x0402D6D0 RID: 186064
		[Token(Token = "0x402D6D0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TryConsumeGuidebook;

		// Token: 0x0402D6D1 RID: 186065
		[Token(Token = "0x402D6D1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SendGetInfo;

		// Token: 0x0402D6D2 RID: 186066
		[Token(Token = "0x402D6D2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ShowDetailCoroutine;

		// Token: 0x0402D6D3 RID: 186067
		[Token(Token = "0x402D6D3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
