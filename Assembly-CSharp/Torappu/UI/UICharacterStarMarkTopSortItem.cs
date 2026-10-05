using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003556 RID: 13654
	[Token(Token = "0x2003556")]
	[RequireComponent(typeof(TwoStateToggle))]
	public class UICharacterStarMarkTopSortItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06015C18 RID: 89112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C18")]
		[Address(RVA = "0xE58310", Offset = "0xE56F10", VA = "0x180E58310")]
		public void Render(bool isStarMarkTop)
		{
		}

		// Token: 0x170033AC RID: 13228
		// (set) Token: 0x06015C19 RID: 89113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170033AC")]
		public Action eventOnStarMarkTopClick
		{
			[Token(Token = "0x6015C19")]
			[Address(RVA = "0xE58880", Offset = "0xE57480", VA = "0x180E58880")]
			set
			{
			}
		}

		// Token: 0x170033AD RID: 13229
		// (set) Token: 0x06015C1A RID: 89114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170033AD")]
		public Action eventOnEnterEditMode
		{
			[Token(Token = "0x6015C1A")]
			[Address(RVA = "0xE58800", Offset = "0xE57400", VA = "0x180E58800")]
			set
			{
			}
		}

		// Token: 0x06015C1B RID: 89115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C1B")]
		[Address(RVA = "0xE58290", Offset = "0xE56E90", VA = "0x180E58290")]
		public void EventOnEnterEditMode()
		{
		}

		// Token: 0x06015C1C RID: 89116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C1C")]
		[Address(RVA = "0xE58570", Offset = "0xE57170", VA = "0x180E58570")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06015C1D RID: 89117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C1D")]
		[Address(RVA = "0xE58720", Offset = "0xE57320", VA = "0x180E58720")]
		private void _OnToggle(TwoStateToggle.State state)
		{
		}

		// Token: 0x06015C1E RID: 89118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C1E")]
		[Address(RVA = "0xE587A0", Offset = "0xE573A0", VA = "0x180E587A0")]
		public UICharacterStarMarkTopSortItem()
		{
		}

		// Token: 0x0401A292 RID: 107154
		[Token(Token = "0x401A292")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _starMarkEditBtnAnim;

		// Token: 0x0401A293 RID: 107155
		[Token(Token = "0x401A293")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x0401A294 RID: 107156
		[Token(Token = "0x401A294")]
		[FieldOffset(Offset = "0x30")]
		private TwoStateToggle m_twoStateToggle;

		// Token: 0x0401A295 RID: 107157
		[Token(Token = "0x401A295")]
		[FieldOffset(Offset = "0x38")]
		private Action m_eventStarMarkTopSortClick;

		// Token: 0x0401A296 RID: 107158
		[Token(Token = "0x401A296")]
		[FieldOffset(Offset = "0x40")]
		private Action m_eventEnterEditModeClick;

		// Token: 0x0401A297 RID: 107159
		[Token(Token = "0x401A297")]
		[FieldOffset(Offset = "0x48")]
		private bool m_cachedStarMarkTop;

		// Token: 0x0401A298 RID: 107160
		[Token(Token = "0x401A298")]
		[FieldOffset(Offset = "0x50")]
		private AnimationSwitchTween m_editBtnSwitchTween;

		// Token: 0x0401A299 RID: 107161
		[Token(Token = "0x401A299")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401A29A RID: 107162
		[Token(Token = "0x401A29A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_eventOnStarMarkTopClick;

		// Token: 0x0401A29B RID: 107163
		[Token(Token = "0x401A29B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_eventOnEnterEditMode;

		// Token: 0x0401A29C RID: 107164
		[Token(Token = "0x401A29C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnEnterEditMode;

		// Token: 0x0401A29D RID: 107165
		[Token(Token = "0x401A29D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401A29E RID: 107166
		[Token(Token = "0x401A29E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnToggle;

		// Token: 0x0401A29F RID: 107167
		[Token(Token = "0x401A29F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
