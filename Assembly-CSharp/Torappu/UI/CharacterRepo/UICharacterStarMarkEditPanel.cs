using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterRepo
{
	// Token: 0x02005E3D RID: 24125
	[Token(Token = "0x2005E3D")]
	public class UICharacterStarMarkEditPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x170052DC RID: 21212
		// (get) Token: 0x06022F49 RID: 143177 RVA: 0x000BF988 File Offset: 0x000BDB88
		// (set) Token: 0x06022F4A RID: 143178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170052DC")]
		public bool isShow
		{
			[Token(Token = "0x6022F49")]
			[Address(RVA = "0x1D8E410", Offset = "0x1D8D010", VA = "0x181D8E410")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6022F4A")]
			[Address(RVA = "0x1D8E470", Offset = "0x1D8D070", VA = "0x181D8E470")]
			set
			{
			}
		}

		// Token: 0x06022F4B RID: 143179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F4B")]
		[Address(RVA = "0x1D8DFF0", Offset = "0x1D8CBF0", VA = "0x181D8DFF0")]
		public void Render(int starMarkCnt)
		{
		}

		// Token: 0x06022F4C RID: 143180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F4C")]
		[Address(RVA = "0x1D8DEE0", Offset = "0x1D8CAE0", VA = "0x181D8DEE0")]
		public void EventOnConfirmEdit()
		{
		}

		// Token: 0x06022F4D RID: 143181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F4D")]
		[Address(RVA = "0x1D8DE40", Offset = "0x1D8CA40", VA = "0x181D8DE40")]
		public void EventOnClearMarks()
		{
		}

		// Token: 0x06022F4E RID: 143182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F4E")]
		[Address(RVA = "0x1D8DF80", Offset = "0x1D8CB80", VA = "0x181D8DF80")]
		public void OnExitEditMode()
		{
		}

		// Token: 0x06022F4F RID: 143183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F4F")]
		[Address(RVA = "0x1D8E2A0", Offset = "0x1D8CEA0", VA = "0x181D8E2A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022F50 RID: 143184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F50")]
		[Address(RVA = "0x1D8E1A0", Offset = "0x1D8CDA0", VA = "0x181D8E1A0")]
		private void _EnsureSwitchTween()
		{
		}

		// Token: 0x06022F51 RID: 143185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F51")]
		[Address(RVA = "0x1D8E3B0", Offset = "0x1D8CFB0", VA = "0x181D8E3B0")]
		public UICharacterStarMarkEditPanel()
		{
		}

		// Token: 0x0403028E RID: 197262
		[Token(Token = "0x403028E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _starMarkCount;

		// Token: 0x0403028F RID: 197263
		[Token(Token = "0x403028F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _starMarkEditSwitchAnim;

		// Token: 0x04030290 RID: 197264
		[Token(Token = "0x4030290")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _backPressRt;

		// Token: 0x04030291 RID: 197265
		[Token(Token = "0x4030291")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public Action eventOnStarMarkEditConfirm;

		// Token: 0x04030292 RID: 197266
		[Token(Token = "0x4030292")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Action eventOnClearAllStarMark;

		// Token: 0x04030293 RID: 197267
		[Token(Token = "0x4030293")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public Action eventOnExitEditMode;

		// Token: 0x04030294 RID: 197268
		[Token(Token = "0x4030294")]
		[FieldOffset(Offset = "0x50")]
		private bool m_panelShowed;

		// Token: 0x04030295 RID: 197269
		[Token(Token = "0x4030295")]
		[FieldOffset(Offset = "0x51")]
		private bool m_isInited;

		// Token: 0x04030296 RID: 197270
		[Token(Token = "0x4030296")]
		[FieldOffset(Offset = "0x58")]
		private AnimationSwitchTween m_starMarkEditModeSwitch;

		// Token: 0x04030297 RID: 197271
		[Token(Token = "0x4030297")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04030298 RID: 197272
		[Token(Token = "0x4030298")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isShow;

		// Token: 0x04030299 RID: 197273
		[Token(Token = "0x4030299")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403029A RID: 197274
		[Token(Token = "0x403029A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnConfirmEdit;

		// Token: 0x0403029B RID: 197275
		[Token(Token = "0x403029B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnClearMarks;

		// Token: 0x0403029C RID: 197276
		[Token(Token = "0x403029C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnExitEditMode;

		// Token: 0x0403029D RID: 197277
		[Token(Token = "0x403029D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403029E RID: 197278
		[Token(Token = "0x403029E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__EnsureSwitchTween;

		// Token: 0x0403029F RID: 197279
		[Token(Token = "0x403029F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
