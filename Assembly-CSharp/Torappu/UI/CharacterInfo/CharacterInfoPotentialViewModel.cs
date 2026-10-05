using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F07 RID: 24327
	[Token(Token = "0x2005F07")]
	public class CharacterInfoPotentialViewModel : IHotfixable
	{
		// Token: 0x060233F8 RID: 144376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60233F8")]
		[Address(RVA = "0x1DC2830", Offset = "0x1DC1430", VA = "0x181DC2830")]
		public void LoadData(PlayerCharacter pc, CharacterData cd)
		{
		}

		// Token: 0x060233F9 RID: 144377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60233F9")]
		[Address(RVA = "0x1DC2B50", Offset = "0x1DC1750", VA = "0x181DC2B50")]
		public void RefreshData(PlayerCharacter pc)
		{
		}

		// Token: 0x060233FA RID: 144378 RVA: 0x000C03C0 File Offset: 0x000BE5C0
		[Token(Token = "0x60233FA")]
		[Address(RVA = "0x1DC30E0", Offset = "0x1DC1CE0", VA = "0x181DC30E0")]
		private CharacterInfoPotentialViewModel.PotentialType _ResolvePotentialType()
		{
			return CharacterInfoPotentialViewModel.PotentialType.ACTIVITY;
		}

		// Token: 0x060233FB RID: 144379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60233FB")]
		[Address(RVA = "0x1DC31E0", Offset = "0x1DC1DE0", VA = "0x181DC31E0")]
		private CharacterInfoPotentialViewModel.PotentialItemViewModel _ResolveVoucherItem()
		{
			return null;
		}

		// Token: 0x060233FC RID: 144380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60233FC")]
		[Address(RVA = "0x1DC2C80", Offset = "0x1DC1880", VA = "0x181DC2C80")]
		private CharacterInfoPotentialViewModel.PotentialItemViewModel _ResolveCharItem()
		{
			return null;
		}

		// Token: 0x060233FD RID: 144381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60233FD")]
		[Address(RVA = "0x1DC2EE0", Offset = "0x1DC1AE0", VA = "0x181DC2EE0")]
		private CharacterInfoPotentialViewModel.PotentialItemViewModel _ResolveCommonItem()
		{
			return null;
		}

		// Token: 0x060233FE RID: 144382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60233FE")]
		[Address(RVA = "0x1DC3350", Offset = "0x1DC1F50", VA = "0x181DC3350")]
		public CharacterInfoPotentialViewModel()
		{
		}

		// Token: 0x0403090F RID: 198927
		[Token(Token = "0x403090F")]
		[FieldOffset(Offset = "0x10")]
		public PlayerCharacter playerChar;

		// Token: 0x04030910 RID: 198928
		[Token(Token = "0x4030910")]
		[FieldOffset(Offset = "0x18")]
		public CharacterData charData;

		// Token: 0x04030911 RID: 198929
		[Token(Token = "0x4030911")]
		[FieldOffset(Offset = "0x20")]
		public CharacterInfoPotentialViewModel.PotentialType potentialType;

		// Token: 0x04030912 RID: 198930
		[Token(Token = "0x4030912")]
		[FieldOffset(Offset = "0x28")]
		public CharacterInfoPotentialViewModel.PotentialItemViewModel voucherItem;

		// Token: 0x04030913 RID: 198931
		[Token(Token = "0x4030913")]
		[FieldOffset(Offset = "0x30")]
		public CharacterInfoPotentialViewModel.PotentialItemViewModel charItem;

		// Token: 0x04030914 RID: 198932
		[Token(Token = "0x4030914")]
		[FieldOffset(Offset = "0x38")]
		public CharacterInfoPotentialViewModel.PotentialItemViewModel commonItem;

		// Token: 0x04030915 RID: 198933
		[Token(Token = "0x4030915")]
		[FieldOffset(Offset = "0x40")]
		public bool showMixedHint;

		// Token: 0x04030916 RID: 198934
		[Token(Token = "0x4030916")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04030917 RID: 198935
		[Token(Token = "0x4030917")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04030918 RID: 198936
		[Token(Token = "0x4030918")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ResolvePotentialType;

		// Token: 0x04030919 RID: 198937
		[Token(Token = "0x4030919")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ResolveVoucherItem;

		// Token: 0x0403091A RID: 198938
		[Token(Token = "0x403091A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ResolveCharItem;

		// Token: 0x0403091B RID: 198939
		[Token(Token = "0x403091B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ResolveCommonItem;

		// Token: 0x0403091C RID: 198940
		[Token(Token = "0x403091C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005F08 RID: 24328
		[Token(Token = "0x2005F08")]
		public enum PotentialType
		{
			// Token: 0x0403091E RID: 198942
			[Token(Token = "0x403091E")]
			ACTIVITY,
			// Token: 0x0403091F RID: 198943
			[Token(Token = "0x403091F")]
			VOUCHER,
			// Token: 0x04030920 RID: 198944
			[Token(Token = "0x4030920")]
			GENERAL,
			// Token: 0x04030921 RID: 198945
			[Token(Token = "0x4030921")]
			CHARACTER,
			// Token: 0x04030922 RID: 198946
			[Token(Token = "0x4030922")]
			ENUM
		}

		// Token: 0x02005F09 RID: 24329
		[Token(Token = "0x2005F09")]
		public class PotentialItemViewModel
		{
			// Token: 0x060233FF RID: 144383 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60233FF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PotentialItemViewModel()
			{
			}

			// Token: 0x04030923 RID: 198947
			[Token(Token = "0x4030923")]
			[FieldOffset(Offset = "0x10")]
			public int index;

			// Token: 0x04030924 RID: 198948
			[Token(Token = "0x4030924")]
			[FieldOffset(Offset = "0x14")]
			public int requireCount;

			// Token: 0x04030925 RID: 198949
			[Token(Token = "0x4030925")]
			[FieldOffset(Offset = "0x18")]
			public UIItemViewModel item;

			// Token: 0x04030926 RID: 198950
			[Token(Token = "0x4030926")]
			[FieldOffset(Offset = "0x20")]
			public int count;
		}
	}
}
