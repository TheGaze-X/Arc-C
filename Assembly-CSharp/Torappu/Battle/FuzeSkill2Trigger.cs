using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002562 RID: 9570
	[Token(Token = "0x2002562")]
	public class FuzeSkill2Trigger : TargetTrigger
	{
		// Token: 0x17002060 RID: 8288
		// (get) Token: 0x0600F702 RID: 63234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002060")]
		public override Entity target
		{
			[Token(Token = "0x600F702")]
			[Address(RVA = "0x70CC30", Offset = "0x70B830", VA = "0x18070CC30", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002061 RID: 8289
		// (get) Token: 0x0600F703 RID: 63235 RVA: 0x0005C250 File Offset: 0x0005A450
		[Token(Token = "0x17002061")]
		public override bool isReadyToTrig
		{
			[Token(Token = "0x600F703")]
			[Address(RVA = "0x70CBD0", Offset = "0x70B7D0", VA = "0x18070CBD0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F704 RID: 63236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F704")]
		[Address(RVA = "0x70C550", Offset = "0x70B150", VA = "0x18070C550", Slot = "12")]
		public override void Reset(Entity owner, Ability ability)
		{
		}

		// Token: 0x0600F705 RID: 63237 RVA: 0x0005C268 File Offset: 0x0005A468
		[Token(Token = "0x600F705")]
		[Address(RVA = "0x70C600", Offset = "0x70B200", VA = "0x18070C600", Slot = "13")]
		public override bool Search(bool force)
		{
			return default(bool);
		}

		// Token: 0x0600F706 RID: 63238 RVA: 0x0005C280 File Offset: 0x0005A480
		[Token(Token = "0x600F706")]
		[Address(RVA = "0x70C9A0", Offset = "0x70B5A0", VA = "0x18070C9A0")]
		private bool _IsValidTrap(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0600F707 RID: 63239 RVA: 0x0005C298 File Offset: 0x0005A498
		[Token(Token = "0x600F707")]
		[Address(RVA = "0x70C4E0", Offset = "0x70B0E0", VA = "0x18070C4E0", Slot = "14")]
		public override bool CheckTargetIn(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F708 RID: 63240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F708")]
		[Address(RVA = "0x70CB30", Offset = "0x70B730", VA = "0x18070CB30")]
		public FuzeSkill2Trigger()
		{
		}

		// Token: 0x0600F709 RID: 63241 RVA: 0x0005C2B0 File Offset: 0x0005A4B0
		[Token(Token = "0x600F709")]
		[Address(RVA = "0x6EF7F0", Offset = "0x6EE3F0", VA = "0x1806EF7F0")]
		private bool <>xLuaBaseProxy_get_isReadyToTrig()
		{
			return default(bool);
		}

		// Token: 0x0600F70A RID: 63242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F70A")]
		[Address(RVA = "0x6F3400", Offset = "0x6F2000", VA = "0x1806F3400")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1)
		{
		}

		// Token: 0x04011261 RID: 70241
		[Token(Token = "0x4011261")]
		private const int MIN_SKILL_TRIGGER_TILE_CNT = 2;

		// Token: 0x04011262 RID: 70242
		[Token(Token = "0x4011262")]
		private const string SHELTR_KEY = "trap_141_sheltr";

		// Token: 0x04011263 RID: 70243
		[Token(Token = "0x4011263")]
		[FieldOffset(Offset = "0x20")]
		private Entity m_owner;

		// Token: 0x04011264 RID: 70244
		[Token(Token = "0x4011264")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isLastSearchSucceed;

		// Token: 0x04011265 RID: 70245
		[Token(Token = "0x4011265")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_target;

		// Token: 0x04011266 RID: 70246
		[Token(Token = "0x4011266")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isReadyToTrig;

		// Token: 0x04011267 RID: 70247
		[Token(Token = "0x4011267")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04011268 RID: 70248
		[Token(Token = "0x4011268")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Search;

		// Token: 0x04011269 RID: 70249
		[Token(Token = "0x4011269")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__IsValidTrap;

		// Token: 0x0401126A RID: 70250
		[Token(Token = "0x401126A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CheckTargetIn;

		// Token: 0x0401126B RID: 70251
		[Token(Token = "0x401126B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
