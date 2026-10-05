using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BD7 RID: 11223
	[Token(Token = "0x2002BD7")]
	public class DuplicateBlackboardVar : AbilityStandard.Behaviour
	{
		// Token: 0x06012F38 RID: 77624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F38")]
		[Address(RVA = "0xAE1B80", Offset = "0xAE0780", VA = "0x180AE1B80", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06012F39 RID: 77625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F39")]
		[Address(RVA = "0xAE1C60", Offset = "0xAE0860", VA = "0x180AE1C60")]
		public DuplicateBlackboardVar()
		{
		}

		// Token: 0x06012F3A RID: 77626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F3A")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x04015641 RID: 87617
		[Token(Token = "0x4015641")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _sourceVar;

		// Token: 0x04015642 RID: 87618
		[Token(Token = "0x4015642")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _targetVar;

		// Token: 0x04015643 RID: 87619
		[Token(Token = "0x4015643")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x04015644 RID: 87620
		[Token(Token = "0x4015644")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
