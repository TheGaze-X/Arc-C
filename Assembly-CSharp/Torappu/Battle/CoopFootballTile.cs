using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002393 RID: 9107
	[Token(Token = "0x2002393")]
	public class CoopFootballTile : DynamicBuffTileFixed
	{
		// Token: 0x0600E70A RID: 59146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E70A")]
		[Address(RVA = "0x5BA1D0", Offset = "0x5B8DD0", VA = "0x1805BA1D0", Slot = "50")]
		protected override void OnSwitchMode(int mode)
		{
		}

		// Token: 0x0600E70B RID: 59147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E70B")]
		[Address(RVA = "0x5BA330", Offset = "0x5B8F30", VA = "0x1805BA330")]
		public CoopFootballTile()
		{
		}

		// Token: 0x0600E70C RID: 59148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E70C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void <>xLuaBaseProxy_OnSwitchMode(int P0)
		{
		}

		// Token: 0x0400FE7F RID: 65151
		[Token(Token = "0x400FE7F")]
		[FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		private List<CoopFootballTile.GrasslandData> _grasslandDatas;

		// Token: 0x0400FE80 RID: 65152
		[Token(Token = "0x400FE80")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnSwitchMode;

		// Token: 0x0400FE81 RID: 65153
		[Token(Token = "0x400FE81")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002394 RID: 9108
		[Token(Token = "0x2002394")]
		private enum GrasslandType
		{
			// Token: 0x0400FE83 RID: 65155
			[Token(Token = "0x400FE83")]
			NORMAL_LAND,
			// Token: 0x0400FE84 RID: 65156
			[Token(Token = "0x400FE84")]
			ICE_LAND,
			// Token: 0x0400FE85 RID: 65157
			[Token(Token = "0x400FE85")]
			SLIME_LAND
		}

		// Token: 0x02002395 RID: 9109
		[Token(Token = "0x2002395")]
		[Serializable]
		private struct GrasslandData
		{
			// Token: 0x0400FE86 RID: 65158
			[Token(Token = "0x400FE86")]
			[FieldOffset(Offset = "0x0")]
			public int modeIdx;

			// Token: 0x0400FE87 RID: 65159
			[Token(Token = "0x400FE87")]
			[FieldOffset(Offset = "0x4")]
			public CoopFootballTile.GrasslandType grasslandType;

			// Token: 0x0400FE88 RID: 65160
			[Token(Token = "0x400FE88")]
			[FieldOffset(Offset = "0x8")]
			public float additionalFriction;
		}
	}
}
