using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Skills
{
	// Token: 0x020028BA RID: 10426
	[Token(Token = "0x20028BA")]
	public class TrapEddSkillReadyEffect : ReadySkillEffect
	{
		// Token: 0x06011576 RID: 71030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011576")]
		[Address(RVA = "0x932E90", Offset = "0x931A90", VA = "0x180932E90", Slot = "14")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011577 RID: 71031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011577")]
		[Address(RVA = "0x933630", Offset = "0x932230", VA = "0x180933630")]
		public TrapEddSkillReadyEffect()
		{
		}

		// Token: 0x06011578 RID: 71032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011578")]
		[Address(RVA = "0x933620", Offset = "0x932220", VA = "0x180933620")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0401361A RID: 79386
		[Token(Token = "0x401361A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Entity.MountPointType startMountPoint;

		// Token: 0x0401361B RID: 79387
		[Token(Token = "0x401361B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0401361C RID: 79388
		[Token(Token = "0x401361C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
