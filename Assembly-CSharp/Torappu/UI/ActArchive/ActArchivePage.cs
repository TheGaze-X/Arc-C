using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AA9 RID: 27305
	[Token(Token = "0x2006AA9")]
	public class ActArchivePage : StateEnginePage
	{
		// Token: 0x060270FD RID: 159997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270FD")]
		[Address(RVA = "0x2234280", Offset = "0x2232E80", VA = "0x182234280", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x060270FE RID: 159998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270FE")]
		[Address(RVA = "0x2234340", Offset = "0x2232F40", VA = "0x182234340", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x060270FF RID: 159999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60270FF")]
		[Address(RVA = "0x22341D0", Offset = "0x2232DD0", VA = "0x1822341D0", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x06027100 RID: 160000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027100")]
		[Address(RVA = "0x22340F0", Offset = "0x2232CF0", VA = "0x1822340F0", Slot = "26")]
		protected override IEnumerator EffectsOnHide(bool isIntoStack, bool isRemoveVirtualTop)
		{
			return null;
		}

		// Token: 0x06027101 RID: 160001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027101")]
		[Address(RVA = "0x2234600", Offset = "0x2233200", VA = "0x182234600")]
		private IEnumerator _JumpToDetailState(DataBundle param)
		{
			return null;
		}

		// Token: 0x06027102 RID: 160002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027102")]
		[Address(RVA = "0x22346D0", Offset = "0x22332D0", VA = "0x1822346D0")]
		private IEnumerator _RouteToEntryCoroutine(bool useFastMode = false)
		{
			return null;
		}

		// Token: 0x06027103 RID: 160003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027103")]
		[Address(RVA = "0x2234550", Offset = "0x2233150", VA = "0x182234550")]
		private IEnumerator _ClearStateAfterHide()
		{
			return null;
		}

		// Token: 0x06027104 RID: 160004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027104")]
		[Address(RVA = "0x2234790", Offset = "0x2233390", VA = "0x182234790")]
		public ActArchivePage()
		{
		}

		// Token: 0x06027107 RID: 160007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027107")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x06027108 RID: 160008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027108")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x06027109 RID: 160009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027109")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x0602710A RID: 160010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602710A")]
		[Address(RVA = "0x12172E0", Offset = "0x1215EE0", VA = "0x1812172E0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnHide(bool P0, bool P1)
		{
			return null;
		}

		// Token: 0x04037489 RID: 226441
		[Token(Token = "0x4037489")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private ActArchiveStateBean _stateBean;

		// Token: 0x0403748A RID: 226442
		[Token(Token = "0x403748A")]
		[FieldOffset(Offset = "0xF8")]
		private ActArchivePage.ActArchiveParam m_param;

		// Token: 0x0403748B RID: 226443
		[Token(Token = "0x403748B")]
		[FieldOffset(Offset = "0x100")]
		private DataBundle m_savedInst;

		// Token: 0x0403748C RID: 226444
		[Token(Token = "0x403748C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0403748D RID: 226445
		[Token(Token = "0x403748D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x0403748E RID: 226446
		[Token(Token = "0x403748E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x0403748F RID: 226447
		[Token(Token = "0x403748F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EffectsOnHide;

		// Token: 0x04037490 RID: 226448
		[Token(Token = "0x4037490")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__JumpToDetailState;

		// Token: 0x04037491 RID: 226449
		[Token(Token = "0x4037491")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RouteToEntryCoroutine;

		// Token: 0x04037492 RID: 226450
		[Token(Token = "0x4037492")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ClearStateAfterHide;

		// Token: 0x04037493 RID: 226451
		[Token(Token = "0x4037493")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006AAA RID: 27306
		[Token(Token = "0x2006AAA")]
		public class ActArchiveParam
		{
			// Token: 0x17005C4B RID: 23627
			// (get) Token: 0x0602710B RID: 160011 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0602710C RID: 160012 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005C4B")]
			public Type archivePluginType
			{
				[Token(Token = "0x602710B")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x602710C")]
				[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0602710D RID: 160013 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602710D")]
			public ActArchivePage.ActArchiveParam SetPlugin<Plugin>() where Plugin : ActArchivePlugin, new()
			{
				return null;
			}

			// Token: 0x0602710E RID: 160014 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602710E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActArchiveParam()
			{
			}

			// Token: 0x04037494 RID: 226452
			[Token(Token = "0x4037494")]
			[FieldOffset(Offset = "0x10")]
			public string archiveId;

			// Token: 0x04037495 RID: 226453
			[Token(Token = "0x4037495")]
			[FieldOffset(Offset = "0x18")]
			public string bgmInstIdAlias;

			// Token: 0x04037497 RID: 226455
			[Token(Token = "0x4037497")]
			[FieldOffset(Offset = "0x28")]
			public DataBundle extraPassthroughData;
		}
	}
}
