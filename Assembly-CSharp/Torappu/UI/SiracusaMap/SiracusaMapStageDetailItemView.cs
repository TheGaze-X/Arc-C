using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003EFB RID: 16123
	[Token(Token = "0x2003EFB")]
	public class SiracusaMapStageDetailItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003BC8 RID: 15304
		// (get) Token: 0x06019084 RID: 102532 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019085 RID: 102533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BC8")]
		public Action<string> selectChanged
		{
			[Token(Token = "0x6019084")]
			[Address(RVA = "0x11BF0D0", Offset = "0x11BDCD0", VA = "0x1811BF0D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6019085")]
			[Address(RVA = "0x11BF130", Offset = "0x11BDD30", VA = "0x1811BF130")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06019086 RID: 102534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019086")]
		[Address(RVA = "0x11BE990", Offset = "0x11BD590", VA = "0x1811BE990")]
		public void Render(SiracusaMapStageDetailInfoViewModel viewModel)
		{
		}

		// Token: 0x06019087 RID: 102535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019087")]
		[Address(RVA = "0x11BEEA0", Offset = "0x11BDAA0", VA = "0x1811BEEA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019088 RID: 102536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019088")]
		[Address(RVA = "0x11BEFA0", Offset = "0x11BDBA0", VA = "0x1811BEFA0")]
		private void _RefreshStageRank(bool isAvg, int stageRank)
		{
		}

		// Token: 0x06019089 RID: 102537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019089")]
		[Address(RVA = "0x11BEF20", Offset = "0x11BDB20", VA = "0x1811BEF20")]
		private void _RefreshSelectState(bool select)
		{
		}

		// Token: 0x0601908A RID: 102538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601908A")]
		[Address(RVA = "0x11BE8B0", Offset = "0x11BD4B0", VA = "0x1811BE8B0")]
		public void OnDetailItemClick()
		{
		}

		// Token: 0x0601908B RID: 102539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601908B")]
		[Address(RVA = "0x11BF070", Offset = "0x11BDC70", VA = "0x1811BF070")]
		public SiracusaMapStageDetailItemView()
		{
		}

		// Token: 0x0401EF22 RID: 126754
		[Token(Token = "0x401EF22")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objLevelPart;

		// Token: 0x0401EF23 RID: 126755
		[Token(Token = "0x401EF23")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtLevelName1;

		// Token: 0x0401EF24 RID: 126756
		[Token(Token = "0x401EF24")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtLevelName2;

		// Token: 0x0401EF25 RID: 126757
		[Token(Token = "0x401EF25")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private StageRankView _stageRankView;

		// Token: 0x0401EF26 RID: 126758
		[Token(Token = "0x401EF26")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _objAvgPart;

		// Token: 0x0401EF27 RID: 126759
		[Token(Token = "0x401EF27")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _txtAvgName1;

		// Token: 0x0401EF28 RID: 126760
		[Token(Token = "0x401EF28")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _txtAvgName2;

		// Token: 0x0401EF29 RID: 126761
		[Token(Token = "0x401EF29")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _objAvgState;

		// Token: 0x0401EF2A RID: 126762
		[Token(Token = "0x401EF2A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _txtAvgState;

		// Token: 0x0401EF2B RID: 126763
		[Token(Token = "0x401EF2B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _objSelectPart;

		// Token: 0x0401EF2C RID: 126764
		[Token(Token = "0x401EF2C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _objExploreMoreTips;

		// Token: 0x0401EF2D RID: 126765
		[Token(Token = "0x401EF2D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _objSplitLine;

		// Token: 0x0401EF2E RID: 126766
		[Token(Token = "0x401EF2E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _objClickArea;

		// Token: 0x0401EF2F RID: 126767
		[Token(Token = "0x401EF2F")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isSelecting;

		// Token: 0x0401EF30 RID: 126768
		[Token(Token = "0x401EF30")]
		[FieldOffset(Offset = "0x88")]
		private string m_cachedItemId;

		// Token: 0x0401EF31 RID: 126769
		[Token(Token = "0x401EF31")]
		[FieldOffset(Offset = "0x90")]
		private bool m_inited;

		// Token: 0x0401EF33 RID: 126771
		[Token(Token = "0x401EF33")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectChanged;

		// Token: 0x0401EF34 RID: 126772
		[Token(Token = "0x401EF34")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_selectChanged;

		// Token: 0x0401EF35 RID: 126773
		[Token(Token = "0x401EF35")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401EF36 RID: 126774
		[Token(Token = "0x401EF36")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401EF37 RID: 126775
		[Token(Token = "0x401EF37")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RefreshStageRank;

		// Token: 0x0401EF38 RID: 126776
		[Token(Token = "0x401EF38")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RefreshSelectState;

		// Token: 0x0401EF39 RID: 126777
		[Token(Token = "0x401EF39")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnDetailItemClick;

		// Token: 0x0401EF3A RID: 126778
		[Token(Token = "0x401EF3A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
