using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002545 RID: 9541
	[Token(Token = "0x2002545")]
	public class MostCharacterSurroundTileSelector : TileSelector
	{
		// Token: 0x1700203D RID: 8253
		// (get) Token: 0x0600F62F RID: 63023 RVA: 0x0005B9B0 File Offset: 0x00059BB0
		[Token(Token = "0x1700203D")]
		protected override TileSelector.FilterType filterType
		{
			[Token(Token = "0x600F62F")]
			[Address(RVA = "0x6D6C60", Offset = "0x6D5860", VA = "0x1806D6C60", Slot = "40")]
			get
			{
				return TileSelector.FilterType.ALL;
			}
		}

		// Token: 0x1700203E RID: 8254
		// (get) Token: 0x0600F630 RID: 63024 RVA: 0x0005B9C8 File Offset: 0x00059BC8
		[Token(Token = "0x1700203E")]
		public override bool ignoreTargetFree
		{
			[Token(Token = "0x600F630")]
			[Address(RVA = "0x6D6CC0", Offset = "0x6D58C0", VA = "0x1806D6CC0", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700203F RID: 8255
		// (get) Token: 0x0600F631 RID: 63025 RVA: 0x0005B9E0 File Offset: 0x00059BE0
		[Token(Token = "0x1700203F")]
		public override EntityCategory targetCategory
		{
			[Token(Token = "0x600F631")]
			[Address(RVA = "0x6D6D20", Offset = "0x6D5920", VA = "0x1806D6D20", Slot = "27")]
			get
			{
				return EntityCategory.NONE;
			}
		}

		// Token: 0x0600F632 RID: 63026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F632")]
		[Address(RVA = "0x6D4680", Offset = "0x6D3280", VA = "0x1806D4680", Slot = "12")]
		public override void Reset(Entity owner, Ability ability, [Optional] Func<Entity, bool> validator)
		{
		}

		// Token: 0x0600F633 RID: 63027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F633")]
		[Address(RVA = "0x6D6480", Offset = "0x6D5080", VA = "0x1806D6480")]
		private void _ResetInternal()
		{
		}

		// Token: 0x0600F634 RID: 63028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F634")]
		[Address(RVA = "0x6D4E20", Offset = "0x6D3A20", VA = "0x1806D4E20", Slot = "41")]
		protected override void _DoFilter(List<Tile> candidates, TileSelector.FilterType tileFilterType)
		{
		}

		// Token: 0x0600F635 RID: 63029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F635")]
		[Address(RVA = "0x6D5660", Offset = "0x6D4260", VA = "0x1806D5660")]
		private void _OnUnitBorn(object arg)
		{
		}

		// Token: 0x0600F636 RID: 63030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F636")]
		[Address(RVA = "0x6D5D70", Offset = "0x6D4970", VA = "0x1806D5D70")]
		private void _OnUnitFinish(object arg)
		{
		}

		// Token: 0x0600F637 RID: 63031 RVA: 0x0005B9F8 File Offset: 0x00059BF8
		[Token(Token = "0x600F637")]
		[Address(RVA = "0x6D4BD0", Offset = "0x6D37D0", VA = "0x1806D4BD0")]
		private bool _CheckSpecifiedEnemies(DoubleBufferedList<ObjectPtr<Enemy>> enemies)
		{
			return default(bool);
		}

		// Token: 0x0600F638 RID: 63032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F638")]
		[Address(RVA = "0x6D6B40", Offset = "0x6D5740", VA = "0x1806D6B40")]
		public MostCharacterSurroundTileSelector()
		{
		}

		// Token: 0x0600F639 RID: 63033 RVA: 0x0005BA10 File Offset: 0x00059C10
		[Token(Token = "0x600F639")]
		[Address(RVA = "0x6D4AB0", Offset = "0x6D36B0", VA = "0x1806D4AB0")]
		private TileSelector.FilterType <>xLuaBaseProxy_get_filterType()
		{
			return TileSelector.FilterType.ALL;
		}

		// Token: 0x0600F63A RID: 63034 RVA: 0x0005BA28 File Offset: 0x00059C28
		[Token(Token = "0x600F63A")]
		[Address(RVA = "0x6D4B10", Offset = "0x6D3710", VA = "0x1806D4B10")]
		private bool <>xLuaBaseProxy_get_ignoreTargetFree()
		{
			return default(bool);
		}

		// Token: 0x0600F63B RID: 63035 RVA: 0x0005BA40 File Offset: 0x00059C40
		[Token(Token = "0x600F63B")]
		[Address(RVA = "0x6D4B70", Offset = "0x6D3770", VA = "0x1806D4B70")]
		private EntityCategory <>xLuaBaseProxy_get_targetCategory()
		{
			return EntityCategory.NONE;
		}

		// Token: 0x0600F63C RID: 63036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F63C")]
		[Address(RVA = "0x6D3780", Offset = "0x6D2380", VA = "0x1806D3780")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1, Func<Entity, bool> P2)
		{
		}

		// Token: 0x0600F63D RID: 63037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F63D")]
		[Address(RVA = "0x6D37A0", Offset = "0x6D23A0", VA = "0x1806D37A0")]
		private void <>xLuaBaseProxy__DoFilter(List<Tile> P0, TileSelector.FilterType P1)
		{
		}

		// Token: 0x0401110B RID: 69899
		[Token(Token = "0x401110B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[SerializeField]
		[Group("Advanced")]
		private List<string> _specifiedEnemyKeys;

		// Token: 0x0401110C RID: 69900
		[Token(Token = "0x401110C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[SerializeField]
		[Group("Advanced")]
		private bool _ignoreTargetFree;

		// Token: 0x0401110D RID: 69901
		[Token(Token = "0x401110D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		[SerializeField]
		[Group("Advanced")]
		[Enum(true, EnumDisplay.Checkbox)]
		public EntityCategory _AdvancedTargetCategory;

		// Token: 0x0401110E RID: 69902
		[Token(Token = "0x401110E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[SerializeField]
		[Group("Advanced")]
		private bool _onlyCalculateTilesWhichCharacterLocateOn;

		// Token: 0x0401110F RID: 69903
		[Token(Token = "0x401110F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x181")]
		[SerializeField]
		[Group("Advanced")]
		private bool _exceptTilesWhichCharacterLocateOn;

		// Token: 0x04011110 RID: 69904
		[Token(Token = "0x4011110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x182")]
		[SerializeField]
		[Group("Advanced")]
		private bool _disableRandomShuffle;

		// Token: 0x04011111 RID: 69905
		[Token(Token = "0x4011111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x183")]
		[SerializeField]
		[Group("Advanced")]
		private bool _forceCalculateRallyPointBornAndFinish;

		// Token: 0x04011112 RID: 69906
		[Token(Token = "0x4011112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private int[,] m_charCountMap;

		// Token: 0x04011113 RID: 69907
		[Token(Token = "0x4011113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private bool[,] m_charLocatedMap;

		// Token: 0x04011114 RID: 69908
		[Token(Token = "0x4011114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private int m_maxCharCount;

		// Token: 0x04011115 RID: 69909
		[Token(Token = "0x4011115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private int m_cachedMapHeight;

		// Token: 0x04011116 RID: 69910
		[Token(Token = "0x4011116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private int m_cachedMapWidth;

		// Token: 0x04011117 RID: 69911
		[Token(Token = "0x4011117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private Dictionary<int, List<Tile>> m_charDict;

		// Token: 0x04011118 RID: 69912
		[Token(Token = "0x4011118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_filterType;

		// Token: 0x04011119 RID: 69913
		[Token(Token = "0x4011119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_ignoreTargetFree;

		// Token: 0x0401111A RID: 69914
		[Token(Token = "0x401111A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_targetCategory;

		// Token: 0x0401111B RID: 69915
		[Token(Token = "0x401111B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0401111C RID: 69916
		[Token(Token = "0x401111C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ResetInternal;

		// Token: 0x0401111D RID: 69917
		[Token(Token = "0x401111D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__DoFilter;

		// Token: 0x0401111E RID: 69918
		[Token(Token = "0x401111E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnUnitBorn;

		// Token: 0x0401111F RID: 69919
		[Token(Token = "0x401111F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnUnitFinish;

		// Token: 0x04011120 RID: 69920
		[Token(Token = "0x4011120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CheckSpecifiedEnemies;

		// Token: 0x04011121 RID: 69921
		[Token(Token = "0x4011121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
