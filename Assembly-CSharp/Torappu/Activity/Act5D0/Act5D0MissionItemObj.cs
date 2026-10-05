using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act5D0
{
	// Token: 0x020071F6 RID: 29174
	[Token(Token = "0x20071F6")]
	public class Act5D0MissionItemObj : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029614 RID: 169492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029614")]
		[Address(RVA = "0x24C26B0", Offset = "0x24C12B0", VA = "0x1824C26B0")]
		public void RenderItemPart(Act5D0MissionViewModel viewModel)
		{
		}

		// Token: 0x06029615 RID: 169493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029615")]
		[Address(RVA = "0x24C2630", Offset = "0x24C1230", VA = "0x1824C2630")]
		public void InitData(Act5D0MissionViewModel viewModel)
		{
		}

		// Token: 0x06029616 RID: 169494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029616")]
		[Address(RVA = "0x24C2DA0", Offset = "0x24C19A0", VA = "0x1824C2DA0")]
		public Act5D0MissionItemObj()
		{
		}

		// Token: 0x0403B19F RID: 242079
		[Token(Token = "0x403B19F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _bg;

		// Token: 0x0403B1A0 RID: 242080
		[Token(Token = "0x403B1A0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _difficulty;

		// Token: 0x0403B1A1 RID: 242081
		[Token(Token = "0x403B1A1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _difficultyAppend;

		// Token: 0x0403B1A2 RID: 242082
		[Token(Token = "0x403B1A2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _reward;

		// Token: 0x0403B1A3 RID: 242083
		[Token(Token = "0x403B1A3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _rewardAppend;

		// Token: 0x0403B1A4 RID: 242084
		[Token(Token = "0x403B1A4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _title;

		// Token: 0x0403B1A5 RID: 242085
		[Token(Token = "0x403B1A5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0403B1A6 RID: 242086
		[Token(Token = "0x403B1A6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _rewardItemCount;

		// Token: 0x0403B1A7 RID: 242087
		[Token(Token = "0x403B1A7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _crossImg;

		// Token: 0x0403B1A8 RID: 242088
		[Token(Token = "0x403B1A8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _finishMask;

		// Token: 0x0403B1A9 RID: 242089
		[Token(Token = "0x403B1A9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _itemCanvas;

		// Token: 0x0403B1AA RID: 242090
		[Token(Token = "0x403B1AA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _itemViewContainer;

		// Token: 0x0403B1AB RID: 242091
		[Token(Token = "0x403B1AB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _itemCardScaleFactor;

		// Token: 0x0403B1AC RID: 242092
		[Token(Token = "0x403B1AC")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		public UIStringEvent clickEvent;

		// Token: 0x0403B1AD RID: 242093
		[Token(Token = "0x403B1AD")]
		[FieldOffset(Offset = "0x88")]
		private UIItemCard m_itemCard;

		// Token: 0x0403B1AE RID: 242094
		[Token(Token = "0x403B1AE")]
		[FieldOffset(Offset = "0x90")]
		private bool m_itemInited;

		// Token: 0x0403B1AF RID: 242095
		[Token(Token = "0x403B1AF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderItemPart;

		// Token: 0x0403B1B0 RID: 242096
		[Token(Token = "0x403B1B0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0403B1B1 RID: 242097
		[Token(Token = "0x403B1B1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
