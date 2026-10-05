using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Home.Activity
{
	// Token: 0x02004C7D RID: 19581
	[Token(Token = "0x2004C7D")]
	public class OpenServerTotalCheckInItemView : MonoBehaviour
	{
		// Token: 0x0601D5CF RID: 120271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5CF")]
		[Address(RVA = "0x16EC970", Offset = "0x16EB570", VA = "0x1816EC970")]
		public void Init(int index, TotalCheckinData data)
		{
		}

		// Token: 0x0601D5D0 RID: 120272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5D0")]
		[Address(RVA = "0x16ED090", Offset = "0x16EBC90", VA = "0x1816ED090")]
		public void OnClick()
		{
		}

		// Token: 0x0601D5D1 RID: 120273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5D1")]
		[Address(RVA = "0x16ED040", Offset = "0x16EBC40", VA = "0x1816ED040")]
		public void OnAnimator()
		{
		}

		// Token: 0x0601D5D2 RID: 120274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5D2")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public OpenServerTotalCheckInItemView()
		{
		}

		// Token: 0x04026A3C RID: 158268
		[Token(Token = "0x4026A3C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _indexId;

		// Token: 0x04026A3D RID: 158269
		[Token(Token = "0x4026A3D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _itemName;

		// Token: 0x04026A3E RID: 158270
		[Token(Token = "0x4026A3E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _itemIcon;

		// Token: 0x04026A3F RID: 158271
		[Token(Token = "0x4026A3F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _itemCount;

		// Token: 0x04026A40 RID: 158272
		[Token(Token = "0x4026A40")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _itemIcon_2;

		// Token: 0x04026A41 RID: 158273
		[Token(Token = "0x4026A41")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _itemCount_2;

		// Token: 0x04026A42 RID: 158274
		[Token(Token = "0x4026A42")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _neverGet;

		// Token: 0x04026A43 RID: 158275
		[Token(Token = "0x4026A43")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _alreadyGet;

		// Token: 0x04026A44 RID: 158276
		[Token(Token = "0x4026A44")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _alreadyGet_2;

		// Token: 0x04026A45 RID: 158277
		[Token(Token = "0x4026A45")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _upPart;

		// Token: 0x04026A46 RID: 158278
		[Token(Token = "0x4026A46")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _downPart;

		// Token: 0x04026A47 RID: 158279
		[Token(Token = "0x4026A47")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<Sprite> _upSpritePart;

		// Token: 0x04026A48 RID: 158280
		[Token(Token = "0x4026A48")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private List<Sprite> _downSpritePart;

		// Token: 0x04026A49 RID: 158281
		[Token(Token = "0x4026A49")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _canGet;

		// Token: 0x04026A4A RID: 158282
		[Token(Token = "0x4026A4A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _canGetHotSpot;

		// Token: 0x04026A4B RID: 158283
		[Token(Token = "0x4026A4B")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		public Action<int> OnGetCheckIn;

		// Token: 0x04026A4C RID: 158284
		[Token(Token = "0x4026A4C")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Animator _onFinish;

		// Token: 0x04026A4D RID: 158285
		[Token(Token = "0x4026A4D")]
		[FieldOffset(Offset = "0xA0")]
		private int m_index;

		// Token: 0x04026A4E RID: 158286
		[Token(Token = "0x4026A4E")]
		private const string MISSION_COMPLETE_ANIMATOR = "chain_login_complete";
	}
}
