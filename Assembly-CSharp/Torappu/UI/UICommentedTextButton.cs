using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039E0 RID: 14816
	[Token(Token = "0x20039E0")]
	public class UICommentedTextButton : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601766A RID: 95850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601766A")]
		[Address(RVA = "0xFBDE90", Offset = "0xFBCA90", VA = "0x180FBDE90")]
		public void Init(UICommentedTextData data)
		{
		}

		// Token: 0x0601766B RID: 95851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601766B")]
		[Address(RVA = "0xFBE1A0", Offset = "0xFBCDA0", VA = "0x180FBE1A0")]
		public void SetSize(Vector2 sizeDelta, Vector2 hotzone, Vector3 anchor3D)
		{
		}

		// Token: 0x0601766C RID: 95852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601766C")]
		[Address(RVA = "0xFBDE00", Offset = "0xFBCA00", VA = "0x180FBDE00")]
		public void EventOnClick()
		{
		}

		// Token: 0x0601766D RID: 95853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601766D")]
		[Address(RVA = "0xFBE2B0", Offset = "0xFBCEB0", VA = "0x180FBE2B0")]
		public UICommentedTextButton()
		{
		}

		// Token: 0x0401C435 RID: 115765
		[Token(Token = "0x401C435")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _bkgLight;

		// Token: 0x0401C436 RID: 115766
		[Token(Token = "0x401C436")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _bkgDark;

		// Token: 0x0401C437 RID: 115767
		[Token(Token = "0x401C437")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgLine;

		// Token: 0x0401C438 RID: 115768
		[Token(Token = "0x401C438")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _darkColor;

		// Token: 0x0401C439 RID: 115769
		[Token(Token = "0x401C439")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _lightColor;

		// Token: 0x0401C43A RID: 115770
		[Token(Token = "0x401C43A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _hotzone;

		// Token: 0x0401C43B RID: 115771
		[Token(Token = "0x401C43B")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public Action<UITermDescDataModel> OnClickEvent;

		// Token: 0x0401C43C RID: 115772
		[Token(Token = "0x401C43C")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public bool UseDarkColor;

		// Token: 0x0401C43D RID: 115773
		[Token(Token = "0x401C43D")]
		[FieldOffset(Offset = "0x68")]
		private UITermDescDataModel m_paramPair;

		// Token: 0x0401C43E RID: 115774
		[Token(Token = "0x401C43E")]
		[FieldOffset(Offset = "0x78")]
		private RectTransform m_rectTrans;

		// Token: 0x0401C43F RID: 115775
		[Token(Token = "0x401C43F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401C440 RID: 115776
		[Token(Token = "0x401C440")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetSize;

		// Token: 0x0401C441 RID: 115777
		[Token(Token = "0x401C441")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x0401C442 RID: 115778
		[Token(Token = "0x401C442")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
