using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200251F RID: 9503
	[Token(Token = "0x200251F")]
	public class AdvancedProjectileSelector : RangeSelector
	{
		// Token: 0x17001FFD RID: 8189
		// (get) Token: 0x0600F536 RID: 62774 RVA: 0x0005AFF0 File Offset: 0x000591F0
		[Token(Token = "0x17001FFD")]
		public override SideType targetSide
		{
			[Token(Token = "0x600F536")]
			[Address(RVA = "0x6B35C0", Offset = "0x6B21C0", VA = "0x1806B35C0", Slot = "25")]
			get
			{
				return SideType.NONE;
			}
		}

		// Token: 0x17001FFE RID: 8190
		// (get) Token: 0x0600F537 RID: 62775 RVA: 0x0005B008 File Offset: 0x00059208
		[Token(Token = "0x17001FFE")]
		public override MotionMask targetMotion
		{
			[Token(Token = "0x600F537")]
			[Address(RVA = "0x6B3560", Offset = "0x6B2160", VA = "0x1806B3560", Slot = "26")]
			get
			{
				return MotionMask.NONE;
			}
		}

		// Token: 0x17001FFF RID: 8191
		// (get) Token: 0x0600F538 RID: 62776 RVA: 0x0005B020 File Offset: 0x00059220
		[Token(Token = "0x17001FFF")]
		public override EntityCategory targetCategory
		{
			[Token(Token = "0x600F538")]
			[Address(RVA = "0x6B3500", Offset = "0x6B2100", VA = "0x1806B3500", Slot = "27")]
			get
			{
				return EntityCategory.NONE;
			}
		}

		// Token: 0x17002000 RID: 8192
		// (get) Token: 0x0600F539 RID: 62777 RVA: 0x0005B038 File Offset: 0x00059238
		[Token(Token = "0x17002000")]
		public override bool ignoreTargetFree
		{
			[Token(Token = "0x600F539")]
			[Address(RVA = "0x6B34A0", Offset = "0x6B20A0", VA = "0x1806B34A0", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F53A RID: 62778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F53A")]
		[Address(RVA = "0x6B3210", Offset = "0x6B1E10", VA = "0x1806B3210", Slot = "12")]
		public override void Reset(Entity owner, Ability ability, [Optional] Func<Entity, bool> validator)
		{
		}

		// Token: 0x0600F53B RID: 62779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F53B")]
		[Address(RVA = "0x6B31B0", Offset = "0x6B1DB0", VA = "0x1806B31B0", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F53C RID: 62780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F53C")]
		[Address(RVA = "0x6B3150", Offset = "0x6B1D50", VA = "0x1806B3150", Slot = "38")]
		protected override void OnPostFilter(List<Tile> candidates)
		{
		}

		// Token: 0x0600F53D RID: 62781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F53D")]
		[Address(RVA = "0x6B2DA0", Offset = "0x6B19A0", VA = "0x1806B2DA0", Slot = "21")]
		public override List<Projectile> FindProjectiles_CLEAR(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F53E RID: 62782 RVA: 0x0005B050 File Offset: 0x00059250
		[Token(Token = "0x600F53E")]
		[Address(RVA = "0x6B3320", Offset = "0x6B1F20", VA = "0x1806B3320", Slot = "40")]
		protected virtual bool _ValidateProjectile(Projectile projectile)
		{
			return default(bool);
		}

		// Token: 0x0600F53F RID: 62783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F53F")]
		[Address(RVA = "0x6B33E0", Offset = "0x6B1FE0", VA = "0x1806B33E0")]
		public AdvancedProjectileSelector()
		{
		}

		// Token: 0x0600F540 RID: 62784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F540")]
		[Address(RVA = "0x6A2DA0", Offset = "0x6A19A0", VA = "0x1806A2DA0")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1, Func<Entity, bool> P2)
		{
		}

		// Token: 0x0600F541 RID: 62785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F541")]
		[Address(RVA = "0x6B3310", Offset = "0x6B1F10", VA = "0x1806B3310")]
		private List<Projectile> <>xLuaBaseProxy_FindProjectiles_CLEAR(Vector2 P0)
		{
			return null;
		}

		// Token: 0x04010FD3 RID: 69587
		[Token(Token = "0x4010FD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private SideType _targetSide;

		// Token: 0x04010FD4 RID: 69588
		[Token(Token = "0x4010FD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private SideType m_sideTypeMask;

		// Token: 0x04010FD5 RID: 69589
		[Token(Token = "0x4010FD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private List<Projectile> m_projectileCache;

		// Token: 0x04010FD6 RID: 69590
		[Token(Token = "0x4010FD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_targetSide;

		// Token: 0x04010FD7 RID: 69591
		[Token(Token = "0x4010FD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_targetMotion;

		// Token: 0x04010FD8 RID: 69592
		[Token(Token = "0x4010FD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_targetCategory;

		// Token: 0x04010FD9 RID: 69593
		[Token(Token = "0x4010FD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_ignoreTargetFree;

		// Token: 0x04010FDA RID: 69594
		[Token(Token = "0x4010FDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04010FDB RID: 69595
		[Token(Token = "0x4010FDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04010FDC RID: 69596
		[Token(Token = "0x4010FDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix1_OnPostFilter;

		// Token: 0x04010FDD RID: 69597
		[Token(Token = "0x4010FDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_FindProjectiles_CLEAR;

		// Token: 0x04010FDE RID: 69598
		[Token(Token = "0x4010FDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ValidateProjectile;

		// Token: 0x04010FDF RID: 69599
		[Token(Token = "0x4010FDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
