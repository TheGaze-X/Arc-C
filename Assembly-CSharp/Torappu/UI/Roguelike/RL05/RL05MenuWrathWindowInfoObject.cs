using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055F0 RID: 22000
	[Token(Token = "0x20055F0")]
	public class RL05MenuWrathWindowInfoObject : MonoBehaviour
	{
		// Token: 0x060204B4 RID: 132276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204B4")]
		[Address(RVA = "0x1A6B740", Offset = "0x1A6A340", VA = "0x181A6B740")]
		public void Render(RL05WrathTagItemViewModel wrathItem, Sprite wrathSprite)
		{
		}

		// Token: 0x060204B5 RID: 132277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204B5")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public RL05MenuWrathWindowInfoObject()
		{
		}

		// Token: 0x0402BB44 RID: 179012
		[Token(Token = "0x402BB44")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasObject _atlasObject;

		// Token: 0x0402BB45 RID: 179013
		[Token(Token = "0x402BB45")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _imgBackground;

		// Token: 0x0402BB46 RID: 179014
		[Token(Token = "0x402BB46")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x0402BB47 RID: 179015
		[Token(Token = "0x402BB47")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtName;

		// Token: 0x0402BB48 RID: 179016
		[Token(Token = "0x402BB48")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtLevelName;

		// Token: 0x0402BB49 RID: 179017
		[Token(Token = "0x402BB49")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _txtLevelNum;

		// Token: 0x0402BB4A RID: 179018
		[Token(Token = "0x402BB4A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _txtFunctionDesc;

		// Token: 0x0402BB4B RID: 179019
		[Token(Token = "0x402BB4B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _txtDesc;

		// Token: 0x0402BB4C RID: 179020
		[Token(Token = "0x402BB4C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _bkgVariation;

		// Token: 0x0402BB4D RID: 179021
		[Token(Token = "0x402BB4D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _bkgNormal;

		// Token: 0x0402BB4E RID: 179022
		[Token(Token = "0x402BB4E")]
		[FieldOffset(Offset = "0x68")]
		private RL05WrathTagItemViewModel m_wrathData;
	}
}
