using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Home.Activity
{
	// Token: 0x02004C75 RID: 19573
	[Token(Token = "0x2004C75")]
	public class OpenServerChainLoginItemView : MonoBehaviour
	{
		// Token: 0x0601D5AF RID: 120239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5AF")]
		[Address(RVA = "0x16EAE50", Offset = "0x16E9A50", VA = "0x1816EAE50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D5B0 RID: 120240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5B0")]
		[Address(RVA = "0x16EA2A0", Offset = "0x16E8EA0", VA = "0x1816EA2A0")]
		public void Init(int index, ChainLoginData data)
		{
		}

		// Token: 0x0601D5B1 RID: 120241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5B1")]
		[Address(RVA = "0x16EADE0", Offset = "0x16E99E0", VA = "0x1816EADE0")]
		public void OnAnimator()
		{
		}

		// Token: 0x0601D5B2 RID: 120242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5B2")]
		[Address(RVA = "0x16EAE30", Offset = "0x16E9A30", VA = "0x1816EAE30")]
		public void OnClick()
		{
		}

		// Token: 0x0601D5B3 RID: 120243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5B3")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public OpenServerChainLoginItemView()
		{
		}

		// Token: 0x040269EB RID: 158187
		[Token(Token = "0x40269EB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _dayText;

		// Token: 0x040269EC RID: 158188
		[Token(Token = "0x40269EC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _itemName;

		// Token: 0x040269ED RID: 158189
		[Token(Token = "0x40269ED")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _itemIcon;

		// Token: 0x040269EE RID: 158190
		[Token(Token = "0x40269EE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _itemIcon_2;

		// Token: 0x040269EF RID: 158191
		[Token(Token = "0x40269EF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _alreadyLogin;

		// Token: 0x040269F0 RID: 158192
		[Token(Token = "0x40269F0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _alreadyGet;

		// Token: 0x040269F1 RID: 158193
		[Token(Token = "0x40269F1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _alreadyGet_2;

		// Token: 0x040269F2 RID: 158194
		[Token(Token = "0x40269F2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _neverGet;

		// Token: 0x040269F3 RID: 158195
		[Token(Token = "0x40269F3")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _countText;

		// Token: 0x040269F4 RID: 158196
		[Token(Token = "0x40269F4")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _countText_2;

		// Token: 0x040269F5 RID: 158197
		[Token(Token = "0x40269F5")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _canGet;

		// Token: 0x040269F6 RID: 158198
		[Token(Token = "0x40269F6")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _upPart;

		// Token: 0x040269F7 RID: 158199
		[Token(Token = "0x40269F7")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _downPart;

		// Token: 0x040269F8 RID: 158200
		[Token(Token = "0x40269F8")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private List<Sprite> _upSpritePart;

		// Token: 0x040269F9 RID: 158201
		[Token(Token = "0x40269F9")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private List<Sprite> _downSpritePart;

		// Token: 0x040269FA RID: 158202
		[Token(Token = "0x40269FA")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		public Action<int> OnGetChainLogin;

		// Token: 0x040269FB RID: 158203
		[Token(Token = "0x40269FB")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Animator _onFinish;

		// Token: 0x040269FC RID: 158204
		[Token(Token = "0x40269FC")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Transform _itemCardContainer;

		// Token: 0x040269FD RID: 158205
		[Token(Token = "0x40269FD")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float _itemScaleFactor;

		// Token: 0x040269FE RID: 158206
		[Token(Token = "0x40269FE")]
		[FieldOffset(Offset = "0xAC")]
		private bool m_isInited;

		// Token: 0x040269FF RID: 158207
		[Token(Token = "0x40269FF")]
		[FieldOffset(Offset = "0xB0")]
		private UIItemCard m_itemCard;

		// Token: 0x04026A00 RID: 158208
		[Token(Token = "0x4026A00")]
		[FieldOffset(Offset = "0xB8")]
		private int m_index;

		// Token: 0x04026A01 RID: 158209
		[Token(Token = "0x4026A01")]
		private const string MISSION_COMPLETE_ANIMATOR = "chain_login_complete";
	}
}
