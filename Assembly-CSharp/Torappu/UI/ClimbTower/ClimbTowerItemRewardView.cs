using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C5C RID: 23644
	[Token(Token = "0x2005C5C")]
	public class ClimbTowerItemRewardView : DataBinder<ClimbTowerItemRewardProperty>, IHotfixable
	{
		// Token: 0x1700506C RID: 20588
		// (get) Token: 0x06022423 RID: 140323 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022424 RID: 140324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700506C")]
		public Action onClicked
		{
			[Token(Token = "0x6022423")]
			[Address(RVA = "0x1CBB980", Offset = "0x1CBA580", VA = "0x181CBB980")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022424")]
			[Address(RVA = "0x1CBB9E0", Offset = "0x1CBA5E0", VA = "0x181CBB9E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06022425 RID: 140325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022425")]
		[Address(RVA = "0x1CBB4D0", Offset = "0x1CBA0D0", VA = "0x181CBB4D0")]
		public void OnClicked()
		{
		}

		// Token: 0x06022426 RID: 140326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022426")]
		[Address(RVA = "0x1CBB5E0", Offset = "0x1CBA1E0", VA = "0x181CBB5E0", Slot = "7")]
		public override void OnValueChanged(ClimbTowerItemRewardProperty property)
		{
		}

		// Token: 0x06022427 RID: 140327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022427")]
		[Address(RVA = "0x1CBB8E0", Offset = "0x1CBA4E0", VA = "0x181CBB8E0")]
		public ClimbTowerItemRewardView()
		{
		}

		// Token: 0x0402F08C RID: 192652
		[Token(Token = "0x402F08C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _rewardProgressFormat;

		// Token: 0x0402F08D RID: 192653
		[Token(Token = "0x402F08D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textLowerProgress;

		// Token: 0x0402F08E RID: 192654
		[Token(Token = "0x402F08E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Slider _sliderLowerProgress;

		// Token: 0x0402F08F RID: 192655
		[Token(Token = "0x402F08F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textLowerItemName;

		// Token: 0x0402F090 RID: 192656
		[Token(Token = "0x402F090")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textHigherProgress;

		// Token: 0x0402F091 RID: 192657
		[Token(Token = "0x402F091")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Slider _sliderHigherProgress;

		// Token: 0x0402F092 RID: 192658
		[Token(Token = "0x402F092")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textHigherItemName;

		// Token: 0x0402F093 RID: 192659
		[Token(Token = "0x402F093")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textCountDown;

		// Token: 0x0402F094 RID: 192660
		[Token(Token = "0x402F094")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TwoStateToggle _toggleBtnBkg;

		// Token: 0x0402F096 RID: 192662
		[Token(Token = "0x402F096")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClicked;

		// Token: 0x0402F097 RID: 192663
		[Token(Token = "0x402F097")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClicked;

		// Token: 0x0402F098 RID: 192664
		[Token(Token = "0x402F098")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClicked;

		// Token: 0x0402F099 RID: 192665
		[Token(Token = "0x402F099")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402F09A RID: 192666
		[Token(Token = "0x402F09A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
