using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F80 RID: 24448
	[Token(Token = "0x2005F80")]
	public class CharacterInfoActivityPotentialItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060235FC RID: 144892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235FC")]
		[Address(RVA = "0x1DFE1E0", Offset = "0x1DFCDE0", VA = "0x181DFE1E0")]
		public void Render(string activityItemId)
		{
		}

		// Token: 0x060235FD RID: 144893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235FD")]
		[Address(RVA = "0x1DFE300", Offset = "0x1DFCF00", VA = "0x181DFE300")]
		public CharacterInfoActivityPotentialItemView()
		{
		}

		// Token: 0x04030DBE RID: 200126
		[Token(Token = "0x4030DBE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _text;

		// Token: 0x04030DBF RID: 200127
		[Token(Token = "0x4030DBF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030DC0 RID: 200128
		[Token(Token = "0x4030DC0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
