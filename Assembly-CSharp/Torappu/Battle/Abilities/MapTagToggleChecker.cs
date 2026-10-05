using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B61 RID: 11105
	[Token(Token = "0x2002B61")]
	public class MapTagToggleChecker : ToggleablePassiveBuffAbility.Checker
	{
		// Token: 0x06012A48 RID: 76360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A48")]
		[Address(RVA = "0xAA1F80", Offset = "0xAA0B80", VA = "0x180AA1F80", Slot = "6")]
		protected override void LoadData(Blackboard blackboard)
		{
		}

		// Token: 0x06012A49 RID: 76361 RVA: 0x000723A8 File Offset: 0x000705A8
		[Token(Token = "0x6012A49")]
		[Address(RVA = "0xAA1F20", Offset = "0xAA0B20", VA = "0x180AA1F20", Slot = "5")]
		public override bool CheckInitialToggled()
		{
			return default(bool);
		}

		// Token: 0x06012A4A RID: 76362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A4A")]
		[Address(RVA = "0xAA1FE0", Offset = "0xAA0BE0", VA = "0x180AA1FE0", Slot = "9")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012A4B RID: 76363 RVA: 0x000723C0 File Offset: 0x000705C0
		[Token(Token = "0x6012A4B")]
		[Address(RVA = "0xAA2060", Offset = "0xAA0C60", VA = "0x180AA2060")]
		private bool _CheckToggled()
		{
			return default(bool);
		}

		// Token: 0x06012A4C RID: 76364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A4C")]
		[Address(RVA = "0xAA20F0", Offset = "0xAA0CF0", VA = "0x180AA20F0")]
		public MapTagToggleChecker()
		{
		}

		// Token: 0x06012A4D RID: 76365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A4D")]
		[Address(RVA = "0xA96850", Offset = "0xA95450", VA = "0x180A96850")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0401512A RID: 86314
		[Token(Token = "0x401512A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string[] _oneOfTags;

		// Token: 0x0401512B RID: 86315
		[Token(Token = "0x401512B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401512C RID: 86316
		[Token(Token = "0x401512C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckInitialToggled;

		// Token: 0x0401512D RID: 86317
		[Token(Token = "0x401512D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0401512E RID: 86318
		[Token(Token = "0x401512E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CheckToggled;

		// Token: 0x0401512F RID: 86319
		[Token(Token = "0x401512F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
