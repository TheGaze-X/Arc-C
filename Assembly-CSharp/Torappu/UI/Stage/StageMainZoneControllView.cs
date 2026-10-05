using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200696C RID: 26988
	[Token(Token = "0x200696C")]
	public class StageMainZoneControllView : DataBinder<ZoneViewProperty>
	{
		// Token: 0x060269F3 RID: 158195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269F3")]
		[Address(RVA = "0x21AD1F0", Offset = "0x21ABDF0", VA = "0x1821AD1F0")]
		public void OnLeft()
		{
		}

		// Token: 0x060269F4 RID: 158196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269F4")]
		[Address(RVA = "0x21AD290", Offset = "0x21ABE90", VA = "0x1821AD290")]
		public void OnRight()
		{
		}

		// Token: 0x060269F5 RID: 158197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269F5")]
		[Address(RVA = "0x21AD330", Offset = "0x21ABF30", VA = "0x1821AD330", Slot = "7")]
		public override void OnValueChanged(ZoneViewProperty property)
		{
		}

		// Token: 0x060269F6 RID: 158198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269F6")]
		[Address(RVA = "0x21ADAA0", Offset = "0x21AC6A0", VA = "0x1821ADAA0")]
		private void _SetVisibility(bool isVisible)
		{
		}

		// Token: 0x060269F7 RID: 158199 RVA: 0x000CBDA8 File Offset: 0x000C9FA8
		[Token(Token = "0x60269F7")]
		[Address(RVA = "0x21AD8F0", Offset = "0x21AC4F0", VA = "0x1821AD8F0")]
		private bool _CheckZoneRetroValid(ZoneViewModel zone)
		{
			return default(bool);
		}

		// Token: 0x060269F8 RID: 158200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269F8")]
		[Address(RVA = "0x21ADBC0", Offset = "0x21AC7C0", VA = "0x1821ADBC0")]
		public StageMainZoneControllView()
		{
		}

		// Token: 0x0403680C RID: 223244
		[Token(Token = "0x403680C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _leftBar;

		// Token: 0x0403680D RID: 223245
		[Token(Token = "0x403680D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle _rightBar;

		// Token: 0x0403680E RID: 223246
		[Token(Token = "0x403680E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _leftActiveText;

		// Token: 0x0403680F RID: 223247
		[Token(Token = "0x403680F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _leftUnActiveText;

		// Token: 0x04036810 RID: 223248
		[Token(Token = "0x4036810")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _rightActiveText;

		// Token: 0x04036811 RID: 223249
		[Token(Token = "0x4036811")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _rightUnActiveText;

		// Token: 0x04036812 RID: 223250
		[Token(Token = "0x4036812")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _leftActiveTitle;

		// Token: 0x04036813 RID: 223251
		[Token(Token = "0x4036813")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _leftUnActiveTitle;

		// Token: 0x04036814 RID: 223252
		[Token(Token = "0x4036814")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _rightActiveTitle;

		// Token: 0x04036815 RID: 223253
		[Token(Token = "0x4036815")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _rightUnActiveTitle;

		// Token: 0x04036816 RID: 223254
		[Token(Token = "0x4036816")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _middleTitle;

		// Token: 0x04036817 RID: 223255
		[Token(Token = "0x4036817")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _middleText;

		// Token: 0x04036818 RID: 223256
		[Token(Token = "0x4036818")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04036819 RID: 223257
		[Token(Token = "0x4036819")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private StageStateBean _stateBean;

		// Token: 0x0403681A RID: 223258
		[Token(Token = "0x403681A")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private StageZoneSelectState _state;

		// Token: 0x0403681B RID: 223259
		[Token(Token = "0x403681B")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIStringEvent _eventZoneClick;

		// Token: 0x0403681C RID: 223260
		[Token(Token = "0x403681C")]
		[FieldOffset(Offset = "0xA0")]
		private string m_cacheLeft;

		// Token: 0x0403681D RID: 223261
		[Token(Token = "0x403681D")]
		[FieldOffset(Offset = "0xA8")]
		private string m_cacheRight;

		// Token: 0x0403681E RID: 223262
		[Token(Token = "0x403681E")]
		[FieldOffset(Offset = "0xB0")]
		private FadeSwitchTween m_fadeSwitch;

		// Token: 0x0403681F RID: 223263
		[Token(Token = "0x403681F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnLeft;

		// Token: 0x04036820 RID: 223264
		[Token(Token = "0x4036820")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRight;

		// Token: 0x04036821 RID: 223265
		[Token(Token = "0x4036821")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04036822 RID: 223266
		[Token(Token = "0x4036822")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetVisibility;

		// Token: 0x04036823 RID: 223267
		[Token(Token = "0x4036823")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckZoneRetroValid;

		// Token: 0x04036824 RID: 223268
		[Token(Token = "0x4036824")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
