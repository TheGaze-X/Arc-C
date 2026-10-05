using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Init;
using Torappu.UI.Roguelike.Init.Style;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052F1 RID: 21233
	[Token(Token = "0x20052F1")]
	public class RoguelikeInitProcessState : PopupFadeState, RoguelikeInitContextUser, IHotfixable
	{
		// Token: 0x0601F50F RID: 128271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F50F")]
		[Address(RVA = "0x19090F0", Offset = "0x1907CF0", VA = "0x1819090F0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601F510 RID: 128272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F510")]
		[Address(RVA = "0x19092D0", Offset = "0x1907ED0", VA = "0x1819092D0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601F511 RID: 128273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F511")]
		[Address(RVA = "0x1909490", Offset = "0x1908090", VA = "0x181909490", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601F512 RID: 128274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F512")]
		[Address(RVA = "0x1909590", Offset = "0x1908190", VA = "0x181909590", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601F513 RID: 128275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F513")]
		[Address(RVA = "0x1909AE0", Offset = "0x19086E0", VA = "0x181909AE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601F514 RID: 128276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F514")]
		[Address(RVA = "0x1909910", Offset = "0x1908510", VA = "0x181909910")]
		private void _ExitInitProcess()
		{
		}

		// Token: 0x1700497E RID: 18814
		// (get) Token: 0x0601F515 RID: 128277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700497E")]
		public string topicId
		{
			[Token(Token = "0x601F515")]
			[Address(RVA = "0x1909EA0", Offset = "0x1908AA0", VA = "0x181909EA0", Slot = "32")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700497F RID: 18815
		// (get) Token: 0x0601F516 RID: 128278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700497F")]
		public UIPage page
		{
			[Token(Token = "0x601F516")]
			[Address(RVA = "0x1909E40", Offset = "0x1908A40", VA = "0x181909E40", Slot = "34")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601F517 RID: 128279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F517")]
		[Address(RVA = "0x1909150", Offset = "0x1907D50", VA = "0x181909150", Slot = "31")]
		public void Invalide()
		{
		}

		// Token: 0x0601F518 RID: 128280 RVA: 0x000B17C8 File Offset: 0x000AF9C8
		[Token(Token = "0x601F518")]
		public bool AddTop<T>() where T : State
		{
			return default(bool);
		}

		// Token: 0x0601F519 RID: 128281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F519")]
		[Address(RVA = "0x1909DD0", Offset = "0x19089D0", VA = "0x181909DD0")]
		public RoguelikeInitProcessState()
		{
		}

		// Token: 0x0601F51B RID: 128283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F51B")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601F51C RID: 128284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F51C")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0601F51D RID: 128285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F51D")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0402A137 RID: 172343
		[Token(Token = "0x402A137")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RoguelikeInitPanel[] _panels;

		// Token: 0x0402A138 RID: 172344
		[Token(Token = "0x402A138")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIStyleProvider _styleProvider;

		// Token: 0x0402A139 RID: 172345
		[Token(Token = "0x402A139")]
		[FieldOffset(Offset = "0x80")]
		private RoguelikeInitStyle m_style;

		// Token: 0x0402A13A RID: 172346
		[Token(Token = "0x402A13A")]
		[FieldOffset(Offset = "0x88")]
		private RoguelikeInitModelProperty m_property;

		// Token: 0x0402A13B RID: 172347
		[Token(Token = "0x402A13B")]
		[FieldOffset(Offset = "0x90")]
		private PlayerRoguelikePlayerEventType m_cachedInitPhase;

		// Token: 0x0402A13C RID: 172348
		[Token(Token = "0x402A13C")]
		[FieldOffset(Offset = "0x98")]
		private RoguelikeInitProcessState.MenuAdapter m_menuAdapter;

		// Token: 0x0402A13D RID: 172349
		[Token(Token = "0x402A13D")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_showStatusBar;

		// Token: 0x0402A13E RID: 172350
		[Token(Token = "0x402A13E")]
		[FieldOffset(Offset = "0xA1")]
		private bool m_showBottomBar;

		// Token: 0x0402A13F RID: 172351
		[Token(Token = "0x402A13F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402A140 RID: 172352
		[Token(Token = "0x402A140")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402A141 RID: 172353
		[Token(Token = "0x402A141")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402A142 RID: 172354
		[Token(Token = "0x402A142")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0402A143 RID: 172355
		[Token(Token = "0x402A143")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402A144 RID: 172356
		[Token(Token = "0x402A144")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ExitInitProcess;

		// Token: 0x0402A145 RID: 172357
		[Token(Token = "0x402A145")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x0402A146 RID: 172358
		[Token(Token = "0x402A146")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x0402A147 RID: 172359
		[Token(Token = "0x402A147")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Invalide;

		// Token: 0x0402A148 RID: 172360
		[Token(Token = "0x402A148")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_AddTop;

		// Token: 0x0402A149 RID: 172361
		[Token(Token = "0x402A149")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020052F2 RID: 21234
		[Token(Token = "0x20052F2")]
		private class MenuAdapter : RoguelikeMenuAdapter
		{
			// Token: 0x0601F51E RID: 128286 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F51E")]
			[Address(RVA = "0x18F33D0", Offset = "0x18F1FD0", VA = "0x1818F33D0")]
			public MenuAdapter(RoguelikeInitProcessState closure)
			{
			}

			// Token: 0x17004980 RID: 18816
			// (get) Token: 0x0601F51F RID: 128287 RVA: 0x000B17E0 File Offset: 0x000AF9E0
			[Token(Token = "0x17004980")]
			public override bool showStatusBar
			{
				[Token(Token = "0x601F51F")]
				[Address(RVA = "0x18F3580", Offset = "0x18F2180", VA = "0x1818F3580", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17004981 RID: 18817
			// (get) Token: 0x0601F520 RID: 128288 RVA: 0x000B17F8 File Offset: 0x000AF9F8
			[Token(Token = "0x17004981")]
			public override bool showBottomBar
			{
				[Token(Token = "0x601F520")]
				[Address(RVA = "0x18F3450", Offset = "0x18F2050", VA = "0x1818F3450", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0601F521 RID: 128289 RVA: 0x000B1810 File Offset: 0x000AFA10
			[Token(Token = "0x601F521")]
			[Address(RVA = "0x189EFF0", Offset = "0x189DBF0", VA = "0x18189EFF0")]
			private bool <>xLuaBaseProxy_get_showStatusBar()
			{
				return default(bool);
			}

			// Token: 0x0601F522 RID: 128290 RVA: 0x000B1828 File Offset: 0x000AFA28
			[Token(Token = "0x601F522")]
			[Address(RVA = "0x189EFE0", Offset = "0x189DBE0", VA = "0x18189EFE0")]
			private bool <>xLuaBaseProxy_get_showBottomBar()
			{
				return default(bool);
			}

			// Token: 0x0402A14A RID: 172362
			[Token(Token = "0x402A14A")]
			[FieldOffset(Offset = "0x20")]
			private RoguelikeInitProcessState m_closure;

			// Token: 0x0402A14B RID: 172363
			[Token(Token = "0x402A14B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402A14C RID: 172364
			[Token(Token = "0x402A14C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_showStatusBar;

			// Token: 0x0402A14D RID: 172365
			[Token(Token = "0x402A14D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_showBottomBar;
		}
	}
}
