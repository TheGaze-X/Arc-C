using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act17side
{
	// Token: 0x020079B1 RID: 31153
	[Token(Token = "0x20079B1")]
	public class Act17sideEntryZoneButtonView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17006676 RID: 26230
		// (get) Token: 0x0602BB26 RID: 178982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006676")]
		public string zoneId
		{
			[Token(Token = "0x602BB26")]
			[Address(RVA = "0x27A4FC0", Offset = "0x27A3BC0", VA = "0x1827A4FC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602BB27 RID: 178983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB27")]
		[Address(RVA = "0x27A4E30", Offset = "0x27A3A30", VA = "0x1827A4E30")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602BB28 RID: 178984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB28")]
		[Address(RVA = "0x27A44A0", Offset = "0x27A30A0", VA = "0x1827A44A0")]
		public void Render(Act17sideActivityZoneGroupViewModel.ZoneViewModel viewModel, bool isAllTimeout)
		{
		}

		// Token: 0x0602BB29 RID: 178985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB29")]
		[Address(RVA = "0x27A4400", Offset = "0x27A3000", VA = "0x1827A4400")]
		public void EventOnClicked()
		{
		}

		// Token: 0x0602BB2A RID: 178986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB2A")]
		[Address(RVA = "0x27A4F60", Offset = "0x27A3B60", VA = "0x1827A4F60")]
		public Act17sideEntryZoneButtonView()
		{
		}

		// Token: 0x0403F380 RID: 258944
		[Token(Token = "0x403F380")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _zoneId;

		// Token: 0x0403F381 RID: 258945
		[Token(Token = "0x403F381")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIStringEvent _onClicked;

		// Token: 0x0403F382 RID: 258946
		[Token(Token = "0x403F382")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textInfo;

		// Token: 0x0403F383 RID: 258947
		[Token(Token = "0x403F383")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _buttonSelf;

		// Token: 0x0403F384 RID: 258948
		[Token(Token = "0x403F384")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _imgNew;

		// Token: 0x0403F385 RID: 258949
		[Token(Token = "0x403F385")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelAccessiable;

		// Token: 0x0403F386 RID: 258950
		[Token(Token = "0x403F386")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelTimeout;

		// Token: 0x0403F387 RID: 258951
		[Token(Token = "0x403F387")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0403F388 RID: 258952
		[Token(Token = "0x403F388")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Track point")]
		private RectTransform _trackPointContainer;

		// Token: 0x0403F389 RID: 258953
		[Token(Token = "0x403F389")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Track point")]
		private GameObject _trackPointPrefab;

		// Token: 0x0403F38A RID: 258954
		[Token(Token = "0x403F38A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Progress")]
		private Text _textProgress;

		// Token: 0x0403F38B RID: 258955
		[Token(Token = "0x403F38B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Progress")]
		private GameObject _panelComplete;

		// Token: 0x0403F38C RID: 258956
		[Token(Token = "0x403F38C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Progress")]
		private Image _progressBar;

		// Token: 0x0403F38D RID: 258957
		[Token(Token = "0x403F38D")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x0403F38E RID: 258958
		[Token(Token = "0x403F38E")]
		[FieldOffset(Offset = "0x88")]
		private GameObject m_trackPoint;

		// Token: 0x0403F38F RID: 258959
		[Token(Token = "0x403F38F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_zoneId;

		// Token: 0x0403F390 RID: 258960
		[Token(Token = "0x403F390")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403F391 RID: 258961
		[Token(Token = "0x403F391")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403F392 RID: 258962
		[Token(Token = "0x403F392")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x0403F393 RID: 258963
		[Token(Token = "0x403F393")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
