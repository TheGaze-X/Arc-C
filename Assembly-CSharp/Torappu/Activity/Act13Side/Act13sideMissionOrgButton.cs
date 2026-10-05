using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x02007A37 RID: 31287
	[Token(Token = "0x2007A37")]
	public class Act13sideMissionOrgButton : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602BD67 RID: 179559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD67")]
		[Address(RVA = "0x27CC450", Offset = "0x27CB050", VA = "0x1827CC450")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602BD68 RID: 179560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD68")]
		[Address(RVA = "0x27CC280", Offset = "0x27CAE80", VA = "0x1827CC280")]
		public void Init(string actId, string org_, UIStringEvent onClick)
		{
		}

		// Token: 0x0602BD69 RID: 179561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD69")]
		[Address(RVA = "0x27CC0A0", Offset = "0x27CACA0", VA = "0x1827CC0A0")]
		public void ApplySelect(string actId, string currentOrg, bool haveReward, bool isTimely)
		{
		}

		// Token: 0x0602BD6A RID: 179562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD6A")]
		[Address(RVA = "0x27CC3B0", Offset = "0x27CAFB0", VA = "0x1827CC3B0")]
		public void OnClick()
		{
		}

		// Token: 0x0602BD6B RID: 179563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD6B")]
		[Address(RVA = "0x27CC580", Offset = "0x27CB180", VA = "0x1827CC580")]
		public Act13sideMissionOrgButton()
		{
		}

		// Token: 0x0403F753 RID: 259923
		[Token(Token = "0x403F753")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _orgImg;

		// Token: 0x0403F754 RID: 259924
		[Token(Token = "0x403F754")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _activeToggle;

		// Token: 0x0403F755 RID: 259925
		[Token(Token = "0x403F755")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _unlockPart;

		// Token: 0x0403F756 RID: 259926
		[Token(Token = "0x403F756")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UICommonTrackPoint _trackPoint;

		// Token: 0x0403F757 RID: 259927
		[Token(Token = "0x403F757")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UICommonTrackPoint _newTrackPoint;

		// Token: 0x0403F758 RID: 259928
		[Token(Token = "0x403F758")]
		[FieldOffset(Offset = "0x40")]
		private TrackPointViewProperty m_property;

		// Token: 0x0403F759 RID: 259929
		[Token(Token = "0x403F759")]
		[FieldOffset(Offset = "0x48")]
		private TrackPointViewProperty m_newProperty;

		// Token: 0x0403F75A RID: 259930
		[Token(Token = "0x403F75A")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x0403F75B RID: 259931
		[Token(Token = "0x403F75B")]
		[FieldOffset(Offset = "0x58")]
		private UIStringEvent m_onClick;

		// Token: 0x0403F75C RID: 259932
		[Token(Token = "0x403F75C")]
		[FieldOffset(Offset = "0x60")]
		private string m_targetOrg;

		// Token: 0x0403F75D RID: 259933
		[Token(Token = "0x403F75D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403F75E RID: 259934
		[Token(Token = "0x403F75E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0403F75F RID: 259935
		[Token(Token = "0x403F75F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ApplySelect;

		// Token: 0x0403F760 RID: 259936
		[Token(Token = "0x403F760")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403F761 RID: 259937
		[Token(Token = "0x403F761")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
