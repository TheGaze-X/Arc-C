using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Activity.SeedMode
{
	// Token: 0x020046AF RID: 18095
	[Token(Token = "0x20046AF")]
	public class RoguelikeActivitySeedListTag : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004155 RID: 16725
		// (get) Token: 0x0601B72B RID: 112427 RVA: 0x000A5390 File Offset: 0x000A3590
		[Token(Token = "0x17004155")]
		public SeedItemType tagType
		{
			[Token(Token = "0x601B72B")]
			[Address(RVA = "0x14D5FF0", Offset = "0x14D4BF0", VA = "0x1814D5FF0")]
			get
			{
				return SeedItemType.NONE;
			}
		}

		// Token: 0x0601B72C RID: 112428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B72C")]
		[Address(RVA = "0x14D5E90", Offset = "0x14D4A90", VA = "0x1814D5E90")]
		public void Render(bool isSelected)
		{
		}

		// Token: 0x0601B72D RID: 112429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B72D")]
		[Address(RVA = "0x14D5E20", Offset = "0x14D4A20", VA = "0x1814D5E20")]
		public void OnClickSwitchTag()
		{
		}

		// Token: 0x0601B72E RID: 112430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B72E")]
		[Address(RVA = "0x14D5F70", Offset = "0x14D4B70", VA = "0x1814D5F70")]
		public RoguelikeActivitySeedListTag()
		{
		}

		// Token: 0x04023865 RID: 145509
		[Token(Token = "0x4023865")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _selectObj;

		// Token: 0x04023866 RID: 145510
		[Token(Token = "0x4023866")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SeedItemType _tagType;

		// Token: 0x04023867 RID: 145511
		[Token(Token = "0x4023867")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _nameText;

		// Token: 0x04023868 RID: 145512
		[Token(Token = "0x4023868")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _selectColor;

		// Token: 0x04023869 RID: 145513
		[Token(Token = "0x4023869")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _unselectColor;

		// Token: 0x0402386A RID: 145514
		[Token(Token = "0x402386A")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public Action<SeedItemType> onClickSwitchTag;

		// Token: 0x0402386B RID: 145515
		[Token(Token = "0x402386B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_tagType;

		// Token: 0x0402386C RID: 145516
		[Token(Token = "0x402386C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402386D RID: 145517
		[Token(Token = "0x402386D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClickSwitchTag;

		// Token: 0x0402386E RID: 145518
		[Token(Token = "0x402386E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
