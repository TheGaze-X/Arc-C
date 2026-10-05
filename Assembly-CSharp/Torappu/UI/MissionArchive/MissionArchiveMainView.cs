using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.MissionArchive
{
	// Token: 0x02004849 RID: 18505
	[Token(Token = "0x2004849")]
	public class MissionArchiveMainView : DataBinder<MissionArchiveViewProperty>
	{
		// Token: 0x17004264 RID: 16996
		// (get) Token: 0x0601BF3E RID: 114494 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601BF3F RID: 114495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004264")]
		public Action<string> nodeSelectEvent
		{
			[Token(Token = "0x601BF3E")]
			[Address(RVA = "0x15510D0", Offset = "0x154FCD0", VA = "0x1815510D0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601BF3F")]
			[Address(RVA = "0x1551190", Offset = "0x154FD90", VA = "0x181551190")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004265 RID: 16997
		// (get) Token: 0x0601BF40 RID: 114496 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601BF41 RID: 114497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004265")]
		public Action playHiddenClipsEvent
		{
			[Token(Token = "0x601BF40")]
			[Address(RVA = "0x1551130", Offset = "0x154FD30", VA = "0x181551130")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601BF41")]
			[Address(RVA = "0x1551210", Offset = "0x154FE10", VA = "0x181551210")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601BF42 RID: 114498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF42")]
		[Address(RVA = "0x1550560", Offset = "0x154F160", VA = "0x181550560")]
		public void OnPlayHiddenClipsEvent()
		{
		}

		// Token: 0x0601BF43 RID: 114499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF43")]
		[Address(RVA = "0x1550670", Offset = "0x154F270", VA = "0x181550670", Slot = "7")]
		public override void OnValueChanged(MissionArchiveViewProperty property)
		{
		}

		// Token: 0x0601BF44 RID: 114500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BF44")]
		[Address(RVA = "0x1550C60", Offset = "0x154F860", VA = "0x181550C60")]
		public Tween PlayNodeSelect(string nodeId)
		{
			return null;
		}

		// Token: 0x0601BF45 RID: 114501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF45")]
		[Address(RVA = "0x1550DB0", Offset = "0x154F9B0", VA = "0x181550DB0")]
		public void ResetNodeSelect()
		{
		}

		// Token: 0x0601BF46 RID: 114502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF46")]
		[Address(RVA = "0x1550EC0", Offset = "0x154FAC0", VA = "0x181550EC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BF47 RID: 114503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BF47")]
		[Address(RVA = "0x1551060", Offset = "0x154FC60", VA = "0x181551060")]
		public MissionArchiveMainView()
		{
		}

		// Token: 0x04024736 RID: 149302
		[Token(Token = "0x4024736")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<MissionArchiveNodeView> _nodeViews;

		// Token: 0x04024737 RID: 149303
		[Token(Token = "0x4024737")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _hiddenPanel;

		// Token: 0x04024738 RID: 149304
		[Token(Token = "0x4024738")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x0402473B RID: 149307
		[Token(Token = "0x402473B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_nodeSelectEvent;

		// Token: 0x0402473C RID: 149308
		[Token(Token = "0x402473C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_nodeSelectEvent;

		// Token: 0x0402473D RID: 149309
		[Token(Token = "0x402473D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_playHiddenClipsEvent;

		// Token: 0x0402473E RID: 149310
		[Token(Token = "0x402473E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_playHiddenClipsEvent;

		// Token: 0x0402473F RID: 149311
		[Token(Token = "0x402473F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnPlayHiddenClipsEvent;

		// Token: 0x04024740 RID: 149312
		[Token(Token = "0x4024740")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04024741 RID: 149313
		[Token(Token = "0x4024741")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_PlayNodeSelect;

		// Token: 0x04024742 RID: 149314
		[Token(Token = "0x4024742")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ResetNodeSelect;

		// Token: 0x04024743 RID: 149315
		[Token(Token = "0x4024743")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04024744 RID: 149316
		[Token(Token = "0x4024744")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
