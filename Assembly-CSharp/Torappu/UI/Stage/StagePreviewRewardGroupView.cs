using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006934 RID: 26932
	[Token(Token = "0x2006934")]
	public class StagePreviewRewardGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005B13 RID: 23315
		// (get) Token: 0x0602691B RID: 157979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B13")]
		public List<StageDropType> dropTypeList
		{
			[Token(Token = "0x602691B")]
			[Address(RVA = "0x21B5540", Offset = "0x21B4140", VA = "0x1821B5540")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602691C RID: 157980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602691C")]
		[Address(RVA = "0x21B4C50", Offset = "0x21B3850", VA = "0x1821B4C50")]
		public void Render(Dictionary<StageDropType, List<StageRewardDetailViewModel>> viewModelDict, List<KeyValuePair<string, StageRewardDetailViewModel>> timelyReward, OverrideDropInfo overrideDropInfo, bool getFlag = false, bool completeFlag = false)
		{
		}

		// Token: 0x0602691D RID: 157981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602691D")]
		[Address(RVA = "0x21B5320", Offset = "0x21B3F20", VA = "0x1821B5320")]
		private IEnumerator _UpdateLayoutCoroutine()
		{
			return null;
		}

		// Token: 0x0602691E RID: 157982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602691E")]
		[Address(RVA = "0x21B53D0", Offset = "0x21B3FD0", VA = "0x1821B53D0")]
		public StagePreviewRewardGroupView()
		{
		}

		// Token: 0x0403666F RID: 222831
		[Token(Token = "0x403666F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private StagePreviewRewardItemView _itemView;

		// Token: 0x04036670 RID: 222832
		[Token(Token = "0x4036670")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x04036671 RID: 222833
		[Token(Token = "0x4036671")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _longPart;

		// Token: 0x04036672 RID: 222834
		[Token(Token = "0x4036672")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _littlePart;

		// Token: 0x04036673 RID: 222835
		[Token(Token = "0x4036673")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private StageDropType _dropType;

		// Token: 0x04036674 RID: 222836
		[Token(Token = "0x4036674")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GridLayoutGroup _layOutGroup;

		// Token: 0x04036675 RID: 222837
		[Token(Token = "0x4036675")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private StagePreviewRewardGroupViewPlugin _plugin;

		// Token: 0x04036676 RID: 222838
		[Token(Token = "0x4036676")]
		[FieldOffset(Offset = "0x50")]
		private List<StagePreviewRewardItemView> m_viewList;

		// Token: 0x04036677 RID: 222839
		[Token(Token = "0x4036677")]
		[FieldOffset(Offset = "0x58")]
		private List<StageDropType> m_dropTypeList;

		// Token: 0x04036678 RID: 222840
		[Token(Token = "0x4036678")]
		[FieldOffset(Offset = "0x60")]
		public List<ItemType> hideTimelyDrop;

		// Token: 0x04036679 RID: 222841
		[Token(Token = "0x4036679")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dropTypeList;

		// Token: 0x0403667A RID: 222842
		[Token(Token = "0x403667A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403667B RID: 222843
		[Token(Token = "0x403667B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateLayoutCoroutine;

		// Token: 0x0403667C RID: 222844
		[Token(Token = "0x403667C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
