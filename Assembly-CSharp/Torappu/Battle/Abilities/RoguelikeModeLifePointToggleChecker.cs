using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B64 RID: 11108
	[Token(Token = "0x2002B64")]
	public class RoguelikeModeLifePointToggleChecker : ToggleablePassiveBuffAbility.Checker
	{
		// Token: 0x06012A63 RID: 76387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A63")]
		[Address(RVA = "0xAA5270", Offset = "0xAA3E70", VA = "0x180AA5270", Slot = "6")]
		protected override void LoadData(Blackboard blackboard)
		{
		}

		// Token: 0x06012A64 RID: 76388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A64")]
		[Address(RVA = "0xAA5490", Offset = "0xAA4090", VA = "0x180AA5490", Slot = "9")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012A65 RID: 76389 RVA: 0x00072498 File Offset: 0x00070698
		[Token(Token = "0x6012A65")]
		[Address(RVA = "0xAA51F0", Offset = "0xAA3DF0", VA = "0x180AA51F0", Slot = "5")]
		public override bool CheckInitialToggled()
		{
			return default(bool);
		}

		// Token: 0x06012A66 RID: 76390 RVA: 0x000724B0 File Offset: 0x000706B0
		[Token(Token = "0x6012A66")]
		[Address(RVA = "0xAA5520", Offset = "0xAA4120", VA = "0x180AA5520")]
		private bool _CheckCondition()
		{
			return default(bool);
		}

		// Token: 0x06012A67 RID: 76391 RVA: 0x000724C8 File Offset: 0x000706C8
		[Token(Token = "0x6012A67")]
		[Address(RVA = "0xAA5760", Offset = "0xAA4360", VA = "0x180AA5760")]
		private bool _CheckGameMode()
		{
			return default(bool);
		}

		// Token: 0x06012A68 RID: 76392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A68")]
		[Address(RVA = "0xAA5870", Offset = "0xAA4470", VA = "0x180AA5870")]
		public RoguelikeModeLifePointToggleChecker()
		{
		}

		// Token: 0x06012A69 RID: 76393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A69")]
		[Address(RVA = "0xA96850", Offset = "0xA95450", VA = "0x180A96850")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0401514B RID: 86347
		[Token(Token = "0x401514B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _minLifePoint;

		// Token: 0x0401514C RID: 86348
		[Token(Token = "0x401514C")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int _maxLifePoint;

		// Token: 0x0401514D RID: 86349
		[Token(Token = "0x401514D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _checkLifePointEqualMax;

		// Token: 0x0401514E RID: 86350
		[Token(Token = "0x401514E")]
		[FieldOffset(Offset = "0x2C")]
		private int m_minLifePoint;

		// Token: 0x0401514F RID: 86351
		[Token(Token = "0x401514F")]
		[FieldOffset(Offset = "0x30")]
		private int m_maxLifePoint;

		// Token: 0x04015150 RID: 86352
		[Token(Token = "0x4015150")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04015151 RID: 86353
		[Token(Token = "0x4015151")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04015152 RID: 86354
		[Token(Token = "0x4015152")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckInitialToggled;

		// Token: 0x04015153 RID: 86355
		[Token(Token = "0x4015153")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckCondition;

		// Token: 0x04015154 RID: 86356
		[Token(Token = "0x4015154")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckGameMode;

		// Token: 0x04015155 RID: 86357
		[Token(Token = "0x4015155")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
