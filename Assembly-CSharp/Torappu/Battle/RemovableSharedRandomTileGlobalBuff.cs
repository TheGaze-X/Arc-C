using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002278 RID: 8824
	[Token(Token = "0x2002278")]
	public class RemovableSharedRandomTileGlobalBuff : SharedRandomTileGlobalBuff
	{
		// Token: 0x0600DDEA RID: 56810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDEA")]
		[Address(RVA = "0x363E2F0", Offset = "0x363CEF0", VA = "0x18363E2F0", Slot = "11")]
		public override void OnInit(LevelData.GlobalBuffData data)
		{
		}

		// Token: 0x0600DDEB RID: 56811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDEB")]
		[Address(RVA = "0x363E140", Offset = "0x363CD40", VA = "0x18363E140")]
		public static void ClearAllStaticVariables()
		{
		}

		// Token: 0x0600DDEC RID: 56812 RVA: 0x00050EB0 File Offset: 0x0004F0B0
		[Token(Token = "0x600DDEC")]
		[Address(RVA = "0x363E530", Offset = "0x363D130", VA = "0x18363E530", Slot = "19")]
		public override bool TryAddBindingTiles(List<Tile> tiles)
		{
			return default(bool);
		}

		// Token: 0x0600DDED RID: 56813 RVA: 0x00050EC8 File Offset: 0x0004F0C8
		[Token(Token = "0x600DDED")]
		[Address(RVA = "0x363EAE0", Offset = "0x363D6E0", VA = "0x18363EAE0")]
		public bool TryRemoveBindingTiles(List<Tile> tiles)
		{
			return default(bool);
		}

		// Token: 0x0600DDEE RID: 56814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDEE")]
		[Address(RVA = "0x363E380", Offset = "0x363CF80", VA = "0x18363E380", Slot = "14")]
		public override void OnRemoved()
		{
		}

		// Token: 0x0600DDEF RID: 56815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDEF")]
		[Address(RVA = "0x363E4A0", Offset = "0x363D0A0", VA = "0x18363E4A0", Slot = "9")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600DDF0 RID: 56816 RVA: 0x00050EE0 File Offset: 0x0004F0E0
		[Token(Token = "0x600DDF0")]
		[Address(RVA = "0x363E270", Offset = "0x363CE70", VA = "0x18363E270", Slot = "20")]
		protected override bool FilterTile(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0600DDF1 RID: 56817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDF1")]
		[Address(RVA = "0x363F250", Offset = "0x363DE50", VA = "0x18363F250")]
		public RemovableSharedRandomTileGlobalBuff()
		{
		}

		// Token: 0x0600DDF3 RID: 56819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDF3")]
		[Address(RVA = "0x363F110", Offset = "0x363DD10", VA = "0x18363F110")]
		private void <>xLuaBaseProxy_OnInit(LevelData.GlobalBuffData P0)
		{
		}

		// Token: 0x0600DDF4 RID: 56820 RVA: 0x00050EF8 File Offset: 0x0004F0F8
		[Token(Token = "0x600DDF4")]
		[Address(RVA = "0x363F140", Offset = "0x363DD40", VA = "0x18363F140")]
		private bool <>xLuaBaseProxy_TryAddBindingTiles(List<Tile> P0)
		{
			return default(bool);
		}

		// Token: 0x0600DDF5 RID: 56821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDF5")]
		[Address(RVA = "0x363F120", Offset = "0x363DD20", VA = "0x18363F120")]
		private void <>xLuaBaseProxy_OnRemoved()
		{
		}

		// Token: 0x0600DDF6 RID: 56822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDF6")]
		[Address(RVA = "0x363F130", Offset = "0x363DD30", VA = "0x18363F130")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600DDF7 RID: 56823 RVA: 0x00050F10 File Offset: 0x0004F110
		[Token(Token = "0x600DDF7")]
		[Address(RVA = "0x363EF90", Offset = "0x363DB90", VA = "0x18363EF90")]
		private bool <>xLuaBaseProxy_FilterTile(Tile P0)
		{
			return default(bool);
		}

		// Token: 0x0400F0AD RID: 61613
		[Token(Token = "0x400F0AD")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<GridPosition, int> createCnt;

		// Token: 0x0400F0AE RID: 61614
		[Token(Token = "0x400F0AE")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<Tile, Effect> effectHolder;

		// Token: 0x0400F0AF RID: 61615
		[Token(Token = "0x400F0AF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400F0B0 RID: 61616
		[Token(Token = "0x400F0B0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ClearAllStaticVariables;

		// Token: 0x0400F0B1 RID: 61617
		[Token(Token = "0x400F0B1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TryAddBindingTiles;

		// Token: 0x0400F0B2 RID: 61618
		[Token(Token = "0x400F0B2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TryRemoveBindingTiles;

		// Token: 0x0400F0B3 RID: 61619
		[Token(Token = "0x400F0B3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnRemoved;

		// Token: 0x0400F0B4 RID: 61620
		[Token(Token = "0x400F0B4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400F0B5 RID: 61621
		[Token(Token = "0x400F0B5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_FilterTile;

		// Token: 0x0400F0B6 RID: 61622
		[Token(Token = "0x400F0B6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
