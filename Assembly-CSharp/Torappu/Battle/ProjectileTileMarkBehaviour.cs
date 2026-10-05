using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020023C8 RID: 9160
	[Token(Token = "0x20023C8")]
	public class ProjectileTileMarkBehaviour : Projectile.Behaviour
	{
		// Token: 0x0600E905 RID: 59653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E905")]
		[Address(RVA = "0x5F8990", Offset = "0x5F7590", VA = "0x1805F8990", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x0600E906 RID: 59654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E906")]
		[Address(RVA = "0x5F8B60", Offset = "0x5F7760", VA = "0x1805F8B60", Slot = "7")]
		public override void OnProjectileStop()
		{
		}

		// Token: 0x0600E907 RID: 59655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E907")]
		[Address(RVA = "0x5F8C60", Offset = "0x5F7860", VA = "0x1805F8C60")]
		public ProjectileTileMarkBehaviour()
		{
		}

		// Token: 0x0600E908 RID: 59656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E908")]
		[Address(RVA = "0x5EEAD0", Offset = "0x5ED6D0", VA = "0x1805EEAD0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x0600E909 RID: 59657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E909")]
		[Address(RVA = "0x5EEB40", Offset = "0x5ED740", VA = "0x1805EEB40")]
		private void <>xLuaBaseProxy_OnProjectileStop()
		{
		}

		// Token: 0x04010103 RID: 65795
		[Token(Token = "0x4010103")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TileInfoMask _mask;

		// Token: 0x04010104 RID: 65796
		[Token(Token = "0x4010104")]
		[FieldOffset(Offset = "0x30")]
		private Tile m_tracedTile;

		// Token: 0x04010105 RID: 65797
		[Token(Token = "0x4010105")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04010106 RID: 65798
		[Token(Token = "0x4010106")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x04010107 RID: 65799
		[Token(Token = "0x4010107")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
