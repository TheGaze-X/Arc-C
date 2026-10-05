using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act42side
{
	// Token: 0x020072FF RID: 29439
	[Token(Token = "0x20072FF")]
	public class Act42sideRewardDetailItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029A62 RID: 170594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A62")]
		[Address(RVA = "0x251A410", Offset = "0x2519010", VA = "0x18251A410")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029A63 RID: 170595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A63")]
		[Address(RVA = "0x251A2F0", Offset = "0x2518EF0", VA = "0x18251A2F0")]
		public void Render(Act42sideRewardDetailItemViewModel itemViewModel)
		{
		}

		// Token: 0x06029A64 RID: 170596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A64")]
		[Address(RVA = "0x251A600", Offset = "0x2519200", VA = "0x18251A600")]
		private void _OnItemClick(int index)
		{
		}

		// Token: 0x06029A65 RID: 170597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A65")]
		[Address(RVA = "0x251A730", Offset = "0x2519330", VA = "0x18251A730")]
		public Act42sideRewardDetailItemView()
		{
		}

		// Token: 0x0403B930 RID: 244016
		[Token(Token = "0x403B930")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _title;

		// Token: 0x0403B931 RID: 244017
		[Token(Token = "0x403B931")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelGained;

		// Token: 0x0403B932 RID: 244018
		[Token(Token = "0x403B932")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelCurr;

		// Token: 0x0403B933 RID: 244019
		[Token(Token = "0x403B933")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x0403B934 RID: 244020
		[Token(Token = "0x403B934")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _itemCardContainer;

		// Token: 0x0403B935 RID: 244021
		[Token(Token = "0x403B935")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x0403B936 RID: 244022
		[Token(Token = "0x403B936")]
		[FieldOffset(Offset = "0x48")]
		private UIItemCard m_itemCard;

		// Token: 0x0403B937 RID: 244023
		[Token(Token = "0x403B937")]
		[FieldOffset(Offset = "0x50")]
		private UIItemViewModel m_itemViewModel;

		// Token: 0x0403B938 RID: 244024
		[Token(Token = "0x403B938")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403B939 RID: 244025
		[Token(Token = "0x403B939")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403B93A RID: 244026
		[Token(Token = "0x403B93A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnItemClick;

		// Token: 0x0403B93B RID: 244027
		[Token(Token = "0x403B93B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
