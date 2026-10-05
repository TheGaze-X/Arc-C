using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F2D RID: 24365
	[Token(Token = "0x2005F2D")]
	public class SpecialOperatorInfoViewModel : IHotfixable
	{
		// Token: 0x0602348F RID: 144527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602348F")]
		[Address(RVA = "0x1DE5160", Offset = "0x1DE3D60", VA = "0x181DE5160")]
		public void LoadData(PlayerCharacter playerChar, CharacterData charData)
		{
		}

		// Token: 0x06023490 RID: 144528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023490")]
		[Address(RVA = "0x1DE5290", Offset = "0x1DE3E90", VA = "0x181DE5290")]
		private void _LoadSpOpData(CharacterData charData)
		{
		}

		// Token: 0x06023491 RID: 144529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023491")]
		[Address(RVA = "0x1DE5450", Offset = "0x1DE4050", VA = "0x181DE5450")]
		public SpecialOperatorInfoViewModel()
		{
		}

		// Token: 0x04030A65 RID: 199269
		[Token(Token = "0x4030A65")]
		[FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x04030A66 RID: 199270
		[Token(Token = "0x4030A66")]
		[FieldOffset(Offset = "0x18")]
		public bool isSpecialOperator;

		// Token: 0x04030A67 RID: 199271
		[Token(Token = "0x4030A67")]
		[FieldOffset(Offset = "0x1C")]
		public SpecialOperatorTargetType targetType;

		// Token: 0x04030A68 RID: 199272
		[Token(Token = "0x4030A68")]
		[FieldOffset(Offset = "0x20")]
		public string targetId;

		// Token: 0x04030A69 RID: 199273
		[Token(Token = "0x4030A69")]
		[FieldOffset(Offset = "0x28")]
		public string targetTypeIcon;

		// Token: 0x04030A6A RID: 199274
		[Token(Token = "0x4030A6A")]
		[FieldOffset(Offset = "0x30")]
		public string targetTypeName;

		// Token: 0x04030A6B RID: 199275
		[Token(Token = "0x4030A6B")]
		[FieldOffset(Offset = "0x38")]
		public string targetModeName;

		// Token: 0x04030A6C RID: 199276
		[Token(Token = "0x4030A6C")]
		[FieldOffset(Offset = "0x40")]
		public string targetTopicName;

		// Token: 0x04030A6D RID: 199277
		[Token(Token = "0x4030A6D")]
		[FieldOffset(Offset = "0x48")]
		public int curLevel;

		// Token: 0x04030A6E RID: 199278
		[Token(Token = "0x4030A6E")]
		[FieldOffset(Offset = "0x4C")]
		public int maxLevel;

		// Token: 0x04030A6F RID: 199279
		[Token(Token = "0x4030A6F")]
		[FieldOffset(Offset = "0x50")]
		public float curExpProgress;

		// Token: 0x04030A70 RID: 199280
		[Token(Token = "0x4030A70")]
		[FieldOffset(Offset = "0x58")]
		public string powerId;

		// Token: 0x04030A71 RID: 199281
		[Token(Token = "0x4030A71")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04030A72 RID: 199282
		[Token(Token = "0x4030A72")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadSpOpData;

		// Token: 0x04030A73 RID: 199283
		[Token(Token = "0x4030A73")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
