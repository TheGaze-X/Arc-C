using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024F5 RID: 9461
	[Token(Token = "0x20024F5")]
	public class AdvancedSelectorWithRandomTarget : AdvancedSelector
	{
		// Token: 0x0600F3B8 RID: 62392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3B8")]
		[Address(RVA = "0x6A0470", Offset = "0x69F070", VA = "0x1806A0470", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F3B9 RID: 62393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3B9")]
		[Address(RVA = "0x6A07B0", Offset = "0x69F3B0", VA = "0x1806A07B0", Slot = "22")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x0600F3BA RID: 62394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3BA")]
		[Address(RVA = "0x6A08C0", Offset = "0x69F4C0", VA = "0x1806A08C0")]
		public AdvancedSelectorWithRandomTarget()
		{
		}

		// Token: 0x0600F3BB RID: 62395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3BB")]
		[Address(RVA = "0x69A940", Offset = "0x699540", VA = "0x18069A940")]
		private void <>xLuaBaseProxy_OnPostFilter(List<Entity> P0)
		{
		}

		// Token: 0x0600F3BC RID: 62396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3BC")]
		[Address(RVA = "0x60C6F0", Offset = "0x60B2F0", VA = "0x18060C6F0")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x04010DD8 RID: 69080
		[Token(Token = "0x4010DD8")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private int _additionalNum;

		// Token: 0x04010DD9 RID: 69081
		[Token(Token = "0x4010DD9")]
		[FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private bool _randomSelectTarget;

		// Token: 0x04010DDA RID: 69082
		[Token(Token = "0x4010DDA")]
		[FieldOffset(Offset = "0xF8")]
		private FP m_prob;

		// Token: 0x04010DDB RID: 69083
		[Token(Token = "0x4010DDB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04010DDC RID: 69084
		[Token(Token = "0x4010DDC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04010DDD RID: 69085
		[Token(Token = "0x4010DDD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
