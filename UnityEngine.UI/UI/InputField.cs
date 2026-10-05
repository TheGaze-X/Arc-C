using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	[AddComponentMenu("UI/Legacy/Input Field", 103)]
	public class InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement
	{
		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000074")]
		private BaseInput input
		{
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x5B62260", Offset = "0x5B60E60", VA = "0x185B62260")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000075")]
		private string compositionString
		{
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x5B62120", Offset = "0x5B60D20", VA = "0x185B62120")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x5B61D40", Offset = "0x5B60940", VA = "0x185B61D40")]
		protected InputField()
		{
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000076")]
		protected Mesh mesh
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x5B62370", Offset = "0x5B60F70", VA = "0x185B62370")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001AA RID: 426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000077")]
		protected TextGenerator cachedInputTextGenerator
		{
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x5B61FB0", Offset = "0x5B60BB0", VA = "0x185B61FB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001AC RID: 428 RVA: 0x000028F8 File Offset: 0x00000AF8
		// (set) Token: 0x060001AB RID: 427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000078")]
		public bool shouldHideMobileInput
		{
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x5B62880", Offset = "0x5B61480", VA = "0x185B62880")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x5B633C0", Offset = "0x5B61FC0", VA = "0x185B633C0")]
			set
			{
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00002910 File Offset: 0x00000B10
		// (set) Token: 0x060001AD RID: 429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000079")]
		public virtual bool shouldActivateOnSelect
		{
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x5B62850", Offset = "0x5B61450", VA = "0x185B62850", Slot = "62")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x59F2680", Offset = "0x59F1280", VA = "0x1859F2680", Slot = "61")]
			set
			{
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700007A")]
		public string text
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x16925E0", Offset = "0x16911E0", VA = "0x1816925E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x5B636D0", Offset = "0x5B622D0", VA = "0x185B636D0")]
			set
			{
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x5B603F0", Offset = "0x5B5EFF0", VA = "0x185B603F0")]
		public void SetTextWithoutNotify(string input)
		{
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x5B60400", Offset = "0x5B5F000", VA = "0x185B60400")]
		private void SetText(string value, bool sendCallback = true)
		{
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00002928 File Offset: 0x00000B28
		[Token(Token = "0x1700007B")]
		public bool isFocused
		{
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x58BF170", Offset = "0x58BDD70", VA = "0x1858BF170")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00002940 File Offset: 0x00000B40
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700007C")]
		public float caretBlinkRate
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x5A21310", Offset = "0x5A1FF10", VA = "0x185A21310")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x5B62920", Offset = "0x5B61520", VA = "0x185B62920")]
			set
			{
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00002958 File Offset: 0x00000B58
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700007D")]
		public int caretWidth
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x56B9D90", Offset = "0x56B8990", VA = "0x1856B9D90")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x5B62B60", Offset = "0x5B61760", VA = "0x185B62B60")]
			set
			{
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700007E")]
		public Text textComponent
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x22F8880", Offset = "0x22F7480", VA = "0x1822F8880")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x5B63410", Offset = "0x5B62010", VA = "0x185B63410")]
			set
			{
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060001BB RID: 443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700007F")]
		public Graphic placeholder
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x22F8840", Offset = "0x22F7440", VA = "0x1822F8840")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x5B63220", Offset = "0x5B61E20", VA = "0x185B63220")]
			set
			{
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001BC RID: 444 RVA: 0x00002970 File Offset: 0x00000B70
		// (set) Token: 0x060001BD RID: 445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000080")]
		public Color caretColor
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x5B62030", Offset = "0x5B60C30", VA = "0x185B62030")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x5B62990", Offset = "0x5B61590", VA = "0x185B62990")]
			set
			{
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00002988 File Offset: 0x00000B88
		// (set) Token: 0x060001BF RID: 447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000081")]
		public bool customCaretColor
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x5B621E0", Offset = "0x5B60DE0", VA = "0x185B621E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x5B62EC0", Offset = "0x5B61AC0", VA = "0x185B62EC0")]
			set
			{
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x000029A0 File Offset: 0x00000BA0
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000082")]
		public Color selectionColor
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x5B62840", Offset = "0x5B61440", VA = "0x185B62840")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x5B632E0", Offset = "0x5B61EE0", VA = "0x185B632E0")]
			set
			{
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000083")]
		public InputField.EndEditEvent onEndEdit
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x55FB9D0", Offset = "0x55FA5D0", VA = "0x1855FB9D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x5B630E0", Offset = "0x5B61CE0", VA = "0x185B630E0")]
			set
			{
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000084")]
		public InputField.SubmitEvent onSubmit
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x4FA1B40", Offset = "0x4FA0740", VA = "0x184FA1B40")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x5B63130", Offset = "0x5B61D30", VA = "0x185B63130")]
			set
			{
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000085")]
		[Obsolete("onValueChange has been renamed to onValueChanged")]
		public InputField.OnChangeEvent onValueChange
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x5080A80", Offset = "0x507F680", VA = "0x185080A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x5B631D0", Offset = "0x5B61DD0", VA = "0x185B631D0")]
			set
			{
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000086")]
		public InputField.OnChangeEvent onValueChanged
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x5080A80", Offset = "0x507F680", VA = "0x185080A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x5B631D0", Offset = "0x5B61DD0", VA = "0x185B631D0")]
			set
			{
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001CA RID: 458 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060001CB RID: 459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000087")]
		public InputField.OnValidateInput onValidateInput
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x1692740", Offset = "0x1691340", VA = "0x181692740")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x5B63180", Offset = "0x5B61D80", VA = "0x185B63180")]
			set
			{
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001CC RID: 460 RVA: 0x000029B8 File Offset: 0x00000BB8
		// (set) Token: 0x060001CD RID: 461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000088")]
		public int characterLimit
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x5B62110", Offset = "0x5B60D10", VA = "0x185B62110")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x5B62BF0", Offset = "0x5B617F0", VA = "0x185B62BF0")]
			set
			{
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001CE RID: 462 RVA: 0x000029D0 File Offset: 0x00000BD0
		// (set) Token: 0x060001CF RID: 463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000089")]
		public InputField.ContentType contentType
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x58923D0", Offset = "0x5890FD0", VA = "0x1858923D0")]
			get
			{
				return InputField.ContentType.Standard;
			}
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x5B62D10", Offset = "0x5B61910", VA = "0x185B62D10")]
			set
			{
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x000029E8 File Offset: 0x00000BE8
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700008A")]
		public InputField.LineType lineType
		{
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x5A12510", Offset = "0x5A11110", VA = "0x185A12510")]
			get
			{
				return InputField.LineType.SingleLine;
			}
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0x5B63000", Offset = "0x5B61C00", VA = "0x185B63000")]
			set
			{
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00002A00 File Offset: 0x00000C00
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700008B")]
		public InputField.InputType inputType
		{
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x4E843D0", Offset = "0x4E82FD0", VA = "0x184E843D0")]
			get
			{
				return InputField.InputType.Standard;
			}
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x5B62F20", Offset = "0x5B61B20", VA = "0x185B62F20")]
			set
			{
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008C")]
		public TouchScreenKeyboard touchScreenKeyboard
		{
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x4D6C800", Offset = "0x4D6B400", VA = "0x184D6C800")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00002A18 File Offset: 0x00000C18
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700008D")]
		public TouchScreenKeyboardType keyboardType
		{
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x5B62360", Offset = "0x5B60F60", VA = "0x185B62360")]
			get
			{
				return TouchScreenKeyboardType.Default;
			}
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x5B62F90", Offset = "0x5B61B90", VA = "0x185B62F90")]
			set
			{
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x00002A30 File Offset: 0x00000C30
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700008E")]
		public InputField.CharacterValidation characterValidation
		{
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x58881E0", Offset = "0x5886DE0", VA = "0x1858881E0")]
			get
			{
				return InputField.CharacterValidation.None;
			}
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x5B62CA0", Offset = "0x5B618A0", VA = "0x185B62CA0")]
			set
			{
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x00002A48 File Offset: 0x00000C48
		// (set) Token: 0x060001DA RID: 474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700008F")]
		public bool readOnly
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x5B62830", Offset = "0x5B61430", VA = "0x185B62830")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x59F2650", Offset = "0x59F1250", VA = "0x1859F2650")]
			set
			{
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001DB RID: 475 RVA: 0x00002A60 File Offset: 0x00000C60
		[Token(Token = "0x17000090")]
		public bool multiLine
		{
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x5B62420", Offset = "0x5B61020", VA = "0x185B62420")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001DC RID: 476 RVA: 0x00002A78 File Offset: 0x00000C78
		// (set) Token: 0x060001DD RID: 477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000091")]
		public char asteriskChar
		{
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x5B61FA0", Offset = "0x5B60BA0", VA = "0x185B61FA0")]
			get
			{
				return '\0';
			}
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x5B628C0", Offset = "0x5B614C0", VA = "0x185B628C0")]
			set
			{
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001DE RID: 478 RVA: 0x00002A90 File Offset: 0x00000C90
		[Token(Token = "0x17000092")]
		public bool wasCanceled
		{
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x5B628B0", Offset = "0x5B614B0", VA = "0x185B628B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x5B59AF0", Offset = "0x5B586F0", VA = "0x185B59AF0")]
		protected void ClampPos(ref int pos)
		{
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x00002AA8 File Offset: 0x00000CA8
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000093")]
		protected int caretPositionInternal
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x5B620B0", Offset = "0x5B60CB0", VA = "0x185B620B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x5B62A00", Offset = "0x5B61600", VA = "0x185B62A00")]
			set
			{
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x00002AC0 File Offset: 0x00000CC0
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000094")]
		protected int caretSelectPositionInternal
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x5B620E0", Offset = "0x5B60CE0", VA = "0x185B620E0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x5B62B10", Offset = "0x5B61710", VA = "0x185B62B10")]
			set
			{
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00002AD8 File Offset: 0x00000CD8
		[Token(Token = "0x17000095")]
		private new bool hasSelection
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x5B621F0", Offset = "0x5B60DF0", VA = "0x185B621F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x00002AF0 File Offset: 0x00000CF0
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000096")]
		public int caretPosition
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x5B620E0", Offset = "0x5B60CE0", VA = "0x185B620E0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x5B62A50", Offset = "0x5B61650", VA = "0x185B62A50")]
			set
			{
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x00002B08 File Offset: 0x00000D08
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000097")]
		public int selectionAnchorPosition
		{
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x5B620B0", Offset = "0x5B60CB0", VA = "0x185B620B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x5B63270", Offset = "0x5B61E70", VA = "0x185B63270")]
			set
			{
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x00002B20 File Offset: 0x00000D20
		// (set) Token: 0x060001EA RID: 490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000098")]
		public int selectionFocusPosition
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x5B620E0", Offset = "0x5B60CE0", VA = "0x185B620E0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x5B63350", Offset = "0x5B61F50", VA = "0x185B63350")]
			set
			{
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x5B5EC40", Offset = "0x5B5D840", VA = "0x185B5EC40", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x5B5E6B0", Offset = "0x5B5D2B0", VA = "0x185B5E6B0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x5B5E650", Offset = "0x5B5D250", VA = "0x185B5E650", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x5B59A70", Offset = "0x5B58670", VA = "0x185B59A70")]
		private IEnumerator CaretBlink()
		{
			return null;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x5B5FD00", Offset = "0x5B5E900", VA = "0x185B5FD00")]
		private void SetCaretVisible()
		{
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x5B5FC20", Offset = "0x5B5E820", VA = "0x185B5FC20")]
		private void SetCaretActive()
		{
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x5B60A70", Offset = "0x5B5F670", VA = "0x185B60A70")]
		private void UpdateCaretMaterial()
		{
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x5B5F100", Offset = "0x5B5DD00", VA = "0x185B5F100")]
		protected void OnFocus()
		{
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x5B5F100", Offset = "0x5B5DD00", VA = "0x185B5F100")]
		protected void SelectAll()
		{
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x5B5E280", Offset = "0x5B5CE80", VA = "0x185B5E280")]
		public void MoveTextEnd(bool shift)
		{
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x5B5E350", Offset = "0x5B5CF50", VA = "0x185B5E350")]
		public void MoveTextStart(bool shift)
		{
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000099")]
		private static string clipboard
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x58A0FD0", Offset = "0x589FBD0", VA = "0x1858A0FD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x58A1D80", Offset = "0x58A0980", VA = "0x1858A1D80")]
			set
			{
			}
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00002B38 File Offset: 0x00000D38
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x5B608C0", Offset = "0x5B5F4C0", VA = "0x185B608C0")]
		private bool TouchScreenKeyboardShouldBeUsed()
		{
			return default(bool);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00002B50 File Offset: 0x00000D50
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x5B5C360", Offset = "0x5B5AF60", VA = "0x185B5C360")]
		private bool InPlaceEditing()
		{
			return default(bool);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00002B68 File Offset: 0x00000D68
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x5B5C2E0", Offset = "0x5B5AEE0", VA = "0x185B5C2E0")]
		private bool InPlaceEditingChanged()
		{
			return default(bool);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x5B60940", Offset = "0x5B5F540", VA = "0x185B60940")]
		private void UpdateCaretFromKeyboard()
		{
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x5B5CD40", Offset = "0x5B5B940", VA = "0x185B5CD40", Slot = "63")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002B80 File Offset: 0x00000D80
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x5B5F700", Offset = "0x5B5E300", VA = "0x185B5F700")]
		[Obsolete("This function is no longer used. Please use RectTransformUtility.ScreenPointToLocalPointInRectangle() instead.")]
		public Vector2 ScreenToLocal(Vector2 screen)
		{
			return default(Vector2);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002B98 File Offset: 0x00000D98
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x5B5C140", Offset = "0x5B5AD40", VA = "0x185B5C140")]
		private int GetUnclampedCharacterLineFromPosition(Vector2 pos, TextGenerator generator)
		{
			return 0;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00002BB0 File Offset: 0x00000DB0
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x5B5BBA0", Offset = "0x5B5A7A0", VA = "0x185B5BBA0")]
		protected int GetCharacterIndexFromPosition(Vector2 pos)
		{
			return 0;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00002BC8 File Offset: 0x00000DC8
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x5B5D990", Offset = "0x5B5C590", VA = "0x185B5D990")]
		private bool MayDrag(PointerEventData eventData)
		{
			return default(bool);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x5B5E5F0", Offset = "0x5B5D1F0", VA = "0x185B5E5F0", Slot = "64")]
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x5B5E940", Offset = "0x5B5D540", VA = "0x185B5E940", Slot = "65")]
		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x5B5DAA0", Offset = "0x5B5C6A0", VA = "0x185B5DAA0")]
		private IEnumerator MouseDragOutsideRect(PointerEventData eventData)
		{
			return null;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x5B5EF00", Offset = "0x5B5DB00", VA = "0x185B5EF00", Slot = "66")]
		public virtual void OnEndDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x5B5F1A0", Offset = "0x5B5DDA0", VA = "0x185B5F1A0", Slot = "34")]
		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00002BE0 File Offset: 0x00000DE0
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x5B5C670", Offset = "0x5B5B270", VA = "0x185B5C670")]
		protected InputField.EditState KeyPressed(Event evt)
		{
			return InputField.EditState.Continue;
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00002BF8 File Offset: 0x00000DF8
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x5B5C610", Offset = "0x5B5B210", VA = "0x185B5C610")]
		private bool IsValidChar(char c)
		{
			return default(bool);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x5B5F6E0", Offset = "0x5B5E2E0", VA = "0x185B5F6E0")]
		public void ProcessEvent(Event e)
		{
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x5B5F500", Offset = "0x5B5E100", VA = "0x185B5F500", Slot = "67")]
		public virtual void OnUpdateSelected(BaseEventData eventData)
		{
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x5B5C040", Offset = "0x5B5AC40", VA = "0x185B5C040")]
		private string GetSelectedString()
		{
			return null;
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002C10 File Offset: 0x00000E10
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x5B5A560", Offset = "0x5B59160", VA = "0x185B5A560")]
		private int FindtNextWordBegin()
		{
			return 0;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x5B5DFD0", Offset = "0x5B5CBD0", VA = "0x185B5DFD0")]
		private void MoveRight(bool shift, bool ctrl)
		{
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002C28 File Offset: 0x00000E28
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x5B5A660", Offset = "0x5B59260", VA = "0x185B5A660")]
		private int FindtPrevWordBegin()
		{
			return 0;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x5B5DD50", Offset = "0x5B5C950", VA = "0x185B5DD50")]
		private void MoveLeft(bool shift, bool ctrl)
		{
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002C40 File Offset: 0x00000E40
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x5B5A260", Offset = "0x5B58E60", VA = "0x185B5A260")]
		private int DetermineCharacterLine(int charPos, TextGenerator generator)
		{
			return 0;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002C58 File Offset: 0x00000E58
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x5B5D720", Offset = "0x5B5C320", VA = "0x185B5D720")]
		private int LineUpCharacterPosition(int originalPos, bool goToFirstChar)
		{
			return 0;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002C70 File Offset: 0x00000E70
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x5B5D480", Offset = "0x5B5C080", VA = "0x185B5D480")]
		private int LineDownCharacterPosition(int originalPos, bool goToLastChar)
		{
			return 0;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x5B5DD40", Offset = "0x5B5C940", VA = "0x185B5DD40")]
		private void MoveDown(bool shift)
		{
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x5B5DB30", Offset = "0x5B5C730", VA = "0x185B5DB30")]
		private void MoveDown(bool shift, bool goToLastChar)
		{
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x5B5E410", Offset = "0x5B5D010", VA = "0x185B5E410")]
		private void MoveUp(bool shift)
		{
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x5B5E420", Offset = "0x5B5D020", VA = "0x185B5E420")]
		private void MoveUp(bool shift, bool goToFirstChar)
		{
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x5B59F40", Offset = "0x5B58B40", VA = "0x185B59F40")]
		private void Delete()
		{
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x5B5A750", Offset = "0x5B59350", VA = "0x185B5A750")]
		private void ForwardSpace()
		{
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x5B598E0", Offset = "0x5B584E0", VA = "0x185B598E0")]
		private void Backspace()
		{
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x5B5C390", Offset = "0x5B5AF90", VA = "0x185B5C390")]
		private void Insert(char c)
		{
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x5B61530", Offset = "0x5B60130", VA = "0x185B61530")]
		private void UpdateTouchKeyboardFromEditChanges()
		{
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x5B5FB30", Offset = "0x5B5E730", VA = "0x185B5FB30")]
		private void SendOnValueChangedAndUpdateLabel()
		{
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x5B5FBB0", Offset = "0x5B5E7B0", VA = "0x185B5FBB0")]
		private void SendOnValueChanged()
		{
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x5B5FA50", Offset = "0x5B5E650", VA = "0x185B5FA50")]
		protected void SendOnEndEdit()
		{
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x5B5FAC0", Offset = "0x5B5E6C0", VA = "0x185B5FAC0")]
		protected void SendOnSubmit()
		{
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x5B59100", Offset = "0x5B57D00", VA = "0x185B59100", Slot = "68")]
		protected virtual void Append(string input)
		{
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x5B58D80", Offset = "0x5B57980", VA = "0x185B58D80", Slot = "69")]
		protected virtual void Append(char input)
		{
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x5B61050", Offset = "0x5B5FC50", VA = "0x185B61050")]
		protected void UpdateLabel()
		{
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00002C88 File Offset: 0x00000E88
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x5B5C540", Offset = "0x5B5B140", VA = "0x185B5C540")]
		private bool IsSelectionVisible()
		{
			return default(bool);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00002CA0 File Offset: 0x00000EA0
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x5B5BF90", Offset = "0x5B5AB90", VA = "0x185B5BF90")]
		private static int GetLineStartPosition(TextGenerator gen, int line)
		{
			return 0;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00002CB8 File Offset: 0x00000EB8
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x5B5BED0", Offset = "0x5B5AAD0", VA = "0x185B5BED0")]
		private static int GetLineEndPosition(TextGenerator gen, int line)
		{
			return 0;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x5B5FD40", Offset = "0x5B5E940", VA = "0x185B5FD40")]
		private void SetDrawRangeToContainCaretPosition(int caretPos)
		{
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x5B5A740", Offset = "0x5B59340", VA = "0x185B5A740")]
		public void ForceLabelUpdate()
		{
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x5B5D940", Offset = "0x5B5C540", VA = "0x185B5D940")]
		private void MarkGeometryAsDirty()
		{
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x5B5F6F0", Offset = "0x5B5E2F0", VA = "0x185B5F6F0", Slot = "70")]
		public virtual void Rebuild(CanvasUpdate update)
		{
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "71")]
		public virtual void LayoutComplete()
		{
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "72")]
		public virtual void GraphicUpdateComplete()
		{
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x5B60BA0", Offset = "0x5B5F7A0", VA = "0x185B60BA0")]
		private void UpdateGeometry()
		{
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x5B591A0", Offset = "0x5B57DA0", VA = "0x185B591A0")]
		private void AssignPositioningIfNeeded()
		{
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x5B5EF30", Offset = "0x5B5DB30", VA = "0x185B5EF30")]
		private void OnFillVBO(Mesh vbo)
		{
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x5B5A880", Offset = "0x5B59480", VA = "0x185B5A880")]
		private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset)
		{
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x5B59B30", Offset = "0x5B58730", VA = "0x185B59B30")]
		private void CreateCursorVerts()
		{
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x5B5B360", Offset = "0x5B59F60", VA = "0x185B5B360")]
		private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset)
		{
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002CD0 File Offset: 0x00000ED0
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x5B61590", Offset = "0x5B60190", VA = "0x185B61590")]
		protected char Validate(string text, int pos, char ch)
		{
			return '\0';
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x5B58C30", Offset = "0x5B57830", VA = "0x185B58C30")]
		public void ActivateInputField()
		{
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x5B587B0", Offset = "0x5B573B0", VA = "0x185B587B0")]
		private void ActivateInputFieldInternal()
		{
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x5B5F420", Offset = "0x5B5E020", VA = "0x185B5F420", Slot = "38")]
		public override void OnSelect(BaseEventData eventData)
		{
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x5B5F170", Offset = "0x5B5DD70", VA = "0x185B5F170", Slot = "73")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x5B59CF0", Offset = "0x5B588F0", VA = "0x185B59CF0")]
		public void DeactivateInputField()
		{
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x5B5E620", Offset = "0x5B5D220", VA = "0x185B5E620", Slot = "39")]
		public override void OnDeselect(BaseEventData eventData)
		{
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x5B5F480", Offset = "0x5B5E080", VA = "0x185B5F480", Slot = "74")]
		public virtual void OnSubmit(BaseEventData eventData)
		{
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x5B5A340", Offset = "0x5B58F40", VA = "0x185B5A340")]
		private void EnforceContentType()
		{
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x5B5A4B0", Offset = "0x5B590B0", VA = "0x185B5A4B0")]
		private void EnforceTextHOverflow()
		{
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x5B60840", Offset = "0x5B5F440", VA = "0x185B60840")]
		private void SetToCustomIfContentTypeIsNot(params InputField.ContentType[] allowedContentTypes)
		{
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x5B608A0", Offset = "0x5B5F4A0", VA = "0x185B608A0")]
		private void SetToCustom()
		{
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x5B5A310", Offset = "0x5B58F10", VA = "0x185B5A310", Slot = "28")]
		protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
		{
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "75")]
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "76")]
		public virtual void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000240 RID: 576 RVA: 0x00002CE8 File Offset: 0x00000EE8
		[Token(Token = "0x1700009A")]
		public virtual float minWidth
		{
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x738E20", Offset = "0x737A20", VA = "0x180738E20", Slot = "77")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000241 RID: 577 RVA: 0x00002D00 File Offset: 0x00000F00
		[Token(Token = "0x1700009B")]
		public virtual float preferredWidth
		{
			[Token(Token = "0x6000241")]
			[Address(RVA = "0x5B62640", Offset = "0x5B61240", VA = "0x185B62640", Slot = "78")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000242 RID: 578 RVA: 0x00002D18 File Offset: 0x00000F18
		[Token(Token = "0x1700009C")]
		public virtual float flexibleWidth
		{
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x2251AE0", Offset = "0x22506E0", VA = "0x182251AE0", Slot = "79")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000243 RID: 579 RVA: 0x00002D30 File Offset: 0x00000F30
		[Token(Token = "0x1700009D")]
		public virtual float minHeight
		{
			[Token(Token = "0x6000243")]
			[Address(RVA = "0x738E20", Offset = "0x737A20", VA = "0x180738E20", Slot = "80")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000244 RID: 580 RVA: 0x00002D48 File Offset: 0x00000F48
		[Token(Token = "0x1700009E")]
		public virtual float preferredHeight
		{
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x5B62440", Offset = "0x5B61040", VA = "0x185B62440", Slot = "81")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00002D60 File Offset: 0x00000F60
		[Token(Token = "0x1700009F")]
		public virtual float flexibleHeight
		{
			[Token(Token = "0x6000245")]
			[Address(RVA = "0x2251AE0", Offset = "0x22506E0", VA = "0x182251AE0", Slot = "82")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000246 RID: 582 RVA: 0x00002D78 File Offset: 0x00000F78
		[Token(Token = "0x170000A0")]
		public virtual int layoutPriority
		{
			[Token(Token = "0x6000246")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "83")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x589F680", Offset = "0x589E280", VA = "0x18589F680", Slot = "48")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0xF8")]
		protected TouchScreenKeyboard m_Keyboard;

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x0")]
		private static readonly char[] kSeparators;

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x8")]
		private static bool s_IsQuestDevice;

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x100")]
		[FormerlySerializedAs("text")]
		[SerializeField]
		protected Text m_TextComponent;

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		protected Graphic m_Placeholder;

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private InputField.ContentType m_ContentType;

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x114")]
		[FormerlySerializedAs("inputType")]
		[SerializeField]
		private InputField.InputType m_InputType;

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x118")]
		[FormerlySerializedAs("asteriskChar")]
		[SerializeField]
		private char m_AsteriskChar;

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x11C")]
		[FormerlySerializedAs("keyboardType")]
		[SerializeField]
		private TouchScreenKeyboardType m_KeyboardType;

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private InputField.LineType m_LineType;

		// Token: 0x040000DC RID: 220
		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x124")]
		[FormerlySerializedAs("hideMobileInput")]
		[SerializeField]
		private bool m_HideMobileInput;

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		[FormerlySerializedAs("validation")]
		private InputField.CharacterValidation m_CharacterValidation;

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x12C")]
		[FormerlySerializedAs("characterLimit")]
		[SerializeField]
		private int m_CharacterLimit;

		// Token: 0x040000DF RID: 223
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x130")]
		[FormerlySerializedAs("m_OnSubmit")]
		[FormerlySerializedAs("m_EndEdit")]
		[FormerlySerializedAs("m_OnEndEdit")]
		[SerializeField]
		[FormerlySerializedAs("onSubmit")]
		private InputField.SubmitEvent m_OnSubmit;

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private InputField.EndEditEvent m_OnDidEndEdit;

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x140")]
		[FormerlySerializedAs("onValueChange")]
		[FormerlySerializedAs("m_OnValueChange")]
		[SerializeField]
		private InputField.OnChangeEvent m_OnValueChanged;

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x148")]
		[FormerlySerializedAs("onValidateInput")]
		[SerializeField]
		private InputField.OnValidateInput m_OnValidateInput;

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		[FormerlySerializedAs("selectionColor")]
		private Color m_CaretColor;

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private bool m_CustomCaretColor;

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x164")]
		[SerializeField]
		private Color m_SelectionColor;

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		[Multiline]
		[FormerlySerializedAs("mValue")]
		protected string m_Text;

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		[Range(0f, 4f)]
		private float m_CaretBlinkRate;

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x184")]
		[SerializeField]
		[Range(1f, 5f)]
		private int m_CaretWidth;

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private bool m_ReadOnly;

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x189")]
		[SerializeField]
		private bool m_ShouldActivateOnSelect;

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x18C")]
		protected int m_CaretPosition;

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x190")]
		protected int m_CaretSelectPosition;

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x198")]
		private RectTransform caretRectTrans;

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x1A0")]
		protected UIVertex[] m_CursorVerts;

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x1A8")]
		private TextGenerator m_InputTextCache;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x1B0")]
		private CanvasRenderer m_CachedInputRenderer;

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x1B8")]
		private bool m_PreventFontCallback;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x1C0")]
		[NonSerialized]
		protected Mesh m_Mesh;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x1C8")]
		private bool m_AllowInput;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x1C9")]
		private bool m_ShouldActivateNextUpdate;

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x1CA")]
		private bool m_UpdateDrag;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x1CB")]
		private bool m_DragPositionOutOfBounds;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		private const float kHScrollSpeed = 0.05f;

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		private const float kVScrollSpeed = 0.1f;

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x1CC")]
		protected bool m_CaretVisible;

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x1D0")]
		private Coroutine m_BlinkCoroutine;

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x1D8")]
		private float m_BlinkStartTime;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x1DC")]
		protected int m_DrawStart;

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x1E0")]
		protected int m_DrawEnd;

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x1E8")]
		private Coroutine m_DragCoroutine;

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x1F0")]
		private string m_OriginalText;

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x1F8")]
		private bool m_WasCanceled;

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x1F9")]
		private bool m_HasDoneFocusTransition;

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x200")]
		private WaitForSecondsRealtime m_WaitForSecondsRealtime;

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x208")]
		private bool m_TouchKeyboardAllowsInPlaceEditing;

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x209")]
		private bool m_IsCompositionActive;

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		private const string kEmailSpecialCharacters = "!#$%&'*+-/=?^_`{|}~";

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		private const string kOculusQuestDeviceModel = "Oculus Quest";

		// Token: 0x04000107 RID: 263
		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x210")]
		private Event m_ProcessingEvent;

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		private const int k_MaxTextLength = 16382;

		// Token: 0x0200002D RID: 45
		[Token(Token = "0x200002D")]
		public enum ContentType
		{
			// Token: 0x0400010A RID: 266
			[Token(Token = "0x400010A")]
			Standard,
			// Token: 0x0400010B RID: 267
			[Token(Token = "0x400010B")]
			Autocorrected,
			// Token: 0x0400010C RID: 268
			[Token(Token = "0x400010C")]
			IntegerNumber,
			// Token: 0x0400010D RID: 269
			[Token(Token = "0x400010D")]
			DecimalNumber,
			// Token: 0x0400010E RID: 270
			[Token(Token = "0x400010E")]
			Alphanumeric,
			// Token: 0x0400010F RID: 271
			[Token(Token = "0x400010F")]
			Name,
			// Token: 0x04000110 RID: 272
			[Token(Token = "0x4000110")]
			EmailAddress,
			// Token: 0x04000111 RID: 273
			[Token(Token = "0x4000111")]
			Password,
			// Token: 0x04000112 RID: 274
			[Token(Token = "0x4000112")]
			Pin,
			// Token: 0x04000113 RID: 275
			[Token(Token = "0x4000113")]
			Custom
		}

		// Token: 0x0200002E RID: 46
		[Token(Token = "0x200002E")]
		public enum InputType
		{
			// Token: 0x04000115 RID: 277
			[Token(Token = "0x4000115")]
			Standard,
			// Token: 0x04000116 RID: 278
			[Token(Token = "0x4000116")]
			AutoCorrect,
			// Token: 0x04000117 RID: 279
			[Token(Token = "0x4000117")]
			Password
		}

		// Token: 0x0200002F RID: 47
		[Token(Token = "0x200002F")]
		public enum CharacterValidation
		{
			// Token: 0x04000119 RID: 281
			[Token(Token = "0x4000119")]
			None,
			// Token: 0x0400011A RID: 282
			[Token(Token = "0x400011A")]
			Integer,
			// Token: 0x0400011B RID: 283
			[Token(Token = "0x400011B")]
			Decimal,
			// Token: 0x0400011C RID: 284
			[Token(Token = "0x400011C")]
			Alphanumeric,
			// Token: 0x0400011D RID: 285
			[Token(Token = "0x400011D")]
			Name,
			// Token: 0x0400011E RID: 286
			[Token(Token = "0x400011E")]
			EmailAddress
		}

		// Token: 0x02000030 RID: 48
		[Token(Token = "0x2000030")]
		public enum LineType
		{
			// Token: 0x04000120 RID: 288
			[Token(Token = "0x4000120")]
			SingleLine,
			// Token: 0x04000121 RID: 289
			[Token(Token = "0x4000121")]
			MultiLineSubmit,
			// Token: 0x04000122 RID: 290
			[Token(Token = "0x4000122")]
			MultiLineNewline
		}

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x0600024A RID: 586
		[Token(Token = "0x2000031")]
		public delegate char OnValidateInput(string text, int charIndex, char addedChar);

		// Token: 0x02000032 RID: 50
		[Token(Token = "0x2000032")]
		[Serializable]
		public class SubmitEvent : UnityEvent<string>
		{
			// Token: 0x0600024D RID: 589 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x5B6A430", Offset = "0x5B69030", VA = "0x185B6A430")]
			public SubmitEvent()
			{
			}
		}

		// Token: 0x02000033 RID: 51
		[Token(Token = "0x2000033")]
		[Serializable]
		public class EndEditEvent : UnityEvent<string>
		{
			// Token: 0x0600024E RID: 590 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600024E")]
			[Address(RVA = "0x5B56830", Offset = "0x5B55430", VA = "0x185B56830")]
			public EndEditEvent()
			{
			}
		}

		// Token: 0x02000034 RID: 52
		[Token(Token = "0x2000034")]
		[Serializable]
		public class OnChangeEvent : UnityEvent<string>
		{
			// Token: 0x0600024F RID: 591 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600024F")]
			[Address(RVA = "0x5B6A350", Offset = "0x5B68F50", VA = "0x185B6A350")]
			public OnChangeEvent()
			{
			}
		}

		// Token: 0x02000035 RID: 53
		[Token(Token = "0x2000035")]
		protected enum EditState
		{
			// Token: 0x04000124 RID: 292
			[Token(Token = "0x4000124")]
			Continue,
			// Token: 0x04000125 RID: 293
			[Token(Token = "0x4000125")]
			Finish
		}
	}
}
