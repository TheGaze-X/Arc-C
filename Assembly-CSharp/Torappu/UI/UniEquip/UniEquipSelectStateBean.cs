using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C3E RID: 15422
	[Token(Token = "0x2003C3E")]
	public class UniEquipSelectStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x17003998 RID: 14744
		// (get) Token: 0x060181CE RID: 98766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003998")]
		public string charId
		{
			[Token(Token = "0x60181CE")]
			[Address(RVA = "0x109AEB0", Offset = "0x1099AB0", VA = "0x18109AEB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003999 RID: 14745
		// (get) Token: 0x060181D0 RID: 98768 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060181CF RID: 98767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003999")]
		public string targetEquipId
		{
			[Token(Token = "0x60181D0")]
			[Address(RVA = "0x109AF40", Offset = "0x1099B40", VA = "0x18109AF40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60181CF")]
			[Address(RVA = "0x109B0D0", Offset = "0x1099CD0", VA = "0x18109B0D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700399A RID: 14746
		// (get) Token: 0x060181D1 RID: 98769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700399A")]
		public UniEquipSelectViewModel targetSelectViewModel
		{
			[Token(Token = "0x60181D1")]
			[Address(RVA = "0x109AFA0", Offset = "0x1099BA0", VA = "0x18109AFA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060181D2 RID: 98770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181D2")]
		[Address(RVA = "0x109A100", Offset = "0x1098D00", VA = "0x18109A100")]
		public void RefreshViewModel(int charInstId, string initSelectEquipId, bool isAvgRunning, bool needFocus = false)
		{
		}

		// Token: 0x060181D3 RID: 98771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181D3")]
		[Address(RVA = "0x109A920", Offset = "0x1099520", VA = "0x18109A920")]
		private void _GeneTalentDesc(UniEquipSelectList selectList, PlayerCharacter playerChar)
		{
		}

		// Token: 0x060181D4 RID: 98772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181D4")]
		[Address(RVA = "0x109A4D0", Offset = "0x10990D0", VA = "0x18109A4D0")]
		private void _CalculateAttibute(UniEquipSelectList selectList, PlayerCharacter playerChar)
		{
		}

		// Token: 0x060181D5 RID: 98773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181D5")]
		[Address(RVA = "0x1099E30", Offset = "0x1098A30", VA = "0x181099E30")]
		public void OnSelectUniEquip(string uniEquipId)
		{
		}

		// Token: 0x060181D6 RID: 98774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60181D6")]
		[Address(RVA = "0x1099D50", Offset = "0x1098950", VA = "0x181099D50")]
		public UniEquipSelectViewModel GetViewModelById(string equipId)
		{
			return null;
		}

		// Token: 0x060181D7 RID: 98775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181D7")]
		[Address(RVA = "0x109ADC0", Offset = "0x10999C0", VA = "0x18109ADC0")]
		public UniEquipSelectStateBean()
		{
		}

		// Token: 0x0401D499 RID: 119961
		[Token(Token = "0x401D499")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public UniEquipSelectProperty property;

		// Token: 0x0401D49B RID: 119963
		[Token(Token = "0x401D49B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charId;

		// Token: 0x0401D49C RID: 119964
		[Token(Token = "0x401D49C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_targetEquipId;

		// Token: 0x0401D49D RID: 119965
		[Token(Token = "0x401D49D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_targetEquipId;

		// Token: 0x0401D49E RID: 119966
		[Token(Token = "0x401D49E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_targetSelectViewModel;

		// Token: 0x0401D49F RID: 119967
		[Token(Token = "0x401D49F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RefreshViewModel;

		// Token: 0x0401D4A0 RID: 119968
		[Token(Token = "0x401D4A0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GeneTalentDesc;

		// Token: 0x0401D4A1 RID: 119969
		[Token(Token = "0x401D4A1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CalculateAttibute;

		// Token: 0x0401D4A2 RID: 119970
		[Token(Token = "0x401D4A2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnSelectUniEquip;

		// Token: 0x0401D4A3 RID: 119971
		[Token(Token = "0x401D4A3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetViewModelById;

		// Token: 0x0401D4A4 RID: 119972
		[Token(Token = "0x401D4A4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
