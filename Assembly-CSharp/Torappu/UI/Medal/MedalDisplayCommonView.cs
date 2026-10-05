using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x02004995 RID: 18837
	[Token(Token = "0x2004995")]
	public class MedalDisplayCommonView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C625 RID: 116261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C625")]
		[Address(RVA = "0x15EA040", Offset = "0x15E8C40", VA = "0x1815EA040")]
		public void Render(MedalDisplayViewModel viewModel)
		{
		}

		// Token: 0x0601C626 RID: 116262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C626")]
		[Address(RVA = "0x15EA270", Offset = "0x15E8E70", VA = "0x1815EA270")]
		public MedalDisplayCommonView()
		{
		}

		// Token: 0x040252CA RID: 152266
		[Token(Token = "0x40252CA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _medalGroupName;

		// Token: 0x040252CB RID: 152267
		[Token(Token = "0x40252CB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _medalDescription;

		// Token: 0x040252CC RID: 152268
		[Token(Token = "0x40252CC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _medalCount;

		// Token: 0x040252CD RID: 152269
		[Token(Token = "0x40252CD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _medalAvailCount;

		// Token: 0x040252CE RID: 152270
		[Token(Token = "0x40252CE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040252CF RID: 152271
		[Token(Token = "0x40252CF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
