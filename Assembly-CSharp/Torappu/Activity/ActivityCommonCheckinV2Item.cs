using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006DAF RID: 28079
	[Token(Token = "0x2006DAF")]
	public class ActivityCommonCheckinV2Item : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027FD4 RID: 163796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FD4")]
		[Address(RVA = "0x2339310", Offset = "0x2337F10", VA = "0x182339310")]
		public void RenderItemView(ActivityCommonCheckinV2Item.ItemConfigGroup configGroup, int order, DefaultCheckInData.CheckInDailyInfo dailyInfo, bool hasInfoFlag, bool canReceiveFlag = false, bool lastTargetFlag = false)
		{
		}

		// Token: 0x06027FD5 RID: 163797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FD5")]
		[Address(RVA = "0x2339D40", Offset = "0x2338940", VA = "0x182339D40")]
		private void _RenderCardSubObjList(int order, List<ItemBundle> itemList, bool isClickable)
		{
		}

		// Token: 0x06027FD6 RID: 163798 RVA: 0x000D0458 File Offset: 0x000CE658
		[Token(Token = "0x6027FD6")]
		[Address(RVA = "0x2339C00", Offset = "0x2338800", VA = "0x182339C00")]
		private ActivityCheckinCardSubObjListTool.ItemObjConfig _GetItemObjConfig(int count)
		{
			return default(ActivityCheckinCardSubObjListTool.ItemObjConfig);
		}

		// Token: 0x06027FD7 RID: 163799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FD7")]
		[Address(RVA = "0x2339280", Offset = "0x2337E80", VA = "0x182339280")]
		public void OnReceive()
		{
		}

		// Token: 0x06027FD8 RID: 163800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FD8")]
		[Address(RVA = "0x233A1A0", Offset = "0x2338DA0", VA = "0x18233A1A0")]
		public ActivityCommonCheckinV2Item()
		{
		}

		// Token: 0x04038AE4 RID: 232164
		[Token(Token = "0x4038AE4")]
		private const string ANIMATOR_PARAM = "fadein";

		// Token: 0x04038AE5 RID: 232165
		[Token(Token = "0x4038AE5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _orderIndex;

		// Token: 0x04038AE6 RID: 232166
		[Token(Token = "0x4038AE6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _normalShadow;

		// Token: 0x04038AE7 RID: 232167
		[Token(Token = "0x4038AE7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _normalBg;

		// Token: 0x04038AE8 RID: 232168
		[Token(Token = "0x4038AE8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _subItemListContainer;

		// Token: 0x04038AE9 RID: 232169
		[Token(Token = "0x4038AE9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Acceptable Image")]
		private Image _acceptableLight;

		// Token: 0x04038AEA RID: 232170
		[Token(Token = "0x4038AEA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Acceptable Image")]
		private Image _acceptableBg;

		// Token: 0x04038AEB RID: 232171
		[Token(Token = "0x4038AEB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _logoImg;

		// Token: 0x04038AEC RID: 232172
		[Token(Token = "0x4038AEC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Reward Image")]
		private Image _rewardDot;

		// Token: 0x04038AED RID: 232173
		[Token(Token = "0x4038AED")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Reward Image")]
		private Image _rewardAcceptableMask;

		// Token: 0x04038AEE RID: 232174
		[Token(Token = "0x4038AEE")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _decImg;

		// Token: 0x04038AEF RID: 232175
		[Token(Token = "0x4038AEF")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Acceptable Image")]
		private Image _decorImg;

		// Token: 0x04038AF0 RID: 232176
		[Token(Token = "0x4038AF0")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Reward Image")]
		private Image _rewardAcceptableDot;

		// Token: 0x04038AF1 RID: 232177
		[Token(Token = "0x4038AF1")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _hotSpot;

		// Token: 0x04038AF2 RID: 232178
		[Token(Token = "0x4038AF2")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private ActivityCheckinCardSubObjListTool.ItemObjConfig[] _cardSubObjConfigs;

		// Token: 0x04038AF3 RID: 232179
		[Token(Token = "0x4038AF3")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Acceptable Image")]
		private Image _arrowImg;

		// Token: 0x04038AF4 RID: 232180
		[Token(Token = "0x4038AF4")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Already Get Image")]
		private Image _alreadyGetMask;

		// Token: 0x04038AF5 RID: 232181
		[Token(Token = "0x4038AF5")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Already Get Image")]
		private Image _alreadyGetImg;

		// Token: 0x04038AF6 RID: 232182
		[Token(Token = "0x4038AF6")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Already Get Image")]
		private Image _alreadyGetLabel;

		// Token: 0x04038AF7 RID: 232183
		[Token(Token = "0x4038AF7")]
		[FieldOffset(Offset = "0xA8")]
		[NonSerialized]
		public UIIntEvent clickEvent;

		// Token: 0x04038AF8 RID: 232184
		[Token(Token = "0x4038AF8")]
		[FieldOffset(Offset = "0xB0")]
		private int m_order;

		// Token: 0x04038AF9 RID: 232185
		[Token(Token = "0x4038AF9")]
		[FieldOffset(Offset = "0xB4")]
		private bool m_isClickable;

		// Token: 0x04038AFA RID: 232186
		[Token(Token = "0x4038AFA")]
		[FieldOffset(Offset = "0xB8")]
		private ActivityCheckinCardSubObjListTool m_activityCheckinCardSubObjListTool;

		// Token: 0x04038AFB RID: 232187
		[Token(Token = "0x4038AFB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderItemView;

		// Token: 0x04038AFC RID: 232188
		[Token(Token = "0x4038AFC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderCardSubObjList;

		// Token: 0x04038AFD RID: 232189
		[Token(Token = "0x4038AFD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetItemObjConfig;

		// Token: 0x04038AFE RID: 232190
		[Token(Token = "0x4038AFE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnReceive;

		// Token: 0x04038AFF RID: 232191
		[Token(Token = "0x4038AFF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006DB0 RID: 28080
		[Token(Token = "0x2006DB0")]
		public struct ItemConfigGroup
		{
			// Token: 0x04038B00 RID: 232192
			[Token(Token = "0x4038B00")]
			[FieldOffset(Offset = "0x0")]
			public Color mainColor;

			// Token: 0x04038B01 RID: 232193
			[Token(Token = "0x4038B01")]
			[FieldOffset(Offset = "0x10")]
			public Color logoColor;

			// Token: 0x04038B02 RID: 232194
			[Token(Token = "0x4038B02")]
			[FieldOffset(Offset = "0x20")]
			public Color acceptableLogoColor;

			// Token: 0x04038B03 RID: 232195
			[Token(Token = "0x4038B03")]
			[FieldOffset(Offset = "0x30")]
			public Color maskColor;

			// Token: 0x04038B04 RID: 232196
			[Token(Token = "0x4038B04")]
			[FieldOffset(Offset = "0x40")]
			public Color rewardBgColor;

			// Token: 0x04038B05 RID: 232197
			[Token(Token = "0x4038B05")]
			[FieldOffset(Offset = "0x50")]
			public Color rewardMaskColor;

			// Token: 0x04038B06 RID: 232198
			[Token(Token = "0x4038B06")]
			[FieldOffset(Offset = "0x60")]
			public Color rewardDotColor;

			// Token: 0x04038B07 RID: 232199
			[Token(Token = "0x4038B07")]
			[FieldOffset(Offset = "0x70")]
			public Color lightColor;

			// Token: 0x04038B08 RID: 232200
			[Token(Token = "0x4038B08")]
			[FieldOffset(Offset = "0x80")]
			public Sprite decSprite;
		}
	}
}
