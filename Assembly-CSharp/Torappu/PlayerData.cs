using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using XLua;

namespace Torappu
{
	// Token: 0x02000C0D RID: 3085
	[Token(Token = "0x2000C0D")]
	[Hotfix(HotfixFlag.Stateless)]
	public class PlayerData : Singleton<PlayerData>
	{
		// Token: 0x060068A9 RID: 26793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068A9")]
		[Address(RVA = "0x1EF9320", Offset = "0x1EF7F20", VA = "0x181EF9320")]
		private PlayerData()
		{
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x060068AA RID: 26794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CF1")]
		public JsonSerializerSettings serializeSetting
		{
			[Token(Token = "0x60068AA")]
			[Address(RVA = "0x1EF9650", Offset = "0x1EF8250", VA = "0x181EF9650")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x060068AB RID: 26795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CF2")]
		public string logToken
		{
			[Token(Token = "0x60068AB")]
			[Address(RVA = "0x1EF95F0", Offset = "0x1EF81F0", VA = "0x181EF95F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x060068AC RID: 26796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CF3")]
		public string accessToken
		{
			[Token(Token = "0x60068AC")]
			[Address(RVA = "0x1EF9470", Offset = "0x1EF8070", VA = "0x181EF9470")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x060068AD RID: 26797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CF4")]
		public string chatMask
		{
			[Token(Token = "0x60068AD")]
			[Address(RVA = "0x1EF94D0", Offset = "0x1EF80D0", VA = "0x181EF94D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060068AE RID: 26798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068AE")]
		[Address(RVA = "0x1EF83C0", Offset = "0x1EF6FC0", VA = "0x181EF83C0")]
		public void Init(PlayerDataModel playerModel, JObject rawData)
		{
		}

		// Token: 0x060068AF RID: 26799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068AF")]
		[Address(RVA = "0x1EF8630", Offset = "0x1EF7230", VA = "0x181EF8630")]
		public void NotifyDataChanged(PlayerDataModel newDataModel, PlayerDataDelta delta)
		{
		}

		// Token: 0x060068B0 RID: 26800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068B0")]
		[Address(RVA = "0x1EF8540", Offset = "0x1EF7140", VA = "0x181EF8540")]
		public static void LuaOnlyBindListener(ILuaPlayerData luaPlayerData)
		{
		}

		// Token: 0x060068B1 RID: 26801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068B1")]
		[Address(RVA = "0x1EF9070", Offset = "0x1EF7C70", VA = "0x181EF9070")]
		private void _SyncDataToLua()
		{
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x060068B2 RID: 26802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CF5")]
		public PlayerDataModel data
		{
			[Token(Token = "0x60068B2")]
			[Address(RVA = "0x1EF9540", Offset = "0x1EF8140", VA = "0x181EF9540")]
			get
			{
				return null;
			}
		}

		// Token: 0x060068B3 RID: 26803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068B3")]
		[Address(RVA = "0x1EF85D0", Offset = "0x1EF71D0", VA = "0x181EF85D0")]
		public JObject NetworkerOnlyRawData()
		{
			return null;
		}

		// Token: 0x060068B4 RID: 26804 RVA: 0x000309F0 File Offset: 0x0002EBF0
		[Token(Token = "0x60068B4")]
		[Address(RVA = "0x1EF8120", Offset = "0x1EF6D20", VA = "0x181EF8120")]
		public bool CheckIfActivityExists(string actId)
		{
			return default(bool);
		}

		// Token: 0x060068B5 RID: 26805 RVA: 0x00030A08 File Offset: 0x0002EC08
		[Token(Token = "0x60068B5")]
		[Address(RVA = "0x1EF81D0", Offset = "0x1EF6DD0", VA = "0x181EF81D0")]
		public bool CheckIfSandboxExists(string topicId)
		{
			return default(bool);
		}

		// Token: 0x060068B6 RID: 26806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068B6")]
		[Address(RVA = "0x1EF8300", Offset = "0x1EF6F00", VA = "0x181EF8300")]
		public PlayerCharacter GetCharInstById(string charId)
		{
			return null;
		}

		// Token: 0x060068B7 RID: 26807 RVA: 0x00030A20 File Offset: 0x0002EC20
		[Token(Token = "0x60068B7")]
		[Address(RVA = "0x1EF8280", Offset = "0x1EF6E80", VA = "0x181EF8280")]
		public static int GenerateFakeValidCharInstId(int bias, PlayerData.FakeInstType instType)
		{
			return 0;
		}

		// Token: 0x060068B8 RID: 26808 RVA: 0x00030A38 File Offset: 0x0002EC38
		[Token(Token = "0x60068B8")]
		[Address(RVA = "0x1EF84D0", Offset = "0x1EF70D0", VA = "0x181EF84D0")]
		public static bool IsValidPlayerChar(int charInstId)
		{
			return default(bool);
		}

		// Token: 0x060068B9 RID: 26809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068B9")]
		[Address(RVA = "0x1EF8720", Offset = "0x1EF7320", VA = "0x181EF8720", Slot = "4")]
		protected virtual void OnPlayerDataChanged(PlayerDataModel prevData, PlayerDataDelta delta)
		{
		}

		// Token: 0x060068BA RID: 26810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068BA")]
		[Address(RVA = "0x1EF8850", Offset = "0x1EF7450", VA = "0x181EF8850")]
		private void _OnDataChangeOnly_UpdateCharInstMap()
		{
		}

		// Token: 0x060068BB RID: 26811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068BB")]
		[Address(RVA = "0x1EF8A60", Offset = "0x1EF7660", VA = "0x181EF8A60")]
		private void _OnDataChangeOnly_UpdateExistActMap()
		{
		}

		// Token: 0x060068BC RID: 26812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068BC")]
		[Address(RVA = "0x1EF8D00", Offset = "0x1EF7900", VA = "0x181EF8D00")]
		private void _OnDataChangeOnly_UpdateExistSandboxPermSet()
		{
		}

		// Token: 0x04003F1A RID: 16154
		[Token(Token = "0x4003F1A")]
		private const int FAKE_CHAR_INST_ID_ROOT = 8388608;

		// Token: 0x04003F1B RID: 16155
		[Token(Token = "0x4003F1B")]
		private const int FAKE_CHAR_INST_ID_OFFSET = 65536;

		// Token: 0x04003F1C RID: 16156
		[Token(Token = "0x4003F1C")]
		[FieldOffset(Offset = "0x10")]
		private string m_logToken;

		// Token: 0x04003F1D RID: 16157
		[Token(Token = "0x4003F1D")]
		[FieldOffset(Offset = "0x18")]
		private string m_accessToken;

		// Token: 0x04003F1E RID: 16158
		[Token(Token = "0x4003F1E")]
		[FieldOffset(Offset = "0x20")]
		private PlayerDataModel m_data;

		// Token: 0x04003F1F RID: 16159
		[Token(Token = "0x4003F1F")]
		[FieldOffset(Offset = "0x28")]
		private JObject m_rawData;

		// Token: 0x04003F20 RID: 16160
		[Token(Token = "0x4003F20")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, PlayerCharacter> m_charIdInstMap;

		// Token: 0x04003F21 RID: 16161
		[Token(Token = "0x4003F21")]
		[FieldOffset(Offset = "0x38")]
		private HashSet<string> m_existActSet;

		// Token: 0x04003F22 RID: 16162
		[Token(Token = "0x4003F22")]
		[FieldOffset(Offset = "0x40")]
		private HashSet<string> m_existSandboxPermSet;

		// Token: 0x04003F23 RID: 16163
		[Token(Token = "0x4003F23")]
		[FieldOffset(Offset = "0x48")]
		private ILuaPlayerData m_luaPlayerData;

		// Token: 0x04003F24 RID: 16164
		[Token(Token = "0x4003F24")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04003F25 RID: 16165
		[Token(Token = "0x4003F25")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_serializeSetting;

		// Token: 0x04003F26 RID: 16166
		[Token(Token = "0x4003F26")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_logToken;

		// Token: 0x04003F27 RID: 16167
		[Token(Token = "0x4003F27")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_accessToken;

		// Token: 0x04003F28 RID: 16168
		[Token(Token = "0x4003F28")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_chatMask;

		// Token: 0x04003F29 RID: 16169
		[Token(Token = "0x4003F29")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04003F2A RID: 16170
		[Token(Token = "0x4003F2A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_NotifyDataChanged;

		// Token: 0x04003F2B RID: 16171
		[Token(Token = "0x4003F2B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LuaOnlyBindListener;

		// Token: 0x04003F2C RID: 16172
		[Token(Token = "0x4003F2C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SyncDataToLua;

		// Token: 0x04003F2D RID: 16173
		[Token(Token = "0x4003F2D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_data;

		// Token: 0x04003F2E RID: 16174
		[Token(Token = "0x4003F2E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_NetworkerOnlyRawData;

		// Token: 0x04003F2F RID: 16175
		[Token(Token = "0x4003F2F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CheckIfActivityExists;

		// Token: 0x04003F30 RID: 16176
		[Token(Token = "0x4003F30")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CheckIfSandboxExists;

		// Token: 0x04003F31 RID: 16177
		[Token(Token = "0x4003F31")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetCharInstById;

		// Token: 0x04003F32 RID: 16178
		[Token(Token = "0x4003F32")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GenerateFakeValidCharInstId;

		// Token: 0x04003F33 RID: 16179
		[Token(Token = "0x4003F33")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_IsValidPlayerChar;

		// Token: 0x04003F34 RID: 16180
		[Token(Token = "0x4003F34")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x04003F35 RID: 16181
		[Token(Token = "0x4003F35")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnDataChangeOnly_UpdateCharInstMap;

		// Token: 0x04003F36 RID: 16182
		[Token(Token = "0x4003F36")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnDataChangeOnly_UpdateExistActMap;

		// Token: 0x04003F37 RID: 16183
		[Token(Token = "0x4003F37")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnDataChangeOnly_UpdateExistSandboxPermSet;

		// Token: 0x02000C0E RID: 3086
		[Token(Token = "0x2000C0E")]
		public enum FakeInstType
		{
			// Token: 0x04003F39 RID: 16185
			[Token(Token = "0x4003F39")]
			VAULT,
			// Token: 0x04003F3A RID: 16186
			[Token(Token = "0x4003F3A")]
			ASSIST,
			// Token: 0x04003F3B RID: 16187
			[Token(Token = "0x4003F3B")]
			PREDEFINED
		}
	}
}
