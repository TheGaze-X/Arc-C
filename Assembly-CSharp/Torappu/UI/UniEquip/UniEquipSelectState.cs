using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C16 RID: 15382
	[Token(Token = "0x2003C16")]
	public class UniEquipSelectState : State
	{
		// Token: 0x060180FB RID: 98555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60180FB")]
		[Address(RVA = "0x1089860", Offset = "0x1088460", VA = "0x181089860")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060180FC RID: 98556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60180FC")]
		[Address(RVA = "0x1089060", Offset = "0x1087C60", VA = "0x181089060")]
		public void OnSelectUniEquip(string equipId)
		{
		}

		// Token: 0x060180FD RID: 98557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60180FD")]
		[Address(RVA = "0x1088AE0", Offset = "0x10876E0", VA = "0x181088AE0")]
		public void OnCheckDetail(string equipId)
		{
		}

		// Token: 0x060180FE RID: 98558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60180FE")]
		[Address(RVA = "0x10890E0", Offset = "0x1087CE0", VA = "0x1810890E0")]
		public void OnUnlockUniEquip(string equipId)
		{
		}

		// Token: 0x060180FF RID: 98559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60180FF")]
		[Address(RVA = "0x10887F0", Offset = "0x10873F0", VA = "0x1810887F0")]
		public void OnChangeUniEquip(string equipId)
		{
		}

		// Token: 0x06018100 RID: 98560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018100")]
		[Address(RVA = "0x1088E10", Offset = "0x1087A10", VA = "0x181088E10")]
		public void OnLevelUpUniEquip(string equipId)
		{
		}

		// Token: 0x06018101 RID: 98561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018101")]
		[Address(RVA = "0x1088790", Offset = "0x1087390", VA = "0x181088790", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06018102 RID: 98562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018102")]
		[Address(RVA = "0x1088BA0", Offset = "0x10877A0", VA = "0x181088BA0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06018103 RID: 98563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018103")]
		[Address(RVA = "0x1089960", Offset = "0x1088560", VA = "0x181089960")]
		private void _TriggerAVGSignal()
		{
		}

		// Token: 0x06018104 RID: 98564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018104")]
		[Address(RVA = "0x1088F60", Offset = "0x1087B60", VA = "0x181088F60", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06018105 RID: 98565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018105")]
		[Address(RVA = "0x10891A0", Offset = "0x1087DA0", VA = "0x1810891A0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06018106 RID: 98566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018106")]
		[Address(RVA = "0x10899C0", Offset = "0x10885C0", VA = "0x1810899C0")]
		public UniEquipSelectState()
		{
		}

		// Token: 0x0601810A RID: 98570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601810A")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601810B RID: 98571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601810B")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0601810C RID: 98572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601810C")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0401D305 RID: 119557
		[Token(Token = "0x401D305")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UniEquipSelectStateBean _stateBean;

		// Token: 0x0401D306 RID: 119558
		[Token(Token = "0x401D306")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UniEquipSelectHolder _holder;

		// Token: 0x0401D307 RID: 119559
		[Token(Token = "0x401D307")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isInited;

		// Token: 0x0401D308 RID: 119560
		[Token(Token = "0x401D308")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D309 RID: 119561
		[Token(Token = "0x401D309")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnSelectUniEquip;

		// Token: 0x0401D30A RID: 119562
		[Token(Token = "0x401D30A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCheckDetail;

		// Token: 0x0401D30B RID: 119563
		[Token(Token = "0x401D30B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnUnlockUniEquip;

		// Token: 0x0401D30C RID: 119564
		[Token(Token = "0x401D30C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnChangeUniEquip;

		// Token: 0x0401D30D RID: 119565
		[Token(Token = "0x401D30D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnLevelUpUniEquip;

		// Token: 0x0401D30E RID: 119566
		[Token(Token = "0x401D30E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401D30F RID: 119567
		[Token(Token = "0x401D30F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401D310 RID: 119568
		[Token(Token = "0x401D310")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__TriggerAVGSignal;

		// Token: 0x0401D311 RID: 119569
		[Token(Token = "0x401D311")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0401D312 RID: 119570
		[Token(Token = "0x401D312")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0401D313 RID: 119571
		[Token(Token = "0x401D313")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
