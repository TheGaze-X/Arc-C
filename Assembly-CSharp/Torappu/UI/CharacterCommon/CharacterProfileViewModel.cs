using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.CharacterCommon
{
	// Token: 0x02005FD5 RID: 24533
	[Token(Token = "0x2005FD5")]
	public class CharacterProfileViewModel
	{
		// Token: 0x0602376F RID: 145263 RVA: 0x000C0F60 File Offset: 0x000BF160
		[Token(Token = "0x602376F")]
		[Address(RVA = "0x1E224F0", Offset = "0x1E210F0", VA = "0x181E224F0")]
		public int GetSelectEquipPosition()
		{
			return 0;
		}

		// Token: 0x06023770 RID: 145264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023770")]
		[Address(RVA = "0x1E22420", Offset = "0x1E21020", VA = "0x181E22420")]
		public string GetFinalWrappedDesc()
		{
			return null;
		}

		// Token: 0x06023771 RID: 145265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023771")]
		[Address(RVA = "0x1E22E90", Offset = "0x1E21A90", VA = "0x181E22E90")]
		public void OnRefreshEquipInfo(string equipId)
		{
		}

		// Token: 0x06023772 RID: 145266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023772")]
		[Address(RVA = "0x1E23340", Offset = "0x1E21F40", VA = "0x181E23340")]
		private void _RefreshEquipInfoForTargetEquip(string equipId)
		{
		}

		// Token: 0x06023773 RID: 145267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023773")]
		[Address(RVA = "0x1E22FD0", Offset = "0x1E21BD0", VA = "0x181E22FD0")]
		private void _LoadMasterInfo(CharQuery charQuery, Dictionary<string, int> masterDict)
		{
		}

		// Token: 0x06023774 RID: 145268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023774")]
		[Address(RVA = "0x1E22ED0", Offset = "0x1E21AD0", VA = "0x181E22ED0")]
		private CharacterMasterViewModel _GeneMasterModelFromLevelInfo(CharMasterLevelData levelInfo, CharMasterLevelData nextInfo, string charId, string masterId, bool hasMaster)
		{
			return null;
		}

		// Token: 0x06023775 RID: 145269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023775")]
		[Address(RVA = "0x1E225B0", Offset = "0x1E211B0", VA = "0x181E225B0")]
		public void LoadData(CharacterData charData, CharQuery charQuery, EvolvePhase evolvePhase, int level, int potentialRank, bool hasMultipleTmpl, string currentEquipId, ListDict<string, PlayerCharEquipInfo> currentEquipInfo, Dictionary<string, int> masterDict)
		{
		}

		// Token: 0x06023776 RID: 145270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023776")]
		[Address(RVA = "0x1E22D00", Offset = "0x1E21900", VA = "0x181E22D00")]
		public void LoadData(PlayerCharacter playerChar, CharacterData charData)
		{
		}

		// Token: 0x06023777 RID: 145271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023777")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CharacterProfileViewModel()
		{
		}

		// Token: 0x04031102 RID: 200962
		[Token(Token = "0x4031102")]
		[FieldOffset(Offset = "0x10")]
		public CharQuery charQuery;

		// Token: 0x04031103 RID: 200963
		[Token(Token = "0x4031103")]
		[FieldOffset(Offset = "0x28")]
		public string nickName;

		// Token: 0x04031104 RID: 200964
		[Token(Token = "0x4031104")]
		[FieldOffset(Offset = "0x30")]
		public string realName;

		// Token: 0x04031105 RID: 200965
		[Token(Token = "0x4031105")]
		[FieldOffset(Offset = "0x38")]
		public RarityRank rarity;

		// Token: 0x04031106 RID: 200966
		[Token(Token = "0x4031106")]
		[FieldOffset(Offset = "0x40")]
		public CharacterTalentViewModel[] talentDescs;

		// Token: 0x04031107 RID: 200967
		[Token(Token = "0x4031107")]
		[FieldOffset(Offset = "0x48")]
		public List<CharacterMasterViewModel> masterDescs;

		// Token: 0x04031108 RID: 200968
		[Token(Token = "0x4031108")]
		[FieldOffset(Offset = "0x50")]
		public List<CharacterUniEquipViewModel> equips;

		// Token: 0x04031109 RID: 200969
		[Token(Token = "0x4031109")]
		[FieldOffset(Offset = "0x58")]
		public string featureDescBasic;

		// Token: 0x0403110A RID: 200970
		[Token(Token = "0x403110A")]
		[FieldOffset(Offset = "0x60")]
		public string featureDescAdditive;

		// Token: 0x0403110B RID: 200971
		[Token(Token = "0x403110B")]
		[FieldOffset(Offset = "0x68")]
		public Sprite campLogo;

		// Token: 0x0403110C RID: 200972
		[Token(Token = "0x403110C")]
		[FieldOffset(Offset = "0x70")]
		public string powerId;

		// Token: 0x0403110D RID: 200973
		[Token(Token = "0x403110D")]
		[FieldOffset(Offset = "0x78")]
		public bool hasMultipleTmpl;

		// Token: 0x0403110E RID: 200974
		[Token(Token = "0x403110E")]
		[FieldOffset(Offset = "0x80")]
		public string rawFeatureDesc;

		// Token: 0x0403110F RID: 200975
		[Token(Token = "0x403110F")]
		[FieldOffset(Offset = "0x88")]
		public EvolvePhase evolvePhase;

		// Token: 0x04031110 RID: 200976
		[Token(Token = "0x4031110")]
		[FieldOffset(Offset = "0x8C")]
		public int level;

		// Token: 0x04031111 RID: 200977
		[Token(Token = "0x4031111")]
		[FieldOffset(Offset = "0x90")]
		public int potentialRank;

		// Token: 0x04031112 RID: 200978
		[Token(Token = "0x4031112")]
		[FieldOffset(Offset = "0x98")]
		public string currentSelectEquipId;

		// Token: 0x04031113 RID: 200979
		[Token(Token = "0x4031113")]
		[FieldOffset(Offset = "0xA0")]
		public string currentEquipId;

		// Token: 0x04031114 RID: 200980
		[Token(Token = "0x4031114")]
		[FieldOffset(Offset = "0xA8")]
		public bool haveAvailEquip;

		// Token: 0x04031115 RID: 200981
		[Token(Token = "0x4031115")]
		[FieldOffset(Offset = "0xA9")]
		public bool haveEquip;

		// Token: 0x04031116 RID: 200982
		[Token(Token = "0x4031116")]
		[FieldOffset(Offset = "0xB0")]
		public string subProfessionInfo;
	}
}
