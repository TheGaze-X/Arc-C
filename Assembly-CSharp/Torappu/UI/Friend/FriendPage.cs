using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Building.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D49 RID: 19785
	[Token(Token = "0x2004D49")]
	public class FriendPage : StateEnginePage, IBuildingPage
	{
		// Token: 0x17004582 RID: 17794
		// (get) Token: 0x0601D9BD RID: 121277 RVA: 0x000AC170 File Offset: 0x000AA370
		[Token(Token = "0x17004582")]
		public override AVGPageKey avgPage
		{
			[Token(Token = "0x601D9BD")]
			[Address(RVA = "0x172A960", Offset = "0x1729560", VA = "0x18172A960", Slot = "20")]
			get
			{
				return AVGPageKey.NONE;
			}
		}

		// Token: 0x17004583 RID: 17795
		// (get) Token: 0x0601D9BE RID: 121278 RVA: 0x000AC188 File Offset: 0x000AA388
		[Token(Token = "0x17004583")]
		public bool isVisitBuildingUnlocked
		{
			[Token(Token = "0x601D9BE")]
			[Address(RVA = "0x172A9C0", Offset = "0x17295C0", VA = "0x18172A9C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601D9BF RID: 121279 RVA: 0x000AC1A0 File Offset: 0x000AA3A0
		[Token(Token = "0x601D9BF")]
		[Address(RVA = "0x172A160", Offset = "0x1728D60", VA = "0x18172A160", Slot = "29")]
		public bool CanInteractBuilding()
		{
			return default(bool);
		}

		// Token: 0x0601D9C0 RID: 121280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D9C0")]
		[Address(RVA = "0x172A1C0", Offset = "0x1728DC0", VA = "0x18172A1C0", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0601D9C1 RID: 121281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D9C1")]
		[Address(RVA = "0x172A5E0", Offset = "0x17291E0", VA = "0x18172A5E0", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x0601D9C2 RID: 121282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D9C2")]
		[Address(RVA = "0x172A520", Offset = "0x1729120", VA = "0x18172A520", Slot = "17")]
		protected override void OnPageRouted()
		{
		}

		// Token: 0x0601D9C3 RID: 121283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D9C3")]
		private IEnumerator _OpenState<T>(bool isFast = false) where T : State
		{
			return null;
		}

		// Token: 0x0601D9C4 RID: 121284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D9C4")]
		[Address(RVA = "0x172A700", Offset = "0x1729300", VA = "0x18172A700")]
		private void _OnInitTopMenu(GameObject inst)
		{
		}

		// Token: 0x0601D9C5 RID: 121285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D9C5")]
		[Address(RVA = "0x172A830", Offset = "0x1729430", VA = "0x18172A830")]
		private void _SetBackgroundImg()
		{
		}

		// Token: 0x0601D9C6 RID: 121286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D9C6")]
		[Address(RVA = "0x172A650", Offset = "0x1729250", VA = "0x18172A650")]
		public void VisitBuilding(string friendId)
		{
		}

		// Token: 0x0601D9C7 RID: 121287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D9C7")]
		[Address(RVA = "0x172A900", Offset = "0x1729500", VA = "0x18172A900")]
		public FriendPage()
		{
		}

		// Token: 0x0601D9C9 RID: 121289 RVA: 0x000AC1B8 File Offset: 0x000AA3B8
		[Token(Token = "0x601D9C9")]
		[Address(RVA = "0x101CF00", Offset = "0x101BB00", VA = "0x18101CF00")]
		private AVGPageKey <>xLuaBaseProxy_get_avgPage()
		{
			return AVGPageKey.NONE;
		}

		// Token: 0x0601D9CA RID: 121290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D9CA")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0601D9CB RID: 121291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D9CB")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x0601D9CC RID: 121292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D9CC")]
		[Address(RVA = "0xF93B60", Offset = "0xF92760", VA = "0x180F93B60")]
		private void <>xLuaBaseProxy_OnPageRouted()
		{
		}

		// Token: 0x040271C5 RID: 160197
		[Token(Token = "0x40271C5")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private PrefabInstHolder _topMenuHolder;

		// Token: 0x040271C6 RID: 160198
		[Token(Token = "0x40271C6")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Text _lvl;

		// Token: 0x040271C7 RID: 160199
		[Token(Token = "0x40271C7")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Text _playerName;

		// Token: 0x040271C8 RID: 160200
		[Token(Token = "0x40271C8")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Text _playerServer;

		// Token: 0x040271C9 RID: 160201
		[Token(Token = "0x40271C9")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private FriendStateControl _stateController;

		// Token: 0x040271CA RID: 160202
		[Token(Token = "0x40271CA")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private FriendListStateBean _stateBean;

		// Token: 0x040271CB RID: 160203
		[Token(Token = "0x40271CB")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private Image _bgImage;

		// Token: 0x040271CC RID: 160204
		[Token(Token = "0x40271CC")]
		[FieldOffset(Offset = "0x128")]
		private bool m_isVisitBuildingUnlocked;

		// Token: 0x040271CD RID: 160205
		[Token(Token = "0x40271CD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_avgPage;

		// Token: 0x040271CE RID: 160206
		[Token(Token = "0x40271CE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isVisitBuildingUnlocked;

		// Token: 0x040271CF RID: 160207
		[Token(Token = "0x40271CF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CanInteractBuilding;

		// Token: 0x040271D0 RID: 160208
		[Token(Token = "0x40271D0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x040271D1 RID: 160209
		[Token(Token = "0x40271D1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x040271D2 RID: 160210
		[Token(Token = "0x40271D2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnPageRouted;

		// Token: 0x040271D3 RID: 160211
		[Token(Token = "0x40271D3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OpenState;

		// Token: 0x040271D4 RID: 160212
		[Token(Token = "0x40271D4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnInitTopMenu;

		// Token: 0x040271D5 RID: 160213
		[Token(Token = "0x40271D5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SetBackgroundImg;

		// Token: 0x040271D6 RID: 160214
		[Token(Token = "0x40271D6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_VisitBuilding;

		// Token: 0x040271D7 RID: 160215
		[Token(Token = "0x40271D7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004D4A RID: 19786
		[Token(Token = "0x2004D4A")]
		public enum InitOpts
		{
			// Token: 0x040271D9 RID: 160217
			[Token(Token = "0x40271D9")]
			NONE,
			// Token: 0x040271DA RID: 160218
			[Token(Token = "0x40271DA")]
			NAME_CARD_SKIN
		}

		// Token: 0x02004D4B RID: 19787
		[Token(Token = "0x2004D4B")]
		public class Param
		{
			// Token: 0x17004584 RID: 17796
			// (get) Token: 0x0601D9CD RID: 121293 RVA: 0x000AC1D0 File Offset: 0x000AA3D0
			// (set) Token: 0x0601D9CE RID: 121294 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004584")]
			public FriendPage.InitOpts initOpt
			{
				[Token(Token = "0x601D9CD")]
				[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
				[CompilerGenerated]
				private get
				{
					return FriendPage.InitOpts.NONE;
				}
				[Token(Token = "0x601D9CE")]
				[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0601D9CF RID: 121295 RVA: 0x000AC1E8 File Offset: 0x000AA3E8
			[Token(Token = "0x601D9CF")]
			[Address(RVA = "0x164B8B0", Offset = "0x164A4B0", VA = "0x18164B8B0")]
			public FriendPage.InitOpts ConsumeInitOpts()
			{
				return FriendPage.InitOpts.NONE;
			}

			// Token: 0x0601D9D0 RID: 121296 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D9D0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x040271DC RID: 160220
			[Token(Token = "0x40271DC")]
			[FieldOffset(Offset = "0x18")]
			public NameCardSkinChangeStateBean.RoutedNameCardSkinParam routedNameCardSkinParam;
		}
	}
}
