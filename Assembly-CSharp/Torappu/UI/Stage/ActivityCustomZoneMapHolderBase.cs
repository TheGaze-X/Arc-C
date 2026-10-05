using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020068D8 RID: 26840
	[Token(Token = "0x20068D8")]
	public abstract class ActivityCustomZoneMapHolderBase : DataBinder<ActivityCustomZoneMapProperty>
	{
		// Token: 0x0602674C RID: 157516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602674C")]
		[Address(RVA = "0x2176770", Offset = "0x2175370", VA = "0x182176770", Slot = "7")]
		public override void OnValueChanged(ActivityCustomZoneMapProperty property)
		{
		}

		// Token: 0x0602674D RID: 157517 RVA: 0x000CB370 File Offset: 0x000C9570
		[Token(Token = "0x602674D")]
		[Address(RVA = "0x2176B30", Offset = "0x2175730", VA = "0x182176B30")]
		private bool _TryLoadCustomZoneMap(string prefabPath)
		{
			return default(bool);
		}

		// Token: 0x0602674E RID: 157518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602674E")]
		[Address(RVA = "0x2176860", Offset = "0x2175460", VA = "0x182176860")]
		private void _ClearLoadedZoneMap()
		{
		}

		// Token: 0x0602674F RID: 157519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602674F")]
		[Address(RVA = "0x2176930", Offset = "0x2175530", VA = "0x182176930", Slot = "8")]
		protected virtual void _InitZoneMap(ActivityCustomZoneMap zoneMap)
		{
		}

		// Token: 0x06026750 RID: 157520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026750")]
		[Address(RVA = "0x2176680", Offset = "0x2175280", VA = "0x182176680", Slot = "9")]
		protected virtual void OnStageBtnClicked(string stageId)
		{
		}

		// Token: 0x06026751 RID: 157521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026751")]
		[Address(RVA = "0x2176D50", Offset = "0x2175950", VA = "0x182176D50")]
		protected ActivityCustomZoneMapHolderBase()
		{
		}

		// Token: 0x040362DF RID: 221919
		[Token(Token = "0x40362DF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _customZoneMapParent;

		// Token: 0x040362E0 RID: 221920
		[Token(Token = "0x40362E0")]
		[FieldOffset(Offset = "0x28")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040362E1 RID: 221921
		[Token(Token = "0x40362E1")]
		[FieldOffset(Offset = "0x38")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040362E2 RID: 221922
		[Token(Token = "0x40362E2")]
		[FieldOffset(Offset = "0x48")]
		private string m_zoneMapPathCache;

		// Token: 0x040362E3 RID: 221923
		[Token(Token = "0x40362E3")]
		[FieldOffset(Offset = "0x50")]
		private ActivityCustomZoneMap m_zoneMap;

		// Token: 0x040362E4 RID: 221924
		[Token(Token = "0x40362E4")]
		[FieldOffset(Offset = "0x58")]
		protected ActivityCustomZoneMapViewModel m_cachedZoneMapModel;

		// Token: 0x040362E5 RID: 221925
		[Token(Token = "0x40362E5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040362E6 RID: 221926
		[Token(Token = "0x40362E6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__TryLoadCustomZoneMap;

		// Token: 0x040362E7 RID: 221927
		[Token(Token = "0x40362E7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ClearLoadedZoneMap;

		// Token: 0x040362E8 RID: 221928
		[Token(Token = "0x40362E8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitZoneMap;

		// Token: 0x040362E9 RID: 221929
		[Token(Token = "0x40362E9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnStageBtnClicked;

		// Token: 0x040362EA RID: 221930
		[Token(Token = "0x40362EA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
