using System;
using System.Xml;
using Il2CppDummyDll;

namespace System.Configuration
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public abstract class ConfigurationSection : ConfigurationElement
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x4F1AE40", Offset = "0x4F19A40", VA = "0x184F1AE40", Slot = "13")]
		protected internal virtual void DeserializeSection(XmlReader reader)
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002088 File Offset: 0x00000288
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x4F1AE70", Offset = "0x4F19A70", VA = "0x184F1AE70", Slot = "7")]
		protected internal override bool IsModified()
		{
			return default(bool);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x4F1AEA0", Offset = "0x4F19AA0", VA = "0x184F1AEA0", Slot = "10")]
		protected internal override void ResetModified()
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x4F1AED0", Offset = "0x4F19AD0", VA = "0x184F1AED0", Slot = "14")]
		protected internal virtual string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode)
		{
			return null;
		}
	}
}
