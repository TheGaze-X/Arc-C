using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053E5 RID: 21477
	[Token(Token = "0x20053E5")]
	public class RoguelikeRewardItemExDropTagView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F9A0 RID: 129440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F9A0")]
		[Address(RVA = "0x193D7C0", Offset = "0x193C3C0", VA = "0x18193D7C0")]
		public List<Graphic> GetGraphics()
		{
			return null;
		}

		// Token: 0x0601F9A1 RID: 129441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F9A1")]
		[Address(RVA = "0x193D8A0", Offset = "0x193C4A0", VA = "0x18193D8A0")]
		public void Render(string topicId, RoguelikeRewardExDropTagSrcType tagSrcType)
		{
		}

		// Token: 0x0601F9A2 RID: 129442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F9A2")]
		[Address(RVA = "0x193DC10", Offset = "0x193C810", VA = "0x18193DC10")]
		private string _GetExDropTagName(string topicId, RoguelikeRewardExDropTagSrcType tagSrcType)
		{
			return null;
		}

		// Token: 0x0601F9A3 RID: 129443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F9A3")]
		[Address(RVA = "0x193DD90", Offset = "0x193C990", VA = "0x18193DD90")]
		public RoguelikeRewardItemExDropTagView()
		{
		}

		// Token: 0x0402A8FF RID: 174335
		[Token(Token = "0x402A8FF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Graphic _graphicBgLight;

		// Token: 0x0402A900 RID: 174336
		[Token(Token = "0x402A900")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgTagBg;

		// Token: 0x0402A901 RID: 174337
		[Token(Token = "0x402A901")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtTagName;

		// Token: 0x0402A902 RID: 174338
		[Token(Token = "0x402A902")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<RoguelikeRewardExDropTagConfig> _configs;

		// Token: 0x0402A903 RID: 174339
		[Token(Token = "0x402A903")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetGraphics;

		// Token: 0x0402A904 RID: 174340
		[Token(Token = "0x402A904")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A905 RID: 174341
		[Token(Token = "0x402A905")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetExDropTagName;

		// Token: 0x0402A906 RID: 174342
		[Token(Token = "0x402A906")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
