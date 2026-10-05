using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C1E RID: 19486
	[Token(Token = "0x2004C1E")]
	public class HomeSecretarySkinFilterItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170044C8 RID: 17608
		// (get) Token: 0x0601D43E RID: 119870 RVA: 0x000AB0C0 File Offset: 0x000A92C0
		[Token(Token = "0x170044C8")]
		public HomeSecretarySkinChangeViewModel.FilterType type
		{
			[Token(Token = "0x601D43E")]
			[Address(RVA = "0x16D7C70", Offset = "0x16D6870", VA = "0x1816D7C70")]
			get
			{
				return HomeSecretarySkinChangeViewModel.FilterType.NONE;
			}
		}

		// Token: 0x170044C9 RID: 17609
		// (set) Token: 0x0601D43F RID: 119871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170044C9")]
		public bool selected
		{
			[Token(Token = "0x601D43F")]
			[Address(RVA = "0x16D7CD0", Offset = "0x16D68D0", VA = "0x1816D7CD0")]
			set
			{
			}
		}

		// Token: 0x0601D440 RID: 119872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D440")]
		[Address(RVA = "0x16D7AE0", Offset = "0x16D66E0", VA = "0x1816D7AE0")]
		public void OnFilterClicked(bool selected)
		{
		}

		// Token: 0x0601D441 RID: 119873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D441")]
		[Address(RVA = "0x16D7C10", Offset = "0x16D6810", VA = "0x1816D7C10")]
		public HomeSecretarySkinFilterItemView()
		{
		}

		// Token: 0x040267AF RID: 157615
		[Token(Token = "0x40267AF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HomeSecretarySkinChangeViewModel.FilterType _type;

		// Token: 0x040267B0 RID: 157616
		[Token(Token = "0x40267B0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _toggle;

		// Token: 0x040267B1 RID: 157617
		[Token(Token = "0x40267B1")]
		[FieldOffset(Offset = "0x28")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040267B2 RID: 157618
		[Token(Token = "0x40267B2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x040267B3 RID: 157619
		[Token(Token = "0x40267B3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_selected;

		// Token: 0x040267B4 RID: 157620
		[Token(Token = "0x40267B4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnFilterClicked;

		// Token: 0x040267B5 RID: 157621
		[Token(Token = "0x40267B5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
