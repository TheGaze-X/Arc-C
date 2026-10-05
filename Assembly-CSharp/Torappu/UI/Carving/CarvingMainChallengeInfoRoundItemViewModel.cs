using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x02006074 RID: 24692
	[Token(Token = "0x2006074")]
	public class CarvingMainChallengeInfoRoundItemViewModel : IHotfixable
	{
		// Token: 0x17005453 RID: 21587
		// (get) Token: 0x06023B45 RID: 146245 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06023B46 RID: 146246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005453")]
		public string roundTitle
		{
			[Token(Token = "0x6023B45")]
			[Address(RVA = "0x1E57D10", Offset = "0x1E56910", VA = "0x181E57D10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6023B46")]
			[Address(RVA = "0x1E57DF0", Offset = "0x1E569F0", VA = "0x181E57DF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005454 RID: 21588
		// (get) Token: 0x06023B47 RID: 146247 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06023B48 RID: 146248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005454")]
		public List<CarvingMaterialModel> materialItemList
		{
			[Token(Token = "0x6023B47")]
			[Address(RVA = "0x1E57CB0", Offset = "0x1E568B0", VA = "0x181E57CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6023B48")]
			[Address(RVA = "0x1E57D70", Offset = "0x1E56970", VA = "0x181E57D70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06023B49 RID: 146249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B49")]
		[Address(RVA = "0x1E57640", Offset = "0x1E56240", VA = "0x181E57640")]
		public void LoadData(string actId, Dictionary<string, int> fixedMaterialList, int roundNum, Dictionary<string, Act35SideData.Act35SideMaterialData> materialDataMap)
		{
		}

		// Token: 0x06023B4A RID: 146250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B4A")]
		[Address(RVA = "0x1E57C50", Offset = "0x1E56850", VA = "0x181E57C50")]
		public CarvingMainChallengeInfoRoundItemViewModel()
		{
		}

		// Token: 0x040317B7 RID: 202679
		[Token(Token = "0x40317B7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_roundTitle;

		// Token: 0x040317B8 RID: 202680
		[Token(Token = "0x40317B8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_roundTitle;

		// Token: 0x040317B9 RID: 202681
		[Token(Token = "0x40317B9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_materialItemList;

		// Token: 0x040317BA RID: 202682
		[Token(Token = "0x40317BA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_materialItemList;

		// Token: 0x040317BB RID: 202683
		[Token(Token = "0x40317BB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040317BC RID: 202684
		[Token(Token = "0x40317BC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
