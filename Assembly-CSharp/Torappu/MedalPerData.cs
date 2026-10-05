using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020010EA RID: 4330
	[Token(Token = "0x20010EA")]
	public class MedalPerData
	{
		// Token: 0x06006E8F RID: 28303 RVA: 0x00032178 File Offset: 0x00030378
		[Token(Token = "0x6006E8F")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "4")]
		public virtual bool ShouldSerializedisplayTime()
		{
			return default(bool);
		}

		// Token: 0x06006E90 RID: 28304 RVA: 0x00032190 File Offset: 0x00030390
		[Token(Token = "0x6006E90")]
		[Address(RVA = "0x906A30", Offset = "0x905630", VA = "0x180906A30", Slot = "5")]
		public virtual bool ShouldSerializeisHidden()
		{
			return default(bool);
		}

		// Token: 0x06006E91 RID: 28305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E91")]
		[Address(RVA = "0x2107A50", Offset = "0x2106650", VA = "0x182107A50")]
		public MedalPerData()
		{
		}

		// Token: 0x04005CC7 RID: 23751
		[Token(Token = "0x4005CC7")]
		[FieldOffset(Offset = "0x10")]
		public string medalId;

		// Token: 0x04005CC8 RID: 23752
		[Token(Token = "0x4005CC8")]
		[FieldOffset(Offset = "0x18")]
		public string medalName;

		// Token: 0x04005CC9 RID: 23753
		[Token(Token = "0x4005CC9")]
		[FieldOffset(Offset = "0x20")]
		public string medalType;

		// Token: 0x04005CCA RID: 23754
		[Token(Token = "0x4005CCA")]
		[FieldOffset(Offset = "0x28")]
		public int slotId;

		// Token: 0x04005CCB RID: 23755
		[Token(Token = "0x4005CCB")]
		[FieldOffset(Offset = "0x30")]
		public string[] preMedalIdList;

		// Token: 0x04005CCC RID: 23756
		[Token(Token = "0x4005CCC")]
		[FieldOffset(Offset = "0x38")]
		public MedalRarity rarity;

		// Token: 0x04005CCD RID: 23757
		[Token(Token = "0x4005CCD")]
		[FieldOffset(Offset = "0x40")]
		public string template;

		// Token: 0x04005CCE RID: 23758
		[Token(Token = "0x4005CCE")]
		[FieldOffset(Offset = "0x48")]
		public List<string> unlockParam;

		// Token: 0x04005CCF RID: 23759
		[Token(Token = "0x4005CCF")]
		[FieldOffset(Offset = "0x50")]
		public string getMethod;

		// Token: 0x04005CD0 RID: 23760
		[Token(Token = "0x4005CD0")]
		[FieldOffset(Offset = "0x58")]
		public string description;

		// Token: 0x04005CD1 RID: 23761
		[Token(Token = "0x4005CD1")]
		[FieldOffset(Offset = "0x60")]
		public string advancedMedal;

		// Token: 0x04005CD2 RID: 23762
		[Token(Token = "0x4005CD2")]
		[FieldOffset(Offset = "0x68")]
		public string originMedal;

		// Token: 0x04005CD3 RID: 23763
		[Token(Token = "0x4005CD3")]
		[FieldOffset(Offset = "0x70")]
		public long displayTime;

		// Token: 0x04005CD4 RID: 23764
		[Token(Token = "0x4005CD4")]
		[FieldOffset(Offset = "0x78")]
		public List<MedalExpireTime> expireTimes;

		// Token: 0x04005CD5 RID: 23765
		[Token(Token = "0x4005CD5")]
		[FieldOffset(Offset = "0x80")]
		public List<MedalRewardGroupData> medalRewardGroup;

		// Token: 0x04005CD6 RID: 23766
		[Token(Token = "0x4005CD6")]
		[FieldOffset(Offset = "0x88")]
		public bool isHidden;
	}
}
