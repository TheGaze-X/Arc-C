using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F83 RID: 24451
	[Token(Token = "0x2005F83")]
	public class CharacterInfoHomePotentialView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023606 RID: 144902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023606")]
		[Address(RVA = "0x1DFFCF0", Offset = "0x1DFE8F0", VA = "0x181DFFCF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023607 RID: 144903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023607")]
		[Address(RVA = "0x1DFFC60", Offset = "0x1DFE860", VA = "0x181DFFC60")]
		public void SetArrowTarget(bool isHide)
		{
		}

		// Token: 0x06023608 RID: 144904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023608")]
		[Address(RVA = "0x1DFFA50", Offset = "0x1DFE650", VA = "0x181DFFA50")]
		public void Render(CharacterInfoHolderBean.CharViewModel charViewModel)
		{
		}

		// Token: 0x06023609 RID: 144905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023609")]
		[Address(RVA = "0x1DFFD80", Offset = "0x1DFE980", VA = "0x181DFFD80")]
		public CharacterInfoHomePotentialView()
		{
		}

		// Token: 0x04030DD5 RID: 200149
		[Token(Token = "0x4030DD5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imagePotential;

		// Token: 0x04030DD6 RID: 200150
		[Token(Token = "0x4030DD6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imagePlus;

		// Token: 0x04030DD7 RID: 200151
		[Token(Token = "0x4030DD7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imageMax;

		// Token: 0x04030DD8 RID: 200152
		[Token(Token = "0x4030DD8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _symbolUnapplicable;

		// Token: 0x04030DD9 RID: 200153
		[Token(Token = "0x4030DD9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _potentialTextContainer;

		// Token: 0x04030DDA RID: 200154
		[Token(Token = "0x4030DDA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _downArrow;

		// Token: 0x04030DDB RID: 200155
		[Token(Token = "0x4030DDB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _upArrow;

		// Token: 0x04030DDC RID: 200156
		[Token(Token = "0x4030DDC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UICommonTrackPoint _potentialTrackPoint;

		// Token: 0x04030DDD RID: 200157
		[Token(Token = "0x4030DDD")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public TrackPointViewProperty potentialTrackProp;

		// Token: 0x04030DDE RID: 200158
		[Token(Token = "0x4030DDE")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isInited;

		// Token: 0x04030DDF RID: 200159
		[Token(Token = "0x4030DDF")]
		[FieldOffset(Offset = "0x68")]
		private List<Text> m_potentialText;

		// Token: 0x04030DE0 RID: 200160
		[Token(Token = "0x4030DE0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04030DE1 RID: 200161
		[Token(Token = "0x4030DE1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetArrowTarget;

		// Token: 0x04030DE2 RID: 200162
		[Token(Token = "0x4030DE2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030DE3 RID: 200163
		[Token(Token = "0x4030DE3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
