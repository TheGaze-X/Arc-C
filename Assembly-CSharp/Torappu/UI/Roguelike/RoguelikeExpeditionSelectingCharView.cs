using System;
using Il2CppDummyDll;
using Torappu.UI.Atlas;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052DB RID: 21211
	[Token(Token = "0x20052DB")]
	public abstract class RoguelikeExpeditionSelectingCharView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F48B RID: 128139
		[Token(Token = "0x601F48B")]
		protected abstract void RenderChar(RoguelikeExpeditionModel expeditionModel, bool isAfter);

		// Token: 0x0601F48C RID: 128140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F48C")]
		[Address(RVA = "0x18FE580", Offset = "0x18FD180", VA = "0x1818FE580")]
		public void SetPluginContext(RoguelikeExpeditionPluginContext context)
		{
		}

		// Token: 0x0601F48D RID: 128141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F48D")]
		[Address(RVA = "0x18FE120", Offset = "0x18FCD20", VA = "0x1818FE120")]
		public void RenderView(RoguelikeExpeditionModel expeditionModel, bool isAfter)
		{
		}

		// Token: 0x0601F48E RID: 128142 RVA: 0x000B1690 File Offset: 0x000AF890
		[Token(Token = "0x601F48E")]
		[Address(RVA = "0x18FE600", Offset = "0x18FD200", VA = "0x1818FE600")]
		private SpriteRenderData _GetPortraitSprite(string charId, string skinId, CharQuery charQuery)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x0601F48F RID: 128143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F48F")]
		[Address(RVA = "0x18FE800", Offset = "0x18FD400", VA = "0x1818FE800")]
		protected RoguelikeExpeditionSelectingCharView()
		{
		}

		// Token: 0x0402A043 RID: 172099
		[Token(Token = "0x402A043")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _rarityImg;

		// Token: 0x0402A044 RID: 172100
		[Token(Token = "0x402A044")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _professionImg;

		// Token: 0x0402A045 RID: 172101
		[Token(Token = "0x402A045")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _charName;

		// Token: 0x0402A046 RID: 172102
		[Token(Token = "0x402A046")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _charPortrait;

		// Token: 0x0402A047 RID: 172103
		[Token(Token = "0x402A047")]
		[FieldOffset(Offset = "0x38")]
		private string m_cachedCharInstId;

		// Token: 0x0402A048 RID: 172104
		[Token(Token = "0x402A048")]
		[FieldOffset(Offset = "0x40")]
		protected RoguelikeExpeditionPluginContext pluginContext;

		// Token: 0x0402A049 RID: 172105
		[Token(Token = "0x402A049")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetPluginContext;

		// Token: 0x0402A04A RID: 172106
		[Token(Token = "0x402A04A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0402A04B RID: 172107
		[Token(Token = "0x402A04B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetPortraitSprite;

		// Token: 0x0402A04C RID: 172108
		[Token(Token = "0x402A04C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
