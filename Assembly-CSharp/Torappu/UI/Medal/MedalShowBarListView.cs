using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x02004988 RID: 18824
	[Token(Token = "0x2004988")]
	public class MedalShowBarListView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004327 RID: 17191
		// (get) Token: 0x0601C5D7 RID: 116183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004327")]
		private MedalShowBarListView.CountStyleAnimController countStyleController
		{
			[Token(Token = "0x601C5D7")]
			[Address(RVA = "0x15DA190", Offset = "0x15D8D90", VA = "0x1815DA190")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601C5D8 RID: 116184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5D8")]
		[Address(RVA = "0x15D7EB0", Offset = "0x15D6AB0", VA = "0x1815D7EB0")]
		public void ApplyValueChange(Vector2 value)
		{
		}

		// Token: 0x0601C5D9 RID: 116185 RVA: 0x000A7FD0 File Offset: 0x000A61D0
		[Token(Token = "0x601C5D9")]
		[Address(RVA = "0x15D9010", Offset = "0x15D7C10", VA = "0x1815D9010")]
		private static int _CalcIndexFromScrollValue(float val, int totalCount, float countInOnePage)
		{
			return 0;
		}

		// Token: 0x0601C5DA RID: 116186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5DA")]
		[Address(RVA = "0x15D8EF0", Offset = "0x15D7AF0", VA = "0x1815D8EF0")]
		public void ToLeftBarType(string typeId)
		{
		}

		// Token: 0x0601C5DB RID: 116187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C5DB")]
		[Address(RVA = "0x15D9200", Offset = "0x15D7E00", VA = "0x1815D9200")]
		private IEnumerator _DisplayOwnCount()
		{
			return null;
		}

		// Token: 0x0601C5DC RID: 116188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5DC")]
		[Address(RVA = "0x15D8660", Offset = "0x15D7260", VA = "0x1815D8660")]
		public void SwitchProgressDisplay()
		{
		}

		// Token: 0x0601C5DD RID: 116189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5DD")]
		[Address(RVA = "0x15D85F0", Offset = "0x15D71F0", VA = "0x1815D85F0")]
		public void StopProgressAnim()
		{
		}

		// Token: 0x0601C5DE RID: 116190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5DE")]
		[Address(RVA = "0x15D8580", Offset = "0x15D7180", VA = "0x1815D8580")]
		public void ResetProgressAnim()
		{
		}

		// Token: 0x0601C5DF RID: 116191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5DF")]
		[Address(RVA = "0x15D80F0", Offset = "0x15D6CF0", VA = "0x1815D80F0")]
		public void KillTween()
		{
		}

		// Token: 0x0601C5E0 RID: 116192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5E0")]
		[Address(RVA = "0x15D9DC0", Offset = "0x15D89C0", VA = "0x1815D9DC0")]
		private void _ToBarPos(int index, [Optional] Action finishAction)
		{
		}

		// Token: 0x0601C5E1 RID: 116193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5E1")]
		[Address(RVA = "0x15D9A10", Offset = "0x15D8610", VA = "0x1815D9A10")]
		private void _ToBarPosWithReset(int index, [Optional] Action finishAction)
		{
		}

		// Token: 0x0601C5E2 RID: 116194 RVA: 0x000A7FE8 File Offset: 0x000A61E8
		[Token(Token = "0x601C5E2")]
		[Address(RVA = "0x15D92B0", Offset = "0x15D7EB0", VA = "0x1815D92B0")]
		private int _FindListIdxByTypeId(string typeId)
		{
			return 0;
		}

		// Token: 0x0601C5E3 RID: 116195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5E3")]
		[Address(RVA = "0x15D8D10", Offset = "0x15D7910", VA = "0x1815D8D10")]
		public void ToBarType(string typeId)
		{
		}

		// Token: 0x0601C5E4 RID: 116196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5E4")]
		[Address(RVA = "0x15D87A0", Offset = "0x15D73A0", VA = "0x1815D87A0")]
		public void ToBarGroup(string groupId)
		{
		}

		// Token: 0x0601C5E5 RID: 116197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C5E5")]
		[Address(RVA = "0x15D86D0", Offset = "0x15D72D0", VA = "0x1815D86D0")]
		public IEnumerator ToBarGroupWhenScrollReady(string groupId)
		{
			return null;
		}

		// Token: 0x0601C5E6 RID: 116198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5E6")]
		[Address(RVA = "0x15D8220", Offset = "0x15D6E20", VA = "0x1815D8220")]
		public void OpenMedal(string medalId)
		{
		}

		// Token: 0x0601C5E7 RID: 116199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C5E7")]
		[Address(RVA = "0x15D8C40", Offset = "0x15D7840", VA = "0x1815D8C40")]
		public IEnumerator ToBarMedalWhenScrollReady(string medalId)
		{
			return null;
		}

		// Token: 0x0601C5E8 RID: 116200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5E8")]
		[Address(RVA = "0x15D88F0", Offset = "0x15D74F0", VA = "0x1815D88F0")]
		public void ToBarMedalAndOpen(string medalId, bool openMedal = true)
		{
		}

		// Token: 0x0601C5E9 RID: 116201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5E9")]
		[Address(RVA = "0x15D8390", Offset = "0x15D6F90", VA = "0x1815D8390")]
		public void Render(MedalListViewModel listViewModel)
		{
		}

		// Token: 0x0601C5EA RID: 116202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5EA")]
		[Address(RVA = "0x15D9410", Offset = "0x15D8010", VA = "0x1815D9410")]
		private void _RefreshProgressDisplay()
		{
		}

		// Token: 0x0601C5EB RID: 116203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5EB")]
		[Address(RVA = "0x15D90B0", Offset = "0x15D7CB0", VA = "0x1815D90B0")]
		private void _CoroutineWithPage(IEnumerator coroutine)
		{
		}

		// Token: 0x0601C5EC RID: 116204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C5EC")]
		[Address(RVA = "0x15DA0E0", Offset = "0x15D8CE0", VA = "0x1815DA0E0")]
		public MedalShowBarListView()
		{
		}

		// Token: 0x0402524A RID: 152138
		[Token(Token = "0x402524A")]
		private const int LIST_NEAR_INDEX_DIST = 10;

		// Token: 0x0402524B RID: 152139
		[Token(Token = "0x402524B")]
		private const float LIST_ITEM_HEIGHT = 144f;

		// Token: 0x0402524C RID: 152140
		[Token(Token = "0x402524C")]
		private const string PROGRESS_SWITCH_ANIM = "medal_progress_switch";

		// Token: 0x0402524D RID: 152141
		[Token(Token = "0x402524D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _percentIncreaseInterval;

		// Token: 0x0402524E RID: 152142
		[Token(Token = "0x402524E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _percentIncreaseDelay;

		// Token: 0x0402524F RID: 152143
		[Token(Token = "0x402524F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MedalBarListRecycleList _adapter;

		// Token: 0x04025250 RID: 152144
		[Token(Token = "0x4025250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MedalBarListView _barListView;

		// Token: 0x04025251 RID: 152145
		[Token(Token = "0x4025251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _roundBgImage;

		// Token: 0x04025252 RID: 152146
		[Token(Token = "0x4025252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _roundCircleImage;

		// Token: 0x04025253 RID: 152147
		[Token(Token = "0x4025253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _percentCount;

		// Token: 0x04025254 RID: 152148
		[Token(Token = "0x4025254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _countPart;

		// Token: 0x04025255 RID: 152149
		[Token(Token = "0x4025255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _threePartCount;

		// Token: 0x04025256 RID: 152150
		[Token(Token = "0x4025256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _twoPartCount;

		// Token: 0x04025257 RID: 152151
		[Token(Token = "0x4025257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _onePartCount;

		// Token: 0x04025258 RID: 152152
		[Token(Token = "0x4025258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _threePartMax;

		// Token: 0x04025259 RID: 152153
		[Token(Token = "0x4025259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _twoPartMax;

		// Token: 0x0402525A RID: 152154
		[Token(Token = "0x402525A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _onePartMax;

		// Token: 0x0402525B RID: 152155
		[Token(Token = "0x402525B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _collectCount;

		// Token: 0x0402525C RID: 152156
		[Token(Token = "0x402525C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private LoopVerticalScrollRect _scrollRect;

		// Token: 0x0402525D RID: 152157
		[Token(Token = "0x402525D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private List<MedalBarListStateBtn> _btnList;

		// Token: 0x0402525E RID: 152158
		[Token(Token = "0x402525E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x0402525F RID: 152159
		[Token(Token = "0x402525F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<MedalTypeViewModel> m_cachedTypeList;

		// Token: 0x04025260 RID: 152160
		[Token(Token = "0x4025260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private List<MedalBarListItemModel> m_cachedBarListViewModel;

		// Token: 0x04025261 RID: 152161
		[Token(Token = "0x4025261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private MedalListViewModel m_cachedViewModel;

		// Token: 0x04025262 RID: 152162
		[Token(Token = "0x4025262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private MedalListViewModel.ListFilter m_cachedFilter;

		// Token: 0x04025263 RID: 152163
		[Token(Token = "0x4025263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private UIPageListener m_pageListener;

		// Token: 0x04025264 RID: 152164
		[Token(Token = "0x4025264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private bool m_isInited;

		// Token: 0x04025265 RID: 152165
		[Token(Token = "0x4025265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private MedalShowBarListView.CountStyleAnimController m_countStyleController;

		// Token: 0x04025266 RID: 152166
		[Token(Token = "0x4025266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Tween m_cacheTween;

		// Token: 0x04025267 RID: 152167
		[Token(Token = "0x4025267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool m_isTypeJumping;

		// Token: 0x04025268 RID: 152168
		[Token(Token = "0x4025268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_countStyleController;

		// Token: 0x04025269 RID: 152169
		[Token(Token = "0x4025269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ApplyValueChange;

		// Token: 0x0402526A RID: 152170
		[Token(Token = "0x402526A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CalcIndexFromScrollValue;

		// Token: 0x0402526B RID: 152171
		[Token(Token = "0x402526B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ToLeftBarType;

		// Token: 0x0402526C RID: 152172
		[Token(Token = "0x402526C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__DisplayOwnCount;

		// Token: 0x0402526D RID: 152173
		[Token(Token = "0x402526D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SwitchProgressDisplay;

		// Token: 0x0402526E RID: 152174
		[Token(Token = "0x402526E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_StopProgressAnim;

		// Token: 0x0402526F RID: 152175
		[Token(Token = "0x402526F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ResetProgressAnim;

		// Token: 0x04025270 RID: 152176
		[Token(Token = "0x4025270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_KillTween;

		// Token: 0x04025271 RID: 152177
		[Token(Token = "0x4025271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ToBarPos;

		// Token: 0x04025272 RID: 152178
		[Token(Token = "0x4025272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ToBarPosWithReset;

		// Token: 0x04025273 RID: 152179
		[Token(Token = "0x4025273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__FindListIdxByTypeId;

		// Token: 0x04025274 RID: 152180
		[Token(Token = "0x4025274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ToBarType;

		// Token: 0x04025275 RID: 152181
		[Token(Token = "0x4025275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ToBarGroup;

		// Token: 0x04025276 RID: 152182
		[Token(Token = "0x4025276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_ToBarGroupWhenScrollReady;

		// Token: 0x04025277 RID: 152183
		[Token(Token = "0x4025277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OpenMedal;

		// Token: 0x04025278 RID: 152184
		[Token(Token = "0x4025278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_ToBarMedalWhenScrollReady;

		// Token: 0x04025279 RID: 152185
		[Token(Token = "0x4025279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_ToBarMedalAndOpen;

		// Token: 0x0402527A RID: 152186
		[Token(Token = "0x402527A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402527B RID: 152187
		[Token(Token = "0x402527B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__RefreshProgressDisplay;

		// Token: 0x0402527C RID: 152188
		[Token(Token = "0x402527C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__CoroutineWithPage;

		// Token: 0x0402527D RID: 152189
		[Token(Token = "0x402527D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004989 RID: 18825
		[Token(Token = "0x2004989")]
		private class CountStyleAnimController : IHotfixable
		{
			// Token: 0x0601C5ED RID: 116205 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C5ED")]
			[Address(RVA = "0x15DD4C0", Offset = "0x15DC0C0", VA = "0x1815DD4C0")]
			public CountStyleAnimController(MedalShowBarListView closure)
			{
			}

			// Token: 0x0601C5EE RID: 116206 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C5EE")]
			[Address(RVA = "0x15DCCC0", Offset = "0x15DB8C0", VA = "0x1815DCCC0")]
			public void ResetAnim()
			{
			}

			// Token: 0x0601C5EF RID: 116207 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C5EF")]
			[Address(RVA = "0x15DCF20", Offset = "0x15DBB20", VA = "0x1815DCF20")]
			public void SwitchAnim()
			{
			}

			// Token: 0x0601C5F0 RID: 116208 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C5F0")]
			[Address(RVA = "0x15DCEC0", Offset = "0x15DBAC0", VA = "0x1815DCEC0")]
			public void StopAnim()
			{
			}

			// Token: 0x0601C5F1 RID: 116209 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C5F1")]
			[Address(RVA = "0x15DD2C0", Offset = "0x15DBEC0", VA = "0x1815DD2C0")]
			private void _StopAnimImpl()
			{
			}

			// Token: 0x0402527E RID: 152190
			[Token(Token = "0x402527E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private MedalShowBarListView m_closure;

			// Token: 0x0402527F RID: 152191
			[Token(Token = "0x402527F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private bool m_showProgressDetails;

			// Token: 0x04025280 RID: 152192
			[Token(Token = "0x4025280")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			private bool m_isSwitchingProgress;

			// Token: 0x04025281 RID: 152193
			[Token(Token = "0x4025281")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04025282 RID: 152194
			[Token(Token = "0x4025282")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ResetAnim;

			// Token: 0x04025283 RID: 152195
			[Token(Token = "0x4025283")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_SwitchAnim;

			// Token: 0x04025284 RID: 152196
			[Token(Token = "0x4025284")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_StopAnim;

			// Token: 0x04025285 RID: 152197
			[Token(Token = "0x4025285")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__StopAnimImpl;
		}
	}
}
