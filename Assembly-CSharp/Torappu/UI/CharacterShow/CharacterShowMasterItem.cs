using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterShow
{
	// Token: 0x02005DF0 RID: 24048
	[Token(Token = "0x2005DF0")]
	public class CharacterShowMasterItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06022D92 RID: 142738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D92")]
		[Address(RVA = "0x1D6D670", Offset = "0x1D6C270", VA = "0x181D6D670")]
		public void Render(CharacterShowMasterModel viewModel, bool isUnlockHintVisible)
		{
		}

		// Token: 0x06022D93 RID: 142739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022D93")]
		[Address(RVA = "0x1D6D950", Offset = "0x1D6C550", VA = "0x181D6D950")]
		private string _GetUnlockIconName(EvolvePhase evolvePhase)
		{
			return null;
		}

		// Token: 0x06022D94 RID: 142740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D94")]
		[Address(RVA = "0x1D6DA00", Offset = "0x1D6C600", VA = "0x181D6DA00")]
		public CharacterShowMasterItem()
		{
		}

		// Token: 0x0402FFA1 RID: 196513
		[Token(Token = "0x402FFA1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _name;

		// Token: 0x0402FFA2 RID: 196514
		[Token(Token = "0x402FFA2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0402FFA3 RID: 196515
		[Token(Token = "0x402FFA3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _unlockHintGo;

		// Token: 0x0402FFA4 RID: 196516
		[Token(Token = "0x402FFA4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textUnlockHint;

		// Token: 0x0402FFA5 RID: 196517
		[Token(Token = "0x402FFA5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasImage _imgUnlockIcon;

		// Token: 0x0402FFA6 RID: 196518
		[Token(Token = "0x402FFA6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasObject _atlasUnlockIcon;

		// Token: 0x0402FFA7 RID: 196519
		[Token(Token = "0x402FFA7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _iconEvolveOneUnlockName;

		// Token: 0x0402FFA8 RID: 196520
		[Token(Token = "0x402FFA8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _iconEvolveTwoUnlockName;

		// Token: 0x0402FFA9 RID: 196521
		[Token(Token = "0x402FFA9")]
		[FieldOffset(Offset = "0x58")]
		private string m_cachedIconName;

		// Token: 0x0402FFAA RID: 196522
		[Token(Token = "0x402FFAA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402FFAB RID: 196523
		[Token(Token = "0x402FFAB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetUnlockIconName;

		// Token: 0x0402FFAC RID: 196524
		[Token(Token = "0x402FFAC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
