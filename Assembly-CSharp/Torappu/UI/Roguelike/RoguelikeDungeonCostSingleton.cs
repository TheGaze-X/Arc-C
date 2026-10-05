using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005259 RID: 21081
	[Token(Token = "0x2005259")]
	public class RoguelikeDungeonCostSingleton : PageSingleComponent
	{
		// Token: 0x0601F177 RID: 127351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F177")]
		[Address(RVA = "0x18CA610", Offset = "0x18C9210", VA = "0x1818CA610")]
		public void HandleOnOpenCost(RoguelikeDungeonCostSingleton.Config config, [Optional] string prefabPath)
		{
		}

		// Token: 0x0601F178 RID: 127352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F178")]
		[Address(RVA = "0x18CA740", Offset = "0x18C9340", VA = "0x1818CA740")]
		private RoguelikeDungeonCostBasePanel _EnsurePanelInstance(UIPage page, string topicId, string prefabPath)
		{
			return null;
		}

		// Token: 0x0601F179 RID: 127353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F179")]
		[Address(RVA = "0x18CA910", Offset = "0x18C9510", VA = "0x1818CA910")]
		public RoguelikeDungeonCostSingleton()
		{
		}

		// Token: 0x04029B54 RID: 170836
		[Token(Token = "0x4029B54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04029B55 RID: 170837
		[Token(Token = "0x4029B55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RoguelikeDungeonCostBasePanel m_basePanel;

		// Token: 0x04029B56 RID: 170838
		[Token(Token = "0x4029B56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string m_cacheTopicId;

		// Token: 0x04029B57 RID: 170839
		[Token(Token = "0x4029B57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string m_cachePrefabPath;

		// Token: 0x04029B58 RID: 170840
		[Token(Token = "0x4029B58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleOnOpenCost;

		// Token: 0x04029B59 RID: 170841
		[Token(Token = "0x4029B59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EnsurePanelInstance;

		// Token: 0x04029B5A RID: 170842
		[Token(Token = "0x4029B5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200525A RID: 21082
		[Token(Token = "0x200525A")]
		public class Config
		{
			// Token: 0x0601F17A RID: 127354 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F17A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Config()
			{
			}

			// Token: 0x04029B5B RID: 170843
			[Token(Token = "0x4029B5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string topicId;

			// Token: 0x04029B5C RID: 170844
			[Token(Token = "0x4029B5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string itemId;

			// Token: 0x04029B5D RID: 170845
			[Token(Token = "0x4029B5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int needCount;

			// Token: 0x04029B5E RID: 170846
			[Token(Token = "0x4029B5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string checkText;

			// Token: 0x04029B5F RID: 170847
			[Token(Token = "0x4029B5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string tips;

			// Token: 0x04029B60 RID: 170848
			[Token(Token = "0x4029B60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action onCancel;

			// Token: 0x04029B61 RID: 170849
			[Token(Token = "0x4029B61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Action onAccept;

			// Token: 0x04029B62 RID: 170850
			[Token(Token = "0x4029B62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Color themeColor;

			// Token: 0x04029B63 RID: 170851
			[Token(Token = "0x4029B63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public bool useItemIcon;
		}
	}
}
