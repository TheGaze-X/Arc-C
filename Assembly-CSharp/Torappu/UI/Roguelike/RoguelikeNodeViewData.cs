using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005222 RID: 21026
	[Token(Token = "0x2005222")]
	public class RoguelikeNodeViewData : ScriptableObject, IHotfixable
	{
		// Token: 0x0601F05C RID: 127068 RVA: 0x000B0898 File Offset: 0x000AEA98
		[Token(Token = "0x601F05C")]
		[Address(RVA = "0x18BEC10", Offset = "0x18BD810", VA = "0x1818BEC10")]
		private bool ShouldSerializeunactiveSpriteData()
		{
			return default(bool);
		}

		// Token: 0x1700487D RID: 18557
		// (get) Token: 0x0601F05D RID: 127069 RVA: 0x000B08B0 File Offset: 0x000AEAB0
		[Token(Token = "0x1700487D")]
		public Color inactiveColor
		{
			[Token(Token = "0x601F05D")]
			[Address(RVA = "0x18BF700", Offset = "0x18BE300", VA = "0x1818BF700")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700487E RID: 18558
		// (get) Token: 0x0601F05E RID: 127070 RVA: 0x000B08C8 File Offset: 0x000AEAC8
		[Token(Token = "0x1700487E")]
		public Color activeColor
		{
			[Token(Token = "0x601F05E")]
			[Address(RVA = "0x18BF000", Offset = "0x18BDC00", VA = "0x1818BF000")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700487F RID: 18559
		// (get) Token: 0x0601F05F RID: 127071 RVA: 0x000B08E0 File Offset: 0x000AEAE0
		[Token(Token = "0x1700487F")]
		public Color discardedColor
		{
			[Token(Token = "0x601F05F")]
			[Address(RVA = "0x18BF160", Offset = "0x18BDD60", VA = "0x1818BF160")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17004880 RID: 18560
		// (get) Token: 0x0601F060 RID: 127072 RVA: 0x000B08F8 File Offset: 0x000AEAF8
		[Token(Token = "0x17004880")]
		public Color discardedLineColor
		{
			[Token(Token = "0x601F060")]
			[Address(RVA = "0x18BF260", Offset = "0x18BDE60", VA = "0x1818BF260")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17004881 RID: 18561
		// (get) Token: 0x0601F061 RID: 127073 RVA: 0x000B0910 File Offset: 0x000AEB10
		[Token(Token = "0x17004881")]
		public Color discardedVertLineColor
		{
			[Token(Token = "0x601F061")]
			[Address(RVA = "0x18BF3E0", Offset = "0x18BDFE0", VA = "0x1818BF3E0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17004882 RID: 18562
		// (get) Token: 0x0601F062 RID: 127074 RVA: 0x000B0928 File Offset: 0x000AEB28
		[Token(Token = "0x17004882")]
		public Color discardedReflectLineColor
		{
			[Token(Token = "0x601F062")]
			[Address(RVA = "0x18BF360", Offset = "0x18BDF60", VA = "0x1818BF360")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17004883 RID: 18563
		// (get) Token: 0x0601F063 RID: 127075 RVA: 0x000B0940 File Offset: 0x000AEB40
		[Token(Token = "0x17004883")]
		public Color discardedReflectArrowColor
		{
			[Token(Token = "0x601F063")]
			[Address(RVA = "0x18BF2E0", Offset = "0x18BDEE0", VA = "0x1818BF2E0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17004884 RID: 18564
		// (get) Token: 0x0601F064 RID: 127076 RVA: 0x000B0958 File Offset: 0x000AEB58
		[Token(Token = "0x17004884")]
		public Color discardedBkgColor
		{
			[Token(Token = "0x601F064")]
			[Address(RVA = "0x18BF0E0", Offset = "0x18BDCE0", VA = "0x1818BF0E0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17004885 RID: 18565
		// (get) Token: 0x0601F065 RID: 127077 RVA: 0x000B0970 File Offset: 0x000AEB70
		[Token(Token = "0x17004885")]
		public Color discardedIconColor
		{
			[Token(Token = "0x601F065")]
			[Address(RVA = "0x18BF1E0", Offset = "0x18BDDE0", VA = "0x1818BF1E0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17004886 RID: 18566
		// (get) Token: 0x0601F066 RID: 127078 RVA: 0x000B0988 File Offset: 0x000AEB88
		[Token(Token = "0x17004886")]
		public Color traceColor
		{
			[Token(Token = "0x601F066")]
			[Address(RVA = "0x18BF9B0", Offset = "0x18BE5B0", VA = "0x1818BF9B0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17004887 RID: 18567
		// (get) Token: 0x0601F067 RID: 127079 RVA: 0x000B09A0 File Offset: 0x000AEBA0
		[Token(Token = "0x17004887")]
		public Color traceBkgColor
		{
			[Token(Token = "0x601F067")]
			[Address(RVA = "0x18BF930", Offset = "0x18BE530", VA = "0x1818BF930")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17004888 RID: 18568
		// (get) Token: 0x0601F068 RID: 127080 RVA: 0x000B09B8 File Offset: 0x000AEBB8
		[Token(Token = "0x17004888")]
		public Color traceIconColor
		{
			[Token(Token = "0x601F068")]
			[Address(RVA = "0x18BFAB0", Offset = "0x18BE6B0", VA = "0x1818BFAB0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17004889 RID: 18569
		// (get) Token: 0x0601F069 RID: 127081 RVA: 0x000B09D0 File Offset: 0x000AEBD0
		[Token(Token = "0x17004889")]
		public Color traceDefaultColor
		{
			[Token(Token = "0x601F069")]
			[Address(RVA = "0x18BFA30", Offset = "0x18BE630", VA = "0x1818BFA30")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700488A RID: 18570
		// (get) Token: 0x0601F06A RID: 127082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700488A")]
		public Sprite bossIcon
		{
			[Token(Token = "0x601F06A")]
			[Address(RVA = "0x18BF080", Offset = "0x18BDC80", VA = "0x1818BF080")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700488B RID: 18571
		// (get) Token: 0x0601F06B RID: 127083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700488B")]
		public Sprite finalBossIcon
		{
			[Token(Token = "0x601F06B")]
			[Address(RVA = "0x18BF460", Offset = "0x18BE060", VA = "0x1818BF460")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700488C RID: 18572
		// (get) Token: 0x0601F06C RID: 127084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700488C")]
		public Sprite lineImg
		{
			[Token(Token = "0x601F06C")]
			[Address(RVA = "0x18BF7E0", Offset = "0x18BE3E0", VA = "0x1818BF7E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700488D RID: 18573
		// (get) Token: 0x0601F06D RID: 127085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700488D")]
		public Sprite lineHiddenImg
		{
			[Token(Token = "0x601F06D")]
			[Address(RVA = "0x18BF780", Offset = "0x18BE380", VA = "0x1818BF780")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700488E RID: 18574
		// (get) Token: 0x0601F06E RID: 127086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700488E")]
		public Sprite lineLockedImg
		{
			[Token(Token = "0x601F06E")]
			[Address(RVA = "0x18BF840", Offset = "0x18BE440", VA = "0x1818BF840")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700488F RID: 18575
		// (get) Token: 0x0601F06F RID: 127087 RVA: 0x000B09E8 File Offset: 0x000AEBE8
		[Token(Token = "0x1700488F")]
		public Color vertLineDefaultColor
		{
			[Token(Token = "0x601F06F")]
			[Address(RVA = "0x18BFBC0", Offset = "0x18BE7C0", VA = "0x1818BFBC0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17004890 RID: 18576
		// (get) Token: 0x0601F070 RID: 127088 RVA: 0x000B0A00 File Offset: 0x000AEC00
		[Token(Token = "0x17004890")]
		public Color hideBattleColor
		{
			[Token(Token = "0x601F070")]
			[Address(RVA = "0x18BF5E0", Offset = "0x18BE1E0", VA = "0x1818BF5E0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17004891 RID: 18577
		// (get) Token: 0x0601F071 RID: 127089 RVA: 0x000B0A18 File Offset: 0x000AEC18
		[Token(Token = "0x17004891")]
		public Color hideEventColor
		{
			[Token(Token = "0x601F071")]
			[Address(RVA = "0x18BF670", Offset = "0x18BE270", VA = "0x1818BF670")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17004892 RID: 18578
		// (get) Token: 0x0601F072 RID: 127090 RVA: 0x000B0A30 File Offset: 0x000AEC30
		[Token(Token = "0x17004892")]
		public Color hideBarBattleColor
		{
			[Token(Token = "0x601F072")]
			[Address(RVA = "0x18BF4C0", Offset = "0x18BE0C0", VA = "0x1818BF4C0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17004893 RID: 18579
		// (get) Token: 0x0601F073 RID: 127091 RVA: 0x000B0A48 File Offset: 0x000AEC48
		[Token(Token = "0x17004893")]
		public Color hideBarEventColor
		{
			[Token(Token = "0x601F073")]
			[Address(RVA = "0x18BF550", Offset = "0x18BE150", VA = "0x1818BF550")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17004894 RID: 18580
		// (get) Token: 0x0601F074 RID: 127092 RVA: 0x000B0A60 File Offset: 0x000AEC60
		[Token(Token = "0x17004894")]
		public Color selectedTextColor
		{
			[Token(Token = "0x601F074")]
			[Address(RVA = "0x18BF8A0", Offset = "0x18BE4A0", VA = "0x1818BF8A0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17004895 RID: 18581
		// (get) Token: 0x0601F075 RID: 127093 RVA: 0x000B0A78 File Offset: 0x000AEC78
		[Token(Token = "0x17004895")]
		public Color unSelectedTextColor
		{
			[Token(Token = "0x601F075")]
			[Address(RVA = "0x18BFB30", Offset = "0x18BE730", VA = "0x1818BFB30")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x0601F076 RID: 127094 RVA: 0x000B0A90 File Offset: 0x000AEC90
		[Token(Token = "0x601F076")]
		[Address(RVA = "0x18BE850", Offset = "0x18BD450", VA = "0x1818BE850")]
		public Color GetSelectableColor(RoguelikeEventType type, bool isFinalBoss, PlayerNodeForesightType foresightType, bool isInTrace)
		{
			return default(Color);
		}

		// Token: 0x0601F077 RID: 127095 RVA: 0x000B0AA8 File Offset: 0x000AECA8
		[Token(Token = "0x601F077")]
		[Address(RVA = "0x18BE140", Offset = "0x18BCD40", VA = "0x1818BE140")]
		public Color GetBottomBarColor(RoguelikeEventType type, bool isFinalBoss, PlayerNodeForesightType foresightType, bool isInTrace)
		{
			return default(Color);
		}

		// Token: 0x0601F078 RID: 127096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F078")]
		[Address(RVA = "0x18BE3D0", Offset = "0x18BCFD0", VA = "0x1818BE3D0")]
		public Sprite GetIcon(RoguelikeEventType type, PlayerNodeForesightType foresightType, bool isInTrace, int nodeDisplaySubType = 0)
		{
			return null;
		}

		// Token: 0x0601F079 RID: 127097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F079")]
		[Address(RVA = "0x18BEA90", Offset = "0x18BD690", VA = "0x1818BEA90")]
		public Sprite GetUnactiveIcon(RoguelikeEventType type, int nodeDisplaySubType = 0)
		{
			return null;
		}

		// Token: 0x0601F07A RID: 127098 RVA: 0x000B0AC0 File Offset: 0x000AECC0
		[Token(Token = "0x601F07A")]
		[Address(RVA = "0x18BEC70", Offset = "0x18BD870", VA = "0x1818BEC70")]
		private bool _TryFindSubTypeIcon(List<RoguelikeNodeViewData.NodeSubTypeData> dataList, RoguelikeEventType type, int nodeDisplaySubType, out Sprite sprite)
		{
			return default(bool);
		}

		// Token: 0x0601F07B RID: 127099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F07B")]
		[Address(RVA = "0x18BDFF0", Offset = "0x18BCBF0", VA = "0x1818BDFF0")]
		public Sprite GetBackIcon(RoguelikeEventType type)
		{
			return null;
		}

		// Token: 0x0601F07C RID: 127100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F07C")]
		[Address(RVA = "0x18BE560", Offset = "0x18BD160", VA = "0x1818BE560")]
		public Sprite GetNameIcon(RoguelikeEventType type, PlayerNodeForesightType foresightType, bool isInTrace)
		{
			return null;
		}

		// Token: 0x0601F07D RID: 127101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F07D")]
		[Address(RVA = "0x18BE6A0", Offset = "0x18BD2A0", VA = "0x1818BE6A0")]
		public GameObject GetParticlePrefab(RoguelikeEventType type, bool isFinalBoss, PlayerNodeForesightType foresightType)
		{
			return null;
		}

		// Token: 0x0601F07E RID: 127102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F07E")]
		[Address(RVA = "0x18BEDC0", Offset = "0x18BD9C0", VA = "0x1818BEDC0")]
		public RoguelikeNodeViewData()
		{
		}

		// Token: 0x040299D2 RID: 170450
		[Token(Token = "0x40299D2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color _inactiveColor;

		// Token: 0x040299D3 RID: 170451
		[Token(Token = "0x40299D3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _activeColor;

		// Token: 0x040299D4 RID: 170452
		[Token(Token = "0x40299D4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("discarded")]
		private Color _discardedColor;

		// Token: 0x040299D5 RID: 170453
		[Token(Token = "0x40299D5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("discarded")]
		private Color _discardedLineColor;

		// Token: 0x040299D6 RID: 170454
		[Token(Token = "0x40299D6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("discarded")]
		private Color _discardedVertLineColor;

		// Token: 0x040299D7 RID: 170455
		[Token(Token = "0x40299D7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("discarded")]
		private Color _discardedReflectLineColor;

		// Token: 0x040299D8 RID: 170456
		[Token(Token = "0x40299D8")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("discarded")]
		private Color _discardedReflectArrowColor;

		// Token: 0x040299D9 RID: 170457
		[Token(Token = "0x40299D9")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("discarded")]
		private Color _discardedBkgColor;

		// Token: 0x040299DA RID: 170458
		[Token(Token = "0x40299DA")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("discarded")]
		private Color _discardedIconColor;

		// Token: 0x040299DB RID: 170459
		[Token(Token = "0x40299DB")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Trace")]
		private Color _traceColor;

		// Token: 0x040299DC RID: 170460
		[Token(Token = "0x40299DC")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Trace")]
		private Color _traceBkgColor;

		// Token: 0x040299DD RID: 170461
		[Token(Token = "0x40299DD")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Trace")]
		private Color _traceIconColor;

		// Token: 0x040299DE RID: 170462
		[Token(Token = "0x40299DE")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Trace")]
		private Color _traceDefaultColor;

		// Token: 0x040299DF RID: 170463
		[Token(Token = "0x40299DF")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Trace")]
		private Color _vertLineDefaultColor;

		// Token: 0x040299E0 RID: 170464
		[Token(Token = "0x40299E0")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private List<RoguelikeNodeViewData.ColorData> _selectableColors;

		// Token: 0x040299E1 RID: 170465
		[Token(Token = "0x40299E1")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private List<RoguelikeNodeViewData.ColorData> _bottomBarColors;

		// Token: 0x040299E2 RID: 170466
		[Token(Token = "0x40299E2")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private List<RoguelikeNodeViewData.SpriteData> _activeIcons;

		// Token: 0x040299E3 RID: 170467
		[Token(Token = "0x40299E3")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private List<RoguelikeNodeViewData.SpriteData> _nameIcons;

		// Token: 0x040299E4 RID: 170468
		[Token(Token = "0x40299E4")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private List<RoguelikeNodeViewData.ParticleData> _particles;

		// Token: 0x040299E5 RID: 170469
		[Token(Token = "0x40299E5")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private Sprite _bossIcon;

		// Token: 0x040299E6 RID: 170470
		[Token(Token = "0x40299E6")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private Sprite _finalBossIcon;

		// Token: 0x040299E7 RID: 170471
		[Token(Token = "0x40299E7")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private Sprite _lineImg;

		// Token: 0x040299E8 RID: 170472
		[Token(Token = "0x40299E8")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private Sprite _lineLockedImg;

		// Token: 0x040299E9 RID: 170473
		[Token(Token = "0x40299E9")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private Sprite _lineHiddenImg;

		// Token: 0x040299EA RID: 170474
		[Token(Token = "0x40299EA")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		[Group("VisiblePart")]
		private Sprite _hideBattleImg;

		// Token: 0x040299EB RID: 170475
		[Token(Token = "0x40299EB")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		[Group("VisiblePart")]
		private Sprite _hideEventImg;

		// Token: 0x040299EC RID: 170476
		[Token(Token = "0x40299EC")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		[Group("VisiblePart")]
		private Color _hideBattleColor;

		// Token: 0x040299ED RID: 170477
		[Token(Token = "0x40299ED")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		[Group("VisiblePart")]
		private Color _hideEventColor;

		// Token: 0x040299EE RID: 170478
		[Token(Token = "0x40299EE")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		[Group("VisiblePart")]
		private Color _hideBarBattleColor;

		// Token: 0x040299EF RID: 170479
		[Token(Token = "0x40299EF")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		[Group("VisiblePart")]
		private Color _hideBarEventColor;

		// Token: 0x040299F0 RID: 170480
		[Token(Token = "0x40299F0")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		[Group("VisiblePart")]
		private GameObject _hideBarBattleEffect;

		// Token: 0x040299F1 RID: 170481
		[Token(Token = "0x40299F1")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		[Group("VisiblePart")]
		private GameObject _hideBarEventEffect;

		// Token: 0x040299F2 RID: 170482
		[Token(Token = "0x40299F2")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private bool _useUnActiveSpriteDataFlag;

		// Token: 0x040299F3 RID: 170483
		[Token(Token = "0x40299F3")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private RoguelikeNodeViewData.UnActiveNodeData _unactiveSpriteData;

		// Token: 0x040299F4 RID: 170484
		[Token(Token = "0x40299F4")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private RoguelikeNodeViewData.UnActiveNodeData _backImgData;

		// Token: 0x040299F5 RID: 170485
		[Token(Token = "0x40299F5")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private List<RoguelikeNodeViewData.NodeSubTypeData> _activeSubTypeSpriteData;

		// Token: 0x040299F6 RID: 170486
		[Token(Token = "0x40299F6")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private List<RoguelikeNodeViewData.NodeSubTypeData> _unactiveSubTypeSpriteData;

		// Token: 0x040299F7 RID: 170487
		[Token(Token = "0x40299F7")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		private Color _finalBossColor;

		// Token: 0x040299F8 RID: 170488
		[Token(Token = "0x40299F8")]
		[FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		private GameObject _finalBossEffect;

		// Token: 0x040299F9 RID: 170489
		[Token(Token = "0x40299F9")]
		[FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		[Group("TextColor")]
		private Color _selectedTextColor;

		// Token: 0x040299FA RID: 170490
		[Token(Token = "0x40299FA")]
		[FieldOffset(Offset = "0x1F8")]
		[SerializeField]
		[Group("TextColor")]
		private Color _unSelectedTextColor;

		// Token: 0x040299FB RID: 170491
		[Token(Token = "0x40299FB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShouldSerializeunactiveSpriteData;

		// Token: 0x040299FC RID: 170492
		[Token(Token = "0x40299FC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_inactiveColor;

		// Token: 0x040299FD RID: 170493
		[Token(Token = "0x40299FD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_activeColor;

		// Token: 0x040299FE RID: 170494
		[Token(Token = "0x40299FE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_discardedColor;

		// Token: 0x040299FF RID: 170495
		[Token(Token = "0x40299FF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_discardedLineColor;

		// Token: 0x04029A00 RID: 170496
		[Token(Token = "0x4029A00")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_discardedVertLineColor;

		// Token: 0x04029A01 RID: 170497
		[Token(Token = "0x4029A01")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_discardedReflectLineColor;

		// Token: 0x04029A02 RID: 170498
		[Token(Token = "0x4029A02")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_discardedReflectArrowColor;

		// Token: 0x04029A03 RID: 170499
		[Token(Token = "0x4029A03")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_discardedBkgColor;

		// Token: 0x04029A04 RID: 170500
		[Token(Token = "0x4029A04")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_discardedIconColor;

		// Token: 0x04029A05 RID: 170501
		[Token(Token = "0x4029A05")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_traceColor;

		// Token: 0x04029A06 RID: 170502
		[Token(Token = "0x4029A06")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_traceBkgColor;

		// Token: 0x04029A07 RID: 170503
		[Token(Token = "0x4029A07")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_traceIconColor;

		// Token: 0x04029A08 RID: 170504
		[Token(Token = "0x4029A08")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_traceDefaultColor;

		// Token: 0x04029A09 RID: 170505
		[Token(Token = "0x4029A09")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_bossIcon;

		// Token: 0x04029A0A RID: 170506
		[Token(Token = "0x4029A0A")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_finalBossIcon;

		// Token: 0x04029A0B RID: 170507
		[Token(Token = "0x4029A0B")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_lineImg;

		// Token: 0x04029A0C RID: 170508
		[Token(Token = "0x4029A0C")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_lineHiddenImg;

		// Token: 0x04029A0D RID: 170509
		[Token(Token = "0x4029A0D")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_lineLockedImg;

		// Token: 0x04029A0E RID: 170510
		[Token(Token = "0x4029A0E")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_vertLineDefaultColor;

		// Token: 0x04029A0F RID: 170511
		[Token(Token = "0x4029A0F")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_hideBattleColor;

		// Token: 0x04029A10 RID: 170512
		[Token(Token = "0x4029A10")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_hideEventColor;

		// Token: 0x04029A11 RID: 170513
		[Token(Token = "0x4029A11")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_hideBarBattleColor;

		// Token: 0x04029A12 RID: 170514
		[Token(Token = "0x4029A12")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_hideBarEventColor;

		// Token: 0x04029A13 RID: 170515
		[Token(Token = "0x4029A13")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_selectedTextColor;

		// Token: 0x04029A14 RID: 170516
		[Token(Token = "0x4029A14")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_unSelectedTextColor;

		// Token: 0x04029A15 RID: 170517
		[Token(Token = "0x4029A15")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_GetSelectableColor;

		// Token: 0x04029A16 RID: 170518
		[Token(Token = "0x4029A16")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_GetBottomBarColor;

		// Token: 0x04029A17 RID: 170519
		[Token(Token = "0x4029A17")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_GetIcon;

		// Token: 0x04029A18 RID: 170520
		[Token(Token = "0x4029A18")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_GetUnactiveIcon;

		// Token: 0x04029A19 RID: 170521
		[Token(Token = "0x4029A19")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__TryFindSubTypeIcon;

		// Token: 0x04029A1A RID: 170522
		[Token(Token = "0x4029A1A")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_GetBackIcon;

		// Token: 0x04029A1B RID: 170523
		[Token(Token = "0x4029A1B")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_GetNameIcon;

		// Token: 0x04029A1C RID: 170524
		[Token(Token = "0x4029A1C")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_GetParticlePrefab;

		// Token: 0x04029A1D RID: 170525
		[Token(Token = "0x4029A1D")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005223 RID: 21027
		[Token(Token = "0x2005223")]
		[Serializable]
		private class ColorData
		{
			// Token: 0x0601F07F RID: 127103 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F07F")]
			[Address(RVA = "0x18AD940", Offset = "0x18AC540", VA = "0x1818AD940")]
			public ColorData()
			{
			}

			// Token: 0x04029A1E RID: 170526
			[Token(Token = "0x4029A1E")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeEventType type;

			// Token: 0x04029A1F RID: 170527
			[Token(Token = "0x4029A1F")]
			[FieldOffset(Offset = "0x14")]
			public Color color;
		}

		// Token: 0x02005224 RID: 21028
		[Token(Token = "0x2005224")]
		[Serializable]
		private class SpriteData
		{
			// Token: 0x0601F080 RID: 127104 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F080")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SpriteData()
			{
			}

			// Token: 0x04029A20 RID: 170528
			[Token(Token = "0x4029A20")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeEventType type;

			// Token: 0x04029A21 RID: 170529
			[Token(Token = "0x4029A21")]
			[FieldOffset(Offset = "0x18")]
			public Sprite icon;
		}

		// Token: 0x02005225 RID: 21029
		[Token(Token = "0x2005225")]
		[Serializable]
		private class ParticleData
		{
			// Token: 0x0601F081 RID: 127105 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F081")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ParticleData()
			{
			}

			// Token: 0x04029A22 RID: 170530
			[Token(Token = "0x4029A22")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeEventType type;

			// Token: 0x04029A23 RID: 170531
			[Token(Token = "0x4029A23")]
			[FieldOffset(Offset = "0x18")]
			public GameObject prefab;
		}

		// Token: 0x02005226 RID: 21030
		[Token(Token = "0x2005226")]
		[Serializable]
		private class UnActiveNodeData
		{
			// Token: 0x0601F082 RID: 127106 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F082")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public UnActiveNodeData()
			{
			}

			// Token: 0x04029A24 RID: 170532
			[Token(Token = "0x4029A24")]
			[FieldOffset(Offset = "0x10")]
			public List<RoguelikeNodeViewData.SpriteData> spriteDatas;
		}

		// Token: 0x02005227 RID: 21031
		[Token(Token = "0x2005227")]
		[Serializable]
		private class NodeSubTypeData
		{
			// Token: 0x0601F083 RID: 127107 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F083")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public NodeSubTypeData()
			{
			}

			// Token: 0x04029A25 RID: 170533
			[Token(Token = "0x4029A25")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeEventType type;

			// Token: 0x04029A26 RID: 170534
			[Token(Token = "0x4029A26")]
			[FieldOffset(Offset = "0x14")]
			public int nodeDisplaySubType;

			// Token: 0x04029A27 RID: 170535
			[Token(Token = "0x4029A27")]
			[FieldOffset(Offset = "0x18")]
			public Sprite icon;
		}
	}
}
