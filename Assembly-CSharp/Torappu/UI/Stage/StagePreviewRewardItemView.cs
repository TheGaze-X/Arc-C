using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006937 RID: 26935
	[Token(Token = "0x2006937")]
	public class StagePreviewRewardItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026927 RID: 157991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026927")]
		[Address(RVA = "0x21B58F0", Offset = "0x21B44F0", VA = "0x1821B58F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026928 RID: 157992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026928")]
		[Address(RVA = "0x21B5B60", Offset = "0x21B4760", VA = "0x1821B5B60")]
		private void _OnItemClicked(int index)
		{
		}

		// Token: 0x06026929 RID: 157993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026929")]
		[Address(RVA = "0x21B5650", Offset = "0x21B4250", VA = "0x1821B5650")]
		public void Render(StageRewardDetailViewModel viewModel, bool getFlag = false, bool completeFlag = false, [Optional] string timelyDropId, [Optional] string overrideDropId)
		{
		}

		// Token: 0x0602692A RID: 157994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602692A")]
		[Address(RVA = "0x21B5C60", Offset = "0x21B4860", VA = "0x1821B5C60")]
		private void _RenderTimelyDrop(string timelyDropId)
		{
		}

		// Token: 0x0602692B RID: 157995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602692B")]
		[Address(RVA = "0x21B5E90", Offset = "0x21B4A90", VA = "0x1821B5E90")]
		public StagePreviewRewardItemView()
		{
		}

		// Token: 0x04036681 RID: 222849
		[Token(Token = "0x4036681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _itemCardContainer;

		// Token: 0x04036682 RID: 222850
		[Token(Token = "0x4036682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _scalePercent;

		// Token: 0x04036683 RID: 222851
		[Token(Token = "0x4036683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _alwaysPart;

		// Token: 0x04036684 RID: 222852
		[Token(Token = "0x4036684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _almostPart;

		// Token: 0x04036685 RID: 222853
		[Token(Token = "0x4036685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _sometimePart;

		// Token: 0x04036686 RID: 222854
		[Token(Token = "0x4036686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _usualPart;

		// Token: 0x04036687 RID: 222855
		[Token(Token = "0x4036687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _oftenPart;

		// Token: 0x04036688 RID: 222856
		[Token(Token = "0x4036688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _alreadyGetPart;

		// Token: 0x04036689 RID: 222857
		[Token(Token = "0x4036689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _threeStarGetPart;

		// Token: 0x0403668A RID: 222858
		[Token(Token = "0x403668A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _overridePart;

		// Token: 0x0403668B RID: 222859
		[Token(Token = "0x403668B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _overrideDropTagText;

		// Token: 0x0403668C RID: 222860
		[Token(Token = "0x403668C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _timelyDropContainer;

		// Token: 0x0403668D RID: 222861
		[Token(Token = "0x403668D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GameObject m_timelyDropItem;

		// Token: 0x0403668E RID: 222862
		[Token(Token = "0x403668E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private string m_cacheDropId;

		// Token: 0x0403668F RID: 222863
		[Token(Token = "0x403668F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private UIItemCard m_itemCard;

		// Token: 0x04036690 RID: 222864
		[Token(Token = "0x4036690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool m_isInited;

		// Token: 0x04036691 RID: 222865
		[Token(Token = "0x4036691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04036692 RID: 222866
		[Token(Token = "0x4036692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnItemClicked;

		// Token: 0x04036693 RID: 222867
		[Token(Token = "0x4036693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04036694 RID: 222868
		[Token(Token = "0x4036694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderTimelyDrop;

		// Token: 0x04036695 RID: 222869
		[Token(Token = "0x4036695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
