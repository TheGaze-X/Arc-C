using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterShow
{
	// Token: 0x02005DF5 RID: 24053
	[Token(Token = "0x2005DF5")]
	public class CharacterShowTalentItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06022DA4 RID: 142756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DA4")]
		[Address(RVA = "0x1D6F800", Offset = "0x1D6E400", VA = "0x181D6F800")]
		public void Render(CharacterShowTalentModel talentModel, bool isUnlockHintVisible)
		{
		}

		// Token: 0x06022DA5 RID: 142757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022DA5")]
		[Address(RVA = "0x1D6FF10", Offset = "0x1D6EB10", VA = "0x181D6FF10")]
		private string _GetUnlockIconName(CharacterShowTalentModel talentModel)
		{
			return null;
		}

		// Token: 0x06022DA6 RID: 142758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022DA6")]
		[Address(RVA = "0x1D6FC80", Offset = "0x1D6E880", VA = "0x181D6FC80")]
		private string _GetUnlockHint(CharacterShowTalentModel talentModel)
		{
			return null;
		}

		// Token: 0x06022DA7 RID: 142759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022DA7")]
		[Address(RVA = "0x1D70010", Offset = "0x1D6EC10", VA = "0x181D70010")]
		public CharacterShowTalentItem()
		{
		}

		// Token: 0x0402FFE4 RID: 196580
		[Token(Token = "0x402FFE4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0402FFE5 RID: 196581
		[Token(Token = "0x402FFE5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0402FFE6 RID: 196582
		[Token(Token = "0x402FFE6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _unlockHintGo;

		// Token: 0x0402FFE7 RID: 196583
		[Token(Token = "0x402FFE7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textUnlockHint;

		// Token: 0x0402FFE8 RID: 196584
		[Token(Token = "0x402FFE8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LayoutElement _layoutElement;

		// Token: 0x0402FFE9 RID: 196585
		[Token(Token = "0x402FFE9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _baseHeight;

		// Token: 0x0402FFEA RID: 196586
		[Token(Token = "0x402FFEA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasImage _imgUnlockIcon;

		// Token: 0x0402FFEB RID: 196587
		[Token(Token = "0x402FFEB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAtlasObject _atlasUnlockIcon;

		// Token: 0x0402FFEC RID: 196588
		[Token(Token = "0x402FFEC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string _iconLevelUpUnlockName;

		// Token: 0x0402FFED RID: 196589
		[Token(Token = "0x402FFED")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string _iconEvolveOneUnlockName;

		// Token: 0x0402FFEE RID: 196590
		[Token(Token = "0x402FFEE")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string _iconEvolveTwoUnlockName;

		// Token: 0x0402FFEF RID: 196591
		[Token(Token = "0x402FFEF")]
		[FieldOffset(Offset = "0x70")]
		private TextGenerator m_textGenerator;

		// Token: 0x0402FFF0 RID: 196592
		[Token(Token = "0x402FFF0")]
		[FieldOffset(Offset = "0x78")]
		private string m_cachedDesc;

		// Token: 0x0402FFF1 RID: 196593
		[Token(Token = "0x402FFF1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402FFF2 RID: 196594
		[Token(Token = "0x402FFF2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetUnlockIconName;

		// Token: 0x0402FFF3 RID: 196595
		[Token(Token = "0x402FFF3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetUnlockHint;

		// Token: 0x0402FFF4 RID: 196596
		[Token(Token = "0x402FFF4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
