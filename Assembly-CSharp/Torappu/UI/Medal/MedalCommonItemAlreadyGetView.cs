using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x02004965 RID: 18789
	[Token(Token = "0x2004965")]
	public class MedalCommonItemAlreadyGetView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C524 RID: 116004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C524")]
		[Address(RVA = "0x15C7830", Offset = "0x15C6430", VA = "0x1815C7830")]
		public void Render(MedalCommonViewModel viewModel, string pageName)
		{
		}

		// Token: 0x0601C525 RID: 116005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C525")]
		[Address(RVA = "0x15C7A80", Offset = "0x15C6680", VA = "0x1815C7A80")]
		public MedalCommonItemAlreadyGetView()
		{
		}

		// Token: 0x040250B5 RID: 151733
		[Token(Token = "0x40250B5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _iconImage;

		// Token: 0x040250B6 RID: 151734
		[Token(Token = "0x40250B6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _medalName;

		// Token: 0x040250B7 RID: 151735
		[Token(Token = "0x40250B7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _selectPart;

		// Token: 0x040250B8 RID: 151736
		[Token(Token = "0x40250B8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _advancedIcon;

		// Token: 0x040250B9 RID: 151737
		[Token(Token = "0x40250B9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040250BA RID: 151738
		[Token(Token = "0x40250BA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
