using System;
using System.Xml;
using Il2CppDummyDll;

namespace System.Configuration
{
	// Token: 0x02000421 RID: 1057
	[Token(Token = "0x2000421")]
	public sealed class SettingValueElement : ConfigurationElement
	{
		// Token: 0x06001C44 RID: 7236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C44")]
		[Address(RVA = "0x50BEEB0", Offset = "0x50BDAB0", VA = "0x1850BEEB0")]
		public SettingValueElement()
		{
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06001C45 RID: 7237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000682")]
		protected override ConfigurationPropertyCollection Properties
		{
			[Token(Token = "0x6001C45")]
			[Address(RVA = "0x50BEEE0", Offset = "0x50BDAE0", VA = "0x1850BEEE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06001C46 RID: 7238 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001C47 RID: 7239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000683")]
		public XmlNode ValueXml
		{
			[Token(Token = "0x6001C46")]
			[Address(RVA = "0x50BEF10", Offset = "0x50BDB10", VA = "0x1850BEF10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C47")]
			[Address(RVA = "0x50BEF40", Offset = "0x50BDB40", VA = "0x1850BEF40")]
			set
			{
			}
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C48")]
		[Address(RVA = "0x50BED90", Offset = "0x50BD990", VA = "0x1850BED90", Slot = "5")]
		protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
		{
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x0000C300 File Offset: 0x0000A500
		[Token(Token = "0x6001C49")]
		[Address(RVA = "0x50BEDC0", Offset = "0x50BD9C0", VA = "0x1850BEDC0", Slot = "7")]
		protected override bool IsModified()
		{
			return default(bool);
		}

		// Token: 0x06001C4A RID: 7242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C4A")]
		[Address(RVA = "0x50BEE20", Offset = "0x50BDA20", VA = "0x1850BEE20", Slot = "9")]
		protected override void Reset(ConfigurationElement parentElement)
		{
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C4B")]
		[Address(RVA = "0x50BEDF0", Offset = "0x50BD9F0", VA = "0x1850BEDF0", Slot = "10")]
		protected override void ResetModified()
		{
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x0000C318 File Offset: 0x0000A518
		[Token(Token = "0x6001C4C")]
		[Address(RVA = "0x50BEE50", Offset = "0x50BDA50", VA = "0x1850BEE50", Slot = "11")]
		protected override bool SerializeToXmlElement(XmlWriter writer, string elementName)
		{
			return default(bool);
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C4D")]
		[Address(RVA = "0x50BEE80", Offset = "0x50BDA80", VA = "0x1850BEE80", Slot = "12")]
		protected override void Unmerge(ConfigurationElement sourceElement, ConfigurationElement parentElement, ConfigurationSaveMode saveMode)
		{
		}
	}
}
