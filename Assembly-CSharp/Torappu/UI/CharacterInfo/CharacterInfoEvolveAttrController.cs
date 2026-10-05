using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F4F RID: 24399
	[Token(Token = "0x2005F4F")]
	public class CharacterInfoEvolveAttrController : MonoBehaviour
	{
		// Token: 0x06023547 RID: 144711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023547")]
		[Address(RVA = "0x1DD7360", Offset = "0x1DD5F60", VA = "0x181DD7360")]
		public void RenderAttrs(EvolveAttributeViewModel viewModel)
		{
		}

		// Token: 0x06023548 RID: 144712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023548")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public CharacterInfoEvolveAttrController()
		{
		}

		// Token: 0x04030BFB RID: 199675
		[Token(Token = "0x4030BFB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _ladderRankOld;

		// Token: 0x04030BFC RID: 199676
		[Token(Token = "0x4030BFC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _ladderRankNew;

		// Token: 0x04030BFD RID: 199677
		[Token(Token = "0x4030BFD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _markOld;

		// Token: 0x04030BFE RID: 199678
		[Token(Token = "0x4030BFE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _markNew;
	}
}
