using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020069D0 RID: 27088
	[Token(Token = "0x20069D0")]
	public class ZoneRecordRewardItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026C15 RID: 158741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C15")]
		[Address(RVA = "0x21E3D70", Offset = "0x21E2970", VA = "0x1821E3D70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026C16 RID: 158742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C16")]
		[Address(RVA = "0x21E3680", Offset = "0x21E2280", VA = "0x1821E3680")]
		public void Render(int idx, ZoneRecordRewardViewModel rewardViewModel)
		{
		}

		// Token: 0x06026C17 RID: 158743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026C17")]
		[Address(RVA = "0x21E3C00", Offset = "0x21E2800", VA = "0x1821E3C00")]
		private List<UIItemViewModel> _GenRewardViewModel(ItemBundle[] items)
		{
			return null;
		}

		// Token: 0x06026C18 RID: 158744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C18")]
		[Address(RVA = "0x21E3E20", Offset = "0x21E2A20", VA = "0x1821E3E20")]
		public ZoneRecordRewardItemView()
		{
		}

		// Token: 0x04036BCE RID: 224206
		[Token(Token = "0x4036BCE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon;

		// Token: 0x04036BCF RID: 224207
		[Token(Token = "0x4036BCF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _isAvailable;

		// Token: 0x04036BD0 RID: 224208
		[Token(Token = "0x4036BD0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _isGained;

		// Token: 0x04036BD1 RID: 224209
		[Token(Token = "0x4036BD1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _missionIcon;

		// Token: 0x04036BD2 RID: 224210
		[Token(Token = "0x4036BD2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleLayoutContent _rewardItemsContent;

		// Token: 0x04036BD3 RID: 224211
		[Token(Token = "0x4036BD3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _splitLine;

		// Token: 0x04036BD4 RID: 224212
		[Token(Token = "0x4036BD4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04036BD5 RID: 224213
		[Token(Token = "0x4036BD5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _scaleFactor;

		// Token: 0x04036BD6 RID: 224214
		[Token(Token = "0x4036BD6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _rectFinishPart;

		// Token: 0x04036BD7 RID: 224215
		[Token(Token = "0x4036BD7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _rectAvailPart;

		// Token: 0x04036BD8 RID: 224216
		[Token(Token = "0x4036BD8")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isInited;

		// Token: 0x04036BD9 RID: 224217
		[Token(Token = "0x4036BD9")]
		[FieldOffset(Offset = "0x6C")]
		private float m_defaultFinishRectHeigh;

		// Token: 0x04036BDA RID: 224218
		[Token(Token = "0x4036BDA")]
		[FieldOffset(Offset = "0x70")]
		private float m_defaultAvailRectHeigh;

		// Token: 0x04036BDB RID: 224219
		[Token(Token = "0x4036BDB")]
		private const float COLOR_ALPHA_ONE = 1f;

		// Token: 0x04036BDC RID: 224220
		[Token(Token = "0x4036BDC")]
		private const float COLOR_ALPHA_HALF = 0.5f;

		// Token: 0x04036BDD RID: 224221
		[Token(Token = "0x4036BDD")]
		private const float CLAIM_FLAG_CEIL_WIDTH = 70f;

		// Token: 0x04036BDE RID: 224222
		[Token(Token = "0x4036BDE")]
		private const float AVAIL_CLAIM_FLAG_ADD_WIDTH = 25f;

		// Token: 0x04036BDF RID: 224223
		[Token(Token = "0x4036BDF")]
		private const float REWARDS_LONG_LIMIT = 3f;

		// Token: 0x04036BE0 RID: 224224
		[Token(Token = "0x4036BE0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04036BE1 RID: 224225
		[Token(Token = "0x4036BE1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04036BE2 RID: 224226
		[Token(Token = "0x4036BE2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GenRewardViewModel;

		// Token: 0x04036BE3 RID: 224227
		[Token(Token = "0x4036BE3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
