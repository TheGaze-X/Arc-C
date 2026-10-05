using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BBA RID: 11194
	[Token(Token = "0x2002BBA")]
	public class UlpiaS3Ability : PassiveBuffAbility
	{
		// Token: 0x06012E6E RID: 77422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E6E")]
		[Address(RVA = "0xAD4A30", Offset = "0xAD3630", VA = "0x180AD4A30", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x06012E6F RID: 77423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E6F")]
		[Address(RVA = "0xAD4B30", Offset = "0xAD3730", VA = "0x180AD4B30", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x06012E70 RID: 77424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E70")]
		[Address(RVA = "0xAD4C30", Offset = "0xAD3830", VA = "0x180AD4C30")]
		public void OnProjectileReached(object args)
		{
		}

		// Token: 0x06012E71 RID: 77425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E71")]
		[Address(RVA = "0xAD5140", Offset = "0xAD3D40", VA = "0x180AD5140")]
		private void _AssignSharedData(Character character, GridPosition gridPosition)
		{
		}

		// Token: 0x06012E72 RID: 77426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E72")]
		[Address(RVA = "0xAD5300", Offset = "0xAD3F00", VA = "0x180AD5300")]
		private void _ResetSharedData(Character character)
		{
		}

		// Token: 0x06012E73 RID: 77427 RVA: 0x00073E18 File Offset: 0x00072018
		[Token(Token = "0x6012E73")]
		[Address(RVA = "0xAD5410", Offset = "0xAD4010", VA = "0x180AD5410")]
		private bool _TryGetTileSecond(Tile projectileReachedTile, out Tile targetTile)
		{
			return default(bool);
		}

		// Token: 0x06012E74 RID: 77428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E74")]
		[Address(RVA = "0xAD56D0", Offset = "0xAD42D0", VA = "0x180AD56D0")]
		public UlpiaS3Ability()
		{
		}

		// Token: 0x06012E75 RID: 77429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E75")]
		[Address(RVA = "0xA64260", Offset = "0xA62E60", VA = "0x180A64260")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x06012E76 RID: 77430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012E76")]
		[Address(RVA = "0xA3C270", Offset = "0xA3AE70", VA = "0x180A3C270")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x04015535 RID: 87349
		[Token(Token = "0x4015535")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Group("Respawn Blackboard Keys")]
		private string _skillProgressBBKey;

		// Token: 0x04015536 RID: 87350
		[Token(Token = "0x4015536")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		[Group("Respawn Blackboard Keys")]
		private string _colBBKey;

		// Token: 0x04015537 RID: 87351
		[Token(Token = "0x4015537")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		[Group("Respawn Blackboard Keys")]
		private string _rowBBKey;

		// Token: 0x04015538 RID: 87352
		[Token(Token = "0x4015538")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04015539 RID: 87353
		[Token(Token = "0x4015539")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x0401553A RID: 87354
		[Token(Token = "0x401553A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnProjectileReached;

		// Token: 0x0401553B RID: 87355
		[Token(Token = "0x401553B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__AssignSharedData;

		// Token: 0x0401553C RID: 87356
		[Token(Token = "0x401553C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ResetSharedData;

		// Token: 0x0401553D RID: 87357
		[Token(Token = "0x401553D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryGetTileSecond;

		// Token: 0x0401553E RID: 87358
		[Token(Token = "0x401553E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
