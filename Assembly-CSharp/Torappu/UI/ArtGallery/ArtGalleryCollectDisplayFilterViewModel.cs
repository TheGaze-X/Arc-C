using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x02006632 RID: 26162
	[Token(Token = "0x2006632")]
	public class ArtGalleryCollectDisplayFilterViewModel : IHotfixable
	{
		// Token: 0x170058EA RID: 22762
		// (get) Token: 0x0602595B RID: 153947 RVA: 0x000C8658 File Offset: 0x000C6858
		// (set) Token: 0x0602595C RID: 153948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170058EA")]
		public bool isFilterPanelShow
		{
			[Token(Token = "0x602595B")]
			[Address(RVA = "0x2079670", Offset = "0x2078270", VA = "0x182079670")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602595C")]
			[Address(RVA = "0x2079840", Offset = "0x2078440", VA = "0x182079840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170058EB RID: 22763
		// (get) Token: 0x0602595D RID: 153949 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602595E RID: 153950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170058EB")]
		public string curFilterTypeId
		{
			[Token(Token = "0x602595D")]
			[Address(RVA = "0x2079550", Offset = "0x2078150", VA = "0x182079550")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602595E")]
			[Address(RVA = "0x20796D0", Offset = "0x20782D0", VA = "0x1820796D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170058EC RID: 22764
		// (get) Token: 0x0602595F RID: 153951 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06025960 RID: 153952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170058EC")]
		public string curFilterTypeName
		{
			[Token(Token = "0x602595F")]
			[Address(RVA = "0x20795B0", Offset = "0x20781B0", VA = "0x1820795B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6025960")]
			[Address(RVA = "0x2079750", Offset = "0x2078350", VA = "0x182079750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170058ED RID: 22765
		// (get) Token: 0x06025961 RID: 153953 RVA: 0x000C8670 File Offset: 0x000C6870
		// (set) Token: 0x06025962 RID: 153954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170058ED")]
		public bool hasNewOrRewards
		{
			[Token(Token = "0x6025961")]
			[Address(RVA = "0x2079610", Offset = "0x2078210", VA = "0x182079610")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6025962")]
			[Address(RVA = "0x20797D0", Offset = "0x20783D0", VA = "0x1820797D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06025963 RID: 153955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025963")]
		[Address(RVA = "0x20786D0", Offset = "0x20772D0", VA = "0x1820786D0")]
		public void LoadData()
		{
		}

		// Token: 0x06025964 RID: 153956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025964")]
		[Address(RVA = "0x20792C0", Offset = "0x2077EC0", VA = "0x1820792C0")]
		public void RefreshFilterShowState(bool show)
		{
		}

		// Token: 0x06025965 RID: 153957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025965")]
		[Address(RVA = "0x2078E40", Offset = "0x2077A40", VA = "0x182078E40")]
		public void RefreshCurSelectSetType(string setType)
		{
		}

		// Token: 0x06025966 RID: 153958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025966")]
		[Address(RVA = "0x2078FF0", Offset = "0x2077BF0", VA = "0x182078FF0")]
		public void RefreshFilterData()
		{
		}

		// Token: 0x06025967 RID: 153959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025967")]
		[Address(RVA = "0x2079340", Offset = "0x2077F40", VA = "0x182079340")]
		private void _RefreshSelectSetTypeInfo(string setType)
		{
		}

		// Token: 0x06025968 RID: 153960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025968")]
		[Address(RVA = "0x20794A0", Offset = "0x20780A0", VA = "0x1820794A0")]
		public ArtGalleryCollectDisplayFilterViewModel()
		{
		}

		// Token: 0x04034CDB RID: 216283
		[Token(Token = "0x4034CDB")]
		[FieldOffset(Offset = "0x30")]
		public List<ArtGalleryCollectDisplayFilterItemViewModel> filterItemViewModels;

		// Token: 0x04034CDC RID: 216284
		[Token(Token = "0x4034CDC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isFilterPanelShow;

		// Token: 0x04034CDD RID: 216285
		[Token(Token = "0x4034CDD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isFilterPanelShow;

		// Token: 0x04034CDE RID: 216286
		[Token(Token = "0x4034CDE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_curFilterTypeId;

		// Token: 0x04034CDF RID: 216287
		[Token(Token = "0x4034CDF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_curFilterTypeId;

		// Token: 0x04034CE0 RID: 216288
		[Token(Token = "0x4034CE0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_curFilterTypeName;

		// Token: 0x04034CE1 RID: 216289
		[Token(Token = "0x4034CE1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_curFilterTypeName;

		// Token: 0x04034CE2 RID: 216290
		[Token(Token = "0x4034CE2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_hasNewOrRewards;

		// Token: 0x04034CE3 RID: 216291
		[Token(Token = "0x4034CE3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_hasNewOrRewards;

		// Token: 0x04034CE4 RID: 216292
		[Token(Token = "0x4034CE4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04034CE5 RID: 216293
		[Token(Token = "0x4034CE5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_RefreshFilterShowState;

		// Token: 0x04034CE6 RID: 216294
		[Token(Token = "0x4034CE6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_RefreshCurSelectSetType;

		// Token: 0x04034CE7 RID: 216295
		[Token(Token = "0x4034CE7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_RefreshFilterData;

		// Token: 0x04034CE8 RID: 216296
		[Token(Token = "0x4034CE8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__RefreshSelectSetTypeInfo;

		// Token: 0x04034CE9 RID: 216297
		[Token(Token = "0x4034CE9")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
