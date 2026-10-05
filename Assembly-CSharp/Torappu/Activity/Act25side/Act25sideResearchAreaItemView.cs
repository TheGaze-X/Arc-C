using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x02007515 RID: 29973
	[Token(Token = "0x2007515")]
	public class Act25sideResearchAreaItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A3DA RID: 173018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3DA")]
		[Address(RVA = "0x25E0D10", Offset = "0x25DF910", VA = "0x1825E0D10")]
		public void Render(Act25sideAreaViewModel viewModel, string selectedArea)
		{
		}

		// Token: 0x0602A3DB RID: 173019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3DB")]
		[Address(RVA = "0x25E12D0", Offset = "0x25DFED0", VA = "0x1825E12D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A3DC RID: 173020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3DC")]
		[Address(RVA = "0x25E0A40", Offset = "0x25DF640", VA = "0x1825E0A40")]
		public void OnItemSelect()
		{
		}

		// Token: 0x0602A3DD RID: 173021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3DD")]
		[Address(RVA = "0x25E14B0", Offset = "0x25E00B0", VA = "0x1825E14B0")]
		public Act25sideResearchAreaItemView()
		{
		}

		// Token: 0x0403CB5D RID: 248669
		[Token(Token = "0x403CB5D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _areaName;

		// Token: 0x0403CB5E RID: 248670
		[Token(Token = "0x403CB5E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _areaProgress;

		// Token: 0x0403CB5F RID: 248671
		[Token(Token = "0x403CB5F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelNew;

		// Token: 0x0403CB60 RID: 248672
		[Token(Token = "0x403CB60")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelComplete;

		// Token: 0x0403CB61 RID: 248673
		[Token(Token = "0x403CB61")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelProgress;

		// Token: 0x0403CB62 RID: 248674
		[Token(Token = "0x403CB62")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelSelect;

		// Token: 0x0403CB63 RID: 248675
		[Token(Token = "0x403CB63")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelUnselect;

		// Token: 0x0403CB64 RID: 248676
		[Token(Token = "0x403CB64")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0403CB65 RID: 248677
		[Token(Token = "0x403CB65")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _selectAnim;

		// Token: 0x0403CB66 RID: 248678
		[Token(Token = "0x403CB66")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UICommonTrackPoint _commonTrackPoint;

		// Token: 0x0403CB67 RID: 248679
		[Token(Token = "0x403CB67")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isInited;

		// Token: 0x0403CB68 RID: 248680
		[Token(Token = "0x403CB68")]
		[FieldOffset(Offset = "0x78")]
		private Act25sideAreaViewModel m_cachedViewModel;

		// Token: 0x0403CB69 RID: 248681
		[Token(Token = "0x403CB69")]
		[FieldOffset(Offset = "0x80")]
		private AnimationSwitchTween m_switchTween;

		// Token: 0x0403CB6A RID: 248682
		[Token(Token = "0x403CB6A")]
		[FieldOffset(Offset = "0x88")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403CB6B RID: 248683
		[Token(Token = "0x403CB6B")]
		[FieldOffset(Offset = "0x98")]
		private TrackPointViewProperty m_trackPointProperty;

		// Token: 0x0403CB6C RID: 248684
		[Token(Token = "0x403CB6C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403CB6D RID: 248685
		[Token(Token = "0x403CB6D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403CB6E RID: 248686
		[Token(Token = "0x403CB6E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnItemSelect;

		// Token: 0x0403CB6F RID: 248687
		[Token(Token = "0x403CB6F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
