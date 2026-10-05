using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B5C RID: 11100
	[Token(Token = "0x2002B5C")]
	public class FilterBuffToggleChecker : ToggleablePassiveBuffAbility.Checker
	{
		// Token: 0x06012A28 RID: 76328 RVA: 0x00072288 File Offset: 0x00070488
		[Token(Token = "0x6012A28")]
		[Address(RVA = "0xAA0CE0", Offset = "0xA9F8E0", VA = "0x180AA0CE0", Slot = "5")]
		public override bool CheckInitialToggled()
		{
			return default(bool);
		}

		// Token: 0x06012A29 RID: 76329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A29")]
		[Address(RVA = "0xAA0D40", Offset = "0xA9F940", VA = "0x180AA0D40", Slot = "6")]
		protected override void LoadData(Blackboard blackboard)
		{
		}

		// Token: 0x06012A2A RID: 76330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A2A")]
		[Address(RVA = "0xAA0DA0", Offset = "0xA9F9A0", VA = "0x180AA0DA0", Slot = "7")]
		public override void OnAttached()
		{
		}

		// Token: 0x06012A2B RID: 76331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A2B")]
		[Address(RVA = "0xAA0E50", Offset = "0xA9FA50", VA = "0x180AA0E50", Slot = "9")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012A2C RID: 76332 RVA: 0x000722A0 File Offset: 0x000704A0
		[Token(Token = "0x6012A2C")]
		[Address(RVA = "0xAA0F00", Offset = "0xA9FB00", VA = "0x180AA0F00")]
		private bool _CheckCondition()
		{
			return default(bool);
		}

		// Token: 0x06012A2D RID: 76333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A2D")]
		[Address(RVA = "0xAA1020", Offset = "0xA9FC20", VA = "0x180AA1020")]
		public FilterBuffToggleChecker()
		{
		}

		// Token: 0x06012A2E RID: 76334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A2E")]
		[Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
		private void <>xLuaBaseProxy_OnAttached()
		{
		}

		// Token: 0x06012A2F RID: 76335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A2F")]
		[Address(RVA = "0xA96850", Offset = "0xA95450", VA = "0x180A96850")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x040150F6 RID: 86262
		[Token(Token = "0x40150F6")]
		private const int TOGGLE_CHECKER_TICK = 10;

		// Token: 0x040150F7 RID: 86263
		[Token(Token = "0x40150F7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _excludeBuff;

		// Token: 0x040150F8 RID: 86264
		[Token(Token = "0x40150F8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _buffKey;

		// Token: 0x040150F9 RID: 86265
		[Token(Token = "0x40150F9")]
		[FieldOffset(Offset = "0x30")]
		private PeriodicTicker m_checkerTicker;

		// Token: 0x040150FA RID: 86266
		[Token(Token = "0x40150FA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckInitialToggled;

		// Token: 0x040150FB RID: 86267
		[Token(Token = "0x40150FB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040150FC RID: 86268
		[Token(Token = "0x40150FC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnAttached;

		// Token: 0x040150FD RID: 86269
		[Token(Token = "0x40150FD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040150FE RID: 86270
		[Token(Token = "0x40150FE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckCondition;

		// Token: 0x040150FF RID: 86271
		[Token(Token = "0x40150FF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
