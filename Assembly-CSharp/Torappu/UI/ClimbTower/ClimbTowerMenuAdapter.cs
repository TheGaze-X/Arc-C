using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CC7 RID: 23751
	[Token(Token = "0x2005CC7")]
	public class ClimbTowerMenuAdapter : IHotfixable
	{
		// Token: 0x170050CA RID: 20682
		// (get) Token: 0x06022622 RID: 140834 RVA: 0x000BD3D8 File Offset: 0x000BB5D8
		[Token(Token = "0x170050CA")]
		public virtual bool showMenu
		{
			[Token(Token = "0x6022622")]
			[Address(RVA = "0x1CD20F0", Offset = "0x1CD0CF0", VA = "0x181CD20F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170050CB RID: 20683
		// (get) Token: 0x06022623 RID: 140835 RVA: 0x000BD3F0 File Offset: 0x000BB5F0
		[Token(Token = "0x170050CB")]
		public virtual ClimbTowerMenu.TweenType preferredMenuShowType
		{
			[Token(Token = "0x6022623")]
			[Address(RVA = "0x1CD2030", Offset = "0x1CD0C30", VA = "0x181CD2030", Slot = "5")]
			get
			{
				return ClimbTowerMenu.TweenType.NONE;
			}
		}

		// Token: 0x170050CC RID: 20684
		// (get) Token: 0x06022624 RID: 140836 RVA: 0x000BD408 File Offset: 0x000BB608
		[Token(Token = "0x170050CC")]
		public virtual bool hideBuffBtnWithHolder
		{
			[Token(Token = "0x6022624")]
			[Address(RVA = "0x1CD1F10", Offset = "0x1CD0B10", VA = "0x181CD1F10", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170050CD RID: 20685
		// (get) Token: 0x06022625 RID: 140837 RVA: 0x000BD420 File Offset: 0x000BB620
		[Token(Token = "0x170050CD")]
		public virtual bool showTrapBtn
		{
			[Token(Token = "0x6022625")]
			[Address(RVA = "0x1CD2210", Offset = "0x1CD0E10", VA = "0x181CD2210", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170050CE RID: 20686
		// (get) Token: 0x06022626 RID: 140838 RVA: 0x000BD438 File Offset: 0x000BB638
		[Token(Token = "0x170050CE")]
		public virtual bool showSquadBtn
		{
			[Token(Token = "0x6022626")]
			[Address(RVA = "0x1CD21B0", Offset = "0x1CD0DB0", VA = "0x181CD21B0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170050CF RID: 20687
		// (get) Token: 0x06022627 RID: 140839 RVA: 0x000BD450 File Offset: 0x000BB650
		[Token(Token = "0x170050CF")]
		public virtual ClimbTowerTrapMenuObject.ButtonState trapBtnState
		{
			[Token(Token = "0x6022627")]
			[Address(RVA = "0x1CD22D0", Offset = "0x1CD0ED0", VA = "0x181CD22D0", Slot = "9")]
			get
			{
				return ClimbTowerTrapMenuObject.ButtonState.NORMAL;
			}
		}

		// Token: 0x170050D0 RID: 20688
		// (get) Token: 0x06022628 RID: 140840 RVA: 0x000BD468 File Offset: 0x000BB668
		[Token(Token = "0x170050D0")]
		public virtual ClimbTowerSquadMenuObject.ButtonState squadBtnState
		{
			[Token(Token = "0x6022628")]
			[Address(RVA = "0x1CD2270", Offset = "0x1CD0E70", VA = "0x181CD2270", Slot = "10")]
			get
			{
				return ClimbTowerSquadMenuObject.ButtonState.NORMAL;
			}
		}

		// Token: 0x170050D1 RID: 20689
		// (get) Token: 0x06022629 RID: 140841 RVA: 0x000BD480 File Offset: 0x000BB680
		[Token(Token = "0x170050D1")]
		public virtual bool showProfessionBtns
		{
			[Token(Token = "0x6022629")]
			[Address(RVA = "0x1CD2150", Offset = "0x1CD0D50", VA = "0x181CD2150", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170050D2 RID: 20690
		// (get) Token: 0x0602262A RID: 140842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170050D2")]
		public virtual ClimbTowerProfessionMenuObject.GetProfessionCharCount overrideGetProfessionCharCount
		{
			[Token(Token = "0x602262A")]
			[Address(RVA = "0x1CD1FD0", Offset = "0x1CD0BD0", VA = "0x181CD1FD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x170050D3 RID: 20691
		// (get) Token: 0x0602262B RID: 140843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170050D3")]
		public virtual Action<ProfessionCategory> onProfessionClickedCallback
		{
			[Token(Token = "0x602262B")]
			[Address(RVA = "0x1CD1F70", Offset = "0x1CD0B70", VA = "0x181CD1F70", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x170050D4 RID: 20692
		// (get) Token: 0x0602262C RID: 140844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170050D4")]
		public virtual ClimbTowerMenuButton buttonPrefab
		{
			[Token(Token = "0x602262C")]
			[Address(RVA = "0x1CD1EB0", Offset = "0x1CD0AB0", VA = "0x181CD1EB0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170050D5 RID: 20693
		// (get) Token: 0x0602262D RID: 140845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170050D5")]
		public virtual IClimbTowerMenuButtonDataSource buttonDataSource
		{
			[Token(Token = "0x602262D")]
			[Address(RVA = "0x1CD1E50", Offset = "0x1CD0A50", VA = "0x181CD1E50", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x170050D6 RID: 20694
		// (get) Token: 0x0602262E RID: 140846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170050D6")]
		public virtual Action buttonCallback
		{
			[Token(Token = "0x602262E")]
			[Address(RVA = "0x1CD1DF0", Offset = "0x1CD09F0", VA = "0x181CD1DF0", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x170050D7 RID: 20695
		// (get) Token: 0x0602262F RID: 140847 RVA: 0x000BD498 File Offset: 0x000BB698
		[Token(Token = "0x170050D7")]
		public virtual bool showEffect
		{
			[Token(Token = "0x602262F")]
			[Address(RVA = "0x1CD2090", Offset = "0x1CD0C90", VA = "0x181CD2090", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06022630 RID: 140848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022630")]
		[Address(RVA = "0x1CD1D10", Offset = "0x1CD0910", VA = "0x181CD1D10")]
		public void NotifyAdapterChanged(bool fastMode)
		{
		}

		// Token: 0x06022631 RID: 140849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022631")]
		[Address(RVA = "0x1CD1D90", Offset = "0x1CD0990", VA = "0x181CD1D90")]
		public ClimbTowerMenuAdapter()
		{
		}

		// Token: 0x0402F405 RID: 193541
		[Token(Token = "0x402F405")]
		[FieldOffset(Offset = "0x10")]
		public Action<bool> observer;

		// Token: 0x0402F406 RID: 193542
		[Token(Token = "0x402F406")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_showMenu;

		// Token: 0x0402F407 RID: 193543
		[Token(Token = "0x402F407")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_preferredMenuShowType;

		// Token: 0x0402F408 RID: 193544
		[Token(Token = "0x402F408")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_hideBuffBtnWithHolder;

		// Token: 0x0402F409 RID: 193545
		[Token(Token = "0x402F409")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_showTrapBtn;

		// Token: 0x0402F40A RID: 193546
		[Token(Token = "0x402F40A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_showSquadBtn;

		// Token: 0x0402F40B RID: 193547
		[Token(Token = "0x402F40B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_trapBtnState;

		// Token: 0x0402F40C RID: 193548
		[Token(Token = "0x402F40C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_squadBtnState;

		// Token: 0x0402F40D RID: 193549
		[Token(Token = "0x402F40D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_showProfessionBtns;

		// Token: 0x0402F40E RID: 193550
		[Token(Token = "0x402F40E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_overrideGetProfessionCharCount;

		// Token: 0x0402F40F RID: 193551
		[Token(Token = "0x402F40F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_onProfessionClickedCallback;

		// Token: 0x0402F410 RID: 193552
		[Token(Token = "0x402F410")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_buttonPrefab;

		// Token: 0x0402F411 RID: 193553
		[Token(Token = "0x402F411")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_buttonDataSource;

		// Token: 0x0402F412 RID: 193554
		[Token(Token = "0x402F412")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_buttonCallback;

		// Token: 0x0402F413 RID: 193555
		[Token(Token = "0x402F413")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_showEffect;

		// Token: 0x0402F414 RID: 193556
		[Token(Token = "0x402F414")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_NotifyAdapterChanged;

		// Token: 0x0402F415 RID: 193557
		[Token(Token = "0x402F415")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
