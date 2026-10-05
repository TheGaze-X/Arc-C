using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003364 RID: 13156
	[Token(Token = "0x2003364")]
	public class UIHudEnemySpSlider : UITextSlider, HudPlugin, IHotfixable
	{
		// Token: 0x170031DE RID: 12766
		// (get) Token: 0x06014FEE RID: 85998 RVA: 0x0008A030 File Offset: 0x00088230
		[Token(Token = "0x170031DE")]
		public HudPluginMask hudMask
		{
			[Token(Token = "0x6014FEE")]
			[Address(RVA = "0xD75DA0", Offset = "0xD749A0", VA = "0x180D75DA0", Slot = "6")]
			get
			{
				return HudPluginMask.NONE;
			}
		}

		// Token: 0x170031DF RID: 12767
		// (get) Token: 0x06014FEF RID: 85999 RVA: 0x0008A048 File Offset: 0x00088248
		[Token(Token = "0x170031DF")]
		public bool needToShow
		{
			[Token(Token = "0x6014FEF")]
			[Address(RVA = "0xD75E00", Offset = "0xD74A00", VA = "0x180D75E00", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014FF0 RID: 86000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FF0")]
		[Address(RVA = "0xD75AA0", Offset = "0xD746A0", VA = "0x180D75AA0", Slot = "8")]
		public void OnAttach(Unit owner)
		{
		}

		// Token: 0x06014FF1 RID: 86001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FF1")]
		[Address(RVA = "0xD75BF0", Offset = "0xD747F0", VA = "0x180D75BF0", Slot = "9")]
		public void OnDetach()
		{
		}

		// Token: 0x06014FF2 RID: 86002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FF2")]
		[Address(RVA = "0xD75C50", Offset = "0xD74850", VA = "0x180D75C50", Slot = "10")]
		public void UpdatePlugin()
		{
		}

		// Token: 0x06014FF3 RID: 86003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FF3")]
		[Address(RVA = "0xD75D40", Offset = "0xD74940", VA = "0x180D75D40")]
		public UIHudEnemySpSlider()
		{
		}

		// Token: 0x04018F9A RID: 102298
		[Token(Token = "0x4018F9A")]
		[FieldOffset(Offset = "0x38")]
		private Enemy m_enemy;

		// Token: 0x04018F9B RID: 102299
		[Token(Token = "0x4018F9B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hudMask;

		// Token: 0x04018F9C RID: 102300
		[Token(Token = "0x4018F9C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_needToShow;

		// Token: 0x04018F9D RID: 102301
		[Token(Token = "0x4018F9D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnAttach;

		// Token: 0x04018F9E RID: 102302
		[Token(Token = "0x4018F9E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDetach;

		// Token: 0x04018F9F RID: 102303
		[Token(Token = "0x4018F9F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdatePlugin;

		// Token: 0x04018FA0 RID: 102304
		[Token(Token = "0x4018FA0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
