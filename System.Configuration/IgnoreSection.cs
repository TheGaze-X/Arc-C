using System;
using System.Xml;
using Il2CppDummyDll;

namespace System.Configuration
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	public sealed class IgnoreSection : ConfigurationSection
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x4F1AFF0", Offset = "0x4F19BF0", VA = "0x184F1AFF0")]
		public IgnoreSection()
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000009")]
		protected internal override ConfigurationPropertyCollection Properties
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x4F1B020", Offset = "0x4F19C20", VA = "0x184F1B020", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x4F1AF00", Offset = "0x4F19B00", VA = "0x184F1AF00", Slot = "13")]
		protected internal override void DeserializeSection(XmlReader xmlReader)
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000020D0 File Offset: 0x000002D0
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x4F1AF30", Offset = "0x4F19B30", VA = "0x184F1AF30", Slot = "7")]
		protected internal override bool IsModified()
		{
			return default(bool);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x4F1AF90", Offset = "0x4F19B90", VA = "0x184F1AF90", Slot = "9")]
		protected internal override void Reset(ConfigurationElement parentSection)
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x4F1AF60", Offset = "0x4F19B60", VA = "0x184F1AF60", Slot = "10")]
		protected internal override void ResetModified()
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x4F1AFC0", Offset = "0x4F19BC0", VA = "0x184F1AFC0", Slot = "14")]
		protected internal override string SerializeSection(ConfigurationElement parentSection, string name, ConfigurationSaveMode saveMode)
		{
			return null;
		}
	}
}
