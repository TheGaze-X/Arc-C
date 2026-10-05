using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x0200335B RID: 13147
	[Token(Token = "0x200335B")]
	public class UIHudCharOverloadBulletBar : UIBulletBar, HudPlugin, IHotfixable
	{
		// Token: 0x170031CC RID: 12748
		// (get) Token: 0x06014FB0 RID: 85936 RVA: 0x00089E50 File Offset: 0x00088050
		[Token(Token = "0x170031CC")]
		public HudPluginMask hudMask
		{
			[Token(Token = "0x6014FB0")]
			[Address(RVA = "0xD5CD00", Offset = "0xD5B900", VA = "0x180D5CD00", Slot = "4")]
			get
			{
				return HudPluginMask.NONE;
			}
		}

		// Token: 0x170031CD RID: 12749
		// (get) Token: 0x06014FB1 RID: 85937 RVA: 0x00089E68 File Offset: 0x00088068
		[Token(Token = "0x170031CD")]
		public bool needToShow
		{
			[Token(Token = "0x6014FB1")]
			[Address(RVA = "0xD5CD60", Offset = "0xD5B960", VA = "0x180D5CD60", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014FB2 RID: 85938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FB2")]
		[Address(RVA = "0xD5C840", Offset = "0xD5B440", VA = "0x180D5C840", Slot = "6")]
		public void OnAttach(Unit owner)
		{
		}

		// Token: 0x06014FB3 RID: 85939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FB3")]
		[Address(RVA = "0xD5CAC0", Offset = "0xD5B6C0", VA = "0x180D5CAC0", Slot = "7")]
		public void OnDetach()
		{
		}

		// Token: 0x06014FB4 RID: 85940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FB4")]
		[Address(RVA = "0xD5CB20", Offset = "0xD5B720", VA = "0x180D5CB20", Slot = "8")]
		public void UpdatePlugin()
		{
		}

		// Token: 0x06014FB5 RID: 85941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FB5")]
		[Address(RVA = "0xD5CCA0", Offset = "0xD5B8A0", VA = "0x180D5CCA0")]
		public UIHudCharOverloadBulletBar()
		{
		}

		// Token: 0x04018F48 RID: 102216
		[Token(Token = "0x4018F48")]
		[FieldOffset(Offset = "0x38")]
		private Character m_char;

		// Token: 0x04018F49 RID: 102217
		[Token(Token = "0x4018F49")]
		[FieldOffset(Offset = "0x40")]
		private CastSkillWithLimitTimes m_skill;

		// Token: 0x04018F4A RID: 102218
		[Token(Token = "0x4018F4A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hudMask;

		// Token: 0x04018F4B RID: 102219
		[Token(Token = "0x4018F4B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_needToShow;

		// Token: 0x04018F4C RID: 102220
		[Token(Token = "0x4018F4C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnAttach;

		// Token: 0x04018F4D RID: 102221
		[Token(Token = "0x4018F4D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDetach;

		// Token: 0x04018F4E RID: 102222
		[Token(Token = "0x4018F4E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdatePlugin;

		// Token: 0x04018F4F RID: 102223
		[Token(Token = "0x4018F4F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
