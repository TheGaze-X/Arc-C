using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000130 RID: 304
	[Token(Token = "0x2000130")]
	public class RadioButton : BaseBoolField, IGroupBoxOption
	{
		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x00005340 File Offset: 0x00003540
		// (set) Token: 0x06000893 RID: 2195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C8")]
		public override bool value
		{
			[Token(Token = "0x6000892")]
			[Address(RVA = "0x5AC11F0", Offset = "0x5ABFDF0", VA = "0x185AC11F0", Slot = "102")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000893")]
			[Address(RVA = "0x5AC1230", Offset = "0x5ABFE30", VA = "0x185AC1230", Slot = "103")]
			set
			{
			}
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000894")]
		[Address(RVA = "0x5AC0F90", Offset = "0x5ABFB90", VA = "0x185AC0F90")]
		public RadioButton()
		{
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000895")]
		[Address(RVA = "0x5AC0FA0", Offset = "0x5ABFBA0", VA = "0x185AC0FA0")]
		public RadioButton(string label)
		{
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000896")]
		[Address(RVA = "0x5AC0AA0", Offset = "0x5ABF6A0", VA = "0x185AC0AA0", Slot = "108")]
		protected override void InitLabel()
		{
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000897")]
		[Address(RVA = "0x5AC0B90", Offset = "0x5ABF790", VA = "0x185AC0B90", Slot = "109")]
		protected override void ToggleValue()
		{
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000898")]
		[Address(RVA = "0x5AC0B20", Offset = "0x5ABF720", VA = "0x185AC0B20", Slot = "110")]
		public void SetSelected(bool selected)
		{
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000899")]
		[Address(RVA = "0x5AC0B70", Offset = "0x5ABF770", VA = "0x185AC0B70", Slot = "107")]
		public override void SetValueWithoutNotify(bool newValue)
		{
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600089A")]
		[Address(RVA = "0x5AC0C00", Offset = "0x5ABF800", VA = "0x185AC0C00")]
		private void UpdateCheckmark()
		{
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600089B")]
		[Address(RVA = "0x5AC0CC0", Offset = "0x5ABF8C0", VA = "0x185AC0CC0", Slot = "106")]
		protected override void UpdateMixedValueContent()
		{
		}

		// Token: 0x0400049F RID: 1183
		[Token(Token = "0x400049F")]
		[FieldOffset(Offset = "0x0")]
		public new static readonly string ussClassName;

		// Token: 0x040004A0 RID: 1184
		[Token(Token = "0x40004A0")]
		[FieldOffset(Offset = "0x8")]
		public new static readonly string labelUssClassName;

		// Token: 0x040004A1 RID: 1185
		[Token(Token = "0x40004A1")]
		[FieldOffset(Offset = "0x10")]
		public new static readonly string inputUssClassName;

		// Token: 0x040004A2 RID: 1186
		[Token(Token = "0x40004A2")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string checkmarkBackgroundUssClassName;

		// Token: 0x040004A3 RID: 1187
		[Token(Token = "0x40004A3")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string checkmarkUssClassName;

		// Token: 0x040004A4 RID: 1188
		[Token(Token = "0x40004A4")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string textUssClassName;

		// Token: 0x040004A5 RID: 1189
		[Token(Token = "0x40004A5")]
		[FieldOffset(Offset = "0x428")]
		private VisualElement m_CheckmarkBackground;

		// Token: 0x02000131 RID: 305
		[Token(Token = "0x2000131")]
		public new class UxmlFactory : UxmlFactory<RadioButton, RadioButton.UxmlTraits>
		{
			// Token: 0x0600089D RID: 2205 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600089D")]
			[Address(RVA = "0x5AD2F30", Offset = "0x5AD1B30", VA = "0x185AD2F30")]
			public UxmlFactory()
			{
			}
		}

		// Token: 0x02000132 RID: 306
		[Token(Token = "0x2000132")]
		public new class UxmlTraits : BaseFieldTraits<bool, UxmlBoolAttributeDescription>
		{
			// Token: 0x0600089E RID: 2206 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600089E")]
			[Address(RVA = "0x5AD4430", Offset = "0x5AD3030", VA = "0x185AD4430", Slot = "4")]
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}

			// Token: 0x0600089F RID: 2207 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600089F")]
			[Address(RVA = "0x5AD5D50", Offset = "0x5AD4950", VA = "0x185AD5D50")]
			public UxmlTraits()
			{
			}

			// Token: 0x040004A6 RID: 1190
			[Token(Token = "0x40004A6")]
			[FieldOffset(Offset = "0x88")]
			private UxmlStringAttributeDescription m_Text;
		}
	}
}
