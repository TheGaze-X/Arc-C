using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200437D RID: 17277
	[Token(Token = "0x200437D")]
	public class SandboxV2RacerTempInventoryTopView : DataBinder<SandboxV2RacerTempInventoryProperty>, IHotfixable
	{
		// Token: 0x0601A877 RID: 108663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A877")]
		[Address(RVA = "0x13AF150", Offset = "0x13ADD50", VA = "0x1813AF150", Slot = "7")]
		public override void OnValueChanged(SandboxV2RacerTempInventoryProperty property)
		{
		}

		// Token: 0x0601A878 RID: 108664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A878")]
		[Address(RVA = "0x13AF0D0", Offset = "0x13ADCD0", VA = "0x1813AF0D0")]
		public void EventOnBackBtnClicked()
		{
		}

		// Token: 0x0601A879 RID: 108665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A879")]
		[Address(RVA = "0x13AF4A0", Offset = "0x13AE0A0", VA = "0x1813AF4A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A87A RID: 108666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A87A")]
		[Address(RVA = "0x13AF5B0", Offset = "0x13AE1B0", VA = "0x1813AF5B0")]
		public SandboxV2RacerTempInventoryTopView()
		{
		}

		// Token: 0x04021C32 RID: 138290
		[Token(Token = "0x4021C32")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _backRt;

		// Token: 0x04021C33 RID: 138291
		[Token(Token = "0x4021C33")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04021C34 RID: 138292
		[Token(Token = "0x4021C34")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textTempBagName;

		// Token: 0x04021C35 RID: 138293
		[Token(Token = "0x4021C35")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textTempRacerCount;

		// Token: 0x04021C36 RID: 138294
		[Token(Token = "0x4021C36")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textTempBagCapacity;

		// Token: 0x04021C37 RID: 138295
		[Token(Token = "0x4021C37")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textBagName;

		// Token: 0x04021C38 RID: 138296
		[Token(Token = "0x4021C38")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textRacerCount;

		// Token: 0x04021C39 RID: 138297
		[Token(Token = "0x4021C39")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textBagCapacity;

		// Token: 0x04021C3A RID: 138298
		[Token(Token = "0x4021C3A")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x04021C3B RID: 138299
		[Token(Token = "0x4021C3B")]
		[FieldOffset(Offset = "0x68")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04021C3C RID: 138300
		[Token(Token = "0x4021C3C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04021C3D RID: 138301
		[Token(Token = "0x4021C3D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnBackBtnClicked;

		// Token: 0x04021C3E RID: 138302
		[Token(Token = "0x4021C3E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04021C3F RID: 138303
		[Token(Token = "0x4021C3F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
