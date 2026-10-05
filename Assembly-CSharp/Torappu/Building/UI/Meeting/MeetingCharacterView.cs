using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D61 RID: 7521
	[Token(Token = "0x2001D61")]
	public class MeetingCharacterView : MonoBehaviour, ITimeWatcher, IHotfixable
	{
		// Token: 0x0600B9C5 RID: 47557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9C5")]
		[Address(RVA = "0x3377430", Offset = "0x3376030", VA = "0x183377430")]
		private void Start()
		{
		}

		// Token: 0x0600B9C6 RID: 47558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9C6")]
		[Address(RVA = "0x3376DA0", Offset = "0x33759A0", VA = "0x183376DA0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600B9C7 RID: 47559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9C7")]
		[Address(RVA = "0x3377490", Offset = "0x3376090", VA = "0x183377490", Slot = "4")]
		public void UpdateTime(float deltaTime)
		{
		}

		// Token: 0x0600B9C8 RID: 47560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B9C8")]
		[Address(RVA = "0x3377510", Offset = "0x3376110", VA = "0x183377510")]
		private IEnumerator _LayoutSetupCoroutine()
		{
			return null;
		}

		// Token: 0x0600B9C9 RID: 47561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9C9")]
		[Address(RVA = "0x3376E00", Offset = "0x3375A00", VA = "0x183376E00")]
		public void Setup(IMeetingStationaryCharacter character)
		{
		}

		// Token: 0x0600B9CA RID: 47562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9CA")]
		[Address(RVA = "0x33775C0", Offset = "0x33761C0", VA = "0x1833775C0")]
		private void _UpdateManpower()
		{
		}

		// Token: 0x0600B9CB RID: 47563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9CB")]
		[Address(RVA = "0x3377BB0", Offset = "0x33767B0", VA = "0x183377BB0")]
		public MeetingCharacterView()
		{
		}

		// Token: 0x0400B877 RID: 47223
		[Token(Token = "0x400B877")]
		private const string NORMAL_COLOR = "#313131";

		// Token: 0x0400B878 RID: 47224
		[Token(Token = "0x400B878")]
		private const string BURNOUT_COLOR = "#c82a36";

		// Token: 0x0400B879 RID: 47225
		[Token(Token = "0x400B879")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _emptyPanel;

		// Token: 0x0400B87A RID: 47226
		[Token(Token = "0x400B87A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _stationPanel;

		// Token: 0x0400B87B RID: 47227
		[Token(Token = "0x400B87B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _imgPortrait;

		// Token: 0x0400B87C RID: 47228
		[Token(Token = "0x400B87C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _name;

		// Token: 0x0400B87D RID: 47229
		[Token(Token = "0x400B87D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BuildingBuffDescView _buffView;

		// Token: 0x0400B87E RID: 47230
		[Token(Token = "0x400B87E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BuildingCharMPStateBar _mpStateBarPrefab;

		// Token: 0x0400B87F RID: 47231
		[Token(Token = "0x400B87F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _mpStateBarContainer;

		// Token: 0x0400B880 RID: 47232
		[Token(Token = "0x400B880")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _apLabel;

		// Token: 0x0400B881 RID: 47233
		[Token(Token = "0x400B881")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _maxApLabel;

		// Token: 0x0400B882 RID: 47234
		[Token(Token = "0x400B882")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _gaugeBackground;

		// Token: 0x0400B883 RID: 47235
		[Token(Token = "0x400B883")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAutoSlideRect _autoSlideRect;

		// Token: 0x0400B884 RID: 47236
		[Token(Token = "0x400B884")]
		[FieldOffset(Offset = "0x70")]
		private BuildingCharMPStateBar m_mpBar;

		// Token: 0x0400B885 RID: 47237
		[Token(Token = "0x400B885")]
		[FieldOffset(Offset = "0x78")]
		private BuildingCharModel m_charModel;

		// Token: 0x0400B886 RID: 47238
		[Token(Token = "0x400B886")]
		[FieldOffset(Offset = "0xF0")]
		private CountDownTask m_mpCountDown;

		// Token: 0x0400B887 RID: 47239
		[Token(Token = "0x400B887")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0400B888 RID: 47240
		[Token(Token = "0x400B888")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400B889 RID: 47241
		[Token(Token = "0x400B889")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateTime;

		// Token: 0x0400B88A RID: 47242
		[Token(Token = "0x400B88A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LayoutSetupCoroutine;

		// Token: 0x0400B88B RID: 47243
		[Token(Token = "0x400B88B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x0400B88C RID: 47244
		[Token(Token = "0x400B88C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateManpower;

		// Token: 0x0400B88D RID: 47245
		[Token(Token = "0x400B88D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
