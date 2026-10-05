using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004227 RID: 16935
	[Token(Token = "0x2004227")]
	public class SandboxV2QuestTrackerView : DataBinder<SandboxV2QuestTrackerProperty>, IHotfixable
	{
		// Token: 0x0601A1F4 RID: 106996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1F4")]
		[Address(RVA = "0x130F020", Offset = "0x130DC20", VA = "0x18130F020", Slot = "7")]
		public override void OnValueChanged(SandboxV2QuestTrackerProperty property)
		{
		}

		// Token: 0x0601A1F5 RID: 106997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1F5")]
		[Address(RVA = "0x130F2B0", Offset = "0x130DEB0", VA = "0x18130F2B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A1F6 RID: 106998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1F6")]
		[Address(RVA = "0x130EF80", Offset = "0x130DB80", VA = "0x18130EF80")]
		public void OnOpenArchive()
		{
		}

		// Token: 0x0601A1F7 RID: 106999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1F7")]
		[Address(RVA = "0x130F3D0", Offset = "0x130DFD0", VA = "0x18130F3D0")]
		public SandboxV2QuestTrackerView()
		{
		}

		// Token: 0x04020F80 RID: 135040
		[Token(Token = "0x4020F80")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x04020F81 RID: 135041
		[Token(Token = "0x4020F81")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x04020F82 RID: 135042
		[Token(Token = "0x4020F82")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x04020F83 RID: 135043
		[Token(Token = "0x4020F83")]
		[FieldOffset(Offset = "0x34")]
		private int m_cachedEnterSeq;

		// Token: 0x04020F84 RID: 135044
		[Token(Token = "0x4020F84")]
		[FieldOffset(Offset = "0x38")]
		private SandboxV2QuestTrackerView.Adapter m_adapter;

		// Token: 0x04020F85 RID: 135045
		[Token(Token = "0x4020F85")]
		[FieldOffset(Offset = "0x40")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04020F86 RID: 135046
		[Token(Token = "0x4020F86")]
		[FieldOffset(Offset = "0x50")]
		private SandboxV2QuestTrackerViewModel m_cachedViewModel;

		// Token: 0x04020F87 RID: 135047
		[Token(Token = "0x4020F87")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04020F88 RID: 135048
		[Token(Token = "0x4020F88")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020F89 RID: 135049
		[Token(Token = "0x4020F89")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnOpenArchive;

		// Token: 0x04020F8A RID: 135050
		[Token(Token = "0x4020F8A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004228 RID: 16936
		[Token(Token = "0x2004228")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0601A1F8 RID: 107000 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A1F8")]
			[Address(RVA = "0x12FD0C0", Offset = "0x12FBCC0", VA = "0x1812FD0C0")]
			public Adapter(SandboxV2QuestTrackerView closure)
			{
			}

			// Token: 0x17003E1A RID: 15898
			// (get) Token: 0x0601A1F9 RID: 107001 RVA: 0x000A0500 File Offset: 0x0009E700
			[Token(Token = "0x17003E1A")]
			public override int count
			{
				[Token(Token = "0x601A1F9")]
				[Address(RVA = "0x12FD420", Offset = "0x12FC020", VA = "0x1812FD420", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601A1FA RID: 107002 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A1FA")]
			[Address(RVA = "0x12FCAC0", Offset = "0x12FB6C0", VA = "0x1812FCAC0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04020F8B RID: 135051
			[Token(Token = "0x4020F8B")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2QuestTrackerView m_closure;

			// Token: 0x04020F8C RID: 135052
			[Token(Token = "0x4020F8C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04020F8D RID: 135053
			[Token(Token = "0x4020F8D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04020F8E RID: 135054
			[Token(Token = "0x4020F8E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
