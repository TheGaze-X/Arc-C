using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.TotemBuff
{
	// Token: 0x02005563 RID: 21859
	[Token(Token = "0x2005563")]
	public class RoguelikeTotemBuffState : PopupFadeState
	{
		// Token: 0x0602020D RID: 131597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602020D")]
		[Address(RVA = "0x1A45520", Offset = "0x1A44120", VA = "0x181A45520", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602020E RID: 131598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602020E")]
		[Address(RVA = "0x1A45580", Offset = "0x1A44180", VA = "0x181A45580", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602020F RID: 131599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602020F")]
		[Address(RVA = "0x1A45A60", Offset = "0x1A44660", VA = "0x181A45A60", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06020210 RID: 131600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020210")]
		[Address(RVA = "0x1A45330", Offset = "0x1A43F30", VA = "0x181A45330")]
		public void DismissSelfWithFastMode()
		{
		}

		// Token: 0x06020211 RID: 131601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020211")]
		[Address(RVA = "0x1A45B40", Offset = "0x1A44740", VA = "0x181A45B40")]
		public void ReloadDungeon()
		{
		}

		// Token: 0x06020212 RID: 131602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020212")]
		[Address(RVA = "0x1A45CB0", Offset = "0x1A448B0", VA = "0x181A45CB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020213 RID: 131603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020213")]
		[Address(RVA = "0x1A45E20", Offset = "0x1A44A20", VA = "0x181A45E20")]
		public RoguelikeTotemBuffState()
		{
		}

		// Token: 0x06020214 RID: 131604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020214")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06020215 RID: 131605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020215")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0402B667 RID: 177767
		[Token(Token = "0x402B667")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _viewContainer;

		// Token: 0x0402B668 RID: 177768
		[Token(Token = "0x402B668")]
		[FieldOffset(Offset = "0x78")]
		private bool m_hasInited;

		// Token: 0x0402B669 RID: 177769
		[Token(Token = "0x402B669")]
		[FieldOffset(Offset = "0x80")]
		private RoguelikeDungeonPage m_page;

		// Token: 0x0402B66A RID: 177770
		[Token(Token = "0x402B66A")]
		[FieldOffset(Offset = "0x88")]
		private string m_topicId;

		// Token: 0x0402B66B RID: 177771
		[Token(Token = "0x402B66B")]
		[FieldOffset(Offset = "0x90")]
		private AbstractRoguelikeTotemBuffView m_totemBuffView;

		// Token: 0x0402B66C RID: 177772
		[Token(Token = "0x402B66C")]
		[FieldOffset(Offset = "0x98")]
		private IRoguelikeTotemBuffViewModel m_totemViewModel;

		// Token: 0x0402B66D RID: 177773
		[Token(Token = "0x402B66D")]
		[FieldOffset(Offset = "0xA0")]
		private RoguelikeTotemBuffState.MenuAdapter m_menuAdapter;

		// Token: 0x0402B66E RID: 177774
		[Token(Token = "0x402B66E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402B66F RID: 177775
		[Token(Token = "0x402B66F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402B670 RID: 177776
		[Token(Token = "0x402B670")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402B671 RID: 177777
		[Token(Token = "0x402B671")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DismissSelfWithFastMode;

		// Token: 0x0402B672 RID: 177778
		[Token(Token = "0x402B672")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ReloadDungeon;

		// Token: 0x0402B673 RID: 177779
		[Token(Token = "0x402B673")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402B674 RID: 177780
		[Token(Token = "0x402B674")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005564 RID: 21860
		[Token(Token = "0x2005564")]
		private class MenuAdapter : RoguelikeMenuAdapter
		{
			// Token: 0x06020216 RID: 131606 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020216")]
			[Address(RVA = "0x1A31000", Offset = "0x1A2FC00", VA = "0x181A31000")]
			public MenuAdapter(RoguelikeTotemBuffState closure)
			{
			}

			// Token: 0x17004B64 RID: 19300
			// (get) Token: 0x06020217 RID: 131607 RVA: 0x000B4AF8 File Offset: 0x000B2CF8
			[Token(Token = "0x17004B64")]
			public override bool showBottomBar
			{
				[Token(Token = "0x6020217")]
				[Address(RVA = "0x1A31140", Offset = "0x1A2FD40", VA = "0x181A31140", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17004B65 RID: 19301
			// (get) Token: 0x06020218 RID: 131608 RVA: 0x000B4B10 File Offset: 0x000B2D10
			[Token(Token = "0x17004B65")]
			public override bool showStatusBar
			{
				[Token(Token = "0x6020218")]
				[Address(RVA = "0x1A31360", Offset = "0x1A2FF60", VA = "0x181A31360", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17004B66 RID: 19302
			// (get) Token: 0x06020219 RID: 131609 RVA: 0x000B4B28 File Offset: 0x000B2D28
			[Token(Token = "0x17004B66")]
			public override RoguelikeMenuCharObjectStatus charMenuObjectStatus
			{
				[Token(Token = "0x6020219")]
				[Address(RVA = "0x1A310E0", Offset = "0x1A2FCE0", VA = "0x181A310E0", Slot = "8")]
				get
				{
					return RoguelikeMenuCharObjectStatus.HIDE;
				}
			}

			// Token: 0x17004B67 RID: 19303
			// (get) Token: 0x0602021A RID: 131610 RVA: 0x000B4B40 File Offset: 0x000B2D40
			[Token(Token = "0x17004B67")]
			public override RoguelikeMenuSquadObjectStatus squadMenuObjectStatus
			{
				[Token(Token = "0x602021A")]
				[Address(RVA = "0x1A313C0", Offset = "0x1A2FFC0", VA = "0x181A313C0", Slot = "9")]
				get
				{
					return RoguelikeMenuSquadObjectStatus.NORMAL;
				}
			}

			// Token: 0x17004B68 RID: 19304
			// (get) Token: 0x0602021B RID: 131611 RVA: 0x000B4B58 File Offset: 0x000B2D58
			[Token(Token = "0x17004B68")]
			public override RoguelikeMenuTotemObjectStatus totemMenuObjectStatus
			{
				[Token(Token = "0x602021B")]
				[Address(RVA = "0x1A31420", Offset = "0x1A30020", VA = "0x181A31420", Slot = "10")]
				get
				{
					return RoguelikeMenuTotemObjectStatus.NORMAL;
				}
			}

			// Token: 0x0602021C RID: 131612 RVA: 0x000B4B70 File Offset: 0x000B2D70
			[Token(Token = "0x602021C")]
			[Address(RVA = "0x189EFE0", Offset = "0x189DBE0", VA = "0x18189EFE0")]
			private bool <>xLuaBaseProxy_get_showBottomBar()
			{
				return default(bool);
			}

			// Token: 0x0602021D RID: 131613 RVA: 0x000B4B88 File Offset: 0x000B2D88
			[Token(Token = "0x602021D")]
			[Address(RVA = "0x189EFF0", Offset = "0x189DBF0", VA = "0x18189EFF0")]
			private bool <>xLuaBaseProxy_get_showStatusBar()
			{
				return default(bool);
			}

			// Token: 0x0602021E RID: 131614 RVA: 0x000B4BA0 File Offset: 0x000B2DA0
			[Token(Token = "0x602021E")]
			[Address(RVA = "0x19E6F70", Offset = "0x19E5B70", VA = "0x1819E6F70")]
			private RoguelikeMenuCharObjectStatus <>xLuaBaseProxy_get_charMenuObjectStatus()
			{
				return RoguelikeMenuCharObjectStatus.HIDE;
			}

			// Token: 0x0602021F RID: 131615 RVA: 0x000B4BB8 File Offset: 0x000B2DB8
			[Token(Token = "0x602021F")]
			[Address(RVA = "0x1A30F90", Offset = "0x1A2FB90", VA = "0x181A30F90")]
			private RoguelikeMenuSquadObjectStatus <>xLuaBaseProxy_get_squadMenuObjectStatus()
			{
				return RoguelikeMenuSquadObjectStatus.NORMAL;
			}

			// Token: 0x06020220 RID: 131616 RVA: 0x000B4BD0 File Offset: 0x000B2DD0
			[Token(Token = "0x6020220")]
			[Address(RVA = "0x18C78F0", Offset = "0x18C64F0", VA = "0x1818C78F0")]
			private RoguelikeMenuTotemObjectStatus <>xLuaBaseProxy_get_totemMenuObjectStatus()
			{
				return RoguelikeMenuTotemObjectStatus.NORMAL;
			}

			// Token: 0x0402B675 RID: 177781
			[Token(Token = "0x402B675")]
			[FieldOffset(Offset = "0x20")]
			private RoguelikeTotemBuffState m_closure;

			// Token: 0x0402B676 RID: 177782
			[Token(Token = "0x402B676")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402B677 RID: 177783
			[Token(Token = "0x402B677")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_showBottomBar;

			// Token: 0x0402B678 RID: 177784
			[Token(Token = "0x402B678")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_showStatusBar;

			// Token: 0x0402B679 RID: 177785
			[Token(Token = "0x402B679")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_charMenuObjectStatus;

			// Token: 0x0402B67A RID: 177786
			[Token(Token = "0x402B67A")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_squadMenuObjectStatus;

			// Token: 0x0402B67B RID: 177787
			[Token(Token = "0x402B67B")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_totemMenuObjectStatus;
		}
	}
}
