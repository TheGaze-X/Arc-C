using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act4D0
{
	// Token: 0x02007288 RID: 29320
	[Token(Token = "0x2007288")]
	public class Act4D0MileStoneItemObj : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029867 RID: 170087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029867")]
		[Address(RVA = "0x24DE3A0", Offset = "0x24DCFA0", VA = "0x1824DE3A0")]
		private void _Inited()
		{
		}

		// Token: 0x06029868 RID: 170088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029868")]
		[Address(RVA = "0x24DDB60", Offset = "0x24DC760", VA = "0x1824DDB60")]
		public void OnClick()
		{
		}

		// Token: 0x06029869 RID: 170089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029869")]
		[Address(RVA = "0x24DDBF0", Offset = "0x24DC7F0", VA = "0x1824DDBF0")]
		public void OnFocus()
		{
		}

		// Token: 0x0602986A RID: 170090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602986A")]
		[Address(RVA = "0x24DDFF0", Offset = "0x24DCBF0", VA = "0x1824DDFF0")]
		public void RenderStoryPart(Act4D0MileStoneViewModel viewModel)
		{
		}

		// Token: 0x0602986B RID: 170091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602986B")]
		[Address(RVA = "0x24DDC60", Offset = "0x24DC860", VA = "0x1824DDC60")]
		public void RenderItemPart(Act4D0MileStoneViewModel viewModel)
		{
		}

		// Token: 0x0602986C RID: 170092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602986C")]
		[Address(RVA = "0x24DD720", Offset = "0x24DC320", VA = "0x1824DD720")]
		public void InitData(Act4D0MileStoneViewModel viewModel)
		{
		}

		// Token: 0x0602986D RID: 170093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602986D")]
		[Address(RVA = "0x24DE550", Offset = "0x24DD150", VA = "0x1824DE550")]
		public Act4D0MileStoneItemObj()
		{
		}

		// Token: 0x0403B551 RID: 243025
		[Token(Token = "0x403B551")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _finishImg;

		// Token: 0x0403B552 RID: 243026
		[Token(Token = "0x403B552")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _ableToGetImg;

		// Token: 0x0403B553 RID: 243027
		[Token(Token = "0x403B553")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _ableToGetPart;

		// Token: 0x0403B554 RID: 243028
		[Token(Token = "0x403B554")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _finishPart;

		// Token: 0x0403B555 RID: 243029
		[Token(Token = "0x403B555")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _cannotGetPart;

		// Token: 0x0403B556 RID: 243030
		[Token(Token = "0x403B556")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _finishBackgroundPart;

		// Token: 0x0403B557 RID: 243031
		[Token(Token = "0x403B557")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _scaleInfo;

		// Token: 0x0403B558 RID: 243032
		[Token(Token = "0x403B558")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _itemViewContainer;

		// Token: 0x0403B559 RID: 243033
		[Token(Token = "0x403B559")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _charGetPart;

		// Token: 0x0403B55A RID: 243034
		[Token(Token = "0x403B55A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _itemGetPart;

		// Token: 0x0403B55B RID: 243035
		[Token(Token = "0x403B55B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _detailText;

		// Token: 0x0403B55C RID: 243036
		[Token(Token = "0x403B55C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _detailText_2;

		// Token: 0x0403B55D RID: 243037
		[Token(Token = "0x403B55D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _countText;

		// Token: 0x0403B55E RID: 243038
		[Token(Token = "0x403B55E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _countText_2;

		// Token: 0x0403B55F RID: 243039
		[Token(Token = "0x403B55F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _countTextActive;

		// Token: 0x0403B560 RID: 243040
		[Token(Token = "0x403B560")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _countTextNoActive;

		// Token: 0x0403B561 RID: 243041
		[Token(Token = "0x403B561")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _itemName;

		// Token: 0x0403B562 RID: 243042
		[Token(Token = "0x403B562")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Image _storyImg;

		// Token: 0x0403B563 RID: 243043
		[Token(Token = "0x403B563")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Image _countSymbol;

		// Token: 0x0403B564 RID: 243044
		[Token(Token = "0x403B564")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Image _charHead;

		// Token: 0x0403B565 RID: 243045
		[Token(Token = "0x403B565")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _storyObj;

		// Token: 0x0403B566 RID: 243046
		[Token(Token = "0x403B566")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _itemObj;

		// Token: 0x0403B567 RID: 243047
		[Token(Token = "0x403B567")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private GameObject _ableToGetObj;

		// Token: 0x0403B568 RID: 243048
		[Token(Token = "0x403B568")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Button _ableToGetButton;

		// Token: 0x0403B569 RID: 243049
		[Token(Token = "0x403B569")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Button _ableToGetButtonChar;

		// Token: 0x0403B56A RID: 243050
		[Token(Token = "0x403B56A")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Text _getText;

		// Token: 0x0403B56B RID: 243051
		[Token(Token = "0x403B56B")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private GameObject _focusLight;

		// Token: 0x0403B56C RID: 243052
		[Token(Token = "0x403B56C")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Color _storyTextColor;

		// Token: 0x0403B56D RID: 243053
		[Token(Token = "0x403B56D")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Color _itemTextColor;

		// Token: 0x0403B56E RID: 243054
		[Token(Token = "0x403B56E")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Color _notFinishTextColor;

		// Token: 0x0403B56F RID: 243055
		[Token(Token = "0x403B56F")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private Color _notFinishedCountColor;

		// Token: 0x0403B570 RID: 243056
		[Token(Token = "0x403B570")]
		[FieldOffset(Offset = "0x130")]
		[NonSerialized]
		public UIStringEvent clickEvent;

		// Token: 0x0403B571 RID: 243057
		[Token(Token = "0x403B571")]
		[FieldOffset(Offset = "0x138")]
		private bool m_isInited;

		// Token: 0x0403B572 RID: 243058
		[Token(Token = "0x403B572")]
		[FieldOffset(Offset = "0x140")]
		private UIItemCard m_itemCard;

		// Token: 0x0403B573 RID: 243059
		[Token(Token = "0x403B573")]
		[FieldOffset(Offset = "0x148")]
		private string m_cacheId;

		// Token: 0x0403B574 RID: 243060
		[Token(Token = "0x403B574")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__Inited;

		// Token: 0x0403B575 RID: 243061
		[Token(Token = "0x403B575")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403B576 RID: 243062
		[Token(Token = "0x403B576")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnFocus;

		// Token: 0x0403B577 RID: 243063
		[Token(Token = "0x403B577")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderStoryPart;

		// Token: 0x0403B578 RID: 243064
		[Token(Token = "0x403B578")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RenderItemPart;

		// Token: 0x0403B579 RID: 243065
		[Token(Token = "0x403B579")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0403B57A RID: 243066
		[Token(Token = "0x403B57A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
