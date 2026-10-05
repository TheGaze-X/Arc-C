using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020023CF RID: 9167
	[Token(Token = "0x20023CF")]
	public class LassoProjectile : LinkProjectile
	{
		// Token: 0x0600E93D RID: 59709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E93D")]
		[Address(RVA = "0x5F3390", Offset = "0x5F1F90", VA = "0x1805F3390", Slot = "54")]
		protected override IEnumerator DoLink(Entity target)
		{
			return null;
		}

		// Token: 0x0600E93E RID: 59710 RVA: 0x00055518 File Offset: 0x00053718
		[Token(Token = "0x600E93E")]
		[Address(RVA = "0x5F3890", Offset = "0x5F2490", VA = "0x1805F3890")]
		private bool _ValidForLassoProjectile()
		{
			return default(bool);
		}

		// Token: 0x0600E93F RID: 59711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E93F")]
		[Address(RVA = "0x5F3460", Offset = "0x5F2060", VA = "0x1805F3460", Slot = "52")]
		protected override void OnHitTarget(Entity target)
		{
		}

		// Token: 0x0600E940 RID: 59712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E940")]
		[Address(RVA = "0x5F35D0", Offset = "0x5F21D0", VA = "0x1805F35D0", Slot = "51")]
		protected override void OnProjectileStop()
		{
		}

		// Token: 0x0600E941 RID: 59713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E941")]
		[Address(RVA = "0x5F3730", Offset = "0x5F2330", VA = "0x1805F3730")]
		private void _OnRallyPointLikeSwitch(object arg)
		{
		}

		// Token: 0x0600E942 RID: 59714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E942")]
		[Address(RVA = "0x5F3AB0", Offset = "0x5F26B0", VA = "0x1805F3AB0")]
		public LassoProjectile()
		{
		}

		// Token: 0x0600E944 RID: 59716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E944")]
		[Address(RVA = "0x5F2CD0", Offset = "0x5F18D0", VA = "0x1805F2CD0")]
		private IEnumerator <>xLuaBaseProxy_DoLink(Entity P0)
		{
			return null;
		}

		// Token: 0x0600E945 RID: 59717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E945")]
		[Address(RVA = "0x5F3320", Offset = "0x5F1F20", VA = "0x1805F3320")]
		private void <>xLuaBaseProxy_OnHitTarget(Entity P0)
		{
		}

		// Token: 0x0600E946 RID: 59718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E946")]
		[Address(RVA = "0x5F2CF0", Offset = "0x5F18F0", VA = "0x1805F2CF0")]
		private void <>xLuaBaseProxy_OnProjectileStop()
		{
		}

		// Token: 0x04010143 RID: 65859
		[Token(Token = "0x4010143")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		private bool _keepWhenRallyPointLikeSwitch;

		// Token: 0x04010144 RID: 65860
		[Token(Token = "0x4010144")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoLink;

		// Token: 0x04010145 RID: 65861
		[Token(Token = "0x4010145")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ValidForLassoProjectile;

		// Token: 0x04010146 RID: 65862
		[Token(Token = "0x4010146")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnHitTarget;

		// Token: 0x04010147 RID: 65863
		[Token(Token = "0x4010147")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x04010148 RID: 65864
		[Token(Token = "0x4010148")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnRallyPointLikeSwitch;

		// Token: 0x04010149 RID: 65865
		[Token(Token = "0x4010149")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
