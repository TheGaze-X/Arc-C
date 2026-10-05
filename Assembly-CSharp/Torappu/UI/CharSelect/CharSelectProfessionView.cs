using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.CharSelect
{
	// Token: 0x02005E21 RID: 24097
	[Token(Token = "0x2005E21")]
	public class CharSelectProfessionView : MonoBehaviour
	{
		// Token: 0x06022EA8 RID: 143016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EA8")]
		[Address(RVA = "0x1D66CC0", Offset = "0x1D658C0", VA = "0x181D66CC0")]
		public void RenderView(string subProfessionInfo, string featureDescBasic, string featureDescAdditive)
		{
		}

		// Token: 0x06022EA9 RID: 143017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EA9")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public CharSelectProfessionView()
		{
		}

		// Token: 0x04030184 RID: 196996
		[Token(Token = "0x4030184")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _subProfName;

		// Token: 0x04030185 RID: 196997
		[Token(Token = "0x4030185")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UICommentedText _subProfDetailBasic;

		// Token: 0x04030186 RID: 196998
		[Token(Token = "0x4030186")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UICommentedText _subProfDetailAdditive;

		// Token: 0x04030187 RID: 196999
		[Token(Token = "0x4030187")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _subProfImg;
	}
}
