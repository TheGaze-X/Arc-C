using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200026E RID: 622
	[Token(Token = "0x200026E")]
	[Serializable]
	internal class TemplateAsset : VisualElementAsset
	{
		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x0600117A RID: 4474 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700046A")]
		public List<TemplateAsset.AttributeOverride> attributeOverrides
		{
			[Token(Token = "0x600117A")]
			[Address(RVA = "0x5B266A0", Offset = "0x5B252A0", VA = "0x185B266A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x0600117B RID: 4475 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700046B")]
		internal List<VisualTreeAsset.SlotUsageEntry> slotUsages
		{
			[Token(Token = "0x600117B")]
			[Address(RVA = "0x5997750", Offset = "0x5996350", VA = "0x185997750")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000912 RID: 2322
		[Token(Token = "0x4000912")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string m_TemplateAlias;

		// Token: 0x04000913 RID: 2323
		[Token(Token = "0x4000913")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<TemplateAsset.AttributeOverride> m_AttributeOverrides;

		// Token: 0x04000914 RID: 2324
		[Token(Token = "0x4000914")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private List<VisualTreeAsset.SlotUsageEntry> m_SlotUsages;

		// Token: 0x0200026F RID: 623
		[Token(Token = "0x200026F")]
		[Serializable]
		public struct AttributeOverride
		{
			// Token: 0x04000915 RID: 2325
			[Token(Token = "0x4000915")]
			[FieldOffset(Offset = "0x0")]
			public string m_ElementName;

			// Token: 0x04000916 RID: 2326
			[Token(Token = "0x4000916")]
			[FieldOffset(Offset = "0x8")]
			public string m_AttributeName;

			// Token: 0x04000917 RID: 2327
			[Token(Token = "0x4000917")]
			[FieldOffset(Offset = "0x10")]
			public string m_Value;
		}
	}
}
