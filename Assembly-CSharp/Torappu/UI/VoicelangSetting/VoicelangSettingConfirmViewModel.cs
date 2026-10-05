using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.VoicelangSetting
{
	// Token: 0x02003BA9 RID: 15273
	[Token(Token = "0x2003BA9")]
	public class VoicelangSettingConfirmViewModel
	{
		// Token: 0x1700392F RID: 14639
		// (get) Token: 0x06017ECE RID: 97998 RVA: 0x00098A90 File Offset: 0x00096C90
		// (set) Token: 0x06017ECF RID: 97999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700392F")]
		public ConfirmViewState State
		{
			[Token(Token = "0x6017ECE")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return ConfirmViewState.SingleOpen;
			}
			[Token(Token = "0x6017ECF")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			set
			{
			}
		}

		// Token: 0x17003930 RID: 14640
		// (get) Token: 0x06017ED0 RID: 98000 RVA: 0x00098AA8 File Offset: 0x00096CA8
		// (set) Token: 0x06017ED1 RID: 98001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003930")]
		public VoiceLangType selectedType
		{
			[Token(Token = "0x6017ED0")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
			get
			{
				return VoiceLangType.NONE;
			}
			[Token(Token = "0x6017ED1")]
			[Address(RVA = "0x106FD40", Offset = "0x106E940", VA = "0x18106FD40")]
			set
			{
			}
		}

		// Token: 0x17003931 RID: 14641
		// (get) Token: 0x06017ED2 RID: 98002 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06017ED3 RID: 98003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003931")]
		public List<VoicelangCardViewModel> selectedCards
		{
			[Token(Token = "0x6017ED2")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6017ED3")]
			[Address(RVA = "0x106F990", Offset = "0x106E590", VA = "0x18106F990")]
			set
			{
			}
		}

		// Token: 0x06017ED4 RID: 98004 RVA: 0x00098AC0 File Offset: 0x00096CC0
		[Token(Token = "0x6017ED4")]
		[Address(RVA = "0x106F810", Offset = "0x106E410", VA = "0x18106F810")]
		public bool TryGetSingleSelection(out VoicelangCardViewModel cardMode)
		{
			return default(bool);
		}

		// Token: 0x17003932 RID: 14642
		// (get) Token: 0x06017ED5 RID: 98005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003932")]
		public HashSet<VoiceLangType> displayTypes
		{
			[Token(Token = "0x6017ED5")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06017ED6 RID: 98006 RVA: 0x00098AD8 File Offset: 0x00096CD8
		[Token(Token = "0x6017ED6")]
		[Address(RVA = "0x106F640", Offset = "0x106E240", VA = "0x18106F640")]
		public bool GetComfirmable()
		{
			return default(bool);
		}

		// Token: 0x06017ED7 RID: 98007 RVA: 0x00098AF0 File Offset: 0x00096CF0
		[Token(Token = "0x6017ED7")]
		[Address(RVA = "0x106F800", Offset = "0x106E400", VA = "0x18106F800")]
		public bool IsPlayerVoiceSelected()
		{
			return default(bool);
		}

		// Token: 0x06017ED8 RID: 98008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017ED8")]
		[Address(RVA = "0x106F8C0", Offset = "0x106E4C0", VA = "0x18106F8C0")]
		public VoicelangSettingConfirmViewModel()
		{
		}

		// Token: 0x0401CEFF RID: 118527
		[Token(Token = "0x401CEFF")]
		[FieldOffset(Offset = "0x10")]
		private ConfirmViewState m_state;

		// Token: 0x0401CF00 RID: 118528
		[Token(Token = "0x401CF00")]
		[FieldOffset(Offset = "0x14")]
		private VoiceLangType m_selectedType;

		// Token: 0x0401CF01 RID: 118529
		[Token(Token = "0x401CF01")]
		[FieldOffset(Offset = "0x18")]
		private List<VoicelangCardViewModel> m_selectedCards;

		// Token: 0x0401CF02 RID: 118530
		[Token(Token = "0x401CF02")]
		[FieldOffset(Offset = "0x20")]
		private HashSet<VoiceLangType> m_displayTypes;

		// Token: 0x0401CF03 RID: 118531
		[Token(Token = "0x401CF03")]
		[FieldOffset(Offset = "0x28")]
		private VoiceLangType m_allCardsSameType;
	}
}
