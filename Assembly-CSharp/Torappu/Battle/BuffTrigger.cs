using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200255C RID: 9564
	[Token(Token = "0x200255C")]
	public class BuffTrigger : TargetTrigger
	{
		// Token: 0x17002059 RID: 8281
		// (get) Token: 0x0600F6DC RID: 63196 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F6DD RID: 63197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002059")]
		public Entity owner
		{
			[Token(Token = "0x600F6DC")]
			[Address(RVA = "0x6F3550", Offset = "0x6F2150", VA = "0x1806F3550")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600F6DD")]
			[Address(RVA = "0x6F3610", Offset = "0x6F2210", VA = "0x1806F3610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700205A RID: 8282
		// (get) Token: 0x0600F6DE RID: 63198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700205A")]
		public override Entity target
		{
			[Token(Token = "0x600F6DE")]
			[Address(RVA = "0x6F35B0", Offset = "0x6F21B0", VA = "0x1806F35B0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700205B RID: 8283
		// (get) Token: 0x0600F6DF RID: 63199 RVA: 0x0005C088 File Offset: 0x0005A288
		[Token(Token = "0x1700205B")]
		public override bool isReadyToTrig
		{
			[Token(Token = "0x600F6DF")]
			[Address(RVA = "0x6F34B0", Offset = "0x6F20B0", VA = "0x1806F34B0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F6E0 RID: 63200 RVA: 0x0005C0A0 File Offset: 0x0005A2A0
		[Token(Token = "0x600F6E0")]
		[Address(RVA = "0x6F3170", Offset = "0x6F1D70", VA = "0x1806F3170")]
		private bool CheckReadyToTrig()
		{
			return default(bool);
		}

		// Token: 0x0600F6E1 RID: 63201 RVA: 0x0005C0B8 File Offset: 0x0005A2B8
		[Token(Token = "0x600F6E1")]
		[Address(RVA = "0x6F2F10", Offset = "0x6F1B10", VA = "0x1806F2F10")]
		private bool CheckBuffs(string[] buffKeys, BuffTrigger.CheckType checkType)
		{
			return default(bool);
		}

		// Token: 0x0600F6E2 RID: 63202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F6E2")]
		[Address(RVA = "0x6F3270", Offset = "0x6F1E70", VA = "0x1806F3270", Slot = "12")]
		public override void Reset(Entity owner, Ability ability)
		{
		}

		// Token: 0x0600F6E3 RID: 63203 RVA: 0x0005C0D0 File Offset: 0x0005A2D0
		[Token(Token = "0x600F6E3")]
		[Address(RVA = "0x6F3370", Offset = "0x6F1F70", VA = "0x1806F3370", Slot = "13")]
		public override bool Search(bool force)
		{
			return default(bool);
		}

		// Token: 0x0600F6E4 RID: 63204 RVA: 0x0005C0E8 File Offset: 0x0005A2E8
		[Token(Token = "0x600F6E4")]
		[Address(RVA = "0x6F31E0", Offset = "0x6F1DE0", VA = "0x1806F31E0", Slot = "14")]
		public override bool CheckTargetIn(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F6E5 RID: 63205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F6E5")]
		[Address(RVA = "0x6F3410", Offset = "0x6F2010", VA = "0x1806F3410")]
		public BuffTrigger()
		{
		}

		// Token: 0x0600F6E6 RID: 63206 RVA: 0x0005C100 File Offset: 0x0005A300
		[Token(Token = "0x600F6E6")]
		[Address(RVA = "0x6EF7F0", Offset = "0x6EE3F0", VA = "0x1806EF7F0")]
		private bool <>xLuaBaseProxy_get_isReadyToTrig()
		{
			return default(bool);
		}

		// Token: 0x0600F6E7 RID: 63207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F6E7")]
		[Address(RVA = "0x6F3400", Offset = "0x6F2000", VA = "0x1806F3400")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1)
		{
		}

		// Token: 0x04011231 RID: 70193
		[Token(Token = "0x4011231")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string[] _buffKeys;

		// Token: 0x04011232 RID: 70194
		[Token(Token = "0x4011232")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BuffTrigger.CheckType _checkType;

		// Token: 0x04011234 RID: 70196
		[Token(Token = "0x4011234")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_owner;

		// Token: 0x04011235 RID: 70197
		[Token(Token = "0x4011235")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_owner;

		// Token: 0x04011236 RID: 70198
		[Token(Token = "0x4011236")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_target;

		// Token: 0x04011237 RID: 70199
		[Token(Token = "0x4011237")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isReadyToTrig;

		// Token: 0x04011238 RID: 70200
		[Token(Token = "0x4011238")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckReadyToTrig;

		// Token: 0x04011239 RID: 70201
		[Token(Token = "0x4011239")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CheckBuffs;

		// Token: 0x0401123A RID: 70202
		[Token(Token = "0x401123A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0401123B RID: 70203
		[Token(Token = "0x401123B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Search;

		// Token: 0x0401123C RID: 70204
		[Token(Token = "0x401123C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckTargetIn;

		// Token: 0x0401123D RID: 70205
		[Token(Token = "0x401123D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200255D RID: 9565
		[Token(Token = "0x200255D")]
		[Serializable]
		public enum CheckType
		{
			// Token: 0x0401123F RID: 70207
			[Token(Token = "0x401123F")]
			No,
			// Token: 0x04011240 RID: 70208
			[Token(Token = "0x4011240")]
			Any,
			// Token: 0x04011241 RID: 70209
			[Token(Token = "0x4011241")]
			All
		}
	}
}
