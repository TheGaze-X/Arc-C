using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029F2 RID: 10738
	[Token(Token = "0x20029F2")]
	public class Thorn2S2AdvancedMovement : AdvancedMovement
	{
		// Token: 0x17002747 RID: 10055
		// (get) Token: 0x06011D04 RID: 72964 RVA: 0x0006D170 File Offset: 0x0006B370
		[Token(Token = "0x17002747")]
		public override bool comeBack
		{
			[Token(Token = "0x6011D04")]
			[Address(RVA = "0x9B87B0", Offset = "0x9B73B0", VA = "0x1809B87B0", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06011D05 RID: 72965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D05")]
		[Address(RVA = "0x9B8180", Offset = "0x9B6D80", VA = "0x1809B8180", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011D06 RID: 72966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D06")]
		[Address(RVA = "0x9B7FD0", Offset = "0x9B6BD0", VA = "0x1809B7FD0", Slot = "21")]
		protected override void DealReached()
		{
		}

		// Token: 0x06011D07 RID: 72967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D07")]
		[Address(RVA = "0x9B83B0", Offset = "0x9B6FB0", VA = "0x1809B83B0", Slot = "7")]
		public override void OnProjectileStop()
		{
		}

		// Token: 0x06011D08 RID: 72968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D08")]
		[Address(RVA = "0x9B8430", Offset = "0x9B7030", VA = "0x1809B8430", Slot = "5")]
		public override void OnTick(FP deltaTimeFp)
		{
		}

		// Token: 0x06011D09 RID: 72969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D09")]
		[Address(RVA = "0x9B86B0", Offset = "0x9B72B0", VA = "0x1809B86B0")]
		public Thorn2S2AdvancedMovement()
		{
		}

		// Token: 0x06011D0A RID: 72970 RVA: 0x0006D188 File Offset: 0x0006B388
		[Token(Token = "0x6011D0A")]
		[Address(RVA = "0x9B86A0", Offset = "0x9B72A0", VA = "0x1809B86A0")]
		private bool <>xLuaBaseProxy_get_comeBack()
		{
			return default(bool);
		}

		// Token: 0x06011D0B RID: 72971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D0B")]
		[Address(RVA = "0x9936C0", Offset = "0x9922C0", VA = "0x1809936C0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011D0C RID: 72972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D0C")]
		[Address(RVA = "0x998210", Offset = "0x996E10", VA = "0x180998210")]
		private void <>xLuaBaseProxy_DealReached()
		{
		}

		// Token: 0x06011D0D RID: 72973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D0D")]
		[Address(RVA = "0x9973C0", Offset = "0x995FC0", VA = "0x1809973C0")]
		private void <>xLuaBaseProxy_OnProjectileStop()
		{
		}

		// Token: 0x06011D0E RID: 72974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D0E")]
		[Address(RVA = "0x994070", Offset = "0x992C70", VA = "0x180994070")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0401402A RID: 81962
		[Token(Token = "0x401402A")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private float _extraMoveSpeed;

		// Token: 0x0401402B RID: 81963
		[Token(Token = "0x401402B")]
		[FieldOffset(Offset = "0x148")]
		private FP m_extraMoveSpeed;

		// Token: 0x0401402C RID: 81964
		[Token(Token = "0x401402C")]
		[FieldOffset(Offset = "0x150")]
		private FP m_moveEndTime;

		// Token: 0x0401402D RID: 81965
		[Token(Token = "0x401402D")]
		[FieldOffset(Offset = "0x158")]
		private Vector3 m_cachedDirect;

		// Token: 0x0401402E RID: 81966
		[Token(Token = "0x401402E")]
		[FieldOffset(Offset = "0x168")]
		private PeriodicTimer m_moveTimer;

		// Token: 0x0401402F RID: 81967
		[Token(Token = "0x401402F")]
		[FieldOffset(Offset = "0x170")]
		private Vector3 m_cachedOwnerPos;

		// Token: 0x04014030 RID: 81968
		[Token(Token = "0x4014030")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_comeBack;

		// Token: 0x04014031 RID: 81969
		[Token(Token = "0x4014031")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04014032 RID: 81970
		[Token(Token = "0x4014032")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DealReached;

		// Token: 0x04014033 RID: 81971
		[Token(Token = "0x4014033")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x04014034 RID: 81972
		[Token(Token = "0x4014034")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04014035 RID: 81973
		[Token(Token = "0x4014035")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
