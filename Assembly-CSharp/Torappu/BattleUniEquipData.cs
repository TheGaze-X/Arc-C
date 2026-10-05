using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001043 RID: 4163
	[Token(Token = "0x2001043")]
	[Serializable]
	public class BattleUniEquipData
	{
		// Token: 0x06006DAB RID: 28075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DAB")]
		[Address(RVA = "0x20FF0A0", Offset = "0x20FDCA0", VA = "0x1820FF0A0")]
		public BattleUniEquipData()
		{
		}

		// Token: 0x04005881 RID: 22657
		[Token(Token = "0x4005881")]
		[FieldOffset(Offset = "0x10")]
		public string resKey;

		// Token: 0x04005882 RID: 22658
		[Token(Token = "0x4005882")]
		[FieldOffset(Offset = "0x18")]
		[JsonConverter(typeof(StringEnumConverter))]
		public UniEquipTarget target;

		// Token: 0x04005883 RID: 22659
		[Token(Token = "0x4005883")]
		[FieldOffset(Offset = "0x1C")]
		public bool isToken;

		// Token: 0x04005884 RID: 22660
		[Token(Token = "0x4005884")]
		[FieldOffset(Offset = "0x20")]
		public string validInGameTag;

		// Token: 0x04005885 RID: 22661
		[Token(Token = "0x4005885")]
		[FieldOffset(Offset = "0x28")]
		public string validInMapTag;

		// Token: 0x04005886 RID: 22662
		[Token(Token = "0x4005886")]
		[FieldOffset(Offset = "0x30")]
		public CharacterData.EquipTalentDataBundle addOrOverrideTalentDataBundle;

		// Token: 0x04005887 RID: 22663
		[Token(Token = "0x4005887")]
		[FieldOffset(Offset = "0x38")]
		public CharacterData.EquipTraitDataBundle overrideTraitDataBundle;
	}
}
