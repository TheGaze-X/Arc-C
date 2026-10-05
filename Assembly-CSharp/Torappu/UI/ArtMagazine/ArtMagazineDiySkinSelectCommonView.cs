using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x0200656E RID: 25966
	[Token(Token = "0x200656E")]
	public class ArtMagazineDiySkinSelectCommonView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025566 RID: 152934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025566")]
		[Address(RVA = "0x2052580", Offset = "0x2051180", VA = "0x182052580")]
		public void Render(ArtMagazineDiySkinGroupModel skinGroupModel)
		{
		}

		// Token: 0x06025567 RID: 152935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025567")]
		[Address(RVA = "0x2052740", Offset = "0x2051340", VA = "0x182052740")]
		public ArtMagazineDiySkinSelectCommonView()
		{
		}

		// Token: 0x0403463F RID: 214591
		[Token(Token = "0x403463F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ArtMagazineDiyLoopScrollAdapter _adapter;

		// Token: 0x04034640 RID: 214592
		[Token(Token = "0x4034640")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ArtMagazineDiyFilterGroupView[] _filterGroupList;

		// Token: 0x04034641 RID: 214593
		[Token(Token = "0x4034641")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ArtMagazineDiySorterItemView[] _sorterList;

		// Token: 0x04034642 RID: 214594
		[Token(Token = "0x4034642")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _emptyIcon;

		// Token: 0x04034643 RID: 214595
		[Token(Token = "0x4034643")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04034644 RID: 214596
		[Token(Token = "0x4034644")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
