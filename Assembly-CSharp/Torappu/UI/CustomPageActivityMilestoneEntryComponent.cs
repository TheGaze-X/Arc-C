using System;
using Il2CppDummyDll;
using Torappu.Activity;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003AA0 RID: 15008
	[Token(Token = "0x2003AA0")]
	public abstract class CustomPageActivityMilestoneEntryComponent : CustomPageActivityComponent
	{
		// Token: 0x170038E5 RID: 14565
		// (get) Token: 0x06017B67 RID: 97127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170038E5")]
		protected UIActTrackPoint trackPointAvail
		{
			[Token(Token = "0x6017B67")]
			[Address(RVA = "0xFE5CE0", Offset = "0xFE48E0", VA = "0x180FE5CE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170038E6 RID: 14566
		// (get) Token: 0x06017B68 RID: 97128 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06017B69 RID: 97129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170038E6")]
		protected TrackPointViewProperty availProperty
		{
			[Token(Token = "0x6017B68")]
			[Address(RVA = "0xFE5C80", Offset = "0xFE4880", VA = "0x180FE5C80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6017B69")]
			[Address(RVA = "0xFE5D40", Offset = "0xFE4940", VA = "0x180FE5D40")]
			set
			{
			}
		}

		// Token: 0x06017B6A RID: 97130
		[Token(Token = "0x6017B6A")]
		protected abstract void OnViewModelRefresh(TemplateActivityMilestoneGroupViewModel viewModel);

		// Token: 0x06017B6B RID: 97131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B6B")]
		[Address(RVA = "0xFE5B00", Offset = "0xFE4700", VA = "0x180FE5B00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06017B6C RID: 97132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B6C")]
		[Address(RVA = "0xFE5890", Offset = "0xFE4490", VA = "0x180FE5890", Slot = "6")]
		public sealed override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x06017B6D RID: 97133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B6D")]
		[Address(RVA = "0xFE5BE0", Offset = "0xFE47E0", VA = "0x180FE5BE0")]
		protected CustomPageActivityMilestoneEntryComponent()
		{
		}

		// Token: 0x0401C9E2 RID: 117218
		[Token(Token = "0x401C9E2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIActTrackPoint _trackPointAvail;

		// Token: 0x0401C9E3 RID: 117219
		[Token(Token = "0x401C9E3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0401C9E4 RID: 117220
		[Token(Token = "0x401C9E4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelUnlock;

		// Token: 0x0401C9E5 RID: 117221
		[Token(Token = "0x401C9E5")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x0401C9E6 RID: 117222
		[Token(Token = "0x401C9E6")]
		[FieldOffset(Offset = "0x40")]
		private TrackPointViewProperty m_availProperty;

		// Token: 0x0401C9E7 RID: 117223
		[Token(Token = "0x401C9E7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_trackPointAvail;

		// Token: 0x0401C9E8 RID: 117224
		[Token(Token = "0x401C9E8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_availProperty;

		// Token: 0x0401C9E9 RID: 117225
		[Token(Token = "0x401C9E9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_availProperty;

		// Token: 0x0401C9EA RID: 117226
		[Token(Token = "0x401C9EA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401C9EB RID: 117227
		[Token(Token = "0x401C9EB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0401C9EC RID: 117228
		[Token(Token = "0x401C9EC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
