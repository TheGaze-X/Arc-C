using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.Shop;
using UnityEngine;
using XLua;

namespace Torappu.UI.Skin
{
	// Token: 0x02003EEF RID: 16111
	[Token(Token = "0x2003EEF")]
	public class SkinSelectViewModel : IHotfixable
	{
		// Token: 0x17003B93 RID: 15251
		// (get) Token: 0x06018FD5 RID: 102357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003B93")]
		public string portraitId
		{
			[Token(Token = "0x6018FD5")]
			[Address(RVA = "0x11C2B00", Offset = "0x11C1700", VA = "0x1811C2B00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003B94 RID: 15252
		// (get) Token: 0x06018FD6 RID: 102358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003B94")]
		public string avatarId
		{
			[Token(Token = "0x6018FD6")]
			[Address(RVA = "0x11C2630", Offset = "0x11C1230", VA = "0x1811C2630")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003B95 RID: 15253
		// (get) Token: 0x06018FD7 RID: 102359 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06018FD8 RID: 102360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003B95")]
		public SkinShopViewModel skinShopData
		{
			[Token(Token = "0x6018FD7")]
			[Address(RVA = "0x11C2DD0", Offset = "0x11C19D0", VA = "0x1811C2DD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6018FD8")]
			[Address(RVA = "0x11C35E0", Offset = "0x11C21E0", VA = "0x1811C35E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003B96 RID: 15254
		// (get) Token: 0x06018FD9 RID: 102361 RVA: 0x0009C8B8 File Offset: 0x0009AAB8
		// (set) Token: 0x06018FDA RID: 102362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003B96")]
		public bool cacheSeFlag
		{
			[Token(Token = "0x6018FD9")]
			[Address(RVA = "0x11C2780", Offset = "0x11C1380", VA = "0x1811C2780")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6018FDA")]
			[Address(RVA = "0x11C3070", Offset = "0x11C1C70", VA = "0x1811C3070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003B97 RID: 15255
		// (get) Token: 0x06018FDB RID: 102363 RVA: 0x0009C8D0 File Offset: 0x0009AAD0
		// (set) Token: 0x06018FDC RID: 102364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003B97")]
		public bool useVoucher
		{
			[Token(Token = "0x6018FDB")]
			[Address(RVA = "0x11C3010", Offset = "0x11C1C10", VA = "0x1811C3010")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6018FDC")]
			[Address(RVA = "0x11C36D0", Offset = "0x11C22D0", VA = "0x1811C36D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003B98 RID: 15256
		// (get) Token: 0x06018FDD RID: 102365 RVA: 0x0009C8E8 File Offset: 0x0009AAE8
		// (set) Token: 0x06018FDE RID: 102366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003B98")]
		public bool usePriceToBuy
		{
			[Token(Token = "0x6018FDD")]
			[Address(RVA = "0x11C2FB0", Offset = "0x11C1BB0", VA = "0x1811C2FB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6018FDE")]
			[Address(RVA = "0x11C3660", Offset = "0x11C2260", VA = "0x1811C3660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003B99 RID: 15257
		// (get) Token: 0x06018FDF RID: 102367 RVA: 0x0009C900 File Offset: 0x0009AB00
		// (set) Token: 0x06018FE0 RID: 102368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003B99")]
		public bool hasCurSkin
		{
			[Token(Token = "0x6018FDF")]
			[Address(RVA = "0x11C2A40", Offset = "0x11C1640", VA = "0x1811C2A40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6018FE0")]
			[Address(RVA = "0x11C3340", Offset = "0x11C1F40", VA = "0x1811C3340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003B9A RID: 15258
		// (get) Token: 0x06018FE1 RID: 102369 RVA: 0x0009C918 File Offset: 0x0009AB18
		// (set) Token: 0x06018FE2 RID: 102370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003B9A")]
		public bool isRedeem
		{
			[Token(Token = "0x6018FE1")]
			[Address(RVA = "0x11C2AA0", Offset = "0x11C16A0", VA = "0x1811C2AA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6018FE2")]
			[Address(RVA = "0x11C33B0", Offset = "0x11C1FB0", VA = "0x1811C33B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003B9B RID: 15259
		// (get) Token: 0x06018FE3 RID: 102371 RVA: 0x0009C930 File Offset: 0x0009AB30
		// (set) Token: 0x06018FE4 RID: 102372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003B9B")]
		public bool hasCurSkinAndChar
		{
			[Token(Token = "0x6018FE3")]
			[Address(RVA = "0x11C29E0", Offset = "0x11C15E0", VA = "0x1811C29E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6018FE4")]
			[Address(RVA = "0x11C32D0", Offset = "0x11C1ED0", VA = "0x1811C32D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003B9C RID: 15260
		// (get) Token: 0x06018FE5 RID: 102373 RVA: 0x0009C948 File Offset: 0x0009AB48
		// (set) Token: 0x06018FE6 RID: 102374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003B9C")]
		public bool showPricePart
		{
			[Token(Token = "0x6018FE5")]
			[Address(RVA = "0x11C2D10", Offset = "0x11C1910", VA = "0x1811C2D10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6018FE6")]
			[Address(RVA = "0x11C3500", Offset = "0x11C2100", VA = "0x1811C3500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003B9D RID: 15261
		// (get) Token: 0x06018FE7 RID: 102375 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06018FE8 RID: 102376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003B9D")]
		public string giftAvatarId
		{
			[Token(Token = "0x6018FE7")]
			[Address(RVA = "0x11C28A0", Offset = "0x11C14A0", VA = "0x1811C28A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6018FE8")]
			[Address(RVA = "0x11C31D0", Offset = "0x11C1DD0", VA = "0x1811C31D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003B9E RID: 15262
		// (get) Token: 0x06018FE9 RID: 102377 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06018FEA RID: 102378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003B9E")]
		public string giftAvatarDynId
		{
			[Token(Token = "0x6018FE9")]
			[Address(RVA = "0x11C2840", Offset = "0x11C1440", VA = "0x1811C2840")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6018FEA")]
			[Address(RVA = "0x11C3150", Offset = "0x11C1D50", VA = "0x1811C3150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003B9F RID: 15263
		// (get) Token: 0x06018FEB RID: 102379 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06018FEC RID: 102380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003B9F")]
		public string giftDesc
		{
			[Token(Token = "0x6018FEB")]
			[Address(RVA = "0x11C2900", Offset = "0x11C1500", VA = "0x1811C2900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6018FEC")]
			[Address(RVA = "0x11C3250", Offset = "0x11C1E50", VA = "0x1811C3250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003BA0 RID: 15264
		// (get) Token: 0x06018FED RID: 102381 RVA: 0x0009C960 File Offset: 0x0009AB60
		// (set) Token: 0x06018FEE RID: 102382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BA0")]
		public bool showGiftPart
		{
			[Token(Token = "0x6018FED")]
			[Address(RVA = "0x11C2CB0", Offset = "0x11C18B0", VA = "0x1811C2CB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6018FEE")]
			[Address(RVA = "0x11C3490", Offset = "0x11C2090", VA = "0x1811C3490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003BA1 RID: 15265
		// (get) Token: 0x06018FEF RID: 102383 RVA: 0x0009C978 File Offset: 0x0009AB78
		// (set) Token: 0x06018FF0 RID: 102384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BA1")]
		public bool showDynIllust
		{
			[Token(Token = "0x6018FEF")]
			[Address(RVA = "0x11C2C50", Offset = "0x11C1850", VA = "0x1811C2C50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6018FF0")]
			[Address(RVA = "0x11C3420", Offset = "0x11C2020", VA = "0x1811C3420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003BA2 RID: 15266
		// (get) Token: 0x06018FF1 RID: 102385 RVA: 0x0009C990 File Offset: 0x0009AB90
		// (set) Token: 0x06018FF2 RID: 102386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BA2")]
		public bool equipedSpDynIllust
		{
			[Token(Token = "0x6018FF1")]
			[Address(RVA = "0x11C27E0", Offset = "0x11C13E0", VA = "0x1811C27E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6018FF2")]
			[Address(RVA = "0x11C30E0", Offset = "0x11C1CE0", VA = "0x1811C30E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003BA3 RID: 15267
		// (get) Token: 0x06018FF3 RID: 102387 RVA: 0x0009C9A8 File Offset: 0x0009ABA8
		// (set) Token: 0x06018FF4 RID: 102388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BA3")]
		public bool showSpDynIllust
		{
			[Token(Token = "0x6018FF3")]
			[Address(RVA = "0x11C2D70", Offset = "0x11C1970", VA = "0x1811C2D70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6018FF4")]
			[Address(RVA = "0x11C3570", Offset = "0x11C2170", VA = "0x1811C3570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003BA4 RID: 15268
		// (get) Token: 0x06018FF5 RID: 102389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003BA4")]
		public ShopSkinItemViewModel skinShopModel
		{
			[Token(Token = "0x6018FF5")]
			[Address(RVA = "0x11C2E30", Offset = "0x11C1A30", VA = "0x1811C2E30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003BA5 RID: 15269
		// (get) Token: 0x06018FF6 RID: 102390 RVA: 0x0009C9C0 File Offset: 0x0009ABC0
		[Token(Token = "0x17003BA5")]
		public int groupSortId
		{
			[Token(Token = "0x6018FF6")]
			[Address(RVA = "0x11C2960", Offset = "0x11C1560", VA = "0x1811C2960")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003BA6 RID: 15270
		// (get) Token: 0x06018FF7 RID: 102391 RVA: 0x0009C9D8 File Offset: 0x0009ABD8
		[Token(Token = "0x17003BA6")]
		public int sortId
		{
			[Token(Token = "0x6018FF7")]
			[Address(RVA = "0x11C2F30", Offset = "0x11C1B30", VA = "0x1811C2F30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06018FF8 RID: 102392 RVA: 0x0009C9F0 File Offset: 0x0009ABF0
		[Token(Token = "0x6018FF8")]
		[Address(RVA = "0x11C0F60", Offset = "0x11BFB60", VA = "0x1811C0F60")]
		public static bool CheckSkinAvailableState(CharSkinData skinData)
		{
			return default(bool);
		}

		// Token: 0x06018FF9 RID: 102393 RVA: 0x0009CA08 File Offset: 0x0009AC08
		[Token(Token = "0x6018FF9")]
		[Address(RVA = "0x11C1040", Offset = "0x11BFC40", VA = "0x1811C1040")]
		public static int GetSkinTmplSortId(CharSkinData skinData)
		{
			return 0;
		}

		// Token: 0x06018FFA RID: 102394 RVA: 0x0009CA20 File Offset: 0x0009AC20
		[Token(Token = "0x6018FFA")]
		[Address(RVA = "0x11C0E00", Offset = "0x11BFA00", VA = "0x1811C0E00")]
		public static bool CheckIfHasSkin(string skinId)
		{
			return default(bool);
		}

		// Token: 0x06018FFB RID: 102395 RVA: 0x0009CA38 File Offset: 0x0009AC38
		[Token(Token = "0x6018FFB")]
		[Address(RVA = "0x11C0EE0", Offset = "0x11BFAE0", VA = "0x1811C0EE0")]
		public static bool CheckIsEquipedSpDynIllust(string skinId)
		{
			return default(bool);
		}

		// Token: 0x06018FFC RID: 102396 RVA: 0x0009CA50 File Offset: 0x0009AC50
		[Token(Token = "0x6018FFC")]
		[Address(RVA = "0x11C1B40", Offset = "0x11C0740", VA = "0x1811C1B40")]
		private bool _CheckSelectFlag(CharSkinData skinData, bool secretaryFlag)
		{
			return default(bool);
		}

		// Token: 0x06018FFD RID: 102397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018FFD")]
		[Address(RVA = "0x11C1570", Offset = "0x11C0170", VA = "0x1811C1570")]
		public Sprite LoadAvatarImage()
		{
			return null;
		}

		// Token: 0x06018FFE RID: 102398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018FFE")]
		[Address(RVA = "0x11C1730", Offset = "0x11C0330", VA = "0x1811C1730")]
		public void RefreshData()
		{
		}

		// Token: 0x06018FFF RID: 102399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018FFF")]
		[Address(RVA = "0x11C1790", Offset = "0x11C0390", VA = "0x1811C1790")]
		public void SetShowingSpDynIllust(bool value)
		{
		}

		// Token: 0x06019000 RID: 102400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019000")]
		[Address(RVA = "0x11C1130", Offset = "0x11BFD30", VA = "0x1811C1130")]
		public void InitData(int index, CharSkinData importData, bool secretaryFlag, bool useVoucher)
		{
		}

		// Token: 0x06019001 RID: 102401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019001")]
		[Address(RVA = "0x11C1290", Offset = "0x11BFE90", VA = "0x1811C1290")]
		public void InitData(int index, SkinShopViewModel shopData, bool secretaryFlag, bool useVoucher)
		{
		}

		// Token: 0x06019002 RID: 102402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019002")]
		[Address(RVA = "0x11C1FB0", Offset = "0x11C0BB0", VA = "0x1811C1FB0")]
		private void _UpdateData()
		{
		}

		// Token: 0x06019003 RID: 102403 RVA: 0x0009CA68 File Offset: 0x0009AC68
		[Token(Token = "0x6019003")]
		[Address(RVA = "0x11C1810", Offset = "0x11C0410", VA = "0x1811C1810")]
		private SkinState _AnalyseCurSkinState()
		{
			return SkinState.EQUIPED;
		}

		// Token: 0x06019004 RID: 102404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019004")]
		[Address(RVA = "0x11C1E90", Offset = "0x11C0A90", VA = "0x1811C1E90")]
		private string _GetPortraitId()
		{
			return null;
		}

		// Token: 0x06019005 RID: 102405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019005")]
		[Address(RVA = "0x11C1D70", Offset = "0x11C0970", VA = "0x1811C1D70")]
		private string _GetAvatarId()
		{
			return null;
		}

		// Token: 0x06019006 RID: 102406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019006")]
		[Address(RVA = "0x11C25D0", Offset = "0x11C11D0", VA = "0x1811C25D0")]
		public SkinSelectViewModel()
		{
		}

		// Token: 0x0401EE1E RID: 126494
		[Token(Token = "0x401EE1E")]
		[FieldOffset(Offset = "0x10")]
		public int index;

		// Token: 0x0401EE1F RID: 126495
		[Token(Token = "0x401EE1F")]
		[FieldOffset(Offset = "0x14")]
		public SkinState state;

		// Token: 0x0401EE20 RID: 126496
		[Token(Token = "0x401EE20")]
		[FieldOffset(Offset = "0x18")]
		public CharSkinData skinData;

		// Token: 0x0401EE21 RID: 126497
		[Token(Token = "0x401EE21")]
		[FieldOffset(Offset = "0x20")]
		public int price;

		// Token: 0x0401EE31 RID: 126513
		[Token(Token = "0x401EE31")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_portraitId;

		// Token: 0x0401EE32 RID: 126514
		[Token(Token = "0x401EE32")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_avatarId;

		// Token: 0x0401EE33 RID: 126515
		[Token(Token = "0x401EE33")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_skinShopData;

		// Token: 0x0401EE34 RID: 126516
		[Token(Token = "0x401EE34")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_skinShopData;

		// Token: 0x0401EE35 RID: 126517
		[Token(Token = "0x401EE35")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_cacheSeFlag;

		// Token: 0x0401EE36 RID: 126518
		[Token(Token = "0x401EE36")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_cacheSeFlag;

		// Token: 0x0401EE37 RID: 126519
		[Token(Token = "0x401EE37")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_useVoucher;

		// Token: 0x0401EE38 RID: 126520
		[Token(Token = "0x401EE38")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_useVoucher;

		// Token: 0x0401EE39 RID: 126521
		[Token(Token = "0x401EE39")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_usePriceToBuy;

		// Token: 0x0401EE3A RID: 126522
		[Token(Token = "0x401EE3A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_usePriceToBuy;

		// Token: 0x0401EE3B RID: 126523
		[Token(Token = "0x401EE3B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_hasCurSkin;

		// Token: 0x0401EE3C RID: 126524
		[Token(Token = "0x401EE3C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_hasCurSkin;

		// Token: 0x0401EE3D RID: 126525
		[Token(Token = "0x401EE3D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_isRedeem;

		// Token: 0x0401EE3E RID: 126526
		[Token(Token = "0x401EE3E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_isRedeem;

		// Token: 0x0401EE3F RID: 126527
		[Token(Token = "0x401EE3F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_hasCurSkinAndChar;

		// Token: 0x0401EE40 RID: 126528
		[Token(Token = "0x401EE40")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_set_hasCurSkinAndChar;

		// Token: 0x0401EE41 RID: 126529
		[Token(Token = "0x401EE41")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_showPricePart;

		// Token: 0x0401EE42 RID: 126530
		[Token(Token = "0x401EE42")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_set_showPricePart;

		// Token: 0x0401EE43 RID: 126531
		[Token(Token = "0x401EE43")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_giftAvatarId;

		// Token: 0x0401EE44 RID: 126532
		[Token(Token = "0x401EE44")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_set_giftAvatarId;

		// Token: 0x0401EE45 RID: 126533
		[Token(Token = "0x401EE45")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_giftAvatarDynId;

		// Token: 0x0401EE46 RID: 126534
		[Token(Token = "0x401EE46")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_set_giftAvatarDynId;

		// Token: 0x0401EE47 RID: 126535
		[Token(Token = "0x401EE47")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_giftDesc;

		// Token: 0x0401EE48 RID: 126536
		[Token(Token = "0x401EE48")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_set_giftDesc;

		// Token: 0x0401EE49 RID: 126537
		[Token(Token = "0x401EE49")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_showGiftPart;

		// Token: 0x0401EE4A RID: 126538
		[Token(Token = "0x401EE4A")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_set_showGiftPart;

		// Token: 0x0401EE4B RID: 126539
		[Token(Token = "0x401EE4B")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_showDynIllust;

		// Token: 0x0401EE4C RID: 126540
		[Token(Token = "0x401EE4C")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_set_showDynIllust;

		// Token: 0x0401EE4D RID: 126541
		[Token(Token = "0x401EE4D")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_equipedSpDynIllust;

		// Token: 0x0401EE4E RID: 126542
		[Token(Token = "0x401EE4E")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_set_equipedSpDynIllust;

		// Token: 0x0401EE4F RID: 126543
		[Token(Token = "0x401EE4F")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_get_showSpDynIllust;

		// Token: 0x0401EE50 RID: 126544
		[Token(Token = "0x401EE50")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_set_showSpDynIllust;

		// Token: 0x0401EE51 RID: 126545
		[Token(Token = "0x401EE51")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_get_skinShopModel;

		// Token: 0x0401EE52 RID: 126546
		[Token(Token = "0x401EE52")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_get_groupSortId;

		// Token: 0x0401EE53 RID: 126547
		[Token(Token = "0x401EE53")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x0401EE54 RID: 126548
		[Token(Token = "0x401EE54")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_CheckSkinAvailableState;

		// Token: 0x0401EE55 RID: 126549
		[Token(Token = "0x401EE55")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_GetSkinTmplSortId;

		// Token: 0x0401EE56 RID: 126550
		[Token(Token = "0x401EE56")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_CheckIfHasSkin;

		// Token: 0x0401EE57 RID: 126551
		[Token(Token = "0x401EE57")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_CheckIsEquipedSpDynIllust;

		// Token: 0x0401EE58 RID: 126552
		[Token(Token = "0x401EE58")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__CheckSelectFlag;

		// Token: 0x0401EE59 RID: 126553
		[Token(Token = "0x401EE59")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_LoadAvatarImage;

		// Token: 0x0401EE5A RID: 126554
		[Token(Token = "0x401EE5A")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0401EE5B RID: 126555
		[Token(Token = "0x401EE5B")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_SetShowingSpDynIllust;

		// Token: 0x0401EE5C RID: 126556
		[Token(Token = "0x401EE5C")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0401EE5D RID: 126557
		[Token(Token = "0x401EE5D")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix1_InitData;

		// Token: 0x0401EE5E RID: 126558
		[Token(Token = "0x401EE5E")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__UpdateData;

		// Token: 0x0401EE5F RID: 126559
		[Token(Token = "0x401EE5F")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__AnalyseCurSkinState;

		// Token: 0x0401EE60 RID: 126560
		[Token(Token = "0x401EE60")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__GetPortraitId;

		// Token: 0x0401EE61 RID: 126561
		[Token(Token = "0x401EE61")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__GetAvatarId;

		// Token: 0x0401EE62 RID: 126562
		[Token(Token = "0x401EE62")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
