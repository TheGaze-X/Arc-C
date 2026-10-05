using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x020065D0 RID: 26064
	[Token(Token = "0x20065D0")]
	public class ArtGalleryCollectDetailMissionStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17005896 RID: 22678
		// (get) Token: 0x06025757 RID: 153431 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06025758 RID: 153432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005896")]
		public string selectedSetId
		{
			[Token(Token = "0x6025757")]
			[Address(RVA = "0x20579C0", Offset = "0x20565C0", VA = "0x1820579C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6025758")]
			[Address(RVA = "0x2057A20", Offset = "0x2056620", VA = "0x182057A20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005897 RID: 22679
		// (get) Token: 0x06025759 RID: 153433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005897")]
		public ArtGalleryCollectDetailMissionProperty prop
		{
			[Token(Token = "0x6025759")]
			[Address(RVA = "0x2057960", Offset = "0x2056560", VA = "0x182057960")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x0602575A RID: 153434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602575A")]
		[Address(RVA = "0x20578C0", Offset = "0x20564C0", VA = "0x1820578C0")]
		public ArtGalleryCollectDetailMissionStateBean()
		{
		}

		// Token: 0x0403492A RID: 215338
		[Token(Token = "0x403492A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedSetId;

		// Token: 0x0403492B RID: 215339
		[Token(Token = "0x403492B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_selectedSetId;

		// Token: 0x0403492C RID: 215340
		[Token(Token = "0x403492C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_prop;

		// Token: 0x0403492D RID: 215341
		[Token(Token = "0x403492D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
