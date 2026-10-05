using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Activity;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006789 RID: 26505
	[Token(Token = "0x2006789")]
	public class ActivityCustomZoneMapPage : StateEnginePage, IValueMsgReceiver, IDialogMgrHolder
	{
		// Token: 0x170059EF RID: 23023
		// (get) Token: 0x06026051 RID: 155729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170059EF")]
		public ActivityCustomZoneMapPage.InputParam cachedParam
		{
			[Token(Token = "0x6026051")]
			[Address(RVA = "0x20EA810", Offset = "0x20E9410", VA = "0x1820EA810")]
			get
			{
				return null;
			}
		}

		// Token: 0x06026052 RID: 155730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026052")]
		[Address(RVA = "0x20E98D0", Offset = "0x20E84D0", VA = "0x1820E98D0", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x06026053 RID: 155731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026053")]
		[Address(RVA = "0x20E9820", Offset = "0x20E8420", VA = "0x1820E9820", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x06026054 RID: 155732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026054")]
		[Address(RVA = "0x20E9D10", Offset = "0x20E8910", VA = "0x1820E9D10", Slot = "29")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06026055 RID: 155733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026055")]
		[Address(RVA = "0x20EA610", Offset = "0x20E9210", VA = "0x1820EA610")]
		private void _ShowRewardsGet(ActivityCustomZoneMapPage.ShowRewardsGetInfo info)
		{
		}

		// Token: 0x06026056 RID: 155734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026056")]
		[Address(RVA = "0x20EA090", Offset = "0x20E8C90", VA = "0x1820EA090")]
		private IEnumerator _InitStateEngine()
		{
			return null;
		}

		// Token: 0x06026057 RID: 155735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026057")]
		[Address(RVA = "0x20EA3E0", Offset = "0x20E8FE0", VA = "0x1820EA3E0")]
		private IEnumerator _RouteToCustomZoneMapState()
		{
			return null;
		}

		// Token: 0x06026058 RID: 155736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026058")]
		[Address(RVA = "0x20EA490", Offset = "0x20E9090", VA = "0x1820EA490")]
		private IEnumerator _RouteToCustomZoneStagePreviewState()
		{
			return null;
		}

		// Token: 0x06026059 RID: 155737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026059")]
		[Address(RVA = "0x20EA2B0", Offset = "0x20E8EB0", VA = "0x1820EA2B0")]
		private void _OnInitTopMenu(GameObject inst)
		{
		}

		// Token: 0x0602605A RID: 155738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602605A")]
		[Address(RVA = "0x20EA140", Offset = "0x20E8D40", VA = "0x1820EA140")]
		private void _LoadCustomTopMenu(string topMenuPath)
		{
		}

		// Token: 0x0602605B RID: 155739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602605B")]
		[Address(RVA = "0x20E9F80", Offset = "0x20E8B80", VA = "0x1820E9F80")]
		public void ReturnPage()
		{
		}

		// Token: 0x0602605C RID: 155740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602605C")]
		[Address(RVA = "0x20EA540", Offset = "0x20E9140", VA = "0x1820EA540")]
		private void _SetBackgroundImg()
		{
		}

		// Token: 0x0602605D RID: 155741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602605D")]
		[Address(RVA = "0x20E97C0", Offset = "0x20E83C0", VA = "0x1820E97C0", Slot = "30")]
		public UICompDialogMgr GetDialogMgr()
		{
			return null;
		}

		// Token: 0x0602605E RID: 155742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602605E")]
		[Address(RVA = "0x20EA7B0", Offset = "0x20E93B0", VA = "0x1820EA7B0")]
		public ActivityCustomZoneMapPage()
		{
		}

		// Token: 0x06026062 RID: 155746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026062")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x06026063 RID: 155747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026063")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x040357D2 RID: 219090
		[Token(Token = "0x40357D2")]
		[NonSerialized]
		public const int SHOW_REWARDS_GET = 0;

		// Token: 0x040357D3 RID: 219091
		[Token(Token = "0x40357D3")]
		[NonSerialized]
		public const int PAGE_BACK = 1;

		// Token: 0x040357D4 RID: 219092
		[Token(Token = "0x40357D4")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private ActivityCustomZoneStateBean _stateBean;

		// Token: 0x040357D5 RID: 219093
		[Token(Token = "0x40357D5")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _commonTopMenuHolder;

		// Token: 0x040357D6 RID: 219094
		[Token(Token = "0x40357D6")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private RectTransform _customTopMenuHolder;

		// Token: 0x040357D7 RID: 219095
		[Token(Token = "0x40357D7")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Image _bgImage;

		// Token: 0x040357D8 RID: 219096
		[Token(Token = "0x40357D8")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private RectTransform _dlgContainer;

		// Token: 0x040357D9 RID: 219097
		[Token(Token = "0x40357D9")]
		[FieldOffset(Offset = "0x118")]
		private ActivityCustomZoneMapPage.InputParam m_cachedParam;

		// Token: 0x040357DA RID: 219098
		[Token(Token = "0x40357DA")]
		[FieldOffset(Offset = "0x120")]
		private UICompDialogMgr m_dlgMgr;

		// Token: 0x040357DB RID: 219099
		[Token(Token = "0x40357DB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cachedParam;

		// Token: 0x040357DC RID: 219100
		[Token(Token = "0x40357DC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x040357DD RID: 219101
		[Token(Token = "0x40357DD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x040357DE RID: 219102
		[Token(Token = "0x40357DE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x040357DF RID: 219103
		[Token(Token = "0x40357DF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ShowRewardsGet;

		// Token: 0x040357E0 RID: 219104
		[Token(Token = "0x40357E0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitStateEngine;

		// Token: 0x040357E1 RID: 219105
		[Token(Token = "0x40357E1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RouteToCustomZoneMapState;

		// Token: 0x040357E2 RID: 219106
		[Token(Token = "0x40357E2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RouteToCustomZoneStagePreviewState;

		// Token: 0x040357E3 RID: 219107
		[Token(Token = "0x40357E3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnInitTopMenu;

		// Token: 0x040357E4 RID: 219108
		[Token(Token = "0x40357E4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__LoadCustomTopMenu;

		// Token: 0x040357E5 RID: 219109
		[Token(Token = "0x40357E5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ReturnPage;

		// Token: 0x040357E6 RID: 219110
		[Token(Token = "0x40357E6")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__SetBackgroundImg;

		// Token: 0x040357E7 RID: 219111
		[Token(Token = "0x40357E7")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetDialogMgr;

		// Token: 0x040357E8 RID: 219112
		[Token(Token = "0x40357E8")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200678A RID: 26506
		[Token(Token = "0x200678A")]
		public enum InitState
		{
			// Token: 0x040357EA RID: 219114
			[Token(Token = "0x40357EA")]
			CUSTOM_ZONE_STATE,
			// Token: 0x040357EB RID: 219115
			[Token(Token = "0x40357EB")]
			CUSTOM_STAGE_PREVIEW_STATE
		}

		// Token: 0x0200678B RID: 26507
		[Token(Token = "0x200678B")]
		public class InputParam
		{
			// Token: 0x06026064 RID: 155748 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026064")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public InputParam()
			{
			}

			// Token: 0x040357EC RID: 219116
			[Token(Token = "0x40357EC")]
			[FieldOffset(Offset = "0x10")]
			public ActivityCustomZoneMapViewModel zoneModel;

			// Token: 0x040357ED RID: 219117
			[Token(Token = "0x40357ED")]
			[FieldOffset(Offset = "0x18")]
			public ActivityCustomZoneMapPage.InitState initState;

			// Token: 0x040357EE RID: 219118
			[Token(Token = "0x40357EE")]
			[FieldOffset(Offset = "0x20")]
			public string customTopMenuPrefabPath;
		}

		// Token: 0x0200678C RID: 26508
		[Token(Token = "0x200678C")]
		public struct ShowRewardsGetInfo
		{
			// Token: 0x040357EF RID: 219119
			[Token(Token = "0x40357EF")]
			[FieldOffset(Offset = "0x0")]
			public List<RewardItemModel> rewards;

			// Token: 0x040357F0 RID: 219120
			[Token(Token = "0x40357F0")]
			[FieldOffset(Offset = "0x8")]
			public Action onAfterItemShow;
		}
	}
}
