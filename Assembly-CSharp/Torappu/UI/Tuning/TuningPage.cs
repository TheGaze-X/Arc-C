using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CC6 RID: 15558
	[Token(Token = "0x2003CC6")]
	public class TuningPage : StateEnginePage, IHotfixable
	{
		// Token: 0x170039D8 RID: 14808
		// (get) Token: 0x06018417 RID: 99351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170039D8")]
		public string actId
		{
			[Token(Token = "0x6018417")]
			[Address(RVA = "0x10C3820", Offset = "0x10C2420", VA = "0x1810C3820")]
			get
			{
				return null;
			}
		}

		// Token: 0x06018418 RID: 99352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018418")]
		[Address(RVA = "0x10C3710", Offset = "0x10C2310", VA = "0x1810C3710", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x06018419 RID: 99353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018419")]
		[Address(RVA = "0x10C3660", Offset = "0x10C2260", VA = "0x1810C3660", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x0601841A RID: 99354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601841A")]
		[Address(RVA = "0x10C34E0", Offset = "0x10C20E0", VA = "0x1810C34E0")]
		public static CommonTopMenu CreateCommonTopMenu(Transform container, [Optional] Action onBackClick)
		{
			return null;
		}

		// Token: 0x0601841B RID: 99355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601841B")]
		[Address(RVA = "0x10C37C0", Offset = "0x10C23C0", VA = "0x1810C37C0")]
		public TuningPage()
		{
		}

		// Token: 0x0601841D RID: 99357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601841D")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0601841E RID: 99358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601841E")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x0401D96E RID: 121198
		[Token(Token = "0x401D96E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private string m_actId;

		// Token: 0x0401D96F RID: 121199
		[Token(Token = "0x401D96F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x0401D970 RID: 121200
		[Token(Token = "0x401D970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0401D971 RID: 121201
		[Token(Token = "0x401D971")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x0401D972 RID: 121202
		[Token(Token = "0x401D972")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CreateCommonTopMenu;

		// Token: 0x0401D973 RID: 121203
		[Token(Token = "0x401D973")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003CC7 RID: 15559
		[Token(Token = "0x2003CC7")]
		public class Params
		{
			// Token: 0x0601841F RID: 99359 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601841F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x0401D974 RID: 121204
			[Token(Token = "0x401D974")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string actId;
		}
	}
}
