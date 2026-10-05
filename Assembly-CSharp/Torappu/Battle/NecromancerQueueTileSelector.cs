using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002547 RID: 9543
	[Token(Token = "0x2002547")]
	public class NecromancerQueueTileSelector : TileSelector
	{
		// Token: 0x17002042 RID: 8258
		// (get) Token: 0x0600F64B RID: 63051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002042")]
		public Queue<Tile> tileQueue
		{
			[Token(Token = "0x600F64B")]
			[Address(RVA = "0x6D8310", Offset = "0x6D6F10", VA = "0x1806D8310")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600F64C RID: 63052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F64C")]
		[Address(RVA = "0x6D7D40", Offset = "0x6D6940", VA = "0x1806D7D40")]
		public void PushTileIntoQueue(Tile tile)
		{
		}

		// Token: 0x0600F64D RID: 63053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F64D")]
		[Address(RVA = "0x6D7DE0", Offset = "0x6D69E0", VA = "0x1806D7DE0", Slot = "41")]
		protected override void _DoFilter(List<Tile> candidates, TileSelector.FilterType tileFilterType)
		{
		}

		// Token: 0x0600F64E RID: 63054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F64E")]
		[Address(RVA = "0x6D82B0", Offset = "0x6D6EB0", VA = "0x1806D82B0")]
		public NecromancerQueueTileSelector()
		{
		}

		// Token: 0x0600F64F RID: 63055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F64F")]
		[Address(RVA = "0x6D37A0", Offset = "0x6D23A0", VA = "0x1806D37A0")]
		private void <>xLuaBaseProxy__DoFilter(List<Tile> P0, TileSelector.FilterType P1)
		{
		}

		// Token: 0x04011136 RID: 69942
		[Token(Token = "0x4011136")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		protected NecromancerQueueTileSelector.NecromancerFilterType _necromancerFilterType;

		// Token: 0x04011137 RID: 69943
		[Token(Token = "0x4011137")]
		[FieldOffset(Offset = "0x174")]
		[SerializeField]
		private bool _useOtherSelectorQueue;

		// Token: 0x04011138 RID: 69944
		[Token(Token = "0x4011138")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private string _selectorAbilityName;

		// Token: 0x04011139 RID: 69945
		[Token(Token = "0x4011139")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private bool _verifyQueueTile;

		// Token: 0x0401113A RID: 69946
		[Token(Token = "0x401113A")]
		[FieldOffset(Offset = "0x181")]
		[SerializeField]
		private bool _verifyInRange;

		// Token: 0x0401113B RID: 69947
		[Token(Token = "0x401113B")]
		[FieldOffset(Offset = "0x188")]
		protected Queue<Tile> m_tileQueue;

		// Token: 0x0401113C RID: 69948
		[Token(Token = "0x401113C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_tileQueue;

		// Token: 0x0401113D RID: 69949
		[Token(Token = "0x401113D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PushTileIntoQueue;

		// Token: 0x0401113E RID: 69950
		[Token(Token = "0x401113E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__DoFilter;

		// Token: 0x0401113F RID: 69951
		[Token(Token = "0x401113F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002548 RID: 9544
		[Token(Token = "0x2002548")]
		public enum NecromancerFilterType
		{
			// Token: 0x04011141 RID: 69953
			[Token(Token = "0x4011141")]
			TECNO
		}
	}
}
