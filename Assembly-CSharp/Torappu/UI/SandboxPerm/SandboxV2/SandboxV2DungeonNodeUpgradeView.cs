using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004269 RID: 17001
	[Token(Token = "0x2004269")]
	public class SandboxV2DungeonNodeUpgradeView : DataBinder<SandboxV2DungeonNodeUpgradeProperty>
	{
		// Token: 0x17003E3B RID: 15931
		// (get) Token: 0x0601A33D RID: 107325 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601A33E RID: 107326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003E3B")]
		public ILoadAsset assetLoader
		{
			[Token(Token = "0x601A33D")]
			[Address(RVA = "0x131B3C0", Offset = "0x1319FC0", VA = "0x18131B3C0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601A33E")]
			[Address(RVA = "0x131B4E0", Offset = "0x131A0E0", VA = "0x18131B4E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003E3C RID: 15932
		// (get) Token: 0x0601A33F RID: 107327 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601A340 RID: 107328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003E3C")]
		public Action backEvent
		{
			[Token(Token = "0x601A33F")]
			[Address(RVA = "0x131B420", Offset = "0x131A020", VA = "0x18131B420")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601A340")]
			[Address(RVA = "0x131B560", Offset = "0x131A160", VA = "0x18131B560")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003E3D RID: 15933
		// (get) Token: 0x0601A341 RID: 107329 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601A342 RID: 107330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003E3D")]
		public Action workbenchEvent
		{
			[Token(Token = "0x601A341")]
			[Address(RVA = "0x131B480", Offset = "0x131A080", VA = "0x18131B480")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601A342")]
			[Address(RVA = "0x131B5E0", Offset = "0x131A1E0", VA = "0x18131B5E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601A343 RID: 107331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A343")]
		[Address(RVA = "0x131AC70", Offset = "0x1319870", VA = "0x18131AC70")]
		public void OnBackEvent()
		{
		}

		// Token: 0x0601A344 RID: 107332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A344")]
		[Address(RVA = "0x131AD80", Offset = "0x1319980", VA = "0x18131AD80", Slot = "7")]
		public override void OnValueChanged(SandboxV2DungeonNodeUpgradeProperty property)
		{
		}

		// Token: 0x0601A345 RID: 107333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A345")]
		[Address(RVA = "0x131B190", Offset = "0x1319D90", VA = "0x18131B190")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A346 RID: 107334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A346")]
		[Address(RVA = "0x131B010", Offset = "0x1319C10", VA = "0x18131B010")]
		public GameObject TutorialOnly_GetTutorialGo()
		{
			return null;
		}

		// Token: 0x0601A347 RID: 107335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A347")]
		[Address(RVA = "0x131B350", Offset = "0x1319F50", VA = "0x18131B350")]
		public SandboxV2DungeonNodeUpgradeView()
		{
		}

		// Token: 0x04021250 RID: 135760
		[Token(Token = "0x4021250")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _backRect;

		// Token: 0x04021251 RID: 135761
		[Token(Token = "0x4021251")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _itemLayout;

		// Token: 0x04021252 RID: 135762
		[Token(Token = "0x4021252")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x04021253 RID: 135763
		[Token(Token = "0x4021253")]
		[FieldOffset(Offset = "0x38")]
		private SandboxV2DungeonNodeUpgradeView.Adapter m_adapter;

		// Token: 0x04021254 RID: 135764
		[Token(Token = "0x4021254")]
		[FieldOffset(Offset = "0x40")]
		private List<SandboxV2DungeonNodeUpgradeItemViewModel> m_cachedItems;

		// Token: 0x04021258 RID: 135768
		[Token(Token = "0x4021258")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_assetLoader;

		// Token: 0x04021259 RID: 135769
		[Token(Token = "0x4021259")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_assetLoader;

		// Token: 0x0402125A RID: 135770
		[Token(Token = "0x402125A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_backEvent;

		// Token: 0x0402125B RID: 135771
		[Token(Token = "0x402125B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_backEvent;

		// Token: 0x0402125C RID: 135772
		[Token(Token = "0x402125C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_workbenchEvent;

		// Token: 0x0402125D RID: 135773
		[Token(Token = "0x402125D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_workbenchEvent;

		// Token: 0x0402125E RID: 135774
		[Token(Token = "0x402125E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnBackEvent;

		// Token: 0x0402125F RID: 135775
		[Token(Token = "0x402125F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04021260 RID: 135776
		[Token(Token = "0x4021260")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04021261 RID: 135777
		[Token(Token = "0x4021261")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_TutorialOnly_GetTutorialGo;

		// Token: 0x04021262 RID: 135778
		[Token(Token = "0x4021262")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200426A RID: 17002
		[Token(Token = "0x200426A")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17003E3E RID: 15934
			// (get) Token: 0x0601A348 RID: 107336 RVA: 0x000A07A0 File Offset: 0x0009E9A0
			[Token(Token = "0x17003E3E")]
			public override int count
			{
				[Token(Token = "0x601A348")]
				[Address(RVA = "0x1313E60", Offset = "0x1312A60", VA = "0x181313E60", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601A349 RID: 107337 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A349")]
			[Address(RVA = "0x1313C20", Offset = "0x1312820", VA = "0x181313C20")]
			public Adapter(SandboxV2DungeonNodeUpgradeView closure)
			{
			}

			// Token: 0x0601A34A RID: 107338 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A34A")]
			[Address(RVA = "0x13132E0", Offset = "0x1311EE0", VA = "0x1813132E0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601A34B RID: 107339 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A34B")]
			[Address(RVA = "0x13138C0", Offset = "0x13124C0", VA = "0x1813138C0")]
			public GameObject TutorialOnly_GetTutorialGo()
			{
				return null;
			}

			// Token: 0x04021263 RID: 135779
			[Token(Token = "0x4021263")]
			private const int TUTORIAL_ITEM_INDEX = 0;

			// Token: 0x04021264 RID: 135780
			[Token(Token = "0x4021264")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2DungeonNodeUpgradeView m_closure;

			// Token: 0x04021265 RID: 135781
			[Token(Token = "0x4021265")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04021266 RID: 135782
			[Token(Token = "0x4021266")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04021267 RID: 135783
			[Token(Token = "0x4021267")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04021268 RID: 135784
			[Token(Token = "0x4021268")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_TutorialOnly_GetTutorialGo;
		}
	}
}
