using System;
using Il2CppDummyDll;

namespace Torappu.UI.VoicelangSetting
{
	// Token: 0x02003BA7 RID: 15271
	[Token(Token = "0x2003BA7")]
	public class VoicelangPowerViewModel
	{
		// Token: 0x17003929 RID: 14633
		// (get) Token: 0x06017EC1 RID: 97985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003929")]
		public string powerId
		{
			[Token(Token = "0x6017EC1")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700392A RID: 14634
		// (get) Token: 0x06017EC2 RID: 97986 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06017EC3 RID: 97987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700392A")]
		public string powerCode
		{
			[Token(Token = "0x6017EC2")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6017EC3")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x1700392B RID: 14635
		// (get) Token: 0x06017EC4 RID: 97988 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06017EC5 RID: 97989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700392B")]
		public string powerName
		{
			[Token(Token = "0x6017EC4")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6017EC5")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x1700392C RID: 14636
		// (get) Token: 0x06017EC6 RID: 97990 RVA: 0x00098A48 File Offset: 0x00096C48
		// (set) Token: 0x06017EC7 RID: 97991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700392C")]
		public int orderNum
		{
			[Token(Token = "0x6017EC6")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6017EC7")]
			[Address(RVA = "0x4EF630", Offset = "0x4EE230", VA = "0x1804EF630")]
			set
			{
			}
		}

		// Token: 0x1700392D RID: 14637
		// (get) Token: 0x06017EC8 RID: 97992 RVA: 0x00098A60 File Offset: 0x00096C60
		// (set) Token: 0x06017EC9 RID: 97993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700392D")]
		public bool isAll
		{
			[Token(Token = "0x6017EC8")]
			[Address(RVA = "0x4EF600", Offset = "0x4EE200", VA = "0x1804EF600")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6017EC9")]
			[Address(RVA = "0x4EF620", Offset = "0x4EE220", VA = "0x1804EF620")]
			set
			{
			}
		}

		// Token: 0x1700392E RID: 14638
		// (get) Token: 0x06017ECA RID: 97994 RVA: 0x00098A78 File Offset: 0x00096C78
		// (set) Token: 0x06017ECB RID: 97995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700392E")]
		public bool isNew
		{
			[Token(Token = "0x6017ECA")]
			[Address(RVA = "0x106F290", Offset = "0x106DE90", VA = "0x18106F290")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6017ECB")]
			[Address(RVA = "0x106F2A0", Offset = "0x106DEA0", VA = "0x18106F2A0")]
			set
			{
			}
		}

		// Token: 0x06017ECC RID: 97996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017ECC")]
		[Address(RVA = "0x106F090", Offset = "0x106DC90", VA = "0x18106F090")]
		public void FillViewModel(string p_powerId)
		{
		}

		// Token: 0x06017ECD RID: 97997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017ECD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public VoicelangPowerViewModel()
		{
		}

		// Token: 0x0401CEF4 RID: 118516
		[Token(Token = "0x401CEF4")]
		public const string POWERID_ALL = "powerId_all";

		// Token: 0x0401CEF5 RID: 118517
		[Token(Token = "0x401CEF5")]
		[FieldOffset(Offset = "0x10")]
		private string m_powerId;

		// Token: 0x0401CEF6 RID: 118518
		[Token(Token = "0x401CEF6")]
		[FieldOffset(Offset = "0x18")]
		private string m_powerCode;

		// Token: 0x0401CEF7 RID: 118519
		[Token(Token = "0x401CEF7")]
		[FieldOffset(Offset = "0x20")]
		private string m_powerName;

		// Token: 0x0401CEF8 RID: 118520
		[Token(Token = "0x401CEF8")]
		[FieldOffset(Offset = "0x28")]
		private int m_orderNum;

		// Token: 0x0401CEF9 RID: 118521
		[Token(Token = "0x401CEF9")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_isAll;

		// Token: 0x0401CEFA RID: 118522
		[Token(Token = "0x401CEFA")]
		[FieldOffset(Offset = "0x2D")]
		private bool m_isNew;
	}
}
