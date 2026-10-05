using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002544 RID: 9540
	[Token(Token = "0x2002544")]
	public class FilterAttackRangeCoverTileSelector : TileSelector
	{
		// Token: 0x0600F621 RID: 63009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F621")]
		[Address(RVA = "0x6D3410", Offset = "0x6D2010", VA = "0x1806D3410")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600F622 RID: 63010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F622")]
		[Address(RVA = "0x6D3480", Offset = "0x6D2080", VA = "0x1806D3480", Slot = "12")]
		public override void Reset(Entity owner, Ability ability, [Optional] Func<Entity, bool> validator)
		{
		}

		// Token: 0x0600F623 RID: 63011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F623")]
		[Address(RVA = "0x6D36C0", Offset = "0x6D22C0", VA = "0x1806D36C0", Slot = "22")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x0600F624 RID: 63012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F624")]
		[Address(RVA = "0x6D3AB0", Offset = "0x6D26B0", VA = "0x1806D3AB0")]
		private void _InitAttackRangeCoverMap()
		{
		}

		// Token: 0x0600F625 RID: 63013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F625")]
		[Address(RVA = "0x6D3FA0", Offset = "0x6D2BA0", VA = "0x1806D3FA0")]
		private void _RefreshAttackRangeCoverMap()
		{
		}

		// Token: 0x0600F626 RID: 63014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F626")]
		[Address(RVA = "0x6D4430", Offset = "0x6D3030", VA = "0x1806D4430")]
		private void _UpdateAttackRangeCoverMap(List<Tile> tiles, bool isAdd)
		{
		}

		// Token: 0x0600F627 RID: 63015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F627")]
		[Address(RVA = "0x6D3D40", Offset = "0x6D2940", VA = "0x1806D3D40")]
		private void _OnUnitBorn(object arg)
		{
		}

		// Token: 0x0600F628 RID: 63016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F628")]
		[Address(RVA = "0x6D3E70", Offset = "0x6D2A70", VA = "0x1806D3E70")]
		private void _OnUnitFinish(object arg)
		{
		}

		// Token: 0x0600F629 RID: 63017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F629")]
		[Address(RVA = "0x6D3CD0", Offset = "0x6D28D0", VA = "0x1806D3CD0")]
		private void _OnAttackRangeDirty(object arg)
		{
		}

		// Token: 0x0600F62A RID: 63018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F62A")]
		[Address(RVA = "0x6D37B0", Offset = "0x6D23B0", VA = "0x1806D37B0", Slot = "41")]
		protected override void _DoFilter(List<Tile> candidates, TileSelector.FilterType tileFilterType)
		{
		}

		// Token: 0x0600F62B RID: 63019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F62B")]
		[Address(RVA = "0x6D4610", Offset = "0x6D3210", VA = "0x1806D4610")]
		public FilterAttackRangeCoverTileSelector()
		{
		}

		// Token: 0x0600F62C RID: 63020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F62C")]
		[Address(RVA = "0x6D3780", Offset = "0x6D2380", VA = "0x1806D3780")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1, Func<Entity, bool> P2)
		{
		}

		// Token: 0x0600F62D RID: 63021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F62D")]
		[Address(RVA = "0x6D3790", Offset = "0x6D2390", VA = "0x1806D3790")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x0600F62E RID: 63022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F62E")]
		[Address(RVA = "0x6D37A0", Offset = "0x6D23A0", VA = "0x1806D37A0")]
		private void <>xLuaBaseProxy__DoFilter(List<Tile> P0, TileSelector.FilterType P1)
		{
		}

		// Token: 0x040110F7 RID: 69879
		[Token(Token = "0x40110F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[SerializeField]
		[Group("Advanced")]
		private float _distToOwner;

		// Token: 0x040110F8 RID: 69880
		[Token(Token = "0x40110F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		[SerializeField]
		[Group("Advanced")]
		private CompareType _distToOwnerCompareType;

		// Token: 0x040110F9 RID: 69881
		[Token(Token = "0x40110F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private int[,] m_attackRangeCoverMap;

		// Token: 0x040110FA RID: 69882
		[Token(Token = "0x40110FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private int m_maxCharCount;

		// Token: 0x040110FB RID: 69883
		[Token(Token = "0x40110FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		private int m_cachedMapHeight;

		// Token: 0x040110FC RID: 69884
		[Token(Token = "0x40110FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private int m_cachedMapWidth;

		// Token: 0x040110FD RID: 69885
		[Token(Token = "0x40110FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private float m_distToOwner;

		// Token: 0x040110FE RID: 69886
		[Token(Token = "0x40110FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private int m_minCoverCount;

		// Token: 0x040110FF RID: 69887
		[Token(Token = "0x40110FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		private bool m_isAttackRangeDirty;

		// Token: 0x04011100 RID: 69888
		[Token(Token = "0x4011100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_FixedUpdate;

		// Token: 0x04011101 RID: 69889
		[Token(Token = "0x4011101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04011102 RID: 69890
		[Token(Token = "0x4011102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04011103 RID: 69891
		[Token(Token = "0x4011103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitAttackRangeCoverMap;

		// Token: 0x04011104 RID: 69892
		[Token(Token = "0x4011104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RefreshAttackRangeCoverMap;

		// Token: 0x04011105 RID: 69893
		[Token(Token = "0x4011105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateAttackRangeCoverMap;

		// Token: 0x04011106 RID: 69894
		[Token(Token = "0x4011106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnUnitBorn;

		// Token: 0x04011107 RID: 69895
		[Token(Token = "0x4011107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnUnitFinish;

		// Token: 0x04011108 RID: 69896
		[Token(Token = "0x4011108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnAttackRangeDirty;

		// Token: 0x04011109 RID: 69897
		[Token(Token = "0x4011109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__DoFilter;

		// Token: 0x0401110A RID: 69898
		[Token(Token = "0x401110A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
