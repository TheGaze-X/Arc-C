using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200254B RID: 9547
	[Token(Token = "0x200254B")]
	public abstract class TargetRelatedTileSelector : TileSelector
	{
		// Token: 0x0600F65B RID: 63067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F65B")]
		[Address(RVA = "0x6DF560", Offset = "0x6DE160", VA = "0x1806DF560", Slot = "12")]
		public override void Reset(Entity owner, Ability ability, [Optional] Func<Entity, bool> validator)
		{
		}

		// Token: 0x0600F65C RID: 63068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F65C")]
		[Address(RVA = "0x6DF6B0", Offset = "0x6DE2B0", VA = "0x1806DF6B0", Slot = "22")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x0600F65D RID: 63069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F65D")]
		[Address(RVA = "0x6DF230", Offset = "0x6DDE30", VA = "0x1806DF230", Slot = "20")]
		public override List<Tile> FindTiles(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F65E RID: 63070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F65E")]
		[Address(RVA = "0x6DF840", Offset = "0x6DE440", VA = "0x1806DF840", Slot = "41")]
		protected override void _DoFilter(List<Tile> candidates, TileSelector.FilterType tileFilterType)
		{
		}

		// Token: 0x0600F65F RID: 63071
		[Token(Token = "0x600F65F")]
		protected abstract List<Tile> _GetRelatedTile(ReusableList<Entity> targets);

		// Token: 0x0600F660 RID: 63072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F660")]
		[Address(RVA = "0x6DF9B0", Offset = "0x6DE5B0", VA = "0x1806DF9B0", Slot = "43")]
		protected virtual List<Tile> _GetRelatedTile(List<Tile> tiles)
		{
			return null;
		}

		// Token: 0x0600F661 RID: 63073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F661")]
		[Address(RVA = "0x6DFA20", Offset = "0x6DE620", VA = "0x1806DFA20")]
		protected TargetRelatedTileSelector()
		{
		}

		// Token: 0x0600F662 RID: 63074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F662")]
		[Address(RVA = "0x6D3780", Offset = "0x6D2380", VA = "0x1806D3780")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1, Func<Entity, bool> P2)
		{
		}

		// Token: 0x0600F663 RID: 63075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F663")]
		[Address(RVA = "0x6D3790", Offset = "0x6D2390", VA = "0x1806D3790")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x0600F664 RID: 63076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F664")]
		[Address(RVA = "0x69B0B0", Offset = "0x699CB0", VA = "0x18069B0B0")]
		private List<Tile> <>xLuaBaseProxy_FindTiles(Vector2 P0)
		{
			return null;
		}

		// Token: 0x0600F665 RID: 63077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F665")]
		[Address(RVA = "0x6D37A0", Offset = "0x6D23A0", VA = "0x1806D37A0")]
		private void <>xLuaBaseProxy__DoFilter(List<Tile> P0, TileSelector.FilterType P1)
		{
		}

		// Token: 0x04011155 RID: 69973
		[Token(Token = "0x4011155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[SerializeField]
		[Group("Selector")]
		private TargetSelector _selector;

		// Token: 0x04011156 RID: 69974
		[Token(Token = "0x4011156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[SerializeField]
		[Group("Selector")]
		private bool _selectorIsTile;

		// Token: 0x04011157 RID: 69975
		[Token(Token = "0x4011157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x179")]
		[SerializeField]
		[Group("Selector")]
		private bool _useValidate;

		// Token: 0x04011158 RID: 69976
		[Token(Token = "0x4011158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04011159 RID: 69977
		[Token(Token = "0x4011159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0401115A RID: 69978
		[Token(Token = "0x401115A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_FindTiles;

		// Token: 0x0401115B RID: 69979
		[Token(Token = "0x401115B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__DoFilter;

		// Token: 0x0401115C RID: 69980
		[Token(Token = "0x401115C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetRelatedTile;

		// Token: 0x0401115D RID: 69981
		[Token(Token = "0x401115D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
