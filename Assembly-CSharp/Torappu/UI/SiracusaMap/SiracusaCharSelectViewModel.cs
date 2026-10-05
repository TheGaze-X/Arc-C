using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F29 RID: 16169
	[Token(Token = "0x2003F29")]
	public class SiracusaCharSelectViewModel : IHotfixable
	{
		// Token: 0x17003C10 RID: 15376
		// (get) Token: 0x060191D4 RID: 102868 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060191D5 RID: 102869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C10")]
		public string selectingCharCardId
		{
			[Token(Token = "0x60191D4")]
			[Address(RVA = "0x11CC220", Offset = "0x11CAE20", VA = "0x1811CC220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60191D5")]
			[Address(RVA = "0x11CC460", Offset = "0x11CB060", VA = "0x1811CC460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003C11 RID: 15377
		// (get) Token: 0x060191D6 RID: 102870 RVA: 0x0009CFF0 File Offset: 0x0009B1F0
		// (set) Token: 0x060191D7 RID: 102871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C11")]
		public bool allCharCardComplete
		{
			[Token(Token = "0x60191D6")]
			[Address(RVA = "0x11CC0A0", Offset = "0x11CACA0", VA = "0x1811CC0A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60191D7")]
			[Address(RVA = "0x11CC280", Offset = "0x11CAE80", VA = "0x1811CC280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003C12 RID: 15378
		// (get) Token: 0x060191D8 RID: 102872 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060191D9 RID: 102873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C12")]
		public string choosingCharCardId
		{
			[Token(Token = "0x60191D8")]
			[Address(RVA = "0x11CC100", Offset = "0x11CAD00", VA = "0x1811CC100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60191D9")]
			[Address(RVA = "0x11CC2F0", Offset = "0x11CAEF0", VA = "0x1811CC2F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003C13 RID: 15379
		// (get) Token: 0x060191DA RID: 102874 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060191DB RID: 102875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C13")]
		public string groupId
		{
			[Token(Token = "0x60191DA")]
			[Address(RVA = "0x11CC160", Offset = "0x11CAD60", VA = "0x1811CC160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60191DB")]
			[Address(RVA = "0x11CC370", Offset = "0x11CAF70", VA = "0x1811CC370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003C14 RID: 15380
		// (get) Token: 0x060191DC RID: 102876 RVA: 0x0009D008 File Offset: 0x0009B208
		// (set) Token: 0x060191DD RID: 102877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C14")]
		public bool isRetro
		{
			[Token(Token = "0x60191DC")]
			[Address(RVA = "0x11CC1C0", Offset = "0x11CADC0", VA = "0x1811CC1C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60191DD")]
			[Address(RVA = "0x11CC3F0", Offset = "0x11CAFF0", VA = "0x1811CC3F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060191DE RID: 102878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60191DE")]
		[Address(RVA = "0x11CB6F0", Offset = "0x11CA2F0", VA = "0x1811CB6F0")]
		public void LoadData(string groupId, bool isRetro)
		{
		}

		// Token: 0x060191DF RID: 102879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60191DF")]
		[Address(RVA = "0x11CBC00", Offset = "0x11CA800", VA = "0x1811CBC00")]
		public void UpdatePlayerData()
		{
		}

		// Token: 0x060191E0 RID: 102880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60191E0")]
		[Address(RVA = "0x11CBB80", Offset = "0x11CA780", VA = "0x1811CBB80")]
		public void UpdateChoosingCharCard(string charCardId)
		{
		}

		// Token: 0x060191E1 RID: 102881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60191E1")]
		[Address(RVA = "0x11CBE40", Offset = "0x11CAA40", VA = "0x1811CBE40")]
		private void _InitChoosingCharCardId()
		{
		}

		// Token: 0x060191E2 RID: 102882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60191E2")]
		[Address(RVA = "0x11CB5C0", Offset = "0x11CA1C0", VA = "0x1811CB5C0")]
		public SiracusaCharSelectItemViewModel GetCurChosingCharCardViewModel()
		{
			return null;
		}

		// Token: 0x060191E3 RID: 102883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60191E3")]
		[Address(RVA = "0x11CC040", Offset = "0x11CAC40", VA = "0x1811CC040")]
		public SiracusaCharSelectViewModel()
		{
		}

		// Token: 0x0401F17F RID: 127359
		[Token(Token = "0x401F17F")]
		[FieldOffset(Offset = "0x20")]
		public ListDict<string, SiracusaCharSelectItemViewModel> charSelectItemViewModelsMap;

		// Token: 0x0401F183 RID: 127363
		[Token(Token = "0x401F183")]
		[FieldOffset(Offset = "0x3C")]
		public int viewRefreshIndex;

		// Token: 0x0401F184 RID: 127364
		[Token(Token = "0x401F184")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectingCharCardId;

		// Token: 0x0401F185 RID: 127365
		[Token(Token = "0x401F185")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_selectingCharCardId;

		// Token: 0x0401F186 RID: 127366
		[Token(Token = "0x401F186")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_allCharCardComplete;

		// Token: 0x0401F187 RID: 127367
		[Token(Token = "0x401F187")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_allCharCardComplete;

		// Token: 0x0401F188 RID: 127368
		[Token(Token = "0x401F188")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_choosingCharCardId;

		// Token: 0x0401F189 RID: 127369
		[Token(Token = "0x401F189")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_choosingCharCardId;

		// Token: 0x0401F18A RID: 127370
		[Token(Token = "0x401F18A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_groupId;

		// Token: 0x0401F18B RID: 127371
		[Token(Token = "0x401F18B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_groupId;

		// Token: 0x0401F18C RID: 127372
		[Token(Token = "0x401F18C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_isRetro;

		// Token: 0x0401F18D RID: 127373
		[Token(Token = "0x401F18D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_isRetro;

		// Token: 0x0401F18E RID: 127374
		[Token(Token = "0x401F18E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401F18F RID: 127375
		[Token(Token = "0x401F18F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_UpdatePlayerData;

		// Token: 0x0401F190 RID: 127376
		[Token(Token = "0x401F190")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_UpdateChoosingCharCard;

		// Token: 0x0401F191 RID: 127377
		[Token(Token = "0x401F191")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__InitChoosingCharCardId;

		// Token: 0x0401F192 RID: 127378
		[Token(Token = "0x401F192")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetCurChosingCharCardViewModel;

		// Token: 0x0401F193 RID: 127379
		[Token(Token = "0x401F193")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
