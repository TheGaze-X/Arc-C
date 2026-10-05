using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006530 RID: 25904
	[Token(Token = "0x2006530")]
	public class ArtMagazineCoverDetailLeafItemViewModel : IHotfixable
	{
		// Token: 0x170057DA RID: 22490
		// (get) Token: 0x060253A1 RID: 152481 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060253A2 RID: 152482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057DA")]
		public string leafId
		{
			[Token(Token = "0x60253A1")]
			[Address(RVA = "0x2026E10", Offset = "0x2025A10", VA = "0x182026E10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60253A2")]
			[Address(RVA = "0x2026F30", Offset = "0x2025B30", VA = "0x182026F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057DB RID: 22491
		// (get) Token: 0x060253A3 RID: 152483 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060253A4 RID: 152484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057DB")]
		public string leafName
		{
			[Token(Token = "0x60253A3")]
			[Address(RVA = "0x2026E70", Offset = "0x2025A70", VA = "0x182026E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60253A4")]
			[Address(RVA = "0x2026FB0", Offset = "0x2025BB0", VA = "0x182026FB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057DC RID: 22492
		// (get) Token: 0x060253A5 RID: 152485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170057DC")]
		public ArtMagazineLeafViewModel leafViewModel
		{
			[Token(Token = "0x60253A5")]
			[Address(RVA = "0x2026ED0", Offset = "0x2025AD0", VA = "0x182026ED0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060253A6 RID: 152486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253A6")]
		[Address(RVA = "0x20269D0", Offset = "0x20255D0", VA = "0x1820269D0")]
		public void LoadData(string leafId, string nickName)
		{
		}

		// Token: 0x060253A7 RID: 152487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253A7")]
		[Address(RVA = "0x2026C70", Offset = "0x2025870", VA = "0x182026C70")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x060253A8 RID: 152488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253A8")]
		[Address(RVA = "0x2026B40", Offset = "0x2025740", VA = "0x182026B40")]
		public void RefreshDefaultData()
		{
		}

		// Token: 0x060253A9 RID: 152489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60253A9")]
		[Address(RVA = "0x2026D70", Offset = "0x2025970", VA = "0x182026D70")]
		public ArtMagazineCoverDetailLeafItemViewModel()
		{
		}

		// Token: 0x0403439C RID: 213916
		[Token(Token = "0x403439C")]
		[FieldOffset(Offset = "0x20")]
		private ArtMagazineLeafViewModel m_leafViewModel;

		// Token: 0x0403439D RID: 213917
		[Token(Token = "0x403439D")]
		[FieldOffset(Offset = "0x28")]
		private string m_nickName;

		// Token: 0x0403439E RID: 213918
		[Token(Token = "0x403439E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_leafId;

		// Token: 0x0403439F RID: 213919
		[Token(Token = "0x403439F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_leafId;

		// Token: 0x040343A0 RID: 213920
		[Token(Token = "0x40343A0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_leafName;

		// Token: 0x040343A1 RID: 213921
		[Token(Token = "0x40343A1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_leafName;

		// Token: 0x040343A2 RID: 213922
		[Token(Token = "0x40343A2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_leafViewModel;

		// Token: 0x040343A3 RID: 213923
		[Token(Token = "0x40343A3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040343A4 RID: 213924
		[Token(Token = "0x40343A4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x040343A5 RID: 213925
		[Token(Token = "0x40343A5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RefreshDefaultData;

		// Token: 0x040343A6 RID: 213926
		[Token(Token = "0x40343A6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
