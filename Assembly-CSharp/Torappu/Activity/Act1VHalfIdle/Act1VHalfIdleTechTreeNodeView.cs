using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200780C RID: 30732
	[Token(Token = "0x200780C")]
	public class Act1VHalfIdleTechTreeNodeView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170064E4 RID: 25828
		// (get) Token: 0x0602B1D8 RID: 176600 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B1D7 RID: 176599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170064E4")]
		public Action<string> onClick
		{
			[Token(Token = "0x602B1D8")]
			[Address(RVA = "0x26FDCC0", Offset = "0x26FC8C0", VA = "0x1826FDCC0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602B1D7")]
			[Address(RVA = "0x26FDD20", Offset = "0x26FC920", VA = "0x1826FDD20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602B1D9 RID: 176601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B1D9")]
		[Address(RVA = "0x26FD980", Offset = "0x26FC580", VA = "0x1826FD980")]
		public void RenderView(Act1VHalfIdleTechTreeNodeViewModel model, string selectedId)
		{
		}

		// Token: 0x0602B1DA RID: 176602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B1DA")]
		[Address(RVA = "0x26FDBD0", Offset = "0x26FC7D0", VA = "0x1826FDBD0")]
		private void _SetPos(Vector2 pos)
		{
		}

		// Token: 0x0602B1DB RID: 176603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B1DB")]
		[Address(RVA = "0x26FD8D0", Offset = "0x26FC4D0", VA = "0x1826FD8D0")]
		public void EventOnClick()
		{
		}

		// Token: 0x0602B1DC RID: 176604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B1DC")]
		[Address(RVA = "0x26FDC60", Offset = "0x26FC860", VA = "0x1826FDC60")]
		public Act1VHalfIdleTechTreeNodeView()
		{
		}

		// Token: 0x0403E4E6 RID: 255206
		[Token(Token = "0x403E4E6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _unlockToggle;

		// Token: 0x0403E4E7 RID: 255207
		[Token(Token = "0x403E4E7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image[] _icons;

		// Token: 0x0403E4E8 RID: 255208
		[Token(Token = "0x403E4E8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _canUnlockEffect;

		// Token: 0x0403E4E9 RID: 255209
		[Token(Token = "0x403E4E9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _selectEffect;

		// Token: 0x0403E4EA RID: 255210
		[Token(Token = "0x403E4EA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _unlockAnim;

		// Token: 0x0403E4EB RID: 255211
		[Token(Token = "0x403E4EB")]
		[FieldOffset(Offset = "0x48")]
		private string m_nodeId;

		// Token: 0x0403E4EC RID: 255212
		[Token(Token = "0x403E4EC")]
		[FieldOffset(Offset = "0x50")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403E4ED RID: 255213
		[Token(Token = "0x403E4ED")]
		[FieldOffset(Offset = "0x60")]
		private bool m_oldUnlockState;

		// Token: 0x0403E4EF RID: 255215
		[Token(Token = "0x403E4EF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_onClick;

		// Token: 0x0403E4F0 RID: 255216
		[Token(Token = "0x403E4F0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onClick;

		// Token: 0x0403E4F1 RID: 255217
		[Token(Token = "0x403E4F1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0403E4F2 RID: 255218
		[Token(Token = "0x403E4F2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetPos;

		// Token: 0x0403E4F3 RID: 255219
		[Token(Token = "0x403E4F3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x0403E4F4 RID: 255220
		[Token(Token = "0x403E4F4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
