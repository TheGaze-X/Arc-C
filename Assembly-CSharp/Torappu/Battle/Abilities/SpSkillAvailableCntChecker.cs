using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B69 RID: 11113
	[Token(Token = "0x2002B69")]
	public class SpSkillAvailableCntChecker : ToggleablePassiveBuffAbility.Checker
	{
		// Token: 0x17002910 RID: 10512
		// (get) Token: 0x06012A81 RID: 76417 RVA: 0x000725B8 File Offset: 0x000707B8
		[Token(Token = "0x17002910")]
		public override float restoreDelay
		{
			[Token(Token = "0x6012A81")]
			[Address(RVA = "0xAA7550", Offset = "0xAA6150", VA = "0x180AA7550", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06012A82 RID: 76418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A82")]
		[Address(RVA = "0xAA70F0", Offset = "0xAA5CF0", VA = "0x180AA70F0", Slot = "6")]
		protected override void LoadData(Blackboard blackboard)
		{
		}

		// Token: 0x06012A83 RID: 76419 RVA: 0x000725D0 File Offset: 0x000707D0
		[Token(Token = "0x6012A83")]
		[Address(RVA = "0xAA7090", Offset = "0xAA5C90", VA = "0x180AA7090", Slot = "5")]
		public override bool CheckInitialToggled()
		{
			return default(bool);
		}

		// Token: 0x06012A84 RID: 76420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A84")]
		[Address(RVA = "0xAA71D0", Offset = "0xAA5DD0", VA = "0x180AA71D0", Slot = "9")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012A85 RID: 76421 RVA: 0x000725E8 File Offset: 0x000707E8
		[Token(Token = "0x6012A85")]
		[Address(RVA = "0xAA7250", Offset = "0xAA5E50", VA = "0x180AA7250")]
		private bool _CheckCondition()
		{
			return default(bool);
		}

		// Token: 0x06012A86 RID: 76422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A86")]
		[Address(RVA = "0xAA74B0", Offset = "0xAA60B0", VA = "0x180AA74B0")]
		public SpSkillAvailableCntChecker()
		{
		}

		// Token: 0x06012A87 RID: 76423 RVA: 0x00072600 File Offset: 0x00070800
		[Token(Token = "0x6012A87")]
		[Address(RVA = "0xA9B660", Offset = "0xA9A260", VA = "0x180A9B660")]
		private float <>xLuaBaseProxy_get_restoreDelay()
		{
			return 0f;
		}

		// Token: 0x06012A88 RID: 76424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A88")]
		[Address(RVA = "0xA96850", Offset = "0xA95450", VA = "0x180A96850")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04015173 RID: 86387
		[Token(Token = "0x4015173")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _compCnt;

		// Token: 0x04015174 RID: 86388
		[Token(Token = "0x4015174")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _restoreDelay;

		// Token: 0x04015175 RID: 86389
		[Token(Token = "0x4015175")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _waitForSkillFinished;

		// Token: 0x04015176 RID: 86390
		[Token(Token = "0x4015176")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private CompareType _condType;

		// Token: 0x04015177 RID: 86391
		[Token(Token = "0x4015177")]
		[FieldOffset(Offset = "0x30")]
		private float m_compCnt;

		// Token: 0x04015178 RID: 86392
		[Token(Token = "0x4015178")]
		[FieldOffset(Offset = "0x34")]
		private float m_restoreDelay;

		// Token: 0x04015179 RID: 86393
		[Token(Token = "0x4015179")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_restoreDelay;

		// Token: 0x0401517A RID: 86394
		[Token(Token = "0x401517A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401517B RID: 86395
		[Token(Token = "0x401517B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckInitialToggled;

		// Token: 0x0401517C RID: 86396
		[Token(Token = "0x401517C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0401517D RID: 86397
		[Token(Token = "0x401517D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckCondition;

		// Token: 0x0401517E RID: 86398
		[Token(Token = "0x401517E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
