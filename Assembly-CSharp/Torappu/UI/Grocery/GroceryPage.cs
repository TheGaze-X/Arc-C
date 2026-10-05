using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CF1 RID: 19697
	[Token(Token = "0x2004CF1")]
	public class GroceryPage : StateEnginePage, IHotfixable
	{
		// Token: 0x1700455A RID: 17754
		// (get) Token: 0x0601D85F RID: 120927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700455A")]
		public string activityId
		{
			[Token(Token = "0x601D85F")]
			[Address(RVA = "0x1715DA0", Offset = "0x17149A0", VA = "0x181715DA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601D860 RID: 120928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D860")]
		[Address(RVA = "0x1715C90", Offset = "0x1714890", VA = "0x181715C90", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0601D861 RID: 120929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D861")]
		[Address(RVA = "0x1715BE0", Offset = "0x17147E0", VA = "0x181715BE0", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x0601D862 RID: 120930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D862")]
		[Address(RVA = "0x1715A60", Offset = "0x1714660", VA = "0x181715A60")]
		public static CommonTopMenu CreateCommonTopMenu(Transform container, [Optional] Action onBackClick)
		{
			return null;
		}

		// Token: 0x0601D863 RID: 120931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D863")]
		[Address(RVA = "0x1715D40", Offset = "0x1714940", VA = "0x181715D40")]
		public GroceryPage()
		{
		}

		// Token: 0x0601D865 RID: 120933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D865")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0601D866 RID: 120934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D866")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x04026F30 RID: 159536
		[Token(Token = "0x4026F30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private string m_actId;

		// Token: 0x04026F31 RID: 159537
		[Token(Token = "0x4026F31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_activityId;

		// Token: 0x04026F32 RID: 159538
		[Token(Token = "0x4026F32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04026F33 RID: 159539
		[Token(Token = "0x4026F33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x04026F34 RID: 159540
		[Token(Token = "0x4026F34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CreateCommonTopMenu;

		// Token: 0x04026F35 RID: 159541
		[Token(Token = "0x4026F35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004CF2 RID: 19698
		[Token(Token = "0x2004CF2")]
		public class Params
		{
			// Token: 0x0601D867 RID: 120935 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D867")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x04026F36 RID: 159542
			[Token(Token = "0x4026F36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string actId;
		}
	}
}
