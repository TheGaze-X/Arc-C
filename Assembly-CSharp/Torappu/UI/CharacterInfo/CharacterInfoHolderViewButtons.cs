using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.Events;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F33 RID: 24371
	[Token(Token = "0x2005F33")]
	public class CharacterInfoHolderViewButtons : DataBinder<CharInfoGroupProperty>
	{
		// Token: 0x060234B8 RID: 144568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234B8")]
		[Address(RVA = "0x1DD7810", Offset = "0x1DD6410", VA = "0x181DD7810")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060234B9 RID: 144569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234B9")]
		[Address(RVA = "0x1DD7640", Offset = "0x1DD6240", VA = "0x181DD7640", Slot = "7")]
		public override void OnValueChanged(CharInfoGroupProperty property)
		{
		}

		// Token: 0x060234BA RID: 144570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234BA")]
		[Address(RVA = "0x1DD75D0", Offset = "0x1DD61D0", VA = "0x181DD75D0")]
		public void OnStateChangeClick()
		{
		}

		// Token: 0x060234BB RID: 144571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234BB")]
		[Address(RVA = "0x1DD78A0", Offset = "0x1DD64A0", VA = "0x181DD78A0")]
		public CharacterInfoHolderViewButtons()
		{
		}

		// Token: 0x04030ACA RID: 199370
		[Token(Token = "0x4030ACA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _starMarkToggle;

		// Token: 0x04030ACB RID: 199371
		[Token(Token = "0x4030ACB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _handbookButton;

		// Token: 0x04030ACC RID: 199372
		[Token(Token = "0x4030ACC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent _onStateClick;

		// Token: 0x04030ACD RID: 199373
		[Token(Token = "0x4030ACD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UICommonTrackPoint _handbookTrackPoint;

		// Token: 0x04030ACE RID: 199374
		[Token(Token = "0x4030ACE")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public TrackPointViewProperty handbookInfoTrackProp;

		// Token: 0x04030ACF RID: 199375
		[Token(Token = "0x4030ACF")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x04030AD0 RID: 199376
		[Token(Token = "0x4030AD0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04030AD1 RID: 199377
		[Token(Token = "0x4030AD1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04030AD2 RID: 199378
		[Token(Token = "0x4030AD2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnStateChangeClick;

		// Token: 0x04030AD3 RID: 199379
		[Token(Token = "0x4030AD3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
