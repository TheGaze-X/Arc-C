using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055C3 RID: 21955
	[Token(Token = "0x20055C3")]
	public class RL05PendingCommonDialogModule : RoguelikeDungeonModule
	{
		// Token: 0x0602039C RID: 131996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602039C")]
		[Address(RVA = "0x1A561B0", Offset = "0x1A54DB0", VA = "0x181A561B0", Slot = "4")]
		protected override void OnCreate()
		{
		}

		// Token: 0x0602039D RID: 131997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602039D")]
		[Address(RVA = "0x1A562F0", Offset = "0x1A54EF0", VA = "0x181A562F0")]
		private void _LoadParam(object args)
		{
		}

		// Token: 0x0602039E RID: 131998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602039E")]
		[Address(RVA = "0x1A565B0", Offset = "0x1A551B0", VA = "0x181A565B0")]
		public RL05PendingCommonDialogModule()
		{
		}

		// Token: 0x0602039F RID: 131999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602039F")]
		[Address(RVA = "0x1A4A420", Offset = "0x1A49020", VA = "0x181A4A420")]
		private void <>xLuaBaseProxy_OnCreate()
		{
		}

		// Token: 0x0402B981 RID: 178561
		[Token(Token = "0x402B981")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0402B982 RID: 178562
		[Token(Token = "0x402B982")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadParam;

		// Token: 0x0402B983 RID: 178563
		[Token(Token = "0x402B983")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020055C4 RID: 21956
		[Token(Token = "0x20055C4")]
		private class MenuAdapter : RoguelikeMenuAdapter
		{
			// Token: 0x17004B8B RID: 19339
			// (get) Token: 0x060203A0 RID: 132000 RVA: 0x000B4F48 File Offset: 0x000B3148
			[Token(Token = "0x17004B8B")]
			public override bool showStatusBar
			{
				[Token(Token = "0x60203A0")]
				[Address(RVA = "0x1A495F0", Offset = "0x1A481F0", VA = "0x181A495F0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17004B8C RID: 19340
			// (get) Token: 0x060203A1 RID: 132001 RVA: 0x000B4F60 File Offset: 0x000B3160
			[Token(Token = "0x17004B8C")]
			public override bool showBottomBar
			{
				[Token(Token = "0x60203A1")]
				[Address(RVA = "0x1A49590", Offset = "0x1A48190", VA = "0x181A49590", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060203A2 RID: 132002 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60203A2")]
			[Address(RVA = "0x1A49530", Offset = "0x1A48130", VA = "0x181A49530")]
			public MenuAdapter()
			{
			}

			// Token: 0x060203A3 RID: 132003 RVA: 0x000B4F78 File Offset: 0x000B3178
			[Token(Token = "0x60203A3")]
			[Address(RVA = "0x189EFF0", Offset = "0x189DBF0", VA = "0x18189EFF0")]
			private bool <>xLuaBaseProxy_get_showStatusBar()
			{
				return default(bool);
			}

			// Token: 0x060203A4 RID: 132004 RVA: 0x000B4F90 File Offset: 0x000B3190
			[Token(Token = "0x60203A4")]
			[Address(RVA = "0x189EFE0", Offset = "0x189DBE0", VA = "0x18189EFE0")]
			private bool <>xLuaBaseProxy_get_showBottomBar()
			{
				return default(bool);
			}

			// Token: 0x0402B984 RID: 178564
			[Token(Token = "0x402B984")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_showStatusBar;

			// Token: 0x0402B985 RID: 178565
			[Token(Token = "0x402B985")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_showBottomBar;

			// Token: 0x0402B986 RID: 178566
			[Token(Token = "0x402B986")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
