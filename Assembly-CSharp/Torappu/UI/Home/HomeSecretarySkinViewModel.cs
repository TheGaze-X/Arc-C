using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.Shop;
using Torappu.UI.Skin;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B80 RID: 19328
	[Token(Token = "0x2004B80")]
	public class HomeSecretarySkinViewModel : IHotfixable
	{
		// Token: 0x17004466 RID: 17510
		// (get) Token: 0x0601D16D RID: 119149 RVA: 0x000AA5B0 File Offset: 0x000A87B0
		// (set) Token: 0x0601D16E RID: 119150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004466")]
		public bool showCanUsePart
		{
			[Token(Token = "0x601D16D")]
			[Address(RVA = "0x16A8C70", Offset = "0x16A7870", VA = "0x1816A8C70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601D16E")]
			[Address(RVA = "0x16A8D90", Offset = "0x16A7990", VA = "0x1816A8D90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004467 RID: 17511
		// (get) Token: 0x0601D16F RID: 119151 RVA: 0x000AA5C8 File Offset: 0x000A87C8
		// (set) Token: 0x0601D170 RID: 119152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004467")]
		public bool showGotoShopPart
		{
			[Token(Token = "0x601D16F")]
			[Address(RVA = "0x16A8CD0", Offset = "0x16A78D0", VA = "0x1816A8CD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601D170")]
			[Address(RVA = "0x16A8E00", Offset = "0x16A7A00", VA = "0x1816A8E00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004468 RID: 17512
		// (get) Token: 0x0601D171 RID: 119153 RVA: 0x000AA5E0 File Offset: 0x000A87E0
		// (set) Token: 0x0601D172 RID: 119154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004468")]
		public bool showJustForShowPart
		{
			[Token(Token = "0x601D171")]
			[Address(RVA = "0x16A8D30", Offset = "0x16A7930", VA = "0x1816A8D30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601D172")]
			[Address(RVA = "0x16A8E70", Offset = "0x16A7A70", VA = "0x1816A8E70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601D173 RID: 119155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D173")]
		[Address(RVA = "0x16A88C0", Offset = "0x16A74C0", VA = "0x1816A88C0")]
		public void InitData(int index, CharSkinData importData, bool secretaryFlag)
		{
		}

		// Token: 0x0601D174 RID: 119156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D174")]
		[Address(RVA = "0x16A87A0", Offset = "0x16A73A0", VA = "0x1816A87A0")]
		public void InitData(int index, SkinShopViewModel shopData, bool secretaryFlag)
		{
		}

		// Token: 0x0601D175 RID: 119157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D175")]
		[Address(RVA = "0x16A89E0", Offset = "0x16A75E0", VA = "0x1816A89E0")]
		private void _InitViewStatus()
		{
		}

		// Token: 0x0601D176 RID: 119158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D176")]
		[Address(RVA = "0x16A8C10", Offset = "0x16A7810", VA = "0x1816A8C10")]
		public HomeSecretarySkinViewModel()
		{
		}

		// Token: 0x040262D2 RID: 156370
		[Token(Token = "0x40262D2")]
		[FieldOffset(Offset = "0x10")]
		public SkinSelectViewModel selectViewModel;

		// Token: 0x040262D6 RID: 156374
		[Token(Token = "0x40262D6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_showCanUsePart;

		// Token: 0x040262D7 RID: 156375
		[Token(Token = "0x40262D7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_showCanUsePart;

		// Token: 0x040262D8 RID: 156376
		[Token(Token = "0x40262D8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_showGotoShopPart;

		// Token: 0x040262D9 RID: 156377
		[Token(Token = "0x40262D9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_showGotoShopPart;

		// Token: 0x040262DA RID: 156378
		[Token(Token = "0x40262DA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_showJustForShowPart;

		// Token: 0x040262DB RID: 156379
		[Token(Token = "0x40262DB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_showJustForShowPart;

		// Token: 0x040262DC RID: 156380
		[Token(Token = "0x40262DC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x040262DD RID: 156381
		[Token(Token = "0x40262DD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix1_InitData;

		// Token: 0x040262DE RID: 156382
		[Token(Token = "0x40262DE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitViewStatus;

		// Token: 0x040262DF RID: 156383
		[Token(Token = "0x40262DF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
