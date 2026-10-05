using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B5A RID: 11098
	[Token(Token = "0x2002B5A")]
	public class EnemyStatusToggleChecker : ToggleablePassiveBuffAbility.Checker
	{
		// Token: 0x1700290B RID: 10507
		// (get) Token: 0x06012A15 RID: 76309 RVA: 0x000721F8 File Offset: 0x000703F8
		[Token(Token = "0x1700290B")]
		public override float restoreDelay
		{
			[Token(Token = "0x6012A15")]
			[Address(RVA = "0xAA0120", Offset = "0xA9ED20", VA = "0x180AA0120", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06012A16 RID: 76310 RVA: 0x00072210 File Offset: 0x00070410
		[Token(Token = "0x6012A16")]
		[Address(RVA = "0xA9FCA0", Offset = "0xA9E8A0", VA = "0x180A9FCA0", Slot = "5")]
		public override bool CheckInitialToggled()
		{
			return default(bool);
		}

		// Token: 0x06012A17 RID: 76311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A17")]
		[Address(RVA = "0xA9FD00", Offset = "0xA9E900", VA = "0x180A9FD00", Slot = "6")]
		protected override void LoadData(Blackboard blackboard)
		{
		}

		// Token: 0x06012A18 RID: 76312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A18")]
		[Address(RVA = "0xA9FDB0", Offset = "0xA9E9B0", VA = "0x180A9FDB0", Slot = "7")]
		public override void OnAttached()
		{
		}

		// Token: 0x06012A19 RID: 76313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A19")]
		[Address(RVA = "0xA9FF40", Offset = "0xA9EB40", VA = "0x180A9FF40", Slot = "9")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012A1A RID: 76314 RVA: 0x00072228 File Offset: 0x00070428
		[Token(Token = "0x6012A1A")]
		[Address(RVA = "0xA9FFC0", Offset = "0xA9EBC0", VA = "0x180A9FFC0")]
		private bool _CheckCondition()
		{
			return default(bool);
		}

		// Token: 0x06012A1B RID: 76315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A1B")]
		[Address(RVA = "0xAA0080", Offset = "0xA9EC80", VA = "0x180AA0080")]
		public EnemyStatusToggleChecker()
		{
		}

		// Token: 0x06012A1C RID: 76316 RVA: 0x00072240 File Offset: 0x00070440
		[Token(Token = "0x6012A1C")]
		[Address(RVA = "0xA9B660", Offset = "0xA9A260", VA = "0x180A9B660")]
		private float <>xLuaBaseProxy_get_restoreDelay()
		{
			return 0f;
		}

		// Token: 0x06012A1D RID: 76317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A1D")]
		[Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
		private void <>xLuaBaseProxy_OnAttached()
		{
		}

		// Token: 0x06012A1E RID: 76318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012A1E")]
		[Address(RVA = "0xA96850", Offset = "0xA95450", VA = "0x180A96850")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x040150DF RID: 86239
		[Token(Token = "0x40150DF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _checkIsMovingBySelf;

		// Token: 0x040150E0 RID: 86240
		[Token(Token = "0x40150E0")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _restoreDelay;

		// Token: 0x040150E1 RID: 86241
		[Token(Token = "0x40150E1")]
		[FieldOffset(Offset = "0x28")]
		private Enemy m_enemy;

		// Token: 0x040150E2 RID: 86242
		[Token(Token = "0x40150E2")]
		[FieldOffset(Offset = "0x30")]
		private float m_restoreDelay;

		// Token: 0x040150E3 RID: 86243
		[Token(Token = "0x40150E3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_restoreDelay;

		// Token: 0x040150E4 RID: 86244
		[Token(Token = "0x40150E4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckInitialToggled;

		// Token: 0x040150E5 RID: 86245
		[Token(Token = "0x40150E5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040150E6 RID: 86246
		[Token(Token = "0x40150E6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnAttached;

		// Token: 0x040150E7 RID: 86247
		[Token(Token = "0x40150E7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040150E8 RID: 86248
		[Token(Token = "0x40150E8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CheckCondition;

		// Token: 0x040150E9 RID: 86249
		[Token(Token = "0x40150E9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
