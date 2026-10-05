using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Atlas;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004290 RID: 17040
	[Token(Token = "0x2004290")]
	[CreateAssetMenu(menuName = "Torappu/SandboxV2/SandboxV2DungeonViewConfig")]
	public class SandboxV2DungeonViewConfig : ScriptableObject, IHotfixable
	{
		// Token: 0x17003E4E RID: 15950
		// (get) Token: 0x0601A413 RID: 107539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003E4E")]
		public SandboxV2LineView lineViewPrefab
		{
			[Token(Token = "0x601A413")]
			[Address(RVA = "0x133D4E0", Offset = "0x133C0E0", VA = "0x18133D4E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003E4F RID: 15951
		// (get) Token: 0x0601A414 RID: 107540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003E4F")]
		public SandboxV2EnemyRushLineView enemyRushLineViewPrefab
		{
			[Token(Token = "0x601A414")]
			[Address(RVA = "0x133D420", Offset = "0x133C020", VA = "0x18133D420")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003E50 RID: 15952
		// (get) Token: 0x0601A415 RID: 107541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003E50")]
		public SandboxV2ZoneView zoneViewPrefab
		{
			[Token(Token = "0x601A415")]
			[Address(RVA = "0x133D5A0", Offset = "0x133C1A0", VA = "0x18133D5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003E51 RID: 15953
		// (get) Token: 0x0601A416 RID: 107542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003E51")]
		public SandboxV2NodeFloatViewHolder nodeFloatViewHolderPrefab
		{
			[Token(Token = "0x601A416")]
			[Address(RVA = "0x133D540", Offset = "0x133C140", VA = "0x18133D540")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003E52 RID: 15954
		// (get) Token: 0x0601A417 RID: 107543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003E52")]
		public SandboxV2DungeonHomeTipView homeTipViewPrefab
		{
			[Token(Token = "0x601A417")]
			[Address(RVA = "0x133D480", Offset = "0x133C080", VA = "0x18133D480")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003E53 RID: 15955
		// (get) Token: 0x0601A418 RID: 107544 RVA: 0x000A0908 File Offset: 0x0009EB08
		[Token(Token = "0x17003E53")]
		public Color defaultItemColor
		{
			[Token(Token = "0x601A418")]
			[Address(RVA = "0x133D3A0", Offset = "0x133BFA0", VA = "0x18133D3A0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x0601A419 RID: 107545 RVA: 0x000A0920 File Offset: 0x0009EB20
		[Token(Token = "0x601A419")]
		[Address(RVA = "0x133D0F0", Offset = "0x133BCF0", VA = "0x18133D0F0")]
		private bool _TryGetWeatherIconData(SandboxV2WeatherType weatherType, out SandboxV2DungeonViewConfig.WeatherIconData weatherIconData)
		{
			return default(bool);
		}

		// Token: 0x0601A41A RID: 107546 RVA: 0x000A0938 File Offset: 0x0009EB38
		[Token(Token = "0x601A41A")]
		[Address(RVA = "0x133CE30", Offset = "0x133BA30", VA = "0x18133CE30")]
		private bool _TryGetNodeViewPrefab(SandboxV2NodeType nodeType, out SandboxV2DungeonViewConfig.NodeViewPrefabData nodeViewPrefabData)
		{
			return default(bool);
		}

		// Token: 0x0601A41B RID: 107547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A41B")]
		[Address(RVA = "0x133BC00", Offset = "0x133A800", VA = "0x18133BC00")]
		public ListDict<string, SandboxV2AbstractBackgroundView> GetBackgroundPrefabList(string backgroundId)
		{
			return null;
		}

		// Token: 0x0601A41C RID: 107548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A41C")]
		[Address(RVA = "0x133CAC0", Offset = "0x133B6C0", VA = "0x18133CAC0")]
		public SandboxV2AbstractNodeView GetNodeViewPrefab(SandboxV2NodeType nodeType)
		{
			return null;
		}

		// Token: 0x0601A41D RID: 107549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A41D")]
		[Address(RVA = "0x133CA20", Offset = "0x133B620", VA = "0x18133CA20")]
		public SandboxV2NodeShadowView GetNodeShadowPrefab(SandboxV2NodeType nodeType)
		{
			return null;
		}

		// Token: 0x0601A41E RID: 107550 RVA: 0x000A0950 File Offset: 0x0009EB50
		[Token(Token = "0x601A41E")]
		[Address(RVA = "0x133C6F0", Offset = "0x133B2F0", VA = "0x18133C6F0")]
		public SpriteRenderData GetNodeAppearanceBkg(SandboxV2NodeType nodeType, SandboxV2NodeAppearanceType nodeAppearanceType)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x0601A41F RID: 107551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A41F")]
		[Address(RVA = "0x133C810", Offset = "0x133B410", VA = "0x18133C810")]
		public SandboxV2DungeonViewConfig.NodeViewAppearanceData GetNodeAppearanceData(SandboxV2NodeType nodeType, SandboxV2NodeAppearanceType nodeAppearanceType)
		{
			return null;
		}

		// Token: 0x0601A420 RID: 107552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A420")]
		[Address(RVA = "0x133CC70", Offset = "0x133B870", VA = "0x18133CC70")]
		public SandboxV2DungeonViewConfig.WeatherIconData GetWeatherIconData(SandboxV2WeatherType weatherType)
		{
			return null;
		}

		// Token: 0x0601A421 RID: 107553 RVA: 0x000A0968 File Offset: 0x0009EB68
		[Token(Token = "0x601A421")]
		[Address(RVA = "0x133BD90", Offset = "0x133A990", VA = "0x18133BD90")]
		public SpriteRenderData GetConstructTipSprite(SandboxV2ConstructTipType tipType)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x0601A422 RID: 107554 RVA: 0x000A0980 File Offset: 0x0009EB80
		[Token(Token = "0x601A422")]
		[Address(RVA = "0x133CD10", Offset = "0x133B910", VA = "0x18133CD10")]
		public SpriteRenderData GetZoneWeatherIcon(SandboxV2WeatherType weatherType)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x0601A423 RID: 107555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A423")]
		[Address(RVA = "0x133CB60", Offset = "0x133B760", VA = "0x18133CB60")]
		public SandboxV2DungeonViewConfig.SeasonData GetSeasonData(SandboxV2SeasonType seasonType)
		{
			return null;
		}

		// Token: 0x0601A424 RID: 107556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A424")]
		[Address(RVA = "0x133C130", Offset = "0x133AD30", VA = "0x18133C130")]
		public SandboxV2DungeonViewConfig.FloatSpriteData GetFloatSpriteData(SandboxV2FloatAppearanceType appearanceType)
		{
			return null;
		}

		// Token: 0x0601A425 RID: 107557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A425")]
		[Address(RVA = "0x133BF20", Offset = "0x133AB20", VA = "0x18133BF20")]
		public SandboxV2DungeonViewConfig.FloatBadgeSpriteData GetFloatBadgeSpriteData(SandboxV2QuestLineBadgeType badgeType)
		{
			return null;
		}

		// Token: 0x0601A426 RID: 107558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A426")]
		[Address(RVA = "0x133C030", Offset = "0x133AC30", VA = "0x18133C030")]
		public string GetFloatEnemyRushStackSpriteData(int stackCount)
		{
			return null;
		}

		// Token: 0x0601A427 RID: 107559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A427")]
		[Address(RVA = "0x133C5C0", Offset = "0x133B1C0", VA = "0x18133C5C0")]
		public SandboxV2DungeonViewConfig.ItemIconData GetItemIconData(string itemId)
		{
			return null;
		}

		// Token: 0x0601A428 RID: 107560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A428")]
		[Address(RVA = "0x133C360", Offset = "0x133AF60", VA = "0x18133C360")]
		public SandboxV2DungeonViewConfig.HomeAppearanceData.HomeHpAppearanceData GetHomeHpAppearanceData(SandboxV2ConstructHpType hpType, bool isEnemyRush)
		{
			return null;
		}

		// Token: 0x0601A429 RID: 107561 RVA: 0x000A0998 File Offset: 0x0009EB98
		[Token(Token = "0x601A429")]
		[Address(RVA = "0x133C240", Offset = "0x133AE40", VA = "0x18133C240")]
		public SpriteRenderData GetHomeBkgSprite(SandboxV2ConstructHpType hpType, bool isEnemyRush)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x0601A42A RID: 107562 RVA: 0x000A09B0 File Offset: 0x0009EBB0
		[Token(Token = "0x601A42A")]
		[Address(RVA = "0x133C4A0", Offset = "0x133B0A0", VA = "0x18133C4A0")]
		public SpriteRenderData GetHomeTipIconSprite(SandboxV2ConstructHpType hpType, bool isEnemyRush)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x0601A42B RID: 107563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A42B")]
		[Address(RVA = "0x133D340", Offset = "0x133BF40", VA = "0x18133D340")]
		public SandboxV2DungeonViewConfig()
		{
		}

		// Token: 0x040213DA RID: 136154
		[Token(Token = "0x40213DA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasObject _atlasObject;

		// Token: 0x040213DB RID: 136155
		[Token(Token = "0x40213DB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<SandboxV2DungeonViewConfig.DungeonBackgroundData> _dungeonBackgroundData;

		// Token: 0x040213DC RID: 136156
		[Token(Token = "0x40213DC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<SandboxV2DungeonViewConfig.NodeViewPrefabData> _nodeViewPrefabData;

		// Token: 0x040213DD RID: 136157
		[Token(Token = "0x40213DD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SandboxV2LineView _lineViewPrefab;

		// Token: 0x040213DE RID: 136158
		[Token(Token = "0x40213DE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SandboxV2EnemyRushLineView _enemyRushLineViewPrefab;

		// Token: 0x040213DF RID: 136159
		[Token(Token = "0x40213DF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SandboxV2ZoneView _zoneViewPrefab;

		// Token: 0x040213E0 RID: 136160
		[Token(Token = "0x40213E0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SandboxV2NodeFloatViewHolder _nodeFloatViewHolderPrefab;

		// Token: 0x040213E1 RID: 136161
		[Token(Token = "0x40213E1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SandboxV2DungeonHomeTipView _homeTipViewPrefab;

		// Token: 0x040213E2 RID: 136162
		[Token(Token = "0x40213E2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<SandboxV2DungeonViewConfig.WeatherIconData> _weatherIconData;

		// Token: 0x040213E3 RID: 136163
		[Token(Token = "0x40213E3")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<SandboxV2DungeonViewConfig.ConstructNodeTipIconData> _constructTipIconData;

		// Token: 0x040213E4 RID: 136164
		[Token(Token = "0x40213E4")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private List<SandboxV2DungeonViewConfig.SeasonData> _seasonData;

		// Token: 0x040213E5 RID: 136165
		[Token(Token = "0x40213E5")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<SandboxV2DungeonViewConfig.FloatSpriteData> _floatSpriteData;

		// Token: 0x040213E6 RID: 136166
		[Token(Token = "0x40213E6")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private List<SandboxV2DungeonViewConfig.FloatBadgeSpriteData> _floatBadgeSpriteData;

		// Token: 0x040213E7 RID: 136167
		[Token(Token = "0x40213E7")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private List<string> _floatEnemyRushStackSpriteData;

		// Token: 0x040213E8 RID: 136168
		[Token(Token = "0x40213E8")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Color _defaultItemColor;

		// Token: 0x040213E9 RID: 136169
		[Token(Token = "0x40213E9")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private List<SandboxV2DungeonViewConfig.ItemIconData> _customItemColors;

		// Token: 0x040213EA RID: 136170
		[Token(Token = "0x40213EA")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private SandboxV2DungeonViewConfig.HomeAppearanceData _homeAppearanceDataNormal;

		// Token: 0x040213EB RID: 136171
		[Token(Token = "0x40213EB")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private SandboxV2DungeonViewConfig.HomeAppearanceData _homeAppearanceDataEnemyRush;

		// Token: 0x040213EC RID: 136172
		[Token(Token = "0x40213EC")]
		[FieldOffset(Offset = "0xB0")]
		private Dictionary<SandboxV2WeatherType, SandboxV2DungeonViewConfig.WeatherIconData> m_weatherIconDict;

		// Token: 0x040213ED RID: 136173
		[Token(Token = "0x40213ED")]
		[FieldOffset(Offset = "0xB8")]
		private Dictionary<SandboxV2NodeType, SandboxV2DungeonViewConfig.NodeViewPrefabData> m_nodeViewPrefabDict;

		// Token: 0x040213EE RID: 136174
		[Token(Token = "0x40213EE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_lineViewPrefab;

		// Token: 0x040213EF RID: 136175
		[Token(Token = "0x40213EF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enemyRushLineViewPrefab;

		// Token: 0x040213F0 RID: 136176
		[Token(Token = "0x40213F0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_zoneViewPrefab;

		// Token: 0x040213F1 RID: 136177
		[Token(Token = "0x40213F1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_nodeFloatViewHolderPrefab;

		// Token: 0x040213F2 RID: 136178
		[Token(Token = "0x40213F2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_homeTipViewPrefab;

		// Token: 0x040213F3 RID: 136179
		[Token(Token = "0x40213F3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_defaultItemColor;

		// Token: 0x040213F4 RID: 136180
		[Token(Token = "0x40213F4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TryGetWeatherIconData;

		// Token: 0x040213F5 RID: 136181
		[Token(Token = "0x40213F5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TryGetNodeViewPrefab;

		// Token: 0x040213F6 RID: 136182
		[Token(Token = "0x40213F6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetBackgroundPrefabList;

		// Token: 0x040213F7 RID: 136183
		[Token(Token = "0x40213F7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetNodeViewPrefab;

		// Token: 0x040213F8 RID: 136184
		[Token(Token = "0x40213F8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetNodeShadowPrefab;

		// Token: 0x040213F9 RID: 136185
		[Token(Token = "0x40213F9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetNodeAppearanceBkg;

		// Token: 0x040213FA RID: 136186
		[Token(Token = "0x40213FA")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetNodeAppearanceData;

		// Token: 0x040213FB RID: 136187
		[Token(Token = "0x40213FB")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetWeatherIconData;

		// Token: 0x040213FC RID: 136188
		[Token(Token = "0x40213FC")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetConstructTipSprite;

		// Token: 0x040213FD RID: 136189
		[Token(Token = "0x40213FD")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetZoneWeatherIcon;

		// Token: 0x040213FE RID: 136190
		[Token(Token = "0x40213FE")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetSeasonData;

		// Token: 0x040213FF RID: 136191
		[Token(Token = "0x40213FF")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_GetFloatSpriteData;

		// Token: 0x04021400 RID: 136192
		[Token(Token = "0x4021400")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_GetFloatBadgeSpriteData;

		// Token: 0x04021401 RID: 136193
		[Token(Token = "0x4021401")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_GetFloatEnemyRushStackSpriteData;

		// Token: 0x04021402 RID: 136194
		[Token(Token = "0x4021402")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GetItemIconData;

		// Token: 0x04021403 RID: 136195
		[Token(Token = "0x4021403")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_GetHomeHpAppearanceData;

		// Token: 0x04021404 RID: 136196
		[Token(Token = "0x4021404")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_GetHomeBkgSprite;

		// Token: 0x04021405 RID: 136197
		[Token(Token = "0x4021405")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_GetHomeTipIconSprite;

		// Token: 0x04021406 RID: 136198
		[Token(Token = "0x4021406")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004291 RID: 17041
		[Token(Token = "0x2004291")]
		[Serializable]
		public class DungeonBackgroundData
		{
			// Token: 0x0601A42C RID: 107564 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A42C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DungeonBackgroundData()
			{
			}

			// Token: 0x04021407 RID: 136199
			[Token(Token = "0x4021407")]
			[FieldOffset(Offset = "0x10")]
			public string backgroundId;

			// Token: 0x04021408 RID: 136200
			[Token(Token = "0x4021408")]
			[FieldOffset(Offset = "0x18")]
			public SandboxV2AbstractBackgroundView backgroundPrefab;
		}

		// Token: 0x02004292 RID: 17042
		[Token(Token = "0x2004292")]
		[Serializable]
		public class NodeViewAppearanceData
		{
			// Token: 0x0601A42D RID: 107565 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A42D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public NodeViewAppearanceData()
			{
			}

			// Token: 0x04021409 RID: 136201
			[Token(Token = "0x4021409")]
			[FieldOffset(Offset = "0x10")]
			public SandboxV2NodeAppearanceType nodeAppearanceType;

			// Token: 0x0402140A RID: 136202
			[Token(Token = "0x402140A")]
			[FieldOffset(Offset = "0x18")]
			public string bkgName;

			// Token: 0x0402140B RID: 136203
			[Token(Token = "0x402140B")]
			[FieldOffset(Offset = "0x20")]
			public Color iconColor;
		}

		// Token: 0x02004293 RID: 17043
		[Token(Token = "0x2004293")]
		[Serializable]
		public class NodeViewPrefabData
		{
			// Token: 0x0601A42E RID: 107566 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A42E")]
			[Address(RVA = "0x1328F10", Offset = "0x1327B10", VA = "0x181328F10")]
			public SandboxV2DungeonViewConfig.NodeViewAppearanceData GetNodeAppearanceData(SandboxV2NodeAppearanceType nodeAppearanceType)
			{
				return null;
			}

			// Token: 0x0601A42F RID: 107567 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A42F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public NodeViewPrefabData()
			{
			}

			// Token: 0x0402140C RID: 136204
			[Token(Token = "0x402140C")]
			[FieldOffset(Offset = "0x10")]
			public SandboxV2AbstractNodeView nodeViewPrefab;

			// Token: 0x0402140D RID: 136205
			[Token(Token = "0x402140D")]
			[FieldOffset(Offset = "0x18")]
			public SandboxV2NodeShadowView nodeShadowPrefab;

			// Token: 0x0402140E RID: 136206
			[Token(Token = "0x402140E")]
			[FieldOffset(Offset = "0x20")]
			public List<SandboxV2NodeType> nodeTypes;

			// Token: 0x0402140F RID: 136207
			[Token(Token = "0x402140F")]
			[FieldOffset(Offset = "0x28")]
			public List<SandboxV2DungeonViewConfig.NodeViewAppearanceData> nodeAppearanceData;

			// Token: 0x04021410 RID: 136208
			[Token(Token = "0x4021410")]
			[FieldOffset(Offset = "0x30")]
			private Dictionary<SandboxV2NodeAppearanceType, SandboxV2DungeonViewConfig.NodeViewAppearanceData> m_nodeViewAppearanceDict;
		}

		// Token: 0x02004294 RID: 17044
		[Token(Token = "0x2004294")]
		[Serializable]
		public class WeatherIconData
		{
			// Token: 0x0601A430 RID: 107568 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A430")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public WeatherIconData()
			{
			}

			// Token: 0x04021411 RID: 136209
			[Token(Token = "0x4021411")]
			[FieldOffset(Offset = "0x10")]
			public SandboxV2WeatherType weatherType;

			// Token: 0x04021412 RID: 136210
			[Token(Token = "0x4021412")]
			[FieldOffset(Offset = "0x14")]
			public Color weatherColor;

			// Token: 0x04021413 RID: 136211
			[Token(Token = "0x4021413")]
			[FieldOffset(Offset = "0x28")]
			public string zoneWeatherIconName;
		}

		// Token: 0x02004295 RID: 17045
		[Token(Token = "0x2004295")]
		[Serializable]
		public class ConstructNodeTipIconData
		{
			// Token: 0x0601A431 RID: 107569 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A431")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ConstructNodeTipIconData()
			{
			}

			// Token: 0x04021414 RID: 136212
			[Token(Token = "0x4021414")]
			[FieldOffset(Offset = "0x10")]
			public SandboxV2ConstructTipType tipType;

			// Token: 0x04021415 RID: 136213
			[Token(Token = "0x4021415")]
			[FieldOffset(Offset = "0x18")]
			public string tipSpriteName;
		}

		// Token: 0x02004296 RID: 17046
		[Token(Token = "0x2004296")]
		[Serializable]
		public class SeasonData
		{
			// Token: 0x0601A432 RID: 107570 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A432")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SeasonData()
			{
			}

			// Token: 0x04021416 RID: 136214
			[Token(Token = "0x4021416")]
			[FieldOffset(Offset = "0x10")]
			public SandboxV2SeasonType seasonType;

			// Token: 0x04021417 RID: 136215
			[Token(Token = "0x4021417")]
			[FieldOffset(Offset = "0x14")]
			public Color seasonColor;
		}

		// Token: 0x02004297 RID: 17047
		[Token(Token = "0x2004297")]
		[Serializable]
		public class ItemIconData
		{
			// Token: 0x0601A433 RID: 107571 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A433")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ItemIconData()
			{
			}

			// Token: 0x04021418 RID: 136216
			[Token(Token = "0x4021418")]
			[FieldOffset(Offset = "0x10")]
			public string itemId;

			// Token: 0x04021419 RID: 136217
			[Token(Token = "0x4021419")]
			[FieldOffset(Offset = "0x18")]
			public Color itemIconColor;
		}

		// Token: 0x02004298 RID: 17048
		[Token(Token = "0x2004298")]
		[Serializable]
		public class HomeAppearanceData
		{
			// Token: 0x0601A434 RID: 107572 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A434")]
			[Address(RVA = "0x1328AD0", Offset = "0x13276D0", VA = "0x181328AD0")]
			public SandboxV2DungeonViewConfig.HomeAppearanceData.HomeHpAppearanceData GetHpAppearanceData(SandboxV2ConstructHpType hpType)
			{
				return null;
			}

			// Token: 0x0601A435 RID: 107573 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A435")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public HomeAppearanceData()
			{
			}

			// Token: 0x0402141A RID: 136218
			[Token(Token = "0x402141A")]
			[FieldOffset(Offset = "0x10")]
			public List<SandboxV2DungeonViewConfig.HomeAppearanceData.HomeHpAppearanceData> hpAppearanceData;

			// Token: 0x02004299 RID: 17049
			[Token(Token = "0x2004299")]
			[Serializable]
			public class HomeHpAppearanceData
			{
				// Token: 0x0601A436 RID: 107574 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x601A436")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public HomeHpAppearanceData()
				{
				}

				// Token: 0x0402141B RID: 136219
				[Token(Token = "0x402141B")]
				[FieldOffset(Offset = "0x10")]
				public SandboxV2ConstructHpType hpType;

				// Token: 0x0402141C RID: 136220
				[Token(Token = "0x402141C")]
				[FieldOffset(Offset = "0x14")]
				public Color hpProgressBarColor;

				// Token: 0x0402141D RID: 136221
				[Token(Token = "0x402141D")]
				[FieldOffset(Offset = "0x24")]
				public Color textBasementLevelColor;

				// Token: 0x0402141E RID: 136222
				[Token(Token = "0x402141E")]
				[FieldOffset(Offset = "0x34")]
				public Color basementIconColor;

				// Token: 0x0402141F RID: 136223
				[Token(Token = "0x402141F")]
				[FieldOffset(Offset = "0x48")]
				public string homeBkgSpriteName;

				// Token: 0x04021420 RID: 136224
				[Token(Token = "0x4021420")]
				[FieldOffset(Offset = "0x50")]
				public string homeTipIconSpriteName;
			}
		}

		// Token: 0x0200429A RID: 17050
		[Token(Token = "0x200429A")]
		[Serializable]
		public class FloatSpriteData
		{
			// Token: 0x0601A437 RID: 107575 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A437")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FloatSpriteData()
			{
			}

			// Token: 0x04021421 RID: 136225
			[Token(Token = "0x4021421")]
			[FieldOffset(Offset = "0x10")]
			public SandboxV2FloatAppearanceType appearanceType;

			// Token: 0x04021422 RID: 136226
			[Token(Token = "0x4021422")]
			[FieldOffset(Offset = "0x14")]
			public Color bkgColor;

			// Token: 0x04021423 RID: 136227
			[Token(Token = "0x4021423")]
			[FieldOffset(Offset = "0x24")]
			public Color frameColor;

			// Token: 0x04021424 RID: 136228
			[Token(Token = "0x4021424")]
			[FieldOffset(Offset = "0x38")]
			public string decoIconId;

			// Token: 0x04021425 RID: 136229
			[Token(Token = "0x4021425")]
			[FieldOffset(Offset = "0x40")]
			public bool showHpBar;

			// Token: 0x04021426 RID: 136230
			[Token(Token = "0x4021426")]
			[FieldOffset(Offset = "0x44")]
			public Color outlineColor;
		}

		// Token: 0x0200429B RID: 17051
		[Token(Token = "0x200429B")]
		[Serializable]
		public class FloatBadgeSpriteData
		{
			// Token: 0x0601A438 RID: 107576 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A438")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FloatBadgeSpriteData()
			{
			}

			// Token: 0x04021427 RID: 136231
			[Token(Token = "0x4021427")]
			[FieldOffset(Offset = "0x10")]
			public SandboxV2QuestLineBadgeType badgeType;

			// Token: 0x04021428 RID: 136232
			[Token(Token = "0x4021428")]
			[FieldOffset(Offset = "0x18")]
			public string badgeIconId;
		}
	}
}
