using System;
using Il2CppDummyDll;

namespace System.Configuration
{
	// Token: 0x02000431 RID: 1073
	[Token(Token = "0x2000431")]
	[ConfigurationCollection(typeof(SchemeSettingElement), CollectionType = 1, AddItemName = "add", ClearItemsName = "clear", RemoveItemName = "remove")]
	public sealed class SchemeSettingElementCollection : ConfigurationElementCollection
	{
		// Token: 0x06001C85 RID: 7301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C85")]
		[Address(RVA = "0x50BE3D0", Offset = "0x50BCFD0", VA = "0x1850BE3D0")]
		public SchemeSettingElementCollection()
		{
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06001C86 RID: 7302 RVA: 0x0000C3A8 File Offset: 0x0000A5A8
		[Token(Token = "0x17000696")]
		public override ConfigurationElementCollectionType CollectionType
		{
			[Token(Token = "0x6001C86")]
			[Address(RVA = "0x50BE400", Offset = "0x50BD000", VA = "0x1850BE400", Slot = "13")]
			get
			{
				return ConfigurationElementCollectionType.BasicMap;
			}
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C87")]
		[Address(RVA = "0x50BE460", Offset = "0x50BD060", VA = "0x1850BE460")]
		public SchemeSettingElement get_Item(int index)
		{
			return null;
		}

		// Token: 0x17000697 RID: 1687
		[Token(Token = "0x17000697")]
		public SchemeSettingElement this[string name]
		{
			[Token(Token = "0x6001C88")]
			[Address(RVA = "0x50BE430", Offset = "0x50BD030", VA = "0x1850BE430")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C89")]
		[Address(RVA = "0x50BE340", Offset = "0x50BCF40", VA = "0x1850BE340", Slot = "16")]
		protected override ConfigurationElement CreateNewElement()
		{
			return null;
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C8A")]
		[Address(RVA = "0x50BE370", Offset = "0x50BCF70", VA = "0x1850BE370", Slot = "17")]
		protected override object GetElementKey(ConfigurationElement element)
		{
			return null;
		}

		// Token: 0x06001C8B RID: 7307 RVA: 0x0000C3C0 File Offset: 0x0000A5C0
		[Token(Token = "0x6001C8B")]
		[Address(RVA = "0x50BE3A0", Offset = "0x50BCFA0", VA = "0x1850BE3A0")]
		public int IndexOf(SchemeSettingElement element)
		{
			return 0;
		}
	}
}
