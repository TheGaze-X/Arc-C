using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000133 RID: 307
	[Token(Token = "0x2000133")]
	public class RadioButtonGroup : BaseField<int>, IGroupBox
	{
		// Token: 0x170001C9 RID: 457
		// (set) Token: 0x060008A0 RID: 2208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C9")]
		public IEnumerable<string> choices
		{
			[Token(Token = "0x60008A0")]
			[Address(RVA = "0x5AC05F0", Offset = "0x5ABF1F0", VA = "0x185AC05F0")]
			set
			{
			}
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x5AC0430", Offset = "0x5ABF030", VA = "0x185AC0430")]
		public RadioButtonGroup()
		{
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x5AC0250", Offset = "0x5ABEE50", VA = "0x185AC0250")]
		public RadioButtonGroup(string label, [Optional] List<string> radioButtonChoices)
		{
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x5ABFE10", Offset = "0x5ABEA10", VA = "0x185ABFE10")]
		private void RadioButtonValueChangedCallback(ChangeEvent<bool> evt)
		{
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x5ABFF50", Offset = "0x5ABEB50", VA = "0x185ABFF50", Slot = "107")]
		public override void SetValueWithoutNotify(int newValue)
		{
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x5ABFFA0", Offset = "0x5ABEBA0", VA = "0x185ABFFA0")]
		private void UpdateRadioButtons()
		{
		}

		// Token: 0x040004A7 RID: 1191
		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public new static readonly string ussClassName;

		// Token: 0x040004A8 RID: 1192
		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x408")]
		private IEnumerable<string> m_Choices;

		// Token: 0x040004A9 RID: 1193
		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x410")]
		private List<RadioButton> m_RadioButtons;

		// Token: 0x040004AA RID: 1194
		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x418")]
		private EventCallback<ChangeEvent<bool>> m_RadioButtonValueChangedCallback;

		// Token: 0x02000134 RID: 308
		[Token(Token = "0x2000134")]
		public new class UxmlFactory : UxmlFactory<RadioButtonGroup, RadioButtonGroup.UxmlTraits>
		{
			// Token: 0x060008A7 RID: 2215 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60008A7")]
			[Address(RVA = "0x5AD2DB0", Offset = "0x5AD19B0", VA = "0x185AD2DB0")]
			public UxmlFactory()
			{
			}
		}

		// Token: 0x02000135 RID: 309
		[Token(Token = "0x2000135")]
		public new class UxmlTraits : BaseFieldTraits<int, UxmlIntAttributeDescription>
		{
			// Token: 0x060008A8 RID: 2216 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60008A8")]
			[Address(RVA = "0x5AD4D90", Offset = "0x5AD3990", VA = "0x185AD4D90", Slot = "4")]
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}

			// Token: 0x060008A9 RID: 2217 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60008A9")]
			[Address(RVA = "0x5AD64B0", Offset = "0x5AD50B0", VA = "0x185AD64B0")]
			public UxmlTraits()
			{
			}

			// Token: 0x040004AB RID: 1195
			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private UxmlStringAttributeDescription m_Choices;
		}
	}
}
