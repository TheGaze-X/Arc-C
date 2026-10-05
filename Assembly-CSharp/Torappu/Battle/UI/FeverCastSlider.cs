using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003290 RID: 12944
	[Token(Token = "0x2003290")]
	public class FeverCastSlider : MonoBehaviour, HudPlugin, IHotfixable
	{
		// Token: 0x170030A0 RID: 12448
		// (get) Token: 0x060148C3 RID: 84163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030A0")]
		private FeverSystemManager feverManager
		{
			[Token(Token = "0x60148C3")]
			[Address(RVA = "0xCCD970", Offset = "0xCCC570", VA = "0x180CCD970")]
			get
			{
				return null;
			}
		}

		// Token: 0x170030A1 RID: 12449
		// (get) Token: 0x060148C4 RID: 84164 RVA: 0x00087678 File Offset: 0x00085878
		[Token(Token = "0x170030A1")]
		public bool needToShow
		{
			[Token(Token = "0x60148C4")]
			[Address(RVA = "0xCCDAE0", Offset = "0xCCC6E0", VA = "0x180CCDAE0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170030A2 RID: 12450
		// (get) Token: 0x060148C5 RID: 84165 RVA: 0x00087690 File Offset: 0x00085890
		[Token(Token = "0x170030A2")]
		public HudPluginMask hudMask
		{
			[Token(Token = "0x60148C5")]
			[Address(RVA = "0xCCDA80", Offset = "0xCCC680", VA = "0x180CCDA80", Slot = "4")]
			get
			{
				return HudPluginMask.NONE;
			}
		}

		// Token: 0x060148C6 RID: 84166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148C6")]
		[Address(RVA = "0xCCD270", Offset = "0xCCBE70", VA = "0x180CCD270", Slot = "6")]
		public void OnAttach(Unit owner)
		{
		}

		// Token: 0x060148C7 RID: 84167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148C7")]
		[Address(RVA = "0xCCD4A0", Offset = "0xCCC0A0", VA = "0x180CCD4A0", Slot = "7")]
		public void OnDetach()
		{
		}

		// Token: 0x060148C8 RID: 84168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148C8")]
		[Address(RVA = "0xCCD560", Offset = "0xCCC160", VA = "0x180CCD560", Slot = "8")]
		public void UpdatePlugin()
		{
		}

		// Token: 0x060148C9 RID: 84169 RVA: 0x000876A8 File Offset: 0x000858A8
		[Token(Token = "0x60148C9")]
		[Address(RVA = "0xCCD630", Offset = "0xCCC230", VA = "0x180CCD630")]
		private bool _ShowFeverSlider()
		{
			return default(bool);
		}

		// Token: 0x060148CA RID: 84170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148CA")]
		[Address(RVA = "0xCCD8E0", Offset = "0xCCC4E0", VA = "0x180CCD8E0")]
		public FeverCastSlider()
		{
		}

		// Token: 0x040184C5 RID: 99525
		[Token(Token = "0x40184C5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UITextSlider _castSlider;

		// Token: 0x040184C6 RID: 99526
		[Token(Token = "0x40184C6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _castSliderRoot;

		// Token: 0x040184C7 RID: 99527
		[Token(Token = "0x40184C7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _feverKey;

		// Token: 0x040184C8 RID: 99528
		[Token(Token = "0x40184C8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _characterGroupTag;

		// Token: 0x040184C9 RID: 99529
		[Token(Token = "0x40184C9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIHudCharSpCastSlider _originSpCastSlider;

		// Token: 0x040184CA RID: 99530
		[Token(Token = "0x40184CA")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isCharacterValid;

		// Token: 0x040184CB RID: 99531
		[Token(Token = "0x40184CB")]
		[FieldOffset(Offset = "0x44")]
		private float m_remainingRatio;

		// Token: 0x040184CC RID: 99532
		[Token(Token = "0x40184CC")]
		[FieldOffset(Offset = "0x48")]
		private FeverSystemManager m_feverSystemManager;

		// Token: 0x040184CD RID: 99533
		[Token(Token = "0x40184CD")]
		[FieldOffset(Offset = "0x50")]
		private ObjectPtr<Character> m_owner;

		// Token: 0x040184CE RID: 99534
		[Token(Token = "0x40184CE")]
		[FieldOffset(Offset = "0x60")]
		private FeverBehaviour m_feverBehaviour;

		// Token: 0x040184CF RID: 99535
		[Token(Token = "0x40184CF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_feverManager;

		// Token: 0x040184D0 RID: 99536
		[Token(Token = "0x40184D0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_needToShow;

		// Token: 0x040184D1 RID: 99537
		[Token(Token = "0x40184D1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_hudMask;

		// Token: 0x040184D2 RID: 99538
		[Token(Token = "0x40184D2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnAttach;

		// Token: 0x040184D3 RID: 99539
		[Token(Token = "0x40184D3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDetach;

		// Token: 0x040184D4 RID: 99540
		[Token(Token = "0x40184D4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdatePlugin;

		// Token: 0x040184D5 RID: 99541
		[Token(Token = "0x40184D5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ShowFeverSlider;

		// Token: 0x040184D6 RID: 99542
		[Token(Token = "0x40184D6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
