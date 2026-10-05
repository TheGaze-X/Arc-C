using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B6B RID: 27499
	[Token(Token = "0x2006B6B")]
	public class ArchiveDisasterRightPanelItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060274AB RID: 160939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274AB")]
		[Address(RVA = "0x227BD90", Offset = "0x227A990", VA = "0x18227BD90")]
		public void Render(DisasterItemModel itemModel)
		{
		}

		// Token: 0x060274AC RID: 160940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274AC")]
		[Address(RVA = "0x227BF10", Offset = "0x227AB10", VA = "0x18227BF10")]
		public ArchiveDisasterRightPanelItemView()
		{
		}

		// Token: 0x04037A1E RID: 227870
		[Token(Token = "0x4037A1E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _titleBgToggle;

		// Token: 0x04037A1F RID: 227871
		[Token(Token = "0x4037A1F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _levelName;

		// Token: 0x04037A20 RID: 227872
		[Token(Token = "0x4037A20")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject[] _levelIcons;

		// Token: 0x04037A21 RID: 227873
		[Token(Token = "0x4037A21")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _effect;

		// Token: 0x04037A22 RID: 227874
		[Token(Token = "0x4037A22")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04037A23 RID: 227875
		[Token(Token = "0x4037A23")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
