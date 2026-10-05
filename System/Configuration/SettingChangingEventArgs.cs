using System;
using System.ComponentModel;
using Il2CppDummyDll;

namespace System.Configuration
{
	// Token: 0x02000418 RID: 1048
	[Token(Token = "0x2000418")]
	public class SettingChangingEventArgs : CancelEventArgs
	{
		// Token: 0x06001C1D RID: 7197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C1D")]
		[Address(RVA = "0x50BE880", Offset = "0x50BD480", VA = "0x1850BE880")]
		public SettingChangingEventArgs(string settingName, string settingClass, string settingKey, object newValue, bool cancel)
		{
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06001C1E RID: 7198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000675")]
		public object NewValue
		{
			[Token(Token = "0x6001C1E")]
			[Address(RVA = "0x50BE8B0", Offset = "0x50BD4B0", VA = "0x1850BE8B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06001C1F RID: 7199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000676")]
		public string SettingClass
		{
			[Token(Token = "0x6001C1F")]
			[Address(RVA = "0x50BE8E0", Offset = "0x50BD4E0", VA = "0x1850BE8E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06001C20 RID: 7200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000677")]
		public string SettingKey
		{
			[Token(Token = "0x6001C20")]
			[Address(RVA = "0x50BE910", Offset = "0x50BD510", VA = "0x1850BE910")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06001C21 RID: 7201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000678")]
		public string SettingName
		{
			[Token(Token = "0x6001C21")]
			[Address(RVA = "0x50BE940", Offset = "0x50BD540", VA = "0x1850BE940")]
			get
			{
				return null;
			}
		}
	}
}
