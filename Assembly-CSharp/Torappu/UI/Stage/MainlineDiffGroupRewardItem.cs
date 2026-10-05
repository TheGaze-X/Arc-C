using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006785 RID: 26501
	[Token(Token = "0x2006785")]
	public class MainlineDiffGroupRewardItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026042 RID: 155714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026042")]
		[Address(RVA = "0x20FB560", Offset = "0x20FA160", VA = "0x1820FB560")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026043 RID: 155715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026043")]
		[Address(RVA = "0x20FB240", Offset = "0x20F9E40", VA = "0x1820FB240")]
		public void Render(StageBattleDiffGroupInfo.StageInfo stageViewModel, bool isSelectStage)
		{
		}

		// Token: 0x06026044 RID: 155716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026044")]
		[Address(RVA = "0x20FB1B0", Offset = "0x20F9DB0", VA = "0x1820FB1B0")]
		public void OnItemClick()
		{
		}

		// Token: 0x06026045 RID: 155717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026045")]
		[Address(RVA = "0x20FB630", Offset = "0x20FA230", VA = "0x1820FB630")]
		public MainlineDiffGroupRewardItem()
		{
		}

		// Token: 0x040357A9 RID: 219049
		[Token(Token = "0x40357A9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x040357AA RID: 219050
		[Token(Token = "0x40357AA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _icon;

		// Token: 0x040357AB RID: 219051
		[Token(Token = "0x40357AB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _apCost;

		// Token: 0x040357AC RID: 219052
		[Token(Token = "0x40357AC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _isPassed;

		// Token: 0x040357AD RID: 219053
		[Token(Token = "0x40357AD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _isComplete;

		// Token: 0x040357AE RID: 219054
		[Token(Token = "0x40357AE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _unPassed;

		// Token: 0x040357AF RID: 219055
		[Token(Token = "0x40357AF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _selectedObj;

		// Token: 0x040357B0 RID: 219056
		[Token(Token = "0x40357B0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _diffName;

		// Token: 0x040357B1 RID: 219057
		[Token(Token = "0x40357B1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private StageRewardPreviewItem _itemRewardCard;

		// Token: 0x040357B2 RID: 219058
		[Token(Token = "0x40357B2")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public UIStringEvent onRewardClick;

		// Token: 0x040357B3 RID: 219059
		[Token(Token = "0x40357B3")]
		[FieldOffset(Offset = "0x68")]
		private bool m_detail;

		// Token: 0x040357B4 RID: 219060
		[Token(Token = "0x40357B4")]
		[FieldOffset(Offset = "0x70")]
		private StageBattleDiffGroupInfo.StageInfo m_cacheViewModel;

		// Token: 0x040357B5 RID: 219061
		[Token(Token = "0x40357B5")]
		[FieldOffset(Offset = "0x78")]
		private StageRewardPreviewItem m_itemRewardCard;

		// Token: 0x040357B6 RID: 219062
		[Token(Token = "0x40357B6")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x040357B7 RID: 219063
		[Token(Token = "0x40357B7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040357B8 RID: 219064
		[Token(Token = "0x40357B8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040357B9 RID: 219065
		[Token(Token = "0x40357B9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x040357BA RID: 219066
		[Token(Token = "0x40357BA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
