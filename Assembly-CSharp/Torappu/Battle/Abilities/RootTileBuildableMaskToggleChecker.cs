using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B65 RID: 11109
	[Token(Token = "0x2002B65")]
	public class RootTileBuildableMaskToggleChecker : ToggleablePassiveBuffAbility.Checker
	{
		// Token: 0x06012A6A RID: 76394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A6A")]
		[Address(RVA = "0xAA5980", Offset = "0xAA4580", VA = "0x180AA5980", Slot = "6")]
		protected override void LoadData(Blackboard blackboard)
		{
		}

		// Token: 0x06012A6B RID: 76395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A6B")]
		[Address(RVA = "0xAA59E0", Offset = "0xAA45E0", VA = "0x180AA59E0", Slot = "8")]
		public override void OnDetached()
		{
		}

		// Token: 0x06012A6C RID: 76396 RVA: 0x000724E0 File Offset: 0x000706E0
		[Token(Token = "0x6012A6C")]
		[Address(RVA = "0xAA5920", Offset = "0xAA4520", VA = "0x180AA5920", Slot = "5")]
		public override bool CheckInitialToggled()
		{
			return default(bool);
		}

		// Token: 0x06012A6D RID: 76397 RVA: 0x000724F8 File Offset: 0x000706F8
		[Token(Token = "0x6012A6D")]
		[Address(RVA = "0xAA5B00", Offset = "0xAA4700", VA = "0x180AA5B00")]
		private bool _CheckCondition()
		{
			return default(bool);
		}

		// Token: 0x06012A6E RID: 76398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A6E")]
		[Address(RVA = "0xAA5A40", Offset = "0xAA4640", VA = "0x180AA5A40", Slot = "9")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012A6F RID: 76399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A6F")]
		[Address(RVA = "0xAA5C50", Offset = "0xAA4850", VA = "0x180AA5C50")]
		public RootTileBuildableMaskToggleChecker()
		{
		}

		// Token: 0x06012A70 RID: 76400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A70")]
		[Address(RVA = "0xA961B0", Offset = "0xA94DB0", VA = "0x180A961B0")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x06012A71 RID: 76401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A71")]
		[Address(RVA = "0xA96850", Offset = "0xA95450", VA = "0x180A96850")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04015156 RID: 86358
		[Token(Token = "0x4015156")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RootTileBuildableMaskToggleChecker.TileCondition _condition;

		// Token: 0x04015157 RID: 86359
		[Token(Token = "0x4015157")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04015158 RID: 86360
		[Token(Token = "0x4015158")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x04015159 RID: 86361
		[Token(Token = "0x4015159")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckInitialToggled;

		// Token: 0x0401515A RID: 86362
		[Token(Token = "0x401515A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckCondition;

		// Token: 0x0401515B RID: 86363
		[Token(Token = "0x401515B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0401515C RID: 86364
		[Token(Token = "0x401515C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002B66 RID: 11110
		[Token(Token = "0x2002B66")]
		[Serializable]
		public struct TileCondition
		{
			// Token: 0x0401515D RID: 86365
			[Token(Token = "0x401515D")]
			[FieldOffset(Offset = "0x0")]
			public AdvancedBuildableMask _toggleOnMask;
		}
	}
}
