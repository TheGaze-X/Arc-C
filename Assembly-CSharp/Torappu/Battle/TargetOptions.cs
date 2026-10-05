using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x02002540 RID: 9536
	[Token(Token = "0x2002540")]
	[Serializable]
	public struct TargetOptions
	{
		// Token: 0x17002030 RID: 8240
		// (get) Token: 0x0600F5F2 RID: 62962 RVA: 0x0005B770 File Offset: 0x00059970
		[Token(Token = "0x17002030")]
		public bool enableAdvanced
		{
			[Token(Token = "0x600F5F2")]
			[Address(RVA = "0x6DF1E0", Offset = "0x6DDDE0", VA = "0x1806DF1E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002031 RID: 8241
		// (get) Token: 0x0600F5F3 RID: 62963 RVA: 0x0005B788 File Offset: 0x00059988
		[Token(Token = "0x17002031")]
		public bool ignoreTargetFreeOptions
		{
			[Token(Token = "0x600F5F3")]
			[Address(RVA = "0x6DF1F0", Offset = "0x6DDDF0", VA = "0x1806DF1F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002032 RID: 8242
		// (get) Token: 0x0600F5F4 RID: 62964 RVA: 0x0005B7A0 File Offset: 0x000599A0
		[Token(Token = "0x17002032")]
		public bool onlyIgnoreSomeOfTargetFreeCaseOptions
		{
			[Token(Token = "0x600F5F4")]
			[Address(RVA = "0x6DF200", Offset = "0x6DDE00", VA = "0x1806DF200")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002033 RID: 8243
		// (get) Token: 0x0600F5F5 RID: 62965 RVA: 0x0005B7B8 File Offset: 0x000599B8
		[Token(Token = "0x17002033")]
		public bool forceExcludeSomeAbnormalFlags
		{
			[Token(Token = "0x600F5F5")]
			[Address(RVA = "0x4E6310", Offset = "0x4E4F10", VA = "0x1804E6310")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002034 RID: 8244
		// (get) Token: 0x0600F5F6 RID: 62966 RVA: 0x0005B7D0 File Offset: 0x000599D0
		[Token(Token = "0x17002034")]
		public SideType targetSideMask
		{
			[Token(Token = "0x600F5F6")]
			[Address(RVA = "0x6DF220", Offset = "0x6DDE20", VA = "0x1806DF220")]
			get
			{
				return SideType.NONE;
			}
		}

		// Token: 0x17002035 RID: 8245
		// (get) Token: 0x0600F5F7 RID: 62967 RVA: 0x0005B7E8 File Offset: 0x000599E8
		[Token(Token = "0x17002035")]
		public PlayerSideMask sourcePlayerSideMask
		{
			[Token(Token = "0x600F5F7")]
			[Address(RVA = "0x6DF210", Offset = "0x6DDE10", VA = "0x1806DF210")]
			get
			{
				return PlayerSideMask.ALL;
			}
		}

		// Token: 0x0600F5F8 RID: 62968 RVA: 0x0005B800 File Offset: 0x00059A00
		[Token(Token = "0x600F5F8")]
		[Address(RVA = "0x6DE960", Offset = "0x6DD560", VA = "0x1806DE960")]
		public static TargetOptions EasyOptions(SideType sideType, MotionMask motionMask, EntityCategory category)
		{
			return default(TargetOptions);
		}

		// Token: 0x0600F5F9 RID: 62969 RVA: 0x0005B818 File Offset: 0x00059A18
		[Token(Token = "0x600F5F9")]
		[Address(RVA = "0x6DE870", Offset = "0x6DD470", VA = "0x1806DE870")]
		public static TargetOptions AdvancedOptions(SideType targetSide, MotionMask motionMask, EntityCategory category, Entity source, SideType sourceSide, PlayerSideMask playerSide, ActionPurposeMask purposeMask, bool ignoreTargetFree, bool ignoreAllyTargetFree, bool ignoreHealFree, bool onlyIgnoreSomeOfTargetFreeCase, AbnormalFlag abnormalFlag, AbnormalCombo abnormalCombo, ProfessionCategory professionMask)
		{
			return default(TargetOptions);
		}

		// Token: 0x0600F5FA RID: 62970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5FA")]
		[Address(RVA = "0x6DE9F0", Offset = "0x6DD5F0", VA = "0x1806DE9F0")]
		public void Init(SideType sourceType, PlayerSideMask sourcePlayerSideMask, Entity source)
		{
		}

		// Token: 0x0600F5FB RID: 62971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5FB")]
		[Address(RVA = "0x6DE9A0", Offset = "0x6DD5A0", VA = "0x1806DE9A0")]
		public void Init(SideType sourceType, PlayerSide sourcePlayerSide, Entity source)
		{
		}

		// Token: 0x0600F5FC RID: 62972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5FC")]
		[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
		public void SetPurposeMask(ActionPurposeMask purposeMask)
		{
		}

		// Token: 0x0600F5FD RID: 62973 RVA: 0x0005B830 File Offset: 0x00059A30
		[Token(Token = "0x600F5FD")]
		[Address(RVA = "0x6DE990", Offset = "0x6DD590", VA = "0x1806DE990")]
		public int GetLayerMask()
		{
			return 0;
		}

		// Token: 0x0600F5FE RID: 62974 RVA: 0x0005B848 File Offset: 0x00059A48
		[Token(Token = "0x600F5FE")]
		[Address(RVA = "0x6DEC00", Offset = "0x6DD800", VA = "0x1806DEC00")]
		public bool VerifyTarget(Entity target, bool checkExtraProfession = false)
		{
			return default(bool);
		}

		// Token: 0x0600F5FF RID: 62975 RVA: 0x0005B860 File Offset: 0x00059A60
		[Token(Token = "0x600F5FF")]
		[Address(RVA = "0x6DEB00", Offset = "0x6DD700", VA = "0x1806DEB00")]
		public bool VerifyTargetWithPlayerSide(Entity target, bool checkExtraProfession = false)
		{
			return default(bool);
		}

		// Token: 0x0600F600 RID: 62976 RVA: 0x0005B878 File Offset: 0x00059A78
		[Token(Token = "0x600F600")]
		[Address(RVA = "0x6DEB90", Offset = "0x6DD790", VA = "0x1806DEB90")]
		public bool VerifyTargetWithoutCheckingTargetSide(Entity target, bool checkExtraProfession = false)
		{
			return default(bool);
		}

		// Token: 0x0600F601 RID: 62977 RVA: 0x0005B890 File Offset: 0x00059A90
		[Token(Token = "0x600F601")]
		[Address(RVA = "0x6DEE20", Offset = "0x6DDA20", VA = "0x1806DEE20")]
		private bool _TryGetSourceMotionMode(out MotionMode motion)
		{
			return default(bool);
		}

		// Token: 0x0600F602 RID: 62978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F602")]
		[Address(RVA = "0x6DEC90", Offset = "0x6DD890", VA = "0x1806DEC90")]
		private void _InitSourceSnapshot(Entity source)
		{
		}

		// Token: 0x0600F603 RID: 62979 RVA: 0x0005B8A8 File Offset: 0x00059AA8
		[Token(Token = "0x600F603")]
		[Address(RVA = "0x6DEF10", Offset = "0x6DDB10", VA = "0x1806DEF10")]
		private bool _VerifyAdvanced(Entity target, bool checkExtraProfession)
		{
			return default(bool);
		}

		// Token: 0x0600F604 RID: 62980 RVA: 0x0005B8C0 File Offset: 0x00059AC0
		[Token(Token = "0x600F604")]
		[Address(RVA = "0x6DF1D0", Offset = "0x6DDDD0", VA = "0x1806DF1D0")]
		private bool _VerifyExtraProfession(ProfessionCategory extraProfession)
		{
			return default(bool);
		}

		// Token: 0x040110C4 RID: 69828
		[Token(Token = "0x40110C4")]
		[FieldOffset(Offset = "0x0")]
		[Help("TargetOptionsUtils.IsValidTargetSide", HelpType.Error, "Invalid target side")]
		public SideType targetSide;

		// Token: 0x040110C5 RID: 69829
		[Token(Token = "0x40110C5")]
		[FieldOffset(Offset = "0x4")]
		public MotionMask targetMotion;

		// Token: 0x040110C6 RID: 69830
		[Token(Token = "0x40110C6")]
		[FieldOffset(Offset = "0x8")]
		[Enum(true, EnumDisplay.Checkbox)]
		public EntityCategory targetCategory;

		// Token: 0x040110C7 RID: 69831
		[Token(Token = "0x40110C7")]
		[FieldOffset(Offset = "0xC")]
		public bool enableAdvancedOptions;

		// Token: 0x040110C8 RID: 69832
		[Token(Token = "0x40110C8")]
		[FieldOffset(Offset = "0xD")]
		[Inspect("enableAdvanced")]
		public bool ignoreTargetFree;

		// Token: 0x040110C9 RID: 69833
		[Token(Token = "0x40110C9")]
		[FieldOffset(Offset = "0xE")]
		[Inspect("enableAdvanced")]
		public bool ignoreAllyTargetFree;

		// Token: 0x040110CA RID: 69834
		[Token(Token = "0x40110CA")]
		[FieldOffset(Offset = "0xF")]
		[Inspect("enableAdvanced")]
		public bool ignoreHealFree;

		// Token: 0x040110CB RID: 69835
		[Token(Token = "0x40110CB")]
		[FieldOffset(Offset = "0x10")]
		[Inspect("enableAdvanced")]
		[Tooltip("If this is |true|, means target side is useless, m_targetMask is all side")]
		public bool ignoreTargetSide;

		// Token: 0x040110CC RID: 69836
		[Token(Token = "0x40110CC")]
		[FieldOffset(Offset = "0x11")]
		[Inspect("enableAdvanced")]
		public bool excludeSomeAbnormalFlags;

		// Token: 0x040110CD RID: 69837
		[Token(Token = "0x40110CD")]
		[FieldOffset(Offset = "0x14")]
		[Inspect("forceExcludeSomeAbnormalFlags")]
		public AbnormalFlag excludeAbnormalFlag;

		// Token: 0x040110CE RID: 69838
		[Token(Token = "0x40110CE")]
		[FieldOffset(Offset = "0x18")]
		[Inspect("enableAdvanced")]
		[Enum(true, EnumDisplay.Checkbox)]
		public ActionPurposeMask purposeMask;

		// Token: 0x040110CF RID: 69839
		[Token(Token = "0x40110CF")]
		[FieldOffset(Offset = "0x1C")]
		[Inspect("enableAdvanced")]
		[Tooltip("If this is |NONE|, it means we won't use this mask. That is, |NONE| is equal to |ALL|.")]
		[Enum(true, EnumDisplay.Checkbox)]
		public ProfessionCategory professionMask;

		// Token: 0x040110D0 RID: 69840
		[Token(Token = "0x40110D0")]
		[FieldOffset(Offset = "0x20")]
		[Inspect("enableAdvanced")]
		public bool checkUnitType;

		// Token: 0x040110D1 RID: 69841
		[Token(Token = "0x40110D1")]
		[FieldOffset(Offset = "0x24")]
		[Inspect("enableAdvanced")]
		public UnitTypeMask unitTypeMask;

		// Token: 0x040110D2 RID: 69842
		[Token(Token = "0x40110D2")]
		[FieldOffset(Offset = "0x28")]
		[Inspect("ignoreTargetFreeOptions")]
		[Tooltip("We don't want to ignore all 'target free' cases, we only can ignore some of them.")]
		public bool onlyIgnoreSomeOfTargetFreeCase;

		// Token: 0x040110D3 RID: 69843
		[Token(Token = "0x40110D3")]
		[FieldOffset(Offset = "0x2C")]
		[Inspect("onlyIgnoreSomeOfTargetFreeCaseOptions")]
		public AbnormalFlag abnormalFlag;

		// Token: 0x040110D4 RID: 69844
		[Token(Token = "0x40110D4")]
		[FieldOffset(Offset = "0x30")]
		[Inspect("onlyIgnoreSomeOfTargetFreeCaseOptions")]
		public AbnormalCombo abnormalCombo;

		// Token: 0x040110D5 RID: 69845
		[Token(Token = "0x40110D5")]
		[FieldOffset(Offset = "0x34")]
		private SideType m_sourceSide;

		// Token: 0x040110D6 RID: 69846
		[Token(Token = "0x40110D6")]
		[FieldOffset(Offset = "0x38")]
		private SideType? m_originTargetSide;

		// Token: 0x040110D7 RID: 69847
		[Token(Token = "0x40110D7")]
		[FieldOffset(Offset = "0x40")]
		private SideType m_targetSideMask;

		// Token: 0x040110D8 RID: 69848
		[Token(Token = "0x40110D8")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		private KeyValuePair<PtrObjRef<Entity>, TargetOptions.SourceSnapshot> m_sourceSnapshot;

		// Token: 0x040110D9 RID: 69849
		[Token(Token = "0x40110D9")]
		[FieldOffset(Offset = "0x58")]
		private PlayerSideMask m_sourcePlayerSideMask;

		// Token: 0x02002541 RID: 9537
		[Token(Token = "0x2002541")]
		public class SourceSnapshot
		{
			// Token: 0x0600F605 RID: 62981 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F605")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SourceSnapshot()
			{
			}

			// Token: 0x040110DA RID: 69850
			[Token(Token = "0x40110DA")]
			[FieldOffset(Offset = "0x10")]
			public MotionMode sourceMotionMode;
		}
	}
}
