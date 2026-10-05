using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003359 RID: 13145
	[Token(Token = "0x2003359")]
	public class UIHudCharHpSlider : UIFollowHpSlider, HudPlugin, IHotfixable
	{
		// Token: 0x170031C8 RID: 12744
		// (get) Token: 0x06014FA0 RID: 85920 RVA: 0x00089DF0 File Offset: 0x00087FF0
		[Token(Token = "0x170031C8")]
		public HudPluginMask hudMask
		{
			[Token(Token = "0x6014FA0")]
			[Address(RVA = "0xD5BD30", Offset = "0xD5A930", VA = "0x180D5BD30", Slot = "6")]
			get
			{
				return HudPluginMask.NONE;
			}
		}

		// Token: 0x170031C9 RID: 12745
		// (get) Token: 0x06014FA1 RID: 85921 RVA: 0x00089E08 File Offset: 0x00088008
		[Token(Token = "0x170031C9")]
		public bool needToShow
		{
			[Token(Token = "0x6014FA1")]
			[Address(RVA = "0xD5BD90", Offset = "0xD5A990", VA = "0x180D5BD90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014FA2 RID: 85922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FA2")]
		[Address(RVA = "0xD5B530", Offset = "0xD5A130", VA = "0x180D5B530", Slot = "11")]
		public virtual void OnAttach(Unit owner)
		{
		}

		// Token: 0x06014FA3 RID: 85923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FA3")]
		[Address(RVA = "0xD5B760", Offset = "0xD5A360", VA = "0x180D5B760", Slot = "9")]
		public void OnDetach()
		{
		}

		// Token: 0x06014FA4 RID: 85924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FA4")]
		[Address(RVA = "0xD5B9E0", Offset = "0xD5A5E0", VA = "0x180D5B9E0", Slot = "10")]
		public void UpdatePlugin()
		{
		}

		// Token: 0x06014FA5 RID: 85925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FA5")]
		[Address(RVA = "0xD5BC40", Offset = "0xD5A840", VA = "0x180D5BC40")]
		private void _OnSideSwitch(object arg)
		{
		}

		// Token: 0x06014FA6 RID: 85926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FA6")]
		[Address(RVA = "0xD5B890", Offset = "0xD5A490", VA = "0x180D5B890", Slot = "12")]
		protected virtual void SetHpSliderFillColorBySide()
		{
		}

		// Token: 0x06014FA7 RID: 85927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FA7")]
		[Address(RVA = "0xD5BCD0", Offset = "0xD5A8D0", VA = "0x180D5BCD0")]
		public UIHudCharHpSlider()
		{
		}

		// Token: 0x04018F36 RID: 102198
		[Token(Token = "0x4018F36")]
		[FieldOffset(Offset = "0x48")]
		private Character m_char;

		// Token: 0x04018F37 RID: 102199
		[Token(Token = "0x4018F37")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hudMask;

		// Token: 0x04018F38 RID: 102200
		[Token(Token = "0x4018F38")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_needToShow;

		// Token: 0x04018F39 RID: 102201
		[Token(Token = "0x4018F39")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnAttach;

		// Token: 0x04018F3A RID: 102202
		[Token(Token = "0x4018F3A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDetach;

		// Token: 0x04018F3B RID: 102203
		[Token(Token = "0x4018F3B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdatePlugin;

		// Token: 0x04018F3C RID: 102204
		[Token(Token = "0x4018F3C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnSideSwitch;

		// Token: 0x04018F3D RID: 102205
		[Token(Token = "0x4018F3D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetHpSliderFillColorBySide;

		// Token: 0x04018F3E RID: 102206
		[Token(Token = "0x4018F3E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
