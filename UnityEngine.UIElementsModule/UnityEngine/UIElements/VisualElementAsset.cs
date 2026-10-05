using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000285 RID: 645
	[Token(Token = "0x2000285")]
	[Serializable]
	internal class VisualElementAsset : IUxmlAttributes, ISerializationCallbackReceiver
	{
		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x060011C7 RID: 4551 RVA: 0x00009A08 File Offset: 0x00007C08
		[Token(Token = "0x17000479")]
		public int id
		{
			[Token(Token = "0x60011C7")]
			[Address(RVA = "0x428FB90", Offset = "0x428E790", VA = "0x18428FB90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x060011C8 RID: 4552 RVA: 0x00009A20 File Offset: 0x00007C20
		[Token(Token = "0x1700047A")]
		public int orderInDocument
		{
			[Token(Token = "0x60011C8")]
			[Address(RVA = "0x3E76340", Offset = "0x3E74F40", VA = "0x183E76340")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x060011C9 RID: 4553 RVA: 0x00009A38 File Offset: 0x00007C38
		[Token(Token = "0x1700047B")]
		public int parentId
		{
			[Token(Token = "0x60011C9")]
			[Address(RVA = "0x5958CC0", Offset = "0x59578C0", VA = "0x185958CC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x060011CA RID: 4554 RVA: 0x00009A50 File Offset: 0x00007C50
		[Token(Token = "0x1700047C")]
		public int ruleIndex
		{
			[Token(Token = "0x60011CA")]
			[Address(RVA = "0x59BA3B0", Offset = "0x59B8FB0", VA = "0x1859BA3B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x060011CB RID: 4555 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700047D")]
		public string fullTypeName
		{
			[Token(Token = "0x60011CB")]
			[Address(RVA = "0x59976A0", Offset = "0x59962A0", VA = "0x1859976A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x060011CC RID: 4556 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700047E")]
		public string[] classes
		{
			[Token(Token = "0x60011CC")]
			[Address(RVA = "0x59976F0", Offset = "0x59962F0", VA = "0x1859976F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x060011CD RID: 4557 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700047F")]
		public List<string> stylesheetPaths
		{
			[Token(Token = "0x60011CD")]
			[Address(RVA = "0x5B2F770", Offset = "0x5B2E370", VA = "0x185B2F770")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x060011CE RID: 4558 RVA: 0x00009A68 File Offset: 0x00007C68
		[Token(Token = "0x17000480")]
		public bool hasStylesheetPaths
		{
			[Token(Token = "0x60011CE")]
			[Address(RVA = "0x1FF9060", Offset = "0x1FF7C60", VA = "0x181FF9060")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x060011CF RID: 4559 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000481")]
		public List<StyleSheet> stylesheets
		{
			[Token(Token = "0x60011CF")]
			[Address(RVA = "0x5B2F800", Offset = "0x5B2E400", VA = "0x185B2F800")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x060011D0 RID: 4560 RVA: 0x00009A80 File Offset: 0x00007C80
		[Token(Token = "0x17000482")]
		public bool hasStylesheets
		{
			[Token(Token = "0x60011D0")]
			[Address(RVA = "0x1FF9040", Offset = "0x1FF7C40", VA = "0x181FF9040")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x060011D1 RID: 4561 RVA: 0x00009A98 File Offset: 0x00007C98
		[Token(Token = "0x17000483")]
		internal bool skipClone
		{
			[Token(Token = "0x60011D1")]
			[Address(RVA = "0x6DF210", Offset = "0x6DDE10", VA = "0x1806DF210")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011D2")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		public void OnBeforeSerialize()
		{
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011D3")]
		[Address(RVA = "0x5B2F4E0", Offset = "0x5B2E0E0", VA = "0x185B2F4E0", Slot = "6")]
		public void OnAfterDeserialize()
		{
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011D4")]
		[Address(RVA = "0x5B2F370", Offset = "0x5B2DF70", VA = "0x185B2F370")]
		public void AddProperty(string propertyName, string propertyValue)
		{
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011D5")]
		[Address(RVA = "0x5B2F370", Offset = "0x5B2DF70", VA = "0x185B2F370")]
		private void SetOrAddProperty(string propertyName, string propertyValue)
		{
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x00009AB0 File Offset: 0x00007CB0
		[Token(Token = "0x60011D6")]
		[Address(RVA = "0x5B2F670", Offset = "0x5B2E270", VA = "0x185B2F670", Slot = "4")]
		public bool TryGetAttributeValue(string propertyName, out string value)
		{
			return default(bool);
		}

		// Token: 0x04000936 RID: 2358
		[Token(Token = "0x4000936")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string m_Name;

		// Token: 0x04000937 RID: 2359
		[Token(Token = "0x4000937")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int m_Id;

		// Token: 0x04000938 RID: 2360
		[Token(Token = "0x4000938")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int m_OrderInDocument;

		// Token: 0x04000939 RID: 2361
		[Token(Token = "0x4000939")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int m_ParentId;

		// Token: 0x0400093A RID: 2362
		[Token(Token = "0x400093A")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int m_RuleIndex;

		// Token: 0x0400093B RID: 2363
		[Token(Token = "0x400093B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string m_Text;

		// Token: 0x0400093C RID: 2364
		[Token(Token = "0x400093C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private PickingMode m_PickingMode;

		// Token: 0x0400093D RID: 2365
		[Token(Token = "0x400093D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string m_FullTypeName;

		// Token: 0x0400093E RID: 2366
		[Token(Token = "0x400093E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string[] m_Classes;

		// Token: 0x0400093F RID: 2367
		[Token(Token = "0x400093F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<string> m_StylesheetPaths;

		// Token: 0x04000940 RID: 2368
		[Token(Token = "0x4000940")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<StyleSheet> m_Stylesheets;

		// Token: 0x04000941 RID: 2369
		[Token(Token = "0x4000941")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool m_SkipClone;

		// Token: 0x04000942 RID: 2370
		[Token(Token = "0x4000942")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<string> m_Properties;
	}
}
