using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CGGallery
{
	// Token: 0x02006008 RID: 24584
	[Token(Token = "0x2006008")]
	public class CGGalleryCollectionState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x060238A2 RID: 145570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60238A2")]
		[Address(RVA = "0x1E2CE00", Offset = "0x1E2BA00", VA = "0x181E2CE00", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060238A3 RID: 145571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60238A3")]
		[Address(RVA = "0x1E2D3A0", Offset = "0x1E2BFA0", VA = "0x181E2D3A0", Slot = "19")]
		protected override IEnumerator OnPreload()
		{
			return null;
		}

		// Token: 0x060238A4 RID: 145572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238A4")]
		[Address(RVA = "0x1E2CE60", Offset = "0x1E2BA60", VA = "0x181E2CE60", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060238A5 RID: 145573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238A5")]
		[Address(RVA = "0x1E2D1F0", Offset = "0x1E2BDF0", VA = "0x181E2D1F0", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x060238A6 RID: 145574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238A6")]
		[Address(RVA = "0x1E2D110", Offset = "0x1E2BD10", VA = "0x181E2D110", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x060238A7 RID: 145575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238A7")]
		[Address(RVA = "0x1E2CF20", Offset = "0x1E2BB20", VA = "0x181E2CF20", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x060238A8 RID: 145576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238A8")]
		[Address(RVA = "0x1E2D430", Offset = "0x1E2C030", VA = "0x181E2D430")]
		public void ToFavouriteFilterMode()
		{
		}

		// Token: 0x060238A9 RID: 145577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238A9")]
		[Address(RVA = "0x1E2D5F0", Offset = "0x1E2C1F0", VA = "0x181E2D5F0")]
		public void ToStorylineFilterMode()
		{
		}

		// Token: 0x060238AA RID: 145578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238AA")]
		[Address(RVA = "0x1E2D040", Offset = "0x1E2BC40", VA = "0x181E2D040", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x060238AB RID: 145579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238AB")]
		[Address(RVA = "0x1E2D950", Offset = "0x1E2C550", VA = "0x181E2D950")]
		private void _OnInspectDisplay(string displayId)
		{
		}

		// Token: 0x060238AC RID: 145580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238AC")]
		[Address(RVA = "0x1E2DC40", Offset = "0x1E2C840", VA = "0x181E2DC40")]
		private void _PresetInspectForFilterChange(CGGalleryFilterMode to)
		{
		}

		// Token: 0x060238AD RID: 145581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238AD")]
		[Address(RVA = "0x1E2D7D0", Offset = "0x1E2C3D0", VA = "0x181E2D7D0")]
		private void _FocusDisplay()
		{
		}

		// Token: 0x060238AE RID: 145582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238AE")]
		[Address(RVA = "0x1E2DED0", Offset = "0x1E2CAD0", VA = "0x181E2DED0")]
		public CGGalleryCollectionState()
		{
		}

		// Token: 0x060238AF RID: 145583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60238AF")]
		[Address(RVA = "0x15A0840", Offset = "0x159F440", VA = "0x1815A0840")]
		private IEnumerator <>xLuaBaseProxy_OnPreload()
		{
			return null;
		}

		// Token: 0x060238B0 RID: 145584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238B0")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060238B1 RID: 145585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238B1")]
		[Address(RVA = "0x1061490", Offset = "0x1060090", VA = "0x181061490")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x060238B2 RID: 145586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238B2")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x060238B3 RID: 145587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60238B3")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x040312D0 RID: 201424
		[Token(Token = "0x40312D0")]
		[NonSerialized]
		private const string MUSIC_ID = "music_bg_tech";

		// Token: 0x040312D1 RID: 201425
		[Token(Token = "0x40312D1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CGGalleryCollectionView _view;

		// Token: 0x040312D2 RID: 201426
		[Token(Token = "0x40312D2")]
		[FieldOffset(Offset = "0x78")]
		private CGGalleryPage m_page;

		// Token: 0x040312D3 RID: 201427
		[Token(Token = "0x40312D3")]
		[FieldOffset(Offset = "0x80")]
		private string m_storylineLastLocatedDisplayId;

		// Token: 0x040312D4 RID: 201428
		[Token(Token = "0x40312D4")]
		[FieldOffset(Offset = "0x88")]
		private bool m_blockInspect;

		// Token: 0x040312D5 RID: 201429
		[Token(Token = "0x40312D5")]
		[FieldOffset(Offset = "0x8C")]
		private int m_blockSequence;

		// Token: 0x040312D6 RID: 201430
		[Token(Token = "0x40312D6")]
		[NonSerialized]
		public const int MSG_INSPECT_DISPLAY = 0;

		// Token: 0x040312D7 RID: 201431
		[Token(Token = "0x40312D7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040312D8 RID: 201432
		[Token(Token = "0x40312D8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPreload;

		// Token: 0x040312D9 RID: 201433
		[Token(Token = "0x40312D9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040312DA RID: 201434
		[Token(Token = "0x40312DA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x040312DB RID: 201435
		[Token(Token = "0x40312DB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x040312DC RID: 201436
		[Token(Token = "0x40312DC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x040312DD RID: 201437
		[Token(Token = "0x40312DD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ToFavouriteFilterMode;

		// Token: 0x040312DE RID: 201438
		[Token(Token = "0x40312DE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ToStorylineFilterMode;

		// Token: 0x040312DF RID: 201439
		[Token(Token = "0x40312DF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x040312E0 RID: 201440
		[Token(Token = "0x40312E0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnInspectDisplay;

		// Token: 0x040312E1 RID: 201441
		[Token(Token = "0x40312E1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__PresetInspectForFilterChange;

		// Token: 0x040312E2 RID: 201442
		[Token(Token = "0x40312E2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__FocusDisplay;

		// Token: 0x040312E3 RID: 201443
		[Token(Token = "0x40312E3")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
