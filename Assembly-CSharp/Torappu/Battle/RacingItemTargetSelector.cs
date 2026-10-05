using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020023EB RID: 9195
	[Token(Token = "0x20023EB")]
	public class RacingItemTargetSelector : AdvancedSelector
	{
		// Token: 0x0600EAD5 RID: 60117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAD5")]
		[Address(RVA = "0x60C5E0", Offset = "0x60B1E0", VA = "0x18060C5E0", Slot = "22")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x0600EAD6 RID: 60118 RVA: 0x00056070 File Offset: 0x00054270
		[Token(Token = "0x600EAD6")]
		[Address(RVA = "0x60C710", Offset = "0x60B310", VA = "0x18060C710", Slot = "16")]
		protected override bool ValidateTarget(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600EAD7 RID: 60119 RVA: 0x00056088 File Offset: 0x00054288
		[Token(Token = "0x600EAD7")]
		[Address(RVA = "0x60C810", Offset = "0x60B410", VA = "0x18060C810")]
		private bool _ValidateTargetInArc(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600EAD8 RID: 60120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAD8")]
		[Address(RVA = "0x60CA10", Offset = "0x60B610", VA = "0x18060CA10")]
		public RacingItemTargetSelector()
		{
		}

		// Token: 0x0600EAD9 RID: 60121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EAD9")]
		[Address(RVA = "0x60C6F0", Offset = "0x60B2F0", VA = "0x18060C6F0")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x0600EADA RID: 60122 RVA: 0x000560A0 File Offset: 0x000542A0
		[Token(Token = "0x600EADA")]
		[Address(RVA = "0x60C700", Offset = "0x60B300", VA = "0x18060C700")]
		private bool <>xLuaBaseProxy_ValidateTarget(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x04010354 RID: 66388
		[Token(Token = "0x4010354")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private float _maxDegree;

		// Token: 0x04010355 RID: 66389
		[Token(Token = "0x4010355")]
		[FieldOffset(Offset = "0xF8")]
		private FP m_maxDegree;

		// Token: 0x04010356 RID: 66390
		[Token(Token = "0x4010356")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04010357 RID: 66391
		[Token(Token = "0x4010357")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ValidateTarget;

		// Token: 0x04010358 RID: 66392
		[Token(Token = "0x4010358")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ValidateTargetInArc;

		// Token: 0x04010359 RID: 66393
		[Token(Token = "0x4010359")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
