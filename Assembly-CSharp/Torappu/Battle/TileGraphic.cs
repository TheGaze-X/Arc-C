using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020023AF RID: 9135
	[Token(Token = "0x20023AF")]
	[SelectionBase]
	public class TileGraphic : MonoBehaviour, IHotfixable
	{
		// Token: 0x17001D4A RID: 7498
		// (get) Token: 0x0600E831 RID: 59441 RVA: 0x00054BE8 File Offset: 0x00052DE8
		// (set) Token: 0x0600E832 RID: 59442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001D4A")]
		public TileGraphic.HighlightType highlightType
		{
			[Token(Token = "0x600E831")]
			[Address(RVA = "0x5DE1B0", Offset = "0x5DCDB0", VA = "0x1805DE1B0")]
			get
			{
				return TileGraphic.HighlightType.NONE;
			}
			[Token(Token = "0x600E832")]
			[Address(RVA = "0x5DE2A0", Offset = "0x5DCEA0", VA = "0x1805DE2A0")]
			set
			{
			}
		}

		// Token: 0x17001D4B RID: 7499
		// (get) Token: 0x0600E833 RID: 59443 RVA: 0x00054C00 File Offset: 0x00052E00
		[Token(Token = "0x17001D4B")]
		public GridPosition gridPos
		{
			[Token(Token = "0x600E833")]
			[Address(RVA = "0x5DE140", Offset = "0x5DCD40", VA = "0x1805DE140")]
			get
			{
				return default(GridPosition);
			}
		}

		// Token: 0x17001D4C RID: 7500
		// (get) Token: 0x0600E834 RID: 59444 RVA: 0x00054C18 File Offset: 0x00052E18
		[Token(Token = "0x17001D4C")]
		public Vector2 mapOffset
		{
			[Token(Token = "0x600E834")]
			[Address(RVA = "0x5DE220", Offset = "0x5DCE20", VA = "0x1805DE220")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x0600E835 RID: 59445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E835")]
		[Address(RVA = "0x5DD710", Offset = "0x5DC310", VA = "0x1805DD710", Slot = "4")]
		public virtual void Init()
		{
		}

		// Token: 0x0600E836 RID: 59446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E836")]
		[Address(RVA = "0x5DDDC0", Offset = "0x5DC9C0", VA = "0x1805DDDC0")]
		public void SetTile(Tile tile)
		{
		}

		// Token: 0x0600E837 RID: 59447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E837")]
		[Address(RVA = "0x5DDD30", Offset = "0x5DC930", VA = "0x1805DDD30")]
		public void SetProhibitHighLight(bool prohibit)
		{
		}

		// Token: 0x0600E838 RID: 59448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E838")]
		[Address(RVA = "0x5DDE50", Offset = "0x5DCA50", VA = "0x1805DDE50")]
		public void UpdateGridPosition(Transform anchor)
		{
		}

		// Token: 0x0600E839 RID: 59449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E839")]
		[Address(RVA = "0x5DD7B0", Offset = "0x5DC3B0", VA = "0x1805DD7B0", Slot = "5")]
		public virtual void OnTriggered(int triggerCnt)
		{
		}

		// Token: 0x0600E83A RID: 59450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E83A")]
		[Address(RVA = "0x5DD830", Offset = "0x5DC430", VA = "0x1805DD830", Slot = "6")]
		public virtual void RefreshThemeConfig()
		{
		}

		// Token: 0x0600E83B RID: 59451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E83B")]
		[Address(RVA = "0x5DD8A0", Offset = "0x5DC4A0", VA = "0x1805DD8A0", Slot = "7")]
		public virtual void ResetTile()
		{
		}

		// Token: 0x0600E83C RID: 59452 RVA: 0x00054C30 File Offset: 0x00052E30
		[Token(Token = "0x600E83C")]
		[Address(RVA = "0x5DD910", Offset = "0x5DC510", VA = "0x1805DD910", Slot = "8")]
		protected virtual bool SetHighlight(TileGraphic.HighlightType value, bool force)
		{
			return default(bool);
		}

		// Token: 0x0600E83D RID: 59453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E83D")]
		[Address(RVA = "0x5DDAE0", Offset = "0x5DC6E0", VA = "0x1805DDAE0", Slot = "9")]
		public virtual void SetLitState(bool state)
		{
		}

		// Token: 0x0600E83E RID: 59454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E83E")]
		[Address(RVA = "0x5DD9E0", Offset = "0x5DC5E0", VA = "0x1805DD9E0", Slot = "10")]
		public virtual void SetLitState(int litLevel)
		{
		}

		// Token: 0x0600E83F RID: 59455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E83F")]
		[Address(RVA = "0x5DDC20", Offset = "0x5DC820", VA = "0x1805DDC20", Slot = "11")]
		public virtual void SetLitStrength(float strength)
		{
		}

		// Token: 0x0600E840 RID: 59456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E840")]
		[Address(RVA = "0x5DE080", Offset = "0x5DCC80", VA = "0x1805DE080")]
		public TileGraphic()
		{
		}

		// Token: 0x0400FFC1 RID: 65473
		[Token(Token = "0x400FFC1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Tile _tile;

		// Token: 0x0400FFC2 RID: 65474
		[Token(Token = "0x400FFC2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GridPosition _gridPos;

		// Token: 0x0400FFC3 RID: 65475
		[Token(Token = "0x400FFC3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector2 _mapOffset;

		// Token: 0x0400FFC4 RID: 65476
		[Token(Token = "0x400FFC4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _prohibitHighLight;

		// Token: 0x0400FFC5 RID: 65477
		[Token(Token = "0x400FFC5")]
		[FieldOffset(Offset = "0x34")]
		protected TileGraphic.HighlightType m_highlightType;

		// Token: 0x0400FFC6 RID: 65478
		[Token(Token = "0x400FFC6")]
		[FieldOffset(Offset = "0x38")]
		protected bool m_prohibitHighLight;

		// Token: 0x0400FFC7 RID: 65479
		[Token(Token = "0x400FFC7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string BRIGHT_TILE_KEYWORD;

		// Token: 0x0400FFC8 RID: 65480
		[Token(Token = "0x400FFC8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_highlightType;

		// Token: 0x0400FFC9 RID: 65481
		[Token(Token = "0x400FFC9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_highlightType;

		// Token: 0x0400FFCA RID: 65482
		[Token(Token = "0x400FFCA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_gridPos;

		// Token: 0x0400FFCB RID: 65483
		[Token(Token = "0x400FFCB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_mapOffset;

		// Token: 0x0400FFCC RID: 65484
		[Token(Token = "0x400FFCC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400FFCD RID: 65485
		[Token(Token = "0x400FFCD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetTile;

		// Token: 0x0400FFCE RID: 65486
		[Token(Token = "0x400FFCE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SetProhibitHighLight;

		// Token: 0x0400FFCF RID: 65487
		[Token(Token = "0x400FFCF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_UpdateGridPosition;

		// Token: 0x0400FFD0 RID: 65488
		[Token(Token = "0x400FFD0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnTriggered;

		// Token: 0x0400FFD1 RID: 65489
		[Token(Token = "0x400FFD1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_RefreshThemeConfig;

		// Token: 0x0400FFD2 RID: 65490
		[Token(Token = "0x400FFD2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ResetTile;

		// Token: 0x0400FFD3 RID: 65491
		[Token(Token = "0x400FFD3")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SetHighlight;

		// Token: 0x0400FFD4 RID: 65492
		[Token(Token = "0x400FFD4")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_SetLitState;

		// Token: 0x0400FFD5 RID: 65493
		[Token(Token = "0x400FFD5")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix1_SetLitState;

		// Token: 0x0400FFD6 RID: 65494
		[Token(Token = "0x400FFD6")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_SetLitStrength;

		// Token: 0x0400FFD7 RID: 65495
		[Token(Token = "0x400FFD7")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020023B0 RID: 9136
		[Token(Token = "0x20023B0")]
		public enum HighlightType
		{
			// Token: 0x0400FFD9 RID: 65497
			[Token(Token = "0x400FFD9")]
			NONE,
			// Token: 0x0400FFDA RID: 65498
			[Token(Token = "0x400FFDA")]
			BUILDABLE,
			// Token: 0x0400FFDB RID: 65499
			[Token(Token = "0x400FFDB")]
			FOCUSED,
			// Token: 0x0400FFDC RID: 65500
			[Token(Token = "0x400FFDC")]
			REPLACEABLE,
			// Token: 0x0400FFDD RID: 65501
			[Token(Token = "0x400FFDD")]
			CUSTOM
		}
	}
}
