using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B63 RID: 11107
	[Token(Token = "0x2002B63")]
	public class RangeTileToggleChecker : ToggleablePassiveBuffAbility.Checker
	{
		// Token: 0x06012A5B RID: 76379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A5B")]
		[Address(RVA = "0xAA4C30", Offset = "0xAA3830", VA = "0x180AA4C30", Slot = "6")]
		protected override void LoadData(Blackboard blackboard)
		{
		}

		// Token: 0x06012A5C RID: 76380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A5C")]
		[Address(RVA = "0xAA4F50", Offset = "0xAA3B50", VA = "0x180AA4F50", Slot = "9")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012A5D RID: 76381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A5D")]
		[Address(RVA = "0xAA4EF0", Offset = "0xAA3AF0", VA = "0x180AA4EF0", Slot = "8")]
		public override void OnDetached()
		{
		}

		// Token: 0x06012A5E RID: 76382 RVA: 0x00072468 File Offset: 0x00070668
		[Token(Token = "0x6012A5E")]
		[Address(RVA = "0xAA4B60", Offset = "0xAA3760", VA = "0x180AA4B60", Slot = "5")]
		public override bool CheckInitialToggled()
		{
			return default(bool);
		}

		// Token: 0x06012A5F RID: 76383 RVA: 0x00072480 File Offset: 0x00070680
		[Token(Token = "0x6012A5F")]
		[Address(RVA = "0xAA5030", Offset = "0xAA3C30", VA = "0x180AA5030")]
		private bool _CheckCondition(Vector2 pos)
		{
			return default(bool);
		}

		// Token: 0x06012A60 RID: 76384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A60")]
		[Address(RVA = "0xAA5150", Offset = "0xAA3D50", VA = "0x180AA5150")]
		public RangeTileToggleChecker()
		{
		}

		// Token: 0x06012A61 RID: 76385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A61")]
		[Address(RVA = "0xA96850", Offset = "0xA95450", VA = "0x180A96850")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06012A62 RID: 76386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A62")]
		[Address(RVA = "0xA961B0", Offset = "0xA94DB0", VA = "0x180A961B0")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x04015142 RID: 86338
		[Token(Token = "0x4015142")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TargetSelector _selector;

		// Token: 0x04015143 RID: 86339
		[Token(Token = "0x4015143")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private PhysicsRange _rangeToLoad;

		// Token: 0x04015144 RID: 86340
		[Token(Token = "0x4015144")]
		[FieldOffset(Offset = "0x30")]
		private int m_minCnt;

		// Token: 0x04015145 RID: 86341
		[Token(Token = "0x4015145")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04015146 RID: 86342
		[Token(Token = "0x4015146")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04015147 RID: 86343
		[Token(Token = "0x4015147")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x04015148 RID: 86344
		[Token(Token = "0x4015148")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckInitialToggled;

		// Token: 0x04015149 RID: 86345
		[Token(Token = "0x4015149")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckCondition;

		// Token: 0x0401514A RID: 86346
		[Token(Token = "0x401514A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
