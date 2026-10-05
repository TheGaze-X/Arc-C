using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Skin
{
	// Token: 0x02003EE7 RID: 16103
	[Token(Token = "0x2003EE7")]
	public class SkinSelectScrollItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018FA0 RID: 102304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018FA0")]
		[Address(RVA = "0x119FF10", Offset = "0x119EB10", VA = "0x18119FF10")]
		public void OnClick()
		{
		}

		// Token: 0x06018FA1 RID: 102305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018FA1")]
		[Address(RVA = "0x119F7E0", Offset = "0x119E3E0", VA = "0x18119F7E0")]
		public void ApplyData(SkinSelectViewModel skinViewModel)
		{
		}

		// Token: 0x06018FA2 RID: 102306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018FA2")]
		[Address(RVA = "0x119FBC0", Offset = "0x119E7C0", VA = "0x18119FBC0")]
		public void ApplyState(float state)
		{
		}

		// Token: 0x06018FA3 RID: 102307 RVA: 0x0009C7F8 File Offset: 0x0009A9F8
		[Token(Token = "0x6018FA3")]
		[Address(RVA = "0x11A0040", Offset = "0x119EC40", VA = "0x1811A0040")]
		private float _ModGetPos(float state)
		{
			return 0f;
		}

		// Token: 0x06018FA4 RID: 102308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018FA4")]
		[Address(RVA = "0x11A0180", Offset = "0x119ED80", VA = "0x1811A0180")]
		public SkinSelectScrollItemView()
		{
		}

		// Token: 0x0401EDA2 RID: 126370
		[Token(Token = "0x401EDA2")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public int index;

		// Token: 0x0401EDA3 RID: 126371
		[Token(Token = "0x401EDA3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _portraitImage;

		// Token: 0x0401EDA4 RID: 126372
		[Token(Token = "0x401EDA4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _portraitImage2;

		// Token: 0x0401EDA5 RID: 126373
		[Token(Token = "0x401EDA5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _name;

		// Token: 0x0401EDA6 RID: 126374
		[Token(Token = "0x401EDA6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _bound;

		// Token: 0x0401EDA7 RID: 126375
		[Token(Token = "0x401EDA7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _alphaBlend;

		// Token: 0x0401EDA8 RID: 126376
		[Token(Token = "0x401EDA8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _content;

		// Token: 0x0401EDA9 RID: 126377
		[Token(Token = "0x401EDA9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _alphaPart;

		// Token: 0x0401EDAA RID: 126378
		[Token(Token = "0x401EDAA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _skinGroupIcon;

		// Token: 0x0401EDAB RID: 126379
		[Token(Token = "0x401EDAB")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _alphaMask;

		// Token: 0x0401EDAC RID: 126380
		[Token(Token = "0x401EDAC")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _boundPerLenth;

		// Token: 0x0401EDAD RID: 126381
		[Token(Token = "0x401EDAD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SkinSelectPriceViewObj _priceObj;

		// Token: 0x0401EDAE RID: 126382
		[Token(Token = "0x401EDAE")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public float sortingIndex;

		// Token: 0x0401EDAF RID: 126383
		[Token(Token = "0x401EDAF")]
		[FieldOffset(Offset = "0x7C")]
		[NonSerialized]
		public int skinIndex;

		// Token: 0x0401EDB0 RID: 126384
		[Token(Token = "0x401EDB0")]
		[FieldOffset(Offset = "0x80")]
		private string m_skinId;

		// Token: 0x0401EDB1 RID: 126385
		[Token(Token = "0x401EDB1")]
		[FieldOffset(Offset = "0x88")]
		private string m_portraitId;

		// Token: 0x0401EDB2 RID: 126386
		[Token(Token = "0x401EDB2")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		public Action<float> OnClickEvent;

		// Token: 0x0401EDB3 RID: 126387
		[Token(Token = "0x401EDB3")]
		[FieldOffset(Offset = "0x98")]
		private float m_currentState;

		// Token: 0x0401EDB4 RID: 126388
		[Token(Token = "0x401EDB4")]
		[FieldOffset(Offset = "0xA0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401EDB5 RID: 126389
		[Token(Token = "0x401EDB5")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_isEmpty;

		// Token: 0x0401EDB6 RID: 126390
		[Token(Token = "0x401EDB6")]
		[FieldOffset(Offset = "0x0")]
		private static readonly float[] EFFECT_STATE;

		// Token: 0x0401EDB7 RID: 126391
		[Token(Token = "0x401EDB7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0401EDB8 RID: 126392
		[Token(Token = "0x401EDB8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0401EDB9 RID: 126393
		[Token(Token = "0x401EDB9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ApplyState;

		// Token: 0x0401EDBA RID: 126394
		[Token(Token = "0x401EDBA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ModGetPos;

		// Token: 0x0401EDBB RID: 126395
		[Token(Token = "0x401EDBB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
