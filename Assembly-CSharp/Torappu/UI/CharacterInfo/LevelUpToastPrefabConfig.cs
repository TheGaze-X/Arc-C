using System;
using Il2CppDummyDll;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005EE8 RID: 24296
	[Token(Token = "0x2005EE8")]
	public struct LevelUpToastPrefabConfig
	{
		// Token: 0x04030804 RID: 198660
		[Token(Token = "0x4030804")]
		[FieldOffset(Offset = "0x0")]
		public CharacterInfoLevelUpNotifyView levelUpNotify;

		// Token: 0x04030805 RID: 198661
		[Token(Token = "0x4030805")]
		[FieldOffset(Offset = "0x8")]
		public CharacterInfoTalentUnlockNotifyView talentUnlockNotify;

		// Token: 0x04030806 RID: 198662
		[Token(Token = "0x4030806")]
		[FieldOffset(Offset = "0x10")]
		public CharacterInfoSkillUnlockNotifyView skillUnlockNotify;

		// Token: 0x04030807 RID: 198663
		[Token(Token = "0x4030807")]
		[FieldOffset(Offset = "0x18")]
		public CharacterInfoBuildingBuffUnlockNotifyView buildingBuffUnlockNotify;

		// Token: 0x04030808 RID: 198664
		[Token(Token = "0x4030808")]
		[FieldOffset(Offset = "0x20")]
		public CharacterInfoBuildingBuffUpgradeNotifyView buildingBuffUpgradeNotify;
	}
}
