using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Sandbox
{
	// Token: 0x02002A65 RID: 10853
	[Token(Token = "0x2002A65")]
	public class HiddenAreaTileListener : IHotfixable, ITileListener
	{
		// Token: 0x060120CF RID: 73935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60120CF")]
		[Address(RVA = "0xA20FB0", Offset = "0xA1FBB0", VA = "0x180A20FB0", Slot = "4")]
		public void OnLocatedCharacterUpdate(Character character)
		{
		}

		// Token: 0x060120D0 RID: 73936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60120D0")]
		[Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0", Slot = "5")]
		public void OnEntityEnter(Entity entity)
		{
		}

		// Token: 0x060120D1 RID: 73937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60120D1")]
		[Address(RVA = "0xA20F30", Offset = "0xA1FB30", VA = "0x180A20F30", Slot = "6")]
		public void OnEntityLeave(Entity entity)
		{
		}

		// Token: 0x060120D2 RID: 73938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60120D2")]
		[Address(RVA = "0xA21B90", Offset = "0xA20790", VA = "0x180A21B90")]
		public void _HideEntity(Entity entity)
		{
		}

		// Token: 0x060120D3 RID: 73939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60120D3")]
		[Address(RVA = "0xA21C50", Offset = "0xA20850", VA = "0x180A21C50")]
		private void _ShowEntity(Entity entity)
		{
		}

		// Token: 0x060120D4 RID: 73940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60120D4")]
		[Address(RVA = "0xA21010", Offset = "0xA1FC10", VA = "0x180A21010")]
		public void OnTileHidden(Tile tile)
		{
		}

		// Token: 0x060120D5 RID: 73941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60120D5")]
		[Address(RVA = "0xA215F0", Offset = "0xA201F0", VA = "0x180A215F0")]
		public void OnTileShown(Tile tile)
		{
		}

		// Token: 0x060120D6 RID: 73942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60120D6")]
		[Address(RVA = "0xA21E50", Offset = "0xA20A50", VA = "0x180A21E50")]
		public HiddenAreaTileListener()
		{
		}

		// Token: 0x04014640 RID: 83520
		[Token(Token = "0x4014640")]
		[FieldOffset(Offset = "0x10")]
		private List<ObjectPtr<Entity>> m_entitiesOnTile;

		// Token: 0x04014641 RID: 83521
		[Token(Token = "0x4014641")]
		[FieldOffset(Offset = "0x18")]
		private ListDict<Tile, Tile.Options> m_cachedOptions;

		// Token: 0x04014642 RID: 83522
		[Token(Token = "0x4014642")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnLocatedCharacterUpdate;

		// Token: 0x04014643 RID: 83523
		[Token(Token = "0x4014643")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEntityEnter;

		// Token: 0x04014644 RID: 83524
		[Token(Token = "0x4014644")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEntityLeave;

		// Token: 0x04014645 RID: 83525
		[Token(Token = "0x4014645")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__HideEntity;

		// Token: 0x04014646 RID: 83526
		[Token(Token = "0x4014646")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ShowEntity;

		// Token: 0x04014647 RID: 83527
		[Token(Token = "0x4014647")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnTileHidden;

		// Token: 0x04014648 RID: 83528
		[Token(Token = "0x4014648")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnTileShown;

		// Token: 0x04014649 RID: 83529
		[Token(Token = "0x4014649")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
