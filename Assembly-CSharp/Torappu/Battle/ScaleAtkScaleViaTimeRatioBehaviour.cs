using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020023C9 RID: 9161
	[Token(Token = "0x20023C9")]
	public class ScaleAtkScaleViaTimeRatioBehaviour : Projectile.Behaviour
	{
		// Token: 0x0600E90A RID: 59658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E90A")]
		[Address(RVA = "0x600380", Offset = "0x5FEF80", VA = "0x180600380", Slot = "10")]
		public override void OnHitTarget(Entity target)
		{
		}

		// Token: 0x0600E90B RID: 59659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E90B")]
		[Address(RVA = "0x600790", Offset = "0x5FF390", VA = "0x180600790")]
		private void _UpdateScaledValue()
		{
		}

		// Token: 0x0600E90C RID: 59660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E90C")]
		[Address(RVA = "0x600440", Offset = "0x5FF040", VA = "0x180600440")]
		private void _AssignDynamicValue(FP dynamicValue)
		{
		}

		// Token: 0x0600E90D RID: 59661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E90D")]
		[Address(RVA = "0x600B60", Offset = "0x5FF760", VA = "0x180600B60")]
		public ScaleAtkScaleViaTimeRatioBehaviour()
		{
		}

		// Token: 0x0600E90E RID: 59662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E90E")]
		[Address(RVA = "0x5F0810", Offset = "0x5EF410", VA = "0x1805F0810")]
		private void <>xLuaBaseProxy_OnHitTarget(Entity P0)
		{
		}

		// Token: 0x04010108 RID: 65800
		[Token(Token = "0x4010108")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public string _minKey;

		// Token: 0x04010109 RID: 65801
		[Token(Token = "0x4010109")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public string _maxKey;

		// Token: 0x0401010A RID: 65802
		[Token(Token = "0x401010A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		public AnimationCurve _scaleCurve;

		// Token: 0x0401010B RID: 65803
		[Token(Token = "0x401010B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnHitTarget;

		// Token: 0x0401010C RID: 65804
		[Token(Token = "0x401010C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateScaledValue;

		// Token: 0x0401010D RID: 65805
		[Token(Token = "0x401010D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__AssignDynamicValue;

		// Token: 0x0401010E RID: 65806
		[Token(Token = "0x401010E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
