using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.StationSelect
{
	// Token: 0x02001C85 RID: 7301
	[Token(Token = "0x2001C85")]
	public class BuildingStationSelectCharInfoView : DataBinder<StationCharGroupProperty>
	{
		// Token: 0x0600B555 RID: 46421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B555")]
		[Address(RVA = "0x32F04F0", Offset = "0x32EF0F0", VA = "0x1832F04F0", Slot = "7")]
		public override void OnValueChanged(StationCharGroupProperty property)
		{
		}

		// Token: 0x0600B556 RID: 46422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B556")]
		[Address(RVA = "0x32F0EC0", Offset = "0x32EFAC0", VA = "0x1832F0EC0")]
		private void _RenderActive()
		{
		}

		// Token: 0x0600B557 RID: 46423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B557")]
		[Address(RVA = "0x32F1150", Offset = "0x32EFD50", VA = "0x1832F1150")]
		private IEnumerator _UpdateAutoLayoutsCoroutine()
		{
			return null;
		}

		// Token: 0x0600B558 RID: 46424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B558")]
		[Address(RVA = "0x32F0AF0", Offset = "0x32EF6F0", VA = "0x1832F0AF0")]
		private void _OnManpowerChanged()
		{
		}

		// Token: 0x0600B559 RID: 46425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B559")]
		[Address(RVA = "0x32F03F0", Offset = "0x32EEFF0", VA = "0x1832F03F0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600B55A RID: 46426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B55A")]
		[Address(RVA = "0x32F0A70", Offset = "0x32EF670", VA = "0x1832F0A70")]
		private void Update()
		{
		}

		// Token: 0x0600B55B RID: 46427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B55B")]
		[Address(RVA = "0x32F1200", Offset = "0x32EFE00", VA = "0x1832F1200")]
		public BuildingStationSelectCharInfoView()
		{
		}

		// Token: 0x0400B183 RID: 45443
		[Token(Token = "0x400B183")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelActive;

		// Token: 0x0400B184 RID: 45444
		[Token(Token = "0x400B184")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0400B185 RID: 45445
		[Token(Token = "0x400B185")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textAp;

		// Token: 0x0400B186 RID: 45446
		[Token(Token = "0x400B186")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textApLimit;

		// Token: 0x0400B187 RID: 45447
		[Token(Token = "0x400B187")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _manpowerBarContainer;

		// Token: 0x0400B188 RID: 45448
		[Token(Token = "0x400B188")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _autoLayoutAp;

		// Token: 0x0400B189 RID: 45449
		[Token(Token = "0x400B189")]
		[FieldOffset(Offset = "0x50")]
		private StationCharViewModel m_selectedChar;

		// Token: 0x0400B18A RID: 45450
		[Token(Token = "0x400B18A")]
		[FieldOffset(Offset = "0x58")]
		private BuildingCharModel m_buildingCharCache;

		// Token: 0x0400B18B RID: 45451
		[Token(Token = "0x400B18B")]
		[FieldOffset(Offset = "0xD0")]
		private BuildingCharMPStateBar m_manpowerBar;

		// Token: 0x0400B18C RID: 45452
		[Token(Token = "0x400B18C")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_isInited;

		// Token: 0x0400B18D RID: 45453
		[Token(Token = "0x400B18D")]
		[FieldOffset(Offset = "0xE0")]
		private CountDownTask m_workTimeCountDown;

		// Token: 0x0400B18E RID: 45454
		[Token(Token = "0x400B18E")]
		[FieldOffset(Offset = "0xE8")]
		private BuildingCharMPHelper m_mpHelper;

		// Token: 0x0400B18F RID: 45455
		[Token(Token = "0x400B18F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400B190 RID: 45456
		[Token(Token = "0x400B190")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderActive;

		// Token: 0x0400B191 RID: 45457
		[Token(Token = "0x400B191")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateAutoLayoutsCoroutine;

		// Token: 0x0400B192 RID: 45458
		[Token(Token = "0x400B192")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnManpowerChanged;

		// Token: 0x0400B193 RID: 45459
		[Token(Token = "0x400B193")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0400B194 RID: 45460
		[Token(Token = "0x400B194")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400B195 RID: 45461
		[Token(Token = "0x400B195")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
