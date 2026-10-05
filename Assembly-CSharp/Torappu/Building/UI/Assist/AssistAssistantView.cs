using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Assist
{
	// Token: 0x02001E04 RID: 7684
	[Token(Token = "0x2001E04")]
	public class AssistAssistantView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170016EF RID: 5871
		// (get) Token: 0x0600BDC3 RID: 48579 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600BDC4 RID: 48580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170016EF")]
		public Action<int> onAssistViewClicked
		{
			[Token(Token = "0x600BDC3")]
			[Address(RVA = "0x339BD40", Offset = "0x339A940", VA = "0x18339BD40")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x600BDC4")]
			[Address(RVA = "0x339BDA0", Offset = "0x339A9A0", VA = "0x18339BDA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600BDC5 RID: 48581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDC5")]
		[Address(RVA = "0x339B550", Offset = "0x339A150", VA = "0x18339B550")]
		public void Render(int index, int charInstId)
		{
		}

		// Token: 0x0600BDC6 RID: 48582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDC6")]
		[Address(RVA = "0x339B440", Offset = "0x339A040", VA = "0x18339B440")]
		public void OnClick()
		{
		}

		// Token: 0x0600BDC7 RID: 48583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDC7")]
		[Address(RVA = "0x339BCE0", Offset = "0x339A8E0", VA = "0x18339BCE0")]
		public AssistAssistantView()
		{
		}

		// Token: 0x0400BE58 RID: 48728
		[Token(Token = "0x400BE58")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _charObj;

		// Token: 0x0400BE59 RID: 48729
		[Token(Token = "0x400BE59")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _noCharObj;

		// Token: 0x0400BE5A RID: 48730
		[Token(Token = "0x400BE5A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _lockedObj;

		// Token: 0x0400BE5B RID: 48731
		[Token(Token = "0x400BE5B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _charPortrait;

		// Token: 0x0400BE5C RID: 48732
		[Token(Token = "0x400BE5C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _lockText;

		// Token: 0x0400BE5D RID: 48733
		[Token(Token = "0x400BE5D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _storeyText;

		// Token: 0x0400BE5E RID: 48734
		[Token(Token = "0x400BE5E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textFavor;

		// Token: 0x0400BE5F RID: 48735
		[Token(Token = "0x400BE5F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelFavor;

		// Token: 0x0400BE60 RID: 48736
		[Token(Token = "0x400BE60")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _trackPoint;

		// Token: 0x0400BE62 RID: 48738
		[Token(Token = "0x400BE62")]
		[FieldOffset(Offset = "0x68")]
		private int m_currentIndex;

		// Token: 0x0400BE63 RID: 48739
		[Token(Token = "0x400BE63")]
		[FieldOffset(Offset = "0x6C")]
		private int m_charInstId;

		// Token: 0x0400BE64 RID: 48740
		[Token(Token = "0x400BE64")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onAssistViewClicked;

		// Token: 0x0400BE65 RID: 48741
		[Token(Token = "0x400BE65")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onAssistViewClicked;

		// Token: 0x0400BE66 RID: 48742
		[Token(Token = "0x400BE66")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400BE67 RID: 48743
		[Token(Token = "0x400BE67")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0400BE68 RID: 48744
		[Token(Token = "0x400BE68")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
