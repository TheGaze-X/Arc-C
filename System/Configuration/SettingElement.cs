using System;
using Il2CppDummyDll;

namespace System.Configuration
{
	// Token: 0x02000420 RID: 1056
	[Token(Token = "0x2000420")]
	public sealed class SettingElement : ConfigurationElement
	{
		// Token: 0x06001C3B RID: 7227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C3B")]
		[Address(RVA = "0x50BEBE0", Offset = "0x50BD7E0", VA = "0x1850BEBE0")]
		public SettingElement()
		{
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C3C")]
		[Address(RVA = "0x50BEC10", Offset = "0x50BD810", VA = "0x1850BEC10")]
		public SettingElement(string name, SettingsSerializeAs serializeAs)
		{
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06001C3D RID: 7229 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001C3E RID: 7230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700067E")]
		public string Name
		{
			[Token(Token = "0x6001C3D")]
			[Address(RVA = "0x50BEC40", Offset = "0x50BD840", VA = "0x1850BEC40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C3E")]
			[Address(RVA = "0x50BED00", Offset = "0x50BD900", VA = "0x1850BED00")]
			set
			{
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06001C3F RID: 7231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700067F")]
		protected override ConfigurationPropertyCollection Properties
		{
			[Token(Token = "0x6001C3F")]
			[Address(RVA = "0x50BEC70", Offset = "0x50BD870", VA = "0x1850BEC70", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06001C40 RID: 7232 RVA: 0x0000C2E8 File Offset: 0x0000A4E8
		// (set) Token: 0x06001C41 RID: 7233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000680")]
		public SettingsSerializeAs SerializeAs
		{
			[Token(Token = "0x6001C40")]
			[Address(RVA = "0x50BECA0", Offset = "0x50BD8A0", VA = "0x1850BECA0")]
			get
			{
				return SettingsSerializeAs.String;
			}
			[Token(Token = "0x6001C41")]
			[Address(RVA = "0x50BED30", Offset = "0x50BD930", VA = "0x1850BED30")]
			set
			{
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06001C42 RID: 7234 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001C43 RID: 7235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000681")]
		public SettingValueElement Value
		{
			[Token(Token = "0x6001C42")]
			[Address(RVA = "0x50BECD0", Offset = "0x50BD8D0", VA = "0x1850BECD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C43")]
			[Address(RVA = "0x50BED60", Offset = "0x50BD960", VA = "0x1850BED60")]
			set
			{
			}
		}
	}
}
