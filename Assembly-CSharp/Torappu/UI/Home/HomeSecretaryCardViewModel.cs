using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B70 RID: 19312
	[Token(Token = "0x2004B70")]
	public class HomeSecretaryCardViewModel : IBasicCharInfo, IHotfixable
	{
		// Token: 0x17004450 RID: 17488
		// (get) Token: 0x0601D10A RID: 119050 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D10B RID: 119051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004450")]
		public BasicCharInfoModel basicCharInfo
		{
			[Token(Token = "0x601D10A")]
			[Address(RVA = "0x16A1920", Offset = "0x16A0520", VA = "0x1816A1920", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x601D10B")]
			[Address(RVA = "0x16A1CF0", Offset = "0x16A08F0", VA = "0x1816A1CF0")]
			set
			{
			}
		}

		// Token: 0x17004451 RID: 17489
		// (get) Token: 0x0601D10C RID: 119052 RVA: 0x000AA310 File Offset: 0x000A8510
		[Token(Token = "0x17004451")]
		public int chrInstId
		{
			[Token(Token = "0x601D10C")]
			[Address(RVA = "0x16A19F0", Offset = "0x16A05F0", VA = "0x1816A19F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004452 RID: 17490
		// (get) Token: 0x0601D10D RID: 119053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004452")]
		public string charId
		{
			[Token(Token = "0x601D10D")]
			[Address(RVA = "0x16A1980", Offset = "0x16A0580", VA = "0x1816A1980")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004453 RID: 17491
		// (get) Token: 0x0601D10E RID: 119054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004453")]
		public string tmplId
		{
			[Token(Token = "0x601D10E")]
			[Address(RVA = "0x16A1C80", Offset = "0x16A0880", VA = "0x1816A1C80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004454 RID: 17492
		// (get) Token: 0x0601D10F RID: 119055 RVA: 0x000AA328 File Offset: 0x000A8528
		[Token(Token = "0x17004454")]
		public CharStarMarkState starMark
		{
			[Token(Token = "0x601D10F")]
			[Address(RVA = "0x16A1C10", Offset = "0x16A0810", VA = "0x1816A1C10")]
			get
			{
				return CharStarMarkState.NONE;
			}
		}

		// Token: 0x17004455 RID: 17493
		// (get) Token: 0x0601D110 RID: 119056 RVA: 0x000AA340 File Offset: 0x000A8540
		[Token(Token = "0x17004455")]
		public ProfessionCategory profession
		{
			[Token(Token = "0x601D110")]
			[Address(RVA = "0x16A1AC0", Offset = "0x16A06C0", VA = "0x1816A1AC0")]
			get
			{
				return ProfessionCategory.NONE;
			}
		}

		// Token: 0x17004456 RID: 17494
		// (get) Token: 0x0601D111 RID: 119057 RVA: 0x000AA358 File Offset: 0x000A8558
		// (set) Token: 0x0601D112 RID: 119058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004456")]
		public CharUISkinStruct skin
		{
			[Token(Token = "0x601D111")]
			[Address(RVA = "0x16A1B90", Offset = "0x16A0790", VA = "0x1816A1B90")]
			[CompilerGenerated]
			get
			{
				return default(CharUISkinStruct);
			}
			[Token(Token = "0x601D112")]
			[Address(RVA = "0x16A1E70", Offset = "0x16A0A70", VA = "0x1816A1E70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004457 RID: 17495
		// (get) Token: 0x0601D113 RID: 119059 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D114 RID: 119060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004457")]
		public string realName
		{
			[Token(Token = "0x601D113")]
			[Address(RVA = "0x16A1B30", Offset = "0x16A0730", VA = "0x1816A1B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601D114")]
			[Address(RVA = "0x16A1DF0", Offset = "0x16A09F0", VA = "0x1816A1DF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004458 RID: 17496
		// (get) Token: 0x0601D115 RID: 119061 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D116 RID: 119062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004458")]
		public string nickName
		{
			[Token(Token = "0x601D115")]
			[Address(RVA = "0x16A1A60", Offset = "0x16A0660", VA = "0x1816A1A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601D116")]
			[Address(RVA = "0x16A1D70", Offset = "0x16A0970", VA = "0x1816A1D70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601D117 RID: 119063 RVA: 0x000AA370 File Offset: 0x000A8570
		[Token(Token = "0x601D117")]
		[Address(RVA = "0x16A1720", Offset = "0x16A0320", VA = "0x1816A1720")]
		public CharQuery GetCharQuery()
		{
			return default(CharQuery);
		}

		// Token: 0x0601D118 RID: 119064 RVA: 0x000AA388 File Offset: 0x000A8588
		[Token(Token = "0x601D118")]
		[Address(RVA = "0x16A1390", Offset = "0x169FF90", VA = "0x1816A1390")]
		public bool FillViewModel(PlayerCharacter playerChar, [Optional] string skinTag)
		{
			return default(bool);
		}

		// Token: 0x0601D119 RID: 119065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D119")]
		[Address(RVA = "0x16A1880", Offset = "0x16A0480", VA = "0x1816A1880")]
		public HomeSecretaryCardViewModel()
		{
		}

		// Token: 0x04026238 RID: 156216
		[Token(Token = "0x4026238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private BasicCharInfoModel m_basicInfo;

		// Token: 0x0402623C RID: 156220
		[Token(Token = "0x402623C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_basicCharInfo;

		// Token: 0x0402623D RID: 156221
		[Token(Token = "0x402623D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_basicCharInfo;

		// Token: 0x0402623E RID: 156222
		[Token(Token = "0x402623E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_chrInstId;

		// Token: 0x0402623F RID: 156223
		[Token(Token = "0x402623F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_charId;

		// Token: 0x04026240 RID: 156224
		[Token(Token = "0x4026240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_tmplId;

		// Token: 0x04026241 RID: 156225
		[Token(Token = "0x4026241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_starMark;

		// Token: 0x04026242 RID: 156226
		[Token(Token = "0x4026242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_profession;

		// Token: 0x04026243 RID: 156227
		[Token(Token = "0x4026243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_skin;

		// Token: 0x04026244 RID: 156228
		[Token(Token = "0x4026244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_skin;

		// Token: 0x04026245 RID: 156229
		[Token(Token = "0x4026245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_realName;

		// Token: 0x04026246 RID: 156230
		[Token(Token = "0x4026246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_set_realName;

		// Token: 0x04026247 RID: 156231
		[Token(Token = "0x4026247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_nickName;

		// Token: 0x04026248 RID: 156232
		[Token(Token = "0x4026248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_set_nickName;

		// Token: 0x04026249 RID: 156233
		[Token(Token = "0x4026249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetCharQuery;

		// Token: 0x0402624A RID: 156234
		[Token(Token = "0x402624A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_FillViewModel;

		// Token: 0x0402624B RID: 156235
		[Token(Token = "0x402624B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
