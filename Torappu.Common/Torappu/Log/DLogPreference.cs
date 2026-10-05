using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json;
using XLua;

namespace Torappu.Log
{
	// Token: 0x02000243 RID: 579
	[Token(Token = "0x2000243")]
	public class DLogPreference : Singleton<DLogPreference>
	{
		// Token: 0x06000D2E RID: 3374 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000D2E")]
		[Address(RVA = "0x55803C0", Offset = "0x557EFC0", VA = "0x1855803C0")]
		private DLogPreference()
		{
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000D2F")]
		[Address(RVA = "0x557F390", Offset = "0x557DF90", VA = "0x18557F390")]
		public void InitAndApply(bool forceReloadData = false)
		{
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D30")]
		[Address(RVA = "0x557F6D0", Offset = "0x557E2D0", VA = "0x18557F6D0")]
		public DLogPreference.Data ResetToCurrentSettings()
		{
			return null;
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000D31")]
		[Address(RVA = "0x557F910", Offset = "0x557E510", VA = "0x18557F910")]
		private static void _AdjustDataFromCurrentSettings(ref DLogPreference.Data data)
		{
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D32")]
		[Address(RVA = "0x5580360", Offset = "0x557EF60", VA = "0x185580360")]
		private static DLogPreference.Data _MigrateData(DLogPreference.Data data)
		{
			return null;
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000D33")]
		[Address(RVA = "0x55801A0", Offset = "0x557EDA0", VA = "0x1855801A0")]
		private static void _MakeDefaultChannels(DLogPreference.Data data)
		{
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000D34")]
		[Address(RVA = "0x557FFE0", Offset = "0x557EBE0", VA = "0x18557FFE0")]
		private static void _ApplyDataToDLog(DLogPreference.Data data)
		{
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x00008714 File Offset: 0x00006914
		[Token(Token = "0x6000D35")]
		[Address(RVA = "0x5580140", Offset = "0x557ED40", VA = "0x185580140")]
		private static bool _EnablePreference()
		{
			return default(bool);
		}

		// Token: 0x04000D4F RID: 3407
		[Token(Token = "0x4000D4F")]
		public const string LOG_PREF_FILE = "dlog_preference.json";

		// Token: 0x04000D50 RID: 3408
		[Token(Token = "0x4000D50")]
		private const int PREF_VERSION = 1;

		// Token: 0x04000D51 RID: 3409
		[Token(Token = "0x4000D51")]
		[FieldOffset(Offset = "0x10")]
		private DLogPreference.Data m_data;

		// Token: 0x04000D52 RID: 3410
		[Token(Token = "0x4000D52")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x04000D53 RID: 3411
		[Token(Token = "0x4000D53")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate6 __Hotfix0_InitAndApply;

		// Token: 0x04000D54 RID: 3412
		[Token(Token = "0x4000D54")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate272 __Hotfix0_ResetToCurrentSettings;

		// Token: 0x04000D55 RID: 3413
		[Token(Token = "0x4000D55")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate273 __Hotfix0__AdjustDataFromCurrentSettings;

		// Token: 0x04000D56 RID: 3414
		[Token(Token = "0x4000D56")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate272 __Hotfix0__MigrateData;

		// Token: 0x04000D57 RID: 3415
		[Token(Token = "0x4000D57")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate1 __Hotfix0__MakeDefaultChannels;

		// Token: 0x04000D58 RID: 3416
		[Token(Token = "0x4000D58")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate1 __Hotfix0__ApplyDataToDLog;

		// Token: 0x04000D59 RID: 3417
		[Token(Token = "0x4000D59")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate8 __Hotfix0__EnablePreference;

		// Token: 0x02000244 RID: 580
		[Token(Token = "0x2000244")]
		public class Data
		{
			// Token: 0x1700015A RID: 346
			// (get) Token: 0x06000D37 RID: 3383 RVA: 0x0000872C File Offset: 0x0000692C
			// (set) Token: 0x06000D38 RID: 3384 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x1700015A")]
			[JsonIgnore]
			public bool isDirty
			{
				[Token(Token = "0x6000D37")]
				[Address(RVA = "0x12411F0", Offset = "0x123FDF0", VA = "0x1812411F0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000D38")]
				[Address(RVA = "0x1241210", Offset = "0x123FE10", VA = "0x181241210")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06000D39 RID: 3385 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000D39")]
			[Address(RVA = "0x55805C0", Offset = "0x557F1C0", VA = "0x1855805C0")]
			public void SetChannel(LogChannel channel, bool enabled)
			{
			}

			// Token: 0x06000D3A RID: 3386 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000D3A")]
			[Address(RVA = "0x5580430", Offset = "0x557F030", VA = "0x185580430")]
			public void SaveToDisk()
			{
			}

			// Token: 0x06000D3B RID: 3387 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000D3B")]
			[Address(RVA = "0x5580680", Offset = "0x557F280", VA = "0x185580680")]
			public Data()
			{
			}

			// Token: 0x04000D5A RID: 3418
			[Token(Token = "0x4000D5A")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, int> channels;

			// Token: 0x04000D5B RID: 3419
			[Token(Token = "0x4000D5B")]
			[FieldOffset(Offset = "0x18")]
			public int version;
		}
	}
}
