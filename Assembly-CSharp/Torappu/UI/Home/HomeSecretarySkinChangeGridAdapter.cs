using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C1B RID: 19483
	[Token(Token = "0x2004C1B")]
	public class HomeSecretarySkinChangeGridAdapter : LoopScrollAdapter<HomeSecretarySkinChangeGridAdapter.ViewHolder, HomeSecretarySkinItemModel>
	{
		// Token: 0x0601D432 RID: 119858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D432")]
		[Address(RVA = "0x16D6DA0", Offset = "0x16D59A0", VA = "0x1816D6DA0")]
		public void SetArguments(HashSet<string> selectedTags, string previewId)
		{
		}

		// Token: 0x0601D433 RID: 119859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D433")]
		[Address(RVA = "0x16D6E40", Offset = "0x16D5A40", VA = "0x1816D6E40", Slot = "13")]
		public override void UpdateView(int position, GameObject view, HomeSecretarySkinChangeGridAdapter.ViewHolder holder, HomeSecretarySkinItemModel data)
		{
		}

		// Token: 0x0601D434 RID: 119860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D434")]
		[Address(RVA = "0x16D6CF0", Offset = "0x16D58F0", VA = "0x1816D6CF0", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0601D435 RID: 119861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D435")]
		[Address(RVA = "0x16D70E0", Offset = "0x16D5CE0", VA = "0x1816D70E0")]
		public HomeSecretarySkinChangeGridAdapter()
		{
		}

		// Token: 0x0402678F RID: 157583
		[Token(Token = "0x402678F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _prefab;

		// Token: 0x04026790 RID: 157584
		[Token(Token = "0x4026790")]
		[FieldOffset(Offset = "0x60")]
		private HashSet<string> m_selectedSkinTags;

		// Token: 0x04026791 RID: 157585
		[Token(Token = "0x4026791")]
		[FieldOffset(Offset = "0x68")]
		private string m_previewSkinTag;

		// Token: 0x04026792 RID: 157586
		[Token(Token = "0x4026792")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetArguments;

		// Token: 0x04026793 RID: 157587
		[Token(Token = "0x4026793")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04026794 RID: 157588
		[Token(Token = "0x4026794")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x04026795 RID: 157589
		[Token(Token = "0x4026795")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004C1C RID: 19484
		[Token(Token = "0x2004C1C")]
		public struct ViewHolder
		{
			// Token: 0x04026796 RID: 157590
			[Token(Token = "0x4026796")]
			[FieldOffset(Offset = "0x0")]
			public HomeSecretarySkinItemView itemView;
		}
	}
}
