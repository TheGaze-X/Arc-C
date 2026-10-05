using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Activity;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AFD RID: 27389
	[Token(Token = "0x2006AFD")]
	public class ArchiveActivityEntryController : ActArchiveController, IHotfixable
	{
		// Token: 0x0602729D RID: 160413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602729D")]
		[Address(RVA = "0x2252700", Offset = "0x2251300", VA = "0x182252700")]
		public List<DataBinder<ArchiveActivityEntryProperty>> InitAndAchieveDataBinder()
		{
			return null;
		}

		// Token: 0x0602729E RID: 160414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602729E")]
		[Address(RVA = "0x2252980", Offset = "0x2251580", VA = "0x182252980", Slot = "4")]
		public override void Init(ActArchiveProxy proxy)
		{
		}

		// Token: 0x0602729F RID: 160415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602729F")]
		[Address(RVA = "0x2252A60", Offset = "0x2251660", VA = "0x182252A60", Slot = "5")]
		public override void OnEnter()
		{
		}

		// Token: 0x060272A0 RID: 160416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272A0")]
		[Address(RVA = "0x2252D30", Offset = "0x2251930", VA = "0x182252D30", Slot = "6")]
		public override void OnExit()
		{
		}

		// Token: 0x060272A1 RID: 160417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272A1")]
		[Address(RVA = "0x22525E0", Offset = "0x22511E0", VA = "0x1822525E0", Slot = "8")]
		public override void BeforePageExit()
		{
		}

		// Token: 0x060272A2 RID: 160418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272A2")]
		[Address(RVA = "0x2252E20", Offset = "0x2251A20", VA = "0x182252E20")]
		private void _SetEffectsActive(bool isEnabled)
		{
		}

		// Token: 0x060272A3 RID: 160419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272A3")]
		[Address(RVA = "0x2252F50", Offset = "0x2251B50", VA = "0x182252F50")]
		public ArchiveActivityEntryController()
		{
		}

		// Token: 0x060272A4 RID: 160420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272A4")]
		[Address(RVA = "0x2252DF0", Offset = "0x22519F0", VA = "0x182252DF0")]
		private void <>xLuaBaseProxy_Init(ActArchiveProxy P0)
		{
		}

		// Token: 0x060272A5 RID: 160421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272A5")]
		[Address(RVA = "0x2252E00", Offset = "0x2251A00", VA = "0x182252E00")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060272A6 RID: 160422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272A6")]
		[Address(RVA = "0x2252E10", Offset = "0x2251A10", VA = "0x182252E10")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x060272A7 RID: 160423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272A7")]
		[Address(RVA = "0x224B000", Offset = "0x2249C00", VA = "0x18224B000")]
		private void <>xLuaBaseProxy_BeforePageExit()
		{
		}

		// Token: 0x04037668 RID: 226920
		[Token(Token = "0x4037668")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ArchiveActivityEntryButtonDataBinder _entryButtonBinder;

		// Token: 0x04037669 RID: 226921
		[Token(Token = "0x4037669")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ArchiveActivityEntryMusicDataBinder _entryMusicDataBinder;

		// Token: 0x0403766A RID: 226922
		[Token(Token = "0x403766A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UICommonPageEffectHolder[] _effectHolders;

		// Token: 0x0403766B RID: 226923
		[Token(Token = "0x403766B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Canvas[] _canvases;

		// Token: 0x0403766C RID: 226924
		[Token(Token = "0x403766C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ArchiveActivityEntryPlugin _plugin;

		// Token: 0x0403766D RID: 226925
		[Token(Token = "0x403766D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ActivityEntryAnimManager _animManager;

		// Token: 0x0403766E RID: 226926
		[Token(Token = "0x403766E")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public Action<ActArchiveType> onEntryCategoryClicked;

		// Token: 0x0403766F RID: 226927
		[Token(Token = "0x403766F")]
		[FieldOffset(Offset = "0x70")]
		private UITwoStepAnimation m_animOnEnter;

		// Token: 0x04037670 RID: 226928
		[Token(Token = "0x4037670")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitAndAchieveDataBinder;

		// Token: 0x04037671 RID: 226929
		[Token(Token = "0x4037671")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04037672 RID: 226930
		[Token(Token = "0x4037672")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04037673 RID: 226931
		[Token(Token = "0x4037673")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04037674 RID: 226932
		[Token(Token = "0x4037674")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_BeforePageExit;

		// Token: 0x04037675 RID: 226933
		[Token(Token = "0x4037675")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetEffectsActive;

		// Token: 0x04037676 RID: 226934
		[Token(Token = "0x4037676")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006AFE RID: 27390
		[Token(Token = "0x2006AFE")]
		private class ArchiveActivityEntryAnimContext : IActAnimContext
		{
			// Token: 0x060272A8 RID: 160424 RVA: 0x000CD8F0 File Offset: 0x000CBAF0
			[Token(Token = "0x60272A8")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "4")]
			public bool CanSkipAnim()
			{
				return default(bool);
			}

			// Token: 0x17005C92 RID: 23698
			// (get) Token: 0x060272A9 RID: 160425 RVA: 0x000CD908 File Offset: 0x000CBB08
			[Token(Token = "0x17005C92")]
			public float animDuration
			{
				[Token(Token = "0x60272A9")]
				[Address(RVA = "0x2251AE0", Offset = "0x22506E0", VA = "0x182251AE0", Slot = "5")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060272AA RID: 160426 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60272AA")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ArchiveActivityEntryAnimContext()
			{
			}
		}
	}
}
