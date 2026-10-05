using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act3D5
{
	// Token: 0x020073CB RID: 29643
	[Token(Token = "0x20073CB")]
	public class Activity3D5Item : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029DFE RID: 171518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DFE")]
		[Address(RVA = "0x257E550", Offset = "0x257D150", VA = "0x18257E550")]
		public void Refresh(string activityId, ActivityCollectionData.CollectionInfo data, bool reached, bool geted)
		{
		}

		// Token: 0x170062D6 RID: 25302
		// (get) Token: 0x06029DFF RID: 171519 RVA: 0x000D6E00 File Offset: 0x000D5000
		[Token(Token = "0x170062D6")]
		public bool hasGot
		{
			[Token(Token = "0x6029DFF")]
			[Address(RVA = "0x257F260", Offset = "0x257DE60", VA = "0x18257F260")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06029E00 RID: 171520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E00")]
		[Address(RVA = "0x257E200", Offset = "0x257CE00", VA = "0x18257E200")]
		private void OnEnable()
		{
		}

		// Token: 0x06029E01 RID: 171521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E01")]
		[Address(RVA = "0x257E120", Offset = "0x257CD20", VA = "0x18257E120")]
		public void Flash()
		{
		}

		// Token: 0x06029E02 RID: 171522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E02")]
		[Address(RVA = "0x257E2F0", Offset = "0x257CEF0", VA = "0x18257E2F0")]
		public void OnGetReward()
		{
		}

		// Token: 0x06029E03 RID: 171523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029E03")]
		[Address(RVA = "0x257F150", Offset = "0x257DD50", VA = "0x18257F150")]
		private IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList)
		{
			return null;
		}

		// Token: 0x06029E04 RID: 171524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E04")]
		[Address(RVA = "0x257F200", Offset = "0x257DE00", VA = "0x18257F200")]
		public Activity3D5Item()
		{
		}

		// Token: 0x0403C043 RID: 245827
		[Token(Token = "0x403C043")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite _normalBG;

		// Token: 0x0403C044 RID: 245828
		[Token(Token = "0x403C044")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _normalCompleteBG;

		// Token: 0x0403C045 RID: 245829
		[Token(Token = "0x403C045")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _bigCompleteBG;

		// Token: 0x0403C046 RID: 245830
		[Token(Token = "0x403C046")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _bg;

		// Token: 0x0403C047 RID: 245831
		[Token(Token = "0x403C047")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _bigMark;

		// Token: 0x0403C048 RID: 245832
		[Token(Token = "0x403C048")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UITweenFade _bright;

		// Token: 0x0403C049 RID: 245833
		[Token(Token = "0x403C049")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _rewardCnt;

		// Token: 0x0403C04A RID: 245834
		[Token(Token = "0x403C04A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _rewardName;

		// Token: 0x0403C04B RID: 245835
		[Token(Token = "0x403C04B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _rewardIconRoot;

		// Token: 0x0403C04C RID: 245836
		[Token(Token = "0x403C04C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button _getMarkBtn;

		// Token: 0x0403C04D RID: 245837
		[Token(Token = "0x403C04D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button _getBtn;

		// Token: 0x0403C04E RID: 245838
		[Token(Token = "0x403C04E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _needDesc;

		// Token: 0x0403C04F RID: 245839
		[Token(Token = "0x403C04F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _needCount;

		// Token: 0x0403C050 RID: 245840
		[Token(Token = "0x403C050")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIChildrenColorGraphic _colorAlter;

		// Token: 0x0403C051 RID: 245841
		[Token(Token = "0x403C051")]
		[FieldOffset(Offset = "0x88")]
		private string m_activityId;

		// Token: 0x0403C052 RID: 245842
		[Token(Token = "0x403C052")]
		[FieldOffset(Offset = "0x90")]
		private ActivityCollectionData.CollectionInfo m_data;

		// Token: 0x0403C053 RID: 245843
		[Token(Token = "0x403C053")]
		[FieldOffset(Offset = "0x98")]
		private bool m_hasGot;

		// Token: 0x0403C054 RID: 245844
		[Token(Token = "0x403C054")]
		[FieldOffset(Offset = "0xA0")]
		private UIItemCard m_itemCell;

		// Token: 0x0403C055 RID: 245845
		[Token(Token = "0x403C055")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Refresh;

		// Token: 0x0403C056 RID: 245846
		[Token(Token = "0x403C056")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_hasGot;

		// Token: 0x0403C057 RID: 245847
		[Token(Token = "0x403C057")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0403C058 RID: 245848
		[Token(Token = "0x403C058")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Flash;

		// Token: 0x0403C059 RID: 245849
		[Token(Token = "0x403C059")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnGetReward;

		// Token: 0x0403C05A RID: 245850
		[Token(Token = "0x403C05A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x0403C05B RID: 245851
		[Token(Token = "0x403C05B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
