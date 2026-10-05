using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055FB RID: 22011
	[Token(Token = "0x20055FB")]
	public class RL05NodeShashedRecruitTipsDialog : UICompDialog<RL05NodeShashedRecruitTipsDialog.Input>
	{
		// Token: 0x060204E7 RID: 132327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204E7")]
		[Address(RVA = "0x1A6C1B0", Offset = "0x1A6ADB0", VA = "0x181A6C1B0", Slot = "18")]
		protected override void OnRender(RL05NodeShashedRecruitTipsDialog.Input input)
		{
		}

		// Token: 0x060204E8 RID: 132328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204E8")]
		[Address(RVA = "0x1A6C570", Offset = "0x1A6B170", VA = "0x181A6C570")]
		private void _AdjustPos(RL05NodeShashedRecruitTipsDialog.Input input)
		{
		}

		// Token: 0x060204E9 RID: 132329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204E9")]
		[Address(RVA = "0x1A6CA90", Offset = "0x1A6B690", VA = "0x181A6CA90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060204EA RID: 132330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204EA")]
		[Address(RVA = "0x1A6C9D0", Offset = "0x1A6B5D0", VA = "0x181A6C9D0")]
		private void _EventOnBtnBack()
		{
		}

		// Token: 0x060204EB RID: 132331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204EB")]
		[Address(RVA = "0x1A6C0C0", Offset = "0x1A6ACC0", VA = "0x181A6C0C0")]
		public void EventOnClose()
		{
		}

		// Token: 0x060204EC RID: 132332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204EC")]
		[Address(RVA = "0x1A6CC30", Offset = "0x1A6B830", VA = "0x181A6CC30")]
		public RL05NodeShashedRecruitTipsDialog()
		{
		}

		// Token: 0x0402BBA4 RID: 179108
		[Token(Token = "0x402BBA4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Button _btnFull;

		// Token: 0x0402BBA5 RID: 179109
		[Token(Token = "0x402BBA5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textCnt;

		// Token: 0x0402BBA6 RID: 179110
		[Token(Token = "0x402BBA6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0402BBA7 RID: 179111
		[Token(Token = "0x402BBA7")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _rtContent;

		// Token: 0x0402BBA8 RID: 179112
		[Token(Token = "0x402BBA8")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float _paddingX;

		// Token: 0x0402BBA9 RID: 179113
		[Token(Token = "0x402BBA9")]
		[FieldOffset(Offset = "0x94")]
		private bool m_inited;

		// Token: 0x0402BBAA RID: 179114
		[Token(Token = "0x402BBAA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402BBAB RID: 179115
		[Token(Token = "0x402BBAB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__AdjustPos;

		// Token: 0x0402BBAC RID: 179116
		[Token(Token = "0x402BBAC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402BBAD RID: 179117
		[Token(Token = "0x402BBAD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EventOnBtnBack;

		// Token: 0x0402BBAE RID: 179118
		[Token(Token = "0x402BBAE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnClose;

		// Token: 0x0402BBAF RID: 179119
		[Token(Token = "0x402BBAF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020055FC RID: 22012
		[Token(Token = "0x20055FC")]
		public class Input
		{
			// Token: 0x060204ED RID: 132333 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60204ED")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0402BBB0 RID: 179120
			[Token(Token = "0x402BBB0")]
			[FieldOffset(Offset = "0x10")]
			public RectTransform target;
		}
	}
}
