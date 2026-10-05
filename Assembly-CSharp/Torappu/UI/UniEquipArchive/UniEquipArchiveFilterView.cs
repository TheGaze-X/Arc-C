using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003BCF RID: 15311
	[Token(Token = "0x2003BCF")]
	public class UniEquipArchiveFilterView : DataBinder<UniEquipArchiveFilterProperty>
	{
		// Token: 0x06017F79 RID: 98169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F79")]
		[Address(RVA = "0x1065010", Offset = "0x1063C10", VA = "0x181065010")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06017F7A RID: 98170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F7A")]
		[Address(RVA = "0x1064C60", Offset = "0x1063860", VA = "0x181064C60", Slot = "7")]
		public override void OnValueChanged(UniEquipArchiveFilterProperty property)
		{
		}

		// Token: 0x06017F7B RID: 98171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F7B")]
		[Address(RVA = "0x10651A0", Offset = "0x1063DA0", VA = "0x1810651A0")]
		private void _MoveCursor(RectTransform target, bool isFastMode)
		{
		}

		// Token: 0x06017F7C RID: 98172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F7C")]
		[Address(RVA = "0x10653F0", Offset = "0x1063FF0", VA = "0x1810653F0")]
		private void _OnToggle(TwoStateToggle.State state)
		{
		}

		// Token: 0x06017F7D RID: 98173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F7D")]
		[Address(RVA = "0x1065470", Offset = "0x1064070", VA = "0x181065470")]
		public UniEquipArchiveFilterView()
		{
		}

		// Token: 0x0401D021 RID: 118817
		[Token(Token = "0x401D021")]
		private const float MOVE_DURATION = 0.35f;

		// Token: 0x0401D022 RID: 118818
		[Token(Token = "0x401D022")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<UniEquipArchiveFilterEquipItem> _equipItems;

		// Token: 0x0401D023 RID: 118819
		[Token(Token = "0x401D023")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle _trackToggle;

		// Token: 0x0401D024 RID: 118820
		[Token(Token = "0x401D024")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelTrack;

		// Token: 0x0401D025 RID: 118821
		[Token(Token = "0x401D025")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _trackNum1;

		// Token: 0x0401D026 RID: 118822
		[Token(Token = "0x401D026")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _trackNum2;

		// Token: 0x0401D027 RID: 118823
		[Token(Token = "0x401D027")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _cursorRect;

		// Token: 0x0401D028 RID: 118824
		[Token(Token = "0x401D028")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _cursorContainer;

		// Token: 0x0401D029 RID: 118825
		[Token(Token = "0x401D029")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public Action<bool> onShowTrackClick;

		// Token: 0x0401D02A RID: 118826
		[Token(Token = "0x401D02A")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public Action<UniEquipArchiveFilterEquipState> onUnlockTabClick;

		// Token: 0x0401D02B RID: 118827
		[Token(Token = "0x401D02B")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isInited;

		// Token: 0x0401D02C RID: 118828
		[Token(Token = "0x401D02C")]
		[FieldOffset(Offset = "0x6C")]
		private int m_fastSeq;

		// Token: 0x0401D02D RID: 118829
		[Token(Token = "0x401D02D")]
		[FieldOffset(Offset = "0x70")]
		private Tween m_moveTween;

		// Token: 0x0401D02E RID: 118830
		[Token(Token = "0x401D02E")]
		[FieldOffset(Offset = "0x78")]
		private RectTransform m_cachedCursorTarget;

		// Token: 0x0401D02F RID: 118831
		[Token(Token = "0x401D02F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D030 RID: 118832
		[Token(Token = "0x401D030")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401D031 RID: 118833
		[Token(Token = "0x401D031")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__MoveCursor;

		// Token: 0x0401D032 RID: 118834
		[Token(Token = "0x401D032")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnToggle;

		// Token: 0x0401D033 RID: 118835
		[Token(Token = "0x401D033")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
