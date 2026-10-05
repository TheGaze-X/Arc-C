using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003362 RID: 13154
	[Token(Token = "0x2003362")]
	public class UIHudEnemyHpSlider : UIFollowHpSlider, HudPlugin, IHotfixable
	{
		// Token: 0x170031DA RID: 12762
		// (get) Token: 0x06014FE0 RID: 85984 RVA: 0x00089FD0 File Offset: 0x000881D0
		[Token(Token = "0x170031DA")]
		public HudPluginMask hudMask
		{
			[Token(Token = "0x6014FE0")]
			[Address(RVA = "0xD75600", Offset = "0xD74200", VA = "0x180D75600", Slot = "6")]
			get
			{
				return HudPluginMask.NONE;
			}
		}

		// Token: 0x170031DB RID: 12763
		// (get) Token: 0x06014FE1 RID: 85985 RVA: 0x00089FE8 File Offset: 0x000881E8
		[Token(Token = "0x170031DB")]
		public bool needToShow
		{
			[Token(Token = "0x6014FE1")]
			[Address(RVA = "0xD75660", Offset = "0xD74260", VA = "0x180D75660", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014FE2 RID: 85986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FE2")]
		[Address(RVA = "0xD74E30", Offset = "0xD73A30", VA = "0x180D74E30", Slot = "8")]
		public void OnAttach(Unit owner)
		{
		}

		// Token: 0x06014FE3 RID: 85987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FE3")]
		[Address(RVA = "0xD75050", Offset = "0xD73C50", VA = "0x180D75050", Slot = "9")]
		public void OnDetach()
		{
		}

		// Token: 0x06014FE4 RID: 85988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FE4")]
		[Address(RVA = "0xD75180", Offset = "0xD73D80", VA = "0x180D75180", Slot = "10")]
		public void UpdatePlugin()
		{
		}

		// Token: 0x06014FE5 RID: 85989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FE5")]
		[Address(RVA = "0xD75350", Offset = "0xD73F50", VA = "0x180D75350")]
		private void _OnSideSwitch(object arg)
		{
		}

		// Token: 0x06014FE6 RID: 85990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FE6")]
		[Address(RVA = "0xD753C0", Offset = "0xD73FC0", VA = "0x180D753C0")]
		private void _SetHpSliderFillColorBySide()
		{
		}

		// Token: 0x06014FE7 RID: 85991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FE7")]
		[Address(RVA = "0xD755A0", Offset = "0xD741A0", VA = "0x180D755A0")]
		public UIHudEnemyHpSlider()
		{
		}

		// Token: 0x04018F8A RID: 102282
		[Token(Token = "0x4018F8A")]
		[FieldOffset(Offset = "0x48")]
		private Enemy m_enemy;

		// Token: 0x04018F8B RID: 102283
		[Token(Token = "0x4018F8B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hudMask;

		// Token: 0x04018F8C RID: 102284
		[Token(Token = "0x4018F8C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_needToShow;

		// Token: 0x04018F8D RID: 102285
		[Token(Token = "0x4018F8D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnAttach;

		// Token: 0x04018F8E RID: 102286
		[Token(Token = "0x4018F8E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDetach;

		// Token: 0x04018F8F RID: 102287
		[Token(Token = "0x4018F8F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdatePlugin;

		// Token: 0x04018F90 RID: 102288
		[Token(Token = "0x4018F90")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnSideSwitch;

		// Token: 0x04018F91 RID: 102289
		[Token(Token = "0x4018F91")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetHpSliderFillColorBySide;

		// Token: 0x04018F92 RID: 102290
		[Token(Token = "0x4018F92")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
