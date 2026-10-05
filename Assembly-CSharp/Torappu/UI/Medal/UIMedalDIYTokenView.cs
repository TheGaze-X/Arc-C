using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x0200493E RID: 18750
	[Token(Token = "0x200493E")]
	public class UIMedalDIYTokenView : MonoBehaviour, IHotfixable, IPointerDownHandler, IEventSystemHandler, IDragHandler, IBeginDragHandler, IEndDragHandler
	{
		// Token: 0x170042FD RID: 17149
		// (get) Token: 0x0601C43F RID: 115775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170042FD")]
		public RectTransform rectTrans
		{
			[Token(Token = "0x601C43F")]
			[Address(RVA = "0x15C0420", Offset = "0x15BF020", VA = "0x1815C0420")]
			get
			{
				return null;
			}
		}

		// Token: 0x170042FE RID: 17150
		// (get) Token: 0x0601C440 RID: 115776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170042FE")]
		public CanvasGroup alphaHandler
		{
			[Token(Token = "0x601C440")]
			[Address(RVA = "0x15C0330", Offset = "0x15BEF30", VA = "0x1815C0330")]
			get
			{
				return null;
			}
		}

		// Token: 0x170042FF RID: 17151
		// (get) Token: 0x0601C441 RID: 115777 RVA: 0x000A7B98 File Offset: 0x000A5D98
		// (set) Token: 0x0601C442 RID: 115778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170042FF")]
		public bool enableRaycast
		{
			[Token(Token = "0x601C441")]
			[Address(RVA = "0x15C0390", Offset = "0x15BEF90", VA = "0x1815C0390")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601C442")]
			[Address(RVA = "0x15C0520", Offset = "0x15BF120", VA = "0x1815C0520")]
			set
			{
			}
		}

		// Token: 0x0601C443 RID: 115779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C443")]
		[Address(RVA = "0x15BF990", Offset = "0x15BE590", VA = "0x1815BF990")]
		public void Init(DIYMedalModel model, IMedalDIYContext context)
		{
		}

		// Token: 0x0601C444 RID: 115780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C444")]
		[Address(RVA = "0x15BF900", Offset = "0x15BE500", VA = "0x1815BF900")]
		public void ClearEvents()
		{
		}

		// Token: 0x0601C445 RID: 115781 RVA: 0x000A7BB0 File Offset: 0x000A5DB0
		[Token(Token = "0x601C445")]
		[Address(RVA = "0x15BFFD0", Offset = "0x15BEBD0", VA = "0x1815BFFD0")]
		private UIMedalDIYTokenView.SizeConfig _LoadSizeConfig(MedalSize size)
		{
			return default(UIMedalDIYTokenView.SizeConfig);
		}

		// Token: 0x0601C446 RID: 115782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C446")]
		[Address(RVA = "0x15BFEA0", Offset = "0x15BEAA0", VA = "0x1815BFEA0", Slot = "4")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x0601C447 RID: 115783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C447")]
		[Address(RVA = "0x15BFD30", Offset = "0x15BE930", VA = "0x1815BFD30", Slot = "5")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0601C448 RID: 115784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C448")]
		[Address(RVA = "0x15BFCB0", Offset = "0x15BE8B0", VA = "0x1815BFCB0", Slot = "6")]
		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0601C449 RID: 115785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C449")]
		[Address(RVA = "0x15BFDB0", Offset = "0x15BE9B0", VA = "0x1815BFDB0", Slot = "7")]
		public void OnEndDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0601C44A RID: 115786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C44A")]
		[Address(RVA = "0x15C0150", Offset = "0x15BED50", VA = "0x1815C0150")]
		private void _TryTriggerBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0601C44B RID: 115787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C44B")]
		[Address(RVA = "0x15C0240", Offset = "0x15BEE40", VA = "0x1815C0240")]
		public UIMedalDIYTokenView()
		{
		}

		// Token: 0x04024F93 RID: 151443
		[Token(Token = "0x4024F93")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _image;

		// Token: 0x04024F94 RID: 151444
		[Token(Token = "0x4024F94")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private HexRaycastBlocker _hexRaycaster;

		// Token: 0x04024F95 RID: 151445
		[Token(Token = "0x4024F95")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x04024F96 RID: 151446
		[Token(Token = "0x4024F96")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<UIMedalDIYTokenView.SizeConfig> _sizeConfigs;

		// Token: 0x04024F97 RID: 151447
		[Token(Token = "0x4024F97")]
		[FieldOffset(Offset = "0x38")]
		private UIMedalDIYTokenView.Status m_status;

		// Token: 0x04024F98 RID: 151448
		[Token(Token = "0x4024F98")]
		[FieldOffset(Offset = "0x48")]
		private DIYMedalModel m_model;

		// Token: 0x04024F99 RID: 151449
		[Token(Token = "0x4024F99")]
		[FieldOffset(Offset = "0x50")]
		private IMedalDIYContext m_context;

		// Token: 0x04024F9A RID: 151450
		[Token(Token = "0x4024F9A")]
		[FieldOffset(Offset = "0x58")]
		private RectTransform m_rectTrans;

		// Token: 0x04024F9B RID: 151451
		[Token(Token = "0x4024F9B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_rectTrans;

		// Token: 0x04024F9C RID: 151452
		[Token(Token = "0x4024F9C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_alphaHandler;

		// Token: 0x04024F9D RID: 151453
		[Token(Token = "0x4024F9D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableRaycast;

		// Token: 0x04024F9E RID: 151454
		[Token(Token = "0x4024F9E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_enableRaycast;

		// Token: 0x04024F9F RID: 151455
		[Token(Token = "0x4024F9F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04024FA0 RID: 151456
		[Token(Token = "0x4024FA0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ClearEvents;

		// Token: 0x04024FA1 RID: 151457
		[Token(Token = "0x4024FA1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadSizeConfig;

		// Token: 0x04024FA2 RID: 151458
		[Token(Token = "0x4024FA2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnPointerDown;

		// Token: 0x04024FA3 RID: 151459
		[Token(Token = "0x4024FA3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnDrag;

		// Token: 0x04024FA4 RID: 151460
		[Token(Token = "0x4024FA4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnBeginDrag;

		// Token: 0x04024FA5 RID: 151461
		[Token(Token = "0x4024FA5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnEndDrag;

		// Token: 0x04024FA6 RID: 151462
		[Token(Token = "0x4024FA6")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TryTriggerBeginDrag;

		// Token: 0x04024FA7 RID: 151463
		[Token(Token = "0x4024FA7")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200493F RID: 18751
		[Token(Token = "0x200493F")]
		private struct Status
		{
			// Token: 0x0601C44C RID: 115788 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C44C")]
			[Address(RVA = "0x15B2150", Offset = "0x15B0D50", VA = "0x1815B2150")]
			public void ClearPress()
			{
			}

			// Token: 0x04024FA8 RID: 151464
			[Token(Token = "0x4024FA8")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIMedalDIYTokenView.Status NONE;

			// Token: 0x04024FA9 RID: 151465
			[Token(Token = "0x4024FA9")]
			[FieldOffset(Offset = "0x0")]
			public bool isPressing;

			// Token: 0x04024FAA RID: 151466
			[Token(Token = "0x4024FAA")]
			[FieldOffset(Offset = "0x1")]
			public bool isDragging;

			// Token: 0x04024FAB RID: 151467
			[Token(Token = "0x4024FAB")]
			[FieldOffset(Offset = "0x8")]
			public long pressTs;
		}

		// Token: 0x02004940 RID: 18752
		[Token(Token = "0x2004940")]
		[Serializable]
		private struct SizeConfig
		{
			// Token: 0x04024FAC RID: 151468
			[Token(Token = "0x4024FAC")]
			[FieldOffset(Offset = "0x0")]
			public MedalSize size;

			// Token: 0x04024FAD RID: 151469
			[Token(Token = "0x4024FAD")]
			[FieldOffset(Offset = "0x4")]
			public Vector2 iconSize;

			// Token: 0x04024FAE RID: 151470
			[Token(Token = "0x4024FAE")]
			[FieldOffset(Offset = "0xC")]
			public Vector2 colliderSize;
		}
	}
}
