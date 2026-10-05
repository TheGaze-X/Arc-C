using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C37 RID: 23607
	[Token(Token = "0x2005C37")]
	public class ClimbTowerController : PageSingleComponent, IPlayerDataListener, IHotfixable
	{
		// Token: 0x1700503A RID: 20538
		// (get) Token: 0x06022367 RID: 140135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700503A")]
		public string towerId
		{
			[Token(Token = "0x6022367")]
			[Address(RVA = "0x1CA33D0", Offset = "0x1CA1FD0", VA = "0x181CA33D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700503B RID: 20539
		// (get) Token: 0x06022368 RID: 140136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700503B")]
		public ClimbTowerProperty towerProperty
		{
			[Token(Token = "0x6022368")]
			[Address(RVA = "0x1CA3440", Offset = "0x1CA2040", VA = "0x181CA3440")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700503C RID: 20540
		// (get) Token: 0x06022369 RID: 140137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700503C")]
		public ClimbTowerItemRewardProperty itemRewardProperty
		{
			[Token(Token = "0x6022369")]
			[Address(RVA = "0x1CA3260", Offset = "0x1CA1E60", VA = "0x181CA3260")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700503D RID: 20541
		// (get) Token: 0x0602236A RID: 140138 RVA: 0x000BCBB0 File Offset: 0x000BADB0
		// (set) Token: 0x0602236B RID: 140139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700503D")]
		public bool squadEditStateForceOpen
		{
			[Token(Token = "0x602236A")]
			[Address(RVA = "0x1CA3350", Offset = "0x1CA1F50", VA = "0x181CA3350")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602236B")]
			[Address(RVA = "0x1CA34B0", Offset = "0x1CA20B0", VA = "0x181CA34B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700503E RID: 20542
		// (get) Token: 0x0602236C RID: 140140 RVA: 0x000BCBC8 File Offset: 0x000BADC8
		[Token(Token = "0x1700503E")]
		public bool isTutorialTower
		{
			[Token(Token = "0x602236C")]
			[Address(RVA = "0x1CA31F0", Offset = "0x1CA1DF0", VA = "0x181CA31F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700503F RID: 20543
		// (get) Token: 0x0602236D RID: 140141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700503F")]
		public List<CharacterCardViewModel> predefinedCharList
		{
			[Token(Token = "0x602236D")]
			[Address(RVA = "0x1CA32D0", Offset = "0x1CA1ED0", VA = "0x181CA32D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602236E RID: 140142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602236E")]
		[Address(RVA = "0x1CA2020", Offset = "0x1CA0C20", VA = "0x181CA2020", Slot = "5")]
		protected override void OnCreate()
		{
		}

		// Token: 0x0602236F RID: 140143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602236F")]
		[Address(RVA = "0x1CA24D0", Offset = "0x1CA10D0", VA = "0x181CA24D0", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06022370 RID: 140144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022370")]
		public void RegisterMenuAdapter<TState>(ClimbTowerMenuAdapter adapter) where TState : State
		{
		}

		// Token: 0x06022371 RID: 140145 RVA: 0x000BCBE0 File Offset: 0x000BADE0
		[Token(Token = "0x6022371")]
		[Address(RVA = "0x1CA2740", Offset = "0x1CA1340", VA = "0x181CA2740")]
		public bool ValidateBottomMenu()
		{
			return default(bool);
		}

		// Token: 0x06022372 RID: 140146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022372")]
		public IEnumerator EnsureBottomMenu<TState>() where TState : State
		{
			return null;
		}

		// Token: 0x06022373 RID: 140147 RVA: 0x000BCBF8 File Offset: 0x000BADF8
		[Token(Token = "0x6022373")]
		[Address(RVA = "0x1CA1EF0", Offset = "0x1CA0AF0", VA = "0x181CA1EF0")]
		public bool IsEnterStateShowing()
		{
			return default(bool);
		}

		// Token: 0x06022374 RID: 140148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022374")]
		[Address(RVA = "0x1CA2610", Offset = "0x1CA1210", VA = "0x181CA2610")]
		public void SaveTowerSelectModeToCache()
		{
		}

		// Token: 0x06022375 RID: 140149 RVA: 0x000BCC10 File Offset: 0x000BAE10
		[Token(Token = "0x6022375")]
		[Address(RVA = "0x1CA1E40", Offset = "0x1CA0A40", VA = "0x181CA1E40", Slot = "12")]
		public bool CheckIfDataChanged(PlayerDataModel prevData, PlayerDataModel curData, PlayerDataDelta delta)
		{
			return default(bool);
		}

		// Token: 0x06022376 RID: 140150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022376")]
		[Address(RVA = "0x1CA2570", Offset = "0x1CA1170", VA = "0x181CA2570", Slot = "13")]
		public void OnPlayerDataChanged()
		{
		}

		// Token: 0x06022377 RID: 140151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022377")]
		[Address(RVA = "0x1CA2970", Offset = "0x1CA1570", VA = "0x181CA2970")]
		private void _OnMenuCreated(GameObject obj)
		{
		}

		// Token: 0x06022378 RID: 140152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022378")]
		[Address(RVA = "0x1CA2AC0", Offset = "0x1CA16C0", VA = "0x181CA2AC0")]
		private void _OnStateEnter(Type stateType, StateEngine.OnStateChangeListener.Additions additions)
		{
		}

		// Token: 0x06022379 RID: 140153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022379")]
		[Address(RVA = "0x1CA2D50", Offset = "0x1CA1950", VA = "0x181CA2D50")]
		private void _OnStateResume(Type stateType, bool backFromStack, StateEngine.OnStateChangeListener.Additions additions)
		{
		}

		// Token: 0x0602237A RID: 140154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602237A")]
		[Address(RVA = "0x1CA2BF0", Offset = "0x1CA17F0", VA = "0x181CA2BF0")]
		private void _OnStatePause(Type stateType, StateEngine.OnStateChangeListener.Additions additions)
		{
		}

		// Token: 0x0602237B RID: 140155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602237B")]
		[Address(RVA = "0x1CA27E0", Offset = "0x1CA13E0", VA = "0x181CA27E0")]
		private void _OnBeforeTransition(Type stateType, Type toType, StateEngine.OnStateChangeListener.Additions additions)
		{
		}

		// Token: 0x0602237C RID: 140156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602237C")]
		[Address(RVA = "0x1CA3060", Offset = "0x1CA1C60", VA = "0x181CA3060")]
		public ClimbTowerController()
		{
		}

		// Token: 0x0602237E RID: 140158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602237E")]
		[Address(RVA = "0xEE5F30", Offset = "0xEE4B30", VA = "0x180EE5F30")]
		private void <>xLuaBaseProxy_OnCreate()
		{
		}

		// Token: 0x0602237F RID: 140159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602237F")]
		[Address(RVA = "0xEDDC40", Offset = "0xEDC840", VA = "0x180EDDC40")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x0402EF08 RID: 192264
		[Token(Token = "0x402EF08")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type[] TRAP_AND_SQUAD_RELATED_STATES;

		// Token: 0x0402EF09 RID: 192265
		[Token(Token = "0x402EF09")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PrefabInstHolder _menuHolder;

		// Token: 0x0402EF0A RID: 192266
		[Token(Token = "0x402EF0A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private StateEngine _stateEngine;

		// Token: 0x0402EF0B RID: 192267
		[Token(Token = "0x402EF0B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UICommonPageEffectHolder _effectHolder;

		// Token: 0x0402EF0C RID: 192268
		[Token(Token = "0x402EF0C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _pnlTrapOrSquadBack;

		// Token: 0x0402EF0D RID: 192269
		[Token(Token = "0x402EF0D")]
		[FieldOffset(Offset = "0x40")]
		private string m_towerId;

		// Token: 0x0402EF0E RID: 192270
		[Token(Token = "0x402EF0E")]
		[FieldOffset(Offset = "0x48")]
		private ClimbTowerMenu m_menu;

		// Token: 0x0402EF0F RID: 192271
		[Token(Token = "0x402EF0F")]
		[FieldOffset(Offset = "0x50")]
		private ClimbTowerProperty m_towerProperty;

		// Token: 0x0402EF10 RID: 192272
		[Token(Token = "0x402EF10")]
		[FieldOffset(Offset = "0x58")]
		private ClimbTowerItemRewardProperty m_itemRewardProperty;

		// Token: 0x0402EF11 RID: 192273
		[Token(Token = "0x402EF11")]
		[FieldOffset(Offset = "0x60")]
		private bool _pnlTrapOrSquadShow;

		// Token: 0x0402EF12 RID: 192274
		[Token(Token = "0x402EF12")]
		[FieldOffset(Offset = "0x68")]
		private EventPool<ClimbTowerController.ClimbTowerUIEvent> m_eventPool;

		// Token: 0x0402EF13 RID: 192275
		[Token(Token = "0x402EF13")]
		[FieldOffset(Offset = "0x70")]
		private StateEngine.OnStateChangeListener m_stateEngineListener;

		// Token: 0x0402EF14 RID: 192276
		[Token(Token = "0x402EF14")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isTutorial;

		// Token: 0x0402EF15 RID: 192277
		[Token(Token = "0x402EF15")]
		[FieldOffset(Offset = "0x80")]
		private List<CharacterCardViewModel> m_predefinedCharList;

		// Token: 0x0402EF17 RID: 192279
		[Token(Token = "0x402EF17")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_towerId;

		// Token: 0x0402EF18 RID: 192280
		[Token(Token = "0x402EF18")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_towerProperty;

		// Token: 0x0402EF19 RID: 192281
		[Token(Token = "0x402EF19")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_itemRewardProperty;

		// Token: 0x0402EF1A RID: 192282
		[Token(Token = "0x402EF1A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_squadEditStateForceOpen;

		// Token: 0x0402EF1B RID: 192283
		[Token(Token = "0x402EF1B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_squadEditStateForceOpen;

		// Token: 0x0402EF1C RID: 192284
		[Token(Token = "0x402EF1C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isTutorialTower;

		// Token: 0x0402EF1D RID: 192285
		[Token(Token = "0x402EF1D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_predefinedCharList;

		// Token: 0x0402EF1E RID: 192286
		[Token(Token = "0x402EF1E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0402EF1F RID: 192287
		[Token(Token = "0x402EF1F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402EF20 RID: 192288
		[Token(Token = "0x402EF20")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_RegisterMenuAdapter;

		// Token: 0x0402EF21 RID: 192289
		[Token(Token = "0x402EF21")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ValidateBottomMenu;

		// Token: 0x0402EF22 RID: 192290
		[Token(Token = "0x402EF22")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EnsureBottomMenu;

		// Token: 0x0402EF23 RID: 192291
		[Token(Token = "0x402EF23")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_IsEnterStateShowing;

		// Token: 0x0402EF24 RID: 192292
		[Token(Token = "0x402EF24")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_SaveTowerSelectModeToCache;

		// Token: 0x0402EF25 RID: 192293
		[Token(Token = "0x402EF25")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_CheckIfDataChanged;

		// Token: 0x0402EF26 RID: 192294
		[Token(Token = "0x402EF26")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x0402EF27 RID: 192295
		[Token(Token = "0x402EF27")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnMenuCreated;

		// Token: 0x0402EF28 RID: 192296
		[Token(Token = "0x402EF28")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnStateEnter;

		// Token: 0x0402EF29 RID: 192297
		[Token(Token = "0x402EF29")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnStateResume;

		// Token: 0x0402EF2A RID: 192298
		[Token(Token = "0x402EF2A")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnStatePause;

		// Token: 0x0402EF2B RID: 192299
		[Token(Token = "0x402EF2B")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnBeforeTransition;

		// Token: 0x0402EF2C RID: 192300
		[Token(Token = "0x402EF2C")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005C38 RID: 23608
		[Token(Token = "0x2005C38")]
		public enum ClimbTowerUIEvent
		{
			// Token: 0x0402EF2E RID: 192302
			[Token(Token = "0x402EF2E")]
			ON_STATE_ENTER,
			// Token: 0x0402EF2F RID: 192303
			[Token(Token = "0x402EF2F")]
			ON_STATE_PAUSE,
			// Token: 0x0402EF30 RID: 192304
			[Token(Token = "0x402EF30")]
			ON_BEFORE_TRANSITION,
			// Token: 0x0402EF31 RID: 192305
			[Token(Token = "0x402EF31")]
			ON_PLAYER_DATA_CHANGED
		}

		// Token: 0x02005C39 RID: 23609
		[Token(Token = "0x2005C39")]
		public class ClimbTowerOnStateChangedArgs
		{
			// Token: 0x06022380 RID: 140160 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022380")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ClimbTowerOnStateChangedArgs()
			{
			}

			// Token: 0x0402EF32 RID: 192306
			[Token(Token = "0x402EF32")]
			[FieldOffset(Offset = "0x10")]
			public Type stateType;

			// Token: 0x0402EF33 RID: 192307
			[Token(Token = "0x402EF33")]
			[FieldOffset(Offset = "0x18")]
			public StateEngine.OnStateChangeListener.Additions additions;
		}

		// Token: 0x02005C3A RID: 23610
		[Token(Token = "0x2005C3A")]
		public class ClimbTowerControllerBridge
		{
			// Token: 0x06022381 RID: 140161 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022381")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public ClimbTowerControllerBridge(ClimbTowerController closure)
			{
			}

			// Token: 0x17005040 RID: 20544
			// (get) Token: 0x06022382 RID: 140162 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005040")]
			public EventPool<ClimbTowerController.ClimbTowerUIEvent> eventPool
			{
				[Token(Token = "0x6022382")]
				[Address(RVA = "0x1CA1CA0", Offset = "0x1CA08A0", VA = "0x181CA1CA0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17005041 RID: 20545
			// (get) Token: 0x06022383 RID: 140163 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005041")]
			public string towerId
			{
				[Token(Token = "0x6022383")]
				[Address(RVA = "0x1CA1D80", Offset = "0x1CA0980", VA = "0x181CA1D80")]
				get
				{
					return null;
				}
			}

			// Token: 0x17005042 RID: 20546
			// (get) Token: 0x06022384 RID: 140164 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005042")]
			public StateEngine stateEngine
			{
				[Token(Token = "0x6022384")]
				[Address(RVA = "0x1CA1D60", Offset = "0x1CA0960", VA = "0x181CA1D60")]
				get
				{
					return null;
				}
			}

			// Token: 0x17005043 RID: 20547
			// (get) Token: 0x06022385 RID: 140165 RVA: 0x000BCC28 File Offset: 0x000BAE28
			[Token(Token = "0x17005043")]
			public bool isTutorialTower
			{
				[Token(Token = "0x6022385")]
				[Address(RVA = "0x1CA1CC0", Offset = "0x1CA08C0", VA = "0x181CA1CC0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17005044 RID: 20548
			// (get) Token: 0x06022386 RID: 140166 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005044")]
			public List<CharacterCardViewModel> predefinedCharList
			{
				[Token(Token = "0x6022386")]
				[Address(RVA = "0xCE05E0", Offset = "0xCDF1E0", VA = "0x180CE05E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17005045 RID: 20549
			// (get) Token: 0x06022387 RID: 140167 RVA: 0x000BCC40 File Offset: 0x000BAE40
			// (set) Token: 0x06022388 RID: 140168 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005045")]
			public bool squadEditStateForceOpen
			{
				[Token(Token = "0x6022387")]
				[Address(RVA = "0x1CA1CE0", Offset = "0x1CA08E0", VA = "0x181CA1CE0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6022388")]
				[Address(RVA = "0x1CA1DA0", Offset = "0x1CA09A0", VA = "0x181CA1DA0")]
				set
				{
				}
			}

			// Token: 0x17005046 RID: 20550
			// (get) Token: 0x06022389 RID: 140169 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005046")]
			public UIPage bindPage
			{
				[Token(Token = "0x6022389")]
				[Address(RVA = "0x1CA1C80", Offset = "0x1CA0880", VA = "0x181CA1C80")]
				get
				{
					return null;
				}
			}

			// Token: 0x0602238A RID: 140170 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602238A")]
			[Address(RVA = "0x1CA1BE0", Offset = "0x1CA07E0", VA = "0x181CA1BE0")]
			public void SetEffectActive(bool show)
			{
			}

			// Token: 0x0402EF34 RID: 192308
			[Token(Token = "0x402EF34")]
			[FieldOffset(Offset = "0x10")]
			private ClimbTowerController m_closure;
		}
	}
}
