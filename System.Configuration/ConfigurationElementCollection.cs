using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace System.Configuration
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	[DebuggerDisplay("Count = {Count}")]
	public abstract class ConfigurationElementCollection : ConfigurationElement
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000020A0 File Offset: 0x000002A0
		[Token(Token = "0x17000002")]
		public virtual ConfigurationElementCollectionType CollectionType
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x4F1AC00", Offset = "0x4F19800", VA = "0x184F1AC00", Slot = "13")]
			get
			{
				return ConfigurationElementCollectionType.BasicMap;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000003")]
		protected virtual string ElementName
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x4F1AC30", Offset = "0x4F19830", VA = "0x184F1AC30", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000011 RID: 17 RVA: 0x000020B8 File Offset: 0x000002B8
		[Token(Token = "0x17000004")]
		protected virtual bool ThrowOnDuplicate
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x4F1AC60", Offset = "0x4F19860", VA = "0x184F1AC60", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000012 RID: 18
		[Token(Token = "0x6000012")]
		protected abstract ConfigurationElement CreateNewElement();

		// Token: 0x06000013 RID: 19
		[Token(Token = "0x6000013")]
		protected abstract object GetElementKey(ConfigurationElement element);
	}
}
