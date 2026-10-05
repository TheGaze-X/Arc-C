using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x02006048 RID: 24648
	[Token(Token = "0x2006048")]
	public class CarvingSlotCardViewHolder : MonoBehaviour, UICustomAnimDrivenLayouter<KeyValuePair<string, CarvingMainCardViewModel>, CarvingSlotCardViewHolder>.ICustomAnimDrivenLayoutElement, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler, IHotfixable
	{
		// Token: 0x17005421 RID: 21537
		// (get) Token: 0x06023A37 RID: 145975 RVA: 0x000C16B0 File Offset: 0x000BF8B0
		// (set) Token: 0x06023A38 RID: 145976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005421")]
		public float samplePos
		{
			[Token(Token = "0x6023A37")]
			[Address(RVA = "0x1E4F940", Offset = "0x1E4E540", VA = "0x181E4F940", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6023A38")]
			[Address(RVA = "0x1E4FB30", Offset = "0x1E4E730", VA = "0x181E4FB30", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005422 RID: 21538
		// (get) Token: 0x06023A39 RID: 145977 RVA: 0x000C16C8 File Offset: 0x000BF8C8
		[Token(Token = "0x17005422")]
		public float showPos
		{
			[Token(Token = "0x6023A39")]
			[Address(RVA = "0x1E4F9B0", Offset = "0x1E4E5B0", VA = "0x181E4F9B0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17005423 RID: 21539
		// (get) Token: 0x06023A3A RID: 145978 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06023A3B RID: 145979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005423")]
		public TouchHandler touchHandler
		{
			[Token(Token = "0x6023A3A")]
			[Address(RVA = "0x1E4FA20", Offset = "0x1E4E620", VA = "0x181E4FA20")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6023A3B")]
			[Address(RVA = "0x1E4FBC0", Offset = "0x1E4E7C0", VA = "0x181E4FBC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005424 RID: 21540
		// (get) Token: 0x06023A3C RID: 145980 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06023A3D RID: 145981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005424")]
		public string cardId
		{
			[Token(Token = "0x6023A3C")]
			[Address(RVA = "0x1E4F8C0", Offset = "0x1E4E4C0", VA = "0x181E4F8C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6023A3D")]
			[Address(RVA = "0x1E4FAA0", Offset = "0x1E4E6A0", VA = "0x181E4FAA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06023A3E RID: 145982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A3E")]
		[Address(RVA = "0x1E4F620", Offset = "0x1E4E220", VA = "0x181E4F620")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023A3F RID: 145983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A3F")]
		[Address(RVA = "0x1E4F550", Offset = "0x1E4E150", VA = "0x181E4F550")]
		public void SetShowPos(float showPos)
		{
		}

		// Token: 0x06023A40 RID: 145984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A40")]
		[Address(RVA = "0x1E4F220", Offset = "0x1E4DE20", VA = "0x181E4F220")]
		public void Render(CarvingMainCardViewModel viewModel, CarvingCardListViewModel cardListViewModel, bool isProcessed)
		{
		}

		// Token: 0x06023A41 RID: 145985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A41")]
		[Address(RVA = "0x1E4EE70", Offset = "0x1E4DA70", VA = "0x181E4EE70", Slot = "6")]
		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06023A42 RID: 145986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A42")]
		[Address(RVA = "0x1E4F120", Offset = "0x1E4DD20", VA = "0x181E4F120", Slot = "7")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06023A43 RID: 145987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A43")]
		[Address(RVA = "0x1E4F1A0", Offset = "0x1E4DDA0", VA = "0x181E4F1A0", Slot = "8")]
		public void OnEndDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06023A44 RID: 145988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A44")]
		[Address(RVA = "0x1E4F020", Offset = "0x1E4DC20", VA = "0x181E4F020")]
		public void OnCardClicked()
		{
		}

		// Token: 0x06023A45 RID: 145989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A45")]
		[Address(RVA = "0x1E4F800", Offset = "0x1E4E400", VA = "0x181E4F800")]
		public CarvingSlotCardViewHolder()
		{
		}

		// Token: 0x040315B1 RID: 202161
		[Token(Token = "0x40315B1")]
		[FieldOffset(Offset = "0x0")]
		public static readonly float SLOT_CARD_SCALE;

		// Token: 0x040315B2 RID: 202162
		[Token(Token = "0x40315B2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CarvingMainCardView _prefabCard;

		// Token: 0x040315B3 RID: 202163
		[Token(Token = "0x40315B3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _cardContainer;

		// Token: 0x040315B4 RID: 202164
		[Token(Token = "0x40315B4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _showAnim;

		// Token: 0x040315B5 RID: 202165
		[Token(Token = "0x40315B5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x040315B6 RID: 202166
		[Token(Token = "0x40315B6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _bornTypeHandler;

		// Token: 0x040315B7 RID: 202167
		[Token(Token = "0x40315B7")]
		[FieldOffset(Offset = "0x48")]
		private bool m_inited;

		// Token: 0x040315B8 RID: 202168
		[Token(Token = "0x40315B8")]
		[FieldOffset(Offset = "0x4C")]
		private float m_showPos;

		// Token: 0x040315B9 RID: 202169
		[Token(Token = "0x40315B9")]
		[FieldOffset(Offset = "0x50")]
		private CarvingMainCardView m_cardView;

		// Token: 0x040315BA RID: 202170
		[Token(Token = "0x40315BA")]
		[FieldOffset(Offset = "0x58")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040315BB RID: 202171
		[Token(Token = "0x40315BB")]
		[FieldOffset(Offset = "0x68")]
		private string m_cachedCardId;

		// Token: 0x040315BC RID: 202172
		[Token(Token = "0x40315BC")]
		[FieldOffset(Offset = "0x70")]
		private CarvingBoardView.CarvingDragParam m_dragParam;

		// Token: 0x040315C0 RID: 202176
		[Token(Token = "0x40315C0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_samplePos;

		// Token: 0x040315C1 RID: 202177
		[Token(Token = "0x40315C1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_samplePos;

		// Token: 0x040315C2 RID: 202178
		[Token(Token = "0x40315C2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_showPos;

		// Token: 0x040315C3 RID: 202179
		[Token(Token = "0x40315C3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_touchHandler;

		// Token: 0x040315C4 RID: 202180
		[Token(Token = "0x40315C4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_touchHandler;

		// Token: 0x040315C5 RID: 202181
		[Token(Token = "0x40315C5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_cardId;

		// Token: 0x040315C6 RID: 202182
		[Token(Token = "0x40315C6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_cardId;

		// Token: 0x040315C7 RID: 202183
		[Token(Token = "0x40315C7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040315C8 RID: 202184
		[Token(Token = "0x40315C8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SetShowPos;

		// Token: 0x040315C9 RID: 202185
		[Token(Token = "0x40315C9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040315CA RID: 202186
		[Token(Token = "0x40315CA")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnBeginDrag;

		// Token: 0x040315CB RID: 202187
		[Token(Token = "0x40315CB")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnDrag;

		// Token: 0x040315CC RID: 202188
		[Token(Token = "0x40315CC")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnEndDrag;

		// Token: 0x040315CD RID: 202189
		[Token(Token = "0x40315CD")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnCardClicked;

		// Token: 0x040315CE RID: 202190
		[Token(Token = "0x40315CE")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
