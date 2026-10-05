using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004361 RID: 17249
	[Token(Token = "0x2004361")]
	public class SandboxV2RacerInventoryTopView : DataBinder<SandboxV2RacerInventoryProperty>, IHotfixable
	{
		// Token: 0x0601A791 RID: 108433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A791")]
		[Address(RVA = "0x1393E80", Offset = "0x1392A80", VA = "0x181393E80", Slot = "7")]
		public override void OnValueChanged(SandboxV2RacerInventoryProperty property)
		{
		}

		// Token: 0x0601A792 RID: 108434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A792")]
		[Address(RVA = "0x1393E00", Offset = "0x1392A00", VA = "0x181393E00")]
		public void EventOnBackBtnClicked()
		{
		}

		// Token: 0x0601A793 RID: 108435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A793")]
		[Address(RVA = "0x13942C0", Offset = "0x1392EC0", VA = "0x1813942C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A794 RID: 108436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A794")]
		[Address(RVA = "0x13943D0", Offset = "0x1392FD0", VA = "0x1813943D0")]
		public SandboxV2RacerInventoryTopView()
		{
		}

		// Token: 0x04021AEC RID: 137964
		[Token(Token = "0x4021AEC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _backRt;

		// Token: 0x04021AED RID: 137965
		[Token(Token = "0x4021AED")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04021AEE RID: 137966
		[Token(Token = "0x4021AEE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelTextBack;

		// Token: 0x04021AEF RID: 137967
		[Token(Token = "0x4021AEF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelTitle;

		// Token: 0x04021AF0 RID: 137968
		[Token(Token = "0x4021AF0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgTokenIcon;

		// Token: 0x04021AF1 RID: 137969
		[Token(Token = "0x4021AF1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textTokenCount;

		// Token: 0x04021AF2 RID: 137970
		[Token(Token = "0x4021AF2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textBagName;

		// Token: 0x04021AF3 RID: 137971
		[Token(Token = "0x4021AF3")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textRacerCount;

		// Token: 0x04021AF4 RID: 137972
		[Token(Token = "0x4021AF4")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textBagCapacity;

		// Token: 0x04021AF5 RID: 137973
		[Token(Token = "0x4021AF5")]
		[FieldOffset(Offset = "0x68")]
		private bool m_hasInited;

		// Token: 0x04021AF6 RID: 137974
		[Token(Token = "0x4021AF6")]
		[FieldOffset(Offset = "0x70")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04021AF7 RID: 137975
		[Token(Token = "0x4021AF7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04021AF8 RID: 137976
		[Token(Token = "0x4021AF8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnBackBtnClicked;

		// Token: 0x04021AF9 RID: 137977
		[Token(Token = "0x4021AF9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04021AFA RID: 137978
		[Token(Token = "0x4021AFA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
