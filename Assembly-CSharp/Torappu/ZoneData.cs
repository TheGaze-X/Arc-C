using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020013C1 RID: 5057
	[Token(Token = "0x20013C1")]
	[Serializable]
	public class ZoneData
	{
		// Token: 0x060073AB RID: 29611 RVA: 0x000336D8 File Offset: 0x000318D8
		[Token(Token = "0x60073AB")]
		[Address(RVA = "0x2111A40", Offset = "0x2110640", VA = "0x182111A40")]
		public bool ShouldSerializebindMainlineZoneId()
		{
			return default(bool);
		}

		// Token: 0x060073AC RID: 29612 RVA: 0x000336F0 File Offset: 0x000318F0
		[Token(Token = "0x60073AC")]
		[Address(RVA = "0x2218030", Offset = "0x2216C30", VA = "0x182218030")]
		public bool ShouldSerializebindMainlineRetroZoneId()
		{
			return default(bool);
		}

		// Token: 0x060073AD RID: 29613 RVA: 0x00033708 File Offset: 0x00031908
		[Token(Token = "0x60073AD")]
		[Address(RVA = "0x2218070", Offset = "0x2216C70", VA = "0x182218070")]
		public bool ShouldSerializesixStarMilestoneGroupId()
		{
			return default(bool);
		}

		// Token: 0x060073AE RID: 29614 RVA: 0x00033720 File Offset: 0x00031920
		[Token(Token = "0x60073AE")]
		[Address(RVA = "0x2218060", Offset = "0x2216C60", VA = "0x182218060")]
		public bool ShouldSerializehasAdditionalPanel()
		{
			return default(bool);
		}

		// Token: 0x060073AF RID: 29615 RVA: 0x00033738 File Offset: 0x00031938
		[Token(Token = "0x60073AF")]
		[Address(RVA = "0x1FF9C40", Offset = "0x1FF8840", VA = "0x181FF9C40", Slot = "4")]
		public virtual bool ShouldSerializeantiSpoilerId()
		{
			return default(bool);
		}

		// Token: 0x060073B0 RID: 29616 RVA: 0x00033750 File Offset: 0x00031950
		[Token(Token = "0x60073B0")]
		[Address(RVA = "0x2218050", Offset = "0x2216C50", VA = "0x182218050")]
		public bool ShouldSerializediamondRewardCount()
		{
			return default(bool);
		}

		// Token: 0x060073B1 RID: 29617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073B1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ZoneData()
		{
		}

		// Token: 0x0400706C RID: 28780
		[Token(Token = "0x400706C")]
		[FieldOffset(Offset = "0x10")]
		public string zoneID;

		// Token: 0x0400706D RID: 28781
		[Token(Token = "0x400706D")]
		[FieldOffset(Offset = "0x18")]
		public int zoneIndex;

		// Token: 0x0400706E RID: 28782
		[Token(Token = "0x400706E")]
		[FieldOffset(Offset = "0x1C")]
		[JsonConverter(typeof(StringEnumConverter))]
		public ZoneType type;

		// Token: 0x0400706F RID: 28783
		[Token(Token = "0x400706F")]
		[FieldOffset(Offset = "0x20")]
		public string zoneNameFirst;

		// Token: 0x04007070 RID: 28784
		[Token(Token = "0x4007070")]
		[FieldOffset(Offset = "0x28")]
		public string zoneNameSecond;

		// Token: 0x04007071 RID: 28785
		[Token(Token = "0x4007071")]
		[FieldOffset(Offset = "0x30")]
		public string zoneNameTitleCurrent;

		// Token: 0x04007072 RID: 28786
		[Token(Token = "0x4007072")]
		[FieldOffset(Offset = "0x38")]
		public string zoneNameTitleUnCurrent;

		// Token: 0x04007073 RID: 28787
		[Token(Token = "0x4007073")]
		[FieldOffset(Offset = "0x40")]
		public string zoneNameTitleEx;

		// Token: 0x04007074 RID: 28788
		[Token(Token = "0x4007074")]
		[FieldOffset(Offset = "0x48")]
		public string zoneNameThird;

		// Token: 0x04007075 RID: 28789
		[Token(Token = "0x4007075")]
		[FieldOffset(Offset = "0x50")]
		public string lockedText;

		// Token: 0x04007076 RID: 28790
		[Token(Token = "0x4007076")]
		[FieldOffset(Offset = "0x58")]
		public string antiSpoilerId;

		// Token: 0x04007077 RID: 28791
		[Token(Token = "0x4007077")]
		[FieldOffset(Offset = "0x60")]
		public bool canPreview;

		// Token: 0x04007078 RID: 28792
		[Token(Token = "0x4007078")]
		[FieldOffset(Offset = "0x61")]
		public bool hasAdditionalPanel;

		// Token: 0x04007079 RID: 28793
		[Token(Token = "0x4007079")]
		[FieldOffset(Offset = "0x68")]
		public string sixStarMilestoneGroupId;

		// Token: 0x0400707A RID: 28794
		[Token(Token = "0x400707A")]
		[FieldOffset(Offset = "0x70")]
		public string bindMainlineZoneId;

		// Token: 0x0400707B RID: 28795
		[Token(Token = "0x400707B")]
		[FieldOffset(Offset = "0x78")]
		public string bindMainlineRetroZoneId;

		// Token: 0x0400707C RID: 28796
		[Token(Token = "0x400707C")]
		[FieldOffset(Offset = "0x80")]
		public int diamondRewardCount;
	}
}
