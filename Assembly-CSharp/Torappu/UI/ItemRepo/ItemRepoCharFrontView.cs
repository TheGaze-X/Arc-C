using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E94 RID: 24212
	[Token(Token = "0x2005E94")]
	public class ItemRepoCharFrontView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023144 RID: 143684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023144")]
		[Address(RVA = "0x1D8FFC0", Offset = "0x1D8EBC0", VA = "0x181D8FFC0")]
		public void Render(ItemBundle charInfo)
		{
		}

		// Token: 0x06023145 RID: 143685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023145")]
		[Address(RVA = "0x1D90290", Offset = "0x1D8EE90", VA = "0x181D90290")]
		public ItemRepoCharFrontView()
		{
		}

		// Token: 0x0403050D RID: 197901
		[Token(Token = "0x403050D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _professionImg;

		// Token: 0x0403050E RID: 197902
		[Token(Token = "0x403050E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _charName;

		// Token: 0x0403050F RID: 197903
		[Token(Token = "0x403050F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _charTopName;

		// Token: 0x04030510 RID: 197904
		[Token(Token = "0x4030510")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _charRarity;

		// Token: 0x04030511 RID: 197905
		[Token(Token = "0x4030511")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _potentialImg;

		// Token: 0x04030512 RID: 197906
		[Token(Token = "0x4030512")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _potentialBg;

		// Token: 0x04030513 RID: 197907
		[Token(Token = "0x4030513")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _awarded;

		// Token: 0x04030514 RID: 197908
		[Token(Token = "0x4030514")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030515 RID: 197909
		[Token(Token = "0x4030515")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
