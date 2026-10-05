using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005229 RID: 21033
	[Token(Token = "0x2005229")]
	public class RoguelikeDungeonState : UIPopupState
	{
		// Token: 0x0601F086 RID: 127110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F086")]
		[Address(RVA = "0x18B7D40", Offset = "0x18B6940", VA = "0x1818B7D40", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601F087 RID: 127111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F087")]
		[Address(RVA = "0x18B8660", Offset = "0x18B7260", VA = "0x1818B8660", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0601F088 RID: 127112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F088")]
		[Address(RVA = "0x18B7DA0", Offset = "0x18B69A0", VA = "0x1818B7DA0", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0601F089 RID: 127113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F089")]
		[Address(RVA = "0x18B87A0", Offset = "0x18B73A0", VA = "0x1818B87A0", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0601F08A RID: 127114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F08A")]
		[Address(RVA = "0x18B7EE0", Offset = "0x18B6AE0", VA = "0x1818B7EE0", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0601F08B RID: 127115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F08B")]
		[Address(RVA = "0x18B7FD0", Offset = "0x18B6BD0", VA = "0x1818B7FD0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601F08C RID: 127116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F08C")]
		[Address(RVA = "0x18B8380", Offset = "0x18B6F80", VA = "0x1818B8380", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601F08D RID: 127117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F08D")]
		[Address(RVA = "0x18B8290", Offset = "0x18B6E90", VA = "0x1818B8290", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x0601F08E RID: 127118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F08E")]
		[Address(RVA = "0x18B8B50", Offset = "0x18B7750", VA = "0x1818B8B50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601F08F RID: 127119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F08F")]
		[Address(RVA = "0x18B8C40", Offset = "0x18B7840", VA = "0x1818B8C40")]
		private void _OpenAvailInterDialog()
		{
		}

		// Token: 0x0601F090 RID: 127120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F090")]
		[Address(RVA = "0x18B8890", Offset = "0x18B7490", VA = "0x1818B8890")]
		private void _ConsumeDungeonGuideAutoShow()
		{
		}

		// Token: 0x0601F091 RID: 127121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F091")]
		[Address(RVA = "0x18B8FF0", Offset = "0x18B7BF0", VA = "0x1818B8FF0")]
		private IEnumerator _ShowTransitionCoro(RoguelikeDungeonController controller)
		{
			return null;
		}

		// Token: 0x0601F092 RID: 127122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F092")]
		[Address(RVA = "0x18B90C0", Offset = "0x18B7CC0", VA = "0x1818B90C0")]
		private IEnumerator _TryDisplayTransition(RoguelikeDungeonController controller)
		{
			return null;
		}

		// Token: 0x0601F093 RID: 127123 RVA: 0x000B0AD8 File Offset: 0x000AECD8
		[Token(Token = "0x601F093")]
		[Address(RVA = "0x18B8A00", Offset = "0x18B7600", VA = "0x1818B8A00")]
		private RoguelikeTransitionView.TransOptions _CreateTransitionParam(RoguelikeDungeonZoneViewModel zoneModel)
		{
			return default(RoguelikeTransitionView.TransOptions);
		}

		// Token: 0x0601F094 RID: 127124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F094")]
		[Address(RVA = "0x18B8D10", Offset = "0x18B7910", VA = "0x1818B8D10")]
		private void _QuitTransition()
		{
		}

		// Token: 0x0601F095 RID: 127125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F095")]
		[Address(RVA = "0x18B9190", Offset = "0x18B7D90", VA = "0x1818B9190")]
		public RoguelikeDungeonState()
		{
		}

		// Token: 0x0601F096 RID: 127126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F096")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601F097 RID: 127127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F097")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0601F098 RID: 127128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F098")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x04029A29 RID: 170537
		[Token(Token = "0x4029A29")]
		private const string SP_DUNGEON_GUIDEBOOK_SUBSIGNAL = "{0}_sp";

		// Token: 0x04029A2A RID: 170538
		[Token(Token = "0x4029A2A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RoguelikeTransitionView _transitionView;

		// Token: 0x04029A2B RID: 170539
		[Token(Token = "0x4029A2B")]
		[FieldOffset(Offset = "0x68")]
		private bool m_inited;

		// Token: 0x04029A2C RID: 170540
		[Token(Token = "0x4029A2C")]
		[FieldOffset(Offset = "0x70")]
		private RoguelikeDungeonState.MenuAdapter m_menuAdapter;

		// Token: 0x04029A2D RID: 170541
		[Token(Token = "0x4029A2D")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isTransiting;

		// Token: 0x04029A2E RID: 170542
		[Token(Token = "0x4029A2E")]
		[FieldOffset(Offset = "0x80")]
		private RoguelikeDungeonState.TransCoroutineStruct m_transCoroutineStruct;

		// Token: 0x04029A2F RID: 170543
		[Token(Token = "0x4029A2F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04029A30 RID: 170544
		[Token(Token = "0x4029A30")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x04029A31 RID: 170545
		[Token(Token = "0x4029A31")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x04029A32 RID: 170546
		[Token(Token = "0x4029A32")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x04029A33 RID: 170547
		[Token(Token = "0x4029A33")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x04029A34 RID: 170548
		[Token(Token = "0x4029A34")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04029A35 RID: 170549
		[Token(Token = "0x4029A35")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04029A36 RID: 170550
		[Token(Token = "0x4029A36")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x04029A37 RID: 170551
		[Token(Token = "0x4029A37")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04029A38 RID: 170552
		[Token(Token = "0x4029A38")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OpenAvailInterDialog;

		// Token: 0x04029A39 RID: 170553
		[Token(Token = "0x4029A39")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ConsumeDungeonGuideAutoShow;

		// Token: 0x04029A3A RID: 170554
		[Token(Token = "0x4029A3A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ShowTransitionCoro;

		// Token: 0x04029A3B RID: 170555
		[Token(Token = "0x4029A3B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__TryDisplayTransition;

		// Token: 0x04029A3C RID: 170556
		[Token(Token = "0x4029A3C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__CreateTransitionParam;

		// Token: 0x04029A3D RID: 170557
		[Token(Token = "0x4029A3D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__QuitTransition;

		// Token: 0x04029A3E RID: 170558
		[Token(Token = "0x4029A3E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200522A RID: 21034
		[Token(Token = "0x200522A")]
		private class MenuAdapter : RoguelikeMenuAdapter
		{
			// Token: 0x0601F099 RID: 127129 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F099")]
			[Address(RVA = "0x18AEE50", Offset = "0x18ADA50", VA = "0x1818AEE50")]
			public MenuAdapter(RoguelikeDungeonState closure, RoguelikeDungeonController controller)
			{
			}

			// Token: 0x17004896 RID: 18582
			// (get) Token: 0x0601F09A RID: 127130 RVA: 0x000B0AF0 File Offset: 0x000AECF0
			[Token(Token = "0x17004896")]
			public override bool showStatusBar
			{
				[Token(Token = "0x601F09A")]
				[Address(RVA = "0x18AF120", Offset = "0x18ADD20", VA = "0x1818AF120", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17004897 RID: 18583
			// (get) Token: 0x0601F09B RID: 127131 RVA: 0x000B0B08 File Offset: 0x000AED08
			[Token(Token = "0x17004897")]
			public override bool showBottomBar
			{
				[Token(Token = "0x601F09B")]
				[Address(RVA = "0x18AEFD0", Offset = "0x18ADBD0", VA = "0x1818AEFD0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0601F09C RID: 127132 RVA: 0x000B0B20 File Offset: 0x000AED20
			[Token(Token = "0x601F09C")]
			[Address(RVA = "0x189EFF0", Offset = "0x189DBF0", VA = "0x18189EFF0")]
			private bool <>xLuaBaseProxy_get_showStatusBar()
			{
				return default(bool);
			}

			// Token: 0x0601F09D RID: 127133 RVA: 0x000B0B38 File Offset: 0x000AED38
			[Token(Token = "0x601F09D")]
			[Address(RVA = "0x189EFE0", Offset = "0x189DBE0", VA = "0x18189EFE0")]
			private bool <>xLuaBaseProxy_get_showBottomBar()
			{
				return default(bool);
			}

			// Token: 0x04029A3F RID: 170559
			[Token(Token = "0x4029A3F")]
			[FieldOffset(Offset = "0x20")]
			private RoguelikeDungeonState m_closure;

			// Token: 0x04029A40 RID: 170560
			[Token(Token = "0x4029A40")]
			[FieldOffset(Offset = "0x28")]
			private RoguelikeDungeonController m_controller;

			// Token: 0x04029A41 RID: 170561
			[Token(Token = "0x4029A41")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04029A42 RID: 170562
			[Token(Token = "0x4029A42")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_showStatusBar;

			// Token: 0x04029A43 RID: 170563
			[Token(Token = "0x4029A43")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_showBottomBar;
		}

		// Token: 0x0200522B RID: 21035
		[Token(Token = "0x200522B")]
		private struct TransCoroutineStruct : IDisposable
		{
			// Token: 0x0601F09E RID: 127134 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F09E")]
			[Address(RVA = "0x18C44F0", Offset = "0x18C30F0", VA = "0x1818C44F0")]
			public TransCoroutineStruct(RoguelikeDungeonState closure)
			{
			}

			// Token: 0x0601F09F RID: 127135 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F09F")]
			[Address(RVA = "0x18C4440", Offset = "0x18C3040", VA = "0x1818C4440")]
			private void _SetCoroutine(IEnumerator coroutine)
			{
			}

			// Token: 0x0601F0A0 RID: 127136 RVA: 0x000B0B50 File Offset: 0x000AED50
			[Token(Token = "0x601F0A0")]
			[Address(RVA = "0x18C4190", Offset = "0x18C2D90", VA = "0x1818C4190")]
			public static RoguelikeDungeonState.TransCoroutineStruct CreateTransCoroutineStruct(RoguelikeDungeonState closure, IEnumerator coroutine)
			{
				return default(RoguelikeDungeonState.TransCoroutineStruct);
			}

			// Token: 0x0601F0A1 RID: 127137 RVA: 0x000B0B68 File Offset: 0x000AED68
			[Token(Token = "0x601F0A1")]
			[Address(RVA = "0x11F7680", Offset = "0x11F6280", VA = "0x1811F7680")]
			public bool IsTransiting()
			{
				return default(bool);
			}

			// Token: 0x0601F0A2 RID: 127138 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F0A2")]
			[Address(RVA = "0x18C42F0", Offset = "0x18C2EF0", VA = "0x1818C42F0", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x04029A44 RID: 170564
			[Token(Token = "0x4029A44")]
			[FieldOffset(Offset = "0x0")]
			private Coroutine m_transitionCoroutine;

			// Token: 0x04029A45 RID: 170565
			[Token(Token = "0x4029A45")]
			[FieldOffset(Offset = "0x8")]
			private RoguelikeDungeonState m_closure;
		}
	}
}
