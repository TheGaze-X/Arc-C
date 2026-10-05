using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053D9 RID: 21465
	[Token(Token = "0x20053D9")]
	public class RoguelikeRewardEntryPopItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F965 RID: 129381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F965")]
		[Address(RVA = "0x1939DB0", Offset = "0x19389B0", VA = "0x181939DB0")]
		public void Render(RoguelikeRewardsPopInfo popInfo)
		{
		}

		// Token: 0x0601F966 RID: 129382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F966")]
		[Address(RVA = "0x193A530", Offset = "0x1939130", VA = "0x18193A530")]
		private void _RenderStyle(RoguelikeRewardEntryPopItemStyle style)
		{
		}

		// Token: 0x0601F967 RID: 129383 RVA: 0x000B25C0 File Offset: 0x000B07C0
		[Token(Token = "0x601F967")]
		[Address(RVA = "0x193A3B0", Offset = "0x1938FB0", VA = "0x18193A3B0")]
		private RoguelikeRewardEntryPopItemStyle _GetPopStyle(ROGUELIKE_REWARDS_LEVEL_UP_POP_TYPE type)
		{
			return default(RoguelikeRewardEntryPopItemStyle);
		}

		// Token: 0x0601F968 RID: 129384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F968")]
		[Address(RVA = "0x193A250", Offset = "0x1938E50", VA = "0x18193A250")]
		private string _GetPopCountTxt(ROGUELIKE_REWARDS_LEVEL_UP_POP_TYPE type, int count)
		{
			return null;
		}

		// Token: 0x0601F969 RID: 129385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F969")]
		[Address(RVA = "0x193A700", Offset = "0x1939300", VA = "0x18193A700")]
		public RoguelikeRewardEntryPopItemView()
		{
		}

		// Token: 0x0402A87B RID: 174203
		[Token(Token = "0x402A87B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _txtPop;

		// Token: 0x0402A87C RID: 174204
		[Token(Token = "0x402A87C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgBg;

		// Token: 0x0402A87D RID: 174205
		[Token(Token = "0x402A87D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgPopIcon;

		// Token: 0x0402A87E RID: 174206
		[Token(Token = "0x402A87E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Style Config")]
		private List<RoguelikeRewardEntryPopItemStyle> _styleList;

		// Token: 0x0402A87F RID: 174207
		[Token(Token = "0x402A87F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A880 RID: 174208
		[Token(Token = "0x402A880")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderStyle;

		// Token: 0x0402A881 RID: 174209
		[Token(Token = "0x402A881")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetPopStyle;

		// Token: 0x0402A882 RID: 174210
		[Token(Token = "0x402A882")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetPopCountTxt;

		// Token: 0x0402A883 RID: 174211
		[Token(Token = "0x402A883")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
