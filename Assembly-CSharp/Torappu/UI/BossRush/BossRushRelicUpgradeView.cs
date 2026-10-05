using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x0200618F RID: 24975
	[Token(Token = "0x200618F")]
	public class BossRushRelicUpgradeView : DataBinder<BossRushRelicUpgradeViewProperty>
	{
		// Token: 0x17005505 RID: 21765
		// (get) Token: 0x0602406B RID: 147563 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602406C RID: 147564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005505")]
		public Action onBackClickedAction
		{
			[Token(Token = "0x602406B")]
			[Address(RVA = "0x1EA9910", Offset = "0x1EA8510", VA = "0x181EA9910")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602406C")]
			[Address(RVA = "0x1EA99D0", Offset = "0x1EA85D0", VA = "0x181EA99D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005506 RID: 21766
		// (get) Token: 0x0602406D RID: 147565 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602406E RID: 147566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005506")]
		public Action<string> onUpgradeClickedAction
		{
			[Token(Token = "0x602406D")]
			[Address(RVA = "0x1EA9970", Offset = "0x1EA8570", VA = "0x181EA9970")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602406E")]
			[Address(RVA = "0x1EA9A50", Offset = "0x1EA8650", VA = "0x181EA9A50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602406F RID: 147567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602406F")]
		[Address(RVA = "0x1EA91A0", Offset = "0x1EA7DA0", VA = "0x181EA91A0", Slot = "7")]
		public override void OnValueChanged(BossRushRelicUpgradeViewProperty property)
		{
		}

		// Token: 0x06024070 RID: 147568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024070")]
		[Address(RVA = "0x1EA9830", Offset = "0x1EA8430", VA = "0x181EA9830")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024071 RID: 147569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024071")]
		[Address(RVA = "0x1EA90C0", Offset = "0x1EA7CC0", VA = "0x181EA90C0")]
		public void EventOnUpgradeClick()
		{
		}

		// Token: 0x06024072 RID: 147570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024072")]
		[Address(RVA = "0x1EA98A0", Offset = "0x1EA84A0", VA = "0x181EA98A0")]
		public BossRushRelicUpgradeView()
		{
		}

		// Token: 0x040320D2 RID: 205010
		[Token(Token = "0x40320D2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objUpgradePart;

		// Token: 0x040320D3 RID: 205011
		[Token(Token = "0x40320D3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objLackPart;

		// Token: 0x040320D4 RID: 205012
		[Token(Token = "0x40320D4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtName;

		// Token: 0x040320D5 RID: 205013
		[Token(Token = "0x40320D5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtLevel;

		// Token: 0x040320D6 RID: 205014
		[Token(Token = "0x40320D6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _txtDesNow;

		// Token: 0x040320D7 RID: 205015
		[Token(Token = "0x40320D7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _txtDesNext;

		// Token: 0x040320D8 RID: 205016
		[Token(Token = "0x40320D8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _txtToUpgrade;

		// Token: 0x040320D9 RID: 205017
		[Token(Token = "0x40320D9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _imgRelicIcon;

		// Token: 0x040320DA RID: 205018
		[Token(Token = "0x40320DA")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _txtTokenName;

		// Token: 0x040320DB RID: 205019
		[Token(Token = "0x40320DB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _txtTokenCount;

		// Token: 0x040320DE RID: 205022
		[Token(Token = "0x40320DE")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x040320DF RID: 205023
		[Token(Token = "0x40320DF")]
		[FieldOffset(Offset = "0x88")]
		private string m_relicId;

		// Token: 0x040320E0 RID: 205024
		[Token(Token = "0x40320E0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onBackClickedAction;

		// Token: 0x040320E1 RID: 205025
		[Token(Token = "0x40320E1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onBackClickedAction;

		// Token: 0x040320E2 RID: 205026
		[Token(Token = "0x40320E2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onUpgradeClickedAction;

		// Token: 0x040320E3 RID: 205027
		[Token(Token = "0x40320E3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onUpgradeClickedAction;

		// Token: 0x040320E4 RID: 205028
		[Token(Token = "0x40320E4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040320E5 RID: 205029
		[Token(Token = "0x40320E5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040320E6 RID: 205030
		[Token(Token = "0x40320E6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnUpgradeClick;

		// Token: 0x040320E7 RID: 205031
		[Token(Token = "0x40320E7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
