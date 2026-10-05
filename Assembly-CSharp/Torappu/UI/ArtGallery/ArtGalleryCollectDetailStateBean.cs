using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x020065D2 RID: 26066
	[Token(Token = "0x20065D2")]
	public class ArtGalleryCollectDetailStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17005898 RID: 22680
		// (get) Token: 0x06025769 RID: 153449 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602576A RID: 153450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005898")]
		public string selectedSetId
		{
			[Token(Token = "0x6025769")]
			[Address(RVA = "0x2058C80", Offset = "0x2057880", VA = "0x182058C80")]
			get
			{
				return null;
			}
			[Token(Token = "0x602576A")]
			[Address(RVA = "0x2058CE0", Offset = "0x20578E0", VA = "0x182058CE0")]
			set
			{
			}
		}

		// Token: 0x0602576B RID: 153451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602576B")]
		[Address(RVA = "0x2058C20", Offset = "0x2057820", VA = "0x182058C20")]
		public ArtGalleryCollectDetailStateBean()
		{
		}

		// Token: 0x0403493F RID: 215359
		[Token(Token = "0x403493F")]
		[FieldOffset(Offset = "0x10")]
		private string m_selectedSetId;

		// Token: 0x04034940 RID: 215360
		[Token(Token = "0x4034940")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedSetId;

		// Token: 0x04034941 RID: 215361
		[Token(Token = "0x4034941")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_selectedSetId;

		// Token: 0x04034942 RID: 215362
		[Token(Token = "0x4034942")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
