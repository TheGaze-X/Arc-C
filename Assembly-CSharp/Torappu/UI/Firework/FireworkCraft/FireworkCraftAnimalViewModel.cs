using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Firework.FireworkCraft
{
	// Token: 0x02004E7B RID: 20091
	[Token(Token = "0x2004E7B")]
	public class FireworkCraftAnimalViewModel : IHotfixable
	{
		// Token: 0x0601DFC6 RID: 122822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFC6")]
		[Address(RVA = "0x179C690", Offset = "0x179B290", VA = "0x18179C690")]
		public void LoadData(FireworkData.AnimalData animalData, bool unlocked)
		{
		}

		// Token: 0x0601DFC7 RID: 122823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFC7")]
		[Address(RVA = "0x179C840", Offset = "0x179B440", VA = "0x18179C840")]
		public FireworkCraftAnimalViewModel()
		{
		}

		// Token: 0x04027D42 RID: 163138
		[Token(Token = "0x4027D42")]
		[FieldOffset(Offset = "0x10")]
		public string animalId;

		// Token: 0x04027D43 RID: 163139
		[Token(Token = "0x4027D43")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04027D44 RID: 163140
		[Token(Token = "0x4027D44")]
		[FieldOffset(Offset = "0x20")]
		public string animalDesc;

		// Token: 0x04027D45 RID: 163141
		[Token(Token = "0x4027D45")]
		[FieldOffset(Offset = "0x28")]
		public string animalNameId;

		// Token: 0x04027D46 RID: 163142
		[Token(Token = "0x4027D46")]
		[FieldOffset(Offset = "0x30")]
		public bool isUnlocked;

		// Token: 0x04027D47 RID: 163143
		[Token(Token = "0x4027D47")]
		[FieldOffset(Offset = "0x38")]
		public string unlockStageId;

		// Token: 0x04027D48 RID: 163144
		[Token(Token = "0x4027D48")]
		[FieldOffset(Offset = "0x40")]
		public string unlockStageCode;

		// Token: 0x04027D49 RID: 163145
		[Token(Token = "0x4027D49")]
		[FieldOffset(Offset = "0x48")]
		public string changedToast;

		// Token: 0x04027D4A RID: 163146
		[Token(Token = "0x4027D4A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04027D4B RID: 163147
		[Token(Token = "0x4027D4B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
