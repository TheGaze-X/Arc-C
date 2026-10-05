using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003357 RID: 13143
	[Token(Token = "0x2003357")]
	public class UIHudCharBulletBar : UIBulletBar, HudPlugin, IHotfixable
	{
		// Token: 0x170031C4 RID: 12740
		// (get) Token: 0x06014F94 RID: 85908 RVA: 0x00089D90 File Offset: 0x00087F90
		[Token(Token = "0x170031C4")]
		public HudPluginMask hudMask
		{
			[Token(Token = "0x6014F94")]
			[Address(RVA = "0xD5B060", Offset = "0xD59C60", VA = "0x180D5B060", Slot = "4")]
			get
			{
				return HudPluginMask.NONE;
			}
		}

		// Token: 0x170031C5 RID: 12741
		// (get) Token: 0x06014F95 RID: 85909 RVA: 0x00089DA8 File Offset: 0x00087FA8
		[Token(Token = "0x170031C5")]
		public bool needToShow
		{
			[Token(Token = "0x6014F95")]
			[Address(RVA = "0xD5B0C0", Offset = "0xD59CC0", VA = "0x180D5B0C0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014F96 RID: 85910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F96")]
		[Address(RVA = "0xD5AA80", Offset = "0xD59680", VA = "0x180D5AA80", Slot = "6")]
		public void OnAttach(Unit owner)
		{
		}

		// Token: 0x06014F97 RID: 85911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F97")]
		[Address(RVA = "0xD5AD00", Offset = "0xD59900", VA = "0x180D5AD00", Slot = "7")]
		public void OnDetach()
		{
		}

		// Token: 0x06014F98 RID: 85912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F98")]
		[Address(RVA = "0xD5AD60", Offset = "0xD59960", VA = "0x180D5AD60", Slot = "8")]
		public void UpdatePlugin()
		{
		}

		// Token: 0x06014F99 RID: 85913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014F99")]
		[Address(RVA = "0xD5B000", Offset = "0xD59C00", VA = "0x180D5B000")]
		public UIHudCharBulletBar()
		{
		}

		// Token: 0x04018F27 RID: 102183
		[Token(Token = "0x4018F27")]
		[FieldOffset(Offset = "0x38")]
		private Character m_char;

		// Token: 0x04018F28 RID: 102184
		[Token(Token = "0x4018F28")]
		[FieldOffset(Offset = "0x40")]
		private CastSkillWithLimitTimes m_skill;

		// Token: 0x04018F29 RID: 102185
		[Token(Token = "0x4018F29")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hudMask;

		// Token: 0x04018F2A RID: 102186
		[Token(Token = "0x4018F2A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_needToShow;

		// Token: 0x04018F2B RID: 102187
		[Token(Token = "0x4018F2B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnAttach;

		// Token: 0x04018F2C RID: 102188
		[Token(Token = "0x4018F2C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDetach;

		// Token: 0x04018F2D RID: 102189
		[Token(Token = "0x4018F2D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdatePlugin;

		// Token: 0x04018F2E RID: 102190
		[Token(Token = "0x4018F2E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
