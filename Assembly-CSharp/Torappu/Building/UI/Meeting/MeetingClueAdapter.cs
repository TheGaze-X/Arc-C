using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D63 RID: 7523
	[Token(Token = "0x2001D63")]
	public class MeetingClueAdapter : LoopScrollAdapter<MeetingClueAdapter.ViewHolder, IMeetingClue>
	{
		// Token: 0x1400005D RID: 93
		// (add) Token: 0x0600B9D2 RID: 47570 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600B9D3 RID: 47571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400005D")]
		public event Action<IMeetingClue, MeetingClueItemView> onClueClicked
		{
			[Token(Token = "0x600B9D2")]
			[Address(RVA = "0x3378610", Offset = "0x3377210", VA = "0x183378610")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600B9D3")]
			[Address(RVA = "0x3378910", Offset = "0x3377510", VA = "0x183378910")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400005E RID: 94
		// (add) Token: 0x0600B9D4 RID: 47572 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600B9D5 RID: 47573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400005E")]
		public event Action<IMeetingClue, MeetingClueItemView> onClueRemoveClicked
		{
			[Token(Token = "0x600B9D4")]
			[Address(RVA = "0x3378710", Offset = "0x3377310", VA = "0x183378710")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600B9D5")]
			[Address(RVA = "0x3378A10", Offset = "0x3377610", VA = "0x183378A10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400005F RID: 95
		// (add) Token: 0x0600B9D6 RID: 47574 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600B9D7 RID: 47575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400005F")]
		public event Action<IMeetingClue, MeetingClueItemView> onClueUnequipClicked
		{
			[Token(Token = "0x600B9D6")]
			[Address(RVA = "0x3378810", Offset = "0x3377410", VA = "0x183378810")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600B9D7")]
			[Address(RVA = "0x3378B10", Offset = "0x3377710", VA = "0x183378B10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001695 RID: 5781
		// (set) Token: 0x0600B9D8 RID: 47576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001695")]
		public IMeetingClue selectedClue
		{
			[Token(Token = "0x600B9D8")]
			[Address(RVA = "0x3378C10", Offset = "0x3377810", VA = "0x183378C10")]
			set
			{
			}
		}

		// Token: 0x0600B9D9 RID: 47577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B9D9")]
		[Address(RVA = "0x3377CC0", Offset = "0x33768C0", VA = "0x183377CC0", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0600B9DA RID: 47578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9DA")]
		[Address(RVA = "0x3377E10", Offset = "0x3376A10", VA = "0x183377E10", Slot = "13")]
		public override void UpdateView(int position, GameObject view, MeetingClueAdapter.ViewHolder holder, IMeetingClue data)
		{
		}

		// Token: 0x0600B9DB RID: 47579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9DB")]
		[Address(RVA = "0x33783B0", Offset = "0x3376FB0", VA = "0x1833783B0")]
		private void _OnClueClicked(IMeetingClue clue, MeetingClueItemView view)
		{
		}

		// Token: 0x0600B9DC RID: 47580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9DC")]
		[Address(RVA = "0x3378450", Offset = "0x3377050", VA = "0x183378450")]
		private void _OnClueRemoveClicked(IMeetingClue clue, MeetingClueItemView view)
		{
		}

		// Token: 0x0600B9DD RID: 47581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9DD")]
		[Address(RVA = "0x33784F0", Offset = "0x33770F0", VA = "0x1833784F0")]
		private void _OnClueUnequipClicked(IMeetingClue clue, MeetingClueItemView view)
		{
		}

		// Token: 0x0600B9DE RID: 47582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9DE")]
		[Address(RVA = "0x3377D80", Offset = "0x3376980", VA = "0x183377D80")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600B9DF RID: 47583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9DF")]
		[Address(RVA = "0x3378590", Offset = "0x3377190", VA = "0x183378590")]
		public MeetingClueAdapter()
		{
		}

		// Token: 0x0400B891 RID: 47249
		[Token(Token = "0x400B891")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _clueProto;

		// Token: 0x0400B892 RID: 47250
		[Token(Token = "0x400B892")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _poolTransform;

		// Token: 0x0400B893 RID: 47251
		[Token(Token = "0x400B893")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private bool _showBonusLabel;

		// Token: 0x0400B894 RID: 47252
		[Token(Token = "0x400B894")]
		[FieldOffset(Offset = "0x69")]
		[SerializeField]
		private bool _showRemoveButton;

		// Token: 0x0400B895 RID: 47253
		[Token(Token = "0x400B895")]
		[FieldOffset(Offset = "0x6C")]
		public int overrideBonus;

		// Token: 0x0400B896 RID: 47254
		[Token(Token = "0x400B896")]
		[FieldOffset(Offset = "0x70")]
		private GameObjectPool m_objectPool;

		// Token: 0x0400B89A RID: 47258
		[Token(Token = "0x400B89A")]
		[FieldOffset(Offset = "0x90")]
		private IMeetingClue m_selectedClue;

		// Token: 0x0400B89B RID: 47259
		[Token(Token = "0x400B89B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_add_onClueClicked;

		// Token: 0x0400B89C RID: 47260
		[Token(Token = "0x400B89C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_remove_onClueClicked;

		// Token: 0x0400B89D RID: 47261
		[Token(Token = "0x400B89D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_add_onClueRemoveClicked;

		// Token: 0x0400B89E RID: 47262
		[Token(Token = "0x400B89E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_remove_onClueRemoveClicked;

		// Token: 0x0400B89F RID: 47263
		[Token(Token = "0x400B89F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_add_onClueUnequipClicked;

		// Token: 0x0400B8A0 RID: 47264
		[Token(Token = "0x400B8A0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_remove_onClueUnequipClicked;

		// Token: 0x0400B8A1 RID: 47265
		[Token(Token = "0x400B8A1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_selectedClue;

		// Token: 0x0400B8A2 RID: 47266
		[Token(Token = "0x400B8A2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x0400B8A3 RID: 47267
		[Token(Token = "0x400B8A3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0400B8A4 RID: 47268
		[Token(Token = "0x400B8A4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnClueClicked;

		// Token: 0x0400B8A5 RID: 47269
		[Token(Token = "0x400B8A5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnClueRemoveClicked;

		// Token: 0x0400B8A6 RID: 47270
		[Token(Token = "0x400B8A6")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnClueUnequipClicked;

		// Token: 0x0400B8A7 RID: 47271
		[Token(Token = "0x400B8A7")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400B8A8 RID: 47272
		[Token(Token = "0x400B8A8")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001D64 RID: 7524
		[Token(Token = "0x2001D64")]
		public class ViewHolder
		{
			// Token: 0x0600B9E0 RID: 47584 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B9E0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}
		}
	}
}
