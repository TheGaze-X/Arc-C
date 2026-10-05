using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200009E RID: 158
	[Token(Token = "0x200009E")]
	public class TextElement : BindableElement, ITextElement, INotifyValueChanged<string>
	{
		// Token: 0x060004A7 RID: 1191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x5A91050", Offset = "0x5A8FC50", VA = "0x185A91050")]
		public TextElement()
		{
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060004A9 RID: 1193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000128")]
		internal ITextHandle textHandle
		{
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x5A91260", Offset = "0x5A8FE60", VA = "0x185A91260")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x5A8FDC0", Offset = "0x5A8E9C0", VA = "0x185A8FDC0")]
			set
			{
			}
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x5A903A0", Offset = "0x5A8EFA0", VA = "0x185A903A0", Slot = "8")]
		public override void HandleEvent(EventBase evt)
		{
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x5A90890", Offset = "0x5A8F490", VA = "0x185A90890")]
		private void OnGeometryChanged(GeometryChangedEvent e)
		{
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060004AD RID: 1197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000129")]
		public virtual string text
		{
			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x5A91270", Offset = "0x5A8FE70", VA = "0x185A91270", Slot = "103")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x5A913A0", Offset = "0x5A8FFA0", VA = "0x185A913A0", Slot = "104")]
			set
			{
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x00004200 File Offset: 0x00002400
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012A")]
		public bool enableRichText
		{
			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x5A91240", Offset = "0x5A8FE40", VA = "0x185A91240")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x5A91370", Offset = "0x5A8FF70", VA = "0x185A91370")]
			set
			{
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x00004218 File Offset: 0x00002418
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012B")]
		public bool displayTooltipWhenElided
		{
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x5A91230", Offset = "0x5A8FE30", VA = "0x185A91230")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x5A91330", Offset = "0x5A8FF30", VA = "0x185A91330")]
			set
			{
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x00004230 File Offset: 0x00002430
		// (set) Token: 0x060004B3 RID: 1203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012C")]
		public bool isElided
		{
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x5A91250", Offset = "0x5A8FE50", VA = "0x185A91250")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x5A91390", Offset = "0x5A8FF90", VA = "0x185A91390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x5A905C0", Offset = "0x5A8F1C0", VA = "0x185A905C0")]
		private void OnGenerateVisualContent(MeshGenerationContext mgc)
		{
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x5A8FE80", Offset = "0x5A8EA80", VA = "0x185A8FE80")]
		internal string ElideText(string drawText, string ellipsisText, float width, TextOverflowPosition textOverflowPosition)
		{
			return null;
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x5A90BE0", Offset = "0x5A8F7E0", VA = "0x185A90BE0")]
		private void UpdateTooltip()
		{
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x5A90C60", Offset = "0x5A8F860", VA = "0x185A90C60")]
		private void UpdateVisibleText()
		{
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00004248 File Offset: 0x00002448
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x5A908A0", Offset = "0x5A8F4A0", VA = "0x185A908A0")]
		private bool ShouldElide()
		{
			return default(bool);
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00004260 File Offset: 0x00002460
		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x5A90910", Offset = "0x5A8F510", VA = "0x185A90910")]
		private bool TextLibraryCanElide()
		{
			return default(bool);
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00004278 File Offset: 0x00002478
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x5A90580", Offset = "0x5A8F180", VA = "0x185A90580")]
		public Vector2 MeasureTextSize(string textToMeasure, float width, VisualElement.MeasureMode widthMode, float height, VisualElement.MeasureMode heightMode)
		{
			return default(Vector2);
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00004290 File Offset: 0x00002490
		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x5A8FDE0", Offset = "0x5A8E9E0", VA = "0x185A8FDE0", Slot = "95")]
		protected internal override Vector2 DoMeasure(float desiredWidth, VisualElement.MeasureMode widthMode, float desiredHeight, VisualElement.MeasureMode heightMode)
		{
			return default(Vector2);
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060004BD RID: 1213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012D")]
		private string value
		{
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x5A90A00", Offset = "0x5A8F600", VA = "0x185A90A00", Slot = "100")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x5A90A50", Offset = "0x5A8F650", VA = "0x185A90A50", Slot = "101")]
			set
			{
			}
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x5A90980", Offset = "0x5A8F580", VA = "0x185A90980", Slot = "102")]
		private void SetValueWithoutNotify(string newValue)
		{
		}

		// Token: 0x04000232 RID: 562
		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string ussClassName;

		// Token: 0x04000233 RID: 563
		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x3C0")]
		private ITextHandle m_TextHandle;

		// Token: 0x04000234 RID: 564
		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x8")]
		internal static int maxTextVertices;

		// Token: 0x04000235 RID: 565
		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x3C8")]
		[SerializeField]
		private string m_Text;

		// Token: 0x04000236 RID: 566
		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x3D0")]
		private bool m_EnableRichText;

		// Token: 0x04000237 RID: 567
		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x3D1")]
		private bool m_DisplayTooltipWhenElided;

		// Token: 0x04000239 RID: 569
		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly string k_EllipsisText;

		// Token: 0x0400023A RID: 570
		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x3D3")]
		private bool m_WasElided;

		// Token: 0x0400023B RID: 571
		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x3D4")]
		private bool m_UpdateTextParams;

		// Token: 0x0400023C RID: 572
		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x3D8")]
		private MeshGenerationContextUtils.TextParams m_TextParams;

		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x470")]
		private int m_PreviousTextParamsHashCode;

		// Token: 0x0200009F RID: 159
		[Token(Token = "0x200009F")]
		public new class UxmlFactory : UxmlFactory<TextElement, TextElement.UxmlTraits>
		{
			// Token: 0x060004C0 RID: 1216 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x5A9A6A0", Offset = "0x5A992A0", VA = "0x185A9A6A0")]
			public UxmlFactory()
			{
			}
		}

		// Token: 0x020000A0 RID: 160
		[Token(Token = "0x20000A0")]
		public new class UxmlTraits : BindableElement.UxmlTraits
		{
			// Token: 0x060004C1 RID: 1217 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60004C1")]
			[Address(RVA = "0x5A9AC60", Offset = "0x5A99860", VA = "0x185A9AC60", Slot = "4")]
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}

			// Token: 0x060004C2 RID: 1218 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x5A9AEC0", Offset = "0x5A99AC0", VA = "0x185A9AEC0")]
			public UxmlTraits()
			{
			}

			// Token: 0x0400023E RID: 574
			[Token(Token = "0x400023E")]
			[FieldOffset(Offset = "0x78")]
			private UxmlStringAttributeDescription m_Text;

			// Token: 0x0400023F RID: 575
			[Token(Token = "0x400023F")]
			[FieldOffset(Offset = "0x80")]
			private UxmlBoolAttributeDescription m_EnableRichText;

			// Token: 0x04000240 RID: 576
			[Token(Token = "0x4000240")]
			[FieldOffset(Offset = "0x88")]
			private UxmlBoolAttributeDescription m_DisplayTooltipWhenElided;
		}
	}
}
