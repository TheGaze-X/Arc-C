using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002279 RID: 8825
	[Token(Token = "0x2002279")]
	public class Rogue1GlobalCardBuffByLifePoint : GlobalBuff
	{
		// Token: 0x0600DDF8 RID: 56824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDF8")]
		[Address(RVA = "0x363F490", Offset = "0x363E090", VA = "0x18363F490", Slot = "9")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600DDF9 RID: 56825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDF9")]
		[Address(RVA = "0x363F3D0", Offset = "0x363DFD0", VA = "0x18363F3D0", Slot = "11")]
		public override void OnInit(LevelData.GlobalBuffData data)
		{
		}

		// Token: 0x0600DDFA RID: 56826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDFA")]
		[Address(RVA = "0x363F830", Offset = "0x363E430", VA = "0x18363F830")]
		private void _CheckToggled()
		{
		}

		// Token: 0x0600DDFB RID: 56827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDFB")]
		[Address(RVA = "0x363F9D0", Offset = "0x363E5D0", VA = "0x18363F9D0")]
		private void _OnToggleChanged(bool isToggled)
		{
		}

		// Token: 0x0600DDFC RID: 56828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDFC")]
		[Address(RVA = "0x363F690", Offset = "0x363E290", VA = "0x18363F690")]
		private void _AddCardBuff()
		{
		}

		// Token: 0x0600DDFD RID: 56829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDFD")]
		[Address(RVA = "0x363F8F0", Offset = "0x363E4F0", VA = "0x18363F8F0")]
		private void _ClearCardBuff()
		{
		}

		// Token: 0x0600DDFE RID: 56830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDFE")]
		[Address(RVA = "0x363FC80", Offset = "0x363E880", VA = "0x18363FC80")]
		public Rogue1GlobalCardBuffByLifePoint()
		{
		}

		// Token: 0x0600DE00 RID: 56832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE00")]
		[Address(RVA = "0x362C380", Offset = "0x362AF80", VA = "0x18362C380")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600DE01 RID: 56833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DE01")]
		[Address(RVA = "0x362AB00", Offset = "0x3629700", VA = "0x18362AB00")]
		private void <>xLuaBaseProxy_OnInit(LevelData.GlobalBuffData P0)
		{
		}

		// Token: 0x0400F0B7 RID: 61623
		[Token(Token = "0x400F0B7")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private int _lifePointMax;

		// Token: 0x0400F0B8 RID: 61624
		[Token(Token = "0x400F0B8")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private string _cardbuffKey;

		// Token: 0x0400F0B9 RID: 61625
		[Token(Token = "0x400F0B9")]
		[FieldOffset(Offset = "0x158")]
		private int m_lifePointMax;

		// Token: 0x0400F0BA RID: 61626
		[Token(Token = "0x400F0BA")]
		[FieldOffset(Offset = "0x15C")]
		private bool m_isToggled;

		// Token: 0x0400F0BB RID: 61627
		[Token(Token = "0x400F0BB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400F0BC RID: 61628
		[Token(Token = "0x400F0BC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400F0BD RID: 61629
		[Token(Token = "0x400F0BD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckToggled;

		// Token: 0x0400F0BE RID: 61630
		[Token(Token = "0x400F0BE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnToggleChanged;

		// Token: 0x0400F0BF RID: 61631
		[Token(Token = "0x400F0BF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__AddCardBuff;

		// Token: 0x0400F0C0 RID: 61632
		[Token(Token = "0x400F0C0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ClearCardBuff;

		// Token: 0x0400F0C1 RID: 61633
		[Token(Token = "0x400F0C1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
