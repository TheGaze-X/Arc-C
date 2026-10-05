using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B5F RID: 11103
	[Token(Token = "0x2002B5F")]
	public class HpRatioToggleChecker : ToggleablePassiveBuffAbility.Checker
	{
		// Token: 0x1700290C RID: 10508
		// (get) Token: 0x06012A39 RID: 76345 RVA: 0x00072300 File Offset: 0x00070500
		[Token(Token = "0x1700290C")]
		public override float restoreDelay
		{
			[Token(Token = "0x6012A39")]
			[Address(RVA = "0xAA1B60", Offset = "0xAA0760", VA = "0x180AA1B60", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700290D RID: 10509
		// (get) Token: 0x06012A3A RID: 76346 RVA: 0x00072318 File Offset: 0x00070518
		[Token(Token = "0x1700290D")]
		private bool setInitialToggle
		{
			[Token(Token = "0x6012A3A")]
			[Address(RVA = "0xAA1BC0", Offset = "0xAA07C0", VA = "0x180AA1BC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012A3B RID: 76347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A3B")]
		[Address(RVA = "0xAA1690", Offset = "0xAA0290", VA = "0x180AA1690", Slot = "6")]
		protected override void LoadData(Blackboard blackboard)
		{
		}

		// Token: 0x06012A3C RID: 76348 RVA: 0x00072330 File Offset: 0x00070530
		[Token(Token = "0x6012A3C")]
		[Address(RVA = "0xAA1620", Offset = "0xAA0220", VA = "0x180AA1620", Slot = "5")]
		public override bool CheckInitialToggled()
		{
			return default(bool);
		}

		// Token: 0x06012A3D RID: 76349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A3D")]
		[Address(RVA = "0xAA17A0", Offset = "0xAA03A0", VA = "0x180AA17A0", Slot = "9")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012A3E RID: 76350 RVA: 0x00072348 File Offset: 0x00070548
		[Token(Token = "0x6012A3E")]
		[Address(RVA = "0xAA1870", Offset = "0xAA0470", VA = "0x180AA1870")]
		private bool _CheckCondition()
		{
			return default(bool);
		}

		// Token: 0x06012A3F RID: 76351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A3F")]
		[Address(RVA = "0xAA1AB0", Offset = "0xAA06B0", VA = "0x180AA1AB0")]
		public HpRatioToggleChecker()
		{
		}

		// Token: 0x06012A40 RID: 76352 RVA: 0x00072360 File Offset: 0x00070560
		[Token(Token = "0x6012A40")]
		[Address(RVA = "0xA9B660", Offset = "0xA9A260", VA = "0x180A9B660")]
		private float <>xLuaBaseProxy_get_restoreDelay()
		{
			return 0f;
		}

		// Token: 0x06012A41 RID: 76353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A41")]
		[Address(RVA = "0xA96850", Offset = "0xA95450", VA = "0x180A96850")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0401510E RID: 86286
		[Token(Token = "0x401510E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _minHpRatio;

		// Token: 0x0401510F RID: 86287
		[Token(Token = "0x401510F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _maxHpRatio;

		// Token: 0x04015110 RID: 86288
		[Token(Token = "0x4015110")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _useLTForMax;

		// Token: 0x04015111 RID: 86289
		[Token(Token = "0x4015111")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _restoreDelay;

		// Token: 0x04015112 RID: 86290
		[Token(Token = "0x4015112")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _toggleOnce;

		// Token: 0x04015113 RID: 86291
		[Token(Token = "0x4015113")]
		[FieldOffset(Offset = "0x31")]
		[SerializeField]
		private bool _setInitialToggle;

		// Token: 0x04015114 RID: 86292
		[Token(Token = "0x4015114")]
		[FieldOffset(Offset = "0x32")]
		[SerializeField]
		[Inspect("setInitialToggle")]
		private bool _initialToggle;

		// Token: 0x04015115 RID: 86293
		[Token(Token = "0x4015115")]
		[FieldOffset(Offset = "0x33")]
		[SerializeField]
		private bool _loadMinHpRatioFromBlackboard;

		// Token: 0x04015116 RID: 86294
		[Token(Token = "0x4015116")]
		[FieldOffset(Offset = "0x34")]
		private float m_minHpRatio;

		// Token: 0x04015117 RID: 86295
		[Token(Token = "0x4015117")]
		[FieldOffset(Offset = "0x38")]
		private float m_maxHpRatio;

		// Token: 0x04015118 RID: 86296
		[Token(Token = "0x4015118")]
		[FieldOffset(Offset = "0x3C")]
		private float m_restoreDelay;

		// Token: 0x04015119 RID: 86297
		[Token(Token = "0x4015119")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasToggleChanged;

		// Token: 0x0401511A RID: 86298
		[Token(Token = "0x401511A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_restoreDelay;

		// Token: 0x0401511B RID: 86299
		[Token(Token = "0x401511B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_setInitialToggle;

		// Token: 0x0401511C RID: 86300
		[Token(Token = "0x401511C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401511D RID: 86301
		[Token(Token = "0x401511D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckInitialToggled;

		// Token: 0x0401511E RID: 86302
		[Token(Token = "0x401511E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0401511F RID: 86303
		[Token(Token = "0x401511F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CheckCondition;

		// Token: 0x04015120 RID: 86304
		[Token(Token = "0x4015120")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
