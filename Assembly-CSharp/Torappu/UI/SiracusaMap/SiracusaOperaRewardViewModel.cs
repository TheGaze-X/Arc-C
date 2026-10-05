using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F4D RID: 16205
	[Token(Token = "0x2003F4D")]
	public class SiracusaOperaRewardViewModel : IHotfixable
	{
		// Token: 0x0601927A RID: 103034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601927A")]
		[Address(RVA = "0x11DD3E0", Offset = "0x11DBFE0", VA = "0x1811DD3E0")]
		public void InitData(string charId)
		{
		}

		// Token: 0x0601927B RID: 103035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601927B")]
		[Address(RVA = "0x11DD4F0", Offset = "0x11DC0F0", VA = "0x1811DD4F0")]
		public SiracusaOperaRewardViewModel()
		{
		}

		// Token: 0x0401F2E8 RID: 127720
		[Token(Token = "0x401F2E8")]
		[FieldOffset(Offset = "0x10")]
		public SiracusaData.CharCardData charCardData;

		// Token: 0x0401F2E9 RID: 127721
		[Token(Token = "0x401F2E9")]
		[FieldOffset(Offset = "0x18")]
		public SiracusaData.ItemInfoData itemInfoData;

		// Token: 0x0401F2EA RID: 127722
		[Token(Token = "0x401F2EA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0401F2EB RID: 127723
		[Token(Token = "0x401F2EB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
