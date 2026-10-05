using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.Events;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003555 RID: 13653
	[Token(Token = "0x2003555")]
	public class UICharacterStarMarkTopItemBinder : DataBinder<BoolProperty>, IHotfixable
	{
		// Token: 0x06015C15 RID: 89109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C15")]
		[Address(RVA = "0xE57EA0", Offset = "0xE56AA0", VA = "0x180E57EA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06015C16 RID: 89110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C16")]
		[Address(RVA = "0xE57D90", Offset = "0xE56990", VA = "0x180E57D90", Slot = "7")]
		public override void OnValueChanged(BoolProperty property)
		{
		}

		// Token: 0x06015C17 RID: 89111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C17")]
		[Address(RVA = "0xE58220", Offset = "0xE56E20", VA = "0x180E58220")]
		public UICharacterStarMarkTopItemBinder()
		{
		}

		// Token: 0x0401A285 RID: 107141
		[Token(Token = "0x401A285")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _starMarkToggleContainer;

		// Token: 0x0401A286 RID: 107142
		[Token(Token = "0x401A286")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UICharacterStarMarkTopSortItem _starMarkTogglePrefab;

		// Token: 0x0401A287 RID: 107143
		[Token(Token = "0x401A287")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _redPointContainerAnim;

		// Token: 0x0401A288 RID: 107144
		[Token(Token = "0x401A288")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _topbarBgAnim;

		// Token: 0x0401A289 RID: 107145
		[Token(Token = "0x401A289")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UnityEvent _eventStarMarkTopClick;

		// Token: 0x0401A28A RID: 107146
		[Token(Token = "0x401A28A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UnityEvent _eventEnterStarMarkEditMode;

		// Token: 0x0401A28B RID: 107147
		[Token(Token = "0x401A28B")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isInited;

		// Token: 0x0401A28C RID: 107148
		[Token(Token = "0x401A28C")]
		[FieldOffset(Offset = "0x68")]
		private UICharacterStarMarkTopSortItem m_starMarkToggle;

		// Token: 0x0401A28D RID: 107149
		[Token(Token = "0x401A28D")]
		[FieldOffset(Offset = "0x70")]
		private AnimationSwitchTween m_redPointSwitchAnim;

		// Token: 0x0401A28E RID: 107150
		[Token(Token = "0x401A28E")]
		[FieldOffset(Offset = "0x78")]
		private AnimationSwitchTween m_topbarToStarMarkTopSwitchAnim;

		// Token: 0x0401A28F RID: 107151
		[Token(Token = "0x401A28F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401A290 RID: 107152
		[Token(Token = "0x401A290")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401A291 RID: 107153
		[Token(Token = "0x401A291")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
