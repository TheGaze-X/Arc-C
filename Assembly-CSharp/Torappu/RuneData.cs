using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Torappu.Battle;

namespace Torappu
{
	// Token: 0x02001261 RID: 4705
	[Token(Token = "0x2001261")]
	[Serializable]
	public class RuneData
	{
		// Token: 0x060071D9 RID: 29145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071D9")]
		[Address(RVA = "0x220DA00", Offset = "0x220C600", VA = "0x18220DA00")]
		public void InitIfNot()
		{
		}

		// Token: 0x060071DA RID: 29146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071DA")]
		[Address(RVA = "0x220D910", Offset = "0x220C510", VA = "0x18220D910")]
		public RuneData Duplicate()
		{
			return null;
		}

		// Token: 0x060071DB RID: 29147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071DB")]
		[Address(RVA = "0x220D850", Offset = "0x220C450", VA = "0x18220D850")]
		public static RuneData CreateFromLegacy(LegacyInLevelRuneData legacyData)
		{
			return null;
		}

		// Token: 0x060071DC RID: 29148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071DC")]
		[Address(RVA = "0x220DE00", Offset = "0x220CA00", VA = "0x18220DE00")]
		private void _PopulateAdditionalMasksFromBlackboard()
		{
		}

		// Token: 0x060071DD RID: 29149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071DD")]
		[Address(RVA = "0x220DA30", Offset = "0x220C630", VA = "0x18220DA30")]
		private void _PopulateAdditionalFiltersFromBlackboard()
		{
		}

		// Token: 0x060071DE RID: 29150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071DE")]
		[Address(RVA = "0x220DCB0", Offset = "0x220C8B0", VA = "0x18220DCB0")]
		private void _PopulateAdditionalFiltersFromBlackboard(string key, ref List<string> filter)
		{
		}

		// Token: 0x060071DF RID: 29151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071DF")]
		[Address(RVA = "0x220E0C0", Offset = "0x220CCC0", VA = "0x18220E0C0")]
		public RuneData()
		{
		}

		// Token: 0x040067C7 RID: 26567
		[Token(Token = "0x40067C7")]
		[FieldOffset(Offset = "0x10")]
		public string key;

		// Token: 0x040067C8 RID: 26568
		[Token(Token = "0x40067C8")]
		[FieldOffset(Offset = "0x18")]
		public RuneData.Selector selector;

		// Token: 0x040067C9 RID: 26569
		[Token(Token = "0x40067C9")]
		[FieldOffset(Offset = "0x20")]
		public Blackboard blackboard;

		// Token: 0x040067CA RID: 26570
		[Token(Token = "0x40067CA")]
		[FieldOffset(Offset = "0x28")]
		[JsonIgnore]
		private bool m_inited;

		// Token: 0x02001262 RID: 4706
		[Token(Token = "0x2001262")]
		[Serializable]
		public class Selector
		{
			// Token: 0x060071E0 RID: 29152 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60071E0")]
			[Address(RVA = "0x2210CC0", Offset = "0x220F8C0", VA = "0x182210CC0")]
			public RuneData.Selector Duplicate()
			{
				return null;
			}

			// Token: 0x060071E1 RID: 29153 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60071E1")]
			[Address(RVA = "0x2211170", Offset = "0x220FD70", VA = "0x182211170")]
			public Selector()
			{
			}

			// Token: 0x040067CB RID: 26571
			[Token(Token = "0x40067CB")]
			[FieldOffset(Offset = "0x10")]
			[Enum(true, EnumDisplay.Checkbox)]
			public ProfessionCategory professionMask;

			// Token: 0x040067CC RID: 26572
			[Token(Token = "0x40067CC")]
			[FieldOffset(Offset = "0x14")]
			public BuildableType buildableMask;

			// Token: 0x040067CD RID: 26573
			[Token(Token = "0x40067CD")]
			[FieldOffset(Offset = "0x18")]
			public PlayerSideMask playerSideMask;

			// Token: 0x040067CE RID: 26574
			[Token(Token = "0x40067CE")]
			[FieldOffset(Offset = "0x1C")]
			public SideType sideType;

			// Token: 0x040067CF RID: 26575
			[Token(Token = "0x40067CF")]
			[FieldOffset(Offset = "0x20")]
			public List<string> charIdFilter;

			// Token: 0x040067D0 RID: 26576
			[Token(Token = "0x40067D0")]
			[FieldOffset(Offset = "0x28")]
			public List<string> charIdExcludeFilter;

			// Token: 0x040067D1 RID: 26577
			[Token(Token = "0x40067D1")]
			[FieldOffset(Offset = "0x30")]
			public List<string> enemyIdFilter;

			// Token: 0x040067D2 RID: 26578
			[Token(Token = "0x40067D2")]
			[FieldOffset(Offset = "0x38")]
			public List<string> enemyIdExcludeFilter;

			// Token: 0x040067D3 RID: 26579
			[Token(Token = "0x40067D3")]
			[FieldOffset(Offset = "0x40")]
			public List<string> enemyLevelTypeFilter;

			// Token: 0x040067D4 RID: 26580
			[Token(Token = "0x40067D4")]
			[FieldOffset(Offset = "0x48")]
			public List<string> enemyActionHiddenGroupFilter;

			// Token: 0x040067D5 RID: 26581
			[Token(Token = "0x40067D5")]
			[FieldOffset(Offset = "0x50")]
			public List<string> skillIdFilter;

			// Token: 0x040067D6 RID: 26582
			[Token(Token = "0x40067D6")]
			[FieldOffset(Offset = "0x58")]
			public List<string> tileKeyFilter;

			// Token: 0x040067D7 RID: 26583
			[Token(Token = "0x40067D7")]
			[FieldOffset(Offset = "0x60")]
			public List<string> groupTagFilter;

			// Token: 0x040067D8 RID: 26584
			[Token(Token = "0x40067D8")]
			[FieldOffset(Offset = "0x68")]
			public List<string> filterTagFilter;

			// Token: 0x040067D9 RID: 26585
			[Token(Token = "0x40067D9")]
			[FieldOffset(Offset = "0x70")]
			public List<string> filterTagExcludeFilter;

			// Token: 0x040067DA RID: 26586
			[Token(Token = "0x40067DA")]
			[FieldOffset(Offset = "0x78")]
			public List<string> subProfessionExcludeFilter;

			// Token: 0x040067DB RID: 26587
			[Token(Token = "0x40067DB")]
			[FieldOffset(Offset = "0x80")]
			public List<string> mapTagFilter;

			// Token: 0x040067DC RID: 26588
			[Token(Token = "0x40067DC")]
			[FieldOffset(Offset = "0x88")]
			public TileData.HeightTypeMask heightTypeMask;
		}
	}
}
