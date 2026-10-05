using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002659 RID: 9817
	[Token(Token = "0x2002659")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class LevelScriptUtils
	{
		// Token: 0x17002303 RID: 8963
		// (get) Token: 0x060100C9 RID: 65737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002303")]
		private static IConverter decrypter
		{
			[Token(Token = "0x60100C9")]
			[Address(RVA = "0x7C8F60", Offset = "0x7C7B60", VA = "0x1807C8F60")]
			get
			{
				return null;
			}
		}

		// Token: 0x060100CA RID: 65738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60100CA")]
		[Address(RVA = "0x7C8840", Offset = "0x7C7440", VA = "0x1807C8840")]
		public static LevelScriptData LoadLevelScript(string levelScriptKey)
		{
			return null;
		}

		// Token: 0x060100CB RID: 65739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60100CB")]
		[Address(RVA = "0x7C8C60", Offset = "0x7C7860", VA = "0x1807C8C60")]
		private static TextAsset _LoadLevelTextAsset(string levelId)
		{
			return null;
		}

		// Token: 0x060100CC RID: 65740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60100CC")]
		[Address(RVA = "0x7C8AE0", Offset = "0x7C76E0", VA = "0x1807C8AE0")]
		private static LevelScriptData ParseLevelScriptData(TextAsset textAsset)
		{
			return null;
		}

		// Token: 0x04011DA6 RID: 73126
		[Token(Token = "0x4011DA6")]
		[FieldOffset(Offset = "0x0")]
		private static IConverter m_decrypter;

		// Token: 0x04011DA7 RID: 73127
		[Token(Token = "0x4011DA7")]
		[FieldOffset(Offset = "0x8")]
		private static IConverter m_plainTextConverter;

		// Token: 0x04011DA8 RID: 73128
		[Token(Token = "0x4011DA8")]
		public const ConverterFactory.ConverterType LEVEL_SCRIPT_CONVERTER_TYPE = ConverterFactory.ConverterType.FLAT_BUFFER;

		// Token: 0x04011DA9 RID: 73129
		[Token(Token = "0x4011DA9")]
		[FieldOffset(Offset = "0x10")]
		public static readonly JsonSerializerSettings s_levelScriptSettings;

		// Token: 0x04011DAA RID: 73130
		[Token(Token = "0x4011DAA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_decrypter;

		// Token: 0x04011DAB RID: 73131
		[Token(Token = "0x4011DAB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadLevelScript;

		// Token: 0x04011DAC RID: 73132
		[Token(Token = "0x4011DAC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadLevelTextAsset;

		// Token: 0x04011DAD RID: 73133
		[Token(Token = "0x4011DAD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ParseLevelScriptData;
	}
}
