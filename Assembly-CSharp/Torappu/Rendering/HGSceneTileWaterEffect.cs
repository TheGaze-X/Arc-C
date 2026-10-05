using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Rendering
{
	// Token: 0x02002071 RID: 8305
	[Token(Token = "0x2002071")]
	public class HGSceneTileWaterEffect : HGSceneWaterEffect
	{
		// Token: 0x0600CC91 RID: 52369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CC91")]
		[Address(RVA = "0x34D0F00", Offset = "0x34CFB00", VA = "0x1834D0F00", Slot = "11")]
		public override Shader GetReplaceSpineShader()
		{
			return null;
		}

		// Token: 0x0600CC92 RID: 52370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC92")]
		[Address(RVA = "0x34D0FD0", Offset = "0x34CFBD0", VA = "0x1834D0FD0", Slot = "8")]
		public override void Merge(BaseSceneEffect another)
		{
		}

		// Token: 0x0600CC93 RID: 52371 RVA: 0x00049CC8 File Offset: 0x00047EC8
		[Token(Token = "0x600CC93")]
		[Address(RVA = "0x34D1110", Offset = "0x34CFD10", VA = "0x1834D1110", Slot = "12")]
		public override bool TryGetTileReplaceSpineShader(out Shader replaceShader, out IList<Vector2> tilePosList)
		{
			return default(bool);
		}

		// Token: 0x0600CC94 RID: 52372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CC94")]
		[Address(RVA = "0x34D0F60", Offset = "0x34CFB60", VA = "0x1834D0F60", Slot = "13")]
		public override string GetSpineOnTileFlagName()
		{
			return null;
		}

		// Token: 0x0600CC95 RID: 52373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC95")]
		[Address(RVA = "0x34D1530", Offset = "0x34D0130", VA = "0x1834D1530")]
		public HGSceneTileWaterEffect()
		{
		}

		// Token: 0x0600CC96 RID: 52374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CC96")]
		[Address(RVA = "0x34D1450", Offset = "0x34D0050", VA = "0x1834D1450")]
		private Shader <>xLuaBaseProxy_GetReplaceSpineShader()
		{
			return null;
		}

		// Token: 0x0600CC97 RID: 52375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC97")]
		[Address(RVA = "0x34D1510", Offset = "0x34D0110", VA = "0x1834D1510")]
		private void <>xLuaBaseProxy_Merge(BaseSceneEffect P0)
		{
		}

		// Token: 0x0600CC98 RID: 52376 RVA: 0x00049CE0 File Offset: 0x00047EE0
		[Token(Token = "0x600CC98")]
		[Address(RVA = "0x34D1520", Offset = "0x34D0120", VA = "0x1834D1520")]
		private bool <>xLuaBaseProxy_TryGetTileReplaceSpineShader(out Shader P0, out IList<Vector2> P1)
		{
			return default(bool);
		}

		// Token: 0x0600CC99 RID: 52377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CC99")]
		[Address(RVA = "0x34D1500", Offset = "0x34D0100", VA = "0x1834D1500")]
		private string <>xLuaBaseProxy_GetSpineOnTileFlagName()
		{
			return null;
		}

		// Token: 0x0400D795 RID: 55189
		[Token(Token = "0x400D795")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		public List<Transform> _waterIntersectTiles;

		// Token: 0x0400D796 RID: 55190
		[Token(Token = "0x400D796")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetReplaceSpineShader;

		// Token: 0x0400D797 RID: 55191
		[Token(Token = "0x400D797")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Merge;

		// Token: 0x0400D798 RID: 55192
		[Token(Token = "0x400D798")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TryGetTileReplaceSpineShader;

		// Token: 0x0400D799 RID: 55193
		[Token(Token = "0x400D799")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSpineOnTileFlagName;

		// Token: 0x0400D79A RID: 55194
		[Token(Token = "0x400D79A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
