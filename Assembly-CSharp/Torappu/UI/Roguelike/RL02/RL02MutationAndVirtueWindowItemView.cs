using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005797 RID: 22423
	[Token(Token = "0x2005797")]
	public class RL02MutationAndVirtueWindowItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06020CD2 RID: 134354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020CD2")]
		[Address(RVA = "0x1B24F00", Offset = "0x1B23B00", VA = "0x181B24F00")]
		private string _BuildMutationString(RoguelikeCharBuffModel mutation, List<string> mutationCharList)
		{
			return null;
		}

		// Token: 0x06020CD3 RID: 134355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CD3")]
		[Address(RVA = "0x1B249B0", Offset = "0x1B235B0", VA = "0x181B249B0")]
		public void Render(string topicId, RoguelikeCharBuffModel mutation, List<string> mutationCharList)
		{
		}

		// Token: 0x06020CD4 RID: 134356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CD4")]
		[Address(RVA = "0x1B24C90", Offset = "0x1B23890", VA = "0x181B24C90")]
		public void Render(string topicId, RoguelikeSquadBuffModel virtue)
		{
		}

		// Token: 0x06020CD5 RID: 134357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CD5")]
		[Address(RVA = "0x1B25180", Offset = "0x1B23D80", VA = "0x181B25180")]
		public RL02MutationAndVirtueWindowItemView()
		{
		}

		// Token: 0x0402C90D RID: 182541
		[Token(Token = "0x402C90D")]
		private const string MUTATION_DESC_COLOR = "#9866b2";

		// Token: 0x0402C90E RID: 182542
		[Token(Token = "0x402C90E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelContent;

		// Token: 0x0402C90F RID: 182543
		[Token(Token = "0x402C90F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imageIcon;

		// Token: 0x0402C910 RID: 182544
		[Token(Token = "0x402C910")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0402C911 RID: 182545
		[Token(Token = "0x402C911")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textEffect;

		// Token: 0x0402C912 RID: 182546
		[Token(Token = "0x402C912")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0402C913 RID: 182547
		[Token(Token = "0x402C913")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasImage _imageBkg;

		// Token: 0x0402C914 RID: 182548
		[Token(Token = "0x402C914")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasObject _imageBkgAtlas;

		// Token: 0x0402C915 RID: 182549
		[Token(Token = "0x402C915")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _imageBkgMutationName;

		// Token: 0x0402C916 RID: 182550
		[Token(Token = "0x402C916")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string _imageBkgVirtueName;

		// Token: 0x0402C917 RID: 182551
		[Token(Token = "0x402C917")]
		[FieldOffset(Offset = "0x60")]
		private string m_cachedIconId;

		// Token: 0x0402C918 RID: 182552
		[Token(Token = "0x402C918")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__BuildMutationString;

		// Token: 0x0402C919 RID: 182553
		[Token(Token = "0x402C919")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C91A RID: 182554
		[Token(Token = "0x402C91A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix1_Render;

		// Token: 0x0402C91B RID: 182555
		[Token(Token = "0x402C91B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
