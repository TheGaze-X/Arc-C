using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Float
{
	// Token: 0x02001DF4 RID: 7668
	[Token(Token = "0x2001DF4")]
	public class BuildingFloatPrivateStationView : AbstractBuildingUIFloatStationView
	{
		// Token: 0x0600BD67 RID: 48487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD67")]
		[Address(RVA = "0x33A0A90", Offset = "0x339F690", VA = "0x1833A0A90", Slot = "7")]
		public override void OnValueChanged(FloatStationViewProperty property)
		{
		}

		// Token: 0x0600BD68 RID: 48488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD68")]
		[Address(RVA = "0x33A0C40", Offset = "0x339F840", VA = "0x1833A0C40")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600BD69 RID: 48489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD69")]
		[Address(RVA = "0x33A1190", Offset = "0x339FD90", VA = "0x1833A1190")]
		private void _UpdateShowEffect(bool isInited, bool isShow)
		{
		}

		// Token: 0x0600BD6A RID: 48490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD6A")]
		[Address(RVA = "0x33A0CC0", Offset = "0x339F8C0", VA = "0x1833A0CC0")]
		private void _UpdateContent(RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600BD6B RID: 48491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD6B")]
		[Address(RVA = "0x33A0920", Offset = "0x339F520", VA = "0x1833A0920")]
		public void OnRecallBtnClicked()
		{
		}

		// Token: 0x0600BD6C RID: 48492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD6C")]
		[Address(RVA = "0x33A0700", Offset = "0x339F300", VA = "0x1833A0700")]
		public void OnCharClicked()
		{
		}

		// Token: 0x0600BD6D RID: 48493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD6D")]
		[Address(RVA = "0x33A1590", Offset = "0x33A0190", VA = "0x1833A1590")]
		public BuildingFloatPrivateStationView()
		{
		}

		// Token: 0x0400BDBB RID: 48571
		[Token(Token = "0x400BDBB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _showAnim;

		// Token: 0x0400BDBC RID: 48572
		[Token(Token = "0x400BDBC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _panelBlank;

		// Token: 0x0400BDBD RID: 48573
		[Token(Token = "0x400BDBD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _txtChar;

		// Token: 0x0400BDBE RID: 48574
		[Token(Token = "0x400BDBE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasImage _imgChar;

		// Token: 0x0400BDBF RID: 48575
		[Token(Token = "0x400BDBF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelFavor;

		// Token: 0x0400BDC0 RID: 48576
		[Token(Token = "0x400BDC0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _txtFavor;

		// Token: 0x0400BDC1 RID: 48577
		[Token(Token = "0x400BDC1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelChar;

		// Token: 0x0400BDC2 RID: 48578
		[Token(Token = "0x400BDC2")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _txtCharNum;

		// Token: 0x0400BDC3 RID: 48579
		[Token(Token = "0x400BDC3")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TwoStateToggle _recallStateToggle;

		// Token: 0x0400BDC4 RID: 48580
		[Token(Token = "0x400BDC4")]
		[FieldOffset(Offset = "0x78")]
		private FloatStationViewModel m_viewModel;

		// Token: 0x0400BDC5 RID: 48581
		[Token(Token = "0x400BDC5")]
		[FieldOffset(Offset = "0x80")]
		private int m_charInstId;

		// Token: 0x0400BDC6 RID: 48582
		[Token(Token = "0x400BDC6")]
		[FieldOffset(Offset = "0x84")]
		private bool m_isShow;

		// Token: 0x0400BDC7 RID: 48583
		[Token(Token = "0x400BDC7")]
		[FieldOffset(Offset = "0x88")]
		private Tween m_tweenCache;

		// Token: 0x0400BDC8 RID: 48584
		[Token(Token = "0x400BDC8")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isInited;

		// Token: 0x0400BDC9 RID: 48585
		[Token(Token = "0x400BDC9")]
		[FieldOffset(Offset = "0x98")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0400BDCA RID: 48586
		[Token(Token = "0x400BDCA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400BDCB RID: 48587
		[Token(Token = "0x400BDCB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400BDCC RID: 48588
		[Token(Token = "0x400BDCC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateShowEffect;

		// Token: 0x0400BDCD RID: 48589
		[Token(Token = "0x400BDCD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateContent;

		// Token: 0x0400BDCE RID: 48590
		[Token(Token = "0x400BDCE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnRecallBtnClicked;

		// Token: 0x0400BDCF RID: 48591
		[Token(Token = "0x400BDCF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCharClicked;

		// Token: 0x0400BDD0 RID: 48592
		[Token(Token = "0x400BDD0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
