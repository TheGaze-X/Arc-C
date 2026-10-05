using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200258D RID: 9613
	[Token(Token = "0x200258D")]
	public class SingleIdTargetValidator : TargetValidator
	{
		// Token: 0x0600F7DB RID: 63451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7DB")]
		[Address(RVA = "0x714C60", Offset = "0x713860", VA = "0x180714C60", Slot = "4")]
		public override void SetData(Entity owner, Blackboard blackboard, bool ignoreTargetSide)
		{
		}

		// Token: 0x0600F7DC RID: 63452 RVA: 0x0005CC70 File Offset: 0x0005AE70
		[Token(Token = "0x600F7DC")]
		[Address(RVA = "0x714D50", Offset = "0x713950", VA = "0x180714D50", Slot = "5")]
		public override bool Validate(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F7DD RID: 63453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7DD")]
		[Address(RVA = "0x714E00", Offset = "0x713A00", VA = "0x180714E00")]
		public SingleIdTargetValidator()
		{
		}

		// Token: 0x0600F7DE RID: 63454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7DE")]
		[Address(RVA = "0x6EFB90", Offset = "0x6EE790", VA = "0x1806EFB90")]
		private void <>xLuaBaseProxy_SetData(Entity P0, Blackboard P1, bool P2)
		{
		}

		// Token: 0x0600F7DF RID: 63455 RVA: 0x0005CC88 File Offset: 0x0005AE88
		[Token(Token = "0x600F7DF")]
		[Address(RVA = "0x6EEA80", Offset = "0x6ED680", VA = "0x1806EEA80")]
		private bool <>xLuaBaseProxy_Validate(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x04011371 RID: 70513
		[Token(Token = "0x4011371")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private string _targetId;

		// Token: 0x04011372 RID: 70514
		[Token(Token = "0x4011372")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private bool _reverse;

		// Token: 0x04011373 RID: 70515
		[Token(Token = "0x4011373")]
		[FieldOffset(Offset = "0x99")]
		[SerializeField]
		private bool _loadFromBlackboard;

		// Token: 0x04011374 RID: 70516
		[Token(Token = "0x4011374")]
		[FieldOffset(Offset = "0xA0")]
		private string m_targetId;

		// Token: 0x04011375 RID: 70517
		[Token(Token = "0x4011375")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04011376 RID: 70518
		[Token(Token = "0x4011376")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Validate;

		// Token: 0x04011377 RID: 70519
		[Token(Token = "0x4011377")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
