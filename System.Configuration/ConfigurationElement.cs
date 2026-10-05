using System;
using System.Reflection;
using System.Xml;
using Il2CppDummyDll;

namespace System.Configuration
{
	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	[DefaultMember("Item")]
	public abstract class ConfigurationElement
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000001")]
		protected internal virtual ConfigurationPropertyCollection Properties
		{
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x4F1AE10", Offset = "0x4F19A10", VA = "0x184F1AE10", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x4F1AC90", Offset = "0x4F19890", VA = "0x184F1AC90", Slot = "5")]
		protected internal virtual void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x4F1ACC0", Offset = "0x4F198C0", VA = "0x184F1ACC0", Slot = "6")]
		protected internal virtual void InitializeDefault()
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002058 File Offset: 0x00000258
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x4F1ACF0", Offset = "0x4F198F0", VA = "0x184F1ACF0", Slot = "7")]
		protected internal virtual bool IsModified()
		{
			return default(bool);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x4F1AD20", Offset = "0x4F19920", VA = "0x184F1AD20", Slot = "8")]
		protected virtual void PostDeserialize()
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x4F1AD80", Offset = "0x4F19980", VA = "0x184F1AD80", Slot = "9")]
		protected internal virtual void Reset(ConfigurationElement parentElement)
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x4F1AD50", Offset = "0x4F19950", VA = "0x184F1AD50", Slot = "10")]
		protected internal virtual void ResetModified()
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002070 File Offset: 0x00000270
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x4F1ADB0", Offset = "0x4F199B0", VA = "0x184F1ADB0", Slot = "11")]
		protected internal virtual bool SerializeToXmlElement(XmlWriter writer, string elementName)
		{
			return default(bool);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x4F1ADE0", Offset = "0x4F199E0", VA = "0x184F1ADE0", Slot = "12")]
		protected internal virtual void Unmerge(ConfigurationElement sourceElement, ConfigurationElement parentElement, ConfigurationSaveMode saveMode)
		{
		}
	}
}
