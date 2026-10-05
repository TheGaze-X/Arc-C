using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x0200716B RID: 29035
	[Token(Token = "0x200716B")]
	public class Act9D0MapZoneView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17006196 RID: 24982
		// (get) Token: 0x06029390 RID: 168848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006196")]
		public string zoneId
		{
			[Token(Token = "0x6029390")]
			[Address(RVA = "0x2498120", Offset = "0x2496D20", VA = "0x182498120")]
			get
			{
				return null;
			}
		}

		// Token: 0x06029391 RID: 168849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029391")]
		[Address(RVA = "0x2497E20", Offset = "0x2496A20", VA = "0x182497E20")]
		public void Render(Act9D0ZoneDescViewModel viewModel, bool isSelected)
		{
		}

		// Token: 0x06029392 RID: 168850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029392")]
		[Address(RVA = "0x2497D80", Offset = "0x2496980", VA = "0x182497D80")]
		public void EventOnClicked()
		{
		}

		// Token: 0x06029393 RID: 168851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029393")]
		[Address(RVA = "0x24980C0", Offset = "0x2496CC0", VA = "0x1824980C0")]
		public Act9D0MapZoneView()
		{
		}

		// Token: 0x0403ADC7 RID: 241095
		[Token(Token = "0x403ADC7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _zoneId;

		// Token: 0x0403ADC8 RID: 241096
		[Token(Token = "0x403ADC8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x0403ADC9 RID: 241097
		[Token(Token = "0x403ADC9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _buttonSelf;

		// Token: 0x0403ADCA RID: 241098
		[Token(Token = "0x403ADCA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _imageSelected;

		// Token: 0x0403ADCB RID: 241099
		[Token(Token = "0x403ADCB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _imageIcon;

		// Token: 0x0403ADCC RID: 241100
		[Token(Token = "0x403ADCC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelTimeout;

		// Token: 0x0403ADCD RID: 241101
		[Token(Token = "0x403ADCD")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0403ADCE RID: 241102
		[Token(Token = "0x403ADCE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIStringEvent _onClicked;

		// Token: 0x0403ADCF RID: 241103
		[Token(Token = "0x403ADCF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool _needDisableImageIcon;

		// Token: 0x0403ADD0 RID: 241104
		[Token(Token = "0x403ADD0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_zoneId;

		// Token: 0x0403ADD1 RID: 241105
		[Token(Token = "0x403ADD1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403ADD2 RID: 241106
		[Token(Token = "0x403ADD2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x0403ADD3 RID: 241107
		[Token(Token = "0x403ADD3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
