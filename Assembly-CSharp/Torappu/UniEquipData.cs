using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020013B5 RID: 5045
	[Token(Token = "0x20013B5")]
	public class UniEquipData
	{
		// Token: 0x060073A0 RID: 29600 RVA: 0x00033690 File Offset: 0x00031890
		[Token(Token = "0x60073A0")]
		[Address(RVA = "0x2216190", Offset = "0x2214D90", VA = "0x182216190", Slot = "4")]
		public virtual bool ShouldSerializespecialEquipDesc()
		{
			return default(bool);
		}

		// Token: 0x060073A1 RID: 29601 RVA: 0x000336A8 File Offset: 0x000318A8
		[Token(Token = "0x60073A1")]
		[Address(RVA = "0x2216190", Offset = "0x2214D90", VA = "0x182216190", Slot = "5")]
		public virtual bool ShouldSerializespecialEquipColor()
		{
			return default(bool);
		}

		// Token: 0x060073A2 RID: 29602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073A2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UniEquipData()
		{
		}

		// Token: 0x04007014 RID: 28692
		[Token(Token = "0x4007014")]
		[FieldOffset(Offset = "0x10")]
		public string uniEquipId;

		// Token: 0x04007015 RID: 28693
		[Token(Token = "0x4007015")]
		[FieldOffset(Offset = "0x18")]
		public string uniEquipName;

		// Token: 0x04007016 RID: 28694
		[Token(Token = "0x4007016")]
		[FieldOffset(Offset = "0x20")]
		public string uniEquipIcon;

		// Token: 0x04007017 RID: 28695
		[Token(Token = "0x4007017")]
		[FieldOffset(Offset = "0x28")]
		public string uniEquipDesc;

		// Token: 0x04007018 RID: 28696
		[Token(Token = "0x4007018")]
		[FieldOffset(Offset = "0x30")]
		public string typeIcon;

		// Token: 0x04007019 RID: 28697
		[Token(Token = "0x4007019")]
		[FieldOffset(Offset = "0x38")]
		public string typeName1;

		// Token: 0x0400701A RID: 28698
		[Token(Token = "0x400701A")]
		[FieldOffset(Offset = "0x40")]
		public string typeName2;

		// Token: 0x0400701B RID: 28699
		[Token(Token = "0x400701B")]
		[FieldOffset(Offset = "0x48")]
		public string equipShiningColor;

		// Token: 0x0400701C RID: 28700
		[Token(Token = "0x400701C")]
		[FieldOffset(Offset = "0x50")]
		public EvolvePhase showEvolvePhase;

		// Token: 0x0400701D RID: 28701
		[Token(Token = "0x400701D")]
		[FieldOffset(Offset = "0x54")]
		public EvolvePhase unlockEvolvePhase;

		// Token: 0x0400701E RID: 28702
		[Token(Token = "0x400701E")]
		[FieldOffset(Offset = "0x58")]
		public string charId;

		// Token: 0x0400701F RID: 28703
		[Token(Token = "0x400701F")]
		[FieldOffset(Offset = "0x60")]
		public string tmplId;

		// Token: 0x04007020 RID: 28704
		[Token(Token = "0x4007020")]
		[FieldOffset(Offset = "0x68")]
		public int showLevel;

		// Token: 0x04007021 RID: 28705
		[Token(Token = "0x4007021")]
		[FieldOffset(Offset = "0x6C")]
		public int unlockLevel;

		// Token: 0x04007022 RID: 28706
		[Token(Token = "0x4007022")]
		[FieldOffset(Offset = "0x70")]
		public List<string> missionList;

		// Token: 0x04007023 RID: 28707
		[Token(Token = "0x4007023")]
		[FieldOffset(Offset = "0x78")]
		public Dictionary<string, int> unlockFavors;

		// Token: 0x04007024 RID: 28708
		[Token(Token = "0x4007024")]
		[FieldOffset(Offset = "0x80")]
		public Dictionary<int, List<ItemBundle>> itemCost;

		// Token: 0x04007025 RID: 28709
		[Token(Token = "0x4007025")]
		[FieldOffset(Offset = "0x88")]
		[JsonConverter(typeof(StringEnumConverter))]
		public UniEquipType type;

		// Token: 0x04007026 RID: 28710
		[Token(Token = "0x4007026")]
		[FieldOffset(Offset = "0x90")]
		public long uniEquipGetTime;

		// Token: 0x04007027 RID: 28711
		[Token(Token = "0x4007027")]
		[FieldOffset(Offset = "0x98")]
		public long uniEquipShowEnd;

		// Token: 0x04007028 RID: 28712
		[Token(Token = "0x4007028")]
		[FieldOffset(Offset = "0xA0")]
		public int charEquipOrder;

		// Token: 0x04007029 RID: 28713
		[Token(Token = "0x4007029")]
		[FieldOffset(Offset = "0xA4")]
		public bool hasUnlockMission;

		// Token: 0x0400702A RID: 28714
		[Token(Token = "0x400702A")]
		[FieldOffset(Offset = "0xA5")]
		public bool isSpecialEquip;

		// Token: 0x0400702B RID: 28715
		[Token(Token = "0x400702B")]
		[FieldOffset(Offset = "0xA8")]
		public string specialEquipDesc;

		// Token: 0x0400702C RID: 28716
		[Token(Token = "0x400702C")]
		[FieldOffset(Offset = "0xB0")]
		public string specialEquipColor;

		// Token: 0x0400702D RID: 28717
		[Token(Token = "0x400702D")]
		[FieldOffset(Offset = "0xB8")]
		public string charColor;
	}
}
