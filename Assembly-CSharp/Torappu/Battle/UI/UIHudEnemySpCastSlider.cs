using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003363 RID: 13155
	[Token(Token = "0x2003363")]
	public class UIHudEnemySpCastSlider : UITextSlider, HudPlugin, IHotfixable
	{
		// Token: 0x170031DC RID: 12764
		// (get) Token: 0x06014FE8 RID: 85992 RVA: 0x0008A000 File Offset: 0x00088200
		[Token(Token = "0x170031DC")]
		public HudPluginMask hudMask
		{
			[Token(Token = "0x6014FE8")]
			[Address(RVA = "0xD759E0", Offset = "0xD745E0", VA = "0x180D759E0", Slot = "6")]
			get
			{
				return HudPluginMask.NONE;
			}
		}

		// Token: 0x170031DD RID: 12765
		// (get) Token: 0x06014FE9 RID: 85993 RVA: 0x0008A018 File Offset: 0x00088218
		[Token(Token = "0x170031DD")]
		public bool needToShow
		{
			[Token(Token = "0x6014FE9")]
			[Address(RVA = "0xD75A40", Offset = "0xD74640", VA = "0x180D75A40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014FEA RID: 85994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FEA")]
		[Address(RVA = "0xD756C0", Offset = "0xD742C0", VA = "0x180D756C0", Slot = "8")]
		public void OnAttach(Unit owner)
		{
		}

		// Token: 0x06014FEB RID: 85995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FEB")]
		[Address(RVA = "0xD75810", Offset = "0xD74410", VA = "0x180D75810", Slot = "9")]
		public void OnDetach()
		{
		}

		// Token: 0x06014FEC RID: 85996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FEC")]
		[Address(RVA = "0xD75870", Offset = "0xD74470", VA = "0x180D75870", Slot = "10")]
		public void UpdatePlugin()
		{
		}

		// Token: 0x06014FED RID: 85997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014FED")]
		[Address(RVA = "0xD75980", Offset = "0xD74580", VA = "0x180D75980")]
		public UIHudEnemySpCastSlider()
		{
		}

		// Token: 0x04018F93 RID: 102291
		[Token(Token = "0x4018F93")]
		[FieldOffset(Offset = "0x38")]
		private Enemy m_enemy;

		// Token: 0x04018F94 RID: 102292
		[Token(Token = "0x4018F94")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hudMask;

		// Token: 0x04018F95 RID: 102293
		[Token(Token = "0x4018F95")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_needToShow;

		// Token: 0x04018F96 RID: 102294
		[Token(Token = "0x4018F96")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnAttach;

		// Token: 0x04018F97 RID: 102295
		[Token(Token = "0x4018F97")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDetach;

		// Token: 0x04018F98 RID: 102296
		[Token(Token = "0x4018F98")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdatePlugin;

		// Token: 0x04018F99 RID: 102297
		[Token(Token = "0x4018F99")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
