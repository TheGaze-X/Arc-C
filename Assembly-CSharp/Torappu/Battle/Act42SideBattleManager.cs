using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020022CB RID: 8907
	[Token(Token = "0x20022CB")]
	public class Act42SideBattleManager : GlobalEnvSystem.EnvManager
	{
		// Token: 0x0600E039 RID: 57401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E039")]
		[Address(RVA = "0x366BF90", Offset = "0x366AB90", VA = "0x18366BF90", Slot = "7")]
		public override void Init(GlobalEnvSystem owner)
		{
		}

		// Token: 0x0600E03A RID: 57402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E03A")]
		[Address(RVA = "0x366C1D0", Offset = "0x366ADD0", VA = "0x18366C1D0", Slot = "8")]
		public override void OnPostInit()
		{
		}

		// Token: 0x0600E03B RID: 57403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E03B")]
		[Address(RVA = "0x366BEF0", Offset = "0x366AAF0", VA = "0x18366BEF0", Slot = "9")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600E03C RID: 57404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E03C")]
		[Address(RVA = "0x366C540", Offset = "0x366B140", VA = "0x18366C540", Slot = "15")]
		public override void OnTrigger(object param)
		{
		}

		// Token: 0x0600E03D RID: 57405 RVA: 0x00051678 File Offset: 0x0004F878
		[Token(Token = "0x600E03D")]
		[Address(RVA = "0x366C6F0", Offset = "0x366B2F0", VA = "0x18366C6F0")]
		public bool ShowHiddenAreaByKey(string areaKey)
		{
			return default(bool);
		}

		// Token: 0x0600E03E RID: 57406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E03E")]
		[Address(RVA = "0x366D100", Offset = "0x366BD00", VA = "0x18366D100")]
		private void _UpdateBorderEffect(string effectKey, Tile tile)
		{
		}

		// Token: 0x0600E03F RID: 57407 RVA: 0x00051690 File Offset: 0x0004F890
		[Token(Token = "0x600E03F")]
		[Address(RVA = "0x366CA00", Offset = "0x366B600", VA = "0x18366CA00")]
		private bool _CheckIsSleepTile(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0600E040 RID: 57408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E040")]
		[Address(RVA = "0x366CD70", Offset = "0x366B970", VA = "0x18366CD70")]
		private void _SetSpineAnimatorShaderParam(Character character, float value)
		{
		}

		// Token: 0x0600E041 RID: 57409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E041")]
		[Address(RVA = "0x366D270", Offset = "0x366BE70", VA = "0x18366D270")]
		private void _UpdateSleepTileBorderEffect()
		{
		}

		// Token: 0x0600E042 RID: 57410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E042")]
		[Address(RVA = "0x366C950", Offset = "0x366B550", VA = "0x18366C950")]
		private void _AddSleepTileBuildableChecker()
		{
		}

		// Token: 0x0600E043 RID: 57411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E043")]
		[Address(RVA = "0x366CB00", Offset = "0x366B700", VA = "0x18366CB00")]
		private void _ReInitTileBorderEffect(Tile tile)
		{
		}

		// Token: 0x0600E044 RID: 57412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E044")]
		[Address(RVA = "0x366BDC0", Offset = "0x366A9C0", VA = "0x18366BDC0")]
		private void ActionAllTileInMap_DISPOSE(Action<Tile> internelFunc)
		{
		}

		// Token: 0x0600E045 RID: 57413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E045")]
		[Address(RVA = "0x366CF70", Offset = "0x366BB70", VA = "0x18366CF70")]
		private void _SynInfoWithSpineShaderManager()
		{
		}

		// Token: 0x0600E046 RID: 57414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E046")]
		[Address(RVA = "0x366D320", Offset = "0x366BF20", VA = "0x18366D320")]
		public Act42SideBattleManager()
		{
		}

		// Token: 0x0600E049 RID: 57417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E049")]
		[Address(RVA = "0x550BE0", Offset = "0x54F7E0", VA = "0x180550BE0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600E04A RID: 57418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E04A")]
		[Address(RVA = "0x590AE0", Offset = "0x58F6E0", VA = "0x180590AE0")]
		private void <>xLuaBaseProxy_OnPostInit()
		{
		}

		// Token: 0x0600E04B RID: 57419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E04B")]
		[Address(RVA = "0x550BD0", Offset = "0x54F7D0", VA = "0x180550BD0")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x0600E04C RID: 57420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E04C")]
		[Address(RVA = "0x550C10", Offset = "0x54F810", VA = "0x180550C10")]
		private void <>xLuaBaseProxy_OnTrigger(object P0)
		{
		}

		// Token: 0x0400F42E RID: 62510
		[Token(Token = "0x400F42E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Effect")]
		private List<string> _tileBorderEffects;

		// Token: 0x0400F42F RID: 62511
		[Token(Token = "0x400F42F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Shader")]
		private Shader _replaceShader;

		// Token: 0x0400F430 RID: 62512
		[Token(Token = "0x400F430")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Shader")]
		private Color _sleepTileColor;

		// Token: 0x0400F431 RID: 62513
		[Token(Token = "0x400F431")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Shader")]
		private Color _fadeColor;

		// Token: 0x0400F432 RID: 62514
		[Token(Token = "0x400F432")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isBossLevel;

		// Token: 0x0400F433 RID: 62515
		[Token(Token = "0x400F433")]
		[FieldOffset(Offset = "0x60")]
		private Act42SideBattleManager.HiddenAreaManager m_hiddenAreaManager;

		// Token: 0x0400F434 RID: 62516
		[Token(Token = "0x400F434")]
		[FieldOffset(Offset = "0x68")]
		private Act42SideBattleManager.ACT42SideSleepTileBuildableChecker m_tileBuildableChecker;

		// Token: 0x0400F435 RID: 62517
		[Token(Token = "0x400F435")]
		private const string SLEEP_ROAD_TILE_KEY = "tile_sleep_road";

		// Token: 0x0400F436 RID: 62518
		[Token(Token = "0x400F436")]
		private const string SLEEP_WALL_TILE_KEY = "tile_sleep_wall";

		// Token: 0x0400F437 RID: 62519
		[Token(Token = "0x400F437")]
		private const string IN_SLEEP_STATE = "in_sleep_state";

		// Token: 0x0400F438 RID: 62520
		[Token(Token = "0x400F438")]
		private const string OUT_SLEEP_STATE = "out_sleep_state";

		// Token: 0x0400F439 RID: 62521
		[Token(Token = "0x400F439")]
		private const string SHADER_SLEEP_TILE_COLOR = "_SleepTileColor";

		// Token: 0x0400F43A RID: 62522
		[Token(Token = "0x400F43A")]
		private const string SHADER_SLEEP_FADE_COLOR = "_FadeColor";

		// Token: 0x0400F43B RID: 62523
		[Token(Token = "0x400F43B")]
		private const string SHADER_SPINE_ON_SLEEP_TILE = "_SpineOnSleepTile";

		// Token: 0x0400F43C RID: 62524
		[Token(Token = "0x400F43C")]
		private const float DEFAULT_FADE_HEIGHT = -0.8f;

		// Token: 0x0400F43D RID: 62525
		[Token(Token = "0x400F43D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400F43E RID: 62526
		[Token(Token = "0x400F43E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPostInit;

		// Token: 0x0400F43F RID: 62527
		[Token(Token = "0x400F43F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0400F440 RID: 62528
		[Token(Token = "0x400F440")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTrigger;

		// Token: 0x0400F441 RID: 62529
		[Token(Token = "0x400F441")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ShowHiddenAreaByKey;

		// Token: 0x0400F442 RID: 62530
		[Token(Token = "0x400F442")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateBorderEffect;

		// Token: 0x0400F443 RID: 62531
		[Token(Token = "0x400F443")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CheckIsSleepTile;

		// Token: 0x0400F444 RID: 62532
		[Token(Token = "0x400F444")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SetSpineAnimatorShaderParam;

		// Token: 0x0400F445 RID: 62533
		[Token(Token = "0x400F445")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateSleepTileBorderEffect;

		// Token: 0x0400F446 RID: 62534
		[Token(Token = "0x400F446")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__AddSleepTileBuildableChecker;

		// Token: 0x0400F447 RID: 62535
		[Token(Token = "0x400F447")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ReInitTileBorderEffect;

		// Token: 0x0400F448 RID: 62536
		[Token(Token = "0x400F448")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ActionAllTileInMap_DISPOSE;

		// Token: 0x0400F449 RID: 62537
		[Token(Token = "0x400F449")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__SynInfoWithSpineShaderManager;

		// Token: 0x0400F44A RID: 62538
		[Token(Token = "0x400F44A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020022CC RID: 8908
		[Token(Token = "0x20022CC")]
		public class HiddenAreaManager : IHotfixable
		{
			// Token: 0x0600E04D RID: 57421 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E04D")]
			[Address(RVA = "0x3676A40", Offset = "0x3675640", VA = "0x183676A40")]
			public HiddenAreaManager(Act42SideBattleManager manager)
			{
			}

			// Token: 0x0600E04E RID: 57422 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E04E")]
			[Address(RVA = "0x36747E0", Offset = "0x36733E0", VA = "0x1836747E0")]
			public void Init()
			{
			}

			// Token: 0x0600E04F RID: 57423 RVA: 0x000516A8 File Offset: 0x0004F8A8
			[Token(Token = "0x600E04F")]
			[Address(RVA = "0x3674970", Offset = "0x3673570", VA = "0x183674970")]
			public bool OprHiddenAreaByKey(string areaKey, bool isShow)
			{
				return default(bool);
			}

			// Token: 0x0600E050 RID: 57424 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E050")]
			[Address(RVA = "0x3674E00", Offset = "0x3673A00", VA = "0x183674E00")]
			private void _InitHiddenAreaDictFromBlackboard(Blackboard blackboard)
			{
			}

			// Token: 0x0600E051 RID: 57425 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E051")]
			[Address(RVA = "0x36754A0", Offset = "0x36740A0", VA = "0x1836754A0")]
			private void _InitParam()
			{
			}

			// Token: 0x0600E052 RID: 57426 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E052")]
			[Address(RVA = "0x3674CE0", Offset = "0x36738E0", VA = "0x183674CE0")]
			private void _InitColliderHolder()
			{
			}

			// Token: 0x0600E053 RID: 57427 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E053")]
			[Address(RVA = "0x36751F0", Offset = "0x3673DF0", VA = "0x1836751F0")]
			private void _InitHideHiddenArea()
			{
			}

			// Token: 0x0600E054 RID: 57428 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E054")]
			[Address(RVA = "0x3675610", Offset = "0x3674210", VA = "0x183675610")]
			private void _OprSingleHiddenArea(string areaKey, Rect rect, bool isShow)
			{
			}

			// Token: 0x0600E055 RID: 57429 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E055")]
			[Address(RVA = "0x3675830", Offset = "0x3674430", VA = "0x183675830")]
			private void _OprTile(string areaKey, Tile tile, bool isShow)
			{
			}

			// Token: 0x0600E056 RID: 57430 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E056")]
			[Address(RVA = "0x36762C0", Offset = "0x3674EC0", VA = "0x1836762C0")]
			private void _TileGraphicImmediatelyDissove(string areaKey, Tile tile)
			{
			}

			// Token: 0x0600E057 RID: 57431 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E057")]
			[Address(RVA = "0x3675FF0", Offset = "0x3674BF0", VA = "0x183675FF0")]
			private void _TileGraphicDynamicDissolve(string areaKey, Tile tile)
			{
			}

			// Token: 0x0600E058 RID: 57432 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E058")]
			[Address(RVA = "0x36759D0", Offset = "0x36745D0", VA = "0x1836759D0")]
			private void _PlayTileGraphicDynamicDissolve(string area)
			{
			}

			// Token: 0x0600E059 RID: 57433 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E059")]
			[Address(RVA = "0x3675C50", Offset = "0x3674850", VA = "0x183675C50")]
			private void _TileGraphicDynamicDissolvePostOpr(string areaKey, Tile tile)
			{
			}

			// Token: 0x0400F44B RID: 62539
			[Token(Token = "0x400F44B")]
			[FieldOffset(Offset = "0x10")]
			private ListDict<string, List<Rect>> m_hiddenAreaDict;

			// Token: 0x0400F44C RID: 62540
			[Token(Token = "0x400F44C")]
			[FieldOffset(Offset = "0x18")]
			private ListDict<Tile, Tile.Options> m_cachedOptions;

			// Token: 0x0400F44D RID: 62541
			[Token(Token = "0x400F44D")]
			[FieldOffset(Offset = "0x20")]
			private ListDict<Tile, Material> m_tileMaterialDict;

			// Token: 0x0400F44E RID: 62542
			[Token(Token = "0x400F44E")]
			[FieldOffset(Offset = "0x28")]
			private ListDict<string, List<Tile>> m_hiddenTileManageDict;

			// Token: 0x0400F44F RID: 62543
			[Token(Token = "0x400F44F")]
			[FieldOffset(Offset = "0x30")]
			private ListDict<string, List<Material>> m_materialHashList;

			// Token: 0x0400F450 RID: 62544
			[Token(Token = "0x400F450")]
			[FieldOffset(Offset = "0x38")]
			private Act42SideBattleManager m_manager;

			// Token: 0x0400F451 RID: 62545
			[Token(Token = "0x400F451")]
			[FieldOffset(Offset = "0x40")]
			private GameObject m_colliderHolder;

			// Token: 0x0400F452 RID: 62546
			[Token(Token = "0x400F452")]
			private const string RECT_KEY = "rect_";

			// Token: 0x0400F453 RID: 62547
			[Token(Token = "0x400F453")]
			private const string TILE_KEY = "TILE";

			// Token: 0x0400F454 RID: 62548
			[Token(Token = "0x400F454")]
			private const string Collider_Holder_Key = "ColliderHolder";

			// Token: 0x0400F455 RID: 62549
			[Token(Token = "0x400F455")]
			private const string SHADER_UNIFORM_KEY = "_DissolveClip";

			// Token: 0x0400F456 RID: 62550
			[Token(Token = "0x400F456")]
			private const string COLLIDER_FORMAT_KEY = "collider_{0:D2}_{1:D2}";

			// Token: 0x0400F457 RID: 62551
			[Token(Token = "0x400F457")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400F458 RID: 62552
			[Token(Token = "0x400F458")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x0400F459 RID: 62553
			[Token(Token = "0x400F459")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OprHiddenAreaByKey;

			// Token: 0x0400F45A RID: 62554
			[Token(Token = "0x400F45A")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__InitHiddenAreaDictFromBlackboard;

			// Token: 0x0400F45B RID: 62555
			[Token(Token = "0x400F45B")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__InitParam;

			// Token: 0x0400F45C RID: 62556
			[Token(Token = "0x400F45C")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__InitColliderHolder;

			// Token: 0x0400F45D RID: 62557
			[Token(Token = "0x400F45D")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__InitHideHiddenArea;

			// Token: 0x0400F45E RID: 62558
			[Token(Token = "0x400F45E")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__OprSingleHiddenArea;

			// Token: 0x0400F45F RID: 62559
			[Token(Token = "0x400F45F")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0__OprTile;

			// Token: 0x0400F460 RID: 62560
			[Token(Token = "0x400F460")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0__TileGraphicImmediatelyDissove;

			// Token: 0x0400F461 RID: 62561
			[Token(Token = "0x400F461")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0__TileGraphicDynamicDissolve;

			// Token: 0x0400F462 RID: 62562
			[Token(Token = "0x400F462")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0__PlayTileGraphicDynamicDissolve;

			// Token: 0x0400F463 RID: 62563
			[Token(Token = "0x400F463")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0__TileGraphicDynamicDissolvePostOpr;
		}

		// Token: 0x020022D0 RID: 8912
		[Token(Token = "0x20022D0")]
		public class ACT42SideSleepTileBuildableChecker : ITileBuildableChecker, IHotfixable
		{
			// Token: 0x0600E062 RID: 57442 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E062")]
			[Address(RVA = "0x365E650", Offset = "0x365D250", VA = "0x18365E650")]
			public ACT42SideSleepTileBuildableChecker()
			{
			}

			// Token: 0x0600E063 RID: 57443 RVA: 0x000516D8 File Offset: 0x0004F8D8
			[Token(Token = "0x600E063")]
			[Address(RVA = "0x365E580", Offset = "0x365D180", VA = "0x18365E580", Slot = "4")]
			public bool IsCharacterBuildableOnTile(Tile tile, BattleCharacterData sourceData)
			{
				return default(bool);
			}

			// Token: 0x0400F46B RID: 62571
			[Token(Token = "0x400F46B")]
			private const string TILE_END_EFFECT_NAME = "tile_end_special";

			// Token: 0x0400F46C RID: 62572
			[Token(Token = "0x400F46C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400F46D RID: 62573
			[Token(Token = "0x400F46D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_IsCharacterBuildableOnTile;
		}
	}
}
