using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200254A RID: 9546
	[Token(Token = "0x200254A")]
	public class TargetOffsetTileSelector : TargetRelatedTileSelector
	{
		// Token: 0x17002043 RID: 8259
		// (get) Token: 0x0600F653 RID: 63059 RVA: 0x0005BAE8 File Offset: 0x00059CE8
		[Token(Token = "0x17002043")]
		private SharedConsts.Direction offsetDirection
		{
			[Token(Token = "0x600F653")]
			[Address(RVA = "0x6DE6C0", Offset = "0x6DD2C0", VA = "0x1806DE6C0")]
			get
			{
				return SharedConsts.Direction.UP;
			}
		}

		// Token: 0x17002044 RID: 8260
		// (get) Token: 0x0600F654 RID: 63060 RVA: 0x0005BB00 File Offset: 0x00059D00
		[Token(Token = "0x17002044")]
		private int offsetDistance
		{
			[Token(Token = "0x600F654")]
			[Address(RVA = "0x6DE730", Offset = "0x6DD330", VA = "0x1806DE730")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600F655 RID: 63061 RVA: 0x0005BB18 File Offset: 0x00059D18
		[Token(Token = "0x600F655")]
		[Address(RVA = "0x6DDEA0", Offset = "0x6DCAA0", VA = "0x1806DDEA0")]
		public bool SetDynamicOffset(SharedConsts.Direction direction, int distance)
		{
			return default(bool);
		}

		// Token: 0x0600F656 RID: 63062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F656")]
		[Address(RVA = "0x6DE360", Offset = "0x6DCF60", VA = "0x1806DE360", Slot = "42")]
		protected override List<Tile> _GetRelatedTile(ReusableList<Entity> targets)
		{
			return null;
		}

		// Token: 0x0600F657 RID: 63063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F657")]
		[Address(RVA = "0x6DDCC0", Offset = "0x6DC8C0", VA = "0x1806DDCC0")]
		private Tile GetOffsetTile(Tile rootTile, int direction)
		{
			return null;
		}

		// Token: 0x0600F658 RID: 63064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F658")]
		[Address(RVA = "0x6DDFB0", Offset = "0x6DCBB0", VA = "0x1806DDFB0", Slot = "43")]
		protected override List<Tile> _GetRelatedTile(List<Tile> tiles)
		{
			return null;
		}

		// Token: 0x0600F659 RID: 63065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F659")]
		[Address(RVA = "0x6DE600", Offset = "0x6DD200", VA = "0x1806DE600")]
		public TargetOffsetTileSelector()
		{
		}

		// Token: 0x0600F65A RID: 63066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F65A")]
		[Address(RVA = "0x6DDF40", Offset = "0x6DCB40", VA = "0x1806DDF40")]
		private List<Tile> <>xLuaBaseProxy__GetRelatedTile(List<Tile> P0)
		{
			return null;
		}

		// Token: 0x04011146 RID: 69958
		[Token(Token = "0x4011146")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private bool _allowDuplicatedTile;

		// Token: 0x04011147 RID: 69959
		[Token(Token = "0x4011147")]
		[FieldOffset(Offset = "0x184")]
		[SerializeField]
		private SharedConsts.Direction _offsetDirection;

		// Token: 0x04011148 RID: 69960
		[Token(Token = "0x4011148")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private int _offsetDistance;

		// Token: 0x04011149 RID: 69961
		[Token(Token = "0x4011149")]
		[FieldOffset(Offset = "0x18C")]
		[SerializeField]
		private bool _useFourDirTiles;

		// Token: 0x0401114A RID: 69962
		[Token(Token = "0x401114A")]
		[FieldOffset(Offset = "0x18D")]
		[SerializeField]
		private bool _useTargetRootTile;

		// Token: 0x0401114B RID: 69963
		[Token(Token = "0x401114B")]
		[FieldOffset(Offset = "0x18E")]
		private bool m_useDynamicOffset;

		// Token: 0x0401114C RID: 69964
		[Token(Token = "0x401114C")]
		[FieldOffset(Offset = "0x190")]
		private SharedConsts.Direction m_dynamicOffsetDirection;

		// Token: 0x0401114D RID: 69965
		[Token(Token = "0x401114D")]
		[FieldOffset(Offset = "0x194")]
		private int m_dynamicOffsetDistance;

		// Token: 0x0401114E RID: 69966
		[Token(Token = "0x401114E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_offsetDirection;

		// Token: 0x0401114F RID: 69967
		[Token(Token = "0x401114F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_offsetDistance;

		// Token: 0x04011150 RID: 69968
		[Token(Token = "0x4011150")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetDynamicOffset;

		// Token: 0x04011151 RID: 69969
		[Token(Token = "0x4011151")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetRelatedTile;

		// Token: 0x04011152 RID: 69970
		[Token(Token = "0x4011152")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetOffsetTile;

		// Token: 0x04011153 RID: 69971
		[Token(Token = "0x4011153")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix1__GetRelatedTile;

		// Token: 0x04011154 RID: 69972
		[Token(Token = "0x4011154")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
