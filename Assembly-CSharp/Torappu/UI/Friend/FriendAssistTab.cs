using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DA5 RID: 19877
	[Token(Token = "0x2004DA5")]
	public class FriendAssistTab : MonoBehaviour, IHotfixable
	{
		// Token: 0x170045AF RID: 17839
		// (get) Token: 0x0601DBA6 RID: 121766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170045AF")]
		public FriendAssistCharData assistCharData
		{
			[Token(Token = "0x601DBA6")]
			[Address(RVA = "0x173E860", Offset = "0x173D460", VA = "0x18173E860")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601DBA7 RID: 121767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBA7")]
		[Address(RVA = "0x173E410", Offset = "0x173D010", VA = "0x18173E410")]
		public void OnTabClick()
		{
		}

		// Token: 0x0601DBA8 RID: 121768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBA8")]
		[Address(RVA = "0x173E520", Offset = "0x173D120", VA = "0x18173E520")]
		public void SetLock()
		{
		}

		// Token: 0x0601DBA9 RID: 121769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBA9")]
		[Address(RVA = "0x173E490", Offset = "0x173D090", VA = "0x18173E490")]
		public void ResetData(int index)
		{
		}

		// Token: 0x0601DBAA RID: 121770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBAA")]
		[Address(RVA = "0x173DEB0", Offset = "0x173CAB0", VA = "0x18173DEB0")]
		public void ApplyData(FriendAssistCharData assistCharData)
		{
		}

		// Token: 0x0601DBAB RID: 121771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBAB")]
		[Address(RVA = "0x173DAB0", Offset = "0x173C6B0", VA = "0x18173DAB0")]
		public void ApplyData(SharedCharData cardData, bool isSkillLimited)
		{
		}

		// Token: 0x0601DBAC RID: 121772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBAC")]
		[Address(RVA = "0x173E5A0", Offset = "0x173D1A0", VA = "0x18173E5A0")]
		public void _InitData()
		{
		}

		// Token: 0x0601DBAD RID: 121773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBAD")]
		[Address(RVA = "0x173E720", Offset = "0x173D320", VA = "0x18173E720")]
		private void _OnClick(string id, FriendAssistItemFloatPanel.ItemType itemType)
		{
		}

		// Token: 0x0601DBAE RID: 121774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBAE")]
		[Address(RVA = "0x173E800", Offset = "0x173D400", VA = "0x18173E800")]
		public FriendAssistTab()
		{
		}

		// Token: 0x040274F1 RID: 161009
		[Token(Token = "0x40274F1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _specMaxPart;

		// Token: 0x040274F2 RID: 161010
		[Token(Token = "0x40274F2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _levelText;

		// Token: 0x040274F3 RID: 161011
		[Token(Token = "0x40274F3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _characterIcon;

		// Token: 0x040274F4 RID: 161012
		[Token(Token = "0x40274F4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _eliteImage;

		// Token: 0x040274F5 RID: 161013
		[Token(Token = "0x40274F5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _potentialImage;

		// Token: 0x040274F6 RID: 161014
		[Token(Token = "0x40274F6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ThreeStateToggle _backStage;

		// Token: 0x040274F7 RID: 161015
		[Token(Token = "0x40274F7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _limitPart;

		// Token: 0x040274F8 RID: 161016
		[Token(Token = "0x40274F8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _limitText;

		// Token: 0x040274F9 RID: 161017
		[Token(Token = "0x40274F9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private FriendAssistSkillItem _selectedSkillIcon;

		// Token: 0x040274FA RID: 161018
		[Token(Token = "0x40274FA")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private FriendAssistEquipItem _selectedEquipIcon;

		// Token: 0x040274FB RID: 161019
		[Token(Token = "0x40274FB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _reselectIcon;

		// Token: 0x040274FC RID: 161020
		[Token(Token = "0x40274FC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIScaler _scaler;

		// Token: 0x040274FD RID: 161021
		[Token(Token = "0x40274FD")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public Action<int, string, GameObject, FriendAssistItemFloatPanel.ItemType> onItemClicked;

		// Token: 0x040274FE RID: 161022
		[Token(Token = "0x40274FE")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		public Action<int> onTabClicked;

		// Token: 0x040274FF RID: 161023
		[Token(Token = "0x40274FF")]
		[FieldOffset(Offset = "0x88")]
		private FriendAssistCharData m_cachedAssistCharData;

		// Token: 0x04027500 RID: 161024
		[Token(Token = "0x4027500")]
		[FieldOffset(Offset = "0x90")]
		private int m_index;

		// Token: 0x04027501 RID: 161025
		[Token(Token = "0x4027501")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_assistCharData;

		// Token: 0x04027502 RID: 161026
		[Token(Token = "0x4027502")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTabClick;

		// Token: 0x04027503 RID: 161027
		[Token(Token = "0x4027503")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetLock;

		// Token: 0x04027504 RID: 161028
		[Token(Token = "0x4027504")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ResetData;

		// Token: 0x04027505 RID: 161029
		[Token(Token = "0x4027505")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x04027506 RID: 161030
		[Token(Token = "0x4027506")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix1_ApplyData;

		// Token: 0x04027507 RID: 161031
		[Token(Token = "0x4027507")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitData;

		// Token: 0x04027508 RID: 161032
		[Token(Token = "0x4027508")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnClick;

		// Token: 0x04027509 RID: 161033
		[Token(Token = "0x4027509")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
