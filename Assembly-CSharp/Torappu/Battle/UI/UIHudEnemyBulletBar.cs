using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003361 RID: 13153
	[Token(Token = "0x2003361")]
	public class UIHudEnemyBulletBar : UIBulletBar, HudPlugin, IHotfixable
	{
		// Token: 0x170031D8 RID: 12760
		// (get) Token: 0x06014FDA RID: 85978 RVA: 0x00089FA0 File Offset: 0x000881A0
		[Token(Token = "0x170031D8")]
		public HudPluginMask hudMask
		{
			[Token(Token = "0x6014FDA")]
			[Address(RVA = "0xD74CC0", Offset = "0xD738C0", VA = "0x180D74CC0", Slot = "4")]
			get
			{
				return HudPluginMask.NONE;
			}
		}

		// Token: 0x170031D9 RID: 12761
		// (get) Token: 0x06014FDB RID: 85979 RVA: 0x00089FB8 File Offset: 0x000881B8
		[Token(Token = "0x170031D9")]
		public bool needToShow
		{
			[Token(Token = "0x6014FDB")]
			[Address(RVA = "0xD74D20", Offset = "0xD73920", VA = "0x180D74D20", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014FDC RID: 85980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FDC")]
		[Address(RVA = "0xD74960", Offset = "0xD73560", VA = "0x180D74960", Slot = "6")]
		public void OnAttach(Unit owner)
		{
		}

		// Token: 0x06014FDD RID: 85981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FDD")]
		[Address(RVA = "0xD74AB0", Offset = "0xD736B0", VA = "0x180D74AB0", Slot = "7")]
		public void OnDetach()
		{
		}

		// Token: 0x06014FDE RID: 85982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FDE")]
		[Address(RVA = "0xD74B10", Offset = "0xD73710", VA = "0x180D74B10", Slot = "8")]
		public void UpdatePlugin()
		{
		}

		// Token: 0x06014FDF RID: 85983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FDF")]
		[Address(RVA = "0xD74C20", Offset = "0xD73820", VA = "0x180D74C20")]
		public UIHudEnemyBulletBar()
		{
		}

		// Token: 0x04018F83 RID: 102275
		[Token(Token = "0x4018F83")]
		[FieldOffset(Offset = "0x38")]
		private Enemy m_enemy;

		// Token: 0x04018F84 RID: 102276
		[Token(Token = "0x4018F84")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hudMask;

		// Token: 0x04018F85 RID: 102277
		[Token(Token = "0x4018F85")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_needToShow;

		// Token: 0x04018F86 RID: 102278
		[Token(Token = "0x4018F86")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnAttach;

		// Token: 0x04018F87 RID: 102279
		[Token(Token = "0x4018F87")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDetach;

		// Token: 0x04018F88 RID: 102280
		[Token(Token = "0x4018F88")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdatePlugin;

		// Token: 0x04018F89 RID: 102281
		[Token(Token = "0x4018F89")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
