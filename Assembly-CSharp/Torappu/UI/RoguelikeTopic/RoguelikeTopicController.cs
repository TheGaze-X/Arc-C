using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x0200452D RID: 17709
	[Token(Token = "0x200452D")]
	public class RoguelikeTopicController : PageSingleComponent, IPlayerDataListener, IHotfixable, IDataBindWrapper
	{
		// Token: 0x1700403D RID: 16445
		// (get) Token: 0x0601B020 RID: 110624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700403D")]
		public RoguelikeTopicModeViewProperty modeProperty
		{
			[Token(Token = "0x601B020")]
			[Address(RVA = "0x1429340", Offset = "0x1427F40", VA = "0x181429340")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700403E RID: 16446
		// (get) Token: 0x0601B021 RID: 110625 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B022 RID: 110626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700403E")]
		public RoguelikeTopicTheme theme
		{
			[Token(Token = "0x601B021")]
			[Address(RVA = "0x14293B0", Offset = "0x1427FB0", VA = "0x1814293B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B022")]
			[Address(RVA = "0x14294B0", Offset = "0x14280B0", VA = "0x1814294B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700403F RID: 16447
		// (get) Token: 0x0601B023 RID: 110627 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B024 RID: 110628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700403F")]
		public string topicId
		{
			[Token(Token = "0x601B023")]
			[Address(RVA = "0x1429430", Offset = "0x1428030", VA = "0x181429430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B024")]
			[Address(RVA = "0x1429540", Offset = "0x1428140", VA = "0x181429540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004040 RID: 16448
		// (get) Token: 0x0601B025 RID: 110629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004040")]
		public UICompDialogMgr dialogMgr
		{
			[Token(Token = "0x601B025")]
			[Address(RVA = "0x14292D0", Offset = "0x1427ED0", VA = "0x1814292D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601B026 RID: 110630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B026")]
		[Address(RVA = "0x1427700", Offset = "0x1426300", VA = "0x181427700", Slot = "5")]
		protected override void OnCreate()
		{
		}

		// Token: 0x0601B027 RID: 110631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B027")]
		[Address(RVA = "0x1427F20", Offset = "0x1426B20", VA = "0x181427F20", Slot = "7")]
		protected override void OnStart()
		{
		}

		// Token: 0x0601B028 RID: 110632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B028")]
		[Address(RVA = "0x1427E30", Offset = "0x1426A30", VA = "0x181427E30", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0601B029 RID: 110633 RVA: 0x000A3E00 File Offset: 0x000A2000
		[Token(Token = "0x601B029")]
		[Address(RVA = "0x14275D0", Offset = "0x14261D0", VA = "0x1814275D0", Slot = "12")]
		public bool CheckIfDataChanged(PlayerDataModel prevData, PlayerDataModel curData, PlayerDataDelta delta)
		{
			return default(bool);
		}

		// Token: 0x0601B02A RID: 110634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B02A")]
		[Address(RVA = "0x1427EB0", Offset = "0x1426AB0", VA = "0x181427EB0", Slot = "13")]
		public void OnPlayerDataChanged()
		{
		}

		// Token: 0x0601B02B RID: 110635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B02B")]
		[Address(RVA = "0x1427FA0", Offset = "0x1426BA0", VA = "0x181427FA0")]
		public void UpdateResource(bool show)
		{
		}

		// Token: 0x0601B02C RID: 110636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B02C")]
		[Address(RVA = "0x1428640", Offset = "0x1427240", VA = "0x181428640")]
		private void _OnBack()
		{
		}

		// Token: 0x0601B02D RID: 110637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B02D")]
		[Address(RVA = "0x1428800", Offset = "0x1427400", VA = "0x181428800")]
		private void _OnBeforeTransition(Type stateType, Type toType, StateEngine.OnStateChangeListener.Additions additions)
		{
		}

		// Token: 0x0601B02E RID: 110638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B02E")]
		[Address(RVA = "0x1428170", Offset = "0x1426D70", VA = "0x181428170")]
		private static CommonTopMenu _CreateCommonTopMenu(RectTransform container, [Optional] Action onBackClick)
		{
			return null;
		}

		// Token: 0x0601B02F RID: 110639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B02F")]
		[Address(RVA = "0x1428580", Offset = "0x1427180", VA = "0x181428580")]
		private RoguelikeTopicTheme _LoadTheme(string topicId)
		{
			return null;
		}

		// Token: 0x0601B030 RID: 110640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B030")]
		[Address(RVA = "0x1428A50", Offset = "0x1427650", VA = "0x181428A50")]
		private void _TriggerBGMSignal()
		{
		}

		// Token: 0x0601B031 RID: 110641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B031")]
		[Address(RVA = "0x1427680", Offset = "0x1426280", VA = "0x181427680")]
		public string GetBgmInstIdAlias()
		{
			return null;
		}

		// Token: 0x0601B032 RID: 110642 RVA: 0x000A3E18 File Offset: 0x000A2018
		[Token(Token = "0x601B032")]
		[Address(RVA = "0x1428400", Offset = "0x1427000", VA = "0x181428400")]
		private long _GetBGMInstId()
		{
			return 0L;
		}

		// Token: 0x0601B033 RID: 110643 RVA: 0x000A3E30 File Offset: 0x000A2030
		[Token(Token = "0x601B033")]
		[Address(RVA = "0x1428300", Offset = "0x1426F00", VA = "0x181428300")]
		private static UIMusicManager.ChunkConfig _CreateRoguelikeTopicMusicChunk(string subSignal)
		{
			return default(UIMusicManager.ChunkConfig);
		}

		// Token: 0x0601B034 RID: 110644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B034")]
		[Address(RVA = "0x14280C0", Offset = "0x1426CC0", VA = "0x1814280C0")]
		private void _ClearBGM()
		{
		}

		// Token: 0x0601B035 RID: 110645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B035")]
		[Address(RVA = "0x1428500", Offset = "0x1427100", VA = "0x181428500")]
		private string _GetBGMSignal()
		{
			return null;
		}

		// Token: 0x0601B036 RID: 110646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B036")]
		[Address(RVA = "0x1429190", Offset = "0x1427D90", VA = "0x181429190")]
		public RoguelikeTopicController()
		{
		}

		// Token: 0x0601B038 RID: 110648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B038")]
		[Address(RVA = "0xEE5F30", Offset = "0xEE4B30", VA = "0x180EE5F30")]
		private void <>xLuaBaseProxy_OnCreate()
		{
		}

		// Token: 0x0601B039 RID: 110649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B039")]
		[Address(RVA = "0xF53770", Offset = "0xF52370", VA = "0x180F53770")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x0601B03A RID: 110650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B03A")]
		[Address(RVA = "0xEDDC40", Offset = "0xEDC840", VA = "0x180EDDC40")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x04022B08 RID: 142088
		[Token(Token = "0x4022B08")]
		private const float FADE_TWEEN_DURATION = 0.63f;

		// Token: 0x04022B09 RID: 142089
		[Token(Token = "0x4022B09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Type[] HIDE_TOP_MENU_STATES;

		// Token: 0x04022B0A RID: 142090
		[Token(Token = "0x4022B0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Type[] SHOW_RESOURCE_BAR_STATES;

		// Token: 0x04022B0B RID: 142091
		[Token(Token = "0x4022B0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ResourceBarViewProperty _resourceBarProperty;

		// Token: 0x04022B0C RID: 142092
		[Token(Token = "0x4022B0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private StateEngine _stateEngine;

		// Token: 0x04022B0D RID: 142093
		[Token(Token = "0x4022B0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x04022B0E RID: 142094
		[Token(Token = "0x4022B0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _resourceContainer;

		// Token: 0x04022B0F RID: 142095
		[Token(Token = "0x4022B0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _compDialogContainer;

		// Token: 0x04022B10 RID: 142096
		[Token(Token = "0x4022B10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RoguelikeTopicModeViewProperty m_modeProperty;

		// Token: 0x04022B11 RID: 142097
		[Token(Token = "0x4022B11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private StateEngine.OnStateChangeListener m_stateEngineListener;

		// Token: 0x04022B12 RID: 142098
		[Token(Token = "0x4022B12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CommonTopMenu m_topMenu;

		// Token: 0x04022B13 RID: 142099
		[Token(Token = "0x4022B13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private UISwitchTween m_topMenuSwitchTween;

		// Token: 0x04022B14 RID: 142100
		[Token(Token = "0x4022B14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private UISwitchTween m_resourceSwitchTween;

		// Token: 0x04022B15 RID: 142101
		[Token(Token = "0x4022B15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string m_bgmInstIdAlias;

		// Token: 0x04022B16 RID: 142102
		[Token(Token = "0x4022B16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private UICompDialogMgr m_dialogMgr;

		// Token: 0x04022B19 RID: 142105
		[Token(Token = "0x4022B19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_modeProperty;

		// Token: 0x04022B1A RID: 142106
		[Token(Token = "0x4022B1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_theme;

		// Token: 0x04022B1B RID: 142107
		[Token(Token = "0x4022B1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_theme;

		// Token: 0x04022B1C RID: 142108
		[Token(Token = "0x4022B1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x04022B1D RID: 142109
		[Token(Token = "0x4022B1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_topicId;

		// Token: 0x04022B1E RID: 142110
		[Token(Token = "0x4022B1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_dialogMgr;

		// Token: 0x04022B1F RID: 142111
		[Token(Token = "0x4022B1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04022B20 RID: 142112
		[Token(Token = "0x4022B20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x04022B21 RID: 142113
		[Token(Token = "0x4022B21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04022B22 RID: 142114
		[Token(Token = "0x4022B22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CheckIfDataChanged;

		// Token: 0x04022B23 RID: 142115
		[Token(Token = "0x4022B23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x04022B24 RID: 142116
		[Token(Token = "0x4022B24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_UpdateResource;

		// Token: 0x04022B25 RID: 142117
		[Token(Token = "0x4022B25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnBack;

		// Token: 0x04022B26 RID: 142118
		[Token(Token = "0x4022B26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnBeforeTransition;

		// Token: 0x04022B27 RID: 142119
		[Token(Token = "0x4022B27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__CreateCommonTopMenu;

		// Token: 0x04022B28 RID: 142120
		[Token(Token = "0x4022B28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__LoadTheme;

		// Token: 0x04022B29 RID: 142121
		[Token(Token = "0x4022B29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__TriggerBGMSignal;

		// Token: 0x04022B2A RID: 142122
		[Token(Token = "0x4022B2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_GetBgmInstIdAlias;

		// Token: 0x04022B2B RID: 142123
		[Token(Token = "0x4022B2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__GetBGMInstId;

		// Token: 0x04022B2C RID: 142124
		[Token(Token = "0x4022B2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__CreateRoguelikeTopicMusicChunk;

		// Token: 0x04022B2D RID: 142125
		[Token(Token = "0x4022B2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__ClearBGM;

		// Token: 0x04022B2E RID: 142126
		[Token(Token = "0x4022B2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__GetBGMSignal;

		// Token: 0x04022B2F RID: 142127
		[Token(Token = "0x4022B2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200452E RID: 17710
		[Token(Token = "0x200452E")]
		private class ShowSwitchTween : UISwitchTween
		{
			// Token: 0x0601B03B RID: 110651 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B03B")]
			[Address(RVA = "0x1441B90", Offset = "0x1440790", VA = "0x181441B90")]
			public ShowSwitchTween(CanvasGroup canvasGroup)
			{
			}

			// Token: 0x0601B03C RID: 110652 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B03C")]
			[Address(RVA = "0x14419E0", Offset = "0x14405E0", VA = "0x1814419E0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601B03D RID: 110653 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B03D")]
			[Address(RVA = "0x1441910", Offset = "0x1440510", VA = "0x181441910", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601B03E RID: 110654 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B03E")]
			[Address(RVA = "0x1441810", Offset = "0x1440410", VA = "0x181441810", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0601B03F RID: 110655 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B03F")]
			[Address(RVA = "0x1441890", Offset = "0x1440490", VA = "0x181441890", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0601B040 RID: 110656 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B040")]
			[Address(RVA = "0x1441AE0", Offset = "0x14406E0", VA = "0x181441AE0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601B041 RID: 110657 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B041")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0601B042 RID: 110658 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B042")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0601B043 RID: 110659 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B043")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x04022B30 RID: 142128
			[Token(Token = "0x4022B30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private CanvasGroup m_canvasGroup;

			// Token: 0x04022B31 RID: 142129
			[Token(Token = "0x4022B31")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04022B32 RID: 142130
			[Token(Token = "0x4022B32")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04022B33 RID: 142131
			[Token(Token = "0x4022B33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x04022B34 RID: 142132
			[Token(Token = "0x4022B34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x04022B35 RID: 142133
			[Token(Token = "0x4022B35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x04022B36 RID: 142134
			[Token(Token = "0x4022B36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
