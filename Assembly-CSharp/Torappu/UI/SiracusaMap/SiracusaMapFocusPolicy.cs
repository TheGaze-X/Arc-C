using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F9F RID: 16287
	[Token(Token = "0x2003F9F")]
	public struct SiracusaMapFocusPolicy : IHotfixable
	{
		// Token: 0x17003C5A RID: 15450
		// (get) Token: 0x06019426 RID: 103462 RVA: 0x0009D668 File Offset: 0x0009B868
		// (set) Token: 0x06019427 RID: 103463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C5A")]
		public uint focusVersion
		{
			[Token(Token = "0x6019426")]
			[Address(RVA = "0x11EDAE0", Offset = "0x11EC6E0", VA = "0x1811EDAE0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6019427")]
			[Address(RVA = "0x11EDB60", Offset = "0x11EC760", VA = "0x1811EDB60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06019428 RID: 103464 RVA: 0x0009D680 File Offset: 0x0009B880
		[Token(Token = "0x6019428")]
		[Address(RVA = "0x11ED1F0", Offset = "0x11EBDF0", VA = "0x1811ED1F0")]
		public bool ShouldRefocus(SiracusaMapFocusPolicy previousPolicy)
		{
			return default(bool);
		}

		// Token: 0x06019429 RID: 103465 RVA: 0x0009D698 File Offset: 0x0009B898
		[Token(Token = "0x6019429")]
		[Address(RVA = "0x11ED140", Offset = "0x11EBD40", VA = "0x1811ED140")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x0601942A RID: 103466 RVA: 0x0009D6B0 File Offset: 0x0009B8B0
		[Token(Token = "0x601942A")]
		[Address(RVA = "0x11ECCB0", Offset = "0x11EB8B0", VA = "0x1811ECCB0")]
		public static SiracusaMapFocusPolicy Create(uint focusVersion, SiracusaMapPage.Param pageParam, SiracusaMapViewModel mapModel)
		{
			return default(SiracusaMapFocusPolicy);
		}

		// Token: 0x0601942B RID: 103467 RVA: 0x0009D6C8 File Offset: 0x0009B8C8
		[Token(Token = "0x601942B")]
		[Address(RVA = "0x11ED2C0", Offset = "0x11EBEC0", VA = "0x1811ED2C0")]
		public static SiracusaMapFocusPolicy TryFocusToArea(uint focusVersion, string areaId)
		{
			return default(SiracusaMapFocusPolicy);
		}

		// Token: 0x0601942C RID: 103468 RVA: 0x0009D6E0 File Offset: 0x0009B8E0
		[Token(Token = "0x601942C")]
		[Address(RVA = "0x11ED7E0", Offset = "0x11EC3E0", VA = "0x1811ED7E0")]
		private static bool _FocusToSelectedPoint(SiracusaMapViewModel mapModel, out SiracusaMapFocusPolicy policy)
		{
			return default(bool);
		}

		// Token: 0x0601942D RID: 103469 RVA: 0x0009D6F8 File Offset: 0x0009B8F8
		[Token(Token = "0x601942D")]
		[Address(RVA = "0x11ED400", Offset = "0x11EC000", VA = "0x1811ED400")]
		private static bool _FocusNewlyUnlockedStage(SiracusaMapViewModel mapModel, out SiracusaMapFocusPolicy policy)
		{
			return default(bool);
		}

		// Token: 0x0601942E RID: 103470 RVA: 0x0009D710 File Offset: 0x0009B910
		[Token(Token = "0x601942E")]
		[Address(RVA = "0x11ED900", Offset = "0x11EC500", VA = "0x1811ED900")]
		private static bool _FocusUnpassedStage(SiracusaMapViewModel mapModel, out SiracusaMapFocusPolicy policy)
		{
			return default(bool);
		}

		// Token: 0x0401F5BA RID: 128442
		[Token(Token = "0x401F5BA")]
		[FieldOffset(Offset = "0x8")]
		public string fromPoint;

		// Token: 0x0401F5BB RID: 128443
		[Token(Token = "0x401F5BB")]
		[FieldOffset(Offset = "0x10")]
		public string toPoint;

		// Token: 0x0401F5BC RID: 128444
		[Token(Token = "0x401F5BC")]
		[FieldOffset(Offset = "0x18")]
		public string toArea;

		// Token: 0x0401F5BD RID: 128445
		[Token(Token = "0x401F5BD")]
		[FieldOffset(Offset = "0x20")]
		public bool isTargetSelected;

		// Token: 0x0401F5BE RID: 128446
		[Token(Token = "0x401F5BE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_focusVersion;

		// Token: 0x0401F5BF RID: 128447
		[Token(Token = "0x401F5BF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_focusVersion;

		// Token: 0x0401F5C0 RID: 128448
		[Token(Token = "0x401F5C0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShouldRefocus;

		// Token: 0x0401F5C1 RID: 128449
		[Token(Token = "0x401F5C1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsEmpty;

		// Token: 0x0401F5C2 RID: 128450
		[Token(Token = "0x401F5C2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Create;

		// Token: 0x0401F5C3 RID: 128451
		[Token(Token = "0x401F5C3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TryFocusToArea;

		// Token: 0x0401F5C4 RID: 128452
		[Token(Token = "0x401F5C4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__FocusToSelectedPoint;

		// Token: 0x0401F5C5 RID: 128453
		[Token(Token = "0x401F5C5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__FocusNewlyUnlockedStage;

		// Token: 0x0401F5C6 RID: 128454
		[Token(Token = "0x401F5C6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__FocusUnpassedStage;
	}
}
