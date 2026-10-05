using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005361 RID: 21345
	[Token(Token = "0x2005361")]
	public class RoguelikeModuleDialogState : UIPopupState, ICompDialogCallBack
	{
		// Token: 0x0601F763 RID: 128867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F763")]
		[Address(RVA = "0x192E4F0", Offset = "0x192D0F0", VA = "0x18192E4F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601F764 RID: 128868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F764")]
		[Address(RVA = "0x192DA50", Offset = "0x192C650", VA = "0x18192DA50", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601F765 RID: 128869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F765")]
		[Address(RVA = "0x192DAB0", Offset = "0x192C6B0", VA = "0x18192DAB0", Slot = "29")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x0601F766 RID: 128870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F766")]
		[Address(RVA = "0x192DDC0", Offset = "0x192C9C0", VA = "0x18192DDC0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601F767 RID: 128871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F767")]
		[Address(RVA = "0x192E250", Offset = "0x192CE50", VA = "0x18192E250", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601F768 RID: 128872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F768")]
		[Address(RVA = "0x192E1C0", Offset = "0x192CDC0", VA = "0x18192E1C0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0601F769 RID: 128873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F769")]
		[Address(RVA = "0x192E2E0", Offset = "0x192CEE0", VA = "0x18192E2E0", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0601F76A RID: 128874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F76A")]
		[Address(RVA = "0x192DBC0", Offset = "0x192C7C0", VA = "0x18192DBC0", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0601F76B RID: 128875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F76B")]
		[Address(RVA = "0x192E420", Offset = "0x192D020", VA = "0x18192E420", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0601F76C RID: 128876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F76C")]
		[Address(RVA = "0x192DCF0", Offset = "0x192C8F0", VA = "0x18192DCF0", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0601F76D RID: 128877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F76D")]
		[Address(RVA = "0x192E6D0", Offset = "0x192D2D0", VA = "0x18192E6D0")]
		public RoguelikeModuleDialogState()
		{
		}

		// Token: 0x0601F76E RID: 128878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F76E")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601F76F RID: 128879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F76F")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0601F770 RID: 128880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F770")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0402A54A RID: 173386
		[Token(Token = "0x402A54A")]
		private const float SHOW_TWEEN_DELAY = 0.05f;

		// Token: 0x0402A54B RID: 173387
		[Token(Token = "0x402A54B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x0402A54C RID: 173388
		[Token(Token = "0x402A54C")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isInited;

		// Token: 0x0402A54D RID: 173389
		[Token(Token = "0x402A54D")]
		[FieldOffset(Offset = "0x70")]
		private UICompDialogMgr m_dialogMgr;

		// Token: 0x0402A54E RID: 173390
		[Token(Token = "0x402A54E")]
		[FieldOffset(Offset = "0x78")]
		private RoguelikeModuleDialogController.IRoguelikeModuleDialogHandler m_dialogHandler;

		// Token: 0x0402A54F RID: 173391
		[Token(Token = "0x402A54F")]
		[FieldOffset(Offset = "0x80")]
		private RoguelikeModuleDialogState.MenuAdapter m_menuAdapter;

		// Token: 0x0402A550 RID: 173392
		[Token(Token = "0x402A550")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402A551 RID: 173393
		[Token(Token = "0x402A551")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402A552 RID: 173394
		[Token(Token = "0x402A552")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x0402A553 RID: 173395
		[Token(Token = "0x402A553")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402A554 RID: 173396
		[Token(Token = "0x402A554")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402A555 RID: 173397
		[Token(Token = "0x402A555")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0402A556 RID: 173398
		[Token(Token = "0x402A556")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0402A557 RID: 173399
		[Token(Token = "0x402A557")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0402A558 RID: 173400
		[Token(Token = "0x402A558")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x0402A559 RID: 173401
		[Token(Token = "0x402A559")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x0402A55A RID: 173402
		[Token(Token = "0x402A55A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005362 RID: 21346
		[Token(Token = "0x2005362")]
		private class MenuAdapter : RoguelikeMenuAdapter
		{
			// Token: 0x0601F771 RID: 128881 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F771")]
			[Address(RVA = "0x1921620", Offset = "0x1920220", VA = "0x181921620")]
			public MenuAdapter(RoguelikeModuleDialogState closure)
			{
			}

			// Token: 0x170049CA RID: 18890
			// (get) Token: 0x0601F772 RID: 128882 RVA: 0x000B2050 File Offset: 0x000B0250
			[Token(Token = "0x170049CA")]
			public override bool showBottomBar
			{
				[Token(Token = "0x601F772")]
				[Address(RVA = "0x1921740", Offset = "0x1920340", VA = "0x181921740", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170049CB RID: 18891
			// (get) Token: 0x0601F773 RID: 128883 RVA: 0x000B2068 File Offset: 0x000B0268
			[Token(Token = "0x170049CB")]
			public override bool showStatusBar
			{
				[Token(Token = "0x601F773")]
				[Address(RVA = "0x19217D0", Offset = "0x19203D0", VA = "0x1819217D0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170049CC RID: 18892
			// (get) Token: 0x0601F774 RID: 128884 RVA: 0x000B2080 File Offset: 0x000B0280
			[Token(Token = "0x170049CC")]
			public override RoguelikeMenuCharObjectStatus charMenuObjectStatus
			{
				[Token(Token = "0x601F774")]
				[Address(RVA = "0x19216E0", Offset = "0x19202E0", VA = "0x1819216E0", Slot = "8")]
				get
				{
					return RoguelikeMenuCharObjectStatus.HIDE;
				}
			}

			// Token: 0x170049CD RID: 18893
			// (get) Token: 0x0601F775 RID: 128885 RVA: 0x000B2098 File Offset: 0x000B0298
			[Token(Token = "0x170049CD")]
			public override RoguelikeMenuSquadObjectStatus squadMenuObjectStatus
			{
				[Token(Token = "0x601F775")]
				[Address(RVA = "0x1921870", Offset = "0x1920470", VA = "0x181921870", Slot = "9")]
				get
				{
					return RoguelikeMenuSquadObjectStatus.NORMAL;
				}
			}

			// Token: 0x0601F776 RID: 128886 RVA: 0x000B20B0 File Offset: 0x000B02B0
			[Token(Token = "0x601F776")]
			[Address(RVA = "0x1921500", Offset = "0x1920100", VA = "0x181921500")]
			private bool <>xLuaBaseProxy_get_showBottomBar()
			{
				return default(bool);
			}

			// Token: 0x0601F777 RID: 128887 RVA: 0x000B20C8 File Offset: 0x000B02C8
			[Token(Token = "0x601F777")]
			[Address(RVA = "0x1921560", Offset = "0x1920160", VA = "0x181921560")]
			private bool <>xLuaBaseProxy_get_showStatusBar()
			{
				return default(bool);
			}

			// Token: 0x0601F778 RID: 128888 RVA: 0x000B20E0 File Offset: 0x000B02E0
			[Token(Token = "0x601F778")]
			[Address(RVA = "0x19214A0", Offset = "0x19200A0", VA = "0x1819214A0")]
			private RoguelikeMenuCharObjectStatus <>xLuaBaseProxy_get_charMenuObjectStatus()
			{
				return RoguelikeMenuCharObjectStatus.HIDE;
			}

			// Token: 0x0601F779 RID: 128889 RVA: 0x000B20F8 File Offset: 0x000B02F8
			[Token(Token = "0x601F779")]
			[Address(RVA = "0x19215C0", Offset = "0x19201C0", VA = "0x1819215C0")]
			private RoguelikeMenuSquadObjectStatus <>xLuaBaseProxy_get_squadMenuObjectStatus()
			{
				return RoguelikeMenuSquadObjectStatus.NORMAL;
			}

			// Token: 0x0402A55B RID: 173403
			[Token(Token = "0x402A55B")]
			[FieldOffset(Offset = "0x20")]
			private RoguelikeModuleDialogState m_closure;

			// Token: 0x0402A55C RID: 173404
			[Token(Token = "0x402A55C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402A55D RID: 173405
			[Token(Token = "0x402A55D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_showBottomBar;

			// Token: 0x0402A55E RID: 173406
			[Token(Token = "0x402A55E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_showStatusBar;

			// Token: 0x0402A55F RID: 173407
			[Token(Token = "0x402A55F")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_charMenuObjectStatus;

			// Token: 0x0402A560 RID: 173408
			[Token(Token = "0x402A560")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_squadMenuObjectStatus;
		}
	}
}
