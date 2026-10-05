using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AF6 RID: 27382
	[Token(Token = "0x2006AF6")]
	public class ActArchiveInfo : IHotfixable
	{
		// Token: 0x17005C8C RID: 23692
		// (get) Token: 0x06027276 RID: 160374 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027277 RID: 160375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005C8C")]
		public string archiveId
		{
			[Token(Token = "0x6027276")]
			[Address(RVA = "0x224C790", Offset = "0x224B390", VA = "0x18224C790")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6027277")]
			[Address(RVA = "0x224C910", Offset = "0x224B510", VA = "0x18224C910")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005C8D RID: 23693
		// (get) Token: 0x06027278 RID: 160376 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027279 RID: 160377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005C8D")]
		public ActArchiveInfo.Param archiveParams
		{
			[Token(Token = "0x6027278")]
			[Address(RVA = "0x224C7F0", Offset = "0x224B3F0", VA = "0x18224C7F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6027279")]
			[Address(RVA = "0x224C990", Offset = "0x224B590", VA = "0x18224C990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005C8E RID: 23694
		// (get) Token: 0x0602727A RID: 160378 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602727B RID: 160379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005C8E")]
		public ActArchivePlugin archivePlugin
		{
			[Token(Token = "0x602727A")]
			[Address(RVA = "0x224C850", Offset = "0x224B450", VA = "0x18224C850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602727B")]
			[Address(RVA = "0x224CA10", Offset = "0x224B610", VA = "0x18224CA10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005C8F RID: 23695
		// (get) Token: 0x0602727C RID: 160380 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602727D RID: 160381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005C8F")]
		public DataBundle extraPassthroughData
		{
			[Token(Token = "0x602727C")]
			[Address(RVA = "0x224C8B0", Offset = "0x224B4B0", VA = "0x18224C8B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602727D")]
			[Address(RVA = "0x224CA90", Offset = "0x224B690", VA = "0x18224CA90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602727E RID: 160382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602727E")]
		[Address(RVA = "0x224BDE0", Offset = "0x224A9E0", VA = "0x18224BDE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602727F RID: 160383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602727F")]
		[Address(RVA = "0x224B6E0", Offset = "0x224A2E0", VA = "0x18224B6E0")]
		public Dictionary<ActArchiveType, ActArchiveCompInfo> GetValidArchiveCompInfo()
		{
			return null;
		}

		// Token: 0x06027280 RID: 160384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027280")]
		[Address(RVA = "0x224B980", Offset = "0x224A580", VA = "0x18224B980")]
		public void LoadData(ActArchiveInfo.Param param)
		{
		}

		// Token: 0x06027281 RID: 160385 RVA: 0x000CD890 File Offset: 0x000CBA90
		[Token(Token = "0x6027281")]
		[Address(RVA = "0x224B880", Offset = "0x224A480", VA = "0x18224B880")]
		public bool HasArchiveComp(ActArchiveType archiveType)
		{
			return default(bool);
		}

		// Token: 0x06027282 RID: 160386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027282")]
		[Address(RVA = "0x224B630", Offset = "0x224A230", VA = "0x18224B630")]
		public ActArchiveCompInfo GetArchiveComp(ActArchiveType archiveType)
		{
			return null;
		}

		// Token: 0x06027283 RID: 160387 RVA: 0x000CD8A8 File Offset: 0x000CBAA8
		[Token(Token = "0x6027283")]
		public static bool GetArchiveTrackpointStatus<Plugin>(string archiveId) where Plugin : ActArchivePlugin, new()
		{
			return default(bool);
		}

		// Token: 0x06027284 RID: 160388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027284")]
		[Address(RVA = "0x224C730", Offset = "0x224B330", VA = "0x18224C730")]
		public ActArchiveInfo()
		{
		}

		// Token: 0x04037633 RID: 226867
		[Token(Token = "0x4037633")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x04037634 RID: 226868
		[Token(Token = "0x4037634")]
		[FieldOffset(Offset = "0x38")]
		private ListDict<ActArchiveType, ActArchiveCompInfo> m_archiveCompInfo;

		// Token: 0x04037635 RID: 226869
		[Token(Token = "0x4037635")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_archiveId;

		// Token: 0x04037636 RID: 226870
		[Token(Token = "0x4037636")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_archiveId;

		// Token: 0x04037637 RID: 226871
		[Token(Token = "0x4037637")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_archiveParams;

		// Token: 0x04037638 RID: 226872
		[Token(Token = "0x4037638")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_archiveParams;

		// Token: 0x04037639 RID: 226873
		[Token(Token = "0x4037639")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_archivePlugin;

		// Token: 0x0403763A RID: 226874
		[Token(Token = "0x403763A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_archivePlugin;

		// Token: 0x0403763B RID: 226875
		[Token(Token = "0x403763B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_extraPassthroughData;

		// Token: 0x0403763C RID: 226876
		[Token(Token = "0x403763C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_extraPassthroughData;

		// Token: 0x0403763D RID: 226877
		[Token(Token = "0x403763D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403763E RID: 226878
		[Token(Token = "0x403763E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetValidArchiveCompInfo;

		// Token: 0x0403763F RID: 226879
		[Token(Token = "0x403763F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04037640 RID: 226880
		[Token(Token = "0x4037640")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_HasArchiveComp;

		// Token: 0x04037641 RID: 226881
		[Token(Token = "0x4037641")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetArchiveComp;

		// Token: 0x04037642 RID: 226882
		[Token(Token = "0x4037642")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetArchiveTrackpointStatus;

		// Token: 0x04037643 RID: 226883
		[Token(Token = "0x4037643")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006AF7 RID: 27383
		[Token(Token = "0x2006AF7")]
		public class Param
		{
			// Token: 0x06027285 RID: 160389 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027285")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x04037644 RID: 226884
			[Token(Token = "0x4037644")]
			[FieldOffset(Offset = "0x10")]
			public string archiveId;

			// Token: 0x04037645 RID: 226885
			[Token(Token = "0x4037645")]
			[FieldOffset(Offset = "0x18")]
			public string bgmInstIdAlias;

			// Token: 0x04037646 RID: 226886
			[Token(Token = "0x4037646")]
			[FieldOffset(Offset = "0x20")]
			public Type archivePluginType;

			// Token: 0x04037647 RID: 226887
			[Token(Token = "0x4037647")]
			[FieldOffset(Offset = "0x28")]
			public DataBundle extraPassthroughData;
		}
	}
}
