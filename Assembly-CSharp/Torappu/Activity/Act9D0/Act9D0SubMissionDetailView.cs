using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x0200717C RID: 29052
	[Token(Token = "0x200717C")]
	public class Act9D0SubMissionDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060293E0 RID: 168928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293E0")]
		[Address(RVA = "0x24A4B30", Offset = "0x24A3730", VA = "0x1824A4B30")]
		public void Render(SubMissionViewModel viewModel)
		{
		}

		// Token: 0x060293E1 RID: 168929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293E1")]
		[Address(RVA = "0x24A5120", Offset = "0x24A3D20", VA = "0x1824A5120")]
		private void _RenderMissionRewards(SubMissionViewModel viewModel)
		{
		}

		// Token: 0x060293E2 RID: 168930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60293E2")]
		[Address(RVA = "0x24A4E40", Offset = "0x24A3A40", VA = "0x1824A4E40")]
		private UIItemCard _CreateItemCard()
		{
			return null;
		}

		// Token: 0x060293E3 RID: 168931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293E3")]
		[Address(RVA = "0x24A4FF0", Offset = "0x24A3BF0", VA = "0x1824A4FF0")]
		private void _OnRewardItemClicked(int index)
		{
		}

		// Token: 0x060293E4 RID: 168932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293E4")]
		[Address(RVA = "0x24A5450", Offset = "0x24A4050", VA = "0x1824A5450")]
		public Act9D0SubMissionDetailView()
		{
		}

		// Token: 0x0403AE65 RID: 241253
		[Token(Token = "0x403AE65")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0403AE66 RID: 241254
		[Token(Token = "0x403AE66")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _ableToGet;

		// Token: 0x0403AE67 RID: 241255
		[Token(Token = "0x403AE67")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _alreadyGet;

		// Token: 0x0403AE68 RID: 241256
		[Token(Token = "0x403AE68")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Slider _slider;

		// Token: 0x0403AE69 RID: 241257
		[Token(Token = "0x403AE69")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _schedule;

		// Token: 0x0403AE6A RID: 241258
		[Token(Token = "0x403AE6A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _titleText;

		// Token: 0x0403AE6B RID: 241259
		[Token(Token = "0x403AE6B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _contentText;

		// Token: 0x0403AE6C RID: 241260
		[Token(Token = "0x403AE6C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<Sprite> _iconList;

		// Token: 0x0403AE6D RID: 241261
		[Token(Token = "0x403AE6D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _cardContainer;

		// Token: 0x0403AE6E RID: 241262
		[Token(Token = "0x403AE6E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _scaleFactor;

		// Token: 0x0403AE6F RID: 241263
		[Token(Token = "0x403AE6F")]
		[FieldOffset(Offset = "0x68")]
		private List<UIItemCard> m_itemCardList;

		// Token: 0x0403AE70 RID: 241264
		[Token(Token = "0x403AE70")]
		[FieldOffset(Offset = "0x70")]
		private List<UIItemViewModel> m_rewardList;

		// Token: 0x0403AE71 RID: 241265
		[Token(Token = "0x403AE71")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403AE72 RID: 241266
		[Token(Token = "0x403AE72")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderMissionRewards;

		// Token: 0x0403AE73 RID: 241267
		[Token(Token = "0x403AE73")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CreateItemCard;

		// Token: 0x0403AE74 RID: 241268
		[Token(Token = "0x403AE74")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnRewardItemClicked;

		// Token: 0x0403AE75 RID: 241269
		[Token(Token = "0x403AE75")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
