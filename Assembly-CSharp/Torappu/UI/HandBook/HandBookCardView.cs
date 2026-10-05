using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x0200668D RID: 26253
	[Token(Token = "0x200668D")]
	[RequireComponent(typeof(Animator), typeof(CanvasGroup))]
	public class HandBookCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005951 RID: 22865
		// (get) Token: 0x06025B47 RID: 154439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005951")]
		public HandBookCardViewModel cardData
		{
			[Token(Token = "0x6025B47")]
			[Address(RVA = "0x20911E0", Offset = "0x208FDE0", VA = "0x1820911E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005952 RID: 22866
		// (set) Token: 0x06025B48 RID: 154440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005952")]
		public HandBookScrollView parentView
		{
			[Token(Token = "0x6025B48")]
			[Address(RVA = "0x20916B0", Offset = "0x20902B0", VA = "0x1820916B0")]
			set
			{
			}
		}

		// Token: 0x17005953 RID: 22867
		// (get) Token: 0x06025B49 RID: 154441 RVA: 0x000C8CB8 File Offset: 0x000C6EB8
		// (set) Token: 0x06025B4A RID: 154442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005953")]
		public bool detailFlag
		{
			[Token(Token = "0x6025B49")]
			[Address(RVA = "0x20912A0", Offset = "0x208FEA0", VA = "0x1820912A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6025B4A")]
			[Address(RVA = "0x2091540", Offset = "0x2090140", VA = "0x182091540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005954 RID: 22868
		// (get) Token: 0x06025B4B RID: 154443 RVA: 0x000C8CD0 File Offset: 0x000C6ED0
		// (set) Token: 0x06025B4C RID: 154444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005954")]
		public Vector3 initPos
		{
			[Token(Token = "0x6025B4B")]
			[Address(RVA = "0x2091300", Offset = "0x208FF00", VA = "0x182091300")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6025B4C")]
			[Address(RVA = "0x20915B0", Offset = "0x20901B0", VA = "0x1820915B0")]
			set
			{
			}
		}

		// Token: 0x17005955 RID: 22869
		// (get) Token: 0x06025B4D RID: 154445 RVA: 0x000C8CE8 File Offset: 0x000C6EE8
		// (set) Token: 0x06025B4E RID: 154446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005955")]
		public float lvl
		{
			[Token(Token = "0x6025B4D")]
			[Address(RVA = "0x2091380", Offset = "0x208FF80", VA = "0x182091380")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6025B4E")]
			[Address(RVA = "0x2091640", Offset = "0x2090240", VA = "0x182091640")]
			set
			{
			}
		}

		// Token: 0x17005956 RID: 22870
		// (get) Token: 0x06025B4F RID: 154447 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06025B50 RID: 154448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005956")]
		public string charID
		{
			[Token(Token = "0x6025B4F")]
			[Address(RVA = "0x2091240", Offset = "0x208FE40", VA = "0x182091240")]
			get
			{
				return null;
			}
			[Token(Token = "0x6025B50")]
			[Address(RVA = "0x20914C0", Offset = "0x20900C0", VA = "0x1820914C0")]
			set
			{
			}
		}

		// Token: 0x17005957 RID: 22871
		// (get) Token: 0x06025B51 RID: 154449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005957")]
		public string powerId
		{
			[Token(Token = "0x6025B51")]
			[Address(RVA = "0x20913E0", Offset = "0x208FFE0", VA = "0x1820913E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005958 RID: 22872
		// (set) Token: 0x06025B52 RID: 154450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005958")]
		public bool selected
		{
			[Token(Token = "0x6025B52")]
			[Address(RVA = "0x2091730", Offset = "0x2090330", VA = "0x182091730")]
			set
			{
			}
		}

		// Token: 0x17005959 RID: 22873
		// (get) Token: 0x06025B53 RID: 154451 RVA: 0x000C8D00 File Offset: 0x000C6F00
		// (set) Token: 0x06025B54 RID: 154452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005959")]
		private float zoomValue
		{
			[Token(Token = "0x6025B53")]
			[Address(RVA = "0x2091440", Offset = "0x2090040", VA = "0x182091440")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6025B54")]
			[Address(RVA = "0x2091830", Offset = "0x2090430", VA = "0x182091830")]
			set
			{
			}
		}

		// Token: 0x06025B55 RID: 154453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B55")]
		[Address(RVA = "0x208F710", Offset = "0x208E310", VA = "0x18208F710")]
		public void MoveFirstThread(float zoomValue, HandBookConstVars.CARDSTATE cardState)
		{
		}

		// Token: 0x06025B56 RID: 154454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B56")]
		[Address(RVA = "0x208F8A0", Offset = "0x208E4A0", VA = "0x18208F8A0")]
		public void MoveSecondThread(float zoomValue, bool zoomFlag, bool quickAnim)
		{
		}

		// Token: 0x06025B57 RID: 154455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B57")]
		[Address(RVA = "0x208FA60", Offset = "0x208E660", VA = "0x18208FA60")]
		public void MoveThirdThread(Vector3 pos, float angle, bool quickAnim)
		{
		}

		// Token: 0x06025B58 RID: 154456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B58")]
		[Address(RVA = "0x208F800", Offset = "0x208E400", VA = "0x18208F800")]
		public void MoveForthThread()
		{
		}

		// Token: 0x06025B59 RID: 154457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B59")]
		[Address(RVA = "0x20906E0", Offset = "0x208F2E0", VA = "0x1820906E0")]
		public void OnValueRefresh(HandBookScrollViewProperty property)
		{
		}

		// Token: 0x06025B5A RID: 154458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B5A")]
		[Address(RVA = "0x208FD40", Offset = "0x208E940", VA = "0x18208FD40")]
		public void OnValueChanged(HandBookScrollViewProperty property)
		{
		}

		// Token: 0x06025B5B RID: 154459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025B5B")]
		[Address(RVA = "0x2090FE0", Offset = "0x208FBE0", VA = "0x182090FE0")]
		private IEnumerator _MoveSecondThread(Vector3 pos)
		{
			return null;
		}

		// Token: 0x06025B5C RID: 154460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025B5C")]
		[Address(RVA = "0x2090E50", Offset = "0x208FA50", VA = "0x182090E50")]
		private IEnumerator _MoveFirstThread(Vector3 pos)
		{
			return null;
		}

		// Token: 0x06025B5D RID: 154461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025B5D")]
		[Address(RVA = "0x2090F30", Offset = "0x208FB30", VA = "0x182090F30")]
		private IEnumerator _MoveMiddleFirstThread()
		{
			return null;
		}

		// Token: 0x06025B5E RID: 154462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B5E")]
		[Address(RVA = "0x208F0D0", Offset = "0x208DCD0", VA = "0x18208F0D0")]
		public void LoadData(HandbookCardData cardData)
		{
		}

		// Token: 0x06025B5F RID: 154463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B5F")]
		[Address(RVA = "0x208F2F0", Offset = "0x208DEF0", VA = "0x18208F2F0")]
		public void LoadData(HandBookCardViewModel cardData, bool needTrackPoint = true)
		{
		}

		// Token: 0x06025B60 RID: 154464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B60")]
		[Address(RVA = "0x2090D80", Offset = "0x208F980", VA = "0x182090D80")]
		public void UpdateTrackPoint()
		{
		}

		// Token: 0x06025B61 RID: 154465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B61")]
		[Address(RVA = "0x2090CF0", Offset = "0x208F8F0", VA = "0x182090CF0")]
		public void SetActiveFalse()
		{
		}

		// Token: 0x06025B62 RID: 154466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B62")]
		[Address(RVA = "0x208FC60", Offset = "0x208E860", VA = "0x18208FC60")]
		public void OnClicked()
		{
		}

		// Token: 0x06025B63 RID: 154467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B63")]
		[Address(RVA = "0x20910C0", Offset = "0x208FCC0", VA = "0x1820910C0")]
		public HandBookCardView()
		{
		}

		// Token: 0x04034F81 RID: 216961
		[Token(Token = "0x4034F81")]
		[FieldOffset(Offset = "0x18")]
		public string m_charId;

		// Token: 0x04034F82 RID: 216962
		[Token(Token = "0x4034F82")]
		[FieldOffset(Offset = "0x20")]
		public float m_lvl;

		// Token: 0x04034F83 RID: 216963
		[Token(Token = "0x4034F83")]
		[FieldOffset(Offset = "0x24")]
		public float m_friendship;

		// Token: 0x04034F84 RID: 216964
		[Token(Token = "0x4034F84")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public int m_coorX;

		// Token: 0x04034F85 RID: 216965
		[Token(Token = "0x4034F85")]
		[FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		public int m_coorY;

		// Token: 0x04034F86 RID: 216966
		[Token(Token = "0x4034F86")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private HandBookCardView[] _relations;

		// Token: 0x04034F87 RID: 216967
		[Token(Token = "0x4034F87")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Animator _cardScaleAnimator;

		// Token: 0x04034F88 RID: 216968
		[Token(Token = "0x4034F88")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _charHeadIconGrey;

		// Token: 0x04034F89 RID: 216969
		[Token(Token = "0x4034F89")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _charHeadIcon;

		// Token: 0x04034F8A RID: 216970
		[Token(Token = "0x4034F8A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _smallIcon;

		// Token: 0x04034F8B RID: 216971
		[Token(Token = "0x4034F8B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _nameText;

		// Token: 0x04034F8C RID: 216972
		[Token(Token = "0x4034F8C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _numberShow;

		// Token: 0x04034F8D RID: 216973
		[Token(Token = "0x4034F8D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _selected;

		// Token: 0x04034F8E RID: 216974
		[Token(Token = "0x4034F8E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _haveMoreLine;

		// Token: 0x04034F8F RID: 216975
		[Token(Token = "0x4034F8F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UICommonTrackPoint _updatedTrackPoint;

		// Token: 0x04034F90 RID: 216976
		[Token(Token = "0x4034F90")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _trackStartPos;

		// Token: 0x04034F91 RID: 216977
		[Token(Token = "0x4034F91")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float _trackEndPos;

		// Token: 0x04034F92 RID: 216978
		[Token(Token = "0x4034F92")]
		[FieldOffset(Offset = "0x88")]
		[HideInInspector]
		public List<HandBookLineViewModel> lines;

		// Token: 0x04034F93 RID: 216979
		[Token(Token = "0x4034F93")]
		[FieldOffset(Offset = "0x90")]
		private TrackPointViewProperty m_updatedTrackPointProperty;

		// Token: 0x04034F94 RID: 216980
		[Token(Token = "0x4034F94")]
		[FieldOffset(Offset = "0x98")]
		private HandBookCardViewModel m_cardData;

		// Token: 0x04034F95 RID: 216981
		[Token(Token = "0x4034F95")]
		[FieldOffset(Offset = "0xA0")]
		private HandBookScrollView m_parentView;

		// Token: 0x04034F97 RID: 216983
		[Token(Token = "0x4034F97")]
		[FieldOffset(Offset = "0xAC")]
		private Vector3 m_initPos;

		// Token: 0x04034F98 RID: 216984
		[Token(Token = "0x4034F98")]
		[FieldOffset(Offset = "0xB8")]
		private string m_powerId;

		// Token: 0x04034F99 RID: 216985
		[Token(Token = "0x4034F99")]
		[FieldOffset(Offset = "0xC0")]
		private float m_propertyZoomValue;

		// Token: 0x04034F9A RID: 216986
		[Token(Token = "0x4034F9A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cardData;

		// Token: 0x04034F9B RID: 216987
		[Token(Token = "0x4034F9B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_parentView;

		// Token: 0x04034F9C RID: 216988
		[Token(Token = "0x4034F9C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_detailFlag;

		// Token: 0x04034F9D RID: 216989
		[Token(Token = "0x4034F9D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_detailFlag;

		// Token: 0x04034F9E RID: 216990
		[Token(Token = "0x4034F9E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_initPos;

		// Token: 0x04034F9F RID: 216991
		[Token(Token = "0x4034F9F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_initPos;

		// Token: 0x04034FA0 RID: 216992
		[Token(Token = "0x4034FA0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_lvl;

		// Token: 0x04034FA1 RID: 216993
		[Token(Token = "0x4034FA1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_lvl;

		// Token: 0x04034FA2 RID: 216994
		[Token(Token = "0x4034FA2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_charID;

		// Token: 0x04034FA3 RID: 216995
		[Token(Token = "0x4034FA3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_charID;

		// Token: 0x04034FA4 RID: 216996
		[Token(Token = "0x4034FA4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_powerId;

		// Token: 0x04034FA5 RID: 216997
		[Token(Token = "0x4034FA5")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_selected;

		// Token: 0x04034FA6 RID: 216998
		[Token(Token = "0x4034FA6")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_zoomValue;

		// Token: 0x04034FA7 RID: 216999
		[Token(Token = "0x4034FA7")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_zoomValue;

		// Token: 0x04034FA8 RID: 217000
		[Token(Token = "0x4034FA8")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_MoveFirstThread;

		// Token: 0x04034FA9 RID: 217001
		[Token(Token = "0x4034FA9")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_MoveSecondThread;

		// Token: 0x04034FAA RID: 217002
		[Token(Token = "0x4034FAA")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_MoveThirdThread;

		// Token: 0x04034FAB RID: 217003
		[Token(Token = "0x4034FAB")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_MoveForthThread;

		// Token: 0x04034FAC RID: 217004
		[Token(Token = "0x4034FAC")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnValueRefresh;

		// Token: 0x04034FAD RID: 217005
		[Token(Token = "0x4034FAD")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04034FAE RID: 217006
		[Token(Token = "0x4034FAE")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__MoveSecondThread;

		// Token: 0x04034FAF RID: 217007
		[Token(Token = "0x4034FAF")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__MoveFirstThread;

		// Token: 0x04034FB0 RID: 217008
		[Token(Token = "0x4034FB0")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__MoveMiddleFirstThread;

		// Token: 0x04034FB1 RID: 217009
		[Token(Token = "0x4034FB1")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04034FB2 RID: 217010
		[Token(Token = "0x4034FB2")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix1_LoadData;

		// Token: 0x04034FB3 RID: 217011
		[Token(Token = "0x4034FB3")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_UpdateTrackPoint;

		// Token: 0x04034FB4 RID: 217012
		[Token(Token = "0x4034FB4")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_SetActiveFalse;

		// Token: 0x04034FB5 RID: 217013
		[Token(Token = "0x4034FB5")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_OnClicked;

		// Token: 0x04034FB6 RID: 217014
		[Token(Token = "0x4034FB6")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
