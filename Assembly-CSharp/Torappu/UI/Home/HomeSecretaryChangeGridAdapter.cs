using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C18 RID: 19480
	[Token(Token = "0x2004C18")]
	public class HomeSecretaryChangeGridAdapter : HomeSecretaryCardScrollAdapter<HomeSecretaryChangeGridAdapter.ViewHolder>
	{
		// Token: 0x0601D42B RID: 119851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D42B")]
		[Address(RVA = "0x16D64A0", Offset = "0x16D50A0", VA = "0x1816D64A0")]
		public void SetArguments(HashSet<int> selectedInstIds, HashSet<int> starMarkSelectedInstIds, Dictionary<string, List<string>> inPresetSkinDict, int previewInstId)
		{
		}

		// Token: 0x0601D42C RID: 119852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D42C")]
		[Address(RVA = "0x16D6570", Offset = "0x16D5170", VA = "0x1816D6570", Slot = "13")]
		public override void UpdateView(int position, GameObject view, HomeSecretaryChangeGridAdapter.ViewHolder holder, HomeSecretaryCardViewModel data)
		{
		}

		// Token: 0x0601D42D RID: 119853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D42D")]
		[Address(RVA = "0x16D63F0", Offset = "0x16D4FF0", VA = "0x1816D63F0", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0601D42E RID: 119854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D42E")]
		[Address(RVA = "0x16D6810", Offset = "0x16D5410", VA = "0x1816D6810")]
		public HomeSecretaryChangeGridAdapter()
		{
		}

		// Token: 0x0402677C RID: 157564
		[Token(Token = "0x402677C")]
		private const int DEFAULT_SKIN_NUM = 1;

		// Token: 0x0402677D RID: 157565
		[Token(Token = "0x402677D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _charCardViewPrefab;

		// Token: 0x0402677E RID: 157566
		[Token(Token = "0x402677E")]
		[FieldOffset(Offset = "0x68")]
		private HashSet<int> m_selectedChrInstIds;

		// Token: 0x0402677F RID: 157567
		[Token(Token = "0x402677F")]
		[FieldOffset(Offset = "0x70")]
		private HashSet<int> m_starMarkSelectedInstIds;

		// Token: 0x04026780 RID: 157568
		[Token(Token = "0x4026780")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<string, List<string>> m_inPresetSkinDict;

		// Token: 0x04026781 RID: 157569
		[Token(Token = "0x4026781")]
		[FieldOffset(Offset = "0x80")]
		private int m_previewingInstId;

		// Token: 0x04026782 RID: 157570
		[Token(Token = "0x4026782")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetArguments;

		// Token: 0x04026783 RID: 157571
		[Token(Token = "0x4026783")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04026784 RID: 157572
		[Token(Token = "0x4026784")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x04026785 RID: 157573
		[Token(Token = "0x4026785")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004C19 RID: 19481
		[Token(Token = "0x2004C19")]
		public struct ViewHolder
		{
			// Token: 0x04026786 RID: 157574
			[Token(Token = "0x4026786")]
			[FieldOffset(Offset = "0x0")]
			public HomeSecretaryChangeCardView cardView;
		}
	}
}
