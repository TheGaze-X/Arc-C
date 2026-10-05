using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003367 RID: 13159
	[Token(Token = "0x2003367")]
	public class UIHudUnitEpSlider : UIFollowEpSlider, HudPlugin, IHotfixable
	{
		// Token: 0x170031E4 RID: 12772
		// (get) Token: 0x06015000 RID: 86016 RVA: 0x0008A0C0 File Offset: 0x000882C0
		[Token(Token = "0x170031E4")]
		public HudPluginMask hudMask
		{
			[Token(Token = "0x6015000")]
			[Address(RVA = "0xD771B0", Offset = "0xD75DB0", VA = "0x180D771B0", Slot = "6")]
			get
			{
				return HudPluginMask.NONE;
			}
		}

		// Token: 0x170031E5 RID: 12773
		// (get) Token: 0x06015001 RID: 86017 RVA: 0x0008A0D8 File Offset: 0x000882D8
		[Token(Token = "0x170031E5")]
		public bool needToShow
		{
			[Token(Token = "0x6015001")]
			[Address(RVA = "0xD77210", Offset = "0xD75E10", VA = "0x180D77210", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06015002 RID: 86018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015002")]
		[Address(RVA = "0xD76810", Offset = "0xD75410", VA = "0x180D76810", Slot = "8")]
		public void OnAttach(Unit owner)
		{
		}

		// Token: 0x06015003 RID: 86019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015003")]
		[Address(RVA = "0xD76A10", Offset = "0xD75610", VA = "0x180D76A10", Slot = "9")]
		public void OnDetach()
		{
		}

		// Token: 0x06015004 RID: 86020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015004")]
		[Address(RVA = "0xD76BE0", Offset = "0xD757E0", VA = "0x180D76BE0", Slot = "10")]
		public void UpdatePlugin()
		{
		}

		// Token: 0x06015005 RID: 86021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015005")]
		[Address(RVA = "0xD76E90", Offset = "0xD75A90", VA = "0x180D76E90")]
		private void _OnAppliedModifier(object arg)
		{
		}

		// Token: 0x06015006 RID: 86022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015006")]
		[Address(RVA = "0xD77070", Offset = "0xD75C70", VA = "0x180D77070")]
		private void _OnElementBreak(object arg)
		{
		}

		// Token: 0x06015007 RID: 86023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015007")]
		[Address(RVA = "0xD77150", Offset = "0xD75D50", VA = "0x180D77150")]
		public UIHudUnitEpSlider()
		{
		}

		// Token: 0x04018FB3 RID: 102323
		[Token(Token = "0x4018FB3")]
		[FieldOffset(Offset = "0x98")]
		private Unit m_owner;

		// Token: 0x04018FB4 RID: 102324
		[Token(Token = "0x4018FB4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hudMask;

		// Token: 0x04018FB5 RID: 102325
		[Token(Token = "0x4018FB5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_needToShow;

		// Token: 0x04018FB6 RID: 102326
		[Token(Token = "0x4018FB6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnAttach;

		// Token: 0x04018FB7 RID: 102327
		[Token(Token = "0x4018FB7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDetach;

		// Token: 0x04018FB8 RID: 102328
		[Token(Token = "0x4018FB8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdatePlugin;

		// Token: 0x04018FB9 RID: 102329
		[Token(Token = "0x4018FB9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnAppliedModifier;

		// Token: 0x04018FBA RID: 102330
		[Token(Token = "0x4018FBA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnElementBreak;

		// Token: 0x04018FBB RID: 102331
		[Token(Token = "0x4018FBB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
