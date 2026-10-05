using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003559 RID: 13657
	[Token(Token = "0x2003559")]
	[RequireComponent(typeof(TwoStateToggle))]
	public class UICharacterTrackPointFilterItem : DataBinder<BoolProperty>, IHotfixable
	{
		// Token: 0x06015C40 RID: 89152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C40")]
		[Address(RVA = "0xE5A3E0", Offset = "0xE58FE0", VA = "0x180E5A3E0", Slot = "7")]
		public override void OnValueChanged(BoolProperty property)
		{
		}

		// Token: 0x06015C41 RID: 89153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C41")]
		[Address(RVA = "0xE5A630", Offset = "0xE59230", VA = "0x180E5A630")]
		public void SetCountText(int count)
		{
		}

		// Token: 0x06015C42 RID: 89154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C42")]
		[Address(RVA = "0xE5A700", Offset = "0xE59300", VA = "0x180E5A700")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06015C43 RID: 89155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C43")]
		[Address(RVA = "0xE5A820", Offset = "0xE59420", VA = "0x180E5A820")]
		private void _OnToggle(TwoStateToggle.State state)
		{
		}

		// Token: 0x06015C44 RID: 89156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C44")]
		[Address(RVA = "0xE5A910", Offset = "0xE59510", VA = "0x180E5A910")]
		public UICharacterTrackPointFilterItem()
		{
		}

		// Token: 0x0401A2CA RID: 107210
		[Token(Token = "0x401A2CA")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color COLOR_SELECTED;

		// Token: 0x0401A2CB RID: 107211
		[Token(Token = "0x401A2CB")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Color COLOR_UNSELECTED;

		// Token: 0x0401A2CC RID: 107212
		[Token(Token = "0x401A2CC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textCount;

		// Token: 0x0401A2CD RID: 107213
		[Token(Token = "0x401A2CD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UnityEvent _eventTrackPointFilterClick;

		// Token: 0x0401A2CE RID: 107214
		[Token(Token = "0x401A2CE")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x0401A2CF RID: 107215
		[Token(Token = "0x401A2CF")]
		[FieldOffset(Offset = "0x38")]
		private TwoStateToggle m_twoStateToggle;

		// Token: 0x0401A2D0 RID: 107216
		[Token(Token = "0x401A2D0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401A2D1 RID: 107217
		[Token(Token = "0x401A2D1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetCountText;

		// Token: 0x0401A2D2 RID: 107218
		[Token(Token = "0x401A2D2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401A2D3 RID: 107219
		[Token(Token = "0x401A2D3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnToggle;

		// Token: 0x0401A2D4 RID: 107220
		[Token(Token = "0x401A2D4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
