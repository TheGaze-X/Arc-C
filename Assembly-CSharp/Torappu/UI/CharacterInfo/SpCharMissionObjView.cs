using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005FBF RID: 24511
	[Token(Token = "0x2005FBF")]
	public class SpCharMissionObjView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170053A9 RID: 21417
		// (get) Token: 0x0602373A RID: 145210 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602373B RID: 145211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170053A9")]
		public Action<SpCharMissionObjViewModel> onGetRewardClicked
		{
			[Token(Token = "0x602373A")]
			[Address(RVA = "0x1E26AE0", Offset = "0x1E256E0", VA = "0x181E26AE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602373B")]
			[Address(RVA = "0x1E26B40", Offset = "0x1E25740", VA = "0x181E26B40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602373C RID: 145212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602373C")]
		[Address(RVA = "0x1E262B0", Offset = "0x1E24EB0", VA = "0x181E262B0")]
		public void Render(SpCharMissionObjViewModel viewModel)
		{
		}

		// Token: 0x0602373D RID: 145213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602373D")]
		[Address(RVA = "0x1E261A0", Offset = "0x1E24DA0", VA = "0x181E261A0")]
		public void EventOnGetRewardClicked()
		{
		}

		// Token: 0x0602373E RID: 145214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602373E")]
		[Address(RVA = "0x1E26820", Offset = "0x1E25420", VA = "0x181E26820")]
		private void _EventOnItemClicked(int index)
		{
		}

		// Token: 0x0602373F RID: 145215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602373F")]
		[Address(RVA = "0x1E268F0", Offset = "0x1E254F0", VA = "0x181E268F0")]
		private Sprite _GetSprite(string id)
		{
			return null;
		}

		// Token: 0x06023740 RID: 145216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023740")]
		[Address(RVA = "0x1E26A30", Offset = "0x1E25630", VA = "0x181E26A30")]
		public SpCharMissionObjView()
		{
		}

		// Token: 0x04031066 RID: 200806
		[Token(Token = "0x4031066")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Settings")]
		private List<SpCharMissionObjView.SpriteData> _spriteDatas;

		// Token: 0x04031067 RID: 200807
		[Token(Token = "0x4031067")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Settings")]
		private float _itemCardScale;

		// Token: 0x04031068 RID: 200808
		[Token(Token = "0x4031068")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imageCond;

		// Token: 0x04031069 RID: 200809
		[Token(Token = "0x4031069")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textCond;

		// Token: 0x0403106A RID: 200810
		[Token(Token = "0x403106A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _rewardsContainer;

		// Token: 0x0403106B RID: 200811
		[Token(Token = "0x403106B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _rewardPlaceHolder;

		// Token: 0x0403106C RID: 200812
		[Token(Token = "0x403106C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _panelRewards;

		// Token: 0x0403106D RID: 200813
		[Token(Token = "0x403106D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _panelConfirm;

		// Token: 0x0403106E RID: 200814
		[Token(Token = "0x403106E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _panelComplete;

		// Token: 0x0403106F RID: 200815
		[Token(Token = "0x403106F")]
		[FieldOffset(Offset = "0x60")]
		private SpCharMissionObjViewModel m_cacheModel;

		// Token: 0x04031070 RID: 200816
		[Token(Token = "0x4031070")]
		[FieldOffset(Offset = "0x68")]
		private List<UIItemCard> m_uiItemCards;

		// Token: 0x04031072 RID: 200818
		[Token(Token = "0x4031072")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onGetRewardClicked;

		// Token: 0x04031073 RID: 200819
		[Token(Token = "0x4031073")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onGetRewardClicked;

		// Token: 0x04031074 RID: 200820
		[Token(Token = "0x4031074")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04031075 RID: 200821
		[Token(Token = "0x4031075")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnGetRewardClicked;

		// Token: 0x04031076 RID: 200822
		[Token(Token = "0x4031076")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EventOnItemClicked;

		// Token: 0x04031077 RID: 200823
		[Token(Token = "0x4031077")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetSprite;

		// Token: 0x04031078 RID: 200824
		[Token(Token = "0x4031078")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005FC0 RID: 24512
		[Token(Token = "0x2005FC0")]
		[Serializable]
		private class SpriteData
		{
			// Token: 0x06023741 RID: 145217 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023741")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SpriteData()
			{
			}

			// Token: 0x04031079 RID: 200825
			[Token(Token = "0x4031079")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x0403107A RID: 200826
			[Token(Token = "0x403107A")]
			[FieldOffset(Offset = "0x18")]
			public Sprite sprite;
		}
	}
}
