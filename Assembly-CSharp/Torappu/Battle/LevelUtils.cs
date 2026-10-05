using System;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200265A RID: 9818
	[Token(Token = "0x200265A")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class LevelUtils
	{
		// Token: 0x17002304 RID: 8964
		// (get) Token: 0x060100CE RID: 65742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002304")]
		private static IConverter decrypter
		{
			[Token(Token = "0x60100CE")]
			[Address(RVA = "0x7C9880", Offset = "0x7C8480", VA = "0x1807C9880")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002305 RID: 8965
		// (get) Token: 0x060100CF RID: 65743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002305")]
		private static IConverter plainTextConverter
		{
			[Token(Token = "0x60100CF")]
			[Address(RVA = "0x7C9920", Offset = "0x7C8520", VA = "0x1807C9920")]
			get
			{
				return null;
			}
		}

		// Token: 0x060100D0 RID: 65744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60100D0")]
		[Address(RVA = "0x7C9390", Offset = "0x7C7F90", VA = "0x1807C9390")]
		public static LevelData LoadLevel(string levelId)
		{
			return null;
		}

		// Token: 0x060100D1 RID: 65745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60100D1")]
		[Address(RVA = "0x7C9220", Offset = "0x7C7E20", VA = "0x1807C9220")]
		public static LevelData LoadLevelScript(string levelId)
		{
			return null;
		}

		// Token: 0x060100D2 RID: 65746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60100D2")]
		[Address(RVA = "0x7C9750", Offset = "0x7C8350", VA = "0x1807C9750")]
		private static TextAsset _LoadLevelTextAsset(string levelId, BattleMiscDB miscDB)
		{
			return null;
		}

		// Token: 0x060100D3 RID: 65747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60100D3")]
		[Address(RVA = "0x7C9500", Offset = "0x7C8100", VA = "0x1807C9500")]
		private static LevelData ParseLevelData(TextAsset textAsset)
		{
			return null;
		}

		// Token: 0x060100D4 RID: 65748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60100D4")]
		[Address(RVA = "0x7C9060", Offset = "0x7C7C60", VA = "0x1807C9060")]
		public static string GetSceneName(LevelData levelData)
		{
			return null;
		}

		// Token: 0x04011DAE RID: 73134
		[Token(Token = "0x4011DAE")]
		[FieldOffset(Offset = "0x0")]
		private static IConverter m_decrypter;

		// Token: 0x04011DAF RID: 73135
		[Token(Token = "0x4011DAF")]
		[FieldOffset(Offset = "0x8")]
		private static IConverter m_plainTextConverter;

		// Token: 0x04011DB0 RID: 73136
		[Token(Token = "0x4011DB0")]
		public const ConverterFactory.ConverterType LEVEL_CONVERTER_TYPE = ConverterFactory.ConverterType.FLAT_BUFFER;

		// Token: 0x04011DB1 RID: 73137
		[Token(Token = "0x4011DB1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_decrypter;

		// Token: 0x04011DB2 RID: 73138
		[Token(Token = "0x4011DB2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_plainTextConverter;

		// Token: 0x04011DB3 RID: 73139
		[Token(Token = "0x4011DB3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadLevel;

		// Token: 0x04011DB4 RID: 73140
		[Token(Token = "0x4011DB4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadLevelScript;

		// Token: 0x04011DB5 RID: 73141
		[Token(Token = "0x4011DB5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadLevelTextAsset;

		// Token: 0x04011DB6 RID: 73142
		[Token(Token = "0x4011DB6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ParseLevelData;

		// Token: 0x04011DB7 RID: 73143
		[Token(Token = "0x4011DB7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetSceneName;

		// Token: 0x0200265B RID: 9819
		[Token(Token = "0x200265B")]
		public class LevelDataMeta
		{
			// Token: 0x060100D5 RID: 65749 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60100D5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LevelDataMeta()
			{
			}

			// Token: 0x04011DB8 RID: 73144
			[Token(Token = "0x4011DB8")]
			[FieldOffset(Offset = "0x10")]
			public string type;
		}
	}
}
