using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EC4 RID: 20164
	[Token(Token = "0x2004EC4")]
	public class FifthAnnivExploreGroupChooseViewModel : IHotfixable
	{
		// Token: 0x1700469D RID: 18077
		// (get) Token: 0x0601E173 RID: 123251 RVA: 0x000AD7A8 File Offset: 0x000AB9A8
		// (set) Token: 0x0601E174 RID: 123252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700469D")]
		public bool hasSelectHeritage
		{
			[Token(Token = "0x601E173")]
			[Address(RVA = "0x17CB540", Offset = "0x17CA140", VA = "0x1817CB540")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601E174")]
			[Address(RVA = "0x17CB610", Offset = "0x17CA210", VA = "0x1817CB610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700469E RID: 18078
		// (get) Token: 0x0601E175 RID: 123253 RVA: 0x000AD7C0 File Offset: 0x000AB9C0
		// (set) Token: 0x0601E176 RID: 123254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700469E")]
		public bool hasHeritageData
		{
			[Token(Token = "0x601E175")]
			[Address(RVA = "0x17CB4E0", Offset = "0x17CA0E0", VA = "0x1817CB4E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601E176")]
			[Address(RVA = "0x17CB5A0", Offset = "0x17CA1A0", VA = "0x1817CB5A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601E177 RID: 123255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E177")]
		[Address(RVA = "0x17CAD00", Offset = "0x17C9900", VA = "0x1817CAD00")]
		public void LoadData()
		{
		}

		// Token: 0x0601E178 RID: 123256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E178")]
		[Address(RVA = "0x17CB230", Offset = "0x17C9E30", VA = "0x1817CB230")]
		public void SetHeritageSelect(bool value)
		{
		}

		// Token: 0x0601E179 RID: 123257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E179")]
		[Address(RVA = "0x17CB0E0", Offset = "0x17C9CE0", VA = "0x1817CB0E0")]
		public void SelectGroup(int position)
		{
		}

		// Token: 0x0601E17A RID: 123258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E17A")]
		[Address(RVA = "0x17CB3D0", Offset = "0x17C9FD0", VA = "0x1817CB3D0")]
		private PlayerMainlineExplore.PlayerExploreGameResult _GetLastGameResultFromPlayerData()
		{
			return null;
		}

		// Token: 0x0601E17B RID: 123259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E17B")]
		[Address(RVA = "0x17CB480", Offset = "0x17CA080", VA = "0x1817CB480")]
		public FifthAnnivExploreGroupChooseViewModel()
		{
		}

		// Token: 0x04028072 RID: 163954
		[Token(Token = "0x4028072")]
		[FieldOffset(Offset = "0x10")]
		public FifthAnnivExploreGroupChoiceItemViewModel selectedChoiceItemViewModel;

		// Token: 0x04028073 RID: 163955
		[Token(Token = "0x4028073")]
		[FieldOffset(Offset = "0x18")]
		public List<FifthAnnivExploreGroupChoiceItemViewModel> groupChoiceItemViewModels;

		// Token: 0x04028076 RID: 163958
		[Token(Token = "0x4028076")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hasSelectHeritage;

		// Token: 0x04028077 RID: 163959
		[Token(Token = "0x4028077")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_hasSelectHeritage;

		// Token: 0x04028078 RID: 163960
		[Token(Token = "0x4028078")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_hasHeritageData;

		// Token: 0x04028079 RID: 163961
		[Token(Token = "0x4028079")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_hasHeritageData;

		// Token: 0x0402807A RID: 163962
		[Token(Token = "0x402807A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402807B RID: 163963
		[Token(Token = "0x402807B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetHeritageSelect;

		// Token: 0x0402807C RID: 163964
		[Token(Token = "0x402807C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SelectGroup;

		// Token: 0x0402807D RID: 163965
		[Token(Token = "0x402807D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetLastGameResultFromPlayerData;

		// Token: 0x0402807E RID: 163966
		[Token(Token = "0x402807E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
