using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003916 RID: 14614
	[Token(Token = "0x2003916")]
	public class UIOKDialog : CommonDialog
	{
		// Token: 0x17003729 RID: 14121
		// (set) Token: 0x06017193 RID: 94611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003729")]
		public UIOKDialog.Options options
		{
			[Token(Token = "0x6017193")]
			[Address(RVA = "0xF796A0", Offset = "0xF782A0", VA = "0x180F796A0")]
			set
			{
			}
		}

		// Token: 0x06017194 RID: 94612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017194")]
		[Address(RVA = "0xF791A0", Offset = "0xF77DA0", VA = "0x180F791A0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06017195 RID: 94613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017195")]
		[Address(RVA = "0xF79000", Offset = "0xF77C00", VA = "0x180F79000")]
		private void OnEnable()
		{
		}

		// Token: 0x06017196 RID: 94614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017196")]
		[Address(RVA = "0xF792F0", Offset = "0xF77EF0", VA = "0x180F792F0")]
		private void _Render()
		{
		}

		// Token: 0x06017197 RID: 94615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017197")]
		[Address(RVA = "0xF78F20", Offset = "0xF77B20", VA = "0x180F78F20", Slot = "5")]
		protected override void OnDismiss()
		{
		}

		// Token: 0x06017198 RID: 94616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017198")]
		[Address(RVA = "0xF79070", Offset = "0xF77C70", VA = "0x180F79070", Slot = "7")]
		protected override void OnShow()
		{
		}

		// Token: 0x06017199 RID: 94617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017199")]
		[Address(RVA = "0xF78EB0", Offset = "0xF77AB0", VA = "0x180F78EB0", Slot = "6")]
		protected override void OnDialogDeduplicated()
		{
		}

		// Token: 0x1700372A RID: 14122
		// (get) Token: 0x0601719A RID: 94618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700372A")]
		public override string message
		{
			[Token(Token = "0x601719A")]
			[Address(RVA = "0xF79640", Offset = "0xF78240", VA = "0x180F79640", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601719B RID: 94619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601719B")]
		[Address(RVA = "0xF78DF0", Offset = "0xF779F0", VA = "0x180F78DF0")]
		public void EventOnBackgroundClick()
		{
		}

		// Token: 0x0601719C RID: 94620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601719C")]
		[Address(RVA = "0xF78E50", Offset = "0xF77A50", VA = "0x180F78E50")]
		public void EventOnConfrimBtnClick()
		{
		}

		// Token: 0x0601719D RID: 94621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601719D")]
		[Address(RVA = "0xF79530", Offset = "0xF78130", VA = "0x180F79530")]
		private IEnumerator _ResetTextScroll()
		{
			return null;
		}

		// Token: 0x0601719E RID: 94622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601719E")]
		[Address(RVA = "0xF795E0", Offset = "0xF781E0", VA = "0x180F795E0")]
		public UIOKDialog()
		{
		}

		// Token: 0x0601719F RID: 94623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601719F")]
		[Address(RVA = "0xF701C0", Offset = "0xF6EDC0", VA = "0x180F701C0")]
		private void <>xLuaBaseProxy_Start()
		{
		}

		// Token: 0x060171A0 RID: 94624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171A0")]
		[Address(RVA = "0xF70100", Offset = "0xF6ED00", VA = "0x180F70100")]
		private void <>xLuaBaseProxy_OnDismiss()
		{
		}

		// Token: 0x060171A1 RID: 94625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171A1")]
		[Address(RVA = "0xF70160", Offset = "0xF6ED60", VA = "0x180F70160")]
		private void <>xLuaBaseProxy_OnShow()
		{
		}

		// Token: 0x060171A2 RID: 94626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60171A2")]
		[Address(RVA = "0xF76E30", Offset = "0xF75A30", VA = "0x180F76E30")]
		private string <>xLuaBaseProxy_get_message()
		{
			return null;
		}

		// Token: 0x0401BE0E RID: 114190
		[Token(Token = "0x401BE0E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UITextIconContent _btnConfirm;

		// Token: 0x0401BE0F RID: 114191
		[Token(Token = "0x401BE0F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _descText;

		// Token: 0x0401BE10 RID: 114192
		[Token(Token = "0x401BE10")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _textContainer;

		// Token: 0x0401BE11 RID: 114193
		[Token(Token = "0x401BE11")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _customContainer;

		// Token: 0x0401BE12 RID: 114194
		[Token(Token = "0x401BE12")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ScrollRect _contentScroll;

		// Token: 0x0401BE13 RID: 114195
		[Token(Token = "0x401BE13")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ScrollRect _textScroll;

		// Token: 0x0401BE14 RID: 114196
		[Token(Token = "0x401BE14")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button _confirmButton;

		// Token: 0x0401BE15 RID: 114197
		[Token(Token = "0x401BE15")]
		[FieldOffset(Offset = "0x68")]
		private UIOKDialog.Options m_options;

		// Token: 0x0401BE16 RID: 114198
		[Token(Token = "0x401BE16")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_options;

		// Token: 0x0401BE17 RID: 114199
		[Token(Token = "0x401BE17")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0401BE18 RID: 114200
		[Token(Token = "0x401BE18")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0401BE19 RID: 114201
		[Token(Token = "0x401BE19")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0401BE1A RID: 114202
		[Token(Token = "0x401BE1A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDismiss;

		// Token: 0x0401BE1B RID: 114203
		[Token(Token = "0x401BE1B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnShow;

		// Token: 0x0401BE1C RID: 114204
		[Token(Token = "0x401BE1C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnDialogDeduplicated;

		// Token: 0x0401BE1D RID: 114205
		[Token(Token = "0x401BE1D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_message;

		// Token: 0x0401BE1E RID: 114206
		[Token(Token = "0x401BE1E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnBackgroundClick;

		// Token: 0x0401BE1F RID: 114207
		[Token(Token = "0x401BE1F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnConfrimBtnClick;

		// Token: 0x0401BE20 RID: 114208
		[Token(Token = "0x401BE20")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ResetTextScroll;

		// Token: 0x0401BE21 RID: 114209
		[Token(Token = "0x401BE21")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003917 RID: 14615
		[Token(Token = "0x2003917")]
		public struct Options
		{
			// Token: 0x0401BE22 RID: 114210
			[Token(Token = "0x401BE22")]
			[FieldOffset(Offset = "0x0")]
			public Action onConfirm;

			// Token: 0x0401BE23 RID: 114211
			[Token(Token = "0x401BE23")]
			[FieldOffset(Offset = "0x8")]
			public RichTextModel descText;

			// Token: 0x0401BE24 RID: 114212
			[Token(Token = "0x401BE24")]
			[FieldOffset(Offset = "0x30")]
			public string btnText;

			// Token: 0x0401BE25 RID: 114213
			[Token(Token = "0x401BE25")]
			[FieldOffset(Offset = "0x38")]
			public Action<RectTransform> addCustomContent;
		}
	}
}
