using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200234F RID: 9039
	[Token(Token = "0x200234F")]
	public class TileMarkManager : GlobalEnvSystem.EnvManager
	{
		// Token: 0x0600E4B7 RID: 58551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4B7")]
		[Address(RVA = "0x5AC870", Offset = "0x5AB470", VA = "0x1805AC870")]
		public void MarkTile(GridPosition pos, int value)
		{
		}

		// Token: 0x0600E4B8 RID: 58552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4B8")]
		[Address(RVA = "0x5AC650", Offset = "0x5AB250", VA = "0x1805AC650")]
		public void MarkTileWithTime(GridPosition pos, int value, FP time)
		{
		}

		// Token: 0x0600E4B9 RID: 58553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4B9")]
		[Address(RVA = "0x5AC9F0", Offset = "0x5AB5F0", VA = "0x1805AC9F0", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600E4BA RID: 58554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4BA")]
		[Address(RVA = "0x5ACAC0", Offset = "0x5AB6C0", VA = "0x1805ACAC0")]
		private void _EmitStatusIfNeed()
		{
		}

		// Token: 0x0600E4BB RID: 58555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4BB")]
		[Address(RVA = "0x5ACF80", Offset = "0x5ABB80", VA = "0x1805ACF80")]
		private void _TickTiles(FP deltaTime)
		{
		}

		// Token: 0x0600E4BC RID: 58556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4BC")]
		[Address(RVA = "0x5AD240", Offset = "0x5ABE40", VA = "0x1805AD240")]
		public TileMarkManager()
		{
		}

		// Token: 0x0600E4BD RID: 58557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4BD")]
		[Address(RVA = "0x550C00", Offset = "0x54F800", VA = "0x180550C00")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0400FC19 RID: 64537
		[Token(Token = "0x400FC19")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<TileMarkManager.TileMarkSetting> _markSettings;

		// Token: 0x0400FC1A RID: 64538
		[Token(Token = "0x400FC1A")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<int, int> m_tileStatus;

		// Token: 0x0400FC1B RID: 64539
		[Token(Token = "0x400FC1B")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<int, int> m_tileStatusOld;

		// Token: 0x0400FC1C RID: 64540
		[Token(Token = "0x400FC1C")]
		[FieldOffset(Offset = "0x40")]
		private HashSet<int> m_changedPositions;

		// Token: 0x0400FC1D RID: 64541
		[Token(Token = "0x400FC1D")]
		[FieldOffset(Offset = "0x48")]
		private List<TileMarkManager.TileTickTime> m_tileTickTimeList;

		// Token: 0x0400FC1E RID: 64542
		[Token(Token = "0x400FC1E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_MarkTile;

		// Token: 0x0400FC1F RID: 64543
		[Token(Token = "0x400FC1F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_MarkTileWithTime;

		// Token: 0x0400FC20 RID: 64544
		[Token(Token = "0x400FC20")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400FC21 RID: 64545
		[Token(Token = "0x400FC21")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EmitStatusIfNeed;

		// Token: 0x0400FC22 RID: 64546
		[Token(Token = "0x400FC22")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TickTiles;

		// Token: 0x0400FC23 RID: 64547
		[Token(Token = "0x400FC23")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002350 RID: 9040
		[Token(Token = "0x2002350")]
		[Serializable]
		private class TileMarkSetting
		{
			// Token: 0x0600E4BE RID: 58558 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E4BE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TileMarkSetting()
			{
			}

			// Token: 0x0400FC24 RID: 64548
			[Token(Token = "0x400FC24")]
			[FieldOffset(Offset = "0x10")]
			public int value;

			// Token: 0x0400FC25 RID: 64549
			[Token(Token = "0x400FC25")]
			[FieldOffset(Offset = "0x14")]
			public CompareType compareType;

			// Token: 0x0400FC26 RID: 64550
			[Token(Token = "0x400FC26")]
			[FieldOffset(Offset = "0x18")]
			public string statusKey;
		}

		// Token: 0x02002351 RID: 9041
		[Token(Token = "0x2002351")]
		private struct TileTickTime
		{
			// Token: 0x0400FC27 RID: 64551
			[Token(Token = "0x400FC27")]
			[FieldOffset(Offset = "0x0")]
			public FP time;

			// Token: 0x0400FC28 RID: 64552
			[Token(Token = "0x400FC28")]
			[FieldOffset(Offset = "0x8")]
			public int code;

			// Token: 0x0400FC29 RID: 64553
			[Token(Token = "0x400FC29")]
			[FieldOffset(Offset = "0xC")]
			public int value;
		}
	}
}
