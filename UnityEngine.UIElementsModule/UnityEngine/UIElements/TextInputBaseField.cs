using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000153 RID: 339
	[Token(Token = "0x2000153")]
	public abstract class TextInputBaseField<TValueType> : BaseField<TValueType>
	{
		// Token: 0x170001FB RID: 507
		// (get) Token: 0x0600096D RID: 2413 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170001FB")]
		protected internal TextInputBaseField<TValueType>.TextInputBase textInputBase
		{
			[Token(Token = "0x600096D")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001FC RID: 508
		// (set) Token: 0x0600096E RID: 2414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001FC")]
		private ITextHandle iTextHandle
		{
			[Token(Token = "0x600096E")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001FD RID: 509
		// (set) Token: 0x0600096F RID: 2415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001FD")]
		protected internal string text
		{
			[Token(Token = "0x600096F")]
			set
			{
			}
		}

		// Token: 0x170001FE RID: 510
		// (set) Token: 0x06000970 RID: 2416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001FE")]
		public bool isReadOnly
		{
			[Token(Token = "0x6000970")]
			set
			{
			}
		}

		// Token: 0x170001FF RID: 511
		// (set) Token: 0x06000971 RID: 2417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001FF")]
		public bool isPasswordField
		{
			[Token(Token = "0x6000971")]
			set
			{
			}
		}

		// Token: 0x17000200 RID: 512
		// (set) Token: 0x06000972 RID: 2418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000200")]
		public int maxLength
		{
			[Token(Token = "0x6000972")]
			set
			{
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000973 RID: 2419 RVA: 0x000056A0 File Offset: 0x000038A0
		// (set) Token: 0x06000974 RID: 2420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000201")]
		public bool isDelayed
		{
			[Token(Token = "0x6000973")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000974")]
			set
			{
			}
		}

		// Token: 0x17000202 RID: 514
		// (set) Token: 0x06000975 RID: 2421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000202")]
		public char maskChar
		{
			[Token(Token = "0x6000975")]
			set
			{
			}
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000976")]
		protected virtual string ValueToString(TValueType value)
		{
			return null;
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000977")]
		protected TextInputBaseField(string label, int maxLength, char maskChar, TextInputBaseField<TValueType>.TextInputBase textInputBase)
		{
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000978")]
		private void OnAttachToPanel(AttachToPanelEvent e)
		{
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000979")]
		private void OnFieldCustomStyleResolved(CustomStyleResolvedEvent e)
		{
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600097A")]
		protected override void ExecuteDefaultActionAtTarget(EventBase evt)
		{
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600097B")]
		protected override void UpdateMixedValueContent()
		{
		}

		// Token: 0x04000530 RID: 1328
		[Token(Token = "0x4000530")]
		[FieldOffset(Offset = "0x0")]
		private static CustomStyleProperty<Color> s_SelectionColorProperty;

		// Token: 0x04000531 RID: 1329
		[Token(Token = "0x4000531")]
		[FieldOffset(Offset = "0x0")]
		private static CustomStyleProperty<Color> s_CursorColorProperty;

		// Token: 0x04000532 RID: 1330
		[Token(Token = "0x4000532")]
		[FieldOffset(Offset = "0x0")]
		private int m_VisualInputTabIndex;

		// Token: 0x04000533 RID: 1331
		[Token(Token = "0x4000533")]
		[FieldOffset(Offset = "0x0")]
		private TextInputBaseField<TValueType>.TextInputBase m_TextInputBase;

		// Token: 0x04000535 RID: 1333
		[Token(Token = "0x4000535")]
		[FieldOffset(Offset = "0x0")]
		public new static readonly string ussClassName;

		// Token: 0x04000536 RID: 1334
		[Token(Token = "0x4000536")]
		[FieldOffset(Offset = "0x0")]
		public new static readonly string labelUssClassName;

		// Token: 0x04000537 RID: 1335
		[Token(Token = "0x4000537")]
		[FieldOffset(Offset = "0x0")]
		public new static readonly string inputUssClassName;

		// Token: 0x04000538 RID: 1336
		[Token(Token = "0x4000538")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string singleLineInputUssClassName;

		// Token: 0x04000539 RID: 1337
		[Token(Token = "0x4000539")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string multilineInputUssClassName;

		// Token: 0x0400053A RID: 1338
		[Token(Token = "0x400053A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string textInputUssName;

		// Token: 0x0400053B RID: 1339
		[Token(Token = "0x400053B")]
		[FieldOffset(Offset = "0x0")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<bool> onIsReadOnlyChanged;

		// Token: 0x02000154 RID: 340
		[Token(Token = "0x2000154")]
		public new class UxmlTraits : BaseFieldTraits<string, UxmlStringAttributeDescription>
		{
			// Token: 0x0600097D RID: 2429 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600097D")]
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}

			// Token: 0x0600097E RID: 2430 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600097E")]
			public UxmlTraits()
			{
			}

			// Token: 0x0400053C RID: 1340
			[Token(Token = "0x400053C")]
			[FieldOffset(Offset = "0x0")]
			private UxmlIntAttributeDescription m_MaxLength;

			// Token: 0x0400053D RID: 1341
			[Token(Token = "0x400053D")]
			[FieldOffset(Offset = "0x0")]
			private UxmlBoolAttributeDescription m_Password;

			// Token: 0x0400053E RID: 1342
			[Token(Token = "0x400053E")]
			[FieldOffset(Offset = "0x0")]
			private UxmlStringAttributeDescription m_MaskCharacter;

			// Token: 0x0400053F RID: 1343
			[Token(Token = "0x400053F")]
			[FieldOffset(Offset = "0x0")]
			private UxmlStringAttributeDescription m_Text;

			// Token: 0x04000540 RID: 1344
			[Token(Token = "0x4000540")]
			[FieldOffset(Offset = "0x0")]
			private UxmlBoolAttributeDescription m_IsReadOnly;

			// Token: 0x04000541 RID: 1345
			[Token(Token = "0x4000541")]
			[FieldOffset(Offset = "0x0")]
			private UxmlBoolAttributeDescription m_IsDelayed;
		}

		// Token: 0x02000155 RID: 341
		[Token(Token = "0x2000155")]
		protected internal abstract class TextInputBase : VisualElement, ITextInputField, IEventHandler, ITextElement
		{
			// Token: 0x0600097F RID: 2431 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600097F")]
			public void ResetValueAndText()
			{
			}

			// Token: 0x06000980 RID: 2432 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000980")]
			private void SaveValueAndText()
			{
			}

			// Token: 0x06000981 RID: 2433 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000981")]
			private void RestoreValueAndText()
			{
			}

			// Token: 0x06000982 RID: 2434 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000982")]
			private void UpdateText(string value)
			{
			}

			// Token: 0x06000983 RID: 2435 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x6000983")]
			protected virtual TValueType StringToValue(string str)
			{
				return null;
			}

			// Token: 0x06000984 RID: 2436 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000984")]
			internal void UpdateValueFromText()
			{
			}

			// Token: 0x06000985 RID: 2437 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000985")]
			internal void UpdateTextFromValue()
			{
			}

			// Token: 0x17000203 RID: 515
			// (get) Token: 0x06000986 RID: 2438 RVA: 0x000056B8 File Offset: 0x000038B8
			[Token(Token = "0x17000203")]
			private bool isReadOnly
			{
				[Token(Token = "0x6000986")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000204 RID: 516
			// (get) Token: 0x06000987 RID: 2439 RVA: 0x000056D0 File Offset: 0x000038D0
			// (set) Token: 0x06000988 RID: 2440 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000204")]
			public bool isReadOnly
			{
				[Token(Token = "0x6000987")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000988")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000205 RID: 517
			// (get) Token: 0x06000989 RID: 2441 RVA: 0x000056E8 File Offset: 0x000038E8
			// (set) Token: 0x0600098A RID: 2442 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000205")]
			public int maxLength
			{
				[Token(Token = "0x6000989")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x600098A")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000206 RID: 518
			// (get) Token: 0x0600098B RID: 2443 RVA: 0x00005700 File Offset: 0x00003900
			// (set) Token: 0x0600098C RID: 2444 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000206")]
			public char maskChar
			{
				[Token(Token = "0x600098B")]
				[CompilerGenerated]
				get
				{
					return '\0';
				}
				[Token(Token = "0x600098C")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000207 RID: 519
			// (get) Token: 0x0600098D RID: 2445 RVA: 0x00005718 File Offset: 0x00003918
			// (set) Token: 0x0600098E RID: 2446 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000207")]
			public virtual bool isPasswordField
			{
				[Token(Token = "0x600098D")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600098E")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000208 RID: 520
			// (get) Token: 0x0600098F RID: 2447 RVA: 0x00005730 File Offset: 0x00003930
			// (set) Token: 0x06000990 RID: 2448 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000208")]
			public bool doubleClickSelectsWord
			{
				[Token(Token = "0x600098F")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000990")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000209 RID: 521
			// (get) Token: 0x06000991 RID: 2449 RVA: 0x00005748 File Offset: 0x00003948
			// (set) Token: 0x06000992 RID: 2450 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000209")]
			public bool tripleClickSelectsLine
			{
				[Token(Token = "0x6000991")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000992")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700020A RID: 522
			// (get) Token: 0x06000993 RID: 2451 RVA: 0x00005760 File Offset: 0x00003960
			// (set) Token: 0x06000994 RID: 2452 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700020A")]
			internal bool isDelayed
			{
				[Token(Token = "0x6000993")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000994")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700020B RID: 523
			// (get) Token: 0x06000995 RID: 2453 RVA: 0x00005778 File Offset: 0x00003978
			[Token(Token = "0x1700020B")]
			internal bool isDragging
			{
				[Token(Token = "0x6000995")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700020C RID: 524
			// (get) Token: 0x06000996 RID: 2454 RVA: 0x00005790 File Offset: 0x00003990
			[Token(Token = "0x1700020C")]
			private bool touchScreenTextField
			{
				[Token(Token = "0x6000996")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700020D RID: 525
			// (get) Token: 0x06000997 RID: 2455 RVA: 0x000057A8 File Offset: 0x000039A8
			[Token(Token = "0x1700020D")]
			private bool touchScreenTextFieldChanged
			{
				[Token(Token = "0x6000997")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700020E RID: 526
			// (get) Token: 0x06000998 RID: 2456 RVA: 0x000057C0 File Offset: 0x000039C0
			[Token(Token = "0x1700020E")]
			public Color selectionColor
			{
				[Token(Token = "0x6000998")]
				get
				{
					return default(Color);
				}
			}

			// Token: 0x1700020F RID: 527
			// (get) Token: 0x06000999 RID: 2457 RVA: 0x000057D8 File Offset: 0x000039D8
			[Token(Token = "0x1700020F")]
			public Color cursorColor
			{
				[Token(Token = "0x6000999")]
				get
				{
					return default(Color);
				}
			}

			// Token: 0x17000210 RID: 528
			// (get) Token: 0x0600099A RID: 2458 RVA: 0x000057F0 File Offset: 0x000039F0
			[Token(Token = "0x17000210")]
			internal bool hasFocus
			{
				[Token(Token = "0x600099A")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000211 RID: 529
			// (get) Token: 0x0600099B RID: 2459 RVA: 0x0000212A File Offset: 0x0000032A
			// (set) Token: 0x0600099C RID: 2460 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000211")]
			internal TextEditorEventHandler editorEventHandler
			{
				[Token(Token = "0x600099B")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600099C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000212 RID: 530
			// (get) Token: 0x0600099D RID: 2461 RVA: 0x0000212A File Offset: 0x0000032A
			// (set) Token: 0x0600099E RID: 2462 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000212")]
			internal TextEditorEngine editorEngine
			{
				[Token(Token = "0x600099D")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600099E")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000213 RID: 531
			// (get) Token: 0x0600099F RID: 2463 RVA: 0x0000212A File Offset: 0x0000032A
			// (set) Token: 0x060009A0 RID: 2464 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000213")]
			public string text
			{
				[Token(Token = "0x600099F")]
				get
				{
					return null;
				}
				[Token(Token = "0x60009A0")]
				set
				{
				}
			}

			// Token: 0x060009A1 RID: 2465 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009A1")]
			internal TextInputBase()
			{
			}

			// Token: 0x060009A2 RID: 2466 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009A2")]
			private void InitTextEditorEventHandler()
			{
			}

			// Token: 0x060009A3 RID: 2467 RVA: 0x00005808 File Offset: 0x00003A08
			[Token(Token = "0x60009A3")]
			private DropdownMenuAction.Status CutActionStatus(DropdownMenuAction a)
			{
				return DropdownMenuAction.Status.None;
			}

			// Token: 0x060009A4 RID: 2468 RVA: 0x00005820 File Offset: 0x00003A20
			[Token(Token = "0x60009A4")]
			private DropdownMenuAction.Status CopyActionStatus(DropdownMenuAction a)
			{
				return DropdownMenuAction.Status.None;
			}

			// Token: 0x060009A5 RID: 2469 RVA: 0x00005838 File Offset: 0x00003A38
			[Token(Token = "0x60009A5")]
			private DropdownMenuAction.Status PasteActionStatus(DropdownMenuAction a)
			{
				return DropdownMenuAction.Status.None;
			}

			// Token: 0x060009A6 RID: 2470 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009A6")]
			private void ProcessMenuCommand(string command)
			{
			}

			// Token: 0x060009A7 RID: 2471 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009A7")]
			private void Cut(DropdownMenuAction a)
			{
			}

			// Token: 0x060009A8 RID: 2472 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009A8")]
			private void Copy(DropdownMenuAction a)
			{
			}

			// Token: 0x060009A9 RID: 2473 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009A9")]
			private void Paste(DropdownMenuAction a)
			{
			}

			// Token: 0x060009AA RID: 2474 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009AA")]
			internal void OnInputCustomStyleResolved(CustomStyleResolvedEvent e)
			{
			}

			// Token: 0x060009AB RID: 2475 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009AB")]
			private void OnAttachToPanel(AttachToPanelEvent attachEvent)
			{
			}

			// Token: 0x060009AC RID: 2476 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009AC")]
			internal virtual void SyncTextEngine()
			{
			}

			// Token: 0x060009AD RID: 2477 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x60009AD")]
			internal string CullString(string s)
			{
				return null;
			}

			// Token: 0x060009AE RID: 2478 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009AE")]
			internal void OnGenerateVisualContent(MeshGenerationContext mgc)
			{
			}

			// Token: 0x060009AF RID: 2479 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009AF")]
			internal void DrawWithTextSelectionAndCursor(MeshGenerationContext mgc, string newText, float pixelsPerPoint)
			{
			}

			// Token: 0x060009B0 RID: 2480 RVA: 0x00005850 File Offset: 0x00003A50
			[Token(Token = "0x60009B0")]
			internal virtual bool AcceptCharacter(char c)
			{
				return default(bool);
			}

			// Token: 0x060009B1 RID: 2481 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009B1")]
			protected virtual void BuildContextualMenu(ContextualMenuPopulateEvent evt)
			{
			}

			// Token: 0x060009B2 RID: 2482 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009B2")]
			private void OnDetectFocusChange()
			{
			}

			// Token: 0x060009B3 RID: 2483 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009B3")]
			private void OnCursorIndexChange()
			{
			}

			// Token: 0x060009B4 RID: 2484 RVA: 0x00005868 File Offset: 0x00003A68
			[Token(Token = "0x60009B4")]
			protected internal override Vector2 DoMeasure(float desiredWidth, VisualElement.MeasureMode widthMode, float desiredHeight, VisualElement.MeasureMode heightMode)
			{
				return default(Vector2);
			}

			// Token: 0x060009B5 RID: 2485 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009B5")]
			internal override void ExecuteDefaultActionDisabledAtTarget(EventBase evt)
			{
			}

			// Token: 0x060009B6 RID: 2486 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009B6")]
			protected override void ExecuteDefaultActionAtTarget(EventBase evt)
			{
			}

			// Token: 0x060009B7 RID: 2487 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009B7")]
			private void ProcessEventAtTarget(EventBase evt)
			{
			}

			// Token: 0x060009B8 RID: 2488 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009B8")]
			protected override void ExecuteDefaultAction(EventBase evt)
			{
			}

			// Token: 0x17000214 RID: 532
			// (get) Token: 0x060009B9 RID: 2489 RVA: 0x00005880 File Offset: 0x00003A80
			[Token(Token = "0x17000214")]
			private bool hasFocus
			{
				[Token(Token = "0x60009B9")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060009BA RID: 2490 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009BA")]
			private void SyncTextEngine()
			{
			}

			// Token: 0x060009BB RID: 2491 RVA: 0x00005898 File Offset: 0x00003A98
			[Token(Token = "0x60009BB")]
			private bool AcceptCharacter(char c)
			{
				return default(bool);
			}

			// Token: 0x060009BC RID: 2492 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x60009BC")]
			private string CullString(string s)
			{
				return null;
			}

			// Token: 0x060009BD RID: 2493 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009BD")]
			private void UpdateText(string value)
			{
			}

			// Token: 0x17000215 RID: 533
			// (get) Token: 0x060009BE RID: 2494 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x17000215")]
			private TextEditorEngine editorEngine
			{
				[Token(Token = "0x60009BE")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000216 RID: 534
			// (get) Token: 0x060009BF RID: 2495 RVA: 0x000058B0 File Offset: 0x00003AB0
			[Token(Token = "0x17000216")]
			private bool isDelayed
			{
				[Token(Token = "0x60009BF")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060009C0 RID: 2496 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009C0")]
			private void UpdateValueFromText()
			{
			}

			// Token: 0x060009C1 RID: 2497 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009C1")]
			private void DeferGUIStyleRectSync()
			{
			}

			// Token: 0x060009C2 RID: 2498 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009C2")]
			private void OnPercentResolved(GeometryChangedEvent evt)
			{
			}

			// Token: 0x060009C3 RID: 2499 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009C3")]
			private static void SyncGUIStyle(TextInputBaseField<TValueType>.TextInputBase textInput, GUIStyle style)
			{
			}

			// Token: 0x060009C4 RID: 2500 RVA: 0x000058C8 File Offset: 0x00003AC8
			[Token(Token = "0x60009C4")]
			private static bool IsLayoutUsingPercent(VisualElement ve)
			{
				return default(bool);
			}

			// Token: 0x060009C5 RID: 2501 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009C5")]
			private static void AssignRect(RectOffset rect, int left, int top, int right, int bottom)
			{
			}

			// Token: 0x04000542 RID: 1346
			[Token(Token = "0x4000542")]
			[FieldOffset(Offset = "0x0")]
			private string m_OriginalText;

			// Token: 0x0400054B RID: 1355
			[Token(Token = "0x400054B")]
			[FieldOffset(Offset = "0x0")]
			private bool m_TouchScreenTextFieldInitialized;

			// Token: 0x0400054C RID: 1356
			[Token(Token = "0x400054C")]
			[FieldOffset(Offset = "0x0")]
			private IVisualElementScheduledItem m_HardwareKeyboardPoller;

			// Token: 0x0400054D RID: 1357
			[Token(Token = "0x400054D")]
			[FieldOffset(Offset = "0x0")]
			private Color m_SelectionColor;

			// Token: 0x0400054E RID: 1358
			[Token(Token = "0x400054E")]
			[FieldOffset(Offset = "0x0")]
			private Color m_CursorColor;

			// Token: 0x04000551 RID: 1361
			[Token(Token = "0x4000551")]
			[FieldOffset(Offset = "0x0")]
			private ITextHandle m_TextHandle;

			// Token: 0x04000552 RID: 1362
			[Token(Token = "0x4000552")]
			[FieldOffset(Offset = "0x0")]
			private string m_Text;
		}
	}
}
