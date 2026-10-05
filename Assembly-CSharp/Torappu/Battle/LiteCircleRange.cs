using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024D1 RID: 9425
	[Token(Token = "0x20024D1")]
	public class LiteCircleRange : CircleRange
	{
		// Token: 0x0600F2AD RID: 62125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F2AD")]
		[Address(RVA = "0x6A8E10", Offset = "0x6A7A10", VA = "0x1806A8E10", Slot = "17")]
		protected override Collider2D[] FetchColliders(Range.Options options)
		{
			return null;
		}

		// Token: 0x0600F2AE RID: 62126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F2AE")]
		[Address(RVA = "0x6A8ED0", Offset = "0x6A7AD0", VA = "0x1806A8ED0", Slot = "11")]
		public override List<Tile> FindTiles(Vector2 mapPos, Func<Tile, bool> validator)
		{
			return null;
		}

		// Token: 0x0600F2AF RID: 62127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F2AF")]
		[Address(RVA = "0x6A8880", Offset = "0x6A7480", VA = "0x1806A8880", Slot = "10")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 mapPos, TargetOptions options, Func<Entity, bool> validator)
		{
			return null;
		}

		// Token: 0x0600F2B0 RID: 62128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F2B0")]
		[Address(RVA = "0x6A8FB0", Offset = "0x6A7BB0", VA = "0x1806A8FB0")]
		private ReusableList<Entity> GetUnitToCheck_DISPOSE(Vector2 mapPos)
		{
			return null;
		}

		// Token: 0x0600F2B1 RID: 62129 RVA: 0x000595F8 File Offset: 0x000577F8
		[Token(Token = "0x600F2B1")]
		[Address(RVA = "0x6A86E0", Offset = "0x6A72E0", VA = "0x1806A86E0", Slot = "12")]
		public override bool CheckTargetIn(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F2B2 RID: 62130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F2B2")]
		[Address(RVA = "0x6A9430", Offset = "0x6A8030", VA = "0x1806A9430")]
		public LiteCircleRange()
		{
		}

		// Token: 0x0600F2B3 RID: 62131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F2B3")]
		[Address(RVA = "0x6A9240", Offset = "0x6A7E40", VA = "0x1806A9240")]
		private Collider2D[] <>xLuaBaseProxy_FetchColliders(Range.Options P0)
		{
			return null;
		}

		// Token: 0x0600F2B4 RID: 62132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F2B4")]
		[Address(RVA = "0x6A9280", Offset = "0x6A7E80", VA = "0x1806A9280")]
		private List<Tile> <>xLuaBaseProxy_FindTiles(Vector2 P0, Func<Tile, bool> P1)
		{
			return null;
		}

		// Token: 0x0600F2B5 RID: 62133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F2B5")]
		[Address(RVA = "0x682A40", Offset = "0x681640", VA = "0x180682A40")]
		private ReusableList<Entity> <>xLuaBaseProxy_DoFindTargets_DISPOSE(Vector2 P0, TargetOptions P1, Func<Entity, bool> P2)
		{
			return null;
		}

		// Token: 0x0600F2B6 RID: 62134 RVA: 0x00059610 File Offset: 0x00057810
		[Token(Token = "0x600F2B6")]
		[Address(RVA = "0x6886B0", Offset = "0x6872B0", VA = "0x1806886B0")]
		private bool <>xLuaBaseProxy_CheckTargetIn(ILocatable P0)
		{
			return default(bool);
		}

		// Token: 0x04010C9F RID: 68767
		[Token(Token = "0x4010C9F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private bool _useTTree;

		// Token: 0x04010CA0 RID: 68768
		[Token(Token = "0x4010CA0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_FetchColliders;

		// Token: 0x04010CA1 RID: 68769
		[Token(Token = "0x4010CA1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_FindTiles;

		// Token: 0x04010CA2 RID: 68770
		[Token(Token = "0x4010CA2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x04010CA3 RID: 68771
		[Token(Token = "0x4010CA3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetUnitToCheck_DISPOSE;

		// Token: 0x04010CA4 RID: 68772
		[Token(Token = "0x4010CA4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckTargetIn;

		// Token: 0x04010CA5 RID: 68773
		[Token(Token = "0x4010CA5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
