using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.CharWord;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005B6 RID: 1462
	[Token(Token = "0x20005B6")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/CharWordDB")]
	[Serializable]
	public class CharWordDB : ConstTable<CharWordTable, CharWordDB>
	{
		// Token: 0x060060DB RID: 24795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060DB")]
		[Address(RVA = "0x1CE9700", Offset = "0x1CE8300", VA = "0x181CE9700", Slot = "15")]
		protected override void OnInit()
		{
		}

		// Token: 0x060060DC RID: 24796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060DC")]
		[Address(RVA = "0x1CE8D20", Offset = "0x1CE7920", VA = "0x181CE8D20")]
		public List<CharWordData> FliterCharWordData(VoiceQuery query, CharWordShowType showType, [Optional] List<CharWordData> resultBuffer)
		{
			return null;
		}

		// Token: 0x060060DD RID: 24797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060DD")]
		[Address(RVA = "0x1CE8DD0", Offset = "0x1CE79D0", VA = "0x181CE8DD0")]
		public List<CharWordData> FliterCharWordData(VoiceQuery query, CharWordShowType showType, DataUnlockType dataUnlockType, [Optional] List<CharWordData> resultBuffer)
		{
			return null;
		}

		// Token: 0x060060DE RID: 24798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060DE")]
		[Address(RVA = "0x1CEA090", Offset = "0x1CE8C90", VA = "0x181CEA090")]
		private void _FilterAllTypesOfCharWordData(VoiceQuery query, DataUnlockType dataUnlockType, List<CharWordData> result)
		{
		}

		// Token: 0x060060DF RID: 24799 RVA: 0x0002F7C0 File Offset: 0x0002D9C0
		[Token(Token = "0x60060DF")]
		[Address(RVA = "0x1CE9F10", Offset = "0x1CE8B10", VA = "0x181CE9F10")]
		private bool _CheckExtraVoiceLangValid(Dictionary<string, ExtraVoiceConfigData> extraVoiceData, VoiceQuery query, CharWordData charWord)
		{
			return default(bool);
		}

		// Token: 0x060060E0 RID: 24800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060E0")]
		[Address(RVA = "0x1CE8A70", Offset = "0x1CE7670", VA = "0x181CE8A70")]
		public List<CharWordData> FilterCharWordData(CharWordShowType showType, [Optional] List<CharWordData> resultBuffer)
		{
			return null;
		}

		// Token: 0x060060E1 RID: 24801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060E1")]
		[Address(RVA = "0x1CE9DB0", Offset = "0x1CE89B0", VA = "0x181CE9DB0")]
		public Dictionary<string, ListDict<CharWordShowType, List<CharWordData>>> ShowTypeSearchTable()
		{
			return null;
		}

		// Token: 0x060060E2 RID: 24802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060E2")]
		[Address(RVA = "0x1CE8C30", Offset = "0x1CE7830", VA = "0x181CE8C30")]
		public CharExtraWordData FindCharExWordData(string wordKey, string voiceId)
		{
			return null;
		}

		// Token: 0x060060E3 RID: 24803 RVA: 0x0002F7D8 File Offset: 0x0002D9D8
		[Token(Token = "0x60060E3")]
		[Address(RVA = "0x1CE9240", Offset = "0x1CE7E40", VA = "0x181CE9240")]
		public bool GetVoiceLangDataByWordKey(string wordKey, out VoiceLangData voiceLangData)
		{
			return default(bool);
		}

		// Token: 0x060060E4 RID: 24804 RVA: 0x0002F7F0 File Offset: 0x0002D9F0
		[Token(Token = "0x60060E4")]
		[Address(RVA = "0x1CE8980", Offset = "0x1CE7580", VA = "0x181CE8980")]
		public bool CheckWordKeyVoiceLangValid(VoiceLangType voiceLangType, string wordKey)
		{
			return default(bool);
		}

		// Token: 0x060060E5 RID: 24805 RVA: 0x0002F808 File Offset: 0x0002DA08
		[Token(Token = "0x60060E5")]
		[Address(RVA = "0x1CE8620", Offset = "0x1CE7220", VA = "0x181CE8620")]
		public bool CheckCharVoiceLangValid(VoiceQuery voiceQuery)
		{
			return default(bool);
		}

		// Token: 0x060060E6 RID: 24806 RVA: 0x0002F820 File Offset: 0x0002DA20
		[Token(Token = "0x60060E6")]
		[Address(RVA = "0x1CE84E0", Offset = "0x1CE70E0", VA = "0x181CE84E0")]
		public bool CheckCharRoleIsNew(string charId)
		{
			return default(bool);
		}

		// Token: 0x060060E7 RID: 24807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060E7")]
		[Address(RVA = "0x1CE9520", Offset = "0x1CE8120", VA = "0x181CE9520")]
		public string GetVoiceLangName(VoiceLangType voiceLangType)
		{
			return null;
		}

		// Token: 0x060060E8 RID: 24808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060E8")]
		[Address(RVA = "0x1CE9340", Offset = "0x1CE7F40", VA = "0x181CE9340")]
		public string GetVoiceLangGroupName(VoiceLangGroupType voiceLangGroupType)
		{
			return null;
		}

		// Token: 0x060060E9 RID: 24809 RVA: 0x0002F838 File Offset: 0x0002DA38
		[Token(Token = "0x60060E9")]
		[Address(RVA = "0x1CE90F0", Offset = "0x1CE7CF0", VA = "0x181CE90F0")]
		public VoiceLangType GetDefaultVoiceLangType()
		{
			return VoiceLangType.NONE;
		}

		// Token: 0x060060EA RID: 24810 RVA: 0x0002F850 File Offset: 0x0002DA50
		[Token(Token = "0x60060EA")]
		[Address(RVA = "0x1CE9E10", Offset = "0x1CE8A10", VA = "0x181CE9E10")]
		public bool TryGetDefaultVoiceLangType(string charId, out VoiceLangType defaultType)
		{
			return default(bool);
		}

		// Token: 0x060060EB RID: 24811 RVA: 0x0002F868 File Offset: 0x0002DA68
		[Token(Token = "0x60060EB")]
		[Address(RVA = "0x1CE9440", Offset = "0x1CE8040", VA = "0x181CE9440")]
		public VoiceLangGroupType GetVoiceLangGroupTypeByType(VoiceLangType voiceLangType)
		{
			return VoiceLangGroupType.NONE;
		}

		// Token: 0x060060EC RID: 24812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060EC")]
		[Address(RVA = "0x1CE9620", Offset = "0x1CE8220", VA = "0x181CE9620")]
		public List<VoiceLangType> GetVoiceLangTypeListByGroupType(VoiceLangGroupType groupType)
		{
			return null;
		}

		// Token: 0x060060ED RID: 24813 RVA: 0x0002F880 File Offset: 0x0002DA80
		[Token(Token = "0x60060ED")]
		[Address(RVA = "0x1CE8890", Offset = "0x1CE7490", VA = "0x181CE8890")]
		public bool CheckVoiceLangNeedDisplay(VoiceLangType voiceLangType)
		{
			return default(bool);
		}

		// Token: 0x060060EE RID: 24814 RVA: 0x0002F898 File Offset: 0x0002DA98
		[Token(Token = "0x60060EE")]
		[Address(RVA = "0x1CE87A0", Offset = "0x1CE73A0", VA = "0x181CE87A0")]
		public bool CheckVoiceGroupNeedDisplay(VoiceLangGroupType voiceLangGroupType)
		{
			return default(bool);
		}

		// Token: 0x060060EF RID: 24815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060EF")]
		[Address(RVA = "0x1CE9170", Offset = "0x1CE7D70", VA = "0x181CE9170")]
		public string GetLinkageVoicePath(string wordKey)
		{
			return null;
		}

		// Token: 0x060060F0 RID: 24816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060F0")]
		[Address(RVA = "0x1CEA430", Offset = "0x1CE9030", VA = "0x181CEA430")]
		public CharWordDB()
		{
		}

		// Token: 0x04002A5D RID: 10845
		[Token(Token = "0x4002A5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[NonSerialized]
		private Dictionary<string, ListDict<CharWordShowType, List<CharWordData>>> m_showTypeSeachTable;

		// Token: 0x04002A5E RID: 10846
		[Token(Token = "0x4002A5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[NonSerialized]
		private Dictionary<VoiceLangType, HashSet<string>> m_voiceLangSearchTable;

		// Token: 0x04002A5F RID: 10847
		[Token(Token = "0x4002A5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[NonSerialized]
		private Dictionary<string, string> m_linkagePathTable;

		// Token: 0x04002A60 RID: 10848
		[Token(Token = "0x4002A60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04002A61 RID: 10849
		[Token(Token = "0x4002A61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_FliterCharWordData;

		// Token: 0x04002A62 RID: 10850
		[Token(Token = "0x4002A62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix1_FliterCharWordData;

		// Token: 0x04002A63 RID: 10851
		[Token(Token = "0x4002A63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__FilterAllTypesOfCharWordData;

		// Token: 0x04002A64 RID: 10852
		[Token(Token = "0x4002A64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckExtraVoiceLangValid;

		// Token: 0x04002A65 RID: 10853
		[Token(Token = "0x4002A65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_FilterCharWordData;

		// Token: 0x04002A66 RID: 10854
		[Token(Token = "0x4002A66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ShowTypeSearchTable;

		// Token: 0x04002A67 RID: 10855
		[Token(Token = "0x4002A67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_FindCharExWordData;

		// Token: 0x04002A68 RID: 10856
		[Token(Token = "0x4002A68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetVoiceLangDataByWordKey;

		// Token: 0x04002A69 RID: 10857
		[Token(Token = "0x4002A69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CheckWordKeyVoiceLangValid;

		// Token: 0x04002A6A RID: 10858
		[Token(Token = "0x4002A6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CheckCharVoiceLangValid;

		// Token: 0x04002A6B RID: 10859
		[Token(Token = "0x4002A6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CheckCharRoleIsNew;

		// Token: 0x04002A6C RID: 10860
		[Token(Token = "0x4002A6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetVoiceLangName;

		// Token: 0x04002A6D RID: 10861
		[Token(Token = "0x4002A6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetVoiceLangGroupName;

		// Token: 0x04002A6E RID: 10862
		[Token(Token = "0x4002A6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetDefaultVoiceLangType;

		// Token: 0x04002A6F RID: 10863
		[Token(Token = "0x4002A6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_TryGetDefaultVoiceLangType;

		// Token: 0x04002A70 RID: 10864
		[Token(Token = "0x4002A70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetVoiceLangGroupTypeByType;

		// Token: 0x04002A71 RID: 10865
		[Token(Token = "0x4002A71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_GetVoiceLangTypeListByGroupType;

		// Token: 0x04002A72 RID: 10866
		[Token(Token = "0x4002A72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_CheckVoiceLangNeedDisplay;

		// Token: 0x04002A73 RID: 10867
		[Token(Token = "0x4002A73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_CheckVoiceGroupNeedDisplay;

		// Token: 0x04002A74 RID: 10868
		[Token(Token = "0x4002A74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GetLinkageVoicePath;

		// Token: 0x04002A75 RID: 10869
		[Token(Token = "0x4002A75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
