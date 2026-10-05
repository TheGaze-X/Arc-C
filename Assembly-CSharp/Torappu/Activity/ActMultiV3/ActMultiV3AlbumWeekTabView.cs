using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F5E RID: 28510
	[Token(Token = "0x2006F5E")]
	public class ActMultiV3AlbumWeekTabView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060287C1 RID: 165825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287C1")]
		[Address(RVA = "0x23BFBD0", Offset = "0x23BE7D0", VA = "0x1823BFBD0")]
		public void Render(ActMultiV3WeekAlbumViewModel model, int selectedTabIdx, bool isFirstUpdate)
		{
		}

		// Token: 0x060287C2 RID: 165826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287C2")]
		[Address(RVA = "0x23BFAF0", Offset = "0x23BE6F0", VA = "0x1823BFAF0")]
		public void OnClickTab()
		{
		}

		// Token: 0x060287C3 RID: 165827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287C3")]
		[Address(RVA = "0x23BFFB0", Offset = "0x23BEBB0", VA = "0x1823BFFB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060287C4 RID: 165828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287C4")]
		[Address(RVA = "0x23C0160", Offset = "0x23BED60", VA = "0x1823C0160")]
		public ActMultiV3AlbumWeekTabView()
		{
		}

		// Token: 0x04039990 RID: 235920
		[Token(Token = "0x4039990")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _selectAnimLocation;

		// Token: 0x04039991 RID: 235921
		[Token(Token = "0x4039991")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle _lockToggle;

		// Token: 0x04039992 RID: 235922
		[Token(Token = "0x4039992")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _selectHotspotGo;

		// Token: 0x04039993 RID: 235923
		[Token(Token = "0x4039993")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TwoStateToggle _markToggle;

		// Token: 0x04039994 RID: 235924
		[Token(Token = "0x4039994")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _titleNumberText;

		// Token: 0x04039995 RID: 235925
		[Token(Token = "0x4039995")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _lockedTitleDescText;

		// Token: 0x04039996 RID: 235926
		[Token(Token = "0x4039996")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _titleDescText;

		// Token: 0x04039997 RID: 235927
		[Token(Token = "0x4039997")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _trackPointContainer;

		// Token: 0x04039998 RID: 235928
		[Token(Token = "0x4039998")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _trackPointObj;

		// Token: 0x04039999 RID: 235929
		[Token(Token = "0x4039999")]
		[FieldOffset(Offset = "0x68")]
		private bool m_inited;

		// Token: 0x0403999A RID: 235930
		[Token(Token = "0x403999A")]
		[FieldOffset(Offset = "0x70")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403999B RID: 235931
		[Token(Token = "0x403999B")]
		[FieldOffset(Offset = "0x80")]
		private UISwitchTween m_selectTween;

		// Token: 0x0403999C RID: 235932
		[Token(Token = "0x403999C")]
		[FieldOffset(Offset = "0x88")]
		private int m_cachedTabIndex;

		// Token: 0x0403999D RID: 235933
		[Token(Token = "0x403999D")]
		[FieldOffset(Offset = "0x90")]
		private GameObject m_trackPoint;

		// Token: 0x0403999E RID: 235934
		[Token(Token = "0x403999E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403999F RID: 235935
		[Token(Token = "0x403999F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClickTab;

		// Token: 0x040399A0 RID: 235936
		[Token(Token = "0x40399A0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040399A1 RID: 235937
		[Token(Token = "0x40399A1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
