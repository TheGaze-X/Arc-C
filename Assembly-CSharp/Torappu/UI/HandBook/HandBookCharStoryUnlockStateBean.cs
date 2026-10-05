using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.CharacterInfo;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006676 RID: 26230
	[Token(Token = "0x2006676")]
	public class HandBookCharStoryUnlockStateBean : MonoBehaviour, IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x1700593C RID: 22844
		// (get) Token: 0x06025A92 RID: 154258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700593C")]
		public string storyTitle
		{
			[Token(Token = "0x6025A92")]
			[Address(RVA = "0x2091DC0", Offset = "0x20909C0", VA = "0x182091DC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700593D RID: 22845
		// (get) Token: 0x06025A93 RID: 154259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700593D")]
		public string charName
		{
			[Token(Token = "0x6025A93")]
			[Address(RVA = "0x2091D00", Offset = "0x2090900", VA = "0x182091D00")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700593E RID: 22846
		// (get) Token: 0x06025A94 RID: 154260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700593E")]
		public List<UIItemViewModel> itemList
		{
			[Token(Token = "0x6025A94")]
			[Address(RVA = "0x2091D60", Offset = "0x2090960", VA = "0x182091D60")]
			get
			{
				return null;
			}
		}

		// Token: 0x06025A95 RID: 154261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A95")]
		[Address(RVA = "0x20918A0", Offset = "0x20904A0", VA = "0x1820918A0")]
		public void LoadData(string charId, string storyTitle, List<ItemBundle> itemModels)
		{
		}

		// Token: 0x06025A96 RID: 154262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A96")]
		[Address(RVA = "0x2091C60", Offset = "0x2090860", VA = "0x182091C60")]
		public HandBookCharStoryUnlockStateBean()
		{
		}

		// Token: 0x04034E78 RID: 216696
		[Token(Token = "0x4034E78")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CharacterIllustViewProperty _charIllustProperty;

		// Token: 0x04034E79 RID: 216697
		[Token(Token = "0x4034E79")]
		[FieldOffset(Offset = "0x20")]
		private string m_storyTitle;

		// Token: 0x04034E7A RID: 216698
		[Token(Token = "0x4034E7A")]
		[FieldOffset(Offset = "0x28")]
		private string m_charName;

		// Token: 0x04034E7B RID: 216699
		[Token(Token = "0x4034E7B")]
		[FieldOffset(Offset = "0x30")]
		private List<UIItemViewModel> m_itemList;

		// Token: 0x04034E7C RID: 216700
		[Token(Token = "0x4034E7C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_storyTitle;

		// Token: 0x04034E7D RID: 216701
		[Token(Token = "0x4034E7D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_charName;

		// Token: 0x04034E7E RID: 216702
		[Token(Token = "0x4034E7E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_itemList;

		// Token: 0x04034E7F RID: 216703
		[Token(Token = "0x4034E7F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04034E80 RID: 216704
		[Token(Token = "0x4034E80")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
