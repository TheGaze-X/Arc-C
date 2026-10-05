using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001EDC RID: 7900
	[Token(Token = "0x2001EDC")]
	[RequireComponent(typeof(CanvasGroup))]
	public class SubtitlePanel : ExecutorComponent
	{
		// Token: 0x0600C418 RID: 50200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C418")]
		[Address(RVA = "0x34352C0", Offset = "0x3433EC0", VA = "0x1834352C0", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x1700176D RID: 5997
		// (get) Token: 0x0600C419 RID: 50201 RVA: 0x00047FB8 File Offset: 0x000461B8
		// (set) Token: 0x0600C41A RID: 50202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700176D")]
		public bool isHidden
		{
			[Token(Token = "0x600C419")]
			[Address(RVA = "0x3436410", Offset = "0x3435010", VA = "0x183436410")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600C41A")]
			[Address(RVA = "0x34364E0", Offset = "0x34350E0", VA = "0x1834364E0")]
			private set
			{
			}
		}

		// Token: 0x1700176E RID: 5998
		// (get) Token: 0x0600C41B RID: 50203 RVA: 0x00047FD0 File Offset: 0x000461D0
		[Token(Token = "0x1700176E")]
		public bool isTyping
		{
			[Token(Token = "0x600C41B")]
			[Address(RVA = "0x3436470", Offset = "0x3435070", VA = "0x183436470")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600C41C RID: 50204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C41C")]
		[Address(RVA = "0x3435170", Offset = "0x3433D70", VA = "0x183435170")]
		private void Awake()
		{
		}

		// Token: 0x0600C41D RID: 50205 RVA: 0x00047FE8 File Offset: 0x000461E8
		[Token(Token = "0x600C41D")]
		[Address(RVA = "0x34358D0", Offset = "0x34344D0", VA = "0x1834358D0")]
		protected bool _ExecuteSubtitle(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C41E RID: 50206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C41E")]
		[Address(RVA = "0x3435FE0", Offset = "0x3434BE0", VA = "0x183435FE0")]
		private void _OnTypeWriterEnd()
		{
		}

		// Token: 0x0600C41F RID: 50207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C41F")]
		[Address(RVA = "0x3435250", Offset = "0x3433E50", VA = "0x183435250", Slot = "12")]
		protected override void ForceCommandEnd()
		{
		}

		// Token: 0x0600C420 RID: 50208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C420")]
		[Address(RVA = "0x3435EE0", Offset = "0x3434AE0", VA = "0x183435EE0", Slot = "13")]
		protected virtual void _OnClicked(object arg)
		{
		}

		// Token: 0x0600C421 RID: 50209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C421")]
		[Address(RVA = "0x3435730", Offset = "0x3434330", VA = "0x183435730", Slot = "5")]
		public override void OnStoryBegin(Story story)
		{
		}

		// Token: 0x0600C422 RID: 50210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C422")]
		[Address(RVA = "0x34353E0", Offset = "0x3433FE0", VA = "0x1834353E0", Slot = "11")]
		protected override void OnFinish()
		{
		}

		// Token: 0x0600C423 RID: 50211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C423")]
		[Address(RVA = "0x3435500", Offset = "0x3434100", VA = "0x183435500", Slot = "7")]
		public override void OnReset()
		{
		}

		// Token: 0x0600C424 RID: 50212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C424")]
		[Address(RVA = "0x34362E0", Offset = "0x3434EE0", VA = "0x1834362E0")]
		private void _SetTypeWriterDelay(object arg)
		{
		}

		// Token: 0x0600C425 RID: 50213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C425")]
		[Address(RVA = "0x3436150", Offset = "0x3434D50", VA = "0x183436150")]
		private void _SetHiddenInternal(bool value, bool force)
		{
		}

		// Token: 0x0600C426 RID: 50214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C426")]
		[Address(RVA = "0x3436390", Offset = "0x3434F90", VA = "0x183436390")]
		public SubtitlePanel()
		{
		}

		// Token: 0x0600C427 RID: 50215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C427")]
		[Address(RVA = "0x33F0E70", Offset = "0x33EFA70", VA = "0x1833F0E70")]
		private void <>xLuaBaseProxy_OnStoryBegin(Story P0)
		{
		}

		// Token: 0x0600C428 RID: 50216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C428")]
		[Address(RVA = "0x33F4E00", Offset = "0x33F3A00", VA = "0x1833F4E00")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0600C429 RID: 50217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C429")]
		[Address(RVA = "0x1C5FCF0", Offset = "0x1C5E8F0", VA = "0x181C5FCF0")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0400C692 RID: 50834
		[Token(Token = "0x400C692")]
		private const float SCREEN_WIDTH = 1280f;

		// Token: 0x0400C693 RID: 50835
		[Token(Token = "0x400C693")]
		private const float SCREEN_HEIGHT = 720f;

		// Token: 0x0400C694 RID: 50836
		[Token(Token = "0x400C694")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AVGTypeWriterText _typeWriter;

		// Token: 0x0400C695 RID: 50837
		[Token(Token = "0x400C695")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _hideDuration;

		// Token: 0x0400C696 RID: 50838
		[Token(Token = "0x400C696")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _autoWaitBaseTime;

		// Token: 0x0400C697 RID: 50839
		[Token(Token = "0x400C697")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _autoWaitTimePerText;

		// Token: 0x0400C698 RID: 50840
		[Token(Token = "0x400C698")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private Ease _hideEase;

		// Token: 0x0400C699 RID: 50841
		[Token(Token = "0x400C699")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _message;

		// Token: 0x0400C69A RID: 50842
		[Token(Token = "0x400C69A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _textTransform;

		// Token: 0x0400C69B RID: 50843
		[Token(Token = "0x400C69B")]
		[FieldOffset(Offset = "0x78")]
		private bool m_hidden;

		// Token: 0x0400C69C RID: 50844
		[Token(Token = "0x400C69C")]
		[FieldOffset(Offset = "0x80")]
		private CanvasGroup m_CanvasGroup;

		// Token: 0x0400C69D RID: 50845
		[Token(Token = "0x400C69D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x0400C69E RID: 50846
		[Token(Token = "0x400C69E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isHidden;

		// Token: 0x0400C69F RID: 50847
		[Token(Token = "0x400C69F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_isHidden;

		// Token: 0x0400C6A0 RID: 50848
		[Token(Token = "0x400C6A0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isTyping;

		// Token: 0x0400C6A1 RID: 50849
		[Token(Token = "0x400C6A1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0400C6A2 RID: 50850
		[Token(Token = "0x400C6A2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ExecuteSubtitle;

		// Token: 0x0400C6A3 RID: 50851
		[Token(Token = "0x400C6A3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnTypeWriterEnd;

		// Token: 0x0400C6A4 RID: 50852
		[Token(Token = "0x400C6A4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ForceCommandEnd;

		// Token: 0x0400C6A5 RID: 50853
		[Token(Token = "0x400C6A5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnClicked;

		// Token: 0x0400C6A6 RID: 50854
		[Token(Token = "0x400C6A6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnStoryBegin;

		// Token: 0x0400C6A7 RID: 50855
		[Token(Token = "0x400C6A7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0400C6A8 RID: 50856
		[Token(Token = "0x400C6A8")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400C6A9 RID: 50857
		[Token(Token = "0x400C6A9")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__SetTypeWriterDelay;

		// Token: 0x0400C6AA RID: 50858
		[Token(Token = "0x400C6AA")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__SetHiddenInternal;

		// Token: 0x0400C6AB RID: 50859
		[Token(Token = "0x400C6AB")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
