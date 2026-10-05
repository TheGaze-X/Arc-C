using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003358 RID: 13144
	[Token(Token = "0x2003358")]
	public class UIHudCharChantCastSlider : UITextSlider, HudPlugin, IHotfixable
	{
		// Token: 0x170031C6 RID: 12742
		// (get) Token: 0x06014F9A RID: 85914 RVA: 0x00089DC0 File Offset: 0x00087FC0
		[Token(Token = "0x170031C6")]
		public HudPluginMask hudMask
		{
			[Token(Token = "0x6014F9A")]
			[Address(RVA = "0xD5B470", Offset = "0xD5A070", VA = "0x180D5B470", Slot = "6")]
			get
			{
				return HudPluginMask.NONE;
			}
		}

		// Token: 0x170031C7 RID: 12743
		// (get) Token: 0x06014F9B RID: 85915 RVA: 0x00089DD8 File Offset: 0x00087FD8
		[Token(Token = "0x170031C7")]
		public bool needToShow
		{
			[Token(Token = "0x6014F9B")]
			[Address(RVA = "0xD5B4D0", Offset = "0xD5A0D0", VA = "0x180D5B4D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014F9C RID: 85916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F9C")]
		[Address(RVA = "0xD5B190", Offset = "0xD59D90", VA = "0x180D5B190", Slot = "8")]
		public void OnAttach(Unit owner)
		{
		}

		// Token: 0x06014F9D RID: 85917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F9D")]
		[Address(RVA = "0xD5B2E0", Offset = "0xD59EE0", VA = "0x180D5B2E0", Slot = "9")]
		public void OnDetach()
		{
		}

		// Token: 0x06014F9E RID: 85918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F9E")]
		[Address(RVA = "0xD5B340", Offset = "0xD59F40", VA = "0x180D5B340", Slot = "10")]
		public void UpdatePlugin()
		{
		}

		// Token: 0x06014F9F RID: 85919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F9F")]
		[Address(RVA = "0xD5B410", Offset = "0xD5A010", VA = "0x180D5B410")]
		public UIHudCharChantCastSlider()
		{
		}

		// Token: 0x04018F2F RID: 102191
		[Token(Token = "0x4018F2F")]
		[FieldOffset(Offset = "0x38")]
		private Character m_char;

		// Token: 0x04018F30 RID: 102192
		[Token(Token = "0x4018F30")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hudMask;

		// Token: 0x04018F31 RID: 102193
		[Token(Token = "0x4018F31")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_needToShow;

		// Token: 0x04018F32 RID: 102194
		[Token(Token = "0x4018F32")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnAttach;

		// Token: 0x04018F33 RID: 102195
		[Token(Token = "0x4018F33")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDetach;

		// Token: 0x04018F34 RID: 102196
		[Token(Token = "0x4018F34")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdatePlugin;

		// Token: 0x04018F35 RID: 102197
		[Token(Token = "0x4018F35")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
