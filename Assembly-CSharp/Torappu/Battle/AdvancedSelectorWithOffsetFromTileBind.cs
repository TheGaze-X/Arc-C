using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024F4 RID: 9460
	[Token(Token = "0x20024F4")]
	public class AdvancedSelectorWithOffsetFromTileBind : AdvancedSelector
	{
		// Token: 0x17001FBD RID: 8125
		// (get) Token: 0x0600F3B1 RID: 62385 RVA: 0x00059E20 File Offset: 0x00058020
		[Token(Token = "0x17001FBD")]
		protected override bool ignoreMapLayer
		{
			[Token(Token = "0x600F3B1")]
			[Address(RVA = "0x6A0410", Offset = "0x69F010", VA = "0x1806A0410", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F3B2 RID: 62386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F3B2")]
		[Address(RVA = "0x69FC30", Offset = "0x69E830", VA = "0x18069FC30", Slot = "13")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F3B3 RID: 62387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3B3")]
		[Address(RVA = "0x6A0220", Offset = "0x69EE20", VA = "0x1806A0220", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F3B4 RID: 62388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3B4")]
		[Address(RVA = "0x6A03A0", Offset = "0x69EFA0", VA = "0x1806A03A0")]
		public AdvancedSelectorWithOffsetFromTileBind()
		{
		}

		// Token: 0x0600F3B5 RID: 62389 RVA: 0x00059E38 File Offset: 0x00058038
		[Token(Token = "0x600F3B5")]
		[Address(RVA = "0x6A0390", Offset = "0x69EF90", VA = "0x1806A0390")]
		private bool <>xLuaBaseProxy_get_ignoreMapLayer()
		{
			return default(bool);
		}

		// Token: 0x0600F3B6 RID: 62390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F3B6")]
		[Address(RVA = "0x69AAA0", Offset = "0x6996A0", VA = "0x18069AAA0")]
		private ReusableList<Entity> <>xLuaBaseProxy_DoFindTargets_DISPOSE(Vector2 P0)
		{
			return null;
		}

		// Token: 0x0600F3B7 RID: 62391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3B7")]
		[Address(RVA = "0x69A940", Offset = "0x699540", VA = "0x18069A940")]
		private void <>xLuaBaseProxy_OnPostFilter(List<Entity> P0)
		{
		}

		// Token: 0x04010DD0 RID: 69072
		[Token(Token = "0x4010DD0")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private bool _tagExcluded;

		// Token: 0x04010DD1 RID: 69073
		[Token(Token = "0x4010DD1")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private string _filterTag;

		// Token: 0x04010DD2 RID: 69074
		[Token(Token = "0x4010DD2")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private bool _excludeRootTile;

		// Token: 0x04010DD3 RID: 69075
		[Token(Token = "0x4010DD3")]
		[FieldOffset(Offset = "0x101")]
		[SerializeField]
		private bool _ignoreMapLayer;

		// Token: 0x04010DD4 RID: 69076
		[Token(Token = "0x4010DD4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_ignoreMapLayer;

		// Token: 0x04010DD5 RID: 69077
		[Token(Token = "0x4010DD5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x04010DD6 RID: 69078
		[Token(Token = "0x4010DD6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04010DD7 RID: 69079
		[Token(Token = "0x4010DD7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
