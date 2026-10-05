using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x02004966 RID: 18790
	[Token(Token = "0x2004966")]
	public class MedalCommonItemNotGetView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C526 RID: 116006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C526")]
		[Address(RVA = "0x15C7AE0", Offset = "0x15C66E0", VA = "0x1815C7AE0")]
		public void Render(MedalCommonViewModel viewModel, string pageName)
		{
		}

		// Token: 0x0601C527 RID: 116007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C527")]
		[Address(RVA = "0x15C7D40", Offset = "0x15C6940", VA = "0x1815C7D40")]
		public MedalCommonItemNotGetView()
		{
		}

		// Token: 0x040250BB RID: 151739
		[Token(Token = "0x40250BB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _medalName;

		// Token: 0x040250BC RID: 151740
		[Token(Token = "0x40250BC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _icon;

		// Token: 0x040250BD RID: 151741
		[Token(Token = "0x40250BD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _rewardFlag;

		// Token: 0x040250BE RID: 151742
		[Token(Token = "0x40250BE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040250BF RID: 151743
		[Token(Token = "0x40250BF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
