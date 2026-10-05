using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E44 RID: 24132
	[Token(Token = "0x2005E44")]
	public class ItemGetMaterialPage : StateEnginePage
	{
		// Token: 0x06022F65 RID: 143205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022F65")]
		[Address(RVA = "0x1D7EDA0", Offset = "0x1D7D9A0", VA = "0x181D7EDA0")]
		public UIItemViewModel LoadItemViewModel()
		{
			return null;
		}

		// Token: 0x06022F66 RID: 143206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F66")]
		[Address(RVA = "0x1D7EEF0", Offset = "0x1D7DAF0", VA = "0x181D7EEF0")]
		public void OnClosePage()
		{
		}

		// Token: 0x06022F67 RID: 143207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022F67")]
		[Address(RVA = "0x1D7EC30", Offset = "0x1D7D830", VA = "0x181D7EC30", Slot = "25")]
		protected override IEnumerator EffectsOnShow(bool isFromStack)
		{
			return null;
		}

		// Token: 0x06022F68 RID: 143208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022F68")]
		[Address(RVA = "0x1D7ECF0", Offset = "0x1D7D8F0", VA = "0x181D7ECF0", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x06022F69 RID: 143209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F69")]
		[Address(RVA = "0x1D7F290", Offset = "0x1D7DE90", VA = "0x181D7F290")]
		public ItemGetMaterialPage()
		{
		}

		// Token: 0x06022F6C RID: 143212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022F6C")]
		[Address(RVA = "0x119B2F0", Offset = "0x1199EF0", VA = "0x18119B2F0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnShow(bool P0)
		{
			return null;
		}

		// Token: 0x06022F6D RID: 143213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022F6D")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x040302C2 RID: 197314
		[Token(Token = "0x40302C2")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private UIBlurFloatPanel _blurFloatPanel;

		// Token: 0x040302C3 RID: 197315
		[Token(Token = "0x40302C3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadItemViewModel;

		// Token: 0x040302C4 RID: 197316
		[Token(Token = "0x40302C4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClosePage;

		// Token: 0x040302C5 RID: 197317
		[Token(Token = "0x40302C5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EffectsOnShow;

		// Token: 0x040302C6 RID: 197318
		[Token(Token = "0x40302C6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x040302C7 RID: 197319
		[Token(Token = "0x40302C7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005E45 RID: 24133
		[Token(Token = "0x2005E45")]
		public class Param
		{
			// Token: 0x06022F6E RID: 143214 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022F6E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x040302C8 RID: 197320
			[Token(Token = "0x40302C8")]
			[FieldOffset(Offset = "0x10")]
			public ItemUtil.ConsumableInfo consumableInfo;

			// Token: 0x040302C9 RID: 197321
			[Token(Token = "0x40302C9")]
			[FieldOffset(Offset = "0x28")]
			public ItemType itemType;

			// Token: 0x040302CA RID: 197322
			[Token(Token = "0x40302CA")]
			[FieldOffset(Offset = "0x30")]
			public UIItemViewModel itemViewModel;

			// Token: 0x040302CB RID: 197323
			[Token(Token = "0x40302CB")]
			[FieldOffset(Offset = "0x38")]
			public string focusItemId;

			// Token: 0x040302CC RID: 197324
			[Token(Token = "0x40302CC")]
			[FieldOffset(Offset = "0x40")]
			public long focusItemNeedCount;
		}
	}
}
