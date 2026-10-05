using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x02007A40 RID: 31296
	[Token(Token = "0x2007A40")]
	public class Act13sidePrestigePromoteView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602BD97 RID: 179607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD97")]
		[Address(RVA = "0x27CF4A0", Offset = "0x27CE0A0", VA = "0x1827CF4A0")]
		public void Render(string actId, string orgId, Act13SideData.PrestigeRank lastRank, Act13SideData.PrestigeRank currentRank)
		{
		}

		// Token: 0x0602BD98 RID: 179608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BD98")]
		[Address(RVA = "0x27CFCF0", Offset = "0x27CE8F0", VA = "0x1827CFCF0")]
		private IEnumerator _EnableInteract()
		{
			return null;
		}

		// Token: 0x0602BD99 RID: 179609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD99")]
		[Address(RVA = "0x27CFDA0", Offset = "0x27CE9A0", VA = "0x1827CFDA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602BD9A RID: 179610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD9A")]
		[Address(RVA = "0x27CF400", Offset = "0x27CE000", VA = "0x1827CF400")]
		public void CloseSelf()
		{
		}

		// Token: 0x0602BD9B RID: 179611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD9B")]
		[Address(RVA = "0x27CFFA0", Offset = "0x27CEBA0", VA = "0x1827CFFA0")]
		public Act13sidePrestigePromoteView()
		{
		}

		// Token: 0x0403F7D2 RID: 260050
		[Token(Token = "0x403F7D2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act13sidePrestigePromoteView.AnimEmojiStruct[] _animStructList;

		// Token: 0x0403F7D3 RID: 260051
		[Token(Token = "0x403F7D3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _animEmojiContainer;

		// Token: 0x0403F7D4 RID: 260052
		[Token(Token = "0x403F7D4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgLogo;

		// Token: 0x0403F7D5 RID: 260053
		[Token(Token = "0x403F7D5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgTitle;

		// Token: 0x0403F7D6 RID: 260054
		[Token(Token = "0x403F7D6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgEmojiLast;

		// Token: 0x0403F7D7 RID: 260055
		[Token(Token = "0x403F7D7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textRankLast;

		// Token: 0x0403F7D8 RID: 260056
		[Token(Token = "0x403F7D8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textRankCurrent;

		// Token: 0x0403F7D9 RID: 260057
		[Token(Token = "0x403F7D9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _rewardList;

		// Token: 0x0403F7DA RID: 260058
		[Token(Token = "0x403F7DA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x0403F7DB RID: 260059
		[Token(Token = "0x403F7DB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _backRt;

		// Token: 0x0403F7DC RID: 260060
		[Token(Token = "0x403F7DC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _enterAnimDelay;

		// Token: 0x0403F7DD RID: 260061
		[Token(Token = "0x403F7DD")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _emojiAnimDelay;

		// Token: 0x0403F7DE RID: 260062
		[Token(Token = "0x403F7DE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _interactDelay;

		// Token: 0x0403F7DF RID: 260063
		[Token(Token = "0x403F7DF")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		public Action onReturn;

		// Token: 0x0403F7E0 RID: 260064
		[Token(Token = "0x403F7E0")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x0403F7E1 RID: 260065
		[Token(Token = "0x403F7E1")]
		[FieldOffset(Offset = "0x89")]
		private bool m_canInteract;

		// Token: 0x0403F7E2 RID: 260066
		[Token(Token = "0x403F7E2")]
		[FieldOffset(Offset = "0x90")]
		private Act13SideData.OrgData m_orgData;

		// Token: 0x0403F7E3 RID: 260067
		[Token(Token = "0x403F7E3")]
		[FieldOffset(Offset = "0x98")]
		private Act13sidePrestigePromoteView.Adapter m_adapter;

		// Token: 0x0403F7E4 RID: 260068
		[Token(Token = "0x403F7E4")]
		[FieldOffset(Offset = "0xA0")]
		private Act13sideAnimEmojiView m_animEmoji;

		// Token: 0x0403F7E5 RID: 260069
		[Token(Token = "0x403F7E5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403F7E6 RID: 260070
		[Token(Token = "0x403F7E6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EnableInteract;

		// Token: 0x0403F7E7 RID: 260071
		[Token(Token = "0x403F7E7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403F7E8 RID: 260072
		[Token(Token = "0x403F7E8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CloseSelf;

		// Token: 0x0403F7E9 RID: 260073
		[Token(Token = "0x403F7E9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007A41 RID: 31297
		[Token(Token = "0x2007A41")]
		[Serializable]
		public struct AnimEmojiStruct
		{
			// Token: 0x0403F7EA RID: 260074
			[Token(Token = "0x403F7EA")]
			[FieldOffset(Offset = "0x0")]
			public Act13SideData.PrestigeRank rank;

			// Token: 0x0403F7EB RID: 260075
			[Token(Token = "0x403F7EB")]
			[FieldOffset(Offset = "0x8")]
			public Act13sideAnimEmojiView emojiView;
		}

		// Token: 0x02007A42 RID: 31298
		[Token(Token = "0x2007A42")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0602BD9C RID: 179612 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BD9C")]
			[Address(RVA = "0x27D13E0", Offset = "0x27CFFE0", VA = "0x1827D13E0")]
			public void SetData(int docCount, int newsCount, int avgCount, string itemId)
			{
			}

			// Token: 0x170066D0 RID: 26320
			// (get) Token: 0x0602BD9D RID: 179613 RVA: 0x000DD6A0 File Offset: 0x000DB8A0
			[Token(Token = "0x170066D0")]
			public override int count
			{
				[Token(Token = "0x602BD9D")]
				[Address(RVA = "0x27D18F0", Offset = "0x27D04F0", VA = "0x1827D18F0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602BD9E RID: 179614 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602BD9E")]
			[Address(RVA = "0x27D0F00", Offset = "0x27CFB00", VA = "0x1827D0F00", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0602BD9F RID: 179615 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BD9F")]
			[Address(RVA = "0x27D1700", Offset = "0x27D0300", VA = "0x1827D1700")]
			public Adapter()
			{
			}

			// Token: 0x0403F7EC RID: 260076
			[Token(Token = "0x403F7EC")]
			[FieldOffset(Offset = "0x20")]
			private List<string> m_hintList;

			// Token: 0x0403F7ED RID: 260077
			[Token(Token = "0x403F7ED")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_SetData;

			// Token: 0x0403F7EE RID: 260078
			[Token(Token = "0x403F7EE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403F7EF RID: 260079
			[Token(Token = "0x403F7EF")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0403F7F0 RID: 260080
			[Token(Token = "0x403F7F0")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
