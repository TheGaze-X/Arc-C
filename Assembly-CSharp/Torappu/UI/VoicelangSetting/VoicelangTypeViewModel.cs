using System;
using Il2CppDummyDll;

namespace Torappu.UI.VoicelangSetting
{
	// Token: 0x02003BAF RID: 15279
	[Token(Token = "0x2003BAF")]
	public class VoicelangTypeViewModel
	{
		// Token: 0x17003935 RID: 14645
		// (get) Token: 0x06017EED RID: 98029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003935")]
		public string TypeName
		{
			[Token(Token = "0x6017EED")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003936 RID: 14646
		// (get) Token: 0x06017EEE RID: 98030 RVA: 0x00098B20 File Offset: 0x00096D20
		[Token(Token = "0x17003936")]
		public VoiceLangGroupType type
		{
			[Token(Token = "0x6017EEE")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return VoiceLangGroupType.NONE;
			}
		}

		// Token: 0x17003937 RID: 14647
		// (get) Token: 0x06017EEF RID: 98031 RVA: 0x00098B38 File Offset: 0x00096D38
		[Token(Token = "0x17003937")]
		public bool valid
		{
			[Token(Token = "0x6017EEF")]
			[Address(RVA = "0x4F61F0", Offset = "0x4F4DF0", VA = "0x1804F61F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003938 RID: 14648
		// (get) Token: 0x06017EF0 RID: 98032 RVA: 0x00098B50 File Offset: 0x00096D50
		// (set) Token: 0x06017EF1 RID: 98033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003938")]
		public bool selected
		{
			[Token(Token = "0x6017EF0")]
			[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6017EF1")]
			[Address(RVA = "0x4F1E30", Offset = "0x4F0A30", VA = "0x1804F1E30")]
			set
			{
			}
		}

		// Token: 0x17003939 RID: 14649
		// (get) Token: 0x06017EF2 RID: 98034 RVA: 0x00098B68 File Offset: 0x00096D68
		// (set) Token: 0x06017EF3 RID: 98035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003939")]
		public bool isAll
		{
			[Token(Token = "0x6017EF2")]
			[Address(RVA = "0x1076980", Offset = "0x1075580", VA = "0x181076980")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6017EF3")]
			[Address(RVA = "0x1076990", Offset = "0x1075590", VA = "0x181076990")]
			set
			{
			}
		}

		// Token: 0x1700393A RID: 14650
		// (get) Token: 0x06017EF4 RID: 98036 RVA: 0x00098B80 File Offset: 0x00096D80
		// (set) Token: 0x06017EF5 RID: 98037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700393A")]
		public int count
		{
			[Token(Token = "0x6017EF4")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6017EF5")]
			[Address(RVA = "0x4EAC10", Offset = "0x4E9810", VA = "0x1804EAC10")]
			set
			{
			}
		}

		// Token: 0x06017EF6 RID: 98038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017EF6")]
		[Address(RVA = "0x10768A0", Offset = "0x10754A0", VA = "0x1810768A0")]
		public void FillModel(VoiceLangGroupType type, bool valid, bool selected, bool isAll)
		{
		}

		// Token: 0x06017EF7 RID: 98039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017EF7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public VoicelangTypeViewModel()
		{
		}

		// Token: 0x0401CF15 RID: 118549
		[Token(Token = "0x401CF15")]
		[FieldOffset(Offset = "0x10")]
		private string m_typeName;

		// Token: 0x0401CF16 RID: 118550
		[Token(Token = "0x401CF16")]
		[FieldOffset(Offset = "0x18")]
		private VoiceLangGroupType m_type;

		// Token: 0x0401CF17 RID: 118551
		[Token(Token = "0x401CF17")]
		[FieldOffset(Offset = "0x1C")]
		private int m_count;

		// Token: 0x0401CF18 RID: 118552
		[Token(Token = "0x401CF18")]
		[FieldOffset(Offset = "0x20")]
		private bool m_selected;

		// Token: 0x0401CF19 RID: 118553
		[Token(Token = "0x401CF19")]
		[FieldOffset(Offset = "0x21")]
		private bool m_valid;

		// Token: 0x0401CF1A RID: 118554
		[Token(Token = "0x401CF1A")]
		[FieldOffset(Offset = "0x22")]
		private bool m_isAll;
	}
}
