using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005454 RID: 21588
	[Token(Token = "0x2005454")]
	public class RoguelikeSacrificeListItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004A7B RID: 19067
		// (get) Token: 0x0601FC82 RID: 130178 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601FC83 RID: 130179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004A7B")]
		public Action<string> onItemClick
		{
			[Token(Token = "0x601FC82")]
			[Address(RVA = "0x196EAE0", Offset = "0x196D6E0", VA = "0x18196EAE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601FC83")]
			[Address(RVA = "0x196EB40", Offset = "0x196D740", VA = "0x18196EB40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601FC84 RID: 130180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC84")]
		[Address(RVA = "0x196E8E0", Offset = "0x196D4E0", VA = "0x18196E8E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601FC85 RID: 130181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC85")]
		[Address(RVA = "0x196E4E0", Offset = "0x196D0E0", VA = "0x18196E4E0")]
		public void Render(IRoguelikeSacrifice data, string selectedItem, bool fastMode)
		{
		}

		// Token: 0x0601FC86 RID: 130182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC86")]
		[Address(RVA = "0x196E3D0", Offset = "0x196CFD0", VA = "0x18196E3D0")]
		public void OnBtnClicked()
		{
		}

		// Token: 0x0601FC87 RID: 130183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FC87")]
		[Address(RVA = "0x196EA70", Offset = "0x196D670", VA = "0x18196EA70")]
		public RoguelikeSacrificeListItem()
		{
		}

		// Token: 0x0402AD22 RID: 175394
		[Token(Token = "0x402AD22")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasSelected;

		// Token: 0x0402AD23 RID: 175395
		[Token(Token = "0x402AD23")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _itemIconHolder;

		// Token: 0x0402AD24 RID: 175396
		[Token(Token = "0x402AD24")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RoguelikeCustomizableItemIcon _itemIconPrefab;

		// Token: 0x0402AD25 RID: 175397
		[Token(Token = "0x402AD25")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _itemIconScale;

		// Token: 0x0402AD26 RID: 175398
		[Token(Token = "0x402AD26")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x0402AD27 RID: 175399
		[Token(Token = "0x402AD27")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<RoguelikeSacrificeListItemPlugin> _plugins;

		// Token: 0x0402AD28 RID: 175400
		[Token(Token = "0x402AD28")]
		[FieldOffset(Offset = "0x48")]
		private bool m_inited;

		// Token: 0x0402AD29 RID: 175401
		[Token(Token = "0x402AD29")]
		[FieldOffset(Offset = "0x50")]
		private UISwitchTween m_selectedTween;

		// Token: 0x0402AD2A RID: 175402
		[Token(Token = "0x402AD2A")]
		[FieldOffset(Offset = "0x58")]
		private string m_cachedInstId;

		// Token: 0x0402AD2B RID: 175403
		[Token(Token = "0x402AD2B")]
		[FieldOffset(Offset = "0x60")]
		private RoguelikeCustomizableItemIcon m_itemIcon;

		// Token: 0x0402AD2D RID: 175405
		[Token(Token = "0x402AD2D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemClick;

		// Token: 0x0402AD2E RID: 175406
		[Token(Token = "0x402AD2E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemClick;

		// Token: 0x0402AD2F RID: 175407
		[Token(Token = "0x402AD2F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402AD30 RID: 175408
		[Token(Token = "0x402AD30")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402AD31 RID: 175409
		[Token(Token = "0x402AD31")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnBtnClicked;

		// Token: 0x0402AD32 RID: 175410
		[Token(Token = "0x402AD32")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
