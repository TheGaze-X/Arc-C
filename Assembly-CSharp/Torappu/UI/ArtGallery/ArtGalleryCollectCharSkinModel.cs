using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x0200662C RID: 26156
	[Token(Token = "0x200662C")]
	public class ArtGalleryCollectCharSkinModel : ArtGalleryCollectItemModelBase
	{
		// Token: 0x170058C5 RID: 22725
		// (get) Token: 0x06025903 RID: 153859 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06025904 RID: 153860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170058C5")]
		public string charName
		{
			[Token(Token = "0x6025903")]
			[Address(RVA = "0x2070F10", Offset = "0x206FB10", VA = "0x182070F10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6025904")]
			[Address(RVA = "0x2071050", Offset = "0x206FC50", VA = "0x182071050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170058C6 RID: 22726
		// (get) Token: 0x06025905 RID: 153861 RVA: 0x000C8448 File Offset: 0x000C6648
		// (set) Token: 0x06025906 RID: 153862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170058C6")]
		public bool showDyn
		{
			[Token(Token = "0x6025905")]
			[Address(RVA = "0x2070F70", Offset = "0x206FB70", VA = "0x182070F70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6025906")]
			[Address(RVA = "0x20710D0", Offset = "0x206FCD0", VA = "0x1820710D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170058C7 RID: 22727
		// (get) Token: 0x06025907 RID: 153863 RVA: 0x000C8460 File Offset: 0x000C6660
		// (set) Token: 0x06025908 RID: 153864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170058C7")]
		public CharUISkinStruct skinStruct
		{
			[Token(Token = "0x6025907")]
			[Address(RVA = "0x2070FD0", Offset = "0x206FBD0", VA = "0x182070FD0")]
			[CompilerGenerated]
			get
			{
				return default(CharUISkinStruct);
			}
			[Token(Token = "0x6025908")]
			[Address(RVA = "0x2071140", Offset = "0x206FD40", VA = "0x182071140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06025909 RID: 153865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025909")]
		[Address(RVA = "0x2070AF0", Offset = "0x206F6F0", VA = "0x182070AF0", Slot = "5")]
		protected override void _LoadDataByType()
		{
		}

		// Token: 0x0602590A RID: 153866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602590A")]
		[Address(RVA = "0x2070E70", Offset = "0x206FA70", VA = "0x182070E70")]
		public ArtGalleryCollectCharSkinModel()
		{
		}

		// Token: 0x04034C5E RID: 216158
		[Token(Token = "0x4034C5E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charName;

		// Token: 0x04034C5F RID: 216159
		[Token(Token = "0x4034C5F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_charName;

		// Token: 0x04034C60 RID: 216160
		[Token(Token = "0x4034C60")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_showDyn;

		// Token: 0x04034C61 RID: 216161
		[Token(Token = "0x4034C61")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_showDyn;

		// Token: 0x04034C62 RID: 216162
		[Token(Token = "0x4034C62")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_skinStruct;

		// Token: 0x04034C63 RID: 216163
		[Token(Token = "0x4034C63")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_skinStruct;

		// Token: 0x04034C64 RID: 216164
		[Token(Token = "0x4034C64")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadDataByType;

		// Token: 0x04034C65 RID: 216165
		[Token(Token = "0x4034C65")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
