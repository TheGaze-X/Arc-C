using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B67 RID: 11111
	[Token(Token = "0x2002B67")]
	public class AirSupportReachExitChecker : ToggleablePassiveBuffAbility.Checker
	{
		// Token: 0x1700290E RID: 10510
		// (get) Token: 0x06012A72 RID: 76402 RVA: 0x00072510 File Offset: 0x00070710
		[Token(Token = "0x1700290E")]
		public override float restoreDelay
		{
			[Token(Token = "0x6012A72")]
			[Address(RVA = "0xA9C270", Offset = "0xA9AE70", VA = "0x180A9C270", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06012A73 RID: 76403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A73")]
		[Address(RVA = "0xA9BDF0", Offset = "0xA9A9F0", VA = "0x180A9BDF0", Slot = "6")]
		protected override void LoadData(Blackboard blackboard)
		{
		}

		// Token: 0x06012A74 RID: 76404 RVA: 0x00072528 File Offset: 0x00070728
		[Token(Token = "0x6012A74")]
		[Address(RVA = "0xA9BD90", Offset = "0xA9A990", VA = "0x180A9BD90", Slot = "5")]
		public override bool CheckInitialToggled()
		{
			return default(bool);
		}

		// Token: 0x06012A75 RID: 76405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A75")]
		[Address(RVA = "0xA9BEA0", Offset = "0xA9AAA0", VA = "0x180A9BEA0", Slot = "9")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012A76 RID: 76406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A76")]
		[Address(RVA = "0xA9C1C0", Offset = "0xA9ADC0", VA = "0x180A9C1C0")]
		public AirSupportReachExitChecker()
		{
		}

		// Token: 0x06012A77 RID: 76407 RVA: 0x00072540 File Offset: 0x00070740
		[Token(Token = "0x6012A77")]
		[Address(RVA = "0xA9B660", Offset = "0xA9A260", VA = "0x180A9B660")]
		private float <>xLuaBaseProxy_get_restoreDelay()
		{
			return 0f;
		}

		// Token: 0x06012A78 RID: 76408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A78")]
		[Address(RVA = "0xA96850", Offset = "0xA95450", VA = "0x180A96850")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0401515E RID: 86366
		[Token(Token = "0x401515E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _isInitToggled;

		// Token: 0x0401515F RID: 86367
		[Token(Token = "0x401515F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _restoreDelay;

		// Token: 0x04015160 RID: 86368
		[Token(Token = "0x4015160")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _toggleWhenReached;

		// Token: 0x04015161 RID: 86369
		[Token(Token = "0x4015161")]
		[FieldOffset(Offset = "0x2C")]
		private float m_restoreDelay;

		// Token: 0x04015162 RID: 86370
		[Token(Token = "0x4015162")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_restoreDelay;

		// Token: 0x04015163 RID: 86371
		[Token(Token = "0x4015163")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04015164 RID: 86372
		[Token(Token = "0x4015164")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckInitialToggled;

		// Token: 0x04015165 RID: 86373
		[Token(Token = "0x4015165")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04015166 RID: 86374
		[Token(Token = "0x4015166")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
