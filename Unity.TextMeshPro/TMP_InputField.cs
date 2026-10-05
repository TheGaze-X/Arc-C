using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x02000053 RID: 83
	[Token(Token = "0x2000053")]
	[AddComponentMenu("UI/TextMeshPro - Input Field", 11)]
	public class TMP_InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement, IScrollHandler
	{
		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600028A RID: 650 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000075")]
		private BaseInput inputSystem
		{
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x58A1190", Offset = "0x589FD90", VA = "0x1858A1190")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600028B RID: 651 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000076")]
		private string compositionString
		{
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x58A1010", Offset = "0x589FC10", VA = "0x1858A1010")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600028C RID: 652 RVA: 0x00002DD8 File Offset: 0x00000FD8
		[Token(Token = "0x17000077")]
		private int compositionLength
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x58A0FE0", Offset = "0x589FBE0", VA = "0x1858A0FE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x58A0B10", Offset = "0x589F710", VA = "0x1858A0B10")]
		protected TMP_InputField()
		{
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600028E RID: 654 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000078")]
		protected Mesh mesh
		{
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x58A12E0", Offset = "0x589FEE0", VA = "0x1858A12E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600028F RID: 655 RVA: 0x00002DF0 File Offset: 0x00000FF0
		// (set) Token: 0x06000290 RID: 656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000079")]
		public bool shouldHideMobileInput
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x58A17D0", Offset = "0x58A03D0", VA = "0x1858A17D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000290")]
			[Address(RVA = "0x58A2C70", Offset = "0x58A1870", VA = "0x1858A2C70")]
			set
			{
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000291 RID: 657 RVA: 0x00002E08 File Offset: 0x00001008
		// (set) Token: 0x06000292 RID: 658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007A")]
		public bool shouldHideSoftKeyboard
		{
			[Token(Token = "0x6000291")]
			[Address(RVA = "0x58A1800", Offset = "0x58A0400", VA = "0x1858A1800")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x58A2CF0", Offset = "0x58A18F0", VA = "0x1858A2CF0")]
			set
			{
			}
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00002E20 File Offset: 0x00001020
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x58A1870", Offset = "0x58A0470", VA = "0x1858A1870")]
		private bool isKeyboardUsingEvents()
		{
			return default(bool);
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000294 RID: 660 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000295 RID: 661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007B")]
		public string text
		{
			[Token(Token = "0x6000294")]
			[Address(RVA = "0x55DCE20", Offset = "0x55DBA20", VA = "0x1855DCE20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000295")]
			[Address(RVA = "0x58A3050", Offset = "0x58A1C50", VA = "0x1858A3050")]
			set
			{
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x589F480", Offset = "0x589E080", VA = "0x18589F480")]
		public void SetTextWithoutNotify(string input)
		{
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x589F490", Offset = "0x589E090", VA = "0x18589F490")]
		private void SetText(string value, bool sendCallback = true)
		{
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000298 RID: 664 RVA: 0x00002E38 File Offset: 0x00001038
		[Token(Token = "0x1700007C")]
		public bool isFocused
		{
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x58A12B0", Offset = "0x589FEB0", VA = "0x1858A12B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000299 RID: 665 RVA: 0x00002E50 File Offset: 0x00001050
		// (set) Token: 0x0600029A RID: 666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007D")]
		public float caretBlinkRate
		{
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x58A0E90", Offset = "0x589FA90", VA = "0x1858A0E90")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x58A1910", Offset = "0x58A0510", VA = "0x1858A1910")]
			set
			{
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600029B RID: 667 RVA: 0x00002E68 File Offset: 0x00001068
		// (set) Token: 0x0600029C RID: 668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007E")]
		public int caretWidth
		{
			[Token(Token = "0x600029B")]
			[Address(RVA = "0x58A0FA0", Offset = "0x589FBA0", VA = "0x1858A0FA0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600029C")]
			[Address(RVA = "0x58A1BD0", Offset = "0x58A07D0", VA = "0x1858A1BD0")]
			set
			{
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600029D RID: 669 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600029E RID: 670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007F")]
		public RectTransform textViewport
		{
			[Token(Token = "0x600029D")]
			[Address(RVA = "0x22F8840", Offset = "0x22F7440", VA = "0x1822F8840")]
			get
			{
				return null;
			}
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x58A3000", Offset = "0x58A1C00", VA = "0x1858A3000")]
			set
			{
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600029F RID: 671 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000080")]
		public TMP_Text textComponent
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x4FA1B40", Offset = "0x4FA0740", VA = "0x184FA1B40")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x58A2FA0", Offset = "0x58A1BA0", VA = "0x1858A2FA0")]
			set
			{
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000081")]
		public Graphic placeholder
		{
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x5080A80", Offset = "0x507F680", VA = "0x185080A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x58A2680", Offset = "0x58A1280", VA = "0x1858A2680")]
			set
			{
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000082")]
		public Scrollbar verticalScrollbar
		{
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x1692740", Offset = "0x1691340", VA = "0x181692740")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x58A3060", Offset = "0x58A1C60", VA = "0x1858A3060")]
			set
			{
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x00002E80 File Offset: 0x00001080
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000083")]
		public float scrollSensitivity
		{
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x58A1730", Offset = "0x58A0330", VA = "0x1858A1730")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x58A2910", Offset = "0x58A1510", VA = "0x1858A2910")]
			set
			{
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x00002E98 File Offset: 0x00001098
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000084")]
		public Color caretColor
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x58A0EA0", Offset = "0x589FAA0", VA = "0x1858A0EA0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x58A1980", Offset = "0x58A0580", VA = "0x1858A1980")]
			set
			{
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x00002EB0 File Offset: 0x000010B0
		// (set) Token: 0x060002AA RID: 682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000085")]
		public bool customCaretColor
		{
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x58A10E0", Offset = "0x589FCE0", VA = "0x1858A10E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x58A1F40", Offset = "0x58A0B40", VA = "0x1858A1F40")]
			set
			{
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060002AB RID: 683 RVA: 0x00002EC8 File Offset: 0x000010C8
		// (set) Token: 0x060002AC RID: 684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000086")]
		public Color selectionColor
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x58A1740", Offset = "0x58A0340", VA = "0x1858A1740")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x58A2A40", Offset = "0x58A1640", VA = "0x1858A2A40")]
			set
			{
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060002AD RID: 685 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060002AE RID: 686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000087")]
		public TMP_InputField.SubmitEvent onEndEdit
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x16925F0", Offset = "0x16911F0", VA = "0x1816925F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x58A23F0", Offset = "0x58A0FF0", VA = "0x1858A23F0")]
			set
			{
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060002AF RID: 687 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060002B0 RID: 688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000088")]
		public TMP_InputField.SubmitEvent onSubmit
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x4FA1B60", Offset = "0x4FA0760", VA = "0x184FA1B60")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x58A24F0", Offset = "0x58A10F0", VA = "0x1858A24F0")]
			set
			{
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060002B2 RID: 690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000089")]
		public TMP_InputField.SelectionEvent onSelect
		{
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x55CD200", Offset = "0x55CBE00", VA = "0x1855CD200")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x58A24A0", Offset = "0x58A10A0", VA = "0x1858A24A0")]
			set
			{
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060002B4 RID: 692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008A")]
		public TMP_InputField.SelectionEvent onDeselect
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x55CD230", Offset = "0x55CBE30", VA = "0x1855CD230")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x58A23A0", Offset = "0x58A0FA0", VA = "0x1858A23A0")]
			set
			{
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060002B6 RID: 694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008B")]
		public TMP_InputField.TextSelectionEvent onTextSelection
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x55CD240", Offset = "0x55CBE40", VA = "0x1855CD240")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x58A2540", Offset = "0x58A1140", VA = "0x1858A2540")]
			set
			{
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060002B8 RID: 696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008C")]
		public TMP_InputField.TextSelectionEvent onEndTextSelection
		{
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x55CD250", Offset = "0x55CBE50", VA = "0x1855CD250")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x58A2440", Offset = "0x58A1040", VA = "0x1858A2440")]
			set
			{
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060002BA RID: 698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008D")]
		public TMP_InputField.OnChangeEvent onValueChanged
		{
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x55CD220", Offset = "0x55CBE20", VA = "0x1855CD220")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x58A2630", Offset = "0x58A1230", VA = "0x1858A2630")]
			set
			{
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060002BB RID: 699 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060002BC RID: 700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008E")]
		public TMP_InputField.TouchScreenKeyboardEvent onTouchScreenKeyboardStatusChanged
		{
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x55CD210", Offset = "0x55CBE10", VA = "0x1855CD210")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x58A2590", Offset = "0x58A1190", VA = "0x1858A2590")]
			set
			{
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060002BD RID: 701 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060002BE RID: 702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008F")]
		public TMP_InputField.OnValidateInput onValidateInput
		{
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x55DCE50", Offset = "0x55DBA50", VA = "0x1855DCE50")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x58A25E0", Offset = "0x58A11E0", VA = "0x1858A25E0")]
			set
			{
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060002BF RID: 703 RVA: 0x00002EE0 File Offset: 0x000010E0
		// (set) Token: 0x060002C0 RID: 704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000090")]
		public int characterLimit
		{
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x58A0FB0", Offset = "0x589FBB0", VA = "0x1858A0FB0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x58A1C60", Offset = "0x58A0860", VA = "0x1858A1C60")]
			set
			{
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x00002EF8 File Offset: 0x000010F8
		// (set) Token: 0x060002C2 RID: 706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000091")]
		public float pointSize
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x58A13C0", Offset = "0x589FFC0", VA = "0x1858A13C0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x58A26D0", Offset = "0x58A12D0", VA = "0x1858A26D0")]
			set
			{
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060002C4 RID: 708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000092")]
		public TMP_FontAsset fontAsset
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x58A10F0", Offset = "0x589FCF0", VA = "0x1858A10F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x58A1FA0", Offset = "0x58A0BA0", VA = "0x1858A1FA0")]
			set
			{
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x00002F10 File Offset: 0x00001110
		// (set) Token: 0x060002C6 RID: 710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000093")]
		public bool onFocusSelectAll
		{
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x58A13B0", Offset = "0x589FFB0", VA = "0x1858A13B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x58A2490", Offset = "0x58A1090", VA = "0x1858A2490")]
			set
			{
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x00002F28 File Offset: 0x00001128
		// (set) Token: 0x060002C8 RID: 712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000094")]
		public bool resetOnDeActivation
		{
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x58A1700", Offset = "0x58A0300", VA = "0x1858A1700")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x58A2860", Offset = "0x58A1460", VA = "0x1858A2860")]
			set
			{
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x00002F40 File Offset: 0x00001140
		// (set) Token: 0x060002CA RID: 714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000095")]
		public bool restoreOriginalTextOnEscape
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x58A1710", Offset = "0x58A0310", VA = "0x1858A1710")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x58A2870", Offset = "0x58A1470", VA = "0x1858A2870")]
			set
			{
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060002CB RID: 715 RVA: 0x00002F58 File Offset: 0x00001158
		// (set) Token: 0x060002CC RID: 716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000096")]
		public bool isRichTextEditingAllowed
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x58A12C0", Offset = "0x589FEC0", VA = "0x1858A12C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x58A21D0", Offset = "0x58A0DD0", VA = "0x1858A21D0")]
			set
			{
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060002CD RID: 717 RVA: 0x00002F70 File Offset: 0x00001170
		// (set) Token: 0x060002CE RID: 718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000097")]
		public TMP_InputField.ContentType contentType
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x58A10D0", Offset = "0x589FCD0", VA = "0x1858A10D0")]
			get
			{
				return TMP_InputField.ContentType.Standard;
			}
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x58A1D90", Offset = "0x58A0990", VA = "0x1858A1D90")]
			set
			{
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060002CF RID: 719 RVA: 0x00002F88 File Offset: 0x00001188
		// (set) Token: 0x060002D0 RID: 720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000098")]
		public TMP_InputField.LineType lineType
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x56B9DE0", Offset = "0x56B89E0", VA = "0x1856B9DE0")]
			get
			{
				return TMP_InputField.LineType.SingleLine;
			}
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x58A22C0", Offset = "0x58A0EC0", VA = "0x1858A22C0")]
			set
			{
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x00002FA0 File Offset: 0x000011A0
		// (set) Token: 0x060002D2 RID: 722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000099")]
		public int lineLimit
		{
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x58A12D0", Offset = "0x589FED0", VA = "0x1858A12D0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x58A2250", Offset = "0x58A0E50", VA = "0x1858A2250")]
			set
			{
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x00002FB8 File Offset: 0x000011B8
		// (set) Token: 0x060002D4 RID: 724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009A")]
		public TMP_InputField.InputType inputType
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x58A1290", Offset = "0x589FE90", VA = "0x1858A1290")]
			get
			{
				return TMP_InputField.InputType.Standard;
			}
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x58A20F0", Offset = "0x58A0CF0", VA = "0x1858A20F0")]
			set
			{
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x00002FD0 File Offset: 0x000011D0
		// (set) Token: 0x060002D6 RID: 726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009B")]
		public TouchScreenKeyboardType keyboardType
		{
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x56B9D90", Offset = "0x56B8990", VA = "0x1856B9D90")]
			get
			{
				return TouchScreenKeyboardType.Default;
			}
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x58A21E0", Offset = "0x58A0DE0", VA = "0x1858A21E0")]
			set
			{
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x00002FE8 File Offset: 0x000011E8
		// (set) Token: 0x060002D8 RID: 728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009C")]
		public TMP_InputField.CharacterValidation characterValidation
		{
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x58A0FC0", Offset = "0x589FBC0", VA = "0x1858A0FC0")]
			get
			{
				return TMP_InputField.CharacterValidation.None;
			}
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x58A1D10", Offset = "0x58A0910", VA = "0x1858A1D10")]
			set
			{
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060002DA RID: 730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009D")]
		public TMP_InputValidator inputValidator
		{
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x58A12A0", Offset = "0x589FEA0", VA = "0x1858A12A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x58A2160", Offset = "0x58A0D60", VA = "0x1858A2160")]
			set
			{
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060002DB RID: 731 RVA: 0x00003000 File Offset: 0x00001200
		// (set) Token: 0x060002DC RID: 732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009E")]
		public bool readOnly
		{
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x58A16F0", Offset = "0x58A02F0", VA = "0x1858A16F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x58A2850", Offset = "0x58A1450", VA = "0x1858A2850")]
			set
			{
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060002DD RID: 733 RVA: 0x00003018 File Offset: 0x00001218
		// (set) Token: 0x060002DE RID: 734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009F")]
		public bool richText
		{
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x58A1720", Offset = "0x58A0320", VA = "0x1858A1720")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x58A2880", Offset = "0x58A1480", VA = "0x1858A2880")]
			set
			{
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060002DF RID: 735 RVA: 0x00003030 File Offset: 0x00001230
		[Token(Token = "0x170000A0")]
		public bool multiLine
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x58A1390", Offset = "0x589FF90", VA = "0x1858A1390")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x00003048 File Offset: 0x00001248
		// (set) Token: 0x060002E1 RID: 737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A1")]
		public char asteriskChar
		{
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x58A0E80", Offset = "0x589FA80", VA = "0x1858A0E80")]
			get
			{
				return '\0';
			}
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x58A18B0", Offset = "0x58A04B0", VA = "0x1858A18B0")]
			set
			{
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x00003060 File Offset: 0x00001260
		[Token(Token = "0x170000A2")]
		public bool wasCanceled
		{
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x58A1860", Offset = "0x58A0460", VA = "0x1858A1860")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x5895500", Offset = "0x5894100", VA = "0x185895500")]
		protected void ClampStringPos(ref int pos)
		{
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x58954A0", Offset = "0x58940A0", VA = "0x1858954A0")]
		protected void ClampCaretPos(ref int pos)
		{
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x00003078 File Offset: 0x00001278
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A3")]
		protected int caretPositionInternal
		{
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x58A0F20", Offset = "0x589FB20", VA = "0x1858A0F20")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x58A19F0", Offset = "0x58A05F0", VA = "0x1858A19F0")]
			set
			{
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x00003090 File Offset: 0x00001290
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A4")]
		protected int stringPositionInternal
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x58A1750", Offset = "0x58A0350", VA = "0x1858A1750")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x58A2E20", Offset = "0x58A1A20", VA = "0x1858A2E20")]
			set
			{
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x000030A8 File Offset: 0x000012A8
		// (set) Token: 0x060002EA RID: 746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A5")]
		protected int caretSelectPositionInternal
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x58A0F60", Offset = "0x589FB60", VA = "0x1858A0F60")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x58A1B70", Offset = "0x58A0770", VA = "0x1858A1B70")]
			set
			{
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060002EB RID: 747 RVA: 0x000030C0 File Offset: 0x000012C0
		// (set) Token: 0x060002EC RID: 748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A6")]
		protected int stringSelectPositionInternal
		{
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x58A1790", Offset = "0x58A0390", VA = "0x1858A1790")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x58A2F50", Offset = "0x58A1B50", VA = "0x1858A2F50")]
			set
			{
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060002ED RID: 749 RVA: 0x000030D8 File Offset: 0x000012D8
		[Token(Token = "0x170000A7")]
		private new bool hasSelection
		{
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x58A1100", Offset = "0x589FD00", VA = "0x1858A1100")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060002EE RID: 750 RVA: 0x000030F0 File Offset: 0x000012F0
		// (set) Token: 0x060002EF RID: 751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A8")]
		public int caretPosition
		{
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x58A0F60", Offset = "0x589FB60", VA = "0x1858A0F60")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x58A1A50", Offset = "0x58A0650", VA = "0x1858A1A50")]
			set
			{
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x00003108 File Offset: 0x00001308
		// (set) Token: 0x060002F1 RID: 753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A9")]
		public int selectionAnchorPosition
		{
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x58A0F20", Offset = "0x589FB20", VA = "0x1858A0F20")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x58A29A0", Offset = "0x58A15A0", VA = "0x1858A29A0")]
			set
			{
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x00003120 File Offset: 0x00001320
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AA")]
		public int selectionFocusPosition
		{
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x58A0F60", Offset = "0x589FB60", VA = "0x1858A0F60")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x58A2AB0", Offset = "0x58A16B0", VA = "0x1858A2AB0")]
			set
			{
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x00003138 File Offset: 0x00001338
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AB")]
		public int stringPosition
		{
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x58A1790", Offset = "0x58A0390", VA = "0x1858A1790")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x58A2E70", Offset = "0x58A1A70", VA = "0x1858A2E70")]
			set
			{
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x00003150 File Offset: 0x00001350
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AC")]
		public int selectionStringAnchorPosition
		{
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x58A1750", Offset = "0x58A0350", VA = "0x1858A1750")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x58A2B50", Offset = "0x58A1750", VA = "0x1858A2B50")]
			set
			{
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x00003168 File Offset: 0x00001368
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AD")]
		public int selectionStringFocusPosition
		{
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x58A1790", Offset = "0x58A0390", VA = "0x1858A1790")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x58A2BE0", Offset = "0x58A17E0", VA = "0x1858A2BE0")]
			set
			{
			}
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x589C6A0", Offset = "0x589B2A0", VA = "0x18589C6A0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x589BE30", Offset = "0x589AA30", VA = "0x18589BE30", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x589BA60", Offset = "0x589A660", VA = "0x18589BA60")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x5895430", Offset = "0x5894030", VA = "0x185895430")]
		private IEnumerator CaretBlink()
		{
			return null;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x589F0E0", Offset = "0x589DCE0", VA = "0x18589F0E0")]
		private void SetCaretVisible()
		{
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x589F010", Offset = "0x589DC10", VA = "0x18589F010")]
		private void SetCaretActive()
		{
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x589D4A0", Offset = "0x589C0A0", VA = "0x18589D4A0")]
		protected void OnFocus()
		{
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x589EB50", Offset = "0x589D750", VA = "0x18589EB50")]
		protected void SelectAll()
		{
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x589AE50", Offset = "0x5899A50", VA = "0x18589AE50")]
		public void MoveTextEnd(bool shift)
		{
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x589B010", Offset = "0x5899C10", VA = "0x18589B010")]
		public void MoveTextStart(bool shift)
		{
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000304")]
		[Address(RVA = "0x589B1A0", Offset = "0x5899DA0", VA = "0x18589B1A0")]
		public void MoveToEndOfLine(bool shift, bool ctrl)
		{
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x589B460", Offset = "0x589A060", VA = "0x18589B460")]
		public void MoveToStartOfLine(bool shift, bool ctrl)
		{
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000306 RID: 774 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000307 RID: 775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AE")]
		private static string clipboard
		{
			[Token(Token = "0x6000306")]
			[Address(RVA = "0x58A0FD0", Offset = "0x589FBD0", VA = "0x1858A0FD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000307")]
			[Address(RVA = "0x58A1D80", Offset = "0x58A0980", VA = "0x1858A1D80")]
			set
			{
			}
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00003180 File Offset: 0x00001380
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x5897C50", Offset = "0x5896850", VA = "0x185897C50")]
		private bool InPlaceEditing()
		{
			return default(bool);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x589FEC0", Offset = "0x589EAC0", VA = "0x18589FEC0")]
		private void UpdateStringPositionFromKeyboard()
		{
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x5898330", Offset = "0x5896F30", VA = "0x185898330", Slot = "62")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00003198 File Offset: 0x00001398
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x5898F80", Offset = "0x5897B80", VA = "0x185898F80")]
		private bool MayDrag(PointerEventData eventData)
		{
			return default(bool);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x589BD90", Offset = "0x589A990", VA = "0x18589BD90", Slot = "63")]
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x589C1C0", Offset = "0x589ADC0", VA = "0x18589C1C0", Slot = "64")]
		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x58990B0", Offset = "0x5897CB0", VA = "0x1858990B0")]
		private IEnumerator MouseDragOutsideRect(PointerEventData eventData)
		{
			return null;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x589CEF0", Offset = "0x589BAF0", VA = "0x18589CEF0", Slot = "65")]
		public virtual void OnEndDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x589D4F0", Offset = "0x589C0F0", VA = "0x18589D4F0", Slot = "34")]
		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x06000311 RID: 785 RVA: 0x000031B0 File Offset: 0x000013B0
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x5897EC0", Offset = "0x5896AC0", VA = "0x185897EC0")]
		protected TMP_InputField.EditState KeyPressed(Event evt)
		{
			return TMP_InputField.EditState.Continue;
		}

		// Token: 0x06000312 RID: 786 RVA: 0x000031C8 File Offset: 0x000013C8
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x5897EA0", Offset = "0x5896AA0", VA = "0x185897EA0", Slot = "66")]
		protected virtual bool IsValidChar(char c)
		{
			return default(bool);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x589E9D0", Offset = "0x589D5D0", VA = "0x18589E9D0")]
		public void ProcessEvent(Event e)
		{
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x589E1D0", Offset = "0x589CDD0", VA = "0x18589E1D0", Slot = "67")]
		public virtual void OnUpdateSelected(BaseEventData eventData)
		{
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x589DE10", Offset = "0x589CA10", VA = "0x18589DE10", Slot = "68")]
		public virtual void OnScroll(PointerEventData eventData)
		{
		}

		// Token: 0x06000316 RID: 790 RVA: 0x000031E0 File Offset: 0x000013E0
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x5897980", Offset = "0x5896580", VA = "0x185897980")]
		private float GetScrollPositionRelativeToViewport()
		{
			return 0f;
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x5897AE0", Offset = "0x58966E0", VA = "0x185897AE0")]
		private string GetSelectedString()
		{
			return null;
		}

		// Token: 0x06000318 RID: 792 RVA: 0x000031F8 File Offset: 0x000013F8
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x5896110", Offset = "0x5894D10", VA = "0x185896110")]
		private int FindNextWordBegin()
		{
			return 0;
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x589A630", Offset = "0x5899230", VA = "0x18589A630")]
		private void MoveRight(bool shift, bool ctrl)
		{
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00003210 File Offset: 0x00001410
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x5896230", Offset = "0x5894E30", VA = "0x185896230")]
		private int FindPrevWordBegin()
		{
			return 0;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x5899490", Offset = "0x5898090", VA = "0x185899490")]
		private void MoveLeft(bool shift, bool ctrl)
		{
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00003228 File Offset: 0x00001428
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x5898CE0", Offset = "0x58978E0", VA = "0x185898CE0")]
		private int LineUpCharacterPosition(int originalPos, bool goToFirstChar)
		{
			return 0;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00003240 File Offset: 0x00001440
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x5898A90", Offset = "0x5897690", VA = "0x185898A90")]
		private int LineDownCharacterPosition(int originalPos, bool goToLastChar)
		{
			return 0;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00003258 File Offset: 0x00001458
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x589E6B0", Offset = "0x589D2B0", VA = "0x18589E6B0")]
		private int PageUpCharacterPosition(int originalPos, bool goToFirstChar)
		{
			return 0;
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00003270 File Offset: 0x00001470
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x589E3B0", Offset = "0x589CFB0", VA = "0x18589E3B0")]
		private int PageDownCharacterPosition(int originalPos, bool goToLastChar)
		{
			return 0;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x5899480", Offset = "0x5898080", VA = "0x185899480")]
		private void MoveDown(bool shift)
		{
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x5899140", Offset = "0x5897D40", VA = "0x185899140")]
		private void MoveDown(bool shift, bool goToLastChar)
		{
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x589B730", Offset = "0x589A330", VA = "0x18589B730")]
		private void MoveUp(bool shift)
		{
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x589B740", Offset = "0x589A340", VA = "0x18589B740")]
		private void MoveUp(bool shift, bool goToFirstChar)
		{
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x589A620", Offset = "0x5899220", VA = "0x18589A620")]
		private void MovePageUp(bool shift)
		{
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x589A150", Offset = "0x5898D50", VA = "0x18589A150")]
		private void MovePageUp(bool shift, bool goToFirstChar)
		{
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x589A140", Offset = "0x5898D40", VA = "0x18589A140")]
		private void MovePageDown(bool shift)
		{
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x5899C50", Offset = "0x5898850", VA = "0x185899C50")]
		private void MovePageDown(bool shift, bool goToLastChar)
		{
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x5895C70", Offset = "0x5894870", VA = "0x185895C70")]
		private void Delete()
		{
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x5895950", Offset = "0x5894550", VA = "0x185895950")]
		private void DeleteKey()
		{
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x5894FF0", Offset = "0x5893BF0", VA = "0x185894FF0")]
		private void Backspace()
		{
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x58942F0", Offset = "0x5892EF0", VA = "0x1858942F0", Slot = "69")]
		protected virtual void Append(string input)
		{
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x5894390", Offset = "0x5892F90", VA = "0x185894390", Slot = "70")]
		protected virtual void Append(char input)
		{
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x5897D00", Offset = "0x5896900", VA = "0x185897D00")]
		private void Insert(char c)
		{
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x58A01D0", Offset = "0x589EDD0", VA = "0x1858A01D0")]
		private void UpdateTouchKeyboardFromEditChanges()
		{
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x589EEF0", Offset = "0x589DAF0", VA = "0x18589EEF0")]
		private void SendOnValueChangedAndUpdateLabel()
		{
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x589EF50", Offset = "0x589DB50", VA = "0x18589EF50")]
		private void SendOnValueChanged()
		{
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x589EBC0", Offset = "0x589D7C0", VA = "0x18589EBC0")]
		protected void SendOnEndEdit()
		{
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x589EDB0", Offset = "0x589D9B0", VA = "0x18589EDB0")]
		protected void SendOnSubmit()
		{
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x589ED60", Offset = "0x589D960", VA = "0x18589ED60")]
		protected void SendOnFocus()
		{
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x589ED10", Offset = "0x589D910", VA = "0x18589ED10")]
		protected void SendOnFocusLost()
		{
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x589EE00", Offset = "0x589DA00", VA = "0x18589EE00")]
		protected void SendOnTextSelection()
		{
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x589EC10", Offset = "0x589D810", VA = "0x18589EC10")]
		protected void SendOnEndTextSelection()
		{
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x589EFA0", Offset = "0x589DBA0", VA = "0x18589EFA0")]
		protected void SendTouchScreenKeyboardStatusChanged()
		{
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x589F750", Offset = "0x589E350", VA = "0x18589F750")]
		protected void UpdateLabel()
		{
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x589FDA0", Offset = "0x589E9A0", VA = "0x18589FDA0")]
		private void UpdateScrollbar()
		{
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x589E080", Offset = "0x589CC80", VA = "0x18589E080")]
		private void OnScrollbarValueChange(float value)
		{
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void UpdateMaskRegions()
		{
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x5894080", Offset = "0x5892C80", VA = "0x185894080")]
		private void AdjustTextPositionRelativeToViewport(float relativePosition)
		{
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00003288 File Offset: 0x00001488
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x5897880", Offset = "0x5896480", VA = "0x185897880")]
		private int GetCaretPositionFromStringIndex(int stringIndex)
		{
			return 0;
		}

		// Token: 0x0600033E RID: 830 RVA: 0x000032A0 File Offset: 0x000014A0
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x5897900", Offset = "0x5896500", VA = "0x185897900")]
		private int GetMinCaretPositionFromStringIndex(int stringIndex)
		{
			return 0;
		}

		// Token: 0x0600033F RID: 831 RVA: 0x000032B8 File Offset: 0x000014B8
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x5897880", Offset = "0x5896480", VA = "0x185897880")]
		private int GetMaxCaretPositionFromStringIndex(int stringIndex)
		{
			return 0;
		}

		// Token: 0x06000340 RID: 832 RVA: 0x000032D0 File Offset: 0x000014D0
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x5897BC0", Offset = "0x58967C0", VA = "0x185897BC0")]
		private int GetStringIndexFromCaretPosition(int caretPosition)
		{
			return 0;
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x5896330", Offset = "0x5894F30", VA = "0x185896330")]
		public void ForceLabelUpdate()
		{
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x5898F30", Offset = "0x5897B30", VA = "0x185898F30")]
		private void MarkGeometryAsDirty()
		{
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x589E9E0", Offset = "0x589D5E0", VA = "0x18589E9E0", Slot = "71")]
		public virtual void Rebuild(CanvasUpdate update)
		{
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "72")]
		public virtual void LayoutComplete()
		{
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000345")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "73")]
		public virtual void GraphicUpdateComplete()
		{
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000346")]
		[Address(RVA = "0x589F690", Offset = "0x589E290", VA = "0x18589F690")]
		private void UpdateGeometry()
		{
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000347")]
		[Address(RVA = "0x58948B0", Offset = "0x58934B0", VA = "0x1858948B0")]
		private void AssignPositioningIfNeeded()
		{
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000348")]
		[Address(RVA = "0x589CF20", Offset = "0x589BB20", VA = "0x18589CF20")]
		private void OnFillVBO(Mesh vbo)
		{
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000349")]
		[Address(RVA = "0x5896340", Offset = "0x5894F40", VA = "0x185896340")]
		private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset)
		{
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034A")]
		[Address(RVA = "0x5895540", Offset = "0x5894140", VA = "0x185895540")]
		private void CreateCursorVerts()
		{
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034B")]
		[Address(RVA = "0x5896E90", Offset = "0x5895A90", VA = "0x185896E90")]
		private void GenerateHightlight(VertexHelper vbo, Vector2 roundingOffset)
		{
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x58938B0", Offset = "0x58924B0", VA = "0x1858938B0")]
		private void AdjustRectTransformRelativeToViewport(Vector2 startPosition, float height, bool isCharVisible)
		{
		}

		// Token: 0x0600034D RID: 845 RVA: 0x000032E8 File Offset: 0x000014E8
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x58A0220", Offset = "0x589EE20", VA = "0x1858A0220")]
		protected char Validate(string text, int pos, char ch)
		{
			return '\0';
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034E")]
		[Address(RVA = "0x5893770", Offset = "0x5892370", VA = "0x185893770")]
		public void ActivateInputField()
		{
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034F")]
		[Address(RVA = "0x58932A0", Offset = "0x5891EA0", VA = "0x1858932A0")]
		private void ActivateInputFieldInternal()
		{
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000350")]
		[Address(RVA = "0x589E0C0", Offset = "0x589CCC0", VA = "0x18589E0C0", Slot = "38")]
		public override void OnSelect(BaseEventData eventData)
		{
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000351")]
		[Address(RVA = "0x589D4C0", Offset = "0x589C0C0", VA = "0x18589D4C0", Slot = "74")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000352")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void OnControlClick()
		{
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000353")]
		[Address(RVA = "0x589EAA0", Offset = "0x589D6A0", VA = "0x18589EAA0")]
		public void ReleaseSelection()
		{
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000354")]
		[Address(RVA = "0x5895700", Offset = "0x5894300", VA = "0x185895700")]
		public void DeactivateInputField(bool clearSelection = false)
		{
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000355")]
		[Address(RVA = "0x589BDC0", Offset = "0x589A9C0", VA = "0x18589BDC0", Slot = "39")]
		public override void OnDeselect(BaseEventData eventData)
		{
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000356")]
		[Address(RVA = "0x589E120", Offset = "0x589CD20", VA = "0x18589E120", Slot = "75")]
		public virtual void OnSubmit(BaseEventData eventData)
		{
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000357")]
		[Address(RVA = "0x5895FA0", Offset = "0x5894BA0", VA = "0x185895FA0")]
		private void EnforceContentType()
		{
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000358")]
		[Address(RVA = "0x589F3D0", Offset = "0x589DFD0", VA = "0x18589F3D0")]
		private void SetTextComponentWrapMode()
		{
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000359")]
		[Address(RVA = "0x589F340", Offset = "0x589DF40", VA = "0x18589F340")]
		private void SetTextComponentRichTextMode()
		{
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035A")]
		[Address(RVA = "0x589F600", Offset = "0x589E200", VA = "0x18589F600")]
		private void SetToCustomIfContentTypeIsNot(params TMP_InputField.ContentType[] allowedContentTypes)
		{
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035B")]
		[Address(RVA = "0x589F660", Offset = "0x589E260", VA = "0x18589F660")]
		private void SetToCustom()
		{
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035C")]
		[Address(RVA = "0x589F660", Offset = "0x589E260", VA = "0x18589F660")]
		private void SetToCustom(TMP_InputField.CharacterValidation characterValidation)
		{
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035D")]
		[Address(RVA = "0x5895F70", Offset = "0x5894B70", VA = "0x185895F70", Slot = "28")]
		protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
		{
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035E")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "76")]
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035F")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "77")]
		public virtual void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000360 RID: 864 RVA: 0x00003300 File Offset: 0x00001500
		[Token(Token = "0x170000AF")]
		public virtual float minWidth
		{
			[Token(Token = "0x6000360")]
			[Address(RVA = "0x738E20", Offset = "0x737A20", VA = "0x180738E20", Slot = "78")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000361 RID: 865 RVA: 0x00003318 File Offset: 0x00001518
		[Token(Token = "0x170000B0")]
		public virtual float preferredWidth
		{
			[Token(Token = "0x6000361")]
			[Address(RVA = "0x58A1560", Offset = "0x58A0160", VA = "0x1858A1560", Slot = "79")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000362 RID: 866 RVA: 0x00003330 File Offset: 0x00001530
		[Token(Token = "0x170000B1")]
		public virtual float flexibleWidth
		{
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x2251AE0", Offset = "0x22506E0", VA = "0x182251AE0", Slot = "80")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000363 RID: 867 RVA: 0x00003348 File Offset: 0x00001548
		[Token(Token = "0x170000B2")]
		public virtual float minHeight
		{
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x738E20", Offset = "0x737A20", VA = "0x180738E20", Slot = "81")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000364 RID: 868 RVA: 0x00003360 File Offset: 0x00001560
		[Token(Token = "0x170000B3")]
		public virtual float preferredHeight
		{
			[Token(Token = "0x6000364")]
			[Address(RVA = "0x58A13D0", Offset = "0x589FFD0", VA = "0x1858A13D0", Slot = "82")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000365 RID: 869 RVA: 0x00003378 File Offset: 0x00001578
		[Token(Token = "0x170000B4")]
		public virtual float flexibleHeight
		{
			[Token(Token = "0x6000365")]
			[Address(RVA = "0x2251AE0", Offset = "0x22506E0", VA = "0x182251AE0", Slot = "83")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000366 RID: 870 RVA: 0x00003390 File Offset: 0x00001590
		[Token(Token = "0x170000B5")]
		public virtual int layoutPriority
		{
			[Token(Token = "0x6000366")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "84")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000367")]
		[Address(RVA = "0x589F230", Offset = "0x589DE30", VA = "0x18589F230")]
		public void SetGlobalPointSize(float pointSize)
		{
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000368")]
		[Address(RVA = "0x589F120", Offset = "0x589DD20", VA = "0x18589F120")]
		public void SetGlobalFontAsset(TMP_FontAsset fontAsset)
		{
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600036A")]
		[Address(RVA = "0x589F680", Offset = "0x589E280", VA = "0x18589F680", Slot = "48")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0xF8")]
		protected TouchScreenKeyboard m_SoftKeyboard;

		// Token: 0x0400023E RID: 574
		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly char[] kSeparators;

		// Token: 0x0400023F RID: 575
		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x100")]
		protected RectTransform m_RectTransform;

		// Token: 0x04000240 RID: 576
		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		protected RectTransform m_TextViewport;

		// Token: 0x04000241 RID: 577
		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x110")]
		protected RectMask2D m_TextComponentRectMask;

		// Token: 0x04000242 RID: 578
		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x118")]
		protected RectMask2D m_TextViewportRectMask;

		// Token: 0x04000243 RID: 579
		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x120")]
		private Rect m_CachedViewportRect;

		// Token: 0x04000244 RID: 580
		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		protected TMP_Text m_TextComponent;

		// Token: 0x04000245 RID: 581
		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x138")]
		protected RectTransform m_TextComponentRectTransform;

		// Token: 0x04000246 RID: 582
		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		protected Graphic m_Placeholder;

		// Token: 0x04000247 RID: 583
		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		protected Scrollbar m_VerticalScrollbar;

		// Token: 0x04000248 RID: 584
		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		protected TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler;

		// Token: 0x04000249 RID: 585
		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0x158")]
		private bool m_IsDrivenByLayoutComponents;

		// Token: 0x0400024A RID: 586
		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private LayoutGroup m_LayoutGroup;

		// Token: 0x0400024B RID: 587
		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x168")]
		private IScrollHandler m_IScrollHandlerParent;

		// Token: 0x0400024C RID: 588
		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x170")]
		private float m_ScrollPosition;

		// Token: 0x0400024D RID: 589
		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x174")]
		[SerializeField]
		protected float m_ScrollSensitivity;

		// Token: 0x0400024E RID: 590
		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private TMP_InputField.ContentType m_ContentType;

		// Token: 0x0400024F RID: 591
		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0x17C")]
		[SerializeField]
		private TMP_InputField.InputType m_InputType;

		// Token: 0x04000250 RID: 592
		[Token(Token = "0x4000250")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private char m_AsteriskChar;

		// Token: 0x04000251 RID: 593
		[Token(Token = "0x4000251")]
		[FieldOffset(Offset = "0x184")]
		[SerializeField]
		private TouchScreenKeyboardType m_KeyboardType;

		// Token: 0x04000252 RID: 594
		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private TMP_InputField.LineType m_LineType;

		// Token: 0x04000253 RID: 595
		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0x18C")]
		[SerializeField]
		private bool m_HideMobileInput;

		// Token: 0x04000254 RID: 596
		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0x18D")]
		[SerializeField]
		private bool m_HideSoftKeyboard;

		// Token: 0x04000255 RID: 597
		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private TMP_InputField.CharacterValidation m_CharacterValidation;

		// Token: 0x04000256 RID: 598
		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private string m_RegexValue;

		// Token: 0x04000257 RID: 599
		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private float m_GlobalPointSize;

		// Token: 0x04000258 RID: 600
		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0x1A4")]
		[SerializeField]
		private int m_CharacterLimit;

		// Token: 0x04000259 RID: 601
		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private TMP_InputField.SubmitEvent m_OnEndEdit;

		// Token: 0x0400025A RID: 602
		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private TMP_InputField.SubmitEvent m_OnSubmit;

		// Token: 0x0400025B RID: 603
		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private TMP_InputField.SelectionEvent m_OnSelect;

		// Token: 0x0400025C RID: 604
		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private TMP_InputField.SelectionEvent m_OnDeselect;

		// Token: 0x0400025D RID: 605
		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private TMP_InputField.TextSelectionEvent m_OnTextSelection;

		// Token: 0x0400025E RID: 606
		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		private TMP_InputField.TextSelectionEvent m_OnEndTextSelection;

		// Token: 0x0400025F RID: 607
		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		private TMP_InputField.OnChangeEvent m_OnValueChanged;

		// Token: 0x04000260 RID: 608
		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		private TMP_InputField.TouchScreenKeyboardEvent m_OnTouchScreenKeyboardStatusChanged;

		// Token: 0x04000261 RID: 609
		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		private TMP_InputField.OnValidateInput m_OnValidateInput;

		// Token: 0x04000262 RID: 610
		[Token(Token = "0x4000262")]
		[FieldOffset(Offset = "0x1F0")]
		[SerializeField]
		private Color m_CaretColor;

		// Token: 0x04000263 RID: 611
		[Token(Token = "0x4000263")]
		[FieldOffset(Offset = "0x200")]
		[SerializeField]
		private bool m_CustomCaretColor;

		// Token: 0x04000264 RID: 612
		[Token(Token = "0x4000264")]
		[FieldOffset(Offset = "0x204")]
		[SerializeField]
		private Color m_SelectionColor;

		// Token: 0x04000265 RID: 613
		[Token(Token = "0x4000265")]
		[FieldOffset(Offset = "0x218")]
		[SerializeField]
		[TextArea(5, 10)]
		protected string m_Text;

		// Token: 0x04000266 RID: 614
		[Token(Token = "0x4000266")]
		[FieldOffset(Offset = "0x220")]
		[SerializeField]
		[Range(0f, 4f)]
		private float m_CaretBlinkRate;

		// Token: 0x04000267 RID: 615
		[Token(Token = "0x4000267")]
		[FieldOffset(Offset = "0x224")]
		[SerializeField]
		[Range(1f, 5f)]
		private int m_CaretWidth;

		// Token: 0x04000268 RID: 616
		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x228")]
		[SerializeField]
		private bool m_ReadOnly;

		// Token: 0x04000269 RID: 617
		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x229")]
		[SerializeField]
		private bool m_RichText;

		// Token: 0x0400026A RID: 618
		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x22C")]
		protected int m_StringPosition;

		// Token: 0x0400026B RID: 619
		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x230")]
		protected int m_StringSelectPosition;

		// Token: 0x0400026C RID: 620
		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x234")]
		protected int m_CaretPosition;

		// Token: 0x0400026D RID: 621
		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0x238")]
		protected int m_CaretSelectPosition;

		// Token: 0x0400026E RID: 622
		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0x240")]
		private RectTransform caretRectTrans;

		// Token: 0x0400026F RID: 623
		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0x248")]
		protected UIVertex[] m_CursorVerts;

		// Token: 0x04000270 RID: 624
		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x250")]
		private CanvasRenderer m_CachedInputRenderer;

		// Token: 0x04000271 RID: 625
		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x258")]
		private Vector2 m_LastPosition;

		// Token: 0x04000272 RID: 626
		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0x260")]
		[NonSerialized]
		protected Mesh m_Mesh;

		// Token: 0x04000273 RID: 627
		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0x268")]
		private bool m_AllowInput;

		// Token: 0x04000274 RID: 628
		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0x269")]
		private bool m_ShouldActivateNextUpdate;

		// Token: 0x04000275 RID: 629
		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0x26A")]
		private bool m_UpdateDrag;

		// Token: 0x04000276 RID: 630
		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0x26B")]
		private bool m_DragPositionOutOfBounds;

		// Token: 0x04000277 RID: 631
		[Token(Token = "0x4000277")]
		private const float kHScrollSpeed = 0.05f;

		// Token: 0x04000278 RID: 632
		[Token(Token = "0x4000278")]
		private const float kVScrollSpeed = 0.1f;

		// Token: 0x04000279 RID: 633
		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0x26C")]
		protected bool m_CaretVisible;

		// Token: 0x0400027A RID: 634
		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x270")]
		private Coroutine m_BlinkCoroutine;

		// Token: 0x0400027B RID: 635
		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x278")]
		private float m_BlinkStartTime;

		// Token: 0x0400027C RID: 636
		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x280")]
		private Coroutine m_DragCoroutine;

		// Token: 0x0400027D RID: 637
		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x288")]
		private string m_OriginalText;

		// Token: 0x0400027E RID: 638
		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x290")]
		private bool m_WasCanceled;

		// Token: 0x0400027F RID: 639
		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x291")]
		private bool m_HasDoneFocusTransition;

		// Token: 0x04000280 RID: 640
		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x298")]
		private WaitForSecondsRealtime m_WaitForSecondsRealtime;

		// Token: 0x04000281 RID: 641
		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x2A0")]
		private bool m_PreventCallback;

		// Token: 0x04000282 RID: 642
		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x2A1")]
		private bool m_TouchKeyboardAllowsInPlaceEditing;

		// Token: 0x04000283 RID: 643
		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0x2A2")]
		private bool m_IsTextComponentUpdateRequired;

		// Token: 0x04000284 RID: 644
		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0x2A3")]
		private bool m_isLastKeyBackspace;

		// Token: 0x04000285 RID: 645
		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0x2A4")]
		private float m_PointerDownClickStartTime;

		// Token: 0x04000286 RID: 646
		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x2A8")]
		private float m_KeyDownStartTime;

		// Token: 0x04000287 RID: 647
		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0x2AC")]
		private float m_DoubleClickDelay;

		// Token: 0x04000288 RID: 648
		[Token(Token = "0x4000288")]
		private const string kEmailSpecialCharacters = "!#$%&'*+-/=?^_`{|}~";

		// Token: 0x04000289 RID: 649
		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0x2B0")]
		private bool m_IsCompositionActive;

		// Token: 0x0400028A RID: 650
		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x2B1")]
		private bool m_ShouldUpdateIMEWindowPosition;

		// Token: 0x0400028B RID: 651
		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0x2B4")]
		private int m_PreviousIMEInsertionLine;

		// Token: 0x0400028C RID: 652
		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0x2B8")]
		[SerializeField]
		protected TMP_FontAsset m_GlobalFontAsset;

		// Token: 0x0400028D RID: 653
		[Token(Token = "0x400028D")]
		[FieldOffset(Offset = "0x2C0")]
		[SerializeField]
		protected bool m_OnFocusSelectAll;

		// Token: 0x0400028E RID: 654
		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0x2C1")]
		protected bool m_isSelectAll;

		// Token: 0x0400028F RID: 655
		[Token(Token = "0x400028F")]
		[FieldOffset(Offset = "0x2C2")]
		[SerializeField]
		protected bool m_ResetOnDeActivation;

		// Token: 0x04000290 RID: 656
		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0x2C3")]
		private bool m_SelectionStillActive;

		// Token: 0x04000291 RID: 657
		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0x2C4")]
		private bool m_ReleaseSelection;

		// Token: 0x04000292 RID: 658
		[Token(Token = "0x4000292")]
		[FieldOffset(Offset = "0x2C8")]
		private GameObject m_PreviouslySelectedObject;

		// Token: 0x04000293 RID: 659
		[Token(Token = "0x4000293")]
		[FieldOffset(Offset = "0x2D0")]
		[SerializeField]
		private bool m_RestoreOriginalTextOnEscape;

		// Token: 0x04000294 RID: 660
		[Token(Token = "0x4000294")]
		[FieldOffset(Offset = "0x2D1")]
		[SerializeField]
		protected bool m_isRichTextEditingAllowed;

		// Token: 0x04000295 RID: 661
		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0x2D4")]
		[SerializeField]
		protected int m_LineLimit;

		// Token: 0x04000296 RID: 662
		[Token(Token = "0x4000296")]
		[FieldOffset(Offset = "0x2D8")]
		[SerializeField]
		protected TMP_InputValidator m_InputValidator;

		// Token: 0x04000297 RID: 663
		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0x2E0")]
		private bool m_isSelected;

		// Token: 0x04000298 RID: 664
		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x2E1")]
		private bool m_IsStringPositionDirty;

		// Token: 0x04000299 RID: 665
		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0x2E2")]
		private bool m_IsCaretPositionDirty;

		// Token: 0x0400029A RID: 666
		[Token(Token = "0x400029A")]
		[FieldOffset(Offset = "0x2E3")]
		private bool m_forceRectTransformAdjustment;

		// Token: 0x0400029B RID: 667
		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0x2E8")]
		private Event m_ProcessingEvent;

		// Token: 0x02000054 RID: 84
		[Token(Token = "0x2000054")]
		public enum ContentType
		{
			// Token: 0x0400029D RID: 669
			[Token(Token = "0x400029D")]
			Standard,
			// Token: 0x0400029E RID: 670
			[Token(Token = "0x400029E")]
			Autocorrected,
			// Token: 0x0400029F RID: 671
			[Token(Token = "0x400029F")]
			IntegerNumber,
			// Token: 0x040002A0 RID: 672
			[Token(Token = "0x40002A0")]
			DecimalNumber,
			// Token: 0x040002A1 RID: 673
			[Token(Token = "0x40002A1")]
			Alphanumeric,
			// Token: 0x040002A2 RID: 674
			[Token(Token = "0x40002A2")]
			Name,
			// Token: 0x040002A3 RID: 675
			[Token(Token = "0x40002A3")]
			EmailAddress,
			// Token: 0x040002A4 RID: 676
			[Token(Token = "0x40002A4")]
			Password,
			// Token: 0x040002A5 RID: 677
			[Token(Token = "0x40002A5")]
			Pin,
			// Token: 0x040002A6 RID: 678
			[Token(Token = "0x40002A6")]
			Custom
		}

		// Token: 0x02000055 RID: 85
		[Token(Token = "0x2000055")]
		public enum InputType
		{
			// Token: 0x040002A8 RID: 680
			[Token(Token = "0x40002A8")]
			Standard,
			// Token: 0x040002A9 RID: 681
			[Token(Token = "0x40002A9")]
			AutoCorrect,
			// Token: 0x040002AA RID: 682
			[Token(Token = "0x40002AA")]
			Password
		}

		// Token: 0x02000056 RID: 86
		[Token(Token = "0x2000056")]
		public enum CharacterValidation
		{
			// Token: 0x040002AC RID: 684
			[Token(Token = "0x40002AC")]
			None,
			// Token: 0x040002AD RID: 685
			[Token(Token = "0x40002AD")]
			Digit,
			// Token: 0x040002AE RID: 686
			[Token(Token = "0x40002AE")]
			Integer,
			// Token: 0x040002AF RID: 687
			[Token(Token = "0x40002AF")]
			Decimal,
			// Token: 0x040002B0 RID: 688
			[Token(Token = "0x40002B0")]
			Alphanumeric,
			// Token: 0x040002B1 RID: 689
			[Token(Token = "0x40002B1")]
			Name,
			// Token: 0x040002B2 RID: 690
			[Token(Token = "0x40002B2")]
			Regex,
			// Token: 0x040002B3 RID: 691
			[Token(Token = "0x40002B3")]
			EmailAddress,
			// Token: 0x040002B4 RID: 692
			[Token(Token = "0x40002B4")]
			CustomValidator
		}

		// Token: 0x02000057 RID: 87
		[Token(Token = "0x2000057")]
		public enum LineType
		{
			// Token: 0x040002B6 RID: 694
			[Token(Token = "0x40002B6")]
			SingleLine,
			// Token: 0x040002B7 RID: 695
			[Token(Token = "0x40002B7")]
			MultiLineSubmit,
			// Token: 0x040002B8 RID: 696
			[Token(Token = "0x40002B8")]
			MultiLineNewline
		}

		// Token: 0x02000058 RID: 88
		// (Invoke) Token: 0x0600036C RID: 876
		[Token(Token = "0x2000058")]
		public delegate char OnValidateInput(string text, int charIndex, char addedChar);

		// Token: 0x02000059 RID: 89
		[Token(Token = "0x2000059")]
		[Serializable]
		public class SubmitEvent : UnityEvent<string>
		{
			// Token: 0x0600036F RID: 879 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x58C4530", Offset = "0x58C3130", VA = "0x1858C4530")]
			public SubmitEvent()
			{
			}
		}

		// Token: 0x0200005A RID: 90
		[Token(Token = "0x200005A")]
		[Serializable]
		public class OnChangeEvent : UnityEvent<string>
		{
			// Token: 0x06000370 RID: 880 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x58C13B0", Offset = "0x58BFFB0", VA = "0x1858C13B0")]
			public OnChangeEvent()
			{
			}
		}

		// Token: 0x0200005B RID: 91
		[Token(Token = "0x200005B")]
		[Serializable]
		public class SelectionEvent : UnityEvent<string>
		{
			// Token: 0x06000371 RID: 881 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x58C15D0", Offset = "0x58C01D0", VA = "0x1858C15D0")]
			public SelectionEvent()
			{
			}
		}

		// Token: 0x0200005C RID: 92
		[Token(Token = "0x200005C")]
		[Serializable]
		public class TextSelectionEvent : UnityEvent<string, int, int>
		{
			// Token: 0x06000372 RID: 882 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x58D8230", Offset = "0x58D6E30", VA = "0x1858D8230")]
			public TextSelectionEvent()
			{
			}
		}

		// Token: 0x0200005D RID: 93
		[Token(Token = "0x200005D")]
		[Serializable]
		public class TouchScreenKeyboardEvent : UnityEvent<TouchScreenKeyboard.Status>
		{
			// Token: 0x06000373 RID: 883 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x58D8270", Offset = "0x58D6E70", VA = "0x1858D8270")]
			public TouchScreenKeyboardEvent()
			{
			}
		}

		// Token: 0x0200005E RID: 94
		[Token(Token = "0x200005E")]
		protected enum EditState
		{
			// Token: 0x040002BA RID: 698
			[Token(Token = "0x40002BA")]
			Continue,
			// Token: 0x040002BB RID: 699
			[Token(Token = "0x40002BB")]
			Finish
		}
	}
}
