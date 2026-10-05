using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005A6E RID: 23150
	[Token(Token = "0x2005A6E")]
	public class SkinShopBlindboxSkinListSkinGroupViewModel : IHotfixable
	{
		// Token: 0x17004F04 RID: 20228
		// (get) Token: 0x06021AEB RID: 137963 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06021AEC RID: 137964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004F04")]
		public ListDict<string, SkinShopBlindboxSkinListItemViewModel> skins
		{
			[Token(Token = "0x6021AEB")]
			[Address(RVA = "0x1C2A200", Offset = "0x1C28E00", VA = "0x181C2A200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6021AEC")]
			[Address(RVA = "0x1C2A260", Offset = "0x1C28E60", VA = "0x181C2A260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06021AED RID: 137965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021AED")]
		[Address(RVA = "0x1C2A130", Offset = "0x1C28D30", VA = "0x181C2A130")]
		public SkinShopBlindboxSkinListSkinGroupViewModel(bool isAchievedSkinGroup)
		{
		}

		// Token: 0x06021AEE RID: 137966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021AEE")]
		[Address(RVA = "0x1C29DD0", Offset = "0x1C289D0", VA = "0x181C29DD0")]
		public void Clear()
		{
		}

		// Token: 0x06021AEF RID: 137967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021AEF")]
		[Address(RVA = "0x1C29CA0", Offset = "0x1C288A0", VA = "0x181C29CA0")]
		public void AddSkinListItemViewModel(SkinShopBlindboxSkinListItemViewModel itemViewModel)
		{
		}

		// Token: 0x06021AF0 RID: 137968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021AF0")]
		[Address(RVA = "0x1C29F70", Offset = "0x1C28B70", VA = "0x181C29F70")]
		public void Sort()
		{
		}

		// Token: 0x06021AF1 RID: 137969 RVA: 0x000BB158 File Offset: 0x000B9358
		[Token(Token = "0x6021AF1")]
		[Address(RVA = "0x1C29EB0", Offset = "0x1C28AB0", VA = "0x181C29EB0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x0402E0ED RID: 188653
		[Token(Token = "0x402E0ED")]
		[FieldOffset(Offset = "0x18")]
		public bool isAchievedSkinGroup;

		// Token: 0x0402E0EE RID: 188654
		[Token(Token = "0x402E0EE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_skins;

		// Token: 0x0402E0EF RID: 188655
		[Token(Token = "0x402E0EF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_skins;

		// Token: 0x0402E0F0 RID: 188656
		[Token(Token = "0x402E0F0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402E0F1 RID: 188657
		[Token(Token = "0x402E0F1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x0402E0F2 RID: 188658
		[Token(Token = "0x402E0F2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_AddSkinListItemViewModel;

		// Token: 0x0402E0F3 RID: 188659
		[Token(Token = "0x402E0F3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Sort;

		// Token: 0x0402E0F4 RID: 188660
		[Token(Token = "0x402E0F4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_IsEmpty;
	}
}
