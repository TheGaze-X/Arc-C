using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL02
{
	// Token: 0x02004621 RID: 17953
	[Token(Token = "0x2004621")]
	public class RL02OuterBuffSummaryRawTextNodeItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004108 RID: 16648
		// (get) Token: 0x0601B491 RID: 111761 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B492 RID: 111762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004108")]
		public UIPage page
		{
			[Token(Token = "0x601B491")]
			[Address(RVA = "0x14A1B80", Offset = "0x14A0780", VA = "0x1814A1B80")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601B492")]
			[Address(RVA = "0x14A1BE0", Offset = "0x14A07E0", VA = "0x1814A1BE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601B493 RID: 111763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B493")]
		[Address(RVA = "0x14A1500", Offset = "0x14A0100", VA = "0x1814A1500")]
		public void Render(string topicId, int position, RL02OuterBuffListRawTextGroupItemModel model)
		{
		}

		// Token: 0x0601B494 RID: 111764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B494")]
		[Address(RVA = "0x14A19E0", Offset = "0x14A05E0", VA = "0x1814A19E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B495 RID: 111765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B495")]
		[Address(RVA = "0x14A1B00", Offset = "0x14A0700", VA = "0x1814A1B00")]
		public RL02OuterBuffSummaryRawTextNodeItemView()
		{
		}

		// Token: 0x04023382 RID: 144258
		[Token(Token = "0x4023382")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _textContent;

		// Token: 0x04023383 RID: 144259
		[Token(Token = "0x4023383")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelBkg;

		// Token: 0x04023384 RID: 144260
		[Token(Token = "0x4023384")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgGroupIcon;

		// Token: 0x04023385 RID: 144261
		[Token(Token = "0x4023385")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _firstText;

		// Token: 0x04023386 RID: 144262
		[Token(Token = "0x4023386")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _canvasGroupText;

		// Token: 0x04023387 RID: 144263
		[Token(Token = "0x4023387")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _canvasGroupIcon;

		// Token: 0x04023388 RID: 144264
		[Token(Token = "0x4023388")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _alphaUnlock;

		// Token: 0x04023389 RID: 144265
		[Token(Token = "0x4023389")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _alphaLockedText;

		// Token: 0x0402338A RID: 144266
		[Token(Token = "0x402338A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _alphaLockedIcon;

		// Token: 0x0402338B RID: 144267
		[Token(Token = "0x402338B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject[] _iconLevelGroup;

		// Token: 0x0402338C RID: 144268
		[Token(Token = "0x402338C")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x0402338D RID: 144269
		[Token(Token = "0x402338D")]
		[FieldOffset(Offset = "0x68")]
		private List<RL02OuterBuffListRawTextItemModel> m_itemViewList;

		// Token: 0x0402338E RID: 144270
		[Token(Token = "0x402338E")]
		[FieldOffset(Offset = "0x70")]
		private RL02OuterBuffSummaryRawTextNodeItemView.Adapter m_adapter;

		// Token: 0x04023390 RID: 144272
		[Token(Token = "0x4023390")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x04023391 RID: 144273
		[Token(Token = "0x4023391")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_page;

		// Token: 0x04023392 RID: 144274
		[Token(Token = "0x4023392")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023393 RID: 144275
		[Token(Token = "0x4023393")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04023394 RID: 144276
		[Token(Token = "0x4023394")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004622 RID: 17954
		[Token(Token = "0x2004622")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x0601B496 RID: 111766 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B496")]
			[Address(RVA = "0x1495960", Offset = "0x1494560", VA = "0x181495960")]
			public Adapter(RL02OuterBuffSummaryRawTextNodeItemView closure)
			{
			}

			// Token: 0x17004109 RID: 16649
			// (get) Token: 0x0601B497 RID: 111767 RVA: 0x000A4CE8 File Offset: 0x000A2EE8
			[Token(Token = "0x17004109")]
			public override int count
			{
				[Token(Token = "0x601B497")]
				[Address(RVA = "0x1495DD0", Offset = "0x14949D0", VA = "0x181495DD0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601B498 RID: 111768 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B498")]
			[Address(RVA = "0x1495180", Offset = "0x1493D80", VA = "0x181495180", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04023395 RID: 144277
			[Token(Token = "0x4023395")]
			[FieldOffset(Offset = "0x20")]
			private RL02OuterBuffSummaryRawTextNodeItemView m_closure;

			// Token: 0x04023396 RID: 144278
			[Token(Token = "0x4023396")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04023397 RID: 144279
			[Token(Token = "0x4023397")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04023398 RID: 144280
			[Token(Token = "0x4023398")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
