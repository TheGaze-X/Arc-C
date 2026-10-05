using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x02004931 RID: 18737
	[Token(Token = "0x2004931")]
	public class UIMedalDIYCardView : MonoBehaviour, IHotfixable, IDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler
	{
		// Token: 0x170042F8 RID: 17144
		// (get) Token: 0x0601C3E3 RID: 115683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170042F8")]
		public CanvasGroup alphaHandler
		{
			[Token(Token = "0x601C3E3")]
			[Address(RVA = "0x15BA510", Offset = "0x15B9110", VA = "0x1815BA510")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601C3E4 RID: 115684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C3E4")]
		[Address(RVA = "0x15B93E0", Offset = "0x15B7FE0", VA = "0x1815B93E0")]
		public void Init(IMedalDIYContext context, UIMedalDIYCardView.DragDelegate dragEvents)
		{
		}

		// Token: 0x0601C3E5 RID: 115685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C3E5")]
		[Address(RVA = "0x15B9A80", Offset = "0x15B8680", VA = "0x1815B9A80")]
		public void Render(DIYMedalModel viewModel)
		{
		}

		// Token: 0x0601C3E6 RID: 115686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C3E6")]
		[Address(RVA = "0x15BA140", Offset = "0x15B8D40", VA = "0x1815BA140")]
		private void _UpdateSelectedStatus()
		{
		}

		// Token: 0x0601C3E7 RID: 115687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C3E7")]
		[Address(RVA = "0x15B9D90", Offset = "0x15B8990", VA = "0x1815B9D90")]
		private void _SetCardPosWithTween(Vector2 targetPos)
		{
		}

		// Token: 0x0601C3E8 RID: 115688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C3E8")]
		[Address(RVA = "0x15B9BC0", Offset = "0x15B87C0", VA = "0x1815B9BC0")]
		private void _SetCardAlphaWithTween(float targetAlpha)
		{
		}

		// Token: 0x0601C3E9 RID: 115689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C3E9")]
		[Address(RVA = "0x15B95E0", Offset = "0x15B81E0", VA = "0x1815B95E0")]
		private void OnDisable()
		{
		}

		// Token: 0x0601C3EA RID: 115690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C3EA")]
		[Address(RVA = "0x15B9690", Offset = "0x15B8290", VA = "0x1815B9690", Slot = "4")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0601C3EB RID: 115691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C3EB")]
		[Address(RVA = "0x15B94C0", Offset = "0x15B80C0", VA = "0x1815B94C0", Slot = "5")]
		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0601C3EC RID: 115692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C3EC")]
		[Address(RVA = "0x15B99A0", Offset = "0x15B85A0", VA = "0x1815B99A0", Slot = "6")]
		public void OnEndDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0601C3ED RID: 115693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C3ED")]
		[Address(RVA = "0x15BA450", Offset = "0x15B9050", VA = "0x1815BA450")]
		public UIMedalDIYCardView()
		{
		}

		// Token: 0x04024F1D RID: 151325
		[Token(Token = "0x4024F1D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector2 DRAG_DIR_DIS;

		// Token: 0x04024F1E RID: 151326
		[Token(Token = "0x4024F1E")]
		private const float CARD_MOVE_DUR = 0.16f;

		// Token: 0x04024F1F RID: 151327
		[Token(Token = "0x4024F1F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon;

		// Token: 0x04024F20 RID: 151328
		[Token(Token = "0x4024F20")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x04024F21 RID: 151329
		[Token(Token = "0x4024F21")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _cardTrans;

		// Token: 0x04024F22 RID: 151330
		[Token(Token = "0x4024F22")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _yBiasSelected;

		// Token: 0x04024F23 RID: 151331
		[Token(Token = "0x4024F23")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _yBiasDefault;

		// Token: 0x04024F24 RID: 151332
		[Token(Token = "0x4024F24")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _cardCanvasGroup;

		// Token: 0x04024F25 RID: 151333
		[Token(Token = "0x4024F25")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _selectedAlpha;

		// Token: 0x04024F26 RID: 151334
		[Token(Token = "0x4024F26")]
		[FieldOffset(Offset = "0x44")]
		private UIMedalDIYCardView.DragContext m_drag;

		// Token: 0x04024F27 RID: 151335
		[Token(Token = "0x4024F27")]
		[FieldOffset(Offset = "0x50")]
		private DIYMedalModel m_viewModel;

		// Token: 0x04024F28 RID: 151336
		[Token(Token = "0x4024F28")]
		[FieldOffset(Offset = "0x58")]
		private UIMedalDIYCardView.DragDelegate m_dragEvents;

		// Token: 0x04024F29 RID: 151337
		[Token(Token = "0x4024F29")]
		[FieldOffset(Offset = "0x78")]
		private IMedalDIYContext m_context;

		// Token: 0x04024F2A RID: 151338
		[Token(Token = "0x4024F2A")]
		[FieldOffset(Offset = "0x80")]
		private Tween m_cardMoveTween;

		// Token: 0x04024F2B RID: 151339
		[Token(Token = "0x4024F2B")]
		[FieldOffset(Offset = "0x88")]
		private Tween m_cardAlphaTween;

		// Token: 0x04024F2C RID: 151340
		[Token(Token = "0x4024F2C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_alphaHandler;

		// Token: 0x04024F2D RID: 151341
		[Token(Token = "0x4024F2D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04024F2E RID: 151342
		[Token(Token = "0x4024F2E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04024F2F RID: 151343
		[Token(Token = "0x4024F2F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateSelectedStatus;

		// Token: 0x04024F30 RID: 151344
		[Token(Token = "0x4024F30")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetCardPosWithTween;

		// Token: 0x04024F31 RID: 151345
		[Token(Token = "0x4024F31")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetCardAlphaWithTween;

		// Token: 0x04024F32 RID: 151346
		[Token(Token = "0x4024F32")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x04024F33 RID: 151347
		[Token(Token = "0x4024F33")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnDrag;

		// Token: 0x04024F34 RID: 151348
		[Token(Token = "0x4024F34")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnBeginDrag;

		// Token: 0x04024F35 RID: 151349
		[Token(Token = "0x4024F35")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnEndDrag;

		// Token: 0x04024F36 RID: 151350
		[Token(Token = "0x4024F36")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004932 RID: 18738
		[Token(Token = "0x2004932")]
		private struct DragContext
		{
			// Token: 0x170042F9 RID: 17145
			// (get) Token: 0x0601C3F0 RID: 115696 RVA: 0x000A7AA8 File Offset: 0x000A5CA8
			// (set) Token: 0x0601C3F1 RID: 115697 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170042F9")]
			public bool isEmpty
			{
				[Token(Token = "0x601C3F0")]
				[Address(RVA = "0xDF9A30", Offset = "0xDF8630", VA = "0x180DF9A30")]
				[CompilerGenerated]
				readonly get
				{
					return default(bool);
				}
				[Token(Token = "0x601C3F1")]
				[Address(RVA = "0xFEDED0", Offset = "0xFECAD0", VA = "0x180FEDED0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170042FA RID: 17146
			// (get) Token: 0x0601C3F2 RID: 115698 RVA: 0x000A7AC0 File Offset: 0x000A5CC0
			// (set) Token: 0x0601C3F3 RID: 115699 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170042FA")]
			public Vector2 startPos
			{
				[Token(Token = "0x601C3F2")]
				[Address(RVA = "0x15ABE60", Offset = "0x15AAA60", VA = "0x1815ABE60")]
				[CompilerGenerated]
				readonly get
				{
					return default(Vector2);
				}
				[Token(Token = "0x601C3F3")]
				[Address(RVA = "0x15ABE80", Offset = "0x15AAA80", VA = "0x1815ABE80")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0601C3F4 RID: 115700 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C3F4")]
			[Address(RVA = "0x15ABE00", Offset = "0x15AAA00", VA = "0x1815ABE00")]
			public DragContext(Vector2 startPos)
			{
			}

			// Token: 0x04024F37 RID: 151351
			[Token(Token = "0x4024F37")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIMedalDIYCardView.DragContext EMPTY;
		}

		// Token: 0x02004933 RID: 18739
		[Token(Token = "0x2004933")]
		public struct DragDelegate
		{
			// Token: 0x0601C3F6 RID: 115702 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C3F6")]
			[Address(RVA = "0x15ABEB0", Offset = "0x15AAAB0", VA = "0x1815ABEB0")]
			public void InvokeDrag(PointerEventData eventData)
			{
			}

			// Token: 0x0601C3F7 RID: 115703 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C3F7")]
			[Address(RVA = "0x15ABE90", Offset = "0x15AAA90", VA = "0x1815ABE90")]
			public void InvokeBeginDrag(PointerEventData eventData)
			{
			}

			// Token: 0x0601C3F8 RID: 115704 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C3F8")]
			[Address(RVA = "0x103A620", Offset = "0x1039220", VA = "0x18103A620")]
			public void InvokeEndDrag(PointerEventData eventData)
			{
			}

			// Token: 0x0601C3F9 RID: 115705 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C3F9")]
			[Address(RVA = "0x5134D0", Offset = "0x5120D0", VA = "0x1805134D0")]
			public void InvokeCancelDrag()
			{
			}

			// Token: 0x04024F3A RID: 151354
			[Token(Token = "0x4024F3A")]
			[FieldOffset(Offset = "0x0")]
			public Action<PointerEventData> onDrag;

			// Token: 0x04024F3B RID: 151355
			[Token(Token = "0x4024F3B")]
			[FieldOffset(Offset = "0x8")]
			public Action<PointerEventData> onBeginDrag;

			// Token: 0x04024F3C RID: 151356
			[Token(Token = "0x4024F3C")]
			[FieldOffset(Offset = "0x10")]
			public Action<PointerEventData> onEndDrag;

			// Token: 0x04024F3D RID: 151357
			[Token(Token = "0x4024F3D")]
			[FieldOffset(Offset = "0x18")]
			public Action cancelDrag;
		}
	}
}
