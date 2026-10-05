using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200373E RID: 14142
	[Token(Token = "0x200373E")]
	public class UIItemUseConfirmFloat : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601676C RID: 92012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601676C")]
		[Address(RVA = "0xEEC9B0", Offset = "0xEEB5B0", VA = "0x180EEC9B0")]
		private void Start()
		{
		}

		// Token: 0x0601676D RID: 92013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601676D")]
		[Address(RVA = "0xEEC8F0", Offset = "0xEEB4F0", VA = "0x180EEC8F0")]
		public void RenderLockedPart(int cost, string itemId, ItemType itemType, string confirmText, Action onClick)
		{
		}

		// Token: 0x0601676E RID: 92014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601676E")]
		[Address(RVA = "0xEEC800", Offset = "0xEEB400", VA = "0x180EEC800")]
		public void OnClick()
		{
		}

		// Token: 0x0601676F RID: 92015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601676F")]
		[Address(RVA = "0xEEC770", Offset = "0xEEB370", VA = "0x180EEC770")]
		public void ClosePage()
		{
		}

		// Token: 0x06016770 RID: 92016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016770")]
		[Address(RVA = "0xEECAB0", Offset = "0xEEB6B0", VA = "0x180EECAB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06016771 RID: 92017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016771")]
		[Address(RVA = "0xEECE90", Offset = "0xEEBA90", VA = "0x180EECE90")]
		private void _RenderLockedPart(int cost, string itemId, ItemType itemType, string confirmText, Action onClick)
		{
		}

		// Token: 0x06016772 RID: 92018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016772")]
		[Address(RVA = "0xEED090", Offset = "0xEEBC90", VA = "0x180EED090")]
		public UIItemUseConfirmFloat()
		{
		}

		// Token: 0x0401B0D5 RID: 110805
		[Token(Token = "0x401B0D5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _container;

		// Token: 0x0401B0D6 RID: 110806
		[Token(Token = "0x401B0D6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _rootView;

		// Token: 0x0401B0D7 RID: 110807
		[Token(Token = "0x401B0D7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _backBtn;

		// Token: 0x0401B0D8 RID: 110808
		[Token(Token = "0x401B0D8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _confirmText;

		// Token: 0x0401B0D9 RID: 110809
		[Token(Token = "0x401B0D9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIBlurFloatPanel _backImage;

		// Token: 0x0401B0DA RID: 110810
		[Token(Token = "0x401B0DA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _itemContainer1;

		// Token: 0x0401B0DB RID: 110811
		[Token(Token = "0x401B0DB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _itemContainer2;

		// Token: 0x0401B0DC RID: 110812
		[Token(Token = "0x401B0DC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x0401B0DD RID: 110813
		[Token(Token = "0x401B0DD")]
		[FieldOffset(Offset = "0x58")]
		private Action m_onClick;

		// Token: 0x0401B0DE RID: 110814
		[Token(Token = "0x401B0DE")]
		[FieldOffset(Offset = "0x60")]
		private UIItemCard m_costItem;

		// Token: 0x0401B0DF RID: 110815
		[Token(Token = "0x401B0DF")]
		[FieldOffset(Offset = "0x68")]
		private UIItemCard m_targetItem;

		// Token: 0x0401B0E0 RID: 110816
		[Token(Token = "0x401B0E0")]
		[FieldOffset(Offset = "0x70")]
		private UIItemViewModel m_costModel;

		// Token: 0x0401B0E1 RID: 110817
		[Token(Token = "0x401B0E1")]
		[FieldOffset(Offset = "0x78")]
		private UIItemViewModel m_targetModel;

		// Token: 0x0401B0E2 RID: 110818
		[Token(Token = "0x401B0E2")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x0401B0E3 RID: 110819
		[Token(Token = "0x401B0E3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0401B0E4 RID: 110820
		[Token(Token = "0x401B0E4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderLockedPart;

		// Token: 0x0401B0E5 RID: 110821
		[Token(Token = "0x401B0E5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0401B0E6 RID: 110822
		[Token(Token = "0x401B0E6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ClosePage;

		// Token: 0x0401B0E7 RID: 110823
		[Token(Token = "0x401B0E7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401B0E8 RID: 110824
		[Token(Token = "0x401B0E8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderLockedPart;

		// Token: 0x0401B0E9 RID: 110825
		[Token(Token = "0x401B0E9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
