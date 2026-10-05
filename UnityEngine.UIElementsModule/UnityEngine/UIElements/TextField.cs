using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200014E RID: 334
	[Token(Token = "0x200014E")]
	public class TextField : TextInputBaseField<string>
	{
		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170001EE")]
		private TextField.TextInput textInput
		{
			[Token(Token = "0x6000949")]
			[Address(RVA = "0x5ACB210", Offset = "0x5AC9E10", VA = "0x185ACB210")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001EF RID: 495
		// (set) Token: 0x0600094A RID: 2378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001EF")]
		public bool multiline
		{
			[Token(Token = "0x600094A")]
			[Address(RVA = "0x5ACB310", Offset = "0x5AC9F10", VA = "0x185ACB310")]
			set
			{
			}
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094B")]
		[Address(RVA = "0x5ACB1E0", Offset = "0x5AC9DE0", VA = "0x185ACB1E0")]
		public TextField()
		{
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094C")]
		[Address(RVA = "0x5ACB1B0", Offset = "0x5AC9DB0", VA = "0x185ACB1B0")]
		public TextField(string label)
		{
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094D")]
		[Address(RVA = "0x5ACAF80", Offset = "0x5AC9B80", VA = "0x185ACAF80")]
		public TextField(string label, int maxLength, bool multiline, bool isPasswordField, char maskChar)
		{
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x0600094E RID: 2382 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x0600094F RID: 2383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001F0")]
		public override string value
		{
			[Token(Token = "0x600094E")]
			[Address(RVA = "0x5ACB2D0", Offset = "0x5AC9ED0", VA = "0x185ACB2D0", Slot = "102")]
			get
			{
				return null;
			}
			[Token(Token = "0x600094F")]
			[Address(RVA = "0x5ACB3E0", Offset = "0x5AC9FE0", VA = "0x185ACB3E0", Slot = "103")]
			set
			{
			}
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000950")]
		[Address(RVA = "0x5ACADD0", Offset = "0x5AC99D0", VA = "0x185ACADD0", Slot = "107")]
		public override void SetValueWithoutNotify(string newValue)
		{
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000951")]
		[Address(RVA = "0x5ACAD40", Offset = "0x5AC9940", VA = "0x185ACAD40", Slot = "93")]
		internal override void OnViewDataReady()
		{
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000952")]
		[Address(RVA = "0x5B5210", Offset = "0x5B3E10", VA = "0x1805B5210", Slot = "108")]
		protected override string ValueToString(string value)
		{
			return null;
		}

		// Token: 0x0400052B RID: 1323
		[Token(Token = "0x400052B")]
		[FieldOffset(Offset = "0x0")]
		public new static readonly string ussClassName;

		// Token: 0x0400052C RID: 1324
		[Token(Token = "0x400052C")]
		[FieldOffset(Offset = "0x8")]
		public new static readonly string labelUssClassName;

		// Token: 0x0400052D RID: 1325
		[Token(Token = "0x400052D")]
		[FieldOffset(Offset = "0x10")]
		public new static readonly string inputUssClassName;

		// Token: 0x0200014F RID: 335
		[Token(Token = "0x200014F")]
		public new class UxmlFactory : UxmlFactory<TextField, TextField.UxmlTraits>
		{
			// Token: 0x06000954 RID: 2388 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000954")]
			[Address(RVA = "0x5AD2CB0", Offset = "0x5AD18B0", VA = "0x185AD2CB0")]
			public UxmlFactory()
			{
			}
		}

		// Token: 0x02000150 RID: 336
		[Token(Token = "0x2000150")]
		public new class UxmlTraits : TextInputBaseField<string>.UxmlTraits
		{
			// Token: 0x06000955 RID: 2389 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000955")]
			[Address(RVA = "0x5AD3D60", Offset = "0x5AD2960", VA = "0x185AD3D60", Slot = "4")]
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}

			// Token: 0x06000956 RID: 2390 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000956")]
			[Address(RVA = "0x5AD5E00", Offset = "0x5AD4A00", VA = "0x185AD5E00")]
			public UxmlTraits()
			{
			}

			// Token: 0x0400052E RID: 1326
			[Token(Token = "0x400052E")]
			[FieldOffset(Offset = "0xB8")]
			private UxmlBoolAttributeDescription m_Multiline;
		}

		// Token: 0x02000151 RID: 337
		[Token(Token = "0x2000151")]
		private class TextInput : TextInputBaseField<string>.TextInputBase
		{
			// Token: 0x170001F1 RID: 497
			// (get) Token: 0x06000957 RID: 2391 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x170001F1")]
			private TextField parentTextField
			{
				[Token(Token = "0x6000957")]
				[Address(RVA = "0x5ACBF50", Offset = "0x5ACAB50", VA = "0x185ACBF50")]
				get
				{
					return null;
				}
			}

			// Token: 0x170001F2 RID: 498
			// (get) Token: 0x06000958 RID: 2392 RVA: 0x00005688 File Offset: 0x00003888
			// (set) Token: 0x06000959 RID: 2393 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170001F2")]
			public bool multiline
			{
				[Token(Token = "0x6000958")]
				[Address(RVA = "0x5ACBF40", Offset = "0x5ACAB40", VA = "0x185ACBF40")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000959")]
				[Address(RVA = "0x5ACC060", Offset = "0x5ACAC60", VA = "0x185ACC060")]
				set
				{
				}
			}

			// Token: 0x0600095A RID: 2394 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600095A")]
			[Address(RVA = "0x5ACBD60", Offset = "0x5ACA960", VA = "0x185ACBD60")]
			private void SetTextAlign()
			{
			}

			// Token: 0x170001F3 RID: 499
			// (set) Token: 0x0600095B RID: 2395 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170001F3")]
			public override bool isPasswordField
			{
				[Token(Token = "0x600095B")]
				[Address(RVA = "0x5ACC010", Offset = "0x5ACAC10", VA = "0x185ACC010", Slot = "112")]
				set
				{
				}
			}

			// Token: 0x0600095C RID: 2396 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x600095C")]
			[Address(RVA = "0x5ACBE40", Offset = "0x5ACAA40", VA = "0x185ACBE40", Slot = "110")]
			protected override string StringToValue(string str)
			{
				return null;
			}

			// Token: 0x0600095D RID: 2397 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600095D")]
			[Address(RVA = "0x5ACBE50", Offset = "0x5ACAA50", VA = "0x185ACBE50", Slot = "114")]
			internal override void SyncTextEngine()
			{
			}

			// Token: 0x0600095E RID: 2398 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600095E")]
			[Address(RVA = "0x5ACB470", Offset = "0x5ACA070", VA = "0x185ACB470", Slot = "11")]
			protected override void ExecuteDefaultActionAtTarget(EventBase evt)
			{
			}

			// Token: 0x0600095F RID: 2399 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600095F")]
			[Address(RVA = "0x5ACBBB0", Offset = "0x5ACA7B0", VA = "0x185ACBBB0", Slot = "12")]
			protected override void ExecuteDefaultAction(EventBase evt)
			{
			}

			// Token: 0x06000960 RID: 2400 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000960")]
			[Address(RVA = "0x5ACBF00", Offset = "0x5ACAB00", VA = "0x185ACBF00")]
			public TextInput()
			{
			}

			// Token: 0x0400052F RID: 1327
			[Token(Token = "0x400052F")]
			[FieldOffset(Offset = "0x410")]
			private bool m_Multiline;
		}
	}
}
