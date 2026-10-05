using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E48 RID: 24136
	[Token(Token = "0x2005E48")]
	public class ItemRepoPage : StateEnginePage
	{
		// Token: 0x06022F7B RID: 143227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F7B")]
		[Address(RVA = "0x1D86E20", Offset = "0x1D85A20", VA = "0x181D86E20", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x06022F7C RID: 143228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022F7C")]
		[Address(RVA = "0x1D86D60", Offset = "0x1D85960", VA = "0x181D86D60", Slot = "25")]
		protected override IEnumerator EffectsOnShow(bool isFromStack)
		{
			return null;
		}

		// Token: 0x06022F7D RID: 143229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F7D")]
		[Address(RVA = "0x1D86ED0", Offset = "0x1D85AD0", VA = "0x181D86ED0")]
		private void _InitStateFromParam(ItemRepoPage.Params param)
		{
		}

		// Token: 0x06022F7E RID: 143230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022F7E")]
		[Address(RVA = "0x1D87020", Offset = "0x1D85C20", VA = "0x181D87020")]
		private IEnumerator _ResetToDefault()
		{
			return null;
		}

		// Token: 0x06022F7F RID: 143231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F7F")]
		[Address(RVA = "0x1D870D0", Offset = "0x1D85CD0", VA = "0x181D870D0")]
		public ItemRepoPage()
		{
		}

		// Token: 0x06022F81 RID: 143233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F81")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x06022F82 RID: 143234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022F82")]
		[Address(RVA = "0x119B2F0", Offset = "0x1199EF0", VA = "0x18119B2F0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnShow(bool P0)
		{
			return null;
		}

		// Token: 0x040302D4 RID: 197332
		[Token(Token = "0x40302D4")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private ItemRepoHomeState _homeState;

		// Token: 0x040302D5 RID: 197333
		[Token(Token = "0x40302D5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x040302D6 RID: 197334
		[Token(Token = "0x40302D6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EffectsOnShow;

		// Token: 0x040302D7 RID: 197335
		[Token(Token = "0x40302D7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitStateFromParam;

		// Token: 0x040302D8 RID: 197336
		[Token(Token = "0x40302D8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ResetToDefault;

		// Token: 0x040302D9 RID: 197337
		[Token(Token = "0x40302D9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005E49 RID: 24137
		[Token(Token = "0x2005E49")]
		public class Params
		{
			// Token: 0x170052E2 RID: 21218
			// (get) Token: 0x06022F83 RID: 143235 RVA: 0x000BF9D0 File Offset: 0x000BDBD0
			// (set) Token: 0x06022F84 RID: 143236 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170052E2")]
			public bool needResetToDefault
			{
				[Token(Token = "0x6022F83")]
				[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
				[CompilerGenerated]
				private get
				{
					return default(bool);
				}
				[Token(Token = "0x6022F84")]
				[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06022F85 RID: 143237 RVA: 0x000BF9E8 File Offset: 0x000BDBE8
			[Token(Token = "0x6022F85")]
			[Address(RVA = "0x1D8B490", Offset = "0x1D8A090", VA = "0x181D8B490")]
			public bool ConsumeIfNeedReset()
			{
				return default(bool);
			}

			// Token: 0x06022F86 RID: 143238 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022F86")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}
		}
	}
}
