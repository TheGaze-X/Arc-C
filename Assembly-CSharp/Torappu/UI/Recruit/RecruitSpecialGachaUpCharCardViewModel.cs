using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x0200471C RID: 18204
	[Token(Token = "0x200471C")]
	public class RecruitSpecialGachaUpCharCardViewModel : IHotfixable
	{
		// Token: 0x0601B980 RID: 113024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B980")]
		[Address(RVA = "0x14E7650", Offset = "0x14E6250", VA = "0x1814E7650")]
		public void LoadData(string charId, RarityRank rank)
		{
		}

		// Token: 0x0601B981 RID: 113025 RVA: 0x000A5A08 File Offset: 0x000A3C08
		[Token(Token = "0x601B981")]
		[Address(RVA = "0x14E75F0", Offset = "0x14E61F0", VA = "0x1814E75F0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x0601B982 RID: 113026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B982")]
		[Address(RVA = "0x14E78C0", Offset = "0x14E64C0", VA = "0x1814E78C0")]
		public RecruitSpecialGachaUpCharCardViewModel()
		{
		}

		// Token: 0x04023C04 RID: 146436
		[Token(Token = "0x4023C04")]
		[FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x04023C05 RID: 146437
		[Token(Token = "0x4023C05")]
		[FieldOffset(Offset = "0x18")]
		public RarityRank rarity;

		// Token: 0x04023C06 RID: 146438
		[Token(Token = "0x4023C06")]
		[FieldOffset(Offset = "0x1C")]
		public ProfessionCategory profession;

		// Token: 0x04023C07 RID: 146439
		[Token(Token = "0x4023C07")]
		[FieldOffset(Offset = "0x20")]
		public string charName;

		// Token: 0x04023C08 RID: 146440
		[Token(Token = "0x4023C08")]
		[FieldOffset(Offset = "0x28")]
		public string portraitId;

		// Token: 0x04023C09 RID: 146441
		[Token(Token = "0x4023C09")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04023C0A RID: 146442
		[Token(Token = "0x4023C0A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsEmpty;

		// Token: 0x04023C0B RID: 146443
		[Token(Token = "0x4023C0B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
