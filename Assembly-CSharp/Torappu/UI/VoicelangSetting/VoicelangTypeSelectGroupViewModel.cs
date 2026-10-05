using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.VoicelangSetting
{
	// Token: 0x02003BAD RID: 15277
	[Token(Token = "0x2003BAD")]
	public class VoicelangTypeSelectGroupViewModel
	{
		// Token: 0x17003933 RID: 14643
		// (get) Token: 0x06017EE6 RID: 98022 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06017EE7 RID: 98023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003933")]
		public List<VoicelangTypeViewModel> typeViewModels
		{
			[Token(Token = "0x6017EE6")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6017EE7")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x17003934 RID: 14644
		// (get) Token: 0x06017EE8 RID: 98024 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06017EE9 RID: 98025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003934")]
		public Dictionary<string, VoicelangCardViewModel> cardViewModels
		{
			[Token(Token = "0x6017EE8")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6017EE9")]
			[Address(RVA = "0x1075FF0", Offset = "0x1074BF0", VA = "0x181075FF0")]
			set
			{
			}
		}

		// Token: 0x06017EEA RID: 98026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017EEA")]
		[Address(RVA = "0x1075DC0", Offset = "0x10749C0", VA = "0x181075DC0")]
		public void SetGroupType(bool isAll, VoiceLangGroupType type = VoiceLangGroupType.NONE)
		{
		}

		// Token: 0x06017EEB RID: 98027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017EEB")]
		[Address(RVA = "0x1075F20", Offset = "0x1074B20", VA = "0x181075F20")]
		public VoicelangTypeSelectGroupViewModel()
		{
		}

		// Token: 0x0401CF13 RID: 118547
		[Token(Token = "0x401CF13")]
		[FieldOffset(Offset = "0x10")]
		private List<VoicelangTypeViewModel> m_typeViewModels;

		// Token: 0x0401CF14 RID: 118548
		[Token(Token = "0x401CF14")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, VoicelangCardViewModel> m_cardViewModels;
	}
}
