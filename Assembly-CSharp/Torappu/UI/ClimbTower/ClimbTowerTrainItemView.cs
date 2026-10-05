using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C60 RID: 23648
	[Token(Token = "0x2005C60")]
	public class ClimbTowerTrainItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700506E RID: 20590
		// (get) Token: 0x06022430 RID: 140336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700506E")]
		public string towerId
		{
			[Token(Token = "0x6022430")]
			[Address(RVA = "0x1CC64A0", Offset = "0x1CC50A0", VA = "0x181CC64A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700506F RID: 20591
		// (get) Token: 0x06022431 RID: 140337 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022432 RID: 140338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700506F")]
		public Action<string> onTowerSelected
		{
			[Token(Token = "0x6022431")]
			[Address(RVA = "0x1CC6440", Offset = "0x1CC5040", VA = "0x181CC6440")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022432")]
			[Address(RVA = "0x1CC6580", Offset = "0x1CC5180", VA = "0x181CC6580")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005070 RID: 20592
		// (get) Token: 0x06022433 RID: 140339 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022434 RID: 140340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005070")]
		public Action<string> onDetailClicked
		{
			[Token(Token = "0x6022433")]
			[Address(RVA = "0x1CC63E0", Offset = "0x1CC4FE0", VA = "0x181CC63E0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022434")]
			[Address(RVA = "0x1CC6500", Offset = "0x1CC5100", VA = "0x181CC6500")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06022435 RID: 140341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022435")]
		[Address(RVA = "0x1CC61D0", Offset = "0x1CC4DD0", VA = "0x181CC61D0")]
		public void Render(ClimbTowerTrainItemViewModel viewModel, bool isSelected)
		{
		}

		// Token: 0x06022436 RID: 140342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022436")]
		[Address(RVA = "0x1CC6100", Offset = "0x1CC4D00", VA = "0x181CC6100")]
		public void OnTowerSelected()
		{
		}

		// Token: 0x06022437 RID: 140343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022437")]
		[Address(RVA = "0x1CC6050", Offset = "0x1CC4C50", VA = "0x181CC6050")]
		public void OnDetailClicked()
		{
		}

		// Token: 0x06022438 RID: 140344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022438")]
		[Address(RVA = "0x1CC6380", Offset = "0x1CC4F80", VA = "0x181CC6380")]
		public ClimbTowerTrainItemView()
		{
		}

		// Token: 0x0402F0AF RID: 192687
		[Token(Token = "0x402F0AF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _towerId;

		// Token: 0x0402F0B0 RID: 192688
		[Token(Token = "0x402F0B0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textTowerCodeName;

		// Token: 0x0402F0B1 RID: 192689
		[Token(Token = "0x402F0B1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _panelSelected;

		// Token: 0x0402F0B2 RID: 192690
		[Token(Token = "0x402F0B2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelComplete;

		// Token: 0x0402F0B3 RID: 192691
		[Token(Token = "0x402F0B3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelInBattle;

		// Token: 0x0402F0B4 RID: 192692
		[Token(Token = "0x402F0B4")]
		[FieldOffset(Offset = "0x40")]
		private FadeSwitchTween m_completeSwitchTween;

		// Token: 0x0402F0B7 RID: 192695
		[Token(Token = "0x402F0B7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_towerId;

		// Token: 0x0402F0B8 RID: 192696
		[Token(Token = "0x402F0B8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onTowerSelected;

		// Token: 0x0402F0B9 RID: 192697
		[Token(Token = "0x402F0B9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_onTowerSelected;

		// Token: 0x0402F0BA RID: 192698
		[Token(Token = "0x402F0BA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_onDetailClicked;

		// Token: 0x0402F0BB RID: 192699
		[Token(Token = "0x402F0BB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_onDetailClicked;

		// Token: 0x0402F0BC RID: 192700
		[Token(Token = "0x402F0BC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F0BD RID: 192701
		[Token(Token = "0x402F0BD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnTowerSelected;

		// Token: 0x0402F0BE RID: 192702
		[Token(Token = "0x402F0BE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDetailClicked;

		// Token: 0x0402F0BF RID: 192703
		[Token(Token = "0x402F0BF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
