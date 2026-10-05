using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006978 RID: 27000
	[Token(Token = "0x2006978")]
	public class StagePreviewResourceBar : DataBinder<ZoneViewProperty>
	{
		// Token: 0x06026A44 RID: 158276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A44")]
		[Address(RVA = "0x21BAEC0", Offset = "0x21B9AC0", VA = "0x1821BAEC0", Slot = "7")]
		public override void OnValueChanged(ZoneViewProperty property)
		{
		}

		// Token: 0x06026A45 RID: 158277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026A45")]
		[Address(RVA = "0x21BB170", Offset = "0x21B9D70", VA = "0x1821BB170")]
		public StagePreviewResourceBar()
		{
		}

		// Token: 0x040368C5 RID: 223429
		[Token(Token = "0x40368C5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelAp;

		// Token: 0x040368C6 RID: 223430
		[Token(Token = "0x40368C6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelEt;

		// Token: 0x040368C7 RID: 223431
		[Token(Token = "0x40368C7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _iconEt;

		// Token: 0x040368C8 RID: 223432
		[Token(Token = "0x40368C8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textEt;

		// Token: 0x040368C9 RID: 223433
		[Token(Token = "0x40368C9")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x040368CA RID: 223434
		[Token(Token = "0x40368CA")]
		[FieldOffset(Offset = "0x48")]
		private UIItemViewModel m_etItemModel;

		// Token: 0x040368CB RID: 223435
		[Token(Token = "0x40368CB")]
		[FieldOffset(Offset = "0x50")]
		private string m_buttonStyle;

		// Token: 0x040368CC RID: 223436
		[Token(Token = "0x40368CC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040368CD RID: 223437
		[Token(Token = "0x40368CD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
