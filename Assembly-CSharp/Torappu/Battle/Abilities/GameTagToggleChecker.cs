using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B5E RID: 11102
	[Token(Token = "0x2002B5E")]
	public class GameTagToggleChecker : ToggleablePassiveBuffAbility.Checker
	{
		// Token: 0x06012A36 RID: 76342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A36")]
		[Address(RVA = "0xAA1520", Offset = "0xAA0120", VA = "0x180AA1520", Slot = "6")]
		protected override void LoadData(Blackboard blackboard)
		{
		}

		// Token: 0x06012A37 RID: 76343 RVA: 0x000722E8 File Offset: 0x000704E8
		[Token(Token = "0x6012A37")]
		[Address(RVA = "0xAA14B0", Offset = "0xAA00B0", VA = "0x180AA14B0", Slot = "5")]
		public override bool CheckInitialToggled()
		{
			return default(bool);
		}

		// Token: 0x06012A38 RID: 76344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A38")]
		[Address(RVA = "0xAA1580", Offset = "0xAA0180", VA = "0x180AA1580")]
		public GameTagToggleChecker()
		{
		}

		// Token: 0x0401510A RID: 86282
		[Token(Token = "0x401510A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _checkRoguelikeMode;

		// Token: 0x0401510B RID: 86283
		[Token(Token = "0x401510B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401510C RID: 86284
		[Token(Token = "0x401510C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckInitialToggled;

		// Token: 0x0401510D RID: 86285
		[Token(Token = "0x401510D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
