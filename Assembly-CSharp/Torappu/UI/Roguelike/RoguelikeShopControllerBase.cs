using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054F6 RID: 21750
	[Token(Token = "0x20054F6")]
	public abstract class RoguelikeShopControllerBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004B04 RID: 19204
		// (get) Token: 0x0601FFE9 RID: 131049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004B04")]
		protected UIPage page
		{
			[Token(Token = "0x601FFE9")]
			[Address(RVA = "0x1A1F6D0", Offset = "0x1A1E2D0", VA = "0x181A1F6D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004B05 RID: 19205
		// (get) Token: 0x0601FFEA RID: 131050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004B05")]
		protected IStateEngine stateEngine
		{
			[Token(Token = "0x601FFEA")]
			[Address(RVA = "0x1A1F7F0", Offset = "0x1A1E3F0", VA = "0x181A1F7F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004B06 RID: 19206
		// (get) Token: 0x0601FFEB RID: 131051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004B06")]
		protected RoguelikeShopStateBean stateBean
		{
			[Token(Token = "0x601FFEB")]
			[Address(RVA = "0x1A1F790", Offset = "0x1A1E390", VA = "0x181A1F790")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004B07 RID: 19207
		// (get) Token: 0x0601FFEC RID: 131052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004B07")]
		protected RoguelikeDungeonController dungeonController
		{
			[Token(Token = "0x601FFEC")]
			[Address(RVA = "0x1A1F670", Offset = "0x1A1E270", VA = "0x181A1F670")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004B08 RID: 19208
		// (get) Token: 0x0601FFED RID: 131053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004B08")]
		protected RoguelikeShopPlugin shopPlugin
		{
			[Token(Token = "0x601FFED")]
			[Address(RVA = "0x1A1F730", Offset = "0x1A1E330", VA = "0x181A1F730")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601FFEE RID: 131054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFEE")]
		[Address(RVA = "0x1A1F120", Offset = "0x1A1DD20", VA = "0x181A1F120", Slot = "4")]
		public virtual void OnEnter(RoguelikeShopControllerBase.Builder builder)
		{
		}

		// Token: 0x0601FFEF RID: 131055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFEF")]
		[Address(RVA = "0x1A1F480", Offset = "0x1A1E080", VA = "0x181A1F480", Slot = "5")]
		public virtual void OnResume(bool isResumedFromStack)
		{
		}

		// Token: 0x0601FFF0 RID: 131056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFF0")]
		[Address(RVA = "0x1A1F420", Offset = "0x1A1E020", VA = "0x181A1F420", Slot = "6")]
		public virtual void OnExit()
		{
		}

		// Token: 0x0601FFF1 RID: 131057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FFF1")]
		[Address(RVA = "0x1A1F090", Offset = "0x1A1DC90", VA = "0x181A1F090", Slot = "7")]
		public virtual IEnumerator HideCoroutine()
		{
			return null;
		}

		// Token: 0x0601FFF2 RID: 131058 RVA: 0x000B4228 File Offset: 0x000B2428
		[Token(Token = "0x601FFF2")]
		protected bool _EnsureStateEngineFrontStateStable<T>() where T : State
		{
			return default(bool);
		}

		// Token: 0x0601FFF3 RID: 131059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFF3")]
		[Address(RVA = "0x1A1F4E0", Offset = "0x1A1E0E0", VA = "0x181A1F4E0")]
		private void _RegisterMenuAdapter(RoguelikeDungeonController controller)
		{
		}

		// Token: 0x0601FFF4 RID: 131060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFF4")]
		[Address(RVA = "0x1A1F610", Offset = "0x1A1E210", VA = "0x181A1F610")]
		protected RoguelikeShopControllerBase()
		{
		}

		// Token: 0x0402B2DE RID: 176862
		[Token(Token = "0x402B2DE")]
		[FieldOffset(Offset = "0x18")]
		private string m_topicId;

		// Token: 0x0402B2DF RID: 176863
		[Token(Token = "0x402B2DF")]
		[FieldOffset(Offset = "0x20")]
		private UIPage m_page;

		// Token: 0x0402B2E0 RID: 176864
		[Token(Token = "0x402B2E0")]
		[FieldOffset(Offset = "0x28")]
		private IStateEngine m_engine;

		// Token: 0x0402B2E1 RID: 176865
		[Token(Token = "0x402B2E1")]
		[FieldOffset(Offset = "0x30")]
		private RoguelikeShopStateBean m_stateBean;

		// Token: 0x0402B2E2 RID: 176866
		[Token(Token = "0x402B2E2")]
		[FieldOffset(Offset = "0x38")]
		private RoguelikeDungeonController m_dungeonController;

		// Token: 0x0402B2E3 RID: 176867
		[Token(Token = "0x402B2E3")]
		[FieldOffset(Offset = "0x40")]
		private RoguelikeShopControllerBase.MenuAdapter m_menuAdapter;

		// Token: 0x0402B2E4 RID: 176868
		[Token(Token = "0x402B2E4")]
		[FieldOffset(Offset = "0x48")]
		private RoguelikeShopPlugin m_shopPlugin;

		// Token: 0x0402B2E5 RID: 176869
		[Token(Token = "0x402B2E5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x0402B2E6 RID: 176870
		[Token(Token = "0x402B2E6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_stateEngine;

		// Token: 0x0402B2E7 RID: 176871
		[Token(Token = "0x402B2E7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_stateBean;

		// Token: 0x0402B2E8 RID: 176872
		[Token(Token = "0x402B2E8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_dungeonController;

		// Token: 0x0402B2E9 RID: 176873
		[Token(Token = "0x402B2E9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_shopPlugin;

		// Token: 0x0402B2EA RID: 176874
		[Token(Token = "0x402B2EA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402B2EB RID: 176875
		[Token(Token = "0x402B2EB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402B2EC RID: 176876
		[Token(Token = "0x402B2EC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0402B2ED RID: 176877
		[Token(Token = "0x402B2ED")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0402B2EE RID: 176878
		[Token(Token = "0x402B2EE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__EnsureStateEngineFrontStateStable;

		// Token: 0x0402B2EF RID: 176879
		[Token(Token = "0x402B2EF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RegisterMenuAdapter;

		// Token: 0x0402B2F0 RID: 176880
		[Token(Token = "0x402B2F0")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020054F7 RID: 21751
		[Token(Token = "0x20054F7")]
		private class MenuAdapter : RoguelikeMenuAdapter
		{
			// Token: 0x17004B09 RID: 19209
			// (get) Token: 0x0601FFF5 RID: 131061 RVA: 0x000B4240 File Offset: 0x000B2440
			[Token(Token = "0x17004B09")]
			public override bool showStatusBar
			{
				[Token(Token = "0x601FFF5")]
				[Address(RVA = "0x1A16750", Offset = "0x1A15350", VA = "0x181A16750", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17004B0A RID: 19210
			// (get) Token: 0x0601FFF6 RID: 131062 RVA: 0x000B4258 File Offset: 0x000B2458
			[Token(Token = "0x17004B0A")]
			public override bool showBottomBar
			{
				[Token(Token = "0x601FFF6")]
				[Address(RVA = "0x1A166F0", Offset = "0x1A152F0", VA = "0x181A166F0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0601FFF7 RID: 131063 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FFF7")]
			[Address(RVA = "0x1A16690", Offset = "0x1A15290", VA = "0x181A16690")]
			public MenuAdapter()
			{
			}

			// Token: 0x0601FFF8 RID: 131064 RVA: 0x000B4270 File Offset: 0x000B2470
			[Token(Token = "0x601FFF8")]
			[Address(RVA = "0x189EFF0", Offset = "0x189DBF0", VA = "0x18189EFF0")]
			private bool <>xLuaBaseProxy_get_showStatusBar()
			{
				return default(bool);
			}

			// Token: 0x0601FFF9 RID: 131065 RVA: 0x000B4288 File Offset: 0x000B2488
			[Token(Token = "0x601FFF9")]
			[Address(RVA = "0x189EFE0", Offset = "0x189DBE0", VA = "0x18189EFE0")]
			private bool <>xLuaBaseProxy_get_showBottomBar()
			{
				return default(bool);
			}

			// Token: 0x0402B2F1 RID: 176881
			[Token(Token = "0x402B2F1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_showStatusBar;

			// Token: 0x0402B2F2 RID: 176882
			[Token(Token = "0x402B2F2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_showBottomBar;

			// Token: 0x0402B2F3 RID: 176883
			[Token(Token = "0x402B2F3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020054F8 RID: 21752
		[Token(Token = "0x20054F8")]
		public struct Builder
		{
			// Token: 0x0402B2F4 RID: 176884
			[Token(Token = "0x402B2F4")]
			[FieldOffset(Offset = "0x0")]
			public string topicId;

			// Token: 0x0402B2F5 RID: 176885
			[Token(Token = "0x402B2F5")]
			[FieldOffset(Offset = "0x8")]
			public UIPage page;

			// Token: 0x0402B2F6 RID: 176886
			[Token(Token = "0x402B2F6")]
			[FieldOffset(Offset = "0x10")]
			public IStateEngine engine;

			// Token: 0x0402B2F7 RID: 176887
			[Token(Token = "0x402B2F7")]
			[FieldOffset(Offset = "0x18")]
			public RoguelikeShopStateBean stateBean;

			// Token: 0x0402B2F8 RID: 176888
			[Token(Token = "0x402B2F8")]
			[FieldOffset(Offset = "0x20")]
			public RoguelikeShopPlugin shopPlugin;
		}
	}
}
