using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu
{
	// Token: 0x02000529 RID: 1321
	[Token(Token = "0x2000529")]
	public abstract class KeyEntityGroupBase : IHotfixable
	{
		// Token: 0x06004F84 RID: 20356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F84")]
		[Address(RVA = "0x1AF5960", Offset = "0x1AF4560", VA = "0x181AF5960")]
		private void _LoadData(KeySettingGroupData groupData)
		{
		}

		// Token: 0x06004F85 RID: 20357 RVA: 0x0002E620 File Offset: 0x0002C820
		[Token(Token = "0x6004F85")]
		[Address(RVA = "0x1AF4D50", Offset = "0x1AF3950", VA = "0x181AF4D50")]
		private bool _CheckKeyCodeSetting(Dictionary<string, Dictionary<string, KeyEntityGroupBase.KeyLogicSetting>> userSetting)
		{
			return default(bool);
		}

		// Token: 0x06004F86 RID: 20358
		[Token(Token = "0x6004F86")]
		protected abstract bool CheckIfUseGroup();

		// Token: 0x06004F87 RID: 20359
		[Token(Token = "0x6004F87")]
		protected abstract void LoadGroupData(KeySettingGroupData groupData);

		// Token: 0x06004F88 RID: 20360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F88")]
		[Address(RVA = "0x1AF5B70", Offset = "0x1AF4770", VA = "0x181AF5B70")]
		protected KeyEntityGroupBase()
		{
		}

		// Token: 0x04001400 RID: 5120
		[Token(Token = "0x4001400")]
		[FieldOffset(Offset = "0x10")]
		public bool showBtnCard;

		// Token: 0x04001401 RID: 5121
		[Token(Token = "0x4001401")]
		[FieldOffset(Offset = "0x18")]
		private string m_groupId;

		// Token: 0x04001402 RID: 5122
		[Token(Token = "0x4001402")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, KeyEntityItem> m_funcIdToItemDict;

		// Token: 0x04001403 RID: 5123
		[Token(Token = "0x4001403")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, KeyEntityItem> m_keyIdToItemDict;

		// Token: 0x04001404 RID: 5124
		[Token(Token = "0x4001404")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__LoadData;

		// Token: 0x04001405 RID: 5125
		[Token(Token = "0x4001405")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CheckKeyCodeSetting;

		// Token: 0x04001406 RID: 5126
		[Token(Token = "0x4001406")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200052A RID: 1322
		[Token(Token = "0x200052A")]
		public class KeyLogicSetting
		{
			// Token: 0x06004F89 RID: 20361 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F89")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public KeyLogicSetting()
			{
			}

			// Token: 0x04001407 RID: 5127
			[Token(Token = "0x4001407")]
			[FieldOffset(Offset = "0x10")]
			public string keyId;
		}

		// Token: 0x0200052B RID: 1323
		[Token(Token = "0x200052B")]
		public class LegacyKeyLogicSetting
		{
			// Token: 0x06004F8A RID: 20362 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F8A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LegacyKeyLogicSetting()
			{
			}

			// Token: 0x04001408 RID: 5128
			[Token(Token = "0x4001408")]
			[FieldOffset(Offset = "0x10")]
			public string keyId;

			// Token: 0x04001409 RID: 5129
			[Token(Token = "0x4001409")]
			[FieldOffset(Offset = "0x18")]
			public KeyBoardVirtualButtonEnum virtualButtonEnum;
		}

		// Token: 0x0200052C RID: 1324
		[Token(Token = "0x200052C")]
		public class TorappuKeyBoardLogic : IHotfixable
		{
			// Token: 0x06004F8B RID: 20363 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F8B")]
			[Address(RVA = "0x1AFFDD0", Offset = "0x1AFE9D0", VA = "0x181AFFDD0")]
			private void _LoadDisplaySettingData()
			{
			}

			// Token: 0x06004F8C RID: 20364 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F8C")]
			[Address(RVA = "0x1B00740", Offset = "0x1AFF340", VA = "0x181B00740")]
			private void _LoadKeyCodeData()
			{
			}

			// Token: 0x06004F8D RID: 20365 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F8D")]
			[Address(RVA = "0x1AFFE80", Offset = "0x1AFEA80", VA = "0x181AFFE80")]
			private void _LoadGroupData(bool isInit)
			{
			}

			// Token: 0x06004F8E RID: 20366 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F8E")]
			[Address(RVA = "0x1AFFC90", Offset = "0x1AFE890", VA = "0x181AFFC90")]
			private void _LoadDefaultKeyCodeData()
			{
			}

			// Token: 0x06004F8F RID: 20367 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F8F")]
			[Address(RVA = "0x1AFFB30", Offset = "0x1AFE730", VA = "0x181AFFB30")]
			private void _LoadDefaultGroupData()
			{
			}

			// Token: 0x06004F90 RID: 20368 RVA: 0x0002E638 File Offset: 0x0002C838
			[Token(Token = "0x6004F90")]
			[Address(RVA = "0x1B01760", Offset = "0x1B00360", VA = "0x181B01760")]
			private bool _TryMoveLegacyData()
			{
				return default(bool);
			}

			// Token: 0x06004F91 RID: 20369 RVA: 0x0002E650 File Offset: 0x0002C850
			[Token(Token = "0x6004F91")]
			[Address(RVA = "0x1B00C50", Offset = "0x1AFF850", VA = "0x181B00C50")]
			private bool _ResolveKeyIdConflicts()
			{
				return default(bool);
			}

			// Token: 0x06004F92 RID: 20370 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F92")]
			[Address(RVA = "0x1AFE200", Offset = "0x1AFCE00", VA = "0x181AFE200")]
			public void LoadData(bool isInit)
			{
			}

			// Token: 0x06004F93 RID: 20371 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004F93")]
			[Address(RVA = "0x1AFD310", Offset = "0x1AFBF10", VA = "0x181AFD310")]
			public string GetFuncNameByFuncId(KeyBoardVirtualButtonConfig config)
			{
				return null;
			}

			// Token: 0x06004F94 RID: 20372 RVA: 0x0002E668 File Offset: 0x0002C868
			[Token(Token = "0x6004F94")]
			[Address(RVA = "0x1AFD200", Offset = "0x1AFBE00", VA = "0x181AFD200")]
			public bool CheckIfNormalBtnDisplay()
			{
				return default(bool);
			}

			// Token: 0x06004F95 RID: 20373 RVA: 0x0002E680 File Offset: 0x0002C880
			[Token(Token = "0x6004F95")]
			[Address(RVA = "0x1AFD1A0", Offset = "0x1AFBDA0", VA = "0x181AFD1A0")]
			public bool CheckIfActBtnDisplay()
			{
				return default(bool);
			}

			// Token: 0x06004F96 RID: 20374 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F96")]
			[Address(RVA = "0x1AFE900", Offset = "0x1AFD500", VA = "0x181AFE900")]
			public void SetNormalBtnDisplay(bool value)
			{
			}

			// Token: 0x06004F97 RID: 20375 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F97")]
			[Address(RVA = "0x1AFE330", Offset = "0x1AFCF30", VA = "0x181AFE330")]
			public void SetActBtnDisplay(bool value)
			{
			}

			// Token: 0x06004F98 RID: 20376 RVA: 0x0002E698 File Offset: 0x0002C898
			[Token(Token = "0x6004F98")]
			[Address(RVA = "0x1AFE570", Offset = "0x1AFD170", VA = "0x181AFE570")]
			public bool SetFuncKey(string groupId, string funcId, string keyId)
			{
				return default(bool);
			}

			// Token: 0x06004F99 RID: 20377 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004F99")]
			[Address(RVA = "0x1AFD260", Offset = "0x1AFBE60", VA = "0x181AFD260")]
			public KeyBoardVirtualButtonConfig GetConflictFuncInSetting(KeyBoardVirtualButtonConfig selectedInfo, string keyId)
			{
				return null;
			}

			// Token: 0x06004F9A RID: 20378 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004F9A")]
			[Address(RVA = "0x1AFD990", Offset = "0x1AFC590", VA = "0x181AFD990")]
			public KeyItem GetKeyItemByFuncId(string groupId, string funcId)
			{
				return null;
			}

			// Token: 0x06004F9B RID: 20379 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004F9B")]
			[Address(RVA = "0x1AFDAE0", Offset = "0x1AFC6E0", VA = "0x181AFDAE0")]
			public KeyItem GetKeyItemByKeyId(string keyId)
			{
				return null;
			}

			// Token: 0x06004F9C RID: 20380 RVA: 0x0002E6B0 File Offset: 0x0002C8B0
			[Token(Token = "0x6004F9C")]
			[Address(RVA = "0x1AFDBA0", Offset = "0x1AFC7A0", VA = "0x181AFDBA0")]
			public bool GetShowBtnByGroupId(string groupId)
			{
				return default(bool);
			}

			// Token: 0x06004F9D RID: 20381 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F9D")]
			[Address(RVA = "0x1AFE290", Offset = "0x1AFCE90", VA = "0x181AFE290")]
			public void ResetAllSetting()
			{
			}

			// Token: 0x06004F9E RID: 20382 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F9E")]
			[Address(RVA = "0x1AFEB40", Offset = "0x1AFD740", VA = "0x181AFEB40")]
			public void TriggerIfAnyKeyDown(KeyCodeType keyCodeType, int keyCode)
			{
			}

			// Token: 0x06004F9F RID: 20383 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004F9F")]
			[Address(RVA = "0x1AFD470", Offset = "0x1AFC070", VA = "0x181AFD470")]
			public List<KeyCodeEntity> GetKeyCodeList()
			{
				return null;
			}

			// Token: 0x06004FA0 RID: 20384 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004FA0")]
			[Address(RVA = "0x1AFDC70", Offset = "0x1AFC870", VA = "0x181AFDC70")]
			public List<KeyBoardVirtualButtonConfig> GetVirtualButton(KeyCodeEntity keyCode)
			{
				return null;
			}

			// Token: 0x06004FA1 RID: 20385 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004FA1")]
			[Address(RVA = "0x1AFD7F0", Offset = "0x1AFC3F0", VA = "0x181AFD7F0")]
			public string GetKeyId(KeyBoardVirtualButtonEnum buttonEnum)
			{
				return null;
			}

			// Token: 0x06004FA2 RID: 20386 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004FA2")]
			[Address(RVA = "0x1AFF290", Offset = "0x1AFDE90", VA = "0x181AFF290")]
			private List<KeyBoardVirtualButtonConfig> _GetConflictItemList(KeyBoardVirtualButtonConfig selectedInfo, string keyId, bool onlySettable = false)
			{
				return null;
			}

			// Token: 0x06004FA3 RID: 20387 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004FA3")]
			[Address(RVA = "0x1AFF9A0", Offset = "0x1AFE5A0", VA = "0x181AFF9A0")]
			private KeyItem _GetKeyItemByKeyCode(KeyCodeEntity keyCode)
			{
				return null;
			}

			// Token: 0x06004FA4 RID: 20388 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004FA4")]
			[Address(RVA = "0x1AFFA30", Offset = "0x1AFE630", VA = "0x181AFFA30")]
			private KeyItem _GetKeyItemByKeyCode(KeyCodeType keyCodeType, int triggerKey)
			{
				return null;
			}

			// Token: 0x06004FA5 RID: 20389 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004FA5")]
			[Address(RVA = "0x1B01420", Offset = "0x1B00020", VA = "0x181B01420")]
			private void _SaveKeyInfo()
			{
			}

			// Token: 0x06004FA6 RID: 20390 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004FA6")]
			[Address(RVA = "0x1B01390", Offset = "0x1AFFF90", VA = "0x181B01390")]
			private void _SaveBtnDisplayInfo()
			{
			}

			// Token: 0x06004FA7 RID: 20391 RVA: 0x0002E6C8 File Offset: 0x0002C8C8
			[Token(Token = "0x6004FA7")]
			[Address(RVA = "0x1B014B0", Offset = "0x1B000B0", VA = "0x181B014B0")]
			private bool _SetFuncKeyWithoutSave(string groupId, string funcId, string keyId)
			{
				return default(bool);
			}

			// Token: 0x06004FA8 RID: 20392 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004FA8")]
			[Address(RVA = "0x1AFEE70", Offset = "0x1AFDA70", VA = "0x181AFEE70")]
			private void _AddKeyCodesFromGroup(KeyEntityGroupBase group, Dictionary<int, HashSet<int>> seen, List<KeyCodeEntity> ret)
			{
			}

			// Token: 0x06004FA9 RID: 20393 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004FA9")]
			[Address(RVA = "0x1B01B40", Offset = "0x1B00740", VA = "0x181B01B40")]
			public TorappuKeyBoardLogic()
			{
			}

			// Token: 0x0400140A RID: 5130
			[Token(Token = "0x400140A")]
			private const string KEYBOARD_SETTING_LEGACY = "KEYBOARD_SETTING";

			// Token: 0x0400140B RID: 5131
			[Token(Token = "0x400140B")]
			private const string KEYBOARD_SETTING = "KEYBOARD_SETTING_V2";

			// Token: 0x0400140C RID: 5132
			[Token(Token = "0x400140C")]
			private const string KEYBOARD_SETTING_DISPLAY = "KEYBOARD_SETTING_DISPLAY";

			// Token: 0x0400140D RID: 5133
			[Token(Token = "0x400140D")]
			[FieldOffset(Offset = "0x10")]
			private Dictionary<string, KeyEntityGroupBase> m_normalGroupDict;

			// Token: 0x0400140E RID: 5134
			[Token(Token = "0x400140E")]
			[FieldOffset(Offset = "0x18")]
			private Dictionary<string, KeyEntityGroupBase> m_actGroupDict;

			// Token: 0x0400140F RID: 5135
			[Token(Token = "0x400140F")]
			[FieldOffset(Offset = "0x20")]
			private Dictionary<string, KeyEntityGroupBase> m_groupDict;

			// Token: 0x04001410 RID: 5136
			[Token(Token = "0x4001410")]
			[FieldOffset(Offset = "0x28")]
			private Dictionary<int, Dictionary<int, string>> m_keyCodeIdMap;

			// Token: 0x04001411 RID: 5137
			[Token(Token = "0x4001411")]
			[FieldOffset(Offset = "0x30")]
			private Dictionary<string, Dictionary<string, KeyEntityGroupBase.KeyLogicSetting>> m_userSettingDict;

			// Token: 0x04001412 RID: 5138
			[Token(Token = "0x4001412")]
			[FieldOffset(Offset = "0x38")]
			private KeyBoardBtnDisplaySetting m_displaySetting;

			// Token: 0x04001413 RID: 5139
			[Token(Token = "0x4001413")]
			[FieldOffset(Offset = "0x3A")]
			public bool isWaitingForKey;

			// Token: 0x04001414 RID: 5140
			[Token(Token = "0x4001414")]
			[FieldOffset(Offset = "0x40")]
			public Action<int, string> onAnyKeyDown;

			// Token: 0x04001415 RID: 5141
			[Token(Token = "0x4001415")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__LoadDisplaySettingData;

			// Token: 0x04001416 RID: 5142
			[Token(Token = "0x4001416")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0__LoadKeyCodeData;

			// Token: 0x04001417 RID: 5143
			[Token(Token = "0x4001417")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__LoadGroupData;

			// Token: 0x04001418 RID: 5144
			[Token(Token = "0x4001418")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__LoadDefaultKeyCodeData;

			// Token: 0x04001419 RID: 5145
			[Token(Token = "0x4001419")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__LoadDefaultGroupData;

			// Token: 0x0400141A RID: 5146
			[Token(Token = "0x400141A")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__TryMoveLegacyData;

			// Token: 0x0400141B RID: 5147
			[Token(Token = "0x400141B")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__ResolveKeyIdConflicts;

			// Token: 0x0400141C RID: 5148
			[Token(Token = "0x400141C")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x0400141D RID: 5149
			[Token(Token = "0x400141D")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_GetFuncNameByFuncId;

			// Token: 0x0400141E RID: 5150
			[Token(Token = "0x400141E")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_CheckIfNormalBtnDisplay;

			// Token: 0x0400141F RID: 5151
			[Token(Token = "0x400141F")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_CheckIfActBtnDisplay;

			// Token: 0x04001420 RID: 5152
			[Token(Token = "0x4001420")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_SetNormalBtnDisplay;

			// Token: 0x04001421 RID: 5153
			[Token(Token = "0x4001421")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_SetActBtnDisplay;

			// Token: 0x04001422 RID: 5154
			[Token(Token = "0x4001422")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_SetFuncKey;

			// Token: 0x04001423 RID: 5155
			[Token(Token = "0x4001423")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_GetConflictFuncInSetting;

			// Token: 0x04001424 RID: 5156
			[Token(Token = "0x4001424")]
			[FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_GetKeyItemByFuncId;

			// Token: 0x04001425 RID: 5157
			[Token(Token = "0x4001425")]
			[FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_GetKeyItemByKeyId;

			// Token: 0x04001426 RID: 5158
			[Token(Token = "0x4001426")]
			[FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_GetShowBtnByGroupId;

			// Token: 0x04001427 RID: 5159
			[Token(Token = "0x4001427")]
			[FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_ResetAllSetting;

			// Token: 0x04001428 RID: 5160
			[Token(Token = "0x4001428")]
			[FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_TriggerIfAnyKeyDown;

			// Token: 0x04001429 RID: 5161
			[Token(Token = "0x4001429")]
			[FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0_GetKeyCodeList;

			// Token: 0x0400142A RID: 5162
			[Token(Token = "0x400142A")]
			[FieldOffset(Offset = "0xA8")]
			private static DelegateBridge __Hotfix0_GetVirtualButton;

			// Token: 0x0400142B RID: 5163
			[Token(Token = "0x400142B")]
			[FieldOffset(Offset = "0xB0")]
			private static DelegateBridge __Hotfix0_GetKeyId;

			// Token: 0x0400142C RID: 5164
			[Token(Token = "0x400142C")]
			[FieldOffset(Offset = "0xB8")]
			private static DelegateBridge __Hotfix0__GetConflictItemList;

			// Token: 0x0400142D RID: 5165
			[Token(Token = "0x400142D")]
			[FieldOffset(Offset = "0xC0")]
			private static DelegateBridge __Hotfix0__GetKeyItemByKeyCode;

			// Token: 0x0400142E RID: 5166
			[Token(Token = "0x400142E")]
			[FieldOffset(Offset = "0xC8")]
			private static DelegateBridge __Hotfix1__GetKeyItemByKeyCode;

			// Token: 0x0400142F RID: 5167
			[Token(Token = "0x400142F")]
			[FieldOffset(Offset = "0xD0")]
			private static DelegateBridge __Hotfix0__SaveKeyInfo;

			// Token: 0x04001430 RID: 5168
			[Token(Token = "0x4001430")]
			[FieldOffset(Offset = "0xD8")]
			private static DelegateBridge __Hotfix0__SaveBtnDisplayInfo;

			// Token: 0x04001431 RID: 5169
			[Token(Token = "0x4001431")]
			[FieldOffset(Offset = "0xE0")]
			private static DelegateBridge __Hotfix0__SetFuncKeyWithoutSave;

			// Token: 0x04001432 RID: 5170
			[Token(Token = "0x4001432")]
			[FieldOffset(Offset = "0xE8")]
			private static DelegateBridge __Hotfix0__AddKeyCodesFromGroup;

			// Token: 0x04001433 RID: 5171
			[Token(Token = "0x4001433")]
			[FieldOffset(Offset = "0xF0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
