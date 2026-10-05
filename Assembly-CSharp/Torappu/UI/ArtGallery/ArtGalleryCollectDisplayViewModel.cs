using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x02006633 RID: 26163
	[Token(Token = "0x2006633")]
	public class ArtGalleryCollectDisplayViewModel : IHotfixable
	{
		// Token: 0x170058EE RID: 22766
		// (get) Token: 0x06025969 RID: 153961 RVA: 0x000C8688 File Offset: 0x000C6888
		// (set) Token: 0x0602596A RID: 153962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170058EE")]
		public int focusIdx
		{
			[Token(Token = "0x6025969")]
			[Address(RVA = "0x2089710", Offset = "0x2088310", VA = "0x182089710")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x602596A")]
			[Address(RVA = "0x20897E0", Offset = "0x20883E0", VA = "0x1820897E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170058EF RID: 22767
		// (get) Token: 0x0602596B RID: 153963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170058EF")]
		public List<ArtGalleryCollectSetViewModel> displaySets
		{
			[Token(Token = "0x602596B")]
			[Address(RVA = "0x20895F0", Offset = "0x20881F0", VA = "0x1820895F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170058F0 RID: 22768
		// (get) Token: 0x0602596C RID: 153964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170058F0")]
		public ArtGalleryCollectDisplayFilterViewModel filterViewModel
		{
			[Token(Token = "0x602596C")]
			[Address(RVA = "0x20896B0", Offset = "0x20882B0", VA = "0x1820896B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170058F1 RID: 22769
		// (get) Token: 0x0602596D RID: 153965 RVA: 0x000C86A0 File Offset: 0x000C68A0
		// (set) Token: 0x0602596E RID: 153966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170058F1")]
		public int enterSeq
		{
			[Token(Token = "0x602596D")]
			[Address(RVA = "0x2089650", Offset = "0x2088250", VA = "0x182089650")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x602596E")]
			[Address(RVA = "0x2089770", Offset = "0x2088370", VA = "0x182089770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602596F RID: 153967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602596F")]
		[Address(RVA = "0x20887C0", Offset = "0x20873C0", VA = "0x1820887C0")]
		public void LoadData()
		{
		}

		// Token: 0x06025970 RID: 153968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025970")]
		[Address(RVA = "0x2088CB0", Offset = "0x20878B0", VA = "0x182088CB0")]
		public void UpdateData()
		{
		}

		// Token: 0x06025971 RID: 153969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025971")]
		[Address(RVA = "0x2088C20", Offset = "0x2087820", VA = "0x182088C20")]
		public void ShowFilterPanel(bool show)
		{
		}

		// Token: 0x06025972 RID: 153970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025972")]
		[Address(RVA = "0x2088F50", Offset = "0x2087B50", VA = "0x182088F50")]
		public void UpdateFilterType(string setTypeId)
		{
		}

		// Token: 0x06025973 RID: 153971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025973")]
		[Address(RVA = "0x2088FF0", Offset = "0x2087BF0", VA = "0x182088FF0")]
		private void _ResetDisplaySets()
		{
		}

		// Token: 0x06025974 RID: 153972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025974")]
		[Address(RVA = "0x20894B0", Offset = "0x20880B0", VA = "0x1820894B0")]
		public ArtGalleryCollectDisplayViewModel()
		{
		}

		// Token: 0x04034CEC RID: 216300
		[Token(Token = "0x4034CEC")]
		[FieldOffset(Offset = "0x18")]
		private List<ArtGalleryCollectSetViewModel> m_displaySets;

		// Token: 0x04034CED RID: 216301
		[Token(Token = "0x4034CED")]
		[FieldOffset(Offset = "0x20")]
		private ListDict<string, ArtGalleryCollectSetViewModel> m_setModels;

		// Token: 0x04034CEE RID: 216302
		[Token(Token = "0x4034CEE")]
		[FieldOffset(Offset = "0x28")]
		private ArtGalleryCollectDisplayFilterViewModel m_filterViewModel;

		// Token: 0x04034CEF RID: 216303
		[Token(Token = "0x4034CEF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_focusIdx;

		// Token: 0x04034CF0 RID: 216304
		[Token(Token = "0x4034CF0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_focusIdx;

		// Token: 0x04034CF1 RID: 216305
		[Token(Token = "0x4034CF1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_displaySets;

		// Token: 0x04034CF2 RID: 216306
		[Token(Token = "0x4034CF2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_filterViewModel;

		// Token: 0x04034CF3 RID: 216307
		[Token(Token = "0x4034CF3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_enterSeq;

		// Token: 0x04034CF4 RID: 216308
		[Token(Token = "0x4034CF4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_enterSeq;

		// Token: 0x04034CF5 RID: 216309
		[Token(Token = "0x4034CF5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04034CF6 RID: 216310
		[Token(Token = "0x4034CF6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04034CF7 RID: 216311
		[Token(Token = "0x4034CF7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ShowFilterPanel;

		// Token: 0x04034CF8 RID: 216312
		[Token(Token = "0x4034CF8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_UpdateFilterType;

		// Token: 0x04034CF9 RID: 216313
		[Token(Token = "0x4034CF9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ResetDisplaySets;

		// Token: 0x04034CFA RID: 216314
		[Token(Token = "0x4034CFA")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
