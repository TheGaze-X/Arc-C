using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053C7 RID: 21447
	[Token(Token = "0x20053C7")]
	public class RoguelikeRewardItemListState : PopupFloatState
	{
		// Token: 0x0601F8F7 RID: 129271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F8F7")]
		[Address(RVA = "0x193E660", Offset = "0x193D260", VA = "0x18193E660", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601F8F8 RID: 129272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F8F8")]
		[Address(RVA = "0x193FA70", Offset = "0x193E670", VA = "0x18193FA70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601F8F9 RID: 129273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F8F9")]
		[Address(RVA = "0x193F060", Offset = "0x193DC60", VA = "0x18193F060", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601F8FA RID: 129274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F8FA")]
		[Address(RVA = "0x193ED60", Offset = "0x193D960", VA = "0x18193ED60", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601F8FB RID: 129275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F8FB")]
		[Address(RVA = "0x193EF00", Offset = "0x193DB00", VA = "0x18193EF00", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601F8FC RID: 129276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F8FC")]
		[Address(RVA = "0x193E9D0", Offset = "0x193D5D0", VA = "0x18193E9D0")]
		public void OnClick(int index)
		{
		}

		// Token: 0x0601F8FD RID: 129277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F8FD")]
		[Address(RVA = "0x193F5B0", Offset = "0x193E1B0", VA = "0x18193F5B0")]
		private void _HandleOnLeave()
		{
		}

		// Token: 0x0601F8FE RID: 129278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F8FE")]
		[Address(RVA = "0x193E6C0", Offset = "0x193D2C0", VA = "0x18193E6C0")]
		public void HandleOnLeave()
		{
		}

		// Token: 0x0601F8FF RID: 129279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F8FF")]
		[Address(RVA = "0x193F7C0", Offset = "0x193E3C0", VA = "0x18193F7C0")]
		private void _HandleOnReceive(RoguelikeRewardItemViewModel item, string topicId)
		{
		}

		// Token: 0x0601F900 RID: 129280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F900")]
		[Address(RVA = "0x193FDE0", Offset = "0x193E9E0", VA = "0x18193FDE0")]
		public RoguelikeRewardItemListState()
		{
		}

		// Token: 0x0601F904 RID: 129284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F904")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601F905 RID: 129285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F905")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601F906 RID: 129286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F906")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0402A7DC RID: 174044
		[Token(Token = "0x402A7DC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RoguelikeRewardListView _listView;

		// Token: 0x0402A7DD RID: 174045
		[Token(Token = "0x402A7DD")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _panelTopMenu;

		// Token: 0x0402A7DE RID: 174046
		[Token(Token = "0x402A7DE")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIStyleProvider _styleProvider;

		// Token: 0x0402A7DF RID: 174047
		[Token(Token = "0x402A7DF")]
		[FieldOffset(Offset = "0x88")]
		private RoguelikeCommonTopMenu m_topMenu;

		// Token: 0x0402A7E0 RID: 174048
		[Token(Token = "0x402A7E0")]
		[FieldOffset(Offset = "0x90")]
		private RoguelikeRewardItemListState.MenuAdapter m_menuAdapter;

		// Token: 0x0402A7E1 RID: 174049
		[Token(Token = "0x402A7E1")]
		[FieldOffset(Offset = "0x98")]
		private RoguelikeRewardItemViewModel m_cacheViewModel;

		// Token: 0x0402A7E2 RID: 174050
		[Token(Token = "0x402A7E2")]
		[FieldOffset(Offset = "0xA0")]
		private RoguelikeRewardStyle m_style;

		// Token: 0x0402A7E3 RID: 174051
		[Token(Token = "0x402A7E3")]
		[FieldOffset(Offset = "0xA8")]
		private string m_topicId;

		// Token: 0x0402A7E4 RID: 174052
		[Token(Token = "0x402A7E4")]
		[FieldOffset(Offset = "0xB0")]
		private RoguelikeRewardStateBean m_stateBean;

		// Token: 0x0402A7E5 RID: 174053
		[Token(Token = "0x402A7E5")]
		[FieldOffset(Offset = "0xB8")]
		private string m_cachedTopicId;

		// Token: 0x0402A7E6 RID: 174054
		[Token(Token = "0x402A7E6")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_inited;

		// Token: 0x0402A7E7 RID: 174055
		[Token(Token = "0x402A7E7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402A7E8 RID: 174056
		[Token(Token = "0x402A7E8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402A7E9 RID: 174057
		[Token(Token = "0x402A7E9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0402A7EA RID: 174058
		[Token(Token = "0x402A7EA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402A7EB RID: 174059
		[Token(Token = "0x402A7EB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402A7EC RID: 174060
		[Token(Token = "0x402A7EC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402A7ED RID: 174061
		[Token(Token = "0x402A7ED")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__HandleOnLeave;

		// Token: 0x0402A7EE RID: 174062
		[Token(Token = "0x402A7EE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HandleOnLeave;

		// Token: 0x0402A7EF RID: 174063
		[Token(Token = "0x402A7EF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__HandleOnReceive;

		// Token: 0x0402A7F0 RID: 174064
		[Token(Token = "0x402A7F0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020053C8 RID: 21448
		[Token(Token = "0x20053C8")]
		private class MenuAdapter : RoguelikeMenuAdapter
		{
			// Token: 0x170049EE RID: 18926
			// (get) Token: 0x0601F907 RID: 129287 RVA: 0x000B23E0 File Offset: 0x000B05E0
			[Token(Token = "0x170049EE")]
			public override bool showStatusBar
			{
				[Token(Token = "0x601F907")]
				[Address(RVA = "0x1937E90", Offset = "0x1936A90", VA = "0x181937E90", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170049EF RID: 18927
			// (get) Token: 0x0601F908 RID: 129288 RVA: 0x000B23F8 File Offset: 0x000B05F8
			[Token(Token = "0x170049EF")]
			public override bool showBottomBar
			{
				[Token(Token = "0x601F908")]
				[Address(RVA = "0x1937DD0", Offset = "0x19369D0", VA = "0x181937DD0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0601F909 RID: 129289 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F909")]
			[Address(RVA = "0x1937D10", Offset = "0x1936910", VA = "0x181937D10")]
			public MenuAdapter()
			{
			}

			// Token: 0x0601F90A RID: 129290 RVA: 0x000B2410 File Offset: 0x000B0610
			[Token(Token = "0x601F90A")]
			[Address(RVA = "0x189EFF0", Offset = "0x189DBF0", VA = "0x18189EFF0")]
			private bool <>xLuaBaseProxy_get_showStatusBar()
			{
				return default(bool);
			}

			// Token: 0x0601F90B RID: 129291 RVA: 0x000B2428 File Offset: 0x000B0628
			[Token(Token = "0x601F90B")]
			[Address(RVA = "0x189EFE0", Offset = "0x189DBE0", VA = "0x18189EFE0")]
			private bool <>xLuaBaseProxy_get_showBottomBar()
			{
				return default(bool);
			}

			// Token: 0x0402A7F1 RID: 174065
			[Token(Token = "0x402A7F1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_showStatusBar;

			// Token: 0x0402A7F2 RID: 174066
			[Token(Token = "0x402A7F2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_showBottomBar;

			// Token: 0x0402A7F3 RID: 174067
			[Token(Token = "0x402A7F3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
