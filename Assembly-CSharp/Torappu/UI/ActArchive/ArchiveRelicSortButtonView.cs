using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C14 RID: 27668
	[Token(Token = "0x2006C14")]
	public class ArchiveRelicSortButtonView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005D3E RID: 23870
		// (get) Token: 0x06027815 RID: 161813 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027816 RID: 161814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D3E")]
		public ArchiveRelicController controller
		{
			[Token(Token = "0x6027815")]
			[Address(RVA = "0x22B3B50", Offset = "0x22B2750", VA = "0x1822B3B50")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6027816")]
			[Address(RVA = "0x22B3BB0", Offset = "0x22B27B0", VA = "0x1822B3BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06027817 RID: 161815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027817")]
		[Address(RVA = "0x22B3610", Offset = "0x22B2210", VA = "0x1822B3610")]
		public void OnBtnClicked()
		{
		}

		// Token: 0x06027818 RID: 161816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027818")]
		[Address(RVA = "0x22B3840", Offset = "0x22B2440", VA = "0x1822B3840")]
		public void Render(ArchiveRelicController controller, FilterRule selectedFilterRule, int newNum)
		{
		}

		// Token: 0x06027819 RID: 161817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027819")]
		[Address(RVA = "0x22B3AD0", Offset = "0x22B26D0", VA = "0x1822B3AD0")]
		public ArchiveRelicSortButtonView()
		{
		}

		// Token: 0x04038021 RID: 229409
		[Token(Token = "0x4038021")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelSelected;

		// Token: 0x04038022 RID: 229410
		[Token(Token = "0x4038022")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelUnselected;

		// Token: 0x04038023 RID: 229411
		[Token(Token = "0x4038023")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textRule;

		// Token: 0x04038024 RID: 229412
		[Token(Token = "0x4038024")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textNew;

		// Token: 0x04038025 RID: 229413
		[Token(Token = "0x4038025")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _btnView;

		// Token: 0x04038026 RID: 229414
		[Token(Token = "0x4038026")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _btn;

		// Token: 0x04038027 RID: 229415
		[Token(Token = "0x4038027")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private FilterRule _filterRule;

		// Token: 0x04038028 RID: 229416
		[Token(Token = "0x4038028")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Color _selectedTextColor;

		// Token: 0x04038029 RID: 229417
		[Token(Token = "0x4038029")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private Color _unSelectedTextColor;

		// Token: 0x0403802B RID: 229419
		[Token(Token = "0x403802B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x0403802C RID: 229420
		[Token(Token = "0x403802C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x0403802D RID: 229421
		[Token(Token = "0x403802D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBtnClicked;

		// Token: 0x0403802E RID: 229422
		[Token(Token = "0x403802E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403802F RID: 229423
		[Token(Token = "0x403802F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
