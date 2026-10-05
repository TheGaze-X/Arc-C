using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005597 RID: 21911
	[Token(Token = "0x2005597")]
	public class RL05CopperExchangeDetailDialog : UICompDialog<RL05CopperExchangeDetailDialog.Options>, IHotfixable
	{
		// Token: 0x060202EB RID: 131819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60202EB")]
		[Address(RVA = "0x1A499D0", Offset = "0x1A485D0", VA = "0x181A499D0", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x060202EC RID: 131820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202EC")]
		[Address(RVA = "0x1A49A30", Offset = "0x1A48630", VA = "0x181A49A30", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x060202ED RID: 131821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202ED")]
		[Address(RVA = "0x1A49B70", Offset = "0x1A48770", VA = "0x181A49B70", Slot = "18")]
		protected override void OnRender(RL05CopperExchangeDetailDialog.Options input)
		{
		}

		// Token: 0x060202EE RID: 131822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202EE")]
		[Address(RVA = "0x1A49910", Offset = "0x1A48510", VA = "0x181A49910")]
		public void EventOnBtnCloseClicked()
		{
		}

		// Token: 0x060202EF RID: 131823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202EF")]
		[Address(RVA = "0x1A49CF0", Offset = "0x1A488F0", VA = "0x181A49CF0")]
		public RL05CopperExchangeDetailDialog()
		{
		}

		// Token: 0x060202F0 RID: 131824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60202F0")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x060202F1 RID: 131825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202F1")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0402B7FE RID: 178174
		[Token(Token = "0x402B7FE")]
		private const int SINGLE_MAX_COUNT = 2;

		// Token: 0x0402B7FF RID: 178175
		[Token(Token = "0x402B7FF")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIRenderTextureImage _blurBkg;

		// Token: 0x0402B800 RID: 178176
		[Token(Token = "0x402B800")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textCount;

		// Token: 0x0402B801 RID: 178177
		[Token(Token = "0x402B801")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _panelMulti;

		// Token: 0x0402B802 RID: 178178
		[Token(Token = "0x402B802")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private SimpleLayoutContent _multiContent;

		// Token: 0x0402B803 RID: 178179
		[Token(Token = "0x402B803")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _panelSingle;

		// Token: 0x0402B804 RID: 178180
		[Token(Token = "0x402B804")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private SimpleLayoutContent _singleContent;

		// Token: 0x0402B805 RID: 178181
		[Token(Token = "0x402B805")]
		[FieldOffset(Offset = "0xA0")]
		private RL05CopperExchangeDetailDialog.Adapter m_multiAdapter;

		// Token: 0x0402B806 RID: 178182
		[Token(Token = "0x402B806")]
		[FieldOffset(Offset = "0xA8")]
		private RL05CopperExchangeDetailDialog.Adapter m_singleAdapter;

		// Token: 0x0402B807 RID: 178183
		[Token(Token = "0x402B807")]
		[FieldOffset(Offset = "0xB0")]
		private RL05CopperExchangeDetailDialog.Options m_cachedOptions;

		// Token: 0x0402B808 RID: 178184
		[Token(Token = "0x402B808")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0402B809 RID: 178185
		[Token(Token = "0x402B809")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0402B80A RID: 178186
		[Token(Token = "0x402B80A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402B80B RID: 178187
		[Token(Token = "0x402B80B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnBtnCloseClicked;

		// Token: 0x0402B80C RID: 178188
		[Token(Token = "0x402B80C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005598 RID: 21912
		[Token(Token = "0x2005598")]
		public class Options
		{
			// Token: 0x060202F2 RID: 131826 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60202F2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x0402B80D RID: 178189
			[Token(Token = "0x402B80D")]
			[FieldOffset(Offset = "0x10")]
			public List<RoguelikeCopperExchangeInfoViewModel> exchangeCopperList;
		}

		// Token: 0x02005599 RID: 21913
		[Token(Token = "0x2005599")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x060202F3 RID: 131827 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60202F3")]
			[Address(RVA = "0x1A47970", Offset = "0x1A46570", VA = "0x181A47970")]
			public Adapter(RL05CopperExchangeDetailDialog closure)
			{
			}

			// Token: 0x17004B7E RID: 19326
			// (get) Token: 0x060202F4 RID: 131828 RVA: 0x000B4E10 File Offset: 0x000B3010
			[Token(Token = "0x17004B7E")]
			public override int count
			{
				[Token(Token = "0x60202F4")]
				[Address(RVA = "0x1A479F0", Offset = "0x1A465F0", VA = "0x181A479F0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060202F5 RID: 131829 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60202F5")]
			[Address(RVA = "0x1A47400", Offset = "0x1A46000", VA = "0x181A47400", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402B80E RID: 178190
			[Token(Token = "0x402B80E")]
			[FieldOffset(Offset = "0x20")]
			private RL05CopperExchangeDetailDialog m_closure;

			// Token: 0x0402B80F RID: 178191
			[Token(Token = "0x402B80F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402B810 RID: 178192
			[Token(Token = "0x402B810")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402B811 RID: 178193
			[Token(Token = "0x402B811")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
