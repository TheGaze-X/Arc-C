using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.VoicelangSetting
{
	// Token: 0x02003BA5 RID: 15269
	[Token(Token = "0x2003BA5")]
	public class VoicelangPowerGroupViewModel
	{
		// Token: 0x17003927 RID: 14631
		// (get) Token: 0x06017EBA RID: 97978 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06017EBB RID: 97979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003927")]
		public List<VoicelangPowerViewModel> dataSource
		{
			[Token(Token = "0x6017EBA")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6017EBB")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x17003928 RID: 14632
		// (get) Token: 0x06017EBC RID: 97980 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06017EBD RID: 97981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003928")]
		public string selectPowerId
		{
			[Token(Token = "0x6017EBC")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6017EBD")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x06017EBE RID: 97982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017EBE")]
		[Address(RVA = "0x106E8A0", Offset = "0x106D4A0", VA = "0x18106E8A0")]
		public void RefreshRedPoint(List<VoicelangCardViewModel> cardListWithRedPoint)
		{
		}

		// Token: 0x06017EBF RID: 97983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017EBF")]
		[Address(RVA = "0x106EAF0", Offset = "0x106D6F0", VA = "0x18106EAF0")]
		public VoicelangPowerGroupViewModel()
		{
		}

		// Token: 0x0401CEF2 RID: 118514
		[Token(Token = "0x401CEF2")]
		[FieldOffset(Offset = "0x10")]
		private List<VoicelangPowerViewModel> m_powerViewModels;

		// Token: 0x0401CEF3 RID: 118515
		[Token(Token = "0x401CEF3")]
		[FieldOffset(Offset = "0x18")]
		private string m_selectPowerId;
	}
}
