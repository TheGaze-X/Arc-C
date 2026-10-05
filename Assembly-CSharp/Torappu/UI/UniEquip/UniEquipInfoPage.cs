using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C1D RID: 15389
	[Token(Token = "0x2003C1D")]
	public class UniEquipInfoPage : StateEnginePage
	{
		// Token: 0x06018133 RID: 98611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018133")]
		[Address(RVA = "0x1087B40", Offset = "0x1086740", VA = "0x181087B40")]
		private void _ReturnPage()
		{
		}

		// Token: 0x06018134 RID: 98612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018134")]
		[Address(RVA = "0x1087A60", Offset = "0x1086660", VA = "0x181087A60", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x06018135 RID: 98613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018135")]
		[Address(RVA = "0x1087BE0", Offset = "0x10867E0", VA = "0x181087BE0")]
		private void _OnInitTopMenu(GameObject inst)
		{
		}

		// Token: 0x06018136 RID: 98614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018136")]
		[Address(RVA = "0x1087D10", Offset = "0x1086910", VA = "0x181087D10")]
		public UniEquipInfoPage()
		{
		}

		// Token: 0x06018138 RID: 98616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018138")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0401D337 RID: 119607
		[Token(Token = "0x401D337")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x0401D338 RID: 119608
		[Token(Token = "0x401D338")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__ReturnPage;

		// Token: 0x0401D339 RID: 119609
		[Token(Token = "0x401D339")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0401D33A RID: 119610
		[Token(Token = "0x401D33A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnInitTopMenu;

		// Token: 0x0401D33B RID: 119611
		[Token(Token = "0x401D33B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003C1E RID: 15390
		[Token(Token = "0x2003C1E")]
		public class Param
		{
			// Token: 0x06018139 RID: 98617 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018139")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x0401D33C RID: 119612
			[Token(Token = "0x401D33C")]
			[FieldOffset(Offset = "0x10")]
			public int charInstId;

			// Token: 0x0401D33D RID: 119613
			[Token(Token = "0x401D33D")]
			[FieldOffset(Offset = "0x18")]
			public string initSelectUniEquipId;
		}
	}
}
