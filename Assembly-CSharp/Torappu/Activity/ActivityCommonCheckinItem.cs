using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006DAD RID: 28077
	[Token(Token = "0x2006DAD")]
	public class ActivityCommonCheckinItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027FCA RID: 163786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FCA")]
		[Address(RVA = "0x2338600", Offset = "0x2337200", VA = "0x182338600")]
		private void OnEnable()
		{
		}

		// Token: 0x06027FCB RID: 163787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FCB")]
		[Address(RVA = "0x23388D0", Offset = "0x23374D0", VA = "0x1823388D0")]
		private void _RenderItem(int order, List<ItemBundle> itemList, bool isReceived)
		{
		}

		// Token: 0x06027FCC RID: 163788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FCC")]
		[Address(RVA = "0x2338700", Offset = "0x2337300", VA = "0x182338700")]
		public void RenderItemView(int order, int dayInfo, List<ItemBundle> itemList, bool hasInfoFlag, bool canReceiveFlag = false)
		{
		}

		// Token: 0x06027FCD RID: 163789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FCD")]
		[Address(RVA = "0x2338680", Offset = "0x2337280", VA = "0x182338680")]
		public void OnReceive()
		{
		}

		// Token: 0x06027FCE RID: 163790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FCE")]
		[Address(RVA = "0x2338C40", Offset = "0x2337840", VA = "0x182338C40")]
		public ActivityCommonCheckinItem()
		{
		}

		// Token: 0x04038AC6 RID: 232134
		[Token(Token = "0x4038AC6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x04038AC7 RID: 232135
		[Token(Token = "0x4038AC7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _canReceiveBack;

		// Token: 0x04038AC8 RID: 232136
		[Token(Token = "0x4038AC8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _normalBack;

		// Token: 0x04038AC9 RID: 232137
		[Token(Token = "0x4038AC9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _canNotReceiveBtn;

		// Token: 0x04038ACA RID: 232138
		[Token(Token = "0x4038ACA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _alreadyReceiveBtn;

		// Token: 0x04038ACB RID: 232139
		[Token(Token = "0x4038ACB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _acceptReceiveBack;

		// Token: 0x04038ACC RID: 232140
		[Token(Token = "0x4038ACC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04038ACD RID: 232141
		[Token(Token = "0x4038ACD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _orderIndex;

		// Token: 0x04038ACE RID: 232142
		[Token(Token = "0x4038ACE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ActivityCommonCheckinItemObj _itemObj;

		// Token: 0x04038ACF RID: 232143
		[Token(Token = "0x4038ACF")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public UIIntEvent clickEvent;

		// Token: 0x04038AD0 RID: 232144
		[Token(Token = "0x4038AD0")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x04038AD1 RID: 232145
		[Token(Token = "0x4038AD1")]
		[FieldOffset(Offset = "0x70")]
		private int m_order;

		// Token: 0x04038AD2 RID: 232146
		[Token(Token = "0x4038AD2")]
		[FieldOffset(Offset = "0x74")]
		private bool m_isReceived;

		// Token: 0x04038AD3 RID: 232147
		[Token(Token = "0x4038AD3")]
		private const string ANIMATOR_PARAM = "fadein";

		// Token: 0x04038AD4 RID: 232148
		[Token(Token = "0x4038AD4")]
		[FieldOffset(Offset = "0x78")]
		private List<ActivityCommonCheckinItemObj> m_itemCardList;

		// Token: 0x04038AD5 RID: 232149
		[Token(Token = "0x4038AD5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x04038AD6 RID: 232150
		[Token(Token = "0x4038AD6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderItem;

		// Token: 0x04038AD7 RID: 232151
		[Token(Token = "0x4038AD7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderItemView;

		// Token: 0x04038AD8 RID: 232152
		[Token(Token = "0x4038AD8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnReceive;

		// Token: 0x04038AD9 RID: 232153
		[Token(Token = "0x4038AD9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
