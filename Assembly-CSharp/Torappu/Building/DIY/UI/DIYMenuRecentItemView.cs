using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x0200199C RID: 6556
	[Token(Token = "0x200199C")]
	public class DIYMenuRecentItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600A4A8 RID: 42152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4A8")]
		[Address(RVA = "0x31E1B70", Offset = "0x31E0770", VA = "0x1831E1B70")]
		public void Setup(List<string> itemDatas, int count, string oldText, bool showTrackpoint, bool isFurniture)
		{
		}

		// Token: 0x0600A4A9 RID: 42153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A4A9")]
		[Address(RVA = "0x31E18E0", Offset = "0x31E04E0", VA = "0x1831E18E0")]
		public Tween GenerateShowTween()
		{
			return null;
		}

		// Token: 0x0600A4AA RID: 42154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A4AA")]
		[Address(RVA = "0x31E1710", Offset = "0x31E0310", VA = "0x1831E1710")]
		public Tween GenerateHideTween()
		{
			return null;
		}

		// Token: 0x0600A4AB RID: 42155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4AB")]
		[Address(RVA = "0x31E1EE0", Offset = "0x31E0AE0", VA = "0x1831E1EE0")]
		public void ShowImmediately()
		{
		}

		// Token: 0x0600A4AC RID: 42156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4AC")]
		[Address(RVA = "0x31E1AC0", Offset = "0x31E06C0", VA = "0x1831E1AC0")]
		public void HideImmediately()
		{
		}

		// Token: 0x0600A4AD RID: 42157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4AD")]
		[Address(RVA = "0x31E1FA0", Offset = "0x31E0BA0", VA = "0x1831E1FA0")]
		public DIYMenuRecentItemView()
		{
		}

		// Token: 0x04009BDB RID: 39899
		[Token(Token = "0x4009BDB")]
		private const float ANIM_DURATION = 0.36f;

		// Token: 0x04009BDC RID: 39900
		[Token(Token = "0x4009BDC")]
		private const float ANIM_SIZE_DELTA_DURATION = 0.2f;

		// Token: 0x04009BDD RID: 39901
		[Token(Token = "0x4009BDD")]
		private const int WIDTH_EMPTY = 260;

		// Token: 0x04009BDE RID: 39902
		[Token(Token = "0x4009BDE")]
		private const int WIDTH_NORMAL = 502;

		// Token: 0x04009BDF RID: 39903
		[Token(Token = "0x4009BDF")]
		private const float HEIGHT_NORMAL = 205.7f;

		// Token: 0x04009BE0 RID: 39904
		[Token(Token = "0x4009BE0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private DIYMenuRecentItemView.DIYMenuRecentItem[] _showIcons;

		// Token: 0x04009BE1 RID: 39905
		[Token(Token = "0x4009BE1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textCount;

		// Token: 0x04009BE2 RID: 39906
		[Token(Token = "0x4009BE2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textOldCount;

		// Token: 0x04009BE3 RID: 39907
		[Token(Token = "0x4009BE3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _pnlNone;

		// Token: 0x04009BE4 RID: 39908
		[Token(Token = "0x4009BE4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _pnlRecent;

		// Token: 0x04009BE5 RID: 39909
		[Token(Token = "0x4009BE5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _pnlTrackpoint;

		// Token: 0x04009BE6 RID: 39910
		[Token(Token = "0x4009BE6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _animSwitch;

		// Token: 0x04009BE7 RID: 39911
		[Token(Token = "0x4009BE7")]
		[FieldOffset(Offset = "0x58")]
		private bool m_cachedEmpty;

		// Token: 0x04009BE8 RID: 39912
		[Token(Token = "0x4009BE8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x04009BE9 RID: 39913
		[Token(Token = "0x4009BE9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenerateShowTween;

		// Token: 0x04009BEA RID: 39914
		[Token(Token = "0x4009BEA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GenerateHideTween;

		// Token: 0x04009BEB RID: 39915
		[Token(Token = "0x4009BEB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x04009BEC RID: 39916
		[Token(Token = "0x4009BEC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x04009BED RID: 39917
		[Token(Token = "0x4009BED")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200199D RID: 6557
		[Token(Token = "0x200199D")]
		[Serializable]
		public class DIYMenuRecentItem : IHotfixable
		{
			// Token: 0x0600A4AE RID: 42158 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A4AE")]
			[Address(RVA = "0x31E2000", Offset = "0x31E0C00", VA = "0x1831E2000")]
			public void Render(string itemId, bool isFurniture)
			{
			}

			// Token: 0x0600A4AF RID: 42159 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A4AF")]
			[Address(RVA = "0x31E2150", Offset = "0x31E0D50", VA = "0x1831E2150")]
			public DIYMenuRecentItem()
			{
			}

			// Token: 0x04009BEE RID: 39918
			[Token(Token = "0x4009BEE")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Image _iconItem;

			// Token: 0x04009BEF RID: 39919
			[Token(Token = "0x4009BEF")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private UIAtlasImage _iconEmpty;

			// Token: 0x04009BF0 RID: 39920
			[Token(Token = "0x4009BF0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x04009BF1 RID: 39921
			[Token(Token = "0x4009BF1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
