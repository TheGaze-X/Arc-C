using System;
using System.Collections;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020023CD RID: 9165
	[Token(Token = "0x20023CD")]
	public class LaserProjectile : LinkProjectile
	{
		// Token: 0x0600E92D RID: 59693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E92D")]
		[Address(RVA = "0x5F2F80", Offset = "0x5F1B80", VA = "0x1805F2F80", Slot = "54")]
		protected override IEnumerator DoLink(Entity target)
		{
			return null;
		}

		// Token: 0x0600E92E RID: 59694 RVA: 0x000554A0 File Offset: 0x000536A0
		[Token(Token = "0x600E92E")]
		[Address(RVA = "0x5F3050", Offset = "0x5F1C50", VA = "0x1805F3050", Slot = "48")]
		public override int GetMaxHitNum()
		{
			return 0;
		}

		// Token: 0x0600E92F RID: 59695 RVA: 0x000554B8 File Offset: 0x000536B8
		[Token(Token = "0x600E92F")]
		[Address(RVA = "0x5F2EF0", Offset = "0x5F1AF0", VA = "0x1805F2EF0", Slot = "53")]
		protected override bool CheckTargetAlreadyHitAndUpdate(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600E930 RID: 59696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E930")]
		[Address(RVA = "0x5F30B0", Offset = "0x5F1CB0", VA = "0x1805F30B0", Slot = "52")]
		protected override void OnHitTarget(Entity target)
		{
		}

		// Token: 0x0600E931 RID: 59697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E931")]
		[Address(RVA = "0x5F3330", Offset = "0x5F1F30", VA = "0x1805F3330")]
		public LaserProjectile()
		{
		}

		// Token: 0x0600E933 RID: 59699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E933")]
		[Address(RVA = "0x5F2CD0", Offset = "0x5F18D0", VA = "0x1805F2CD0")]
		private IEnumerator <>xLuaBaseProxy_DoLink(Entity P0)
		{
			return null;
		}

		// Token: 0x0600E934 RID: 59700 RVA: 0x000554D0 File Offset: 0x000536D0
		[Token(Token = "0x600E934")]
		[Address(RVA = "0x5F32C0", Offset = "0x5F1EC0", VA = "0x1805F32C0")]
		private int <>xLuaBaseProxy_GetMaxHitNum()
		{
			return 0;
		}

		// Token: 0x0600E935 RID: 59701 RVA: 0x000554E8 File Offset: 0x000536E8
		[Token(Token = "0x600E935")]
		[Address(RVA = "0x5F1760", Offset = "0x5F0360", VA = "0x1805F1760")]
		private bool <>xLuaBaseProxy_CheckTargetAlreadyHitAndUpdate(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x0600E936 RID: 59702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E936")]
		[Address(RVA = "0x5F3320", Offset = "0x5F1F20", VA = "0x1805F3320")]
		private void <>xLuaBaseProxy_OnHitTarget(Entity P0)
		{
		}

		// Token: 0x04010137 RID: 65847
		[Token(Token = "0x4010137")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		[Group("Laser")]
		private bool _unlimitedAlreadyHit;

		// Token: 0x04010138 RID: 65848
		[Token(Token = "0x4010138")]
		[FieldOffset(Offset = "0x1D1")]
		[SerializeField]
		[Group("Laser")]
		private bool _ignoreTargetDead;

		// Token: 0x04010139 RID: 65849
		[Token(Token = "0x4010139")]
		[FieldOffset(Offset = "0x1D2")]
		[SerializeField]
		[Group("Laser")]
		private bool _hitIgnoreAttached;

		// Token: 0x0401013A RID: 65850
		[Token(Token = "0x401013A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoLink;

		// Token: 0x0401013B RID: 65851
		[Token(Token = "0x401013B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetMaxHitNum;

		// Token: 0x0401013C RID: 65852
		[Token(Token = "0x401013C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckTargetAlreadyHitAndUpdate;

		// Token: 0x0401013D RID: 65853
		[Token(Token = "0x401013D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnHitTarget;

		// Token: 0x0401013E RID: 65854
		[Token(Token = "0x401013E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
