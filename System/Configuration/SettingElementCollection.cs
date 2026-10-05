using System;
using Il2CppDummyDll;

namespace System.Configuration
{
	// Token: 0x0200041F RID: 1055
	[Token(Token = "0x200041F")]
	public sealed class SettingElementCollection : ConfigurationElementCollection
	{
		// Token: 0x06001C32 RID: 7218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C32")]
		[Address(RVA = "0x50BEB50", Offset = "0x50BD750", VA = "0x1850BEB50")]
		public SettingElementCollection()
		{
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06001C33 RID: 7219 RVA: 0x0000C2D0 File Offset: 0x0000A4D0
		[Token(Token = "0x1700067C")]
		public override ConfigurationElementCollectionType CollectionType
		{
			[Token(Token = "0x6001C33")]
			[Address(RVA = "0x50BEB80", Offset = "0x50BD780", VA = "0x1850BEB80", Slot = "13")]
			get
			{
				return ConfigurationElementCollectionType.BasicMap;
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001C34 RID: 7220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700067D")]
		protected override string ElementName
		{
			[Token(Token = "0x6001C34")]
			[Address(RVA = "0x50BEBB0", Offset = "0x50BD7B0", VA = "0x1850BEBB0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C35")]
		[Address(RVA = "0x50BEA30", Offset = "0x50BD630", VA = "0x1850BEA30")]
		public void Add(SettingElement element)
		{
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C36")]
		[Address(RVA = "0x50BEA60", Offset = "0x50BD660", VA = "0x1850BEA60")]
		public void Clear()
		{
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C37")]
		[Address(RVA = "0x50BEA90", Offset = "0x50BD690", VA = "0x1850BEA90", Slot = "16")]
		protected override ConfigurationElement CreateNewElement()
		{
			return null;
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C38")]
		[Address(RVA = "0x50BEAF0", Offset = "0x50BD6F0", VA = "0x1850BEAF0")]
		public SettingElement Get(string elementKey)
		{
			return null;
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C39")]
		[Address(RVA = "0x50BEAC0", Offset = "0x50BD6C0", VA = "0x1850BEAC0", Slot = "17")]
		protected override object GetElementKey(ConfigurationElement element)
		{
			return null;
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C3A")]
		[Address(RVA = "0x50BEB20", Offset = "0x50BD720", VA = "0x1850BEB20")]
		public void Remove(SettingElement element)
		{
		}
	}
}
