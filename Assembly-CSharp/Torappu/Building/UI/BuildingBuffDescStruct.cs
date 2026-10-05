using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.UI
{
	// Token: 0x02001AFF RID: 6911
	[Token(Token = "0x2001AFF")]
	[Serializable]
	public struct BuildingBuffDescStruct
	{
		// Token: 0x0600AE77 RID: 44663 RVA: 0x00043248 File Offset: 0x00041448
		[Token(Token = "0x600AE77")]
		[Address(RVA = "0x1A15A50", Offset = "0x1A14650", VA = "0x181A15A50")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x0600AE78 RID: 44664 RVA: 0x00043260 File Offset: 0x00041460
		[Token(Token = "0x600AE78")]
		[Address(RVA = "0x3288AE0", Offset = "0x32876E0", VA = "0x183288AE0")]
		public static BuildingBuffDescStruct CreateInst(string name, string iconId, string desc, Color color, Color textColor)
		{
			return default(BuildingBuffDescStruct);
		}

		// Token: 0x0600AE79 RID: 44665 RVA: 0x00043278 File Offset: 0x00041478
		[Token(Token = "0x600AE79")]
		[Address(RVA = "0x3288910", Offset = "0x3287510", VA = "0x183288910")]
		public static BuildingBuffDescStruct CreateInst(BuildingData.BuildingBuff currentBuff, CharacterData.UnlockCondition curUnlockCond, string nextLevelBuff, CharacterData.UnlockCondition nextUnlockCond)
		{
			return default(BuildingBuffDescStruct);
		}

		// Token: 0x0400A723 RID: 42787
		[Token(Token = "0x400A723")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BuildingBuffDescStruct EMPTY;

		// Token: 0x0400A724 RID: 42788
		[Token(Token = "0x400A724")]
		[FieldOffset(Offset = "0x0")]
		private bool m_isNotEmpty;

		// Token: 0x0400A725 RID: 42789
		[Token(Token = "0x400A725")]
		[FieldOffset(Offset = "0x1")]
		public bool isUnlocked;

		// Token: 0x0400A726 RID: 42790
		[Token(Token = "0x400A726")]
		[FieldOffset(Offset = "0x8")]
		public string buffId;

		// Token: 0x0400A727 RID: 42791
		[Token(Token = "0x400A727")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x0400A728 RID: 42792
		[Token(Token = "0x400A728")]
		[FieldOffset(Offset = "0x18")]
		public string iconId;

		// Token: 0x0400A729 RID: 42793
		[Token(Token = "0x400A729")]
		[FieldOffset(Offset = "0x20")]
		public string desc;

		// Token: 0x0400A72A RID: 42794
		[Token(Token = "0x400A72A")]
		[FieldOffset(Offset = "0x28")]
		public string rawDesc;

		// Token: 0x0400A72B RID: 42795
		[Token(Token = "0x400A72B")]
		[FieldOffset(Offset = "0x30")]
		public BuildingData.RoomType roomType;

		// Token: 0x0400A72C RID: 42796
		[Token(Token = "0x400A72C")]
		[FieldOffset(Offset = "0x34")]
		public Color color;

		// Token: 0x0400A72D RID: 42797
		[Token(Token = "0x400A72D")]
		[FieldOffset(Offset = "0x44")]
		public Color textColor;

		// Token: 0x0400A72E RID: 42798
		[Token(Token = "0x400A72E")]
		[FieldOffset(Offset = "0x54")]
		public CharacterData.UnlockCondition currentUnlockCond;

		// Token: 0x0400A72F RID: 42799
		[Token(Token = "0x400A72F")]
		[FieldOffset(Offset = "0x60")]
		public string nextLevelBuff;

		// Token: 0x0400A730 RID: 42800
		[Token(Token = "0x400A730")]
		[FieldOffset(Offset = "0x68")]
		public CharacterData.UnlockCondition nextUnlockCond;
	}
}
