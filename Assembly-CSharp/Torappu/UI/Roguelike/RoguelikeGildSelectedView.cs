using System;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200536F RID: 21359
	[Token(Token = "0x200536F")]
	public class RoguelikeGildSelectedView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F7C5 RID: 128965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7C5")]
		[Address(RVA = "0x1925680", Offset = "0x1924280", VA = "0x181925680")]
		public void Render(ILoadAsset assetLoader, RoguelikePlayerCopperItemViewModel model, string newGildId, string topicId)
		{
		}

		// Token: 0x0601F7C6 RID: 128966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7C6")]
		[Address(RVA = "0x1925A30", Offset = "0x1924630", VA = "0x181925A30")]
		public RoguelikeGildSelectedView()
		{
		}

		// Token: 0x0402A5CA RID: 173514
		[Token(Token = "0x402A5CA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelGildDetail;

		// Token: 0x0402A5CB RID: 173515
		[Token(Token = "0x402A5CB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelItemDetail;

		// Token: 0x0402A5CC RID: 173516
		[Token(Token = "0x402A5CC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _tipsEmpty;

		// Token: 0x0402A5CD RID: 173517
		[Token(Token = "0x402A5CD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _tipsGild;

		// Token: 0x0402A5CE RID: 173518
		[Token(Token = "0x402A5CE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RoguelikeGildItemSelectedView _itemFrom;

		// Token: 0x0402A5CF RID: 173519
		[Token(Token = "0x402A5CF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RoguelikeGildItemSelectedView _itemTo;

		// Token: 0x0402A5D0 RID: 173520
		[Token(Token = "0x402A5D0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _tagReplaceGild;

		// Token: 0x0402A5D1 RID: 173521
		[Token(Token = "0x402A5D1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textTipsGild;

		// Token: 0x0402A5D2 RID: 173522
		[Token(Token = "0x402A5D2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textGildDetail;

		// Token: 0x0402A5D3 RID: 173523
		[Token(Token = "0x402A5D3")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textCopperDetail;

		// Token: 0x0402A5D4 RID: 173524
		[Token(Token = "0x402A5D4")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textGildName;

		// Token: 0x0402A5D5 RID: 173525
		[Token(Token = "0x402A5D5")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textCopperName;

		// Token: 0x0402A5D6 RID: 173526
		[Token(Token = "0x402A5D6")]
		[FieldOffset(Offset = "0x78")]
		private string m_selectedItemId;

		// Token: 0x0402A5D7 RID: 173527
		[Token(Token = "0x402A5D7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A5D8 RID: 173528
		[Token(Token = "0x402A5D8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
