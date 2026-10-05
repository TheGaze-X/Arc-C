using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002356 RID: 9046
	[Token(Token = "0x2002356")]
	public class ViewRangeFogManager : GlobalEnvSystem.EnvManager
	{
		// Token: 0x17001CA6 RID: 7334
		// (get) Token: 0x0600E4ED RID: 58605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001CA6")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600E4ED")]
			[Address(RVA = "0x5B4220", Offset = "0x5B2E20", VA = "0x1805B4220", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E4EE RID: 58606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4EE")]
		[Address(RVA = "0x5B1040", Offset = "0x5AFC40", VA = "0x1805B1040", Slot = "7")]
		public override void Init(GlobalEnvSystem owner)
		{
		}

		// Token: 0x0600E4EF RID: 58607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4EF")]
		[Address(RVA = "0x5B2A30", Offset = "0x5B1630", VA = "0x1805B2A30")]
		private void _OnUnitBorn(object arg)
		{
		}

		// Token: 0x0600E4F0 RID: 58608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4F0")]
		[Address(RVA = "0x5B2E20", Offset = "0x5B1A20", VA = "0x1805B2E20")]
		private void _OnUnitFinish(object arg)
		{
		}

		// Token: 0x0600E4F1 RID: 58609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4F1")]
		[Address(RVA = "0x5B3870", Offset = "0x5B2470", VA = "0x1805B3870")]
		private void _RefreshRemainOnFinishTick(Tile tile)
		{
		}

		// Token: 0x0600E4F2 RID: 58610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4F2")]
		[Address(RVA = "0x5B2940", Offset = "0x5B1540", VA = "0x1805B2940")]
		private void _OnGameOver(object arg)
		{
		}

		// Token: 0x0600E4F3 RID: 58611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4F3")]
		[Address(RVA = "0x5B1BF0", Offset = "0x5B07F0", VA = "0x1805B1BF0", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600E4F4 RID: 58612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4F4")]
		[Address(RVA = "0x5B3780", Offset = "0x5B2380", VA = "0x1805B3780")]
		private void _OnUnitRefresh(object arg)
		{
		}

		// Token: 0x0600E4F5 RID: 58613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4F5")]
		[Address(RVA = "0x5B1C80", Offset = "0x5B0880", VA = "0x1805B1C80", Slot = "15")]
		public override void OnTrigger(object param)
		{
		}

		// Token: 0x0600E4F6 RID: 58614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4F6")]
		[Address(RVA = "0x5B1D80", Offset = "0x5B0980", VA = "0x1805B1D80")]
		public void OnTrigger(Character character, bool force)
		{
		}

		// Token: 0x0600E4F7 RID: 58615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4F7")]
		[Address(RVA = "0x5B3BD0", Offset = "0x5B27D0", VA = "0x1805B3BD0")]
		private void _UpdateTileByDiff()
		{
		}

		// Token: 0x0600E4F8 RID: 58616 RVA: 0x00052C20 File Offset: 0x00050E20
		[Token(Token = "0x600E4F8")]
		[Address(RVA = "0x5B3E50", Offset = "0x5B2A50", VA = "0x1805B3E50")]
		private bool _ValidCharacter(Character character)
		{
			return default(bool);
		}

		// Token: 0x0600E4F9 RID: 58617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4F9")]
		[Address(RVA = "0x5B2330", Offset = "0x5B0F30", VA = "0x1805B2330")]
		private void _GetInViewTile(Character character, ref List<Tile> newInViewTile)
		{
		}

		// Token: 0x0600E4FA RID: 58618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4FA")]
		[Address(RVA = "0x5B2850", Offset = "0x5B1450", VA = "0x1805B2850")]
		private void _MarkInView(bool inCharView, Tile tile)
		{
		}

		// Token: 0x0600E4FB RID: 58619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4FB")]
		[Address(RVA = "0x5B0C70", Offset = "0x5AF870", VA = "0x1805B0C70")]
		public void AddTickTile(List<Tile> tiles, FP time)
		{
		}

		// Token: 0x0600E4FC RID: 58620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4FC")]
		[Address(RVA = "0x5B0A10", Offset = "0x5AF610", VA = "0x1805B0A10")]
		public void AddTickTile(IDrawableRange range, FP time)
		{
		}

		// Token: 0x0600E4FD RID: 58621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4FD")]
		[Address(RVA = "0x5B1B60", Offset = "0x5B0760", VA = "0x1805B1B60")]
		public void MarkNotInView(string id)
		{
		}

		// Token: 0x0600E4FE RID: 58622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4FE")]
		[Address(RVA = "0x5B18F0", Offset = "0x5B04F0", VA = "0x1805B18F0")]
		public void MarkInView(string id, int leftButtomX, int leftButtomY, int rightUpX, int rightUpY)
		{
		}

		// Token: 0x0600E4FF RID: 58623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4FF")]
		[Address(RVA = "0x5B1760", Offset = "0x5B0360", VA = "0x1805B1760")]
		public void MarkInView(bool inCharView, List<Tile> tiles)
		{
		}

		// Token: 0x0600E500 RID: 58624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E500")]
		[Address(RVA = "0x5B3980", Offset = "0x5B2580", VA = "0x1805B3980")]
		private void _ResetSandboxBuilder()
		{
		}

		// Token: 0x0600E501 RID: 58625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E501")]
		[Address(RVA = "0x5B0DE0", Offset = "0x5AF9E0", VA = "0x1805B0DE0")]
		public string GetExploredMap()
		{
			return null;
		}

		// Token: 0x0600E502 RID: 58626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E502")]
		[Address(RVA = "0x5B3F60", Offset = "0x5B2B60", VA = "0x1805B3F60")]
		public ViewRangeFogManager()
		{
		}

		// Token: 0x0600E503 RID: 58627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E503")]
		[Address(RVA = "0x550C20", Offset = "0x54F820", VA = "0x180550C20")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0600E504 RID: 58628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E504")]
		[Address(RVA = "0x550BE0", Offset = "0x54F7E0", VA = "0x180550BE0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600E505 RID: 58629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E505")]
		[Address(RVA = "0x550C00", Offset = "0x54F800", VA = "0x180550C00")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600E506 RID: 58630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E506")]
		[Address(RVA = "0x550C10", Offset = "0x54F810", VA = "0x180550C10")]
		private void <>xLuaBaseProxy_OnTrigger(object P0)
		{
		}

		// Token: 0x0400FC67 RID: 64615
		[Token(Token = "0x400FC67")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _toLight;

		// Token: 0x0400FC68 RID: 64616
		[Token(Token = "0x400FC68")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _toHidden;

		// Token: 0x0400FC69 RID: 64617
		[Token(Token = "0x400FC69")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _toHasViewed;

		// Token: 0x0400FC6A RID: 64618
		[Token(Token = "0x400FC6A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _toNotViewed;

		// Token: 0x0400FC6B RID: 64619
		[Token(Token = "0x400FC6B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _startColor;

		// Token: 0x0400FC6C RID: 64620
		[Token(Token = "0x400FC6C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ProfessionCategory[] _rootProfessions;

		// Token: 0x0400FC6D RID: 64621
		[Token(Token = "0x400FC6D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ProfessionCategory[] _validEnemyProfessions;

		// Token: 0x0400FC6E RID: 64622
		[Token(Token = "0x400FC6E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string _remainOnFinishRange;

		// Token: 0x0400FC6F RID: 64623
		[Token(Token = "0x400FC6F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _remainOnFinishTime;

		// Token: 0x0400FC70 RID: 64624
		[Token(Token = "0x400FC70")]
		[FieldOffset(Offset = "0x78")]
		private ListDict<Character, int> m_unitModeIndexCache;

		// Token: 0x0400FC71 RID: 64625
		[Token(Token = "0x400FC71")]
		[FieldOffset(Offset = "0x80")]
		private ListDict<Character, List<Tile>> m_tileInUnitAttackRangeBefore;

		// Token: 0x0400FC72 RID: 64626
		[Token(Token = "0x400FC72")]
		[FieldOffset(Offset = "0x88")]
		private ViewRangeFogManager.FogEdgeEffectHolder m_fogEdgeEffect;

		// Token: 0x0400FC73 RID: 64627
		[Token(Token = "0x400FC73")]
		[FieldOffset(Offset = "0x90")]
		private ViewRangeFogManager.RemainingTileTicker m_remainingTileTicker;

		// Token: 0x0400FC74 RID: 64628
		[Token(Token = "0x400FC74")]
		[FieldOffset(Offset = "0x98")]
		private ViewRangeFogManager.RangeTileViewHolder m_rangeTileViewHolder;

		// Token: 0x0400FC75 RID: 64629
		[Token(Token = "0x400FC75")]
		[FieldOffset(Offset = "0xA0")]
		private List<Tile> m_newInViewTile;

		// Token: 0x0400FC76 RID: 64630
		[Token(Token = "0x400FC76")]
		[FieldOffset(Offset = "0xA8")]
		private int[,] m_cacheTileStatus;

		// Token: 0x0400FC77 RID: 64631
		[Token(Token = "0x400FC77")]
		[FieldOffset(Offset = "0xB0")]
		private int[,] m_tileStatus;

		// Token: 0x0400FC78 RID: 64632
		[Token(Token = "0x400FC78")]
		[FieldOffset(Offset = "0xB8")]
		private byte[] m_exploreBytes;

		// Token: 0x0400FC79 RID: 64633
		[Token(Token = "0x400FC79")]
		[FieldOffset(Offset = "0xC0")]
		private string m_extraViewRange;

		// Token: 0x0400FC7A RID: 64634
		[Token(Token = "0x400FC7A")]
		[FieldOffset(Offset = "0xC8")]
		private float m_remainOnFinishTime;

		// Token: 0x0400FC7B RID: 64635
		[Token(Token = "0x400FC7B")]
		[FieldOffset(Offset = "0xD0")]
		private string m_forceViewRange;

		// Token: 0x0400FC7C RID: 64636
		[Token(Token = "0x400FC7C")]
		private const string EXTRA_VIEW_RANGE = "extra_view_range";

		// Token: 0x0400FC7D RID: 64637
		[Token(Token = "0x400FC7D")]
		private const string VIEW_TIME_WHEN_FINISH = "finish_view_time";

		// Token: 0x0400FC7E RID: 64638
		[Token(Token = "0x400FC7E")]
		private const string FORCE_VIEW_RANGE = "force_view_range";

		// Token: 0x0400FC7F RID: 64639
		[Token(Token = "0x400FC7F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0400FC80 RID: 64640
		[Token(Token = "0x400FC80")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400FC81 RID: 64641
		[Token(Token = "0x400FC81")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnUnitBorn;

		// Token: 0x0400FC82 RID: 64642
		[Token(Token = "0x400FC82")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnUnitFinish;

		// Token: 0x0400FC83 RID: 64643
		[Token(Token = "0x400FC83")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RefreshRemainOnFinishTick;

		// Token: 0x0400FC84 RID: 64644
		[Token(Token = "0x400FC84")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnGameOver;

		// Token: 0x0400FC85 RID: 64645
		[Token(Token = "0x400FC85")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400FC86 RID: 64646
		[Token(Token = "0x400FC86")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnUnitRefresh;

		// Token: 0x0400FC87 RID: 64647
		[Token(Token = "0x400FC87")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnTrigger;

		// Token: 0x0400FC88 RID: 64648
		[Token(Token = "0x400FC88")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix1_OnTrigger;

		// Token: 0x0400FC89 RID: 64649
		[Token(Token = "0x400FC89")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateTileByDiff;

		// Token: 0x0400FC8A RID: 64650
		[Token(Token = "0x400FC8A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ValidCharacter;

		// Token: 0x0400FC8B RID: 64651
		[Token(Token = "0x400FC8B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GetInViewTile;

		// Token: 0x0400FC8C RID: 64652
		[Token(Token = "0x400FC8C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__MarkInView;

		// Token: 0x0400FC8D RID: 64653
		[Token(Token = "0x400FC8D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_AddTickTile;

		// Token: 0x0400FC8E RID: 64654
		[Token(Token = "0x400FC8E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix1_AddTickTile;

		// Token: 0x0400FC8F RID: 64655
		[Token(Token = "0x400FC8F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_MarkNotInView;

		// Token: 0x0400FC90 RID: 64656
		[Token(Token = "0x400FC90")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_MarkInView;

		// Token: 0x0400FC91 RID: 64657
		[Token(Token = "0x400FC91")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix1_MarkInView;

		// Token: 0x0400FC92 RID: 64658
		[Token(Token = "0x400FC92")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__ResetSandboxBuilder;

		// Token: 0x0400FC93 RID: 64659
		[Token(Token = "0x400FC93")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GetExploredMap;

		// Token: 0x0400FC94 RID: 64660
		[Token(Token = "0x400FC94")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002357 RID: 9047
		[Token(Token = "0x2002357")]
		private class EdgeEffectKey
		{
			// Token: 0x0600E507 RID: 58631 RVA: 0x00052C38 File Offset: 0x00050E38
			[Token(Token = "0x600E507")]
			[Address(RVA = "0x596910", Offset = "0x595510", VA = "0x180596910", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			// Token: 0x0600E508 RID: 58632 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E508")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EdgeEffectKey()
			{
			}

			// Token: 0x0400FC95 RID: 64661
			[Token(Token = "0x400FC95")]
			[FieldOffset(Offset = "0x10")]
			public GridPosition fromGrid;

			// Token: 0x0400FC96 RID: 64662
			[Token(Token = "0x400FC96")]
			[FieldOffset(Offset = "0x18")]
			public GridPosition toGrid;

			// Token: 0x0400FC97 RID: 64663
			[Token(Token = "0x400FC97")]
			[FieldOffset(Offset = "0x20")]
			public SharedConsts.Direction direction;
		}

		// Token: 0x02002358 RID: 9048
		[Token(Token = "0x2002358")]
		private class FogEdgeEffectHolder : ListDict<ViewRangeFogManager.EdgeEffectKey, Effect>, IHotfixable
		{
			// Token: 0x17001CA7 RID: 7335
			[Token(Token = "0x17001CA7")]
			public Effect this[GridPosition fromGridPosition, GridPosition toGridPosition, SharedConsts.Direction direction]
			{
				[Token(Token = "0x600E509")]
				[Address(RVA = "0x596B00", Offset = "0x595700", VA = "0x180596B00")]
				get
				{
					return null;
				}
				[Token(Token = "0x600E50A")]
				[Address(RVA = "0x596BF0", Offset = "0x5957F0", VA = "0x180596BF0")]
				set
				{
				}
			}

			// Token: 0x0600E50B RID: 58635 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E50B")]
			[Address(RVA = "0x596A90", Offset = "0x595690", VA = "0x180596A90")]
			public FogEdgeEffectHolder()
			{
			}

			// Token: 0x0400FC98 RID: 64664
			[Token(Token = "0x400FC98")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_Item;

			// Token: 0x0400FC99 RID: 64665
			[Token(Token = "0x400FC99")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_Item;

			// Token: 0x0400FC9A RID: 64666
			[Token(Token = "0x400FC9A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02002359 RID: 9049
		[Token(Token = "0x2002359")]
		private class RemainingTileTicker : IHotfixable
		{
			// Token: 0x0600E50C RID: 58636 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E50C")]
			[Address(RVA = "0x5A56B0", Offset = "0x5A42B0", VA = "0x1805A56B0")]
			public void OnTick(FP deltaTime)
			{
			}

			// Token: 0x0600E50D RID: 58637 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E50D")]
			[Address(RVA = "0x5A5510", Offset = "0x5A4110", VA = "0x1805A5510")]
			public void AddTickTime(Tile tile, FP time)
			{
			}

			// Token: 0x0600E50E RID: 58638 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E50E")]
			[Address(RVA = "0x5A58B0", Offset = "0x5A44B0", VA = "0x1805A58B0")]
			public RemainingTileTicker()
			{
			}

			// Token: 0x0400FC9B RID: 64667
			[Token(Token = "0x400FC9B")]
			[FieldOffset(Offset = "0x10")]
			public ViewRangeFogManager manager;

			// Token: 0x0400FC9C RID: 64668
			[Token(Token = "0x400FC9C")]
			[FieldOffset(Offset = "0x18")]
			private ListDict<Tile, FP> m_tickTiles;

			// Token: 0x0400FC9D RID: 64669
			[Token(Token = "0x400FC9D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OnTick;

			// Token: 0x0400FC9E RID: 64670
			[Token(Token = "0x400FC9E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_AddTickTime;

			// Token: 0x0400FC9F RID: 64671
			[Token(Token = "0x400FC9F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200235A RID: 9050
		[Token(Token = "0x200235A")]
		private class RangeTileViewHolder : IHotfixable
		{
			// Token: 0x0600E50F RID: 58639 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E50F")]
			[Address(RVA = "0x5A5400", Offset = "0x5A4000", VA = "0x1805A5400")]
			public RangeTileViewHolder(ViewRangeFogManager manager)
			{
			}

			// Token: 0x0600E510 RID: 58640 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E510")]
			[Address(RVA = "0x5A5210", Offset = "0x5A3E10", VA = "0x1805A5210")]
			public void MarkNotInView(string id)
			{
			}

			// Token: 0x0600E511 RID: 58641 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E511")]
			[Address(RVA = "0x5A5030", Offset = "0x5A3C30", VA = "0x1805A5030")]
			public void MarkInView(string id, int leftButtomX, int leftButtomY, int rightUpX, int rightUpY)
			{
			}

			// Token: 0x0400FCA0 RID: 64672
			[Token(Token = "0x400FCA0")]
			[FieldOffset(Offset = "0x10")]
			private ListDict<string, GridPosition> _leftButtomTile;

			// Token: 0x0400FCA1 RID: 64673
			[Token(Token = "0x400FCA1")]
			[FieldOffset(Offset = "0x18")]
			private ListDict<string, GridPosition> _rightUpTile;

			// Token: 0x0400FCA2 RID: 64674
			[Token(Token = "0x400FCA2")]
			[FieldOffset(Offset = "0x20")]
			private ViewRangeFogManager m_manager;

			// Token: 0x0400FCA3 RID: 64675
			[Token(Token = "0x400FCA3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400FCA4 RID: 64676
			[Token(Token = "0x400FCA4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_MarkNotInView;

			// Token: 0x0400FCA5 RID: 64677
			[Token(Token = "0x400FCA5")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_MarkInView;
		}
	}
}
