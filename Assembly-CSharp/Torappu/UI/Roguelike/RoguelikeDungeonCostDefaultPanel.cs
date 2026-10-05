using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005258 RID: 21080
	[Token(Token = "0x2005258")]
	public class RoguelikeDungeonCostDefaultPanel : RoguelikeDungeonCostBasePanel
	{
		// Token: 0x0601F170 RID: 127344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F170")]
		[Address(RVA = "0x18C9970", Offset = "0x18C8570", VA = "0x1818C9970")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601F171 RID: 127345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F171")]
		[Address(RVA = "0x18C9440", Offset = "0x18C8040", VA = "0x1818C9440", Slot = "4")]
		public override void HandleOnOpenCost(UIPage page, RoguelikeDungeonCostSingleton.Config config)
		{
		}

		// Token: 0x0601F172 RID: 127346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F172")]
		[Address(RVA = "0x18C9A50", Offset = "0x18C8650", VA = "0x1818C9A50")]
		private void _OpenPanel()
		{
		}

		// Token: 0x0601F173 RID: 127347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F173")]
		[Address(RVA = "0x18C9900", Offset = "0x18C8500", VA = "0x1818C9900")]
		private void _ClosePanel()
		{
		}

		// Token: 0x0601F174 RID: 127348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F174")]
		[Address(RVA = "0x18C93D0", Offset = "0x18C7FD0", VA = "0x1818C93D0")]
		public void EventOnConfirm()
		{
		}

		// Token: 0x0601F175 RID: 127349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F175")]
		[Address(RVA = "0x18C9890", Offset = "0x18C8490", VA = "0x1818C9890")]
		public void OnCancel()
		{
		}

		// Token: 0x0601F176 RID: 127350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F176")]
		[Address(RVA = "0x18C9AC0", Offset = "0x18C86C0", VA = "0x1818C9AC0")]
		public RoguelikeDungeonCostDefaultPanel()
		{
		}

		// Token: 0x04029B43 RID: 170819
		[Token(Token = "0x4029B43")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public Action onCancel;

		// Token: 0x04029B44 RID: 170820
		[Token(Token = "0x4029B44")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public Action onAccept;

		// Token: 0x04029B45 RID: 170821
		[Token(Token = "0x4029B45")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvas;

		// Token: 0x04029B46 RID: 170822
		[Token(Token = "0x4029B46")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _itemIcon;

		// Token: 0x04029B47 RID: 170823
		[Token(Token = "0x4029B47")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _itemDesc;

		// Token: 0x04029B48 RID: 170824
		[Token(Token = "0x4029B48")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _itemRemainContainer;

		// Token: 0x04029B49 RID: 170825
		[Token(Token = "0x4029B49")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _tips;

		// Token: 0x04029B4A RID: 170826
		[Token(Token = "0x4029B4A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIColorGraphic _uiColor;

		// Token: 0x04029B4B RID: 170827
		[Token(Token = "0x4029B4B")]
		[FieldOffset(Offset = "0x58")]
		private FadeSwitchTween m_showTween;

		// Token: 0x04029B4C RID: 170828
		[Token(Token = "0x4029B4C")]
		[FieldOffset(Offset = "0x60")]
		private bool m_inited;

		// Token: 0x04029B4D RID: 170829
		[Token(Token = "0x4029B4D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04029B4E RID: 170830
		[Token(Token = "0x4029B4E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HandleOnOpenCost;

		// Token: 0x04029B4F RID: 170831
		[Token(Token = "0x4029B4F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OpenPanel;

		// Token: 0x04029B50 RID: 170832
		[Token(Token = "0x4029B50")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ClosePanel;

		// Token: 0x04029B51 RID: 170833
		[Token(Token = "0x4029B51")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnConfirm;

		// Token: 0x04029B52 RID: 170834
		[Token(Token = "0x4029B52")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCancel;

		// Token: 0x04029B53 RID: 170835
		[Token(Token = "0x4029B53")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
