using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002450 RID: 9296
	[Token(Token = "0x2002450")]
	public class CastSkillForTrapGarage : CastSkill, IHudPluginSource
	{
		// Token: 0x17001EF6 RID: 7926
		// (get) Token: 0x0600EEB0 RID: 61104 RVA: 0x00057A68 File Offset: 0x00055C68
		[Token(Token = "0x17001EF6")]
		public int requiredCost
		{
			[Token(Token = "0x600EEB0")]
			[Address(RVA = "0x641A00", Offset = "0x640600", VA = "0x180641A00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600EEB1 RID: 61105 RVA: 0x00057A80 File Offset: 0x00055C80
		[Token(Token = "0x600EEB1")]
		[Address(RVA = "0x6411B0", Offset = "0x63FDB0", VA = "0x1806411B0", Slot = "19")]
		public override bool IsAvailable(PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600EEB2 RID: 61106 RVA: 0x00057A98 File Offset: 0x00055C98
		[Token(Token = "0x600EEB2")]
		[Address(RVA = "0x641290", Offset = "0x63FE90", VA = "0x180641290", Slot = "24")]
		public override bool IsDiscardable()
		{
			return default(bool);
		}

		// Token: 0x0600EEB3 RID: 61107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EEB3")]
		[Address(RVA = "0x6412F0", Offset = "0x63FEF0", VA = "0x1806412F0", Slot = "57")]
		public override void OnInit()
		{
		}

		// Token: 0x0600EEB4 RID: 61108 RVA: 0x00057AB0 File Offset: 0x00055CB0
		[Token(Token = "0x600EEB4")]
		[Address(RVA = "0x640C30", Offset = "0x63F830", VA = "0x180640C30", Slot = "49")]
		protected override bool DoCast([Optional] Ability.FinishCallbackDelegate finishCb, PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600EEB5 RID: 61109 RVA: 0x00057AC8 File Offset: 0x00055CC8
		[Token(Token = "0x600EEB5")]
		[Address(RVA = "0x641640", Offset = "0x640240", VA = "0x180641640", Slot = "51")]
		public override bool UseSkill(PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600EEB6 RID: 61110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EEB6")]
		[Address(RVA = "0x640BB0", Offset = "0x63F7B0", VA = "0x180640BB0")]
		public void AutoUseSkill(PlayerSide operationSide = PlayerSide.DEFAULT)
		{
		}

		// Token: 0x0600EEB7 RID: 61111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EEB7")]
		[Address(RVA = "0x641440", Offset = "0x640040", VA = "0x180641440", Slot = "74")]
		protected override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600EEB8 RID: 61112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EEB8")]
		[Address(RVA = "0x641060", Offset = "0x63FC60", VA = "0x180641060", Slot = "79")]
		public void GatherHudPluginTypes(List<string> pluginNames)
		{
		}

		// Token: 0x0600EEB9 RID: 61113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EEB9")]
		[Address(RVA = "0x641980", Offset = "0x640580", VA = "0x180641980")]
		public CastSkillForTrapGarage()
		{
		}

		// Token: 0x0600EEBA RID: 61114 RVA: 0x00057AE0 File Offset: 0x00055CE0
		[Token(Token = "0x600EEBA")]
		[Address(RVA = "0x636840", Offset = "0x635440", VA = "0x180636840")]
		private bool <>xLuaBaseProxy_IsAvailable(PlayerSide P0)
		{
			return default(bool);
		}

		// Token: 0x0600EEBB RID: 61115 RVA: 0x00057AF8 File Offset: 0x00055CF8
		[Token(Token = "0x600EEBB")]
		[Address(RVA = "0x6345F0", Offset = "0x6331F0", VA = "0x1806345F0")]
		private bool <>xLuaBaseProxy_IsDiscardable()
		{
			return default(bool);
		}

		// Token: 0x0600EEBC RID: 61116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EEBC")]
		[Address(RVA = "0x641620", Offset = "0x640220", VA = "0x180641620")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0600EEBD RID: 61117 RVA: 0x00057B10 File Offset: 0x00055D10
		[Token(Token = "0x600EEBD")]
		[Address(RVA = "0x641610", Offset = "0x640210", VA = "0x180641610")]
		private bool <>xLuaBaseProxy_DoCast(Ability.FinishCallbackDelegate P0, PlayerSide P1)
		{
			return default(bool);
		}

		// Token: 0x0600EEBE RID: 61118 RVA: 0x00057B28 File Offset: 0x00055D28
		[Token(Token = "0x600EEBE")]
		[Address(RVA = "0x641630", Offset = "0x640230", VA = "0x180641630")]
		private bool <>xLuaBaseProxy_UseSkill(PlayerSide P0)
		{
			return default(bool);
		}

		// Token: 0x0600EEBF RID: 61119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EEBF")]
		[Address(RVA = "0x636850", Offset = "0x635450", VA = "0x180636850")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x040107FE RID: 67582
		[Token(Token = "0x40107FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private bool m_inAutoMode;

		// Token: 0x040107FF RID: 67583
		[Token(Token = "0x40107FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		private int m_requiredCost;

		// Token: 0x04010800 RID: 67584
		[Token(Token = "0x4010800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_requiredCost;

		// Token: 0x04010801 RID: 67585
		[Token(Token = "0x4010801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsAvailable;

		// Token: 0x04010802 RID: 67586
		[Token(Token = "0x4010802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsDiscardable;

		// Token: 0x04010803 RID: 67587
		[Token(Token = "0x4010803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04010804 RID: 67588
		[Token(Token = "0x4010804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DoCast;

		// Token: 0x04010805 RID: 67589
		[Token(Token = "0x4010805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UseSkill;

		// Token: 0x04010806 RID: 67590
		[Token(Token = "0x4010806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_AutoUseSkill;

		// Token: 0x04010807 RID: 67591
		[Token(Token = "0x4010807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04010808 RID: 67592
		[Token(Token = "0x4010808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GatherHudPluginTypes;

		// Token: 0x04010809 RID: 67593
		[Token(Token = "0x4010809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
